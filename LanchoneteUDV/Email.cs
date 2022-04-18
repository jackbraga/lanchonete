using LanchoneteUDV.Application.Interfaces;
using System.Net.Mail;

namespace LanchoneteUDV
{
    public class Email
    {
        //FinanceiroBLL _bll = new FinanceiroBLL();
        private readonly IFinanceiroService _financeiroService;
        public Email(IFinanceiroService financeiroService)
        {
            _financeiroService = financeiroService;
        }
        public void EnviarEmail(int idEscala, int idSocio, string emailSocio)
        {
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            var mail = new MailMessage();
            mail.From = new MailAddress("lanchonete.nsjb@gmail.com");
            mail.To.Add(emailSocio);
            //mail.To.Add("jackson_jb007@hotmail.com");
            mail.Subject = "Lanchonete São Joao Batista";
            mail.IsBodyHtml = true;
            string htmlBody;
            htmlBody = RetornaEmail(idEscala,idSocio);//"<h1>Esse é um codigo HTML</h1> <b>percebe-se que as tags funcionam</b>";
            mail.Body = htmlBody;
            SmtpServer.Port = 587;
            SmtpServer.UseDefaultCredentials = false;
            SmtpServer.Credentials = new System.Net.NetworkCredential("lanchonete.nsjb@gmail.com", "lanchonete.udv");
            SmtpServer.EnableSsl = true;

            try
            {
                SmtpServer.Send(mail);
            }
            catch (System.Exception erro)
            {
                //trata erro
            }
            finally
            {
                mail = null;
            }

        }

        private string RetornaEmail(int idEscala, int idSocio)
        {
            string produtos = "";

            var repasse = _financeiroService.ListarItensRepasseFinanceiro(idEscala, idSocio).ToList();//_bll.ListarItensRepasseFinanceiro(idEscala,idSocio);

            foreach (var item in repasse)
            {
                produtos = produtos +
                    "<tr>" +
                        "<td>" + item.Produto + "</td>" +
                        "<td>" + item.PrecoProduto.ToString("R$ 0.00##") + "</td>" +
                        "<td>" + item.Quantidade + "</td>" +
                        "<td>" + item.SubTotal().ToString("R$ 0.00##") + "</td>" +
                    "</tr>";
            }
            string email = BuscaHtml()
                .Replace("@nome", repasse.First().PrimeiroNome())
                .Replace("@data", repasse.First().DataEscala.ToShortDateString())
                .Replace("@escala", repasse.First().Escala)
                .Replace("@produtos", produtos)
                .Replace("@total", repasse.Sum(x => x.SubTotal()).ToString("R$ 0.00##"))
                .Replace("@contestacao", DateTime.Now.AddDays(2).ToShortDateString());

            return email;
        }

        private string BuscaHtml()
        {
            return @"<html>

                <head>
                <style>
                  table.blueTable {
                  font-family: ""Trebuchet MS"", Helvetica, sans-serif;
                  border: 0px solid #70A487;
                  background-color: #FFFFFF;
                  width: 80%;
                  text-align: center;
                  border-collapse: collapse;
                }
                table.blueTable td, table.blueTable th {
                  border: 1px solid #AAAAAA;
                  padding: 3px 1px;
                }
                table.blueTable tbody td {
                  font-size: 12px;
                }
                table.blueTable tr:nth-child(even) {
                  background: #D0E4F5;
                }
                table.blueTable thead {
                  background: #5D87C1;
                  background: -moz-linear-gradient(top, #85a5d0 0%, #6d93c7 66%, #5D87C1 100%);
                  background: -webkit-linear-gradient(top, #85a5d0 0%, #6d93c7 66%, #5D87C1 100%);
                  background: linear-gradient(to bottom, #85a5d0 0%, #6d93c7 66%, #5D87C1 100%);
                }
                table.blueTable thead th{
                  font-size: 14px;
                  font-weight: bold;
                  color: #FFFFFF;
                  border-left: 2px solid #D0E4F5;
                }
                table.blueTable thead th:first-child {
                  border-left: none;
                }

                </style>
                </head>
                <body style=""font-family: 'Trebuchet MS', Helvetica, sans-serif;"">
                  <p>
                    Olá, @nome!<br><br>
                    Segue resumo dos itens consumidos na lanchonete por você e/ou sua família.
                    <br>
                    <br>
                        <b>Data:</b> @data
                    <br>
                    @escala
                    </br>
                
                  </p>
                
                  <table class=""blueTable"">
                    <thead>
                        <tr>
                            <th>Produto</th>
                            <th>Preço Unitário</th>
                            <th>Quantidade</th>
                            <th>Valor Total</th>
                        </tr>
                    </thead>
                    <tbody>     

                        @produtos  


                        <tr>
                            <th style='border:none;'></th>
                            <th style='border:none;'></th>
                            <th style='background: #5D87C1;font-size: 15px;font-weight: bold;color: #FFFFFF;'>TOTAL</th>
                            <th style='background: #5D87C1;font-size: 15px;font-weight: bold;color: #FFFFFF;'>@total</th>
                         </tr>
                    </tbody>
                   
                  </table>


                    <br>
                    <br>
                    
                    <p>
                      Caso encontre alguma inconsistência, 
                       <br>
                      por gentileza, entre em contato com os responsáveis pela lanchonete,
                      <br>
                       no máximo até: <b>@contestacao</b>
                      <br>
                      <br>
                Fraternalmente,
                <br>
                <br>
                Equipe da Lanchonete São Joao Batista
                    </p>
                
                </body>
                </html>";
        }
    }
}
