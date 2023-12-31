(ns mermaid-processor.lhasa-validate-test
  (:require [clojure.test :refer :all]
            [mermaid-processor.behaviors.regex_based :as behavior]
            [mermaid-processor.parse :as parse]
            [mermaid-processor.behaviors.libraries.core :as core]
            [mermaid-processor.behaviors.utils :as utils]
            [mermaid-processor.process :as process]
            [clojure.java.io :as io]))

;; These tests show are from https://github.com/jmaes12345/lhasa-kata

(def mermaid 
  (slurp 
   (io/resource "resources/lhasa/flowchart.mermaid")))

(def lhasa-chart 
  (parse/parse-mermaid mermaid))

;; Example of how to get the missing functions
(deftest complex-chart-test
  (testing "valdate lhasa chart"
    (let [ex (try
               (behavior/build {} lhasa-chart {})
               (catch clojure.lang.ExceptionInfo e e))]
      (is (= (set ["Set SVG" "Require SVG" "Proceed?" "Any ellipse with height >=50?" "Score 1" "Score 2" "Any ellipses?" "Any rectangle with area >= 300?" "Score 3" "Any straight lines?" "Radius larger than 100?" "Radius larger than 50?" "Only blue circles?" "Any text?" "Any Red Circles" "Total element count > 5?" "Any rectangles or squares?" "Text containing the sequence 'Lhasa'?" "Any elements with opacity less than 1?" "More than one element in the file?" "Every line longer than 100?" "Rectangle green?" "Yes" "No"])
             (set ((ex-data ex) :missing))))
      (is (= 24 (count ((ex-data ex) :missing)))))))


;; Example of how to convert the missing functions to an action map
(deftest generates-missing-example-map-test
  (testing "Generate an example mapping from the missing actions"
    (let [ex (try
               (behavior/build {} lhasa-chart {})
               (catch clojure.lang.ExceptionInfo e e))
          expected-value
          [{:regex #"(?i)^\s*Any ellipse with height \s*(>=|<=|>|<|==|!=|=|larger than|smaller than|greater than|less than|longer than|shorter than|larger than or equals|smaller than or equals|greater than or equals|less than or equals|longer than or equals|shorter than or equals|larger than or equal to|smaller than or equal to|greater than or equal to|less than or equal to|longer than or equal to|shorter than or equal to)\s*([^?]+)[\s\?]*\s*$", :action [:your-library-here :any-ellipse-with-height :%1 :%2]}
           {:regex #"(?i)^\s*Score 1[\?]?\s*$", :action [:your-library-here :your-function-name-here]}
           {:regex #"(?i)^\s*Score 2[\?]?\s*$", :action [:your-library-here :your-function-name-here]}
           {:regex #"(?i)^\s*Any ellipses[\?]?\s*$", :action [:your-library-here :your-function-name-here]}
           {:regex #"(?i)^\s*Any rectangle with area \s*(>=|<=|>|<|==|!=|=|larger than|smaller than|greater than|less than|longer than|shorter than|larger than or equals|smaller than or equals|greater than or equals|less than or equals|longer than or equals|shorter than or equals|larger than or equal to|smaller than or equal to|greater than or equal to|less than or equal to|longer than or equal to|shorter than or equal to)\s*([^?]+)[\s\?]*\s*$", :action [:your-library-here :any-rectangle-with-area :%1 :%2]}
           {:regex #"(?i)^\s*Score 3[\?]?\s*$", :action [:your-library-here :your-function-name-here]}
           {:regex #"(?i)^\s*Any straight lines[\?]?\s*$", :action [:your-library-here :your-function-name-here]}
           {:regex #"(?i)^\s*Radius \s*(>=|<=|>|<|==|!=|=|larger than|smaller than|greater than|less than|longer than|shorter than|larger than or equals|smaller than or equals|greater than or equals|less than or equals|longer than or equals|shorter than or equals|larger than or equal to|smaller than or equal to|greater than or equal to|less than or equal to|longer than or equal to|shorter than or equal to)\s*([^?]+)[\s\?]*\s*$", :action [:your-library-here :radius :%1 :%2]}
           {:regex #"(?i)^\s*Only blue circles[\?]?\s*$", :action [:your-library-here :your-function-name-here]}
           {:regex #"(?i)^\s*Any text[\?]?\s*$", :action [:your-library-here :your-function-name-here]}
           {:regex #"(?i)^\s*Any Red Circles[\?]?\s*$", :action [:your-library-here :your-function-name-here]}
           {:regex #"(?i)^\s*Total element count \s*(>=|<=|>|<|==|!=|=|larger than|smaller than|greater than|less than|longer than|shorter than|larger than or equals|smaller than or equals|greater than or equals|less than or equals|longer than or equals|shorter than or equals|larger than or equal to|smaller than or equal to|greater than or equal to|less than or equal to|longer than or equal to|shorter than or equal to)\s*([^?]+)[\s\?]*\s*$", :action [:your-library-here :total-element-count :%1 :%2]}
           {:regex #"(?i)^\s*Any rectangles or squares[\?]?\s*$", :action [:your-library-here :your-function-name-here]}
           {:regex #"(?i)^\s*Set SVG[\?]?\s*$", :action [:your-library-here :your-function-name-here]}
           {:regex #"(?i)^\s*Require SVG[\?]?\s*$", :action [:your-library-here :your-function-name-here]}
           {:regex #"(?i)^\s*Text containing the sequence 'Lhasa'[\?]?\s*$", :action [:your-library-here :your-function-name-here]}
           {:regex #"(?i)^\s*Any elements with opacity \s*(>=|<=|>|<|==|!=|=|larger than|smaller than|greater than|less than|longer than|shorter than|larger than or equals|smaller than or equals|greater than or equals|less than or equals|longer than or equals|shorter than or equals|larger than or equal to|smaller than or equal to|greater than or equal to|less than or equal to|longer than or equal to|shorter than or equal to)\s*([^?]+)[\s\?]*\s*$", :action [:your-library-here :any-elements-with-opacity :%1 :%2]}
           {:regex #"(?i)^\s*More than one element in the file[\?]?\s*$", :action [:your-library-here :your-function-name-here]}
           {:regex #"(?i)^\s*Every line \s*(>=|<=|>|<|==|!=|=|larger than|smaller than|greater than|less than|longer than|shorter than|larger than or equals|smaller than or equals|greater than or equals|less than or equals|longer than or equals|shorter than or equals|larger than or equal to|smaller than or equal to|greater than or equal to|less than or equal to|longer than or equal to|shorter than or equal to)\s*([^?]+)[\s\?]*\s*$", :action [:your-library-here :every-line :%1 :%2]}
           {:regex #"(?i)^\s*Rectangle green[\?]?\s*$", :action [:your-library-here :your-function-name-here]}
           {:regex #"(?i)^\s*(Yes|True|Is True)[\?]?\s*$", :action [:core :last-result-is-true]}
           {:regex #"(?i)^\s*(No|False|Is False|Is Not True)[\?]?\s*$", :action [:core :last-result-is-not-true]}
           {:regex #"(?i)^\s*Proceed[\?]?\s*$", :action [:your-library-here :your-function-name-here]}]
          actual-value ((ex-data ex) :example-map)]
      #_(prn actual-value)
      (doseq [[expected actual] (map vector expected-value actual-value)]
        (is (= (.pattern (expected :regex)) (.pattern (actual :regex))))
        (is (= (expected :action) (actual :action)))))))