using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI.Telas
{
    public partial class FrmProduto : Form
    {
        // Constructor
        public FrmProduto()
        {
            InitializeComponent();
        }

        // Form Load
        private void FrmProduto_Load(object sender, EventArgs e)
        {
            LoadAll();
        }

        // Private Methods

        private void LimparCampos()
        {
            txtId.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtDescricao.Text = string.Empty;
        }

        private void LoadAll()
        {
            dgProduto.AutoGenerateColumns = false;
            dgProduto.DataSource = new Produto().Todos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var produto = new Produto();

            produto.IdProd = txtId.Text;
            produto.Nome = txtNome.Text;
            produto.Descricao = txtDescricao.Text;

            produto.Salvar(1);

            LimparCampos();
            LoadAll();

            MessageBox.Show("Produto cadastrado com sucesso!");
        }
    }
}
