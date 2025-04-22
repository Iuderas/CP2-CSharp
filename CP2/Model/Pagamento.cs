using System;

namespace SistemaDePagamentos.Model
{
    public abstract class Pagamento
    {
        public decimal Valor { get; set; }
        public DateTime DataPagamento { get; set; }

        public Pagamento(decimal valor)
        {
            Valor = valor;
            DataPagamento = DateTime.Now;
        }

        public abstract void ProcessarPagamento();
    }
}
