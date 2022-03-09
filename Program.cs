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
        /// <summary>
        /// Método main, ponto de inicialização da aplicação
        /// </summary>
        /// <param name="args">Argumentos informados pela console</param>
        static void Main(string[] args)
        {
            // Adição do cachorro
            var dadosCachorro = new CadastroCachorro();

            var mensagemCachorro = dadosCachorro.AdicionarCachorro(new CadastroCachorro
            {
                Identificacao = 1,
                Nome = "Rex",
                Raca = "Tomba lata",
                Idade = 2,
                CPF = 99999999,
                Email = "edu@gmail.com",
                Endereco = "Rua do Cobre, 768",
                NomeDoDono = ""
            });

            if (mensagemCachorro == "Cachorro cadastrado com sucesso!")
                Console.WriteLine($"O cadastro do cachorro {dadosCachorro.Nome} foi realizado com sucesso!");
            else
                Console.WriteLine(mensagemCachorro);

            // Adição do gato
            var dadosGato = new CadastroGato();

            var mensagemGato = dadosGato.AdicionarGato(new CadastroGato
            {
                Identificacao = 1,
                Nome = "Miau",
                Raca = "Siames",
                Idade = 5,
                CPF = 88888888,
                Email = "carlos@gmail.com",
                Endereco = "Rua da Prata, 55",
                NomeDoDono = ""
            });

            if (mensagemGato == "Gato cadastrado com sucesso!")
                Console.WriteLine($"O cadastro do gato {dadosGato.Nome} foi realizado com sucesso!");
            else
                Console.WriteLine(mensagemGato);
        }
    }
}
