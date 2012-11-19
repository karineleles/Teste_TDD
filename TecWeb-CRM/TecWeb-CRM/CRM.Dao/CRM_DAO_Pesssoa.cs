using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using TecWeb_CRM.CRM.Entidades;
using System.Data;
using System.Text.RegularExpressions;


namespace TecWeb_CRM.CRM.Dao
{
    public class CRM_DAO_Pessoa
    {
     
  
        public SqlConnection Connection {get;set;}
      

        public CRM_DAO_Pessoa() 
        {
            Connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Administrator\Desktop\TecWeb-CRM\TecWeb-CRM\App_Data\CRM_DataBase.mdf;Integrated Security=True;User Instance=True");
        }

        public List<EntPessoa> SelecionarTodosPessoa()
        {



            List<EntPessoa> Pessoas = new List<EntPessoa>();
            IDbCommand Comando = Connection.CreateCommand();
            Comando.CommandText = "SELECT * FROM PESSOA";
            Connection.Open();
            IDataReader leitor = Comando.ExecuteReader();

            while (leitor.Read())
            {
                EntPessoa pessoa = new EntPessoa();
                Agenda s = new Agenda();

                
                pessoa.Codigo = Convert.ToInt32(leitor.GetValue(0));    
                pessoa.Login = Convert.ToString(leitor.GetValue(1));
                pessoa.Senha = Convert.ToString(leitor.GetValue(2));
                pessoa.Nome = Convert.ToString(leitor.GetValue(3));
                pessoa.Email = Convert.ToString(leitor.GetValue(4));
               
                Pessoas.Add(pessoa);
            }
            Connection.Close();
            return Pessoas;
        }



        public void InserirPessoa(EntPessoa pessoa) 
        {
            
           CRM.Dao.Pessoa BDPessoa = new CRM.Dao.Pessoa();
           CRM_DataBaseEntities Entidade = new CRM_DataBaseEntities();

             BDPessoa.usuário = pessoa.Login;
             BDPessoa.senha = pessoa.Senha;
             BDPessoa.Nome = pessoa.Nome;
             BDPessoa.Email = pessoa.Email;

            

            Entidade.AddToPessoas(BDPessoa);
            Entidade.SaveChanges();
            Connection.Close();

          
        }
        public void AlterarPessoa()
        {
            Connection.Open();
            SqlCommand Comando = new SqlCommand("");
            Connection.Close();
        }
        public void ExcluirPessoa()
        {
            Connection.Open();
            SqlCommand Comando = new SqlCommand("");
            Connection.Close();
        }

        public bool ValidaEmail(string email)
        {

 
        Regex rg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

        if (rg.IsMatch(email))
            return true;
        else
            return false;


           
                        }






    }


    }