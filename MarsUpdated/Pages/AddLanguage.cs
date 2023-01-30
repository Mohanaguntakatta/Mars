
using MarsUpdated;

namespace Mars;

public class AddLanguage : CommonDriver
{
    // Wait  inside the constructor

        public WebDriverWait wait;
        public AddLanguage()
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
        }


    // Implemented the POM pattern
        public IWebElement LanguageButton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
        public IWebElement LanguageAddButton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
        public IWebElement LanguageTextbox => driver.FindElement(By.Name("name"));
        public IWebElement ClickAddButton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
        public IWebElement LanguageButton1 => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));

        public void CreateLanguage(string Language, string LanguageLevel)
    {
        // Identify Language button and click and using explicit waits to locate elements
        wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]")));
        LanguageButton.Click();

        // Identify Add new button and click
        wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div")));    
        LanguageAddButton.Click();

        // Identify Add Language textbox and enter valid input       
        LanguageTextbox.SendKeys(Language);

        SelectElement LanguagelevelDropdown = new SelectElement(driver.FindElement(By.Name("level")));
        LanguagelevelDropdown.SelectByValue(LanguageLevel);

        // Identify Add button and click
        wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]")));
       
        ClickAddButton.Click();
        // Identify Language button and click and using explicit waits to locate elements
        wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]")));
      
        LanguageButton1.Click();


    }
    public void CheckLanguageAdded(string language, string languageLevel)
    {

        //boolean value to check if the language is added for assertion
        bool langugeAdded = false;
        //reading all the columns from the table
        ReadOnlyCollection<IWebElement> elements;
        wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.TagName("td")));
        elements = driver.FindElements(By.TagName("td"));
        for (int i = 0; i < elements.Count; i++)
        {
            //checking to see if the value of language is added to any column in the table
            if (elements[i].Text == language)
            {
                //true if language present
                langugeAdded = true;
                break;
            }
        }
        //fluent assertions. True if language added
        langugeAdded.Should().BeTrue();
    }
}
