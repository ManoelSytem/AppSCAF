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

        public Produto Produto { get; set; }

    }
}
