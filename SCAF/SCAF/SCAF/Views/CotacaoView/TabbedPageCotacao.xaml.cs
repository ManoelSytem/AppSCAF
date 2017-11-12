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
    public partial class TabbedPageCotacao : TabbedPage
    {
        public SolicitacaoCompraViewModel SolicitacaoCompraViewModel;

        public TabbedPageCotacao ()
        {
            InitializeComponent();
            SolicitacaoCompraViewModel = new SolicitacaoCompraViewModel();
            ScPicker.ItemsSource = SolicitacaoCompraViewModel.ScList();
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }

        private void DetalheCotacao(object sender, EventArgs e)
        {

        }

        private void IncluirCotação(object sender, EventArgs e)
        {

        }

        
    }
}