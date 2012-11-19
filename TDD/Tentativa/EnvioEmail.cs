using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Net.Mail;
using System.Globalization;

namespace TDD
{
    class EnvioEmail
    {
        public bool Envia(string endereco, string comentario)
        {
            MailMessage Email = new MailMessage();

            Email.To.Add(endereco);
            Email.From = new MailAddress("crmonlinesi@gmail.com", "CRM_Online", System.Text.Encoding.UTF8);
            Email.Subject = "Lembrete Atividade";
            Email.SubjectEncoding = System.Text.Encoding.UTF8;
            Email.Body = "Aviso de lembrete: " + comentario + " no dia: " + DateTime.Now.Day + ", as " + DateTime.Now.Hour + ":" + DateTime.Now.Minute + "";
            Email.SubjectEncoding = System.Text.Encoding.UTF8;
            Email.IsBodyHtml = true;
            Email.Priority = MailPriority.High;

            SmtpClient cliente = new SmtpClient();

            cliente.Credentials = new System.Net.NetworkCredential("crmonlinesi@gmail.com", "crm123456");
            cliente.Port = 587;
            cliente.Host = "smtp.gmail.com";
            cliente.EnableSsl = true;

            try
            {

                cliente.Send(Email);
                return true;


            }
            catch (Exception ex)
            {

                return false;

            }

        }
        public bool ValidaEmail(string email)
        {
            Regex rg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

            if (rg.IsMatch(email))
            {
                Console.Write("Email Valido!");
                return true;
            }
            else
            {
                Console.Write("Email Inválido!");
                return false;
            }
        }
            public bool ValidacaoHora(string hora)
            {
                Regex rg = new Regex(@"^([0-9]{2}):([0-9]{2}):([0-9]{2})$");
                string[] Vethora = hora.Split(char.Parse(":"));

                if (hora == null && rg.IsMatch(hora) && int.Parse(Vethora[0]) > 24 && int.Parse(Vethora[1]) > 59 && int.Parse(Vethora[0]) < 0 && int.Parse(Vethora[1]) < 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            public string VerificaSemana(DateTime data)
            {
                CultureInfo culture = new CultureInfo("pt-BR");
                DateTimeFormatInfo dtfi = culture.DateTimeFormat;
                string data1 = dtfi.GetDayName(data.DayOfWeek);
                return data1;
            }
            public bool EnvioNDias(DateTime data, string email, string comentario, int dias)
            {
                DateTime dataEnvio = data.AddDays(dias);

                if (dataEnvio.DayOfWeek == DayOfWeek.Saturday || dataEnvio.DayOfWeek == DayOfWeek.Sunday)
                {
                    return false;
                }
                else
                {
                    if (DateTime.Compare(data, DateTime.Now) == -1)
                    {
                        Envia(email, comentario);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            public bool EnvioNDiasSabDom(DateTime data, string email, string comentario, int dias)
            {
                if (DateTime.Compare(data.AddDays(dias), DateTime.Now) == -1)
                {
                    Envia(email, comentario);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            public bool ValidaData(DateTime data)
            {
                if (data < DateTime.Now)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
    }
}