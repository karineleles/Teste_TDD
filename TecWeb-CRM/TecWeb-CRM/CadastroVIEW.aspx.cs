using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TecWeb_CRM.CRM.Controller;
using System.Data.SqlClient;

public partial class Cadastro : System.Web.UI.Page
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
        
        PessoaController Controller = new PessoaController();
        this.GVCadastro.DataSource = Controller.SelecionarTodos();
        this.GVCadastro.DataBind();
        
       
        

    }

 
}
