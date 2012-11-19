using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TecWeb_CRM.CRM.Entidades
{
    public class Agenda
    {
        public int Codigo { get; set; }
        public string data { get; set; }
        public string hora { get; set; }
        public string Comentarios { get; set; }
        public int FK_Codigo { get; set; }
        public string data_email { get; set; }
        public string hora_email { get; set; }
        public int Cod_Tipo { get; set; }
    }

}