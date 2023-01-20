global using TechTalk.SpecFlow;
global using FluentAssertions;
global using OpenQA.Selenium;
global using OpenQA.Selenium.Chrome;
global using System.Collections.ObjectModel;
global using OpenQA.Selenium.Support.UI;
global using SeleniumExtras.WaitHelpers;

namespace MarsUpdated;
[Binding]
public class CommonDriver
{
    public static IWebDriver driver;


    //teardown method is called automatically by specflow hooks after every scenario
    [AfterScenario]
    public void shutDown()
    {
        driver.Quit();
    }
}
