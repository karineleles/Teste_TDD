using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TecWeb_CRM.CRM.Controller;
using TecWeb_CRM.CRM.Entidades;


namespace TecWeb_CRM
{
    public partial class CadastroPessoa : System.Web.UI.Page
    {

        PessoaController Controller = new PessoaController();
        EntPessoa entidade = new EntPessoa();
        Boolean flag = false;

        protected void Page_Load(object sender, EventArgs e)
        {
       
        }


        protected void BTNenviar_Click(object sender, EventArgs e)
        {

            entidade.Login = TXLogin.Text;
            entidade.Senha = TXSenha.Text;
            entidade.Email = TXEmail.Text;
            entidade.Nome = TXNome.Text;
         
               


            Controller.InserirPessoa(entidade);
           

        }

  
    }
}