using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    
    class CadastroCachorro
    {
        private static List<CadastroCachorro> ListaDeCachorro = new List<CadastroCachorro>();

            /// <summary>
        /// Identificação do cachorro
        /// </summary>
            public int Identificacao { get; set; }
            /// <summary>
            /// Nome do cachorro
            /// </summary>
            public string Nome { get; set; }
            /// <summary>
            /// Idade do cachorro
            /// </summary>
            public int Idade { get; set; }
            /// <summary>
            /// Raça do cachorro
            /// </summary>
            public string Raca { get; set; }
            /// <summary>
            /// Nome do dono do cachorro
            /// </summary>
            public string NomeDoDono { get; set; }
            /// <summary>
            /// E-mail do dono do cachorro
            /// </summary>
            public string Email { get; set; }
            /// <summary>
            /// CPF do dono do cachorro
            /// </summary>
            public int CPF { get; set; }
            /// <summary>
            /// Endereço do dono do cachorro
            /// </summary>
            public string Endereco { get; set; }

            /// <summary>
            /// Método para adicionar um cachorro
            /// </summary>
            /// <param name="novoCachorro">Cachorro</param>
            /// <returns>Caso o cachorro seja inserido, retorna true</returns>
            public string AdicionarCachorro(CadastroCachorro novoCachorro)
            {
                if (novoCachorro.Nome == string.Empty || novoCachorro.Idade == 0 || novoCachorro.Raca == string.Empty)
                    return "É obrigatório informar os dados do cachorro.";

                if (novoCachorro.NomeDoDono == string.Empty || novoCachorro.Email == string.Empty || novoCachorro.CPF == 0 || novoCachorro.Endereco == string.Empty)
                    return "É obrigatório informar os dados do dono do cachorro.";

                // Adição do cachorro
                ListaDeCachorro.Add(novoCachorro);

                //// Envio do e-mail
                //var mail = new MailMessage("comunicacao@petstore.com", Email);
                //var client = new SmtpClient
                //{
                //    Port = 25,
                //    DeliveryMethod = SmtpDeliveryMethod.Network,
                //    UseDefaultCredentials = false,
                //    Host = "smtp.google.com"
                //};

                //mail.Subject = "Bem vindo a Pet Store";
                //mail.Body = $"Parabéns! Seu Pet {novoCachorro.Nome} foi cadastrado com sucesso!";
                //client.Send(mail);

                return "Cachorro cadastrado com sucesso!";
        }

    }
}
