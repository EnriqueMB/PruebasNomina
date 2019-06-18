Feature: SpecFlowFeature1
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Nombre de usuario no existe
	Given Yo capturo el nombre de usuario "marcos1"
	And Yo capturo la contraseña "expea"
	When Yo presiono el boton de aceptar
	Then El resultado esperado es -1

Scenario: Contraseña no existe
	Given Yo capturo el nombre de usuario "marcos"
	And Yo capturo la contraseña "expea1"
	When Yo presiono el boton de aceptar
	Then El resultado de ello es -2

Scenario: Usuario aceptado 
	Given Yo capturo el nombre de usuario "marcos"
	And Yo capturo la contraseña "expea"
	When Yo presiono el boton de aceptar
	Then El resultado es 1