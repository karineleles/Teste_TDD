using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TecWeb_CRM.CRM.Controller;
using System.Data.SqlClient;


namespace TecWeb_CRM
{

    public partial class PedidoVIEW : System.Web.UI.Page
    {



        protected void Page_Load(object sender, EventArgs e)
        {


            if (!Page.IsPostBack)
            {
                this.PreencheGrid();
            }

        }
        

        public void PreencheGrid()
        {

            PedidoController Controller = new PedidoController();
            this.GVPedido.DataSource = Controller.SelecionarTodosPedido();
            this.GVPedido.DataBind();
           

        }


    }

}
