using System;

namespace SistemaPagamentos
{
    public static class Menu
    {
        public static void ExibirMenu()
        {
            Console.WriteLine();
            Console.WriteLine("====== Sistema de Processamento de Pagamentos ======");
            Console.WriteLine("=========== Escolha a forma de pagamento ===========");
            Console.WriteLine("1 - Pagamento com Cartão");
            Console.WriteLine("2 - Pagamento com Boleto");
            Console.WriteLine("3 - Sair");
            Console.WriteLine();
        }
    }
}