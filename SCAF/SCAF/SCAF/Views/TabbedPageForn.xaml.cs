using SCAF.Model;
using SCAF.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SCAF.Views.FornecedorView;

namespace SCAF.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedPageForn : TabbedPage
    {
        private Fornecedor novoForn;
        private Fornecedor fornecedor;
        public TabbedPageForn ()
        {
            InitializeComponent();
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var vm = BindingContext as FornecedorViewModel;
            fornecedor = e.Item as Fornecedor;
            vm.HideOrShowFornecedor(fornecedor);

        }

        private void CadastrarFornecedor(object sender, EventArgs e)
        {
            novoForn = new Fornecedor();
            novoForn.RazaoSocial = txtRazaoSocial.Text;
            novoForn.NomeFantasia = txtNomeFantasia.Text;
            novoForn.Cnpj = txtCnpj.Text;
            novoForn.Categoria = txtCategoria.Text;
            novoForn.Email = txtEmail.Text;
            novoForn.InscricaoEstadual = txtIncEstadual.Text;
            novoForn.Endereco = txtEndereco.Text;
            novoForn.Telefone = txtTelefone.Text;

            var vm = BindingContext as FornecedorViewModel;
            vm.HideOrShowFornecedor(novoForn);

        }

        private async void DetalheFornecedor(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FornecedorDetalhePage(fornecedor));
        }

        private void EditarFornecedor(object sender, EventArgs e)
        {
            var pages = Children.GetEnumerator();
            pages.MoveNext(); // First page
            pages.MoveNext(); // Second page
            CurrentPage = pages.Current;
        }
    }
}