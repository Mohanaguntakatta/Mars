
using MarsUpdated;

namespace Mars;

public class AddCertification : CommonDriver
{
    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
    public void CreateCertification(string Certificate, string From, string Year)
    {
        // Identify Certification button and click
        wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]")));
        IWebElement CertificationButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
        CertificationButton.Click();

        // Identify Add new button and click
        wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div")));
        IWebElement CertificationAddNew = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
        CertificationAddNew.Click();

        // Identify ceritificate or award textbox and enter valid input
        IWebElement CertificateTextbox = driver.FindElement(By.Name("certificationName"));
        CertificateTextbox.SendKeys(Certificate);

        // Identify ceritified from textbox and enter valid input
        IWebElement CertifiedFromTextbox = driver.FindElement(By.Name("certificationFrom"));
        CertifiedFromTextbox.SendKeys(From);

        // Identify year dropdown box
        SelectElement CertificationlevelDropdown = new SelectElement(driver.FindElement(By.Name("certificationYear")));
        CertificationlevelDropdown.SelectByValue(Year);

        // Identify add button and click
        wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]")));
        IWebElement CertificationAddButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]"));
        CertificationAddButton.Click();

        // Check if user is able to add certifications succesfully 
    }
    public void CheckCertificationAdded(string certificate, string from, string year)
    {
        //boolean value to check if the certification is added for assertion
        bool certificationAdded = false;
        //reading all the columns from the table
        ReadOnlyCollection<IWebElement> elements;
        wait.Until(ExpectedConditions.ElementIsVisible(By.TagName("td")));
        elements = driver.FindElements(By.TagName("td"));
        for (int i = 0; i < elements.Count; i++)
        {
            //checking to see if the value of certification is added to any column in the table
            if (elements[i].Text == certificate)
            {
                //true if certification present
                certificationAdded = true;
                break;
            }
        }
        //fluent assertions. True if certification added
        certificationAdded.Should().BeTrue();
    }
}