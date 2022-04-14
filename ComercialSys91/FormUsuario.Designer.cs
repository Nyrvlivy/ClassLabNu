namespace ComercialSys91
{
    partial class FormUsuario
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
            this.label8 = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.lstUsuarios = new System.Windows.Forms.ListBox();
            this.txtNivel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSenhaNov = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 13);
            this.label8.TabIndex = 50;
            this.label8.Text = "Lista dos Usuários em Registro:";
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(27, 410);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 49;
            this.btnListar.Text = "&Listar Todos";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lstUsuarios
            // 
            this.lstUsuarios.FormattingEnabled = true;
            this.lstUsuarios.Location = new System.Drawing.Point(27, 244);
            this.lstUsuarios.Name = "lstUsuarios";
            this.lstUsuarios.Size = new System.Drawing.Size(721, 160);
            this.lstUsuarios.TabIndex = 48;
            // 
            // txtNivel
            // 
            this.txtNivel.Location = new System.Drawing.Point(121, 154);
            this.txtNivel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNivel.MaxLength = 15;
            this.txtNivel.Name = "txtNivel";
            this.txtNivel.Size = new System.Drawing.Size(472, 20);
            this.txtNivel.TabIndex = 46;
            this.txtNivel.TextChanged += new System.EventHandler(this.txtNivel_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Nível:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Insira as informações para cadastro de Usuário:";
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(121, 178);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 24);
            this.btnInserir.TabIndex = 40;
            this.btnInserir.Text = "&Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "ID:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(121, 106);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.MaxLength = 60;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(472, 20);
            this.txtEmail.TabIndex = 35;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(121, 82);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(472, 20);
            this.txtNome.TabIndex = 34;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(121, 58);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(36, 20);
            this.txtId.TabIndex = 33;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Digite a senha novamente:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 51;
            this.label9.Text = "Senha:";
            // 
            // txtSenhaNov
            // 
            this.txtSenhaNov.Location = new System.Drawing.Point(430, 130);
            this.txtSenhaNov.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSenhaNov.MaxLength = 32;
            this.txtSenhaNov.Name = "txtSenhaNov";
            this.txtSenhaNov.Size = new System.Drawing.Size(163, 20);
            this.txtSenhaNov.TabIndex = 54;
            this.txtSenhaNov.TextChanged += new System.EventHandler(this.txtSenhaNov_TextChanged);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(121, 130);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSenha.MaxLength = 32;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(163, 20);
            this.txtSenha.TabIndex = 55;
            this.txtSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtSenhaNov);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.lstUsuarios);
            this.Controls.Add(this.txtNivel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtId);
            this.Name = "FormUsuario";
            this.Text = "Usuarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.ListBox lstUsuarios;
        private System.Windows.Forms.TextBox txtNivel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSenhaNov;
        private System.Windows.Forms.TextBox txtSenha;
    }
}