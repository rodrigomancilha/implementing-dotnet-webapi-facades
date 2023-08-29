using System;

namespace MinhaFacade.SubSistemas
{
    public class Cadastro
    {
        public void CadastrarCliente(Cliente cliente)
        {
            Console.WriteLine($"Cadastro do cliente {cliente.Nome} concluído.");
        }
    }
}