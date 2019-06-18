using System;
using TechTalk.SpecFlow;
using LibreriaNomina;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PruebaNomina
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        cslUsuarios usuarios = new cslUsuarios();
        string constraseña = "";
        int resultado = 0;
        [Given(@"Yo capturo el nombre de usuario ""(.*)""")]
        public void GivenYoCapturoElNombreDeUsuario(string p0)
        {
            usuarios.login = p0;
        }
        
        [Given(@"Yo capturo la contraseña ""(.*)""")]
        public void GivenYoCapturoLaContrasena(string p0)
        {
            constraseña = p0;
        }

        [When(@"Yo presiono el boton de aceptar")]
        public void WhenYoPresionoElBotonDeAceptar()
        {
            resultado = usuarios.loginAcceso(constraseña);         
        }
        
        [Then(@"El resultado es (.*)")]
        public void ThenElResultadoEs(int p0)
        {
  
            Assert.AreEqual(p0, resultado);
        }

        [Then(@"El resultado esperado es (.*)")]
        public void ThenElResultadoEsperadoEs(int p0)
        {
            Assert.AreEqual(p0, resultado);
        }

        [Then(@"El resultado de ello es (.*)")]
        public void ThenElResultadoDeElloEs(int p0)
        {
            Assert.AreEqual(p0, resultado);

        }

    }
}
