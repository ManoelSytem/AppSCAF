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
            TabtreeContentAtualizar.Title = "Atualizar";
            var pages = Children.GetEnumerator();
            pages.MoveNext(); // First page
            pages.MoveNext(); // Second page
            pages.MoveNext(); // tree page
            TabtreeContentAtualizar.IsVisible = true;
            CurrentPage = pages.Current;

            txt2RazaoSocial.Text = fornecedor.RazaoSocial;
            txt2NomeFantasia.Text =  fornecedor.NomeFantasia;
            txt2Cnpj.Text = fornecedor.Cnpj;
            txt2Categoria.Text = fornecedor.Categoria;
            txt2Email.Text= fornecedor.Email;
            txt2IncEstadual.Text = fornecedor.InscricaoEstadual;
            txt2Endereco.Text = fornecedor.InscricaoEstadual;
            txt2Telefone.Text = fornecedor.Telefone;

        }

        private void AtualizarFornecedor(object sender, EventArgs e)
        {
            fornecedor.RazaoSocial = txt2RazaoSocial.Text;
            fornecedor.NomeFantasia = txt2NomeFantasia.Text;
            fornecedor.Cnpj = txt2Cnpj.Text;
            fornecedor.Categoria = txt2Categoria.Text;
            fornecedor.Email = txt2Email.Text;
            fornecedor.InscricaoEstadual = txt2IncEstadual.Text;
            fornecedor.Endereco = txt2Endereco.Text;
            fornecedor.Telefone = txt2Telefone.Text;

            var vm = BindingContext as FornecedorViewModel;
            vm.HideOrShowFornecedor(fornecedor);
        }

        private async void DeletaFornecedor(object sender, EventArgs e)
        {
            var result = await DisplayAlert("Menssagem", "Deseja realmente deleta este fornecedor da sua lista ?", "OK", "Cancelar");
            if (result == true) // if it's equal to Ok
            {
                var vm = BindingContext as FornecedorViewModel;
                vm.DeleteFornecedor(fornecedor);
            }
            else // if it's equal to Cancel
            {
                return; // just return to the page and do nothing.
            }
        }

        private void CancelarAutalização(object sender, EventArgs e)
        {
            TabtreeContentAtualizar.Title = "";
            TabtreeContentAtualizar.IsVisible = false;
            txt2RazaoSocial.Text = null;
            txt2NomeFantasia.Text = null;
            txt2Cnpj.Text = null;
            txt2Categoria.Text = null;
            txt2IncEstadual.Text = null;
            txt2Endereco.Text = null;
        }
    }
   
}