using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gvendas.pt.com.Gvendas.MODEL
{
    internal class Pagamento
    {
        public int Id { get; set; }
        public bool EncomendaFeita { get; set; }
        public int Entidade { get; set; }
        public int Referencia { get; set; }
        public DateTime DataPagamento { get; set; }
        public int ValorTotal { get; set; }

        public Pagamento()
        {

        }

        public Pagamento(int id)
        {
            Id = id;
        }
        public Pagamento(int id, bool encomendaFeita, int entidade, int referencia, DateTime dataPagamento, int valorTotal)
        {
            Id = id;
            EncomendaFeita = encomendaFeita;
            Entidade = entidade;
            Referencia = referencia;
            DataPagamento = dataPagamento;
            ValorTotal = valorTotal;
        }
    }
}
