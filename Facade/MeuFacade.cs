using System.Runtime.InteropServices;
using System;
using MinhaFacade.SubSistemas;

namespace MinhaFacade.Facade
{
    public class MeuFacade
    {
        private LimiteCredito limite;
        private Serasa serasa;
        private Cadin cadin;
        private Cadastro cadastro;

        public MeuFacade()
        {
            limite = new LimiteCredito();
            serasa = new Serasa();
            cadin = new Cadin();
            cadastro = new Cadastro();
        }

        public bool ConcederEmprestimo(Cliente cliente, double valor)
        {
            Console.WriteLine($"{cliente.Nome} está pleiteando um empréstimo no valor de {valor:C}\n.");
            cadastro.CadastrarCliente(cliente);

            bool ConcederEmprestimo = true;

            if (serasa.EstaNoSerasa(cliente))
            {
                // Verifica SERASA
                Console.WriteLine($"Cliente {cliente.Nome} possui restrição no SERASA.");
                ConcederEmprestimo = false;
            }
            else if (cadin.EstaNoCadin(cliente))
            {
                // Verifica CADIN
                Console.WriteLine($"{cliente.Nome} possui restrição no CADIN.");
                ConcederEmprestimo = false;
            }
            else if (!limite.PossuiLimiteCredito(cliente, valor))
            {
                // Verifica se o cliente possui limite de crédito
                Console.WriteLine($"O cliente {cliente.Nome} possio limite de crédito inferior à {valor:C}.");
                ConcederEmprestimo = false;
            }
            return ConcederEmprestimo;
        }
    }
}