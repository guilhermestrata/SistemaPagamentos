using System;

namespace SistemaPagamentos.Models
{
    public abstract class Pagamento
    {
        public double Valor { get; set; }
        public DateTime Data { get; set; }

        public abstract string ProcessarPagamento();
    }
}