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
        public TabbedPageCotacao ()
        {
            InitializeComponent();
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

        private void ExibirFormsPro(object sender, EventArgs e)
        {

        }

        private void ExibirFormsServi(object sender, EventArgs e)
        {

        }
    }
}