
using Mars;

namespace MarsUpdated;
[Binding]
public class AddLanguageStepDefinition
{
    AddLanguage AL;

    public AddLanguageStepDefinition()
    {
        AL = new AddLanguage();
    }

    [When(@"User adds '([^']*)' and a '([^']*)'")]
    public void WhenUserAddsAndA(string language, string languageLevel)
    {
        AL.CreateLanguage(language, languageLevel);
    }

    [Then(@"The '([^']*)' and '([^']*)' should be added successfully")]
    public void ThenTheAndShouldBeAddedSuccessfully(string language, string languageLevel)
    {
        AL.CheckLanguageAdded(language, languageLevel);
    }

}
