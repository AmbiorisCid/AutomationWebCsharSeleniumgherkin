Feature: Login PT

Scenario Outline: Login Correcto PT
	Given the user navigate the web page <Page_Web>
	When the user enter usuario <Username>
	When the user click button 
	When digit password <password>
	When the user again click button
	When keep me signed in
	Then the user should see that he logged in corretly

Examples:
|Page_Web									|Username							|password		|
|https://colbun.sharepoint.com/sites/PT_Test|srv_qas-automatizacion@colbun.cl	|CleverIT.2023	|