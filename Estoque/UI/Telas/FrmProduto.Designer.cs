
namespace UI.Telas
{
    partial class FrmProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.cpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.dgProduto = new System.Windows.Forms.DataGridView();
            this.txtPreco = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.rbExcluir = new System.Windows.Forms.RadioButton();
            this.rbEditar = new System.Windows.Forms.RadioButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel1.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 26;
            // 
            // cpId
            // 
            this.cpId.HeaderText = "Id do Produto";
            this.cpId.MinimumWidth = 6;
            this.cpId.Name = "cpId";
            this.cpId.Width = 125;
            // 
            // cpNome
            // 
            this.cpNome.HeaderText = "Nome do Produto";
            this.cpNome.MinimumWidth = 6;
            this.cpNome.Name = "cpNome";
            this.cpNome.Width = 125;
            // 
            // iconButton1
            // 
            this.iconButton1.Font = new System.Drawing.Font("Yu Gothic UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButton1.IconColor = System.Drawing.SystemColors.WindowFrame;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 20;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(877, 75);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.iconButton1.Size = new System.Drawing.Size(102, 27);
            this.iconButton1.TabIndex = 21;
            this.iconButton1.Text = "Pesquisar";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.panelDesktop);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 503);
            this.panel1.TabIndex = 25;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.dgProduto);
            this.panelDesktop.Controls.Add(this.txtPreco);
            this.panelDesktop.Controls.Add(this.label13);
            this.panelDesktop.Controls.Add(this.rbExcluir);
            this.panelDesktop.Controls.Add(this.rbEditar);
            this.panelDesktop.Controls.Add(this.iconButton2);
            this.panelDesktop.Controls.Add(this.textBox1);
            this.panelDesktop.Controls.Add(this.label12);
            this.panelDesktop.Controls.Add(this.label11);
            this.panelDesktop.Controls.Add(this.btnSalvar);
            this.panelDesktop.Controls.Add(this.txtDescricao);
            this.panelDesktop.Controls.Add(this.label10);
            this.panelDesktop.Controls.Add(this.txtNome);
            this.panelDesktop.Controls.Add(this.label9);
            this.panelDesktop.Controls.Add(this.label8);
            this.panelDesktop.Controls.Add(this.txtId);
            this.panelDesktop.Controls.Add(this.label5);
            this.panelDesktop.Controls.Add(this.label7);
            this.panelDesktop.Controls.Add(this.label6);
            this.panelDesktop.Controls.Add(this.label4);
            this.panelDesktop.Controls.Add(this.label3);
            this.panelDesktop.Controls.Add(this.iconPictureBox1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(0, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(765, 503);
            this.panelDesktop.TabIndex = 22;
            // 
            // dgProduto
            // 
            this.dgProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProduto.Location = new System.Drawing.Point(395, 254);
            this.dgProduto.Name = "dgProduto";
            this.dgProduto.RowHeadersWidth = 51;
            this.dgProduto.RowTemplate.Height = 29;
            this.dgProduto.Size = new System.Drawing.Size(353, 226);
            this.dgProduto.TabIndex = 49;
            // 
            // txtPreco
            // 
            this.txtPreco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPreco.Location = new System.Drawing.Point(193, 163);
            this.txtPreco.Mask = "$000,00";
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(173, 27);
            this.txtPreco.TabIndex = 48;
            this.txtPreco.ValidatingType = typeof(int);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label13.Location = new System.Drawing.Point(391, 163);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(367, 76);
            this.label13.TabIndex = 46;
            this.label13.Text = "Após selecionar o produto referente a ação esco-\r\nlhida os dados do mesmoficaram " +
    "disponíveis pa-\r\nra edição na aba Dados do produto (lado esquer-\r\ndo)";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rbExcluir
            // 
            this.rbExcluir.AutoSize = true;
            this.rbExcluir.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbExcluir.Location = new System.Drawing.Point(489, 123);
            this.rbExcluir.Name = "rbExcluir";
            this.rbExcluir.Size = new System.Drawing.Size(81, 27);
            this.rbExcluir.TabIndex = 45;
            this.rbExcluir.TabStop = true;
            this.rbExcluir.Text = "Excluir";
            this.rbExcluir.UseVisualStyleBackColor = true;
            // 
            // rbEditar
            // 
            this.rbEditar.AutoSize = true;
            this.rbEditar.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbEditar.Location = new System.Drawing.Point(391, 123);
            this.rbEditar.Name = "rbEditar";
            this.rbEditar.Size = new System.Drawing.Size(75, 27);
            this.rbEditar.TabIndex = 44;
            this.rbEditar.TabStop = true;
            this.rbEditar.Text = "Editar";
            this.rbEditar.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            this.iconButton2.Font = new System.Drawing.Font("Yu Gothic UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButton2.IconColor = System.Drawing.SystemColors.WindowFrame;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 20;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(647, 79);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.iconButton2.Size = new System.Drawing.Size(102, 27);
            this.iconButton2.TabIndex = 43;
            this.iconButton2.Text = "Pesquisar";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(391, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 27);
            this.textBox1.TabIndex = 42;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Yu Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label12.Location = new System.Drawing.Point(391, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(358, 34);
            this.label12.TabIndex = 41;
            this.label12.Text = "Para pesquisar um produto cadastrado insira o código\r\nde identificação (ID):\r\n";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(391, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(198, 22);
            this.label11.TabIndex = 40;
            this.label11.Text = "Pesquisar um produto:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.White;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvar.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalvar.Location = new System.Drawing.Point(10, 439);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(356, 52);
            this.btnSalvar.TabIndex = 39;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescricao.Location = new System.Drawing.Point(10, 310);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(356, 110);
            this.txtDescricao.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(10, 279);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 25);
            this.label10.TabIndex = 19;
            this.label10.Text = "Descrição:";
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Location = new System.Drawing.Point(10, 238);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(356, 27);
            this.txtNome.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(10, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 25);
            this.label9.TabIndex = 17;
            this.label9.Text = "Nome:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(183, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Valor:";
            // 
            // txtId
            // 
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtId.Location = new System.Drawing.Point(10, 163);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(161, 27);
            this.txtId.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(10, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "ID: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(6, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 22);
            this.label7.TabIndex = 12;
            this.label7.Text = "Dados do produto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label6.Location = new System.Drawing.Point(6, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(360, 34);
            this.label6.TabIndex = 11;
            this.label6.Text = "Para cadastrar um novo produto insira seus dados nos\r\ncampos abaixo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(75, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "manager";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(62, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Produto";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Computer;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 50;
            this.iconPictureBox1.Location = new System.Drawing.Point(6, 12);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(50, 50);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconPictureBox1.TabIndex = 7;
            this.iconPictureBox1.TabStop = false;
            // 
            // FrmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(765, 503);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(765, 503);
            this.MinimumSize = new System.Drawing.Size(765, 503);
            this.Name = "FrmProduto";
            this.Text = "FrmProduto";
            this.Load += new System.EventHandler(this.FrmProduto_Load);
            this.panel1.ResumeLayout(false);
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpNome;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton rbExcluir;
        private System.Windows.Forms.RadioButton rbEditar;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.MaskedTextBox txtPreco;
        private System.Windows.Forms.DataGridView dgProduto;
    }
}