using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    class CadastroGato
    {
        public static List<CadastroGato> ListaDeGatos = new List<CadastroGato>();

        /// <summary>
        /// Identificação do gato
        /// </summary>
        public int Identificacao { get; set; }
        /// <summary>
        /// Nome do gato
        /// </summary>
        public string Nome { get; set; }
        /// <summary>
        /// Idade do gato
        /// </summary>
        public int Idade { get; set; }
        /// <summary>
        /// Raça do gato
        /// </summary>
        public string Raca { get; set; }
        /// <summary>
        /// Nome do dono do gato
        /// </summary>
        public string NomeDoDono { get; set; }
        /// <summary>
        /// E-mail do dono do gato
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// CPF do dono do gato
        /// </summary>
        public int CPF { get; set; }
        /// <summary>
        /// Endereço do dono do gato
        /// </summary>
        public string Endereco { get; set; }

        /// <summary>
        /// Método para adicionar um gato
        /// </summary>
        /// <param name="novoGato">Gato</param>
        /// <returns>Caso o gato seja inserido, retorna uma mensagem informando.</returns>
        public string AdicionarGato(CadastroGato novoGato)
        {
            if (novoGato.Nome == string.Empty || novoGato.Idade == 0 || novoGato.Raca == string.Empty)
                return "É obrigatório informar os dados do gato.";
            if (novoGato.NomeDoDono == string.Empty || novoGato.Email == string.Empty || novoGato.CPF == 0 || novoGato.Endereco == string.Empty)
                return "É obrigatório informar os dados do dono do gato.";

            // Adição do gato
            ListaDeGatos.Add(novoGato);
            #region Envio de email
            //// Envio de e-mail
            //var mail = new MailMessage("comunicacao@petstore.com", Email);
            //var client = new SmtpClient
            //{
            //    Port = 25,
            //    DeliveryMethod = SmtpDeliveryMethod.Network,
            //    UseDefaultCredentials = false,
            //    Host = "smtp.google.com"
            //};

            //mail.Subject = "Bem vindo a Pet Store";
            //mail.Body = $"Parabéns! Seu Pet {gato.Nome} foi cadastrado com sucesso!";
            //client.Send(mail);
            #endregion

            return $"O cadastro do Gato {novoGato.Nome} foi realizado com sucesso!";
        }
    }
}
