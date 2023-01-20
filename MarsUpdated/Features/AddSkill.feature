Feature: AddSkill

Adding a user skill for the profile

Background: Logging in to portal
    Given The user is logged in to portal

Scenario Outline: Add new Skill
    When User adds a '<Skill>' and a '<SkillLevel>'
    Then '<Skill>' and '<SkillLevel>' should be added successfully

    Examples: 
    | Skill    | SkillLevel   |
    | Java     | Beginner     |
    | Specflow | Expert       |
    | Nunit    | Intermediate |
