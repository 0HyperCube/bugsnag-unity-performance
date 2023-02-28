Feature: Manual creation of spans

  Background:
    Given I clear the Bugsnag cache

  Scenario: Manual spans can be logged
    When I run the game in the "ManualSpan" state
    And I wait for 1 span
    Then the trace Bugsnag-Integrity header is valid
    And the trace "Bugsnag-Api-Key" header equals "a35a2a72bd230ac0aa0f52715bbdc6aa"
    * the trace payload field "resourceSpans.0.resource" string attribute "deployment.environment" equals "production"