
using Mars;

namespace MarsUpdated;
[Binding]
public class AddCertificationStepDefinition
{
    AddCertification AC;

    public AddCertificationStepDefinition()
    {
        AC = new AddCertification();
    }

    [When(@"User adds a '([^']*)', '([^']*)' and a '([^']*)'")]
    public void WhenUserAddsAAndA(string certificate, string from, string year)
    {
        AC.CreateCertification(certificate, from, year);
    }

    [Then(@"'([^']*)', '([^']*)' and a '([^']*)' should be added successfully")]
    public void ThenAndAShouldBeAddedSuccessfully(string certificate, string from, string year)
    {
        AC.CheckCertificationAdded(certificate, from, year);
    }

}
