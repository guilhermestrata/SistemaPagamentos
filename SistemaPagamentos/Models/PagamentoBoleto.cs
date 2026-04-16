using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPagamentos.Models
{
    internal class PagamentoBoleto : Pagamento
    {
        public string CodigoBarras { get; set; }

        public override string ProcessarPagamento()
        {
            return $"Processando pagamento de R$ {Valor:F2} via Boleto (Código de barras: {CodigoBarras}) na data {Data:dd/MM/yyyy}.";
        }
    }
}
