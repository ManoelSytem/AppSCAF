using SCAF.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;


namespace SCAF.ViewModels
{
    public class SolicitacaoCompraViewModel : NotificarBase
    {
        public string status;
        public string Status { get { return status; } set { status = value; Notificar(); } }

        public DateTime dataEmisao;
        public DateTime DataEmisao { get { return dataEmisao; } set { dataEmisao = value; Notificar(); } }

        public string cliente;
        public string Cliente { get { return cliente; } set { cliente = value; Notificar(); } }

        public DateTime prazo;
        public DateTime Prazo { get { return prazo; } set { prazo = value; Notificar(); } }

        public string observacao;
        public string Observacao { get { return observacao; } set { observacao = value; Notificar(); } }

        public string solicitante;
        public string Solicitante { get { return solicitante; } set { solicitante = value; Notificar(); } }

        public string comprador;
        public string Comprador { get { return comprador; } set { comprador = value; Notificar(); } }

        public string departamento;
        public string Departamento { get { return departamento; } set { departamento = value; Notificar(); } }

        public List<string> formaPagamento;
        public List<string> FormaPagamento { get { return formaPagamento; } set { formaPagamento = value; Notificar(); } }

        public ObservableCollection<SolicitacaoCompra> SolicitacaoCompra { get; set; }

        public SolicitacaoCompraViewModel()
        {
            SolicitacaoCompra = new ObservableCollection<SolicitacaoCompra>
           {
               new SolicitacaoCompra()
               {


               }

           };
        }


    }
}
