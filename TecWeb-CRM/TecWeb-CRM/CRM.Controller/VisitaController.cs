using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TecWeb_CRM.CRM.Dao;
using TecWeb_CRM.CRM.Entidades;
using System.Data.SqlClient;

namespace TecWeb_CRM.CRM.Controller
{
    public class VisitaController
    {
        public CRM_DAO_Visita Banco { get; set; }


        public void InserirVisita(Visita Visita)
        {
            Banco.InserirVisita(Visita);
        }

        public List<Visita> SelecionarTodosVisita()
        {
            CRM_DAO_Visita Banco2 = new CRM_DAO_Visita();
            return Banco2.SelecionarTodosVisita();

        }
    }
}