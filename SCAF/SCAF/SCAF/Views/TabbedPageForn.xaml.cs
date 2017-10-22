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
    public partial class TabbedPageForn : TabbedPage
    {
        public TabbedPageForn ()
        {
            InitializeComponent();
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var vm = BindingContext as FornecedorViewModel;
            var fornecedor = e.Item as Fornecedor;
            vm.HideOrShowFornecedor(fornecedor);
        }
    }
}