using System;

namespace Gvendas.pt.com.Gvendas.MODEL
{

    internal class Encomendas
    {
        public int Id { get; set; }
        public int Cliente_id { get; set; }
        public int Funcionario_id { get; set; }
        public int ValorTotal { get; set; }
        public DateTime DataEncomenda { get; set; }

        public Encomendas()
        {

        }

        public Encomendas(int id)
        {
            Id = id;
        }

        public Encomendas(int id, int valorTotal, DateTime dataEncomenda, int cliente_id, int funcionario_id)
        {
            Id = id;
            ValorTotal = valorTotal;
            DataEncomenda = dataEncomenda;
            Cliente_id = cliente_id;
            Funcionario_id = funcionario_id;
        }
    }
}
