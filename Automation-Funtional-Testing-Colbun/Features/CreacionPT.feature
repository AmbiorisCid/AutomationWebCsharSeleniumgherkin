Feature: Creacion PT

Scenario Outline: Creación PT planificación de la faena
	Given the user navigate the web page <Page_Web>
	When the user enter usuario <Username>
	When the user click button 
	When digit password <password>
	When the user again click button
	When keep me signed in
	Then the user should see that he logged in corretly
	When user click in CrearPt
	When too click PT instalacion
	When click in tipo personal
	When select State Instal
	When press dropDonw central
	When Digit the consult <Central>
	When select DropDonw PT
	When Consult DropDonw PT <PuestoT>
	When Insert text in instalation <Instalacion>
	When Digit datetime Owner <FechaDesde>
	When set the time from <TiempoDesde>
	When Digit until datetime <FechaHasta>
	When set the timeHasta <TiempoHasta>
	When Digit text wordkDo <Trabajo> 
	When Insert location for <Ubicacion>
	When Press button save
	Then User validet the saved <MensajeP>


Examples:
|Page_Web									|Username							|password		|Central|PuestoT	 |Instalacion					 |FechaDesde|TiempoDesde|FechaHasta|TiempoHasta|Trabajo									|Ubicacion								 |MensajeP												 |
|https://colbun.sharepoint.com/sites/PT_Test|srv_qas-automatizacion@colbun.cl	|CleverIT.2023	|Colbún |Operaciones |Esto es un comentario de prueba|10        |1015		|24        |1112       |Colocar una descripcion breve de trabajo|La faena se encuentra en la calle pepito|El PT fue actualizado de forma exitosa. El ID del PT es|
