using TecWeb_CRM.CRM.Dao;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using TecWeb_CRM.CRM.Entidades;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DTD_Agenda
{
    
    
    /// <summary>
    ///This is a test class for CRM_DAO_AgendaTest and is intended
    ///to contain all CRM_DAO_AgendaTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CRM_DAO_AgendaTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
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

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for CRM_DAO_Agenda Constructor
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Nino\\Desktop\\TecWeb-CRM\\TecWeb-CRM", "/")]
        [UrlToTest("http://localhost:52314/")]
        public void CRM_DAO_AgendaConstructorTest()
        {
            CRM_DAO_Agenda target = new CRM_DAO_Agenda();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for AtualizaAgendaDia
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Nino\\Desktop\\TecWeb-CRM\\TecWeb-CRM", "/")]
        [UrlToTest("http://localhost:52314/")]
        public void AtualizaAgendaDiaTest()
        {
            CRM_DAO_Agenda target = new CRM_DAO_Agenda(); // TODO: Initialize to an appropriate value
            int dia = 0; // TODO: Initialize to an appropriate value
            target.AtualizaAgendaDia(dia);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for EnviarEMail
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Nino\\Desktop\\TecWeb-CRM\\TecWeb-CRM", "/")]
        [UrlToTest("http://localhost:52314/")]
        public void EnviarEMailTest()
        {
            CRM_DAO_Agenda target = new CRM_DAO_Agenda(); // TODO: Initialize to an appropriate value
            string endereco = string.Empty; // TODO: Initialize to an appropriate value
            int dia = 0; // TODO: Initialize to an appropriate value
            string comentario = string.Empty; // TODO: Initialize to an appropriate value
            target.EnviarEMail(endereco, dia, comentario);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for ExcluirAgenda
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Nino\\Desktop\\TecWeb-CRM\\TecWeb-CRM", "/")]
        [UrlToTest("http://localhost:52314/")]
        public void ExcluirAgendaTest()
        {
            CRM_DAO_Agenda target = new CRM_DAO_Agenda(); // TODO: Initialize to an appropriate value
            Agenda Agenda = null; // TODO: Initialize to an appropriate value
            target.ExcluirAgenda(Agenda);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for InserirAgenda
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Nino\\Desktop\\TecWeb-CRM\\TecWeb-CRM", "/")]
        [UrlToTest("http://localhost:52314/")]
        public void InserirAgendaTest()
        {
            CRM_DAO_Agenda target = new CRM_DAO_Agenda(); // TODO: Initialize to an appropriate value
            Agenda agenda = null; // TODO: Initialize to an appropriate value
            target.InserirAgenda(agenda);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for SelecionarAgenda
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Nino\\Desktop\\TecWeb-CRM\\TecWeb-CRM", "/")]
        [UrlToTest("http://localhost:52314/")]
        public void SelecionarAgendaTest()
        {
            CRM_DAO_Agenda target = new CRM_DAO_Agenda(); // TODO: Initialize to an appropriate value
            List<Agenda> expected = null; // TODO: Initialize to an appropriate value
            List<Agenda> actual;
            actual = target.SelecionarAgenda();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SelecionarTodosAgenda
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Nino\\Desktop\\TecWeb-CRM\\TecWeb-CRM", "/")]
        [UrlToTest("http://localhost:52314/")]
        public void SelecionarTodosAgendaTest()
        {
            CRM_DAO_Agenda target = new CRM_DAO_Agenda(); // TODO: Initialize to an appropriate value
            List<Agenda> expected = null; // TODO: Initialize to an appropriate value
            List<Agenda> actual;
            actual = target.SelecionarTodosAgenda();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for VerificaEmail
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Nino\\Desktop\\TecWeb-CRM\\TecWeb-CRM", "/")]
        [UrlToTest("http://localhost:52314/")]
        public void VerificaEmailTest()
        {
            CRM_DAO_Agenda target = new CRM_DAO_Agenda(); // TODO: Initialize to an appropriate value
            int dia = 0; // TODO: Initialize to an appropriate value
            string hora = string.Empty; // TODO: Initialize to an appropriate value
            target.VerificaEmail(dia, hora);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Connection
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Nino\\Desktop\\TecWeb-CRM\\TecWeb-CRM", "/")]
        [UrlToTest("http://localhost:52314/")]
        public void ConnectionTest()
        {
            CRM_DAO_Agenda target = new CRM_DAO_Agenda(); // TODO: Initialize to an appropriate value
            SqlConnection expected = null; // TODO: Initialize to an appropriate value
            SqlConnection actual;
            target.Connection = expected;
            actual = target.Connection;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
