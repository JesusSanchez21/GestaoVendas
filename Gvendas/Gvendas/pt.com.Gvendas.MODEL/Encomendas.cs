using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gvendas.pt.com.Gvendas.MODEL
{
    
        internal class Encomendas
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public int Valor { get; set; }
            public DateTime DataEncomenda { get; set; }
            public DateTime DataChegada { get; set; }

            public Encomendas()
            {

            }

            public Encomendas(int id)
            {
                Id = id;
            }

            public Encomendas(int id, string nome, int valorEncomenda, DateTime dataEncomenda, DateTime dataChegada)
            {
                Id = id;
                Nome = nome;
                Valor = valorEncomenda;
                DataEncomenda = dataEncomenda;
                DataChegada = dataChegada;
            }
        }
}
