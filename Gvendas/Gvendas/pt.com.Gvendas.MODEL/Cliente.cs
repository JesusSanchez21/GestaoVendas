using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gvendas
{
    internal class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Morada { get; set; }
        public string Email { get; set; }
        public int Telefone { get; set; }

        public Cliente()
        {

        }

        public Cliente(int id)
        {
            Id = id;
        }

        public Cliente(int id, string nome, string morada, string email, int telefone)
        {
            Id = id;
            Nome = nome;
            Morada = morada;
            Email = email;
            Telefone = telefone;
        }
    }
}
