using System;

namespace MinhaFacade.SubSistemas
{
    public class Cliente
    {
        public string Nome { get; set; }
        public Cliente(string nome)
        {
            Nome = nome;
        }
    }
}