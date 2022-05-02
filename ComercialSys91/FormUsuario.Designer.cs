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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblNivel = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNomeUser = new System.Windows.Forms.Label();
            this.txtEmailUser = new System.Windows.Forms.TextBox();
            this.txtNomeUser = new System.Windows.Forms.TextBox();
            this.lblSenhaNovamente = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenhaNov = new System.Windows.Forms.TextBox();
            this.txtSenhaUser = new System.Windows.Forms.TextBox();
            this.grbDadosGerais = new System.Windows.Forms.GroupBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnNovoUsuario = new System.Windows.Forms.Button();
            this.chBoxId = new System.Windows.Forms.CheckBox();
            this.chBoxNome = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblIdUsuario = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnListarUsuarios = new System.Windows.Forms.Button();
            this.cmbNivel = new System.Windows.Forms.ComboBox();
            this.clmIdCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbDadosGerais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Location = new System.Drawing.Point(21, 176);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(36, 13);
            this.lblNivel.TabIndex = 42;
            this.lblNivel.Text = "Nível:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(21, 127);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 39;
            this.lblEmail.Text = "Email:";
            // 
            // lblNomeUser
            // 
            this.lblNomeUser.AutoSize = true;
            this.lblNomeUser.Location = new System.Drawing.Point(19, 103);
            this.lblNomeUser.Name = "lblNomeUser";
            this.lblNomeUser.Size = new System.Drawing.Size(38, 13);
            this.lblNomeUser.TabIndex = 37;
            this.lblNomeUser.Text = "Nome:";
            // 
            // txtEmailUser
            // 
            this.txtEmailUser.Location = new System.Drawing.Point(68, 124);
            this.txtEmailUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmailUser.MaxLength = 60;
            this.txtEmailUser.Name = "txtEmailUser";
            this.txtEmailUser.Size = new System.Drawing.Size(472, 20);
            this.txtEmailUser.TabIndex = 35;
            this.txtEmailUser.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtNomeUser
            // 
            this.txtNomeUser.Location = new System.Drawing.Point(68, 100);
            this.txtNomeUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeUser.MaxLength = 100;
            this.txtNomeUser.Name = "txtNomeUser";
            this.txtNomeUser.Size = new System.Drawing.Size(472, 20);
            this.txtNomeUser.TabIndex = 34;
            this.txtNomeUser.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // lblSenhaNovamente
            // 
            this.lblSenhaNovamente.AutoSize = true;
            this.lblSenhaNovamente.Location = new System.Drawing.Point(237, 151);
            this.lblSenhaNovamente.Name = "lblSenhaNovamente";
            this.lblSenhaNovamente.Size = new System.Drawing.Size(134, 13);
            this.lblSenhaNovamente.TabIndex = 52;
            this.lblSenhaNovamente.Text = "Digite a senha novamente:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(21, 151);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(41, 13);
            this.lblSenha.TabIndex = 51;
            this.lblSenha.Text = "Senha:";
            // 
            // txtSenhaNov
            // 
            this.txtSenhaNov.Location = new System.Drawing.Point(377, 148);
            this.txtSenhaNov.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSenhaNov.MaxLength = 32;
            this.txtSenhaNov.Name = "txtSenhaNov";
            this.txtSenhaNov.Size = new System.Drawing.Size(163, 20);
            this.txtSenhaNov.TabIndex = 54;
            this.txtSenhaNov.TextChanged += new System.EventHandler(this.txtSenhaNov_TextChanged);
            // 
            // txtSenhaUser
            // 
            this.txtSenhaUser.Location = new System.Drawing.Point(68, 148);
            this.txtSenhaUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSenhaUser.MaxLength = 32;
            this.txtSenhaUser.Name = "txtSenhaUser";
            this.txtSenhaUser.Size = new System.Drawing.Size(163, 20);
            this.txtSenhaUser.TabIndex = 55;
            this.txtSenhaUser.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            // 
            // grbDadosGerais
            // 
            this.grbDadosGerais.Controls.Add(this.cmbNivel);
            this.grbDadosGerais.Controls.Add(this.comboBox3);
            this.grbDadosGerais.Controls.Add(this.btnNovoUsuario);
            this.grbDadosGerais.Controls.Add(this.txtSenhaUser);
            this.grbDadosGerais.Controls.Add(this.label18);
            this.grbDadosGerais.Controls.Add(this.chBoxId);
            this.grbDadosGerais.Controls.Add(this.txtSenhaNov);
            this.grbDadosGerais.Controls.Add(this.btnlimpar);
            this.grbDadosGerais.Controls.Add(this.chBoxNome);
            this.grbDadosGerais.Controls.Add(this.label7);
            this.grbDadosGerais.Controls.Add(this.lblSenhaNovamente);
            this.grbDadosGerais.Controls.Add(this.btnExcluir);
            this.grbDadosGerais.Controls.Add(this.btnAlterar);
            this.grbDadosGerais.Controls.Add(this.dgvUsuarios);
            this.grbDadosGerais.Controls.Add(this.lblSenha);
            this.grbDadosGerais.Controls.Add(this.txtIdUsuario);
            this.grbDadosGerais.Controls.Add(this.btnBuscar);
            this.grbDadosGerais.Controls.Add(this.lblIdUsuario);
            this.grbDadosGerais.Controls.Add(this.lblUser);
            this.grbDadosGerais.Controls.Add(this.btnListarUsuarios);
            this.grbDadosGerais.Controls.Add(this.lblNomeUser);
            this.grbDadosGerais.Controls.Add(this.lblNivel);
            this.grbDadosGerais.Controls.Add(this.lblEmail);
            this.grbDadosGerais.Controls.Add(this.txtNomeUser);
            this.grbDadosGerais.Controls.Add(this.txtEmailUser);
            this.grbDadosGerais.Location = new System.Drawing.Point(12, 12);
            this.grbDadosGerais.Name = "grbDadosGerais";
            this.grbDadosGerais.Size = new System.Drawing.Size(1287, 319);
            this.grbDadosGerais.TabIndex = 56;
            this.grbDadosGerais.TabStop = false;
            this.grbDadosGerais.Text = "Dados Gerais";
            // 
            // comboBox3
            // 
            this.comboBox3.Enabled = false;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.comboBox3.Location = new System.Drawing.Point(1203, 275);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(35, 21);
            this.comboBox3.TabIndex = 48;
            this.comboBox3.Visible = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(1151, 278);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(46, 13);
            this.label18.TabIndex = 28;
            this.label18.Text = " - Inicial:";
            this.label18.Visible = false;
            // 
            // btnNovoUsuario
            // 
            this.btnNovoUsuario.Location = new System.Drawing.Point(450, 219);
            this.btnNovoUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNovoUsuario.Name = "btnNovoUsuario";
            this.btnNovoUsuario.Size = new System.Drawing.Size(90, 72);
            this.btnNovoUsuario.TabIndex = 26;
            this.btnNovoUsuario.Text = "&Novo Usuário";
            this.btnNovoUsuario.UseVisualStyleBackColor = true;
            // 
            // chBoxId
            // 
            this.chBoxId.AutoSize = true;
            this.chBoxId.Location = new System.Drawing.Point(1101, 294);
            this.chBoxId.Name = "chBoxId";
            this.chBoxId.Size = new System.Drawing.Size(37, 17);
            this.chBoxId.TabIndex = 24;
            this.chBoxId.Text = "ID";
            this.chBoxId.UseVisualStyleBackColor = true;
            // 
            // chBoxNome
            // 
            this.chBoxNome.AutoSize = true;
            this.chBoxNome.Location = new System.Drawing.Point(1101, 277);
            this.chBoxNome.Name = "chBoxNome";
            this.chBoxNome.Size = new System.Drawing.Size(54, 17);
            this.chBoxNome.TabIndex = 23;
            this.chBoxNome.Text = "Nome";
            this.chBoxNome.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1032, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Ordenar por:";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AccessibleName = "dgvClientes";
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIdCli,
            this.clnNome,
            this.clnCpf,
            this.clnEmail});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsuarios.Location = new System.Drawing.Point(573, 36);
            this.dgvUsuarios.MultiSelect = false;
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(683, 235);
            this.dgvUsuarios.TabIndex = 0;
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Location = new System.Drawing.Point(68, 76);
            this.txtIdUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.ReadOnly = true;
            this.txtIdUsuario.Size = new System.Drawing.Size(36, 20);
            this.txtIdUsuario.TabIndex = 4;
            // 
            // btnlimpar
            // 
            this.btnlimpar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnlimpar.Enabled = false;
            this.btnlimpar.Location = new System.Drawing.Point(466, 72);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(74, 23);
            this.btnlimpar.TabIndex = 19;
            this.btnlimpar.Text = "&Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(110, 76);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(61, 20);
            this.btnBuscar.TabIndex = 18;
            this.btnBuscar.Text = "...";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // lblIdUsuario
            // 
            this.lblIdUsuario.AutoSize = true;
            this.lblIdUsuario.Location = new System.Drawing.Point(21, 79);
            this.lblIdUsuario.Name = "lblIdUsuario";
            this.lblIdUsuario.Size = new System.Drawing.Size(21, 13);
            this.lblIdUsuario.TabIndex = 4;
            this.lblIdUsuario.Text = "ID:";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Location = new System.Drawing.Point(22, 277);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Enabled = false;
            this.btnAlterar.Location = new System.Drawing.Point(22, 248);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 13;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(21, 36);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(231, 13);
            this.lblUser.TabIndex = 9;
            this.lblUser.Text = "Insira as informações para cadastro de Usuário:";
            this.lblUser.Click += new System.EventHandler(this.label15_Click);
            // 
            // btnListarUsuarios
            // 
            this.btnListarUsuarios.Location = new System.Drawing.Point(573, 277);
            this.btnListarUsuarios.Name = "btnListarUsuarios";
            this.btnListarUsuarios.Size = new System.Drawing.Size(75, 23);
            this.btnListarUsuarios.TabIndex = 11;
            this.btnListarUsuarios.Text = "&Listar Todos";
            this.btnListarUsuarios.UseVisualStyleBackColor = true;
            // 
            // cmbNivel
            // 
            this.cmbNivel.FormattingEnabled = true;
            this.cmbNivel.Location = new System.Drawing.Point(68, 173);
            this.cmbNivel.Name = "cmbNivel";
            this.cmbNivel.Size = new System.Drawing.Size(472, 21);
            this.cmbNivel.TabIndex = 56;
            // 
            // clmIdCli
            // 
            this.clmIdCli.Frozen = true;
            this.clmIdCli.HeaderText = "Id";
            this.clmIdCli.Name = "clmIdCli";
            this.clmIdCli.ReadOnly = true;
            this.clmIdCli.Width = 40;
            // 
            // clnNome
            // 
            this.clnNome.Frozen = true;
            this.clnNome.HeaderText = "Nome";
            this.clnNome.Name = "clnNome";
            this.clnNome.ReadOnly = true;
            this.clnNome.Width = 220;
            // 
            // clnCpf
            // 
            this.clnCpf.Frozen = true;
            this.clnCpf.HeaderText = "Email";
            this.clnCpf.Name = "clnCpf";
            this.clnCpf.ReadOnly = true;
            this.clnCpf.Width = 220;
            // 
            // clnEmail
            // 
            this.clnEmail.Frozen = true;
            this.clnEmail.HeaderText = "Nível";
            this.clnEmail.Name = "clnEmail";
            this.clnEmail.ReadOnly = true;
            this.clnEmail.Width = 200;
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 349);
            this.Controls.Add(this.grbDadosGerais);
            this.Name = "FormUsuario";
            this.Text = "Usuarios";
            this.grbDadosGerais.ResumeLayout(false);
            this.grbDadosGerais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNomeUser;
        private System.Windows.Forms.TextBox txtEmailUser;
        private System.Windows.Forms.TextBox txtNomeUser;
        private System.Windows.Forms.Label lblSenhaNovamente;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenhaNov;
        private System.Windows.Forms.TextBox txtSenhaUser;
        private System.Windows.Forms.GroupBox grbDadosGerais;
        private System.Windows.Forms.ComboBox cmbNivel;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.CheckBox chBoxId;
        private System.Windows.Forms.CheckBox chBoxNome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblIdUsuario;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnListarUsuarios;
        private System.Windows.Forms.Button btnNovoUsuario;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIdCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnEmail;
    }
}