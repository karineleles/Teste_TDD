using TecWeb_CRM.CRM.Dao;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using TecWeb_CRM.CRM.Entidades;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace TESTE_DAO
{
    
    
    /// <summary>
    ///This is a test class for CRM_DAO_PessoaTest and is intended
    ///to contain all CRM_DAO_PessoaTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CRM_DAO_PessoaTest
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
        ///A test for CRM_DAO_Pessoa Constructor
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("\\\\vmware-host\\Shared Folders\\Arquivos\\TecWeb-CRM\\TecWeb-CRM", "/")]
        [UrlToTest("http://localhost:52314/")]
        public void CRM_DAO_PessoaConstructorTest()
        {
            CRM_DAO_Pessoa target = new CRM_DAO_Pessoa();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for AlterarPessoa
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("\\\\vmware-host\\Shared Folders\\Arquivos\\TecWeb-CRM\\TecWeb-CRM", "/")]
        [UrlToTest("http://localhost:52314/")]
        public void AlterarPessoaTest()
        {
            CRM_DAO_Pessoa target = new CRM_DAO_Pessoa(); // TODO: Initialize to an appropriate value
            target.AlterarPessoa();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for ExcluirPessoa
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("\\\\vmware-host\\Shared Folders\\Arquivos\\TecWeb-CRM\\TecWeb-CRM", "/")]
        [UrlToTest("http://localhost:52314/")]
        public void ExcluirPessoaTest()
        {
            CRM_DAO_Pessoa target = new CRM_DAO_Pessoa(); // TODO: Initialize to an appropriate value
            target.ExcluirPessoa();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for InserirPessoa
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("\\\\vmware-host\\Shared Folders\\Arquivos\\TecWeb-CRM\\TecWeb-CRM", "/")]
        [UrlToTest("http://localhost:52314/")]
        public void InserirPessoaTest()
        {
            CRM_DAO_Pessoa target = new CRM_DAO_Pessoa(); // TODO: Initialize to an appropriate value
            Pessoa Cliente = null; // TODO: Initialize to an appropriate value
            target.InserirPessoa(Cliente);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for SelecionarTodosPessoa
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("\\\\vmware-host\\Shared Folders\\Arquivos\\TecWeb-CRM\\TecWeb-CRM", "/")]
        [UrlToTest("http://localhost:52314/")]
        public void SelecionarTodosPessoaTest()
        {
            CRM_DAO_Pessoa target = new CRM_DAO_Pessoa(); // TODO: Initialize to an appropriate value
            List<Pessoa> expected = null; // TODO: Initialize to an appropriate value
            List<Pessoa> actual;
            actual = target.SelecionarTodosPessoa();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Connection
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("\\\\vmware-host\\Shared Folders\\Arquivos\\TecWeb-CRM\\TecWeb-CRM", "/")]
        [UrlToTest("http://localhost:52314/")]
        public void ConnectionTest()
        {
            CRM_DAO_Pessoa target = new CRM_DAO_Pessoa(); // TODO: Initialize to an appropriate value
            SqlConnection expected = null; // TODO: Initialize to an appropriate value
            SqlConnection actual;
            target.Connection = expected;
            actual = target.Connection;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for CRM_DAO_Pessoa Constructor
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("\\\\vmware-host\\Shared Folders\\Arquivos\\TecWeb-CRM\\TecWeb-CRM", "/")]
        [UrlToTest("http://localhost:52314/")]
        public void CRM_DAO_PessoaConstructorTest1()
        {
            CRM_DAO_Pessoa target = new CRM_DAO_Pessoa();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
