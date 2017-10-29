using SCAF.Model;
using SCAF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SCAF.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SolicitacaoCompraPage : ContentPage
    {
        private SolicitacaoCompra sc;

        public SolicitacaoCompraPage()
        {
            InitializeComponent();
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var vm = BindingContext as SolicitacaoCompraViewModel;
            sc = e.Item as SolicitacaoCompra;
            vm.HideOrShowFornecedor(sc);
        }
    }
}