using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using TecWeb_CRM.CRM.Entidades;
using System.Data;


namespace TecWeb_CRM.CRM.Dao
{
    public class CRM_DAO_Visita
    {
    
   
        public SqlConnection Connection {get;set;}

        public CRM_DAO_Visita() 
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
        public List<Pedido> SelecionarTodosPedido()
        {



            List<Pedido> pedidos = new List<Pedido>();
            IDbCommand Comando = Connection.CreateCommand();
            Comando.CommandText = "SELECT * FROM PEDIDO";
            Connection.Open();
            IDataReader leitor = Comando.ExecuteReader();
            
 
            while (leitor.Read())
            {
                Pedido pedido = new Pedido();
                
                pedido.Codigo = Convert.ToInt32(leitor.GetValue(0));
                pedido.Comentarios = Convert.ToString(leitor.GetValue(9));

                pedidos.Add(pedido);
            }
            Connection.Close();
            return pedidos;
        }
        public List<Agenda> SelecionarTodosAgenda()
        {



            List<Agenda> Agendas = new List<Agenda>();
            IDbCommand Comando = Connection.CreateCommand();
            Comando.CommandText = "SELECT * FROM AGENDA";
            Connection.Open();
            IDataReader leitor = Comando.ExecuteReader();

            while (leitor.Read())
            {
                Agenda agenda = new Agenda();
                
                
                agenda.Codigo = Convert.ToInt32(leitor.GetValue(0));
                agenda.Comentarios = Convert.ToString(leitor.GetValue(1));

                Agendas.Add(agenda);
            }
            Connection.Close();
            return Agendas;
        }
        public List<Visita> SelecionarTodosVisita()
        {

            List<Visita> Visitas = new List<Visita>();
            IDbCommand Comando = Connection.CreateCommand();
            Comando.CommandText = "SELECT * FROM VISITAS";
            Connection.Open();
            IDataReader leitor = Comando.ExecuteReader();

            while (leitor.Read())
            {
                Visita visita = new Visita();
               
                

                visita.Codigo = Convert.ToInt32(leitor.GetValue(0));
                visita.Comentarios = Convert.ToString(leitor.GetValue(9));

                Visitas.Add(visita);
            }
            Connection.Close();
            return Visitas;
        }

        
        public void InserirPessoa(Pessoa Cliente) 
        {
            Connection.Open();
            SqlCommand Comando = new SqlCommand("INSERT INTO PESSOA VALUES ");
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


        public void InserirPedido(Pedido Pedido)
        {
            Connection.Open();
            SqlCommand Comando = new SqlCommand("INSERT INTO PEDIDO VALUES ");
            Connection.Close();
        }
        public void ExcluirPedido(Pedido Pedido)
        {
            Connection.Open();
            SqlCommand Comando = new SqlCommand("");
            Connection.Close();
        }


        public void InserirAgenda(Agenda Agenda)
        {
            Connection.Open();
            SqlCommand Comando = new SqlCommand("INSERT INTO AGENDA VALUES ");
            Connection.Close();
        }
        public void ExcluirAgenda(Agenda Agenda)
        {
            Connection.Open();
            SqlCommand Comando = new SqlCommand("");
            Connection.Close();
        }


        public void InserirVisita(Visita Visita)
        {
            Connection.Open();
            SqlCommand Comando = new SqlCommand("INSERT INTO VISITA VALUES ");
            Connection.Close();
        }
        public void ExcluirVisita(Visita Visita)
        {
            Connection.Open();
            SqlCommand Comando = new SqlCommand("");
            Connection.Close();
        }

    }
}