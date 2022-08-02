Feature: TideWebApplication Feature
	Tide web Apllication

@Contactus
Scenario:To Verify ContactUs display
	Given Load the WebApplication for ContactUs 
	When WebApplication load click on the contactUs
	Then ContactUs get displayed take screenshot


@HowToWashClothes
Scenario: To verify How To Wash Clothes button
	Given Load the WebApplication for How To wash Clothes
	When WebApplication Load Click on How To wash clothes
	And How to wash clothes get displayed take screenshot


@Register
Scenario:To verify Tide page Register 
	Given Load the WebApplication for Register 
	When WebApplication load click on Register 
	Then Click on Sign Up Now
	And Signin displayed take screenshot

@Login  
Scenario: To verify the login page
	Given Load the webApplication for login page
	When WebApplication load click on the Login
	Then write user details 
	And click on login button
	And Login successfully take the screenshot

@LiveChat
Scenario:To Verify Live Chat display
	Given Load the WebApplication for LiveChat
	When WebApplication load click on live chat
	Then scroll to live chat
	And Live Chat displayed take Screenshot


@Selectaloction
Scenario: To Verify  Select a loction display
	Given Load the WebApplication for Select a loction
	When WebApplication Load Click on Langauge
	Then popup should open and choose Langauge
	And Language get changed take screenshot

@SearchBar
Scenario:To Verify Search Bar
	Given Load the WebApplication for Search Bar 
	When WebApplication load click on Search Bar
	Then enter product name in search Bar 
	And Result screen displayed take screenshot 

 
@ShopProducts
Scenario:To Verify Shop products option
	Given Load the WebApplication for ShopProducts
	When WebApplication load click on shop products
	Then Select available product 
	And click on find retailers
	And Retailers screen take screenshot

@OurCommitment
Scenario:To verify the our commitment option
	Given Load the WebApplication for OurCommitment
	When WebApplication load click on Our Commitment
	Then Scroll to Our Ambition option
	And our ambition displayed take screenshot


@WhatsNew
Scenario:To Verify What's New 
	Given Load the WebApplication for WhatsNew
	When WebApplication load click on the whats new
	And latest articles screen take screenshot






