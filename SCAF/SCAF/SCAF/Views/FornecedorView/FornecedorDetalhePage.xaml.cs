using SCAF.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SCAF.Views.FornecedorView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FornecedorDetalhePage : ContentPage
    {
        public FornecedorDetalhePage(Fornecedor fornecedor)
        {
            InitializeComponent();
            lblNomeFantasia.Text = fornecedor.NomeFantasia;
            lblRazaoSocial.Text = fornecedor.RazaoSocial;
            lblCnpj.Text = fornecedor.Cnpj;
            lblIncEstadual.Text = fornecedor.InscricaoEstadual;
            lblEndereco.Text = fornecedor.Endereco;
            lblCategoria.Text = fornecedor.Categoria;
            lblEmail.Text = fornecedor.Email;
        }
    }
}