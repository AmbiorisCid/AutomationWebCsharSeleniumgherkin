Feature: Redirecciones PT

Scenario Outline: Consultar los 5 modulos PT
	Given the user navigate the web page <Page_Web>
	When the user enter usuario <Username>
	When the user click button 
	When digit password <password>
	When the user again click button
	When keep me signed in
	Then the user should see that he logged in corretly
	When click in Sin gestionar
	When click in En gestion
	When click in Autorizados
	When click in Solicitud de vigencia
	When click in Vigencia solicitud cancelacion



Examples:
|Page_Web									|Username							|password		|
|https://colbun.sharepoint.com/sites/PT_Test|srv_qas-automatizacion@colbun.cl	|CleverIT.2023	|