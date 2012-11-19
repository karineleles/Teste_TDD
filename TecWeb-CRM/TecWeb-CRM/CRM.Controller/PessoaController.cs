using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TecWeb_CRM.CRM.Dao;
using TecWeb_CRM.CRM.Entidades;
using System.Data.SqlClient;

namespace TecWeb_CRM.CRM.Controller
{
    public class PessoaController
    {
        CRM_DAO_Pessoa Banco2 = new CRM_DAO_Pessoa();


        public void InserirPessoa(EntPessoa pessoa) 
        {
            Banco2.InserirPessoa(pessoa);
        }

        public List<EntPessoa> SelecionarTodosPessoa()
        {
      
            return Banco2.SelecionarTodosPessoa();
            
        }

        public bool ValidaEmail(string email)
        {

            return Banco2.ValidaEmail(email);

        }


    }
}