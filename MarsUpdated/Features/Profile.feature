Feature: Profile

As a seller
I want the feature to add my profile
So that 
Seller's are able to see the details on the Profile page

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
  
	@ignore
    Scenario Outline: Seller is able to edit Skills details
	Given Edit existing '<Skills>' and '<SkillLevel>' on profile
	Then The '<Skills>' and '<SkillLevel>'skill edit should be updated successfully

	Examples: 
	| Skills | Skill Level |
	| Java   | Expert      |

	@ignore
    Scenario:Seller is able to delete Skills details
	Given Delete existing Skills
	Then Skills should be deleted successfully

    @ignore
    Scenario:Verify validation error for Skills tab
	Given Left Skills field as blank
	Then Error message should be displayed for skills

	@ignore
	Scenario Outline: Negative testing with valid input for add skills
	Given Add existing '<Skills>' and '<SkillLevel>' on profile
	Then Error message should be displayed for skills

	Examples: 
	| Skills | Skill Level | Popup error message                            |
	| Java   | Expert      | This skill is already exist in your skill list |


	Scenario Outline: Add new Language
    When User adds '<Language>' and a '<LanguageLevel>'
    Then The '<Language>' and '<LanguageLevel>' should be added successfully

    Examples: 
    | Language | LanguageLevel  |
    | English  | Basic          |
    | Tamil    | Conversational |
    | Kannada  | Fluent         |

    @ignore
    Scenario Outline: Seller is able to edit Language deatails
	Given Add new '<language>' and '<level>' language to the profile
	Then '<language>'and '<level>' should be updated successfully

	Examples: 
	| Languages | Level  |
	| English   | Fluent |

    @ignore
    Scenario: Seller is able to delete Language deatails
	Given Delete the existing Language deatails
	Then  Language deatails should be deleted successfully

    @ignore
    Scenario: Verify validation error for Language tab
	Given Left Language Field blank
	Then Error message should be displayed 

	Scenario Outline: Add new Certification
    When User adds a '<Certificate>', '<From>' and a '<Year>'
    Then '<Certificate>', '<From>' and a '<Year>' should be added successfully
    
    Examples: 
    | Certificate | From             | Year |
    | Istqb       | Istqb Foundation | 2022 |
    | Scrum       | Scrum Alliance   | 2023 |

	@ignore
    Scenario Outline: seller is able to edit the Certifications details
	Given Edit existing '<Certifications>','<CertificateFrom>' and '<Year>' to profile
	Then '<Certifications>','<CertificateFrom>' and '<Year>' details should be added successfully

	Examples: 
	| Certifications | CertificateFrom   | Year |
	| Istqb Advance  | ISTQB  Foundation | 2023 |

	@ignore
	Scenario: Seller is able to delete Certifications details
	Given Delete Certifications details
	Then Certifications details should be deleted successfully

	@ignore
	Scenario: Verify validation error for Certifications tab
	Given Left Certifications field as blank
	Then Following error message should be displayed

	@ignore
	Scenario: Seller is able to add description on profile
	Given I provide the description as "My name is Mohana,i would love to work in IT field."
	Then The description details should be added successfully

	@ignore
	Scenario:Seller is able to edit description on the Profile
	Given Edit the description as "Hi, i would love to listen music and do dancing during free times."
	Then The description details should be added successfully

	@ignore
	Scenario:Seller is unable to save when the description is empty on the Profile
	Given Delete the description and save
	Then Error message (Please, a description is required) should be displayed

	@ignore
	Scenario Outline:Verify validation error for Description field 
	Given Enter special characters or leave the Description box blank
	Then Following error messages should be displayed

	Examples: 
	| Description | Popup Error message                          |
	| *&          | First character can only be digit or letters |
	|             | "Please, a description is required"          |

	@ignore
	Scenario Outline: Seller is able to add the Availability on profile 
	Given Add '<Availability>','<Hours>' and '<Earn Target>' to profile details
	Then '<Availability>','<Hours>' and '<Earn Target>' should be added successfully

	Examples: 
	| Availability | Hours         | Earn Target                      |
	| Part Time    | As needed     | Between $500 and $1000 per month |

	@ignore
	Scenario Outline: Seller is able to edit the Availability on profile 
	Given Edit '<Availability>','<Hours>' and '<Earn Target>' to profile details
	Then '<Availability>','<Hours>' and '<Earn Target>' should be added successfully

	Examples: 
	| Availability | Hours                    | Earn Target               |
	| Full Time    | More than 30hours a week | More than $1000 per month |

	@ignore
	Scenario Outline: Seller is able to add Education details
	Given Added new '<Country>''<University>' '<Title>' '<Degree>' and '<Graduation Year>" to the profile
	Then '<Country>''<University>' '<Title>' '<Degree>' and '<Graduation Year>" should be added successfully

	Examples: 
	| Country | University | Title  | Degree     | Graduation Year |
	| USA     | American   | B.Tech | Bachelor's | 2022            |


	@ignore
	Scenario Outline: Seller is able to edit Education details
	Given Edit existing '<Country>''<University>' '<Title>' '<Degree>' and '<Graduation Year>" on profile
	Then '<Country>''<University>' '<Title>' '<Degree>' and '<Graduation Year>" should be updated successfully

	Examples: 
	| '<Country | University | Title  | Degree   | Graduation |
	| Australia | Victoria   | M.Tech | Master's | 2023       |

	@ignore
	Scenario:Seller is able to delete Education details
	Given Delete existing Skills
	Then Skills should be deleted successfully

	@ignore
	Scenario:Verify validation error for Education tab
	Given Left Skills field as blank
	Then Error message should be displayed 


