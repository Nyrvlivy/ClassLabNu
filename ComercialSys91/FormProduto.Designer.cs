namespace ComercialSys91
{
    partial class FormProduto
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
            this.label5 = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodBar = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtUnidade = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.lstProdutos = new System.Windows.Forms.ListBox();
            this.grbCadastroProd = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.picbProduto = new System.Windows.Forms.PictureBox();
            this.grbCadastroProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Insira as informações para cadastro do Produto:";
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(648, 164);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 44);
            this.btnInserir.TabIndex = 20;
            this.btnInserir.Text = "&Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Código de Barras:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Unidade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Descrição:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "ID:";
            // 
            // txtCodBar
            // 
            this.txtCodBar.Location = new System.Drawing.Point(121, 112);
            this.txtCodBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodBar.MaxLength = 13;
            this.txtCodBar.Name = "txtCodBar";
            this.txtCodBar.Size = new System.Drawing.Size(472, 20);
            this.txtCodBar.TabIndex = 14;
            this.txtCodBar.TextChanged += new System.EventHandler(this.txtCodBar_TextChanged);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(121, 88);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescricao.MaxLength = 100;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(472, 20);
            this.txtDescricao.TabIndex = 13;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(121, 64);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(36, 20);
            this.txtId.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Valor:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(349, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Desconto:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(457, 191);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(136, 17);
            this.checkBox1.TabIndex = 26;
            this.checkBox1.Text = "Produto descontinuado";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtUnidade
            // 
            this.txtUnidade.Location = new System.Drawing.Point(121, 136);
            this.txtUnidade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUnidade.MaxLength = 14;
            this.txtUnidade.Name = "txtUnidade";
            this.txtUnidade.Size = new System.Drawing.Size(472, 20);
            this.txtUnidade.TabIndex = 27;
            this.txtUnidade.TextChanged += new System.EventHandler(this.txtUnidade_TextChanged);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(121, 160);
            this.txtValor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtValor.MaxLength = 12;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(222, 20);
            this.txtValor.TabIndex = 28;
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(411, 160);
            this.txtDesconto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDesconto.MaxLength = 12;
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(182, 20);
            this.txtDesconto.TabIndex = 29;
            this.txtDesconto.TextChanged += new System.EventHandler(this.txtDesconto_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Lista dos Produtos em Registro:";
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(27, 442);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 31;
            this.btnListar.Text = "&Listar Todos";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lstProdutos
            // 
            this.lstProdutos.FormattingEnabled = true;
            this.lstProdutos.Location = new System.Drawing.Point(27, 276);
            this.lstProdutos.Name = "lstProdutos";
            this.lstProdutos.Size = new System.Drawing.Size(566, 160);
            this.lstProdutos.TabIndex = 30;
            this.lstProdutos.SelectedIndexChanged += new System.EventHandler(this.lstProdutos_SelectedIndexChanged);
            // 
            // grbCadastroProd
            // 
            this.grbCadastroProd.Controls.Add(this.picbProduto);
            this.grbCadastroProd.Controls.Add(this.btnlimpar);
            this.grbCadastroProd.Controls.Add(this.btnBuscar);
            this.grbCadastroProd.Controls.Add(this.btnAlterar);
            this.grbCadastroProd.Controls.Add(this.label5);
            this.grbCadastroProd.Controls.Add(this.label8);
            this.grbCadastroProd.Controls.Add(this.txtId);
            this.grbCadastroProd.Controls.Add(this.btnListar);
            this.grbCadastroProd.Controls.Add(this.txtDescricao);
            this.grbCadastroProd.Controls.Add(this.lstProdutos);
            this.grbCadastroProd.Controls.Add(this.txtCodBar);
            this.grbCadastroProd.Controls.Add(this.txtDesconto);
            this.grbCadastroProd.Controls.Add(this.label1);
            this.grbCadastroProd.Controls.Add(this.txtValor);
            this.grbCadastroProd.Controls.Add(this.label2);
            this.grbCadastroProd.Controls.Add(this.txtUnidade);
            this.grbCadastroProd.Controls.Add(this.label3);
            this.grbCadastroProd.Controls.Add(this.checkBox1);
            this.grbCadastroProd.Controls.Add(this.label4);
            this.grbCadastroProd.Controls.Add(this.label7);
            this.grbCadastroProd.Controls.Add(this.btnInserir);
            this.grbCadastroProd.Controls.Add(this.label6);
            this.grbCadastroProd.Location = new System.Drawing.Point(12, 12);
            this.grbCadastroProd.Name = "grbCadastroProd";
            this.grbCadastroProd.Size = new System.Drawing.Size(775, 489);
            this.grbCadastroProd.TabIndex = 33;
            this.grbCadastroProd.TabStop = false;
            this.grbCadastroProd.Text = "Cadastro de Produtos";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Enabled = false;
            this.btnAlterar.Location = new System.Drawing.Point(648, 109);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 33;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(163, 64);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(61, 20);
            this.btnBuscar.TabIndex = 36;
            this.btnBuscar.Text = "...";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnlimpar
            // 
            this.btnlimpar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnlimpar.Enabled = false;
            this.btnlimpar.Location = new System.Drawing.Point(648, 81);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(74, 23);
            this.btnlimpar.TabIndex = 37;
            this.btnlimpar.Text = "&Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            // 
            // picbProduto
            // 
            this.picbProduto.Location = new System.Drawing.Point(622, 276);
            this.picbProduto.Name = "picbProduto";
            this.picbProduto.Size = new System.Drawing.Size(122, 160);
            this.picbProduto.TabIndex = 38;
            this.picbProduto.TabStop = false;
            // 
            // FormProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 518);
            this.Controls.Add(this.grbCadastroProd);
            this.Name = "FormProduto";
            this.Text = "Produtos";
            this.grbCadastroProd.ResumeLayout(false);
            this.grbCadastroProd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbProduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodBar;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtUnidade;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.ListBox lstProdutos;
        private System.Windows.Forms.GroupBox grbCadastroProd;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.PictureBox picbProduto;
    }
}