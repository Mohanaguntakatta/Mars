
namespace MarsUpdated;
[Binding]
public class AddSkillStepDefinition
{
    AddSkillPage ASP;

    public AddSkillStepDefinition()
    {
        ASP= new AddSkillPage();    
    }

    [When(@"User adds a '([^']*)' and a '([^']*)'")]
    public void WhenUserAddsANewSkillAndSkillLevel(string skill, string skillLevel)
    {
        ASP.CreateSkills(skill,skillLevel);
    }

    [Then(@"'([^']*)' and '([^']*)' should be added successfully")]
    public void ThenNewSkillShouldBeAddedSuccessfully(string skill, string skillLevel)
    {
        ASP.CheckSkillAdded(skill,skillLevel);
    }

}
