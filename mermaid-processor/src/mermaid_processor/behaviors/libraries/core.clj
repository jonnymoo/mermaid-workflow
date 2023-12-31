(ns mermaid-processor.behaviors.libraries.core
  "Core library for behaviors, providing basic actions like setting numbers, comparisons, and checking results."
  (:require [mermaid-processor.behaviors.utils :as utils]
            [clojure.data.xml :as xml]))

(defn- ensure-value [context v]
  (if (and (keyword? v) (= "field" (namespace v)))
    (utils/get-field-value context (name v))
    v))


;; All actions return a new context and a result as a map
(def actions
  "A map of core action functions.
   
   :set-field [field-name field-type value]
   
   Sets a value to a specified field in the context.
   
   ARGUMENTS:
   - field-name: The name of the field in the context where the number will be set.
   - field-type: The type of the field can be one of
     - :number - The value will be cast to a double
     - :string
     - :xml - Uses xml/parse-str to convert a string to xml
   - value: The value to set or a keyword e.g. :required

   :compare [field-name comparator value]
   
   Compares a field value with a given value using a specified comparator.
   
   ARGUMENTS:
   - field-name: The name of the field in the context to compare.
     - :all-fields as field name will comare all fields. Particulary useful for :all-fields \"<>\" :required to check that all required fields have been presented
   - comparator: The comparison operator (e.g., '>').
   - value: The value to compare against.

   :last-result-is-true

   Checks if the last result in the context is true.
   
   :last-result-is-not-true

   Checks if the last result in the context is not true
     
  :do-nothing

   What it says. Just returns the context as is.
   "
   {:set-field
   (fn [field-name field-type value]
     (fn [context]
       (let [value (ensure-value context value)
             parsed-value
             (if (keyword? value)
               value
               (case field-type
                 :string value
                 :number (Double/parseDouble value)
                 :xml (xml/parse-str value)))]
         {:context (utils/set-field-value context field-name parsed-value)
          :result parsed-value
          :audit {:set-field field-name}})))
   :compare
   (fn [field-name comparator rhs-value]
     (case field-name
       :all-fields
       (fn [context]
         {:context context
          :result (every? (fn [[_ v]]
                            (utils/apply-comparator v comparator rhs-value))
                          (context :fields))
          :audit {:compare [field-name comparator rhs-value]}})
       (fn [context]
         (let [lhs-value (utils/get-field-value context field-name)]
           {:context context
            :result (utils/apply-comparator
                     lhs-value
                     comparator
                     rhs-value)
            :audit {:compare [field-name lhs-value comparator rhs-value]}}))))
   :last-result-is-true
   (fn []
     (fn [context]
       {:context context
        :result (if (utils/get-last-result context) true false)}))
   :last-result-is-not-true
   (fn []
     (fn [context]
       {:context context
        :result (if (utils/get-last-result context) false true)}))
   :do-nothing
   (fn []
     (fn [context]
       {:context context
        :result true}))})