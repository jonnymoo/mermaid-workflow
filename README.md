# mermaid-workflow
A project which aims to allow runnable user centric workflow described by mermaid diagrams

# Context
[Mermaid diagrams](https://mermaid.js.org/) is tool to create complex diagrams in simple markdown. Its main purpose is to help documentation catch-up with development.

# Problem statement
I would like to describe how work flows in a simple diagram.

This could be for:
- My own simple to do list of work.
- A repeatable pattern / process of work for use in an organisation.
- To describe how services to end users work and how work flows between consumers of the service and the organisations which are required to fulfil the service e.g. [Service design](https://gds.blog.gov.uk/2016/04/18/what-we-mean-by-service-design/) 

# Constraints and Criteria
I would like to be able to describe my workflow as simply as possible in a mermaid diagram.
I want the diagram to be "test-able / run-able" with as little (ideally no) effort as possible.

# Solution concepts
```mermaid
journey
    title A simple workflow
    section Implement Simplest Workflow
      Create an API: 5: Me
      Create a Work Tray: 3: Me
    section Persistence
      Create backing stores: 5: Me
    section User Testing
      Observation: 5: Janey
```
### Bugs and Issues

...

## Design guidelines

Use TDD to implement a modular / composable design that promotes simplicity over complexity

Order function parameters by specificity (general to specific), e.g. my-function [context behavior item]

Aim towards a DDD like Ubiquitous Language. This means entities should use real life terms from the business / user domain. This language should be refleced in the code. And on language, a decision has been made to not use british english, but stick with american english, e.g. Behavoir, not behavoir. This is simply to make it consitent with other code bases.

```mermaid
C4Container
    title Container diagram for Workflow Automation System

    Person_Ext(user, "User", "Uses the WorkflowUI to interact with the system.")

    System_Boundary(workflowSys, "Workflow System") {
        Container(webUI, "WorkflowUI", "Web Application", "Provides a reference front-end for the workflow.")
        Container(webAPI, "WorkflowAPI", "Web API", "Handles the business logic and data processing for workflows.")
        ContainerDb(clojars, "Clojars", "Artifact Repository", "Stores the Clojure libraries used in the system.")
        Container(mermaidLib, "mermaid-processing", "Clojure Library", "Processes and renders diagrams.")
    }

    Rel(user, webUI, "Uses", "HTTP/HTTPS")
    Rel(webUI, webAPI, "Sends requests to", "HTTP/HTTPS")
    Rel(webAPI, clojars, "Fetches libraries from")
    Rel(webAPI, mermaidLib, "Uses for diagram processing")

    UpdateElementStyle(user, $fontColor="blue")
    UpdateRelStyle(webUI, webAPI, $textColor="green", $lineColor="green")
    UpdateRelStyle(webAPI, clojars, $textColor="purple", $lineColor="purple")
    UpdateRelStyle(webAPI, mermaidLib, $textColor="orange", $lineColor="orange")
```
```mermaid
C4Component
    title Component diagram for mermaid-processing library

    Boundary(mermaidLib, "mermaid-processing") {
        Component(context, "Context", "Stores the state of the running workflow, current node, and other state required by conditions or actions.")
        Component(behavior, "Behavior", "Specifies actions and conditions. Can modify the Context.")
        Component(chart, "Chart", "Represents the parsed Mermaid diagram.")
    }

    Rel(behavior, context, "Modifies")
    Rel(behavior, chart, "Reads state from")
    Rel(chart, context, "Updates state in")
```