using System;
using MinhaFacade.Facade;
using MinhaFacade.SubSistemas;

namespace MinhaFacade
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cria uma instância do Facade
            MeuFacade concedeEmprestimoFacade = new MeuFacade();

            // Cria uma instância de um novo cliente informando o seu nome
            Cliente cliente1 = new Cliente("Rodrigo");

            // Utiliza o Facade para verificar condições de concessão ou não
            bool resultado = concedeEmprestimoFacade.ConcederEmprestimo(cliente1, 190000.00);

            // Exibe Resultado
            Console.WriteLine($"O empréstimo pleiteado pleo cliente {cliente1.Nome} foi " + (resultado ? "Aprovado" : "Rejeitado"));

            // Aguarda
            Console.ReadKey();
        }
    }
}