using System;                                                                      
 namespace CalculatorSelenium.Specs.StepDefinitions
 {                                                                             -
       [Binding]
      public class VSCodeSteps
          private readonly ScenarioContext _scenarioContext;
           public VSCodeSteps(ScenarioContext scenarioContext)
                {
              _scenarioContext = scenarioContext;
              }
          [Given(@"VS Code is open")]
          public void GivenVSCodeIsOpen()
              {
               //_scenarioContext.Pending();
              }
          [Given(@"user has opened the specflow ""(.%)"" in VS code")]
          public void GivenUserHasOpenedTheSpecflowInVSCode(string sampleProject®)
              {
              // _scenarioContext.Pending();
              }
          [When(@"user try to run the test")]
          public void WhenUserTryToRunTheTest()
              {
              // _scenarioContext.Pending();
              }
          [Then(@"binding file should get generated in terminal window")]
           public void ThenBindingFileShouldGetGeneratedInTerminalWindow()
              {
               //_scenarioContext.Pending();
              }
}