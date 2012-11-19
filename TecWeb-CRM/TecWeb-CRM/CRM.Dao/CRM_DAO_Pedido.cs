using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using TecWeb_CRM.CRM.Entidades;
using System.Data;


namespace TecWeb_CRM.CRM.Dao
{
    public class CRM_DAO_Pedido
    {

        public SqlConnection Connection {get;set;}

        public CRM_DAO_Pedido() 
        {
            Connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Administrator\Desktop\TecWeb-CRM\TecWeb-CRM\App_Data\CRM_DataBase.mdf;Integrated Security=True;User Instance=True");
        
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


    }
}