using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;
using TecWeb_CRM.CRM.Entidades;



namespace TecWeb_CRM.CRM.Dao
{
    public class CRM_DAO_Agenda
    {


        public SqlConnection Connection { get; set; }
        Agendum BDagenda = new Agendum();
        CRM_DataBaseEntities Entidade = new CRM_DataBaseEntities();

        public CRM_DAO_Agenda()
        {
            Connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\CRM_DataBase.mdf;Integrated Security=True;User Instance=True");

        }


        public List<Agenda> SelecionarTodosAgenda()
        {
            //Seleciona Todos os registros da tabela AGENDA

            Connection.Open();
            List<Agenda> Agendas = new List<Agenda>();
            IDbCommand Comando = Connection.CreateCommand();
            Comando.CommandText = "SELECT * FROM AGENDA";
            IDataReader leitor = Comando.ExecuteReader();
            try
            {
                while (leitor.Read())
                {

                    Agenda agenda = new Agenda();


                    agenda.Codigo = Convert.ToInt32(leitor.GetValue(0));
                    agenda.data = Convert.ToString(leitor.GetValue(1));
                    agenda.hora = Convert.ToString(leitor.GetValue(2));
                    agenda.Comentarios = Convert.ToString(leitor.GetValue(3));
                    agenda.FK_Codigo = Convert.ToInt32(leitor.GetValue(4));
                    agenda.data_email = Convert.ToString(leitor.GetValue(5));
                    agenda.hora_email = Convert.ToString(leitor.GetValue(6));
                    agenda.Cod_Tipo = Convert.ToInt32(leitor.GetValue(7));


                    Agendas.Add(agenda);

                }


            }
            catch { }
            Connection.Close();
            return Agendas;
        }




        public void InserirAgenda(Agenda agenda)
        {
            //Insere oque foi escrito no formulário, na tabela AGENDA.

            Connection.Open();

            BDagenda.data = agenda.data;
            BDagenda.hora = agenda.hora;
            BDagenda.comentario = agenda.Comentarios;
            BDagenda.FK_Pessoa = agenda.FK_Codigo;
            BDagenda.Data_Email = agenda.data_email;
            BDagenda.Hora_Email = agenda.hora_email;
            BDagenda.Cod_Tipo = agenda.Cod_Tipo;



            Entidade.AddToAgenda(BDagenda);
            Entidade.SaveChanges();
            Connection.Close();

        }

        public List<Agenda> SelecionarAgenda()
        {
            //Seleciona os registros na tabela AGENDA filtrados
            Connection.Open();
            List<Agenda> Agendas = new List<Agenda>();
            IDbCommand Comando = Connection.CreateCommand();
            Comando.CommandText = "SELECT * FROM AGENDA WHERE DATA LIKE ''";
            IDataReader leitor = Comando.ExecuteReader();

            while (leitor.Read())
            {
                Agenda agenda = new Agenda();


                agenda.Codigo = Convert.ToInt32(leitor.GetValue(0));
                agenda.data = Convert.ToString(leitor.GetValue(1));
                agenda.hora = Convert.ToString(leitor.GetValue(2));
                agenda.Comentarios = Convert.ToString(leitor.GetValue(3));
                agenda.FK_Codigo = Convert.ToInt32(leitor.GetValue(4));
                agenda.data_email = Convert.ToString(leitor.GetValue(5));
                agenda.hora_email = Convert.ToString(leitor.GetValue(6));
                agenda.Cod_Tipo = Convert.ToInt32(leitor.GetValue(7));


                Agendas.Add(agenda);
            }
            Connection.Close();
            return Agendas;

        }

        public void AtualizaAgendaDia(int dia)
        {
            //Atualiza o valor do dia para -1, para invalidá-lo
            Connection.Open();
            IDbCommand Comando = Connection.CreateCommand();

            Comando.CommandText = "UPDATE AGENDA SET Data_Email = '-1' WHERE Data_Email LIKE '" + dia + "'";
            Comando.ExecuteNonQuery();

            Connection.Close();
        }

        public void ExcluirAgenda(Agenda Agenda)
        {
            Connection.Open();
            SqlCommand Comando = new SqlCommand("");
            Connection.Close();
        }

