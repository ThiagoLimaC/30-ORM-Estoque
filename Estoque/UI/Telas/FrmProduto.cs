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
        // Construtor
        public FrmProduto()
        {
            InitializeComponent();
        }

        // Form Load
        private void FrmProduto_Load(object sender, EventArgs e)
        {
            LoadAll();
        }

        // Métodos privados

        private void LimparCampos()
        {
            txtId.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtPreco.Text = string.Empty;
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

            var preco = txtPreco.Text.Replace("R$","").Replace(".", ",");
            produto.Valor = Decimal.Parse(preco);

            produto.Descricao = txtDescricao.Text;

            produto.Salvar(1);

            LimparCampos();
            LoadAll();

            MessageBox.Show("Produto cadastrado com sucesso!");
        }
    }
}
