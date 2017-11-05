using SCAF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SCAF.Views.SolicitacaoCompraView
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SolicitacaoCompraDetalhe : ContentPage
	{
		public SolicitacaoCompraDetalhe (SolicitacaoCompra sc)
		{
			InitializeComponent();
            lblCliente.Text = sc.Cliente;
            lblDatEmisao.Text = Convert.ToString(sc.DataEmisao);
            lblSolicitante.Text = sc.Solicitante;
            lblDepartamento.Text = sc.Departamento;
            lblfrmPgto.Text = sc.FormaPagamento;
            lblPrazo.Text = Convert.ToString(sc.Prazo);
            lblStatus.Text = sc.Status;
            lblTipo.Text = sc.Tipo;
            lblObservacao.Text = sc.Observacao;
		}
	}
}