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
        private List<Fornecedor> fornecedor;
        private Fornecedor novoForn;
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
    }
}