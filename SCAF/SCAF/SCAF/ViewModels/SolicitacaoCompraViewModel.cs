using SCAF.Model;
using SCAF.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace SCAF.ViewModels
{
    public class SolicitacaoCompraViewModel : NotificarBase
    {
        public SolicitacaoCompraService ScServico;
        public string status;
        public string Status { get { return status; } set { status = value; Notificar(); } }

        public DateTime dataEmisao;
        public DateTime DataEmisao { get { return dataEmisao; } set { dataEmisao = value; Notificar(); } }

        public string textColorStatus;
        public string TextColorStatus { get { return textColorStatus; } set { textColorStatus = value; Notificar(); } }

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
        private SolicitacaoCompra _oldFornecedor;

        public List<string> FormaPagamento { get { return formaPagamento; } set { formaPagamento = value; Notificar(); } }

        public ObservableCollection<SolicitacaoCompra> SolicitacaoCompra { get; set; }

        public SolicitacaoCompraViewModel()
        {
            ScServico = new SolicitacaoCompraService();
            SolicitacaoCompra = new ObservableCollection<SolicitacaoCompra>
            {
            };
            SolicitacaoCompra = ScServico.GetSc();

        }

        public void HideOrShowFornecedor(SolicitacaoCompra sc)
        {
            if (_oldFornecedor == sc)
            {
                sc.IsVisible = !sc.IsVisible;
                UpdateFornecedor(sc);
            }
            else
            {
                if (_oldFornecedor != null)
                {
                    _oldFornecedor.IsVisible = false;
                    UpdateFornecedor(sc);
                }
                sc.IsVisible = true;
                UpdateFornecedor(sc);
            }

            _oldFornecedor = sc;
        }

        private void UpdateFornecedor(SolicitacaoCompra sc)
        {
            var Index = SolicitacaoCompra.IndexOf(sc);
                SolicitacaoCompra.Remove(sc);
                SolicitacaoCompra.Insert(Index, sc);
        }

        public List<string> ScList()
        {
            var LisSolicitacaoCompra = new List<string>();
            foreach (var sc in SolicitacaoCompra)
            {
                LisSolicitacaoCompra.Add("SC-"+sc.codigo + "-" + sc.Tipo);
            }

            return LisSolicitacaoCompra;
        }
    }
}
