using System;
using System.Collections.Generic;
using System.Net.Mail;

namespace Exercicio
{
    /// <summary>
    /// Inicialização do programa
    /// </summary>
    public static class Program
    {
        private static List<Cachorro> Cachorros = new List<Cachorro>();
        private static List<Gato> Gatos = new List<Gato>();

        /// <summary>
        /// Método main, ponto de inicialização da aplicação
        /// </summary>
        /// <param name="args">Argumentos informados pela console</param>
        static void Main(string[] args)
        {
            // Adição do cachorro
            Cachorro c = new Cachorro();
            var msg1 = c.AdicionarCachorro(new Cachorro
            {
                Identificacao = 1,
                Nome = "Rex",
                Raca = "Tomba lata",
                Idade = 2,
                CPF = 99999999,
                Email = "edu@gmail.com",
                Endereco = "Rua do Cobre, 768",
                NomeDoDono = "Edu"
            });

            if (msg1 == "Cachorro cadastrado com sucesso!")
            {
                Console.WriteLine($"O cadastro do cachorro {c.Nome} foi realizado com sucesso!");
            }

            // Adição do gato
            Gato g = new Gato();
            var msg2 = g.AdicionarGato(new Gato
            {
                Identificacao = 1,
                Nome = "Miau",
                Raca = "Siames",
                Idade = 5,
                CPF = 88888888,
                Email = "carlos@gmail.com",
                Endereco = "Rua da Prata, 55",
                NomeDoDono = "Carlos"
            });

            if (msg2 == "Gato cadastrado com sucesso!")
            {
                Console.WriteLine($"O cadastro do gato {c.Nome} foi realizado com sucesso!");
            }
        }

        public class Cachorro
        {
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
            /// <param name="cachorro">Cachorro</param>
            /// <returns>Caso o cachorro seja inserido, retorna true</returns>
            public string AdicionarCachorro(Cachorro cachorro)
            {
                if (cachorro.Nome == string.Empty || cachorro.Idade == 0 || cachorro.Raca == string.Empty)
                    return "É obrigatório informar os dados do cachorro.";

                if (cachorro.NomeDoDono == string.Empty || cachorro.Email == string.Empty || cachorro.CPF == 0 || cachorro.Endereco == string.Empty)
                    return "É obrigatório informar os dados do dono do cachorro.";

                // Adição do cachorro
                Cachorros.Add(cachorro);

                // Envio do e-mail
                var mail = new MailMessage("comunicacao@petstore.com", Email);
                var client = new SmtpClient
                {
                    Port = 25,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Host = "smtp.google.com"
                };

                mail.Subject = "Bem vindo a Pet Store";
                mail.Body = $"Parabéns! Seu Pet {cachorro.Nome} foi cadastrado com sucesso!";
                client.Send(mail);

                return "Cachorro cadastrado com sucesso!";
            }
        }

        public class Gato
        {
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
            /// <param name="gato">Gato</param>
            /// <returns>Caso o gato seja inserido, retorna uma mensagem informando.</returns>
            public string AdicionarGato(Gato gato)
            {
                if (gato.Nome == string.Empty || gato.Idade == 0 || gato.Raca == string.Empty)
                    return "É obrigatório informar os dados do gato.";

                if (gato.NomeDoDono == string.Empty || gato.Email == string.Empty || gato.CPF == 0 || gato.Endereco == string.Empty)
                    return "É obrigatório informar os dados do dono do gato.";

                // Adição do gato
                Gatos.Add(gato);

                // Envio de e-mail
                var mail = new MailMessage("comunicacao@petstore.com", Email);
                var client = new SmtpClient
                {
                    Port = 25,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Host = "smtp.google.com"
                };

                mail.Subject = "Bem vindo a Pet Store";
                mail.Body = $"Parabéns! Seu Pet {gato.Nome} foi cadastrado com sucesso!";
                client.Send(mail);

                return "Gato cadastrado com sucesso!";
            }
        }
    }
}
