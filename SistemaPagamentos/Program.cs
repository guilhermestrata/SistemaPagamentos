using SistemaPagamentos.Models;
using System;

namespace SistemaPagamentos
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;

            do
            {
                Menu.ExibirMenu();

                Console.Write("Escolha uma opção: ");
                string entrada = Console.ReadLine();

                if (!int.TryParse(entrada, out opcao))
                {
                    Console.WriteLine("Opção inválida!");
                    continue;
                }

                switch (opcao)
                {
                    case 1:
                        ProcessarCartao();
                        break;

                    case 2:
                        ProcessarBoleto();
                        break;

                    case 3:
                        Console.WriteLine("Encerrando o sistema...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

            } while (opcao != 3);
        }

        static void ProcessarCartao()
        {
            double valor = LerValor();

            Console.Write("Informe o número do cartão: ");
            string numero = Console.ReadLine();

            var pagamento = new PagamentoCartao
            {
                Valor = valor,
                NumeroCartao = numero,
                Data = DateTime.Now
            };

            Console.WriteLine(pagamento.ProcessarPagamento());
        }

        static void ProcessarBoleto()
        {
            double valor = LerValor();

            Console.Write("Informe o código de barras: ");
            string codigo = Console.ReadLine();

            var pagamento = new PagamentoBoleto
            {
                Valor = valor,
                CodigoBarras = codigo,
                Data = DateTime.Now
            };

            Console.WriteLine(pagamento.ProcessarPagamento());
        }

        static double LerValor()
        {
            double valor;

            while (true)
            {
                Console.Write("Informe o valor do pagamento: ");

                string entrada = Console.ReadLine();

                if (double.TryParse(entrada, out valor))
                    return valor;

                Console.WriteLine("Valor inválido! Tente novamente.");
            }
        }
    }
}