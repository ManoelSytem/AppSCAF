using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCAF.Model
{
    public abstract class Cotacao
    {
        public string Codigo { get; private set; }

        public DateTime DataEmisao { get; private set; }

        public string Observacao { get; private set; }

        public DateTime DataFim { get; private set; }

        public string StatusDaOferta { get; private set; }

        public double Custo { get; private set; }

        public double Desconto { get; private set; }
        
        public List<string> FormaPagamento { get; private set; }

    }
}
