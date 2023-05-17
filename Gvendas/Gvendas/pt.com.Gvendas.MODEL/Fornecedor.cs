using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gvendas.pt.com.Gvendas.MODEL
{
    internal class Fornecedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string NomeEmpresa { get; set; }
        public int NumeroInterno { get; set; }

        public Fornecedor()
        {

        }

        public Fornecedor(int id)
        {
            Id = id;
        }

        public Fornecedor(int id, string nome, string nomeEmpresa, int numeroInterno)
        {
            Id = id;
            Nome = nome;
            NomeEmpresa = nomeEmpresa;
            NumeroInterno = numeroInterno;
        }
    }
}
