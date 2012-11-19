using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TecWeb_CRM.CRM.Dao;
using TecWeb_CRM.CRM.Entidades;
using System.Data.SqlClient;

namespace TecWeb_CRM.CRM.Controller
{
    
    public class AgendaController
    {
        CRM_DAO_Agenda Banco = new CRM_DAO_Agenda();
        
        public void InserirAgenda(Agenda agenda)
        {
                Banco.InserirAgenda(agenda);
          
         }

        public List<Agenda> SelecionarTodosAgenda()
        {
            CRM_DAO_Agenda Banco2 = new CRM_DAO_Agenda();
            return Banco2.SelecionarTodosAgenda();

        }
        
        public List<Agenda> SelecionarAgenda()
        {
            CRM_DAO_Agenda Banco2 = new CRM_DAO_Agenda();
            return Banco2.SelecionarAgenda();

        }

        public void VerificaEmail(int dia, string hora)
        {
            CRM_DAO_Agenda Banco2 = new CRM_DAO_Agenda();
            Banco2.VerificaEmail(dia,hora.Substring(11, 5));

        }



    }
}