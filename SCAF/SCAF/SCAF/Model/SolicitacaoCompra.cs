using System;
using System.Collections.Generic;


namespace SCAF.Model
{
    public class SolicitacaoCompra
    {
        public string codigo { get; set; }

        public string Status { get; set; }

        public string TextColorStatus { get; set; }

        public bool IsVisible { get; set; }

        public DateTime DataEmisao { get; set; }

        public string Cliente { get; set; }

        public DateTime Prazo { get; set; }

        public string Observacao { get; set; }

        public string Solicitante { get; set; }
      
        public string Comprador { get; set; }

        public string Departamento { get; set; }

        public string FormaPagamento { get; set; }

        public string Tipo { get; set; }

    }

}
