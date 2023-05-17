using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gvendas.pt.com.Gvendas.MODEL
{
    internal class Funcionarios
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Morada { get; set; }
        public string Email { get; set; }
        public int Telefone { get; set; }
        public int NumeroInterno { get; set; }

        public Funcionarios()
        {

        }

        public Funcionarios(int id)
        {
            Id = id;
        }

        public Funcionarios(int id, string nome, string morada, string email, int telefone, int numeroInterno)
        {
            Id = id;
            Nome = nome;
            Morada = morada;
            Email = email;
            Telefone = telefone;
            NumeroInterno = numeroInterno;
        }
    }
}
