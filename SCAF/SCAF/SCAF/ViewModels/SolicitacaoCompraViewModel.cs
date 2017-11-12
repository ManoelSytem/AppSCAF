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
