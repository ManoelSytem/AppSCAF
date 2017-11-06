using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCAF.Model
{
    public class CotacaoServico : Cotacao
    {
        public int NumeroContrato { get; set; }

        public DateTime DateInicio { get; set; }

        public DateTime DateFim { get; set; }

        public Servico Servico { get; set; }
    }
}
