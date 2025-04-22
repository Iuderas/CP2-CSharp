using System;
using CP2;
using SistemaDePagamentos.Model;

namespace SistemaDePagamentos
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;

            do
            {
                Menu.ExibirMenu(); 
                opcao = LerNumeroInteiro("");

                switch (opcao)
                {
                    case 1:
                        ProcessarPagamentoCartao();
                        break;

                    case 2:
                        ProcessarPagamentoBoleto();
                        break;

                    case 3:
                        Console.WriteLine("Saindo do sistema...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

            } while (opcao != 3);
        }

        static void ProcessarPagamentoCartao()
        {
            Console.Write("Informe o número do cartão: ");
            string numeroCartao = Console.ReadLine();

            decimal valorPagamento = LerValorPagamento();

            PagamentoCartao pagamentoCartao = new PagamentoCartao(numeroCartao, valorPagamento);
            pagamentoCartao.ProcessarPagamento();
        }

        static void ProcessarPagamentoBoleto()
        {
            Console.Write("Informe o código de barras: ");
            string codigoBarras = Console.ReadLine();

            decimal valorPagamento = LerValorPagamento();

            PagamentoBoleto pagamentoBoleto = new PagamentoBoleto(codigoBarras, valorPagamento);
            pagamentoBoleto.ProcessarPagamento();
        }

        static decimal LerValorPagamento()
        {
            decimal valorPagamento;
            while (true)
            {
                Console.Write("Informe o valor do pagamento: ");
                string entrada = Console.ReadLine();

                if (decimal.TryParse(entrada, out valorPagamento) && valorPagamento > 0)
                {
                    return valorPagamento;
                }
                else
                {
                    Console.WriteLine("Valor inválido. Por favor, insira um valor numérico válido maior que 0.");
                }
            }
        }

        static int LerNumeroInteiro(string mensagem)
        {
            int numero;
            while (true)
            {
                Console.Write(mensagem); 
                string entrada = Console.ReadLine();

                if (int.TryParse(entrada, out numero))
                {
                    return numero;
                }
                else
                {
                    Console.WriteLine("Opção inválida. Por favor, insira um número válido.");
                }
            }
        }
    }
}
