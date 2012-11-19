using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TecWeb_CRM.CRM.Dao;
using TecWeb_CRM.CRM.Entidades;
using System.Data.SqlClient;

namespace TecWeb_CRM.CRM.Controller
{
    public class PedidoController
    {
        public CRM_DAO_Pedido Banco { get; set; }


        public void InserirPedido(Pedido Pedido)
        {
            Banco.InserirPedido(Pedido);
        }

        public List<Pedido> SelecionarTodosPedido()
        {
            CRM_DAO_Pedido Banco2 = new CRM_DAO_Pedido();
            return Banco2.SelecionarTodosPedido();

        }
    }
}