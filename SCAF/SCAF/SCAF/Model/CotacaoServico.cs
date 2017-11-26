using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCAF.Model
{
    public class CotacaoServico : Cotacao
    {
        public string NumeroContrato { get; set; }

        public DateTime DateInicio { get; set; }

        public DateTime DateFim { get; set; }

        //alterar para tipo serviço
        public Servico Servico { get; set; }

        public string Nome { get; set; }

        public double Valor { get; set; }

    }
}
