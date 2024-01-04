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
            txtValor.Text = string.Empty;
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

            var preco = txtValor.Text.Replace("R$","").Replace(".", ",");
            produto.Valor = Decimal.Parse(preco);

            produto.Descricao = txtDescricao.Text;

            if (btnSalvar.Text == "Alterar")
            {
                produto.Salvar(2);
                btnSalvar.Text = "Salvar";
            }

            produto.Salvar(1);
            LimparCampos();
            LoadAll();

            MessageBox.Show("Produto cadastrado com sucesso!");
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            dgProduto.Rows.Clear();

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

        private void dgProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var prod = new Produto();

            foreach (DataGridViewRow row in dgProduto.Rows)
            {
                if (row != null && row.Index == 0)
                {
                    prod.IdProd = row.Cells["ID"].Value.ToString();
                    prod.Nome = row.Cells["Nome"].Value.ToString();
                    prod.Descricao = row.Cells["Descrição"].Value.ToString();

                    var p = row.Cells["Valor"].Value.ToString();
                    prod.Valor = Convert.ToDecimal(p.Replace("R$", ""));

                    break;
                }
            }

            txtId.Text = prod.IdProd;
            txtNome.Text = prod.Nome;
            txtDescricao.Text = prod.Descricao;
            txtValor.Text = prod.Valor.ToString();

            btnSalvar.Text = "Alterar";
        }
    }
}
