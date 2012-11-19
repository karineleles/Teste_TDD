using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TecWeb_CRM.CRM.Controller;
using System.Data.SqlClient;
using TecWeb_CRM.CRM.Entidades;
using System.Web.Mail;

 

namespace TecWeb_CRM
{
    public partial class AgendaVIEW : System.Web.UI.Page
    
    {
        Agenda agenda = new Agenda();
        AgendaController agendaController = new AgendaController();

        protected void Page_Load(object sender, EventArgs e)
        {

           
            
            MostraAgenda.DataSource = agendaController.SelecionarTodosAgenda();
            MostraAgenda.DataBind();



            if (!Page.IsPostBack)
            {



                agendaController.VerificaEmail(DateTime.Now.DayOfYear,Convert.ToString(DateTime.Now));
               

            }

           

            

        }

        
        


        protected void TXagenda_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void BTenviar_Click(object sender, EventArgs e)
        {
            AgendaController controller = new AgendaController();

            agenda.data = Convert.ToString(DateTime.Now.DayOfYear);
            string SubHora = Convert.ToString(DateTime.Now.TimeOfDay);
            agenda.hora = SubHora.Substring(0, 5);              
            agenda.Comentarios = TXAgenda.Text;
            agenda.FK_Codigo = 8;
            agenda.data_email = Convert.ToString(CDagendaLembrete.SelectedDate.Date.DayOfYear);           
            agenda.hora_email = TXHoraLembrete.Text;
            agenda.Cod_Tipo = Convert.ToInt32(DropDAgenda.SelectedValue);


            controller.InserirAgenda(agenda);


        }


    }
}