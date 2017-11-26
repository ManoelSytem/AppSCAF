using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCAF.Model
{
    public  class CotacaoProduto : Cotacao
    {
        public int QtdProduto { get; set; }

        public string Nome { get; set; }

        //alterar para tipo produto
        public Produto Produto { get; set; }

        public double Valor { get; set; }

    }
}
