Feature: Verifying VSCode Steps Binding                       i
As a VS code user I want to verify

that I am able to generate SpecFlow steps definiton

in VS Code

@newtest

Scenario: Verify Steps Defition generation

Given VS Code is open

And user has opened the specflow "SampleProject" in VS code

When user try to run the test

Then binding file should get generated in terminal window
