using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gvendas.pt.com.Gvendas.MODEL
{
    internal class Produtos
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Valor { get; set; }
        public int Quantidade { get; set; }
        public int FornecedorID { get; set; }
        public Fornecedor fornecedor { get; set; }

        public Produtos()
        {

        }

        public Produtos(int id)
        {
            Id = id;
        }

        public Produtos(int id, string nome, string descricao, int valorProduto, int quantidade)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            Valor = valorProduto;
            Quantidade = quantidade;
        }
    }
}
