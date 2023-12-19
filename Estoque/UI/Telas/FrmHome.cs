using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI.Telas
{
    public partial class FrmHome : Form
    {
        // Forms declarados 
        FrmProduto FrmProduto;
        FrmCliente FrmCliente;
        FrmVenda FrmVenda;
        FrmEstoque FrmEstoque;
        FrmOrdemServico FrmOrdemServico;

        // Construtor 
        public FrmHome()
        {
            InitializeComponent();
            this.FrmProduto = new FrmProduto();
            this.FrmCliente = new FrmCliente();
            this.FrmVenda = new FrmVenda();
            this.FrmOrdemServico = new FrmOrdemServico();
        }

        // Métodos privados

        // Exibe Form Produto
        private void btnFrmProduto_Click(object sender, EventArgs e)
        {
            pnlDesktop.Controls.Clear();
            FrmProduto.TopLevel = false;
            FrmProduto.TopMost = false;
            FrmProduto.Dock = DockStyle.Fill;
            pnlDesktop.Controls.Add(FrmProduto);
            FrmProduto.Show();
        }
    }
}
