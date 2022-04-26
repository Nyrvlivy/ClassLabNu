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
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Insira as informações para cadastro do Produto:";
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(126, 180);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 24);
            this.btnInserir.TabIndex = 20;
            this.btnInserir.Text = "&Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Código de Barras:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Unidade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Descrição:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "ID:";
            // 
            // txtCodBar
            // 
            this.txtCodBar.Location = new System.Drawing.Point(126, 108);
            this.txtCodBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodBar.MaxLength = 13;
            this.txtCodBar.Name = "txtCodBar";
            this.txtCodBar.Size = new System.Drawing.Size(472, 20);
            this.txtCodBar.TabIndex = 14;
            this.txtCodBar.TextChanged += new System.EventHandler(this.txtCodBar_TextChanged);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(126, 84);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescricao.MaxLength = 100;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(472, 20);
            this.txtDescricao.TabIndex = 13;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(126, 60);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(36, 20);
            this.txtId.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Valor:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(354, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Desconto:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(617, 86);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(136, 17);
            this.checkBox1.TabIndex = 26;
            this.checkBox1.Text = "Produto descontinuado";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtUnidade
            // 
            this.txtUnidade.Location = new System.Drawing.Point(126, 132);
            this.txtUnidade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUnidade.MaxLength = 14;
            this.txtUnidade.Name = "txtUnidade";
            this.txtUnidade.Size = new System.Drawing.Size(472, 20);
            this.txtUnidade.TabIndex = 27;
            this.txtUnidade.TextChanged += new System.EventHandler(this.txtUnidade_TextChanged);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(126, 156);
            this.txtValor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtValor.MaxLength = 12;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(222, 20);
            this.txtValor.TabIndex = 28;
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(416, 156);
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
            this.label8.Location = new System.Drawing.Point(29, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Lista dos Produtos em Registro:";
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(32, 417);
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
            this.lstProdutos.Location = new System.Drawing.Point(32, 251);
            this.lstProdutos.Name = "lstProdutos";
            this.lstProdutos.Size = new System.Drawing.Size(721, 160);
            this.lstProdutos.TabIndex = 30;
            this.lstProdutos.SelectedIndexChanged += new System.EventHandler(this.lstProdutos_SelectedIndexChanged);
            // 
            // FormProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 463);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.lstProdutos);
            this.Controls.Add(this.txtDesconto);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtUnidade);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodBar);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtId);
            this.Name = "FormProduto";
            this.Text = "Produtos";
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}