        public void VerificaEmail(int dia, string hora)
        {


            Connection.Open();
            IDbCommand Comando = Connection.CreateCommand();
            Comando.CommandText = "SELECT AG.Data_Email, AG.Hora_Email, AG.comentario, PS.Nome, AG.data, PS.email, AG.Cod_Tipo FROM  Agenda AS AG INNER JOIN  Pessoa AS PS ON PS.CodPessoa = AG.FK_Pessoa";
            IDataReader leitor = Comando.ExecuteReader();

            // While verifica se existe algum registro no banco de dados, se SIM, ele continua a ler o arquivo que fez o SELECT.
            //TRY evita os erros quando a tabela tem algum campo NULO




            while (leitor.Read())
            {
                try
                {

                    //Verifica qual tipo de agenda ( Segunda a Segunda, Dia X, Segunda a Sexta) foi selecionado pelo usuário
                    if ((Convert.ToInt32(leitor.GetValue(6))) == 1)
                    {

                        //Verifica se o dia de hoje é igual o dia do banco
                        if ((Convert.ToInt32(leitor.GetValue(0)) == DateTime.Now.DayOfYear))
                        {
                            //Envia o Email
                            EnviarEMail(Convert.ToString(leitor.GetValue(4)), dia, Convert.ToString(leitor.GetValue(2)));
                            //Verifica se a hora atual é a hora do email
                            if (hora == Convert.ToString(leitor.GetValue(1)))
                                EnviarEMail(Convert.ToString(leitor.GetValue(4)), dia, Convert.ToString(leitor.GetValue(2)));
                            AtualizaAgendaDia(dia);


                        }
                    }
                    //Verifica qual tipo de agenda ( Segunda a Segunda, Dia X, Segunda a Sexta) foi selecionado pelo usuário
                    if ((Convert.ToInt32(leitor.GetValue(6))) == 0)
                    {
                        //Verifica se o dia do ano de hoje é menor que o dia do banco. Exemplo: 340 - 308
                        //Caso seja, ele envia o email e atualiza o valor para -1, para invalidar aquele dia.
                        if ((Convert.ToInt32(leitor.GetValue(0)) - dia) > 0)
                        {

                            EnviarEMail(Convert.ToString(leitor.GetValue(5)), dia, Convert.ToString(leitor.GetValue(2)));
                            //Verifica se a hora atual é a hora do email
                            if (hora == Convert.ToString(leitor.GetValue(1)))
                                EnviarEMail(Convert.ToString(leitor.GetValue(4)), dia, Convert.ToString(leitor.GetValue(2)));
                            AtualizaAgendaDia(dia);

                        }


                    }


                    //Verifica qual tipo de agenda ( Segunda a Segunda, Dia X, Segunda a Sexta) foi selecionado pelo usuário
                    if ((Convert.ToInt32(leitor.GetValue(6))) == 2)
                    {

                        //Verifica se o dia do ano de hoje é menor que o dia do banco. Exemplo: 340 - 308
                        if ((Convert.ToInt32(leitor.GetValue(0)) - dia) > 0)
                        {
                            //Verifica se o dia do banco é sabado ou domingo
                            //Caso seja, ele envia o email e atualiza o valor para -1, para invalidar aquele dia.
                            if (Convert.ToDateTime(leitor.GetValue(0)).DayOfWeek != DayOfWeek.Saturday && Convert.ToDateTime(leitor.GetValue(0)).DayOfWeek != DayOfWeek.Sunday)
                            {

                                //Envia o Email
                                EnviarEMail(Convert.ToString(leitor.GetValue(5)), dia, Convert.ToString(leitor.GetValue(2)));
                                //Verifica se a hora atual é a hora do email  
                                if (hora == Convert.ToString(leitor.GetValue(1)))
                                    EnviarEMail(Convert.ToString(leitor.GetValue(4)), dia, Convert.ToString(leitor.GetValue(2)));
                                AtualizaAgendaDia(dia);

                            }
                        }
                    }
                }
                catch { }


            }



            Connection.Close();







        }



        public void EnviarEMail(string endereco, int dia, string comentario)
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


            }
            catch (Exception ex)
            {



            }




        }


    }
}