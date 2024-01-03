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
            dgProduto.ColumnCount = 4;
            dgProduto.Columns[0].Name = "ID";
            dgProduto.Columns[1].Name = "Nome";
            dgProduto.Columns[2].Name = "Descrição";
            dgProduto.Columns[3].Name = "Valor";

            var rows = new List<string[]>();

            foreach (Produto prod in new Produto().Todos())
            {
                string[] row1 = new string[]
                {
                    prod.IdProd,
                    prod.Nome,
                    prod.Descricao,
                    "R$ " + prod.Valor.ToString()
                };
                rows.Add(row1);
                foreach (string[] rowArray in rows)
                {
                    dgProduto.Rows.Add(rowArray);
                }
            }
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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            dgProduto.Rows.Clear();

            var p = new Produto().Busca(txtPesquisar.Text);

            foreach (Produto prod in new Produto().Busca(txtPesquisar.Text))
            {
                string[] row1 = new string[]
                {
                    prod.IdProd,
                    prod.Nome,
                    prod.Descricao,
                    "R$ " + prod.Valor.ToString()
                };

                dgProduto.Rows.Add(row1);
            }
        }

        private void txtPesquisar_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
