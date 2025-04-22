using System;

namespace SistemaDePagamentos.Model
{
    public class PagamentoCartao : Pagamento
    {
        public string NumeroCartao { get; set; }

        public PagamentoCartao(string numeroCartao, decimal valor)
            : base(valor)
        {
            NumeroCartao = numeroCartao;
        }

        public override void ProcessarPagamento()
        {
            Console.WriteLine($"Processando pagamento de R$ {Valor:F2} via Cartão (Número: {NumeroCartao}) na data {DataPagamento:dd/MM/yyyy}.");
        }
    }
}
