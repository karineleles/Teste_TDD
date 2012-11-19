using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TecWeb_CRM.CRM.Dao;
using TecWeb_CRM.CRM.Entidades;
using System.Data.SqlClient;

namespace TecWeb_CRM.CRM.Controller
{
    public class AtividadeController
    {
        public CRM_DAO_Atividade Banco { get; set; }


        public void InserirAtividade(Atividade Atividade)
        {
            Banco.InserirAtividade(Atividade);
        }

        public List<Atividade> SelecionarTodosAtividade()
        {
            CRM_DAO_Atividade Banco2 = new CRM_DAO_Atividade();
            return Banco2.SelecionarTodosAtividade();

        }
    }
}