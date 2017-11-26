using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCAF.Model
{
    public abstract class Cotacao
    {
        public string Codigo { get; set; }

        public DateTime DataEmisao { get; set; }

        public string Observacao { get; set; }

        public DateTime DataFim { get; set; }

        public string StatusDaOferta { get; set; }

        public double Custo { get; set; }

        public double Desconto { get; set; }
        
        public string FormaPagamento { get; set; }

        public string Sc { get; set; }

        public bool IsVisible { get; set; }

        public string Fornecedor { get; set; }
    }
}
