using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using TecWeb_CRM.CRM.Entidades;
using System.Data;


namespace TecWeb_CRM.CRM.Dao
{
    public class CRM_DAO_Atividade
    {
    
              
        public SqlConnection Connection {get;set;}

        public CRM_DAO_Atividade() 
        {
            Connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Administrator\Desktop\TecWeb-CRM\TecWeb-CRM\App_Data\CRM_DataBase.mdf;Integrated Security=True;User Instance=True");
        
        }


        public List<Atividade> SelecionarTodosAtividade()
        {
            

            
            List<Atividade> Atividades = new List<Atividade>();
            IDbCommand Comando = Connection.CreateCommand();
            Comando.CommandText = "SELECT * FROM ATIVIDADE";
            Connection.Open();
            IDataReader leitor = Comando.ExecuteReader();
            Atividade atividade = new Atividade();
                
            while (leitor.Read())
            {
               
                atividade.Codigo = Convert.ToInt32(leitor.GetValue(0));    
                atividade.Comentarios = Convert.ToString(leitor.GetValue(1));

                Atividades.Add(atividade);
            }
            Connection.Close();
            return Atividades;
        }
        
        public void InserirAtividade(Atividade Atividade)
        {
            Connection.Open();
            SqlCommand Comando = new SqlCommand("INSERT INTO ATIVIDADE VALUES ");
            Connection.Close();
        }
        public void ExcluirAtividade(Atividade Atividade)
        {
            Connection.Open();
            SqlCommand Comando = new SqlCommand("");
            Connection.Close();
        }



    }
}