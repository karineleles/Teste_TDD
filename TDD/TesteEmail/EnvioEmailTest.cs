using TDD;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TesteEmail
{
    
    
    [TestClass()]
    public class EnvioEmailTest
    {


        private TestContext testContextInstance;

        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        


        
              
        [TestMethod()]
        public void EnviaTest()
        {
            EnvioEmail teste = new EnvioEmail(); 
            string endereco = "karine.leles@hotmail.com";
            string comentario = "Teste Email";
            bool EmailTeste = teste.Envia(endereco, comentario);
            Assert.AreEqual(true, EmailTeste);
        }
        [TestMethod()]
        public void ValidaEmailTest()
        {
            EnvioEmail teste = new EnvioEmail();
            string email = "teste.com";
            bool ValidaEmail = teste.ValidaEmail(email);
            Assert.AreEqual(true, ValidaEmail);   
        }
        [TestMethod()]
        public void ValidacaoHoraTest()
        {
            EnvioEmail teste = new EnvioEmail(); 
            string hora = "9:00";
            bool horaValida= teste.ValidacaoHora(hora);
            Assert.AreEqual(true, horaValida);
        }
        [TestMethod()]
        public void VerificaSemanaTest()
        {
            EnvioEmail teste = new EnvioEmail();
            DateTime data = new DateTime(2012,11,15); 
            string semana = teste.VerificaSemana(data);
            Assert.AreEqual("quinta-feira",semana );
        }
        [TestMethod()]
        public void EnvioNDiasTest()
        {
            EnvioEmail teste = new EnvioEmail();
            DateTime data = new DateTime(2012,11,15);
            string email = "karine.leles@hotmail.com";
            string comentario = "Email teste";
            int dias = 3;
            bool envio = teste.EnvioNDias(data, email, comentario, dias);
            Assert.AreEqual(true, envio);
        }
        [TestMethod()]
        public void EnvioNDiasSabDomTest()
        {
            EnvioEmail teste = new EnvioEmail();
            DateTime data = new DateTime(2012,11,15); 
            string email = "karine.leles@hotmail.com";
            string comentario = "Email teste";
            int dias = 3;
            bool envio = teste.EnvioNDiasSabDom(data, email, comentario, dias);
            Assert.AreEqual(true, envio);
        }
        [TestMethod()]
        public void ValidaDataTest()
        {
            EnvioEmail teste = new EnvioEmail();
            DateTime data = new DateTime(2012, 11, 21);
            bool dataValida = teste.ValidaData(data);
            Assert.AreEqual(true, dataValida);
        }

        
        
    }
}
