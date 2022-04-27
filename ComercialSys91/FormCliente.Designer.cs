namespace ComercialSys91
{
    partial class FormCliente
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnDesativar = new System.Windows.Forms.Button();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpDataCad = new System.Windows.Forms.DateTimePicker();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.clmIdCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnAtivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.grbDadosGerais = new System.Windows.Forms.GroupBox();
            this.chBoxId = new System.Windows.Forms.CheckBox();
            this.chBoxNome = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.grbEndereco = new System.Windows.Forms.GroupBox();
            this.btnCadastroManual = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.btnAlterarCep = new System.Windows.Forms.Button();
            this.cmBoxUf = new System.Windows.Forms.ComboBox();
            this.txtUf = new System.Windows.Forms.TextBox();
            this.btnBuscarCep = new System.Windows.Forms.Button();
            this.mskTxtCep = new System.Windows.Forms.MaskedTextBox();
            this.cmBoxEstado = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.grbTelefones = new System.Windows.Forms.GroupBox();
            this.btnAlterarTel = new System.Windows.Forms.Button();
            this.btnTel = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.grbDadosGerais.SuspendLayout();
            this.grbEndereco.SuspendLayout();
            this.grbTelefones.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(62, 75);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(36, 20);
            this.txtId.TabIndex = 4;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(62, 101);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNome.MaxLength = 60;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(348, 20);
            this.txtNome.TabIndex = 0;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(62, 127);
            this.txtCpf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCpf.MaxLength = 11;
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(81, 20);
            this.txtCpf.TabIndex = 1;
            this.txtCpf.TextChanged += new System.EventHandler(this.txtCpf_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(199, 127);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.MaxLength = 60;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(211, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "CPF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email:";
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(993, 610);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(121, 50);
            this.btnInserir.TabIndex = 3;
            this.btnInserir.Text = "&Inserir Dados";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Insira as informações para cadastro de Cliente:";
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(448, 261);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 11;
            this.btnListar.Text = "&Listar Todos";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(23, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Status:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Enabled = false;
            this.btnAlterar.Location = new System.Drawing.Point(107, 261);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 13;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnDesativar
            // 
            this.btnDesativar.Enabled = false;
            this.btnDesativar.Location = new System.Drawing.Point(26, 261);
            this.btnDesativar.Name = "btnDesativar";
            this.btnDesativar.Size = new System.Drawing.Size(75, 23);
            this.btnDesativar.TabIndex = 14;
            this.btnDesativar.Text = "&Desativar";
            this.btnDesativar.UseVisualStyleBackColor = true;
            this.btnDesativar.Click += new System.EventHandler(this.btnDesativar_Click);
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Enabled = false;
            this.chkAtivo.Location = new System.Drawing.Point(69, 165);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(50, 17);
            this.chkAtivo.TabIndex = 15;
            this.chkAtivo.Text = "Ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            this.chkAtivo.CheckedChanged += new System.EventHandler(this.chkAtivo_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Location = new System.Drawing.Point(23, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Data de Cadastro:";
            // 
            // dtpDataCad
            // 
            this.dtpDataCad.Enabled = false;
            this.dtpDataCad.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataCad.Location = new System.Drawing.Point(123, 190);
            this.dtpDataCad.Name = "dtpDataCad";
            this.dtpDataCad.Size = new System.Drawing.Size(115, 20);
            this.dtpDataCad.TabIndex = 17;
            // 
            // dgvClientes
            // 
            this.dgvClientes.AccessibleName = "dgvClientes";
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIdCli,
            this.clnNome,
            this.clnCpf,
            this.clnEmail,
            this.clnAtivo});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientes.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvClientes.Location = new System.Drawing.Point(448, 36);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.Size = new System.Drawing.Size(630, 219);
            this.dgvClientes.TabIndex = 0;
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.clnCpf.HeaderText = "CPF";
            this.clnCpf.Name = "clnCpf";
            this.clnCpf.ReadOnly = true;
            this.clnCpf.Width = 110;
            // 
            // clnEmail
            // 
            this.clnEmail.Frozen = true;
            this.clnEmail.HeaderText = "Email";
            this.clnEmail.Name = "clnEmail";
            this.clnEmail.ReadOnly = true;
            this.clnEmail.Width = 196;
            // 
            // clnAtivo
            // 
            this.clnAtivo.Frozen = true;
            this.clnAtivo.HeaderText = "Ativo";
            this.clnAtivo.Name = "clnAtivo";
            this.clnAtivo.ReadOnly = true;
            this.clnAtivo.Width = 60;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(104, 75);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(61, 20);
            this.btnBuscar.TabIndex = 18;
            this.btnBuscar.Text = "...";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnlimpar.Location = new System.Drawing.Point(336, 156);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(74, 23);
            this.btnlimpar.TabIndex = 19;
            this.btnlimpar.Text = "&Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // grbDadosGerais
            // 
            this.grbDadosGerais.Controls.Add(this.chBoxId);
            this.grbDadosGerais.Controls.Add(this.chBoxNome);
            this.grbDadosGerais.Controls.Add(this.label8);
            this.grbDadosGerais.Controls.Add(this.dgvClientes);
            this.grbDadosGerais.Controls.Add(this.txtId);
            this.grbDadosGerais.Controls.Add(this.txtNome);
            this.grbDadosGerais.Controls.Add(this.btnlimpar);
            this.grbDadosGerais.Controls.Add(this.txtCpf);
            this.grbDadosGerais.Controls.Add(this.btnBuscar);
            this.grbDadosGerais.Controls.Add(this.txtEmail);
            this.grbDadosGerais.Controls.Add(this.label1);
            this.grbDadosGerais.Controls.Add(this.dtpDataCad);
            this.grbDadosGerais.Controls.Add(this.label2);
            this.grbDadosGerais.Controls.Add(this.label7);
            this.grbDadosGerais.Controls.Add(this.label3);
            this.grbDadosGerais.Controls.Add(this.chkAtivo);
            this.grbDadosGerais.Controls.Add(this.label4);
            this.grbDadosGerais.Controls.Add(this.btnDesativar);
            this.grbDadosGerais.Controls.Add(this.btnAlterar);
            this.grbDadosGerais.Controls.Add(this.label5);
            this.grbDadosGerais.Controls.Add(this.label6);
            this.grbDadosGerais.Controls.Add(this.btnListar);
            this.grbDadosGerais.Location = new System.Drawing.Point(12, 12);
            this.grbDadosGerais.Name = "grbDadosGerais";
            this.grbDadosGerais.Size = new System.Drawing.Size(1102, 311);
            this.grbDadosGerais.TabIndex = 22;
            this.grbDadosGerais.TabStop = false;
            this.grbDadosGerais.Text = "Dados Gerais";
            this.grbDadosGerais.Enter += new System.EventHandler(this.grbInserir_Enter);
            // 
            // chBoxId
            // 
            this.chBoxId.AutoSize = true;
            this.chBoxId.Location = new System.Drawing.Point(981, 282);
            this.chBoxId.Name = "chBoxId";
            this.chBoxId.Size = new System.Drawing.Size(37, 17);
            this.chBoxId.TabIndex = 24;
            this.chBoxId.Text = "ID";
            this.chBoxId.UseVisualStyleBackColor = true;
            this.chBoxId.CheckedChanged += new System.EventHandler(this.chBoxId_CheckedChanged);
            // 
            // chBoxNome
            // 
            this.chBoxNome.AutoSize = true;
            this.chBoxNome.Location = new System.Drawing.Point(981, 265);
            this.chBoxNome.Name = "chBoxNome";
            this.chBoxNome.Size = new System.Drawing.Size(54, 17);
            this.chBoxNome.TabIndex = 23;
            this.chBoxNome.Text = "Nome";
            this.chBoxNome.UseVisualStyleBackColor = true;
            this.chBoxNome.CheckedChanged += new System.EventHandler(this.chBoxNome_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(912, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Ordenar por:";
            // 
            // grbEndereco
            // 
            this.grbEndereco.Controls.Add(this.button1);
            this.grbEndereco.Controls.Add(this.btnCadastroManual);
            this.grbEndereco.Controls.Add(this.comboBox3);
            this.grbEndereco.Controls.Add(this.label27);
            this.grbEndereco.Controls.Add(this.btnAlterarCep);
            this.grbEndereco.Controls.Add(this.cmBoxUf);
            this.grbEndereco.Controls.Add(this.txtUf);
            this.grbEndereco.Controls.Add(this.btnBuscarCep);
            this.grbEndereco.Controls.Add(this.mskTxtCep);
            this.grbEndereco.Controls.Add(this.cmBoxEstado);
            this.grbEndereco.Controls.Add(this.label26);
            this.grbEndereco.Controls.Add(this.txtBairro);
            this.grbEndereco.Controls.Add(this.txtNumero);
            this.grbEndereco.Controls.Add(this.label25);
            this.grbEndereco.Controls.Add(this.label24);
            this.grbEndereco.Controls.Add(this.label23);
            this.grbEndereco.Controls.Add(this.label22);
            this.grbEndereco.Controls.Add(this.txtCidade);
            this.grbEndereco.Controls.Add(this.txtComplemento);
            this.grbEndereco.Controls.Add(this.label21);
            this.grbEndereco.Controls.Add(this.txtLogradouro);
            this.grbEndereco.Controls.Add(this.label18);
            this.grbEndereco.Controls.Add(this.label19);
            this.grbEndereco.Controls.Add(this.label20);
            this.grbEndereco.Location = new System.Drawing.Point(12, 329);
            this.grbEndereco.Name = "grbEndereco";
            this.grbEndereco.Size = new System.Drawing.Size(500, 336);
            this.grbEndereco.TabIndex = 23;
            this.grbEndereco.TabStop = false;
            this.grbEndereco.Text = "Endereço";
            this.grbEndereco.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnCadastroManual
            // 
            this.btnCadastroManual.Location = new System.Drawing.Point(184, 65);
            this.btnCadastroManual.Name = "btnCadastroManual";
            this.btnCadastroManual.Size = new System.Drawing.Size(151, 21);
            this.btnCadastroManual.TabIndex = 47;
            this.btnCadastroManual.Text = "&Cadastro Manual";
            this.btnCadastroManual.UseVisualStyleBackColor = true;
            this.btnCadastroManual.Click += new System.EventHandler(this.btnCadastroManual_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.Enabled = false;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Residencial",
            "Comercial"});
            this.comboBox3.Location = new System.Drawing.Point(104, 255);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(102, 21);
            this.comboBox3.TabIndex = 46;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Enabled = false;
            this.label27.Location = new System.Drawing.Point(25, 258);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(31, 13);
            this.label27.TabIndex = 45;
            this.label27.Text = "Tipo:";
            // 
            // btnAlterarCep
            // 
            this.btnAlterarCep.Enabled = false;
            this.btnAlterarCep.Location = new System.Drawing.Point(102, 292);
            this.btnAlterarCep.Name = "btnAlterarCep";
            this.btnAlterarCep.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarCep.TabIndex = 44;
            this.btnAlterarCep.Text = "&Alterar";
            this.btnAlterarCep.UseVisualStyleBackColor = true;
            // 
            // cmBoxUf
            // 
            this.cmBoxUf.Enabled = false;
            this.cmBoxUf.FormattingEnabled = true;
            this.cmBoxUf.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cmBoxUf.Location = new System.Drawing.Point(409, 204);
            this.cmBoxUf.Name = "cmBoxUf";
            this.cmBoxUf.Size = new System.Drawing.Size(56, 21);
            this.cmBoxUf.TabIndex = 43;
            // 
            // txtUf
            // 
            this.txtUf.Enabled = false;
            this.txtUf.Location = new System.Drawing.Point(409, 204);
            this.txtUf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUf.MaxLength = 60;
            this.txtUf.Name = "txtUf";
            this.txtUf.ReadOnly = true;
            this.txtUf.Size = new System.Drawing.Size(56, 20);
            this.txtUf.TabIndex = 39;
            this.txtUf.TextChanged += new System.EventHandler(this.txtUf_TextChanged);
            // 
            // btnBuscarCep
            // 
            this.btnBuscarCep.Location = new System.Drawing.Point(26, 65);
            this.btnBuscarCep.Name = "btnBuscarCep";
            this.btnBuscarCep.Size = new System.Drawing.Size(152, 21);
            this.btnBuscarCep.TabIndex = 41;
            this.btnBuscarCep.Text = "&Busca Online";
            this.btnBuscarCep.UseVisualStyleBackColor = true;
            this.btnBuscarCep.Click += new System.EventHandler(this.btnBuscarCep_Click);
            // 
            // mskTxtCep
            // 
            this.mskTxtCep.Enabled = false;
            this.mskTxtCep.Location = new System.Drawing.Point(104, 106);
            this.mskTxtCep.Mask = "00000-999";
            this.mskTxtCep.Name = "mskTxtCep";
            this.mskTxtCep.Size = new System.Drawing.Size(59, 20);
            this.mskTxtCep.TabIndex = 40;
            this.mskTxtCep.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskTxtCep_MaskInputRejected);
            // 
            // cmBoxEstado
            // 
            this.cmBoxEstado.Enabled = false;
            this.cmBoxEstado.FormattingEnabled = true;
            this.cmBoxEstado.Items.AddRange(new object[] {
            "Acre",
            "Alagoas",
            "Amapá",
            "Amazonas",
            "Bahia",
            "Ceará",
            "Distrito Federal",
            "Espírito Santo",
            "Goiás",
            "Maranhão",
            "Mato Grosso",
            "Mato Grosso do Sul",
            "Minas Gerais",
            "Pará",
            "Paraíba",
            "Paraná",
            "Pernambuco",
            "Piauí",
            "Rio de Janeiro",
            "Rio Grande do Norte",
            "Rio Grande do Sul",
            "Rondônia",
            "Roraima",
            "Santa Catarina",
            "São Paulo",
            "Sergipe",
            "Tocantins"});
            this.cmBoxEstado.Location = new System.Drawing.Point(104, 204);
            this.cmBoxEstado.Name = "cmBoxEstado";
            this.cmBoxEstado.Size = new System.Drawing.Size(268, 21);
            this.cmBoxEstado.TabIndex = 38;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Enabled = false;
            this.label26.Location = new System.Drawing.Point(160, 158);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(37, 13);
            this.label26.TabIndex = 36;
            this.label26.Text = "Bairro:";
            // 
            // txtBairro
            // 
            this.txtBairro.Enabled = false;
            this.txtBairro.Location = new System.Drawing.Point(201, 155);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBairro.MaxLength = 60;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.ReadOnly = true;
            this.txtBairro.Size = new System.Drawing.Size(264, 20);
            this.txtBairro.TabIndex = 35;
            // 
            // txtNumero
            // 
            this.txtNumero.Enabled = false;
            this.txtNumero.Location = new System.Drawing.Point(104, 155);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumero.MaxLength = 11;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.ReadOnly = true;
            this.txtNumero.Size = new System.Drawing.Size(49, 20);
            this.txtNumero.TabIndex = 34;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Enabled = false;
            this.label25.Location = new System.Drawing.Point(25, 158);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(47, 13);
            this.label25.TabIndex = 33;
            this.label25.Text = "Número:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Enabled = false;
            this.label24.Location = new System.Drawing.Point(379, 206);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(24, 13);
            this.label24.TabIndex = 31;
            this.label24.Text = "UF:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Enabled = false;
            this.label23.Location = new System.Drawing.Point(25, 182);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(43, 13);
            this.label23.TabIndex = 30;
            this.label23.Text = "Cidade:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Enabled = false;
            this.label22.Location = new System.Drawing.Point(25, 206);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(43, 13);
            this.label22.TabIndex = 29;
            this.label22.Text = "Estado:";
            // 
            // txtCidade
            // 
            this.txtCidade.Enabled = false;
            this.txtCidade.Location = new System.Drawing.Point(104, 179);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCidade.MaxLength = 60;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.ReadOnly = true;
            this.txtCidade.Size = new System.Drawing.Size(361, 20);
            this.txtCidade.TabIndex = 28;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Enabled = false;
            this.txtComplemento.Location = new System.Drawing.Point(104, 230);
            this.txtComplemento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtComplemento.MaxLength = 60;
            this.txtComplemento.Multiline = true;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.ReadOnly = true;
            this.txtComplemento.Size = new System.Drawing.Size(361, 20);
            this.txtComplemento.TabIndex = 26;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(23, 36);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(219, 13);
            this.label21.TabIndex = 24;
            this.label21.Text = "Selecione a forma de Cadastro de Endereço:";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Enabled = false;
            this.txtLogradouro.Location = new System.Drawing.Point(104, 130);
            this.txtLogradouro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLogradouro.MaxLength = 60;
            this.txtLogradouro.Multiline = true;
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.ReadOnly = true;
            this.txtLogradouro.Size = new System.Drawing.Size(361, 20);
            this.txtLogradouro.TabIndex = 10;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Enabled = false;
            this.label18.Location = new System.Drawing.Point(25, 134);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(64, 13);
            this.label18.TabIndex = 11;
            this.label18.Text = "Logradouro:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Enabled = false;
            this.label19.Location = new System.Drawing.Point(25, 109);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(31, 13);
            this.label19.TabIndex = 12;
            this.label19.Text = "CEP:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Enabled = false;
            this.label20.Location = new System.Drawing.Point(25, 233);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(74, 13);
            this.label20.TabIndex = 13;
            this.label20.Text = "Complemento:";
            // 
            // grbTelefones
            // 
            this.grbTelefones.Controls.Add(this.label14);
            this.grbTelefones.Controls.Add(this.textBox3);
            this.grbTelefones.Controls.Add(this.textBox4);
            this.grbTelefones.Controls.Add(this.label15);
            this.grbTelefones.Controls.Add(this.label16);
            this.grbTelefones.Controls.Add(this.comboBox2);
            this.grbTelefones.Controls.Add(this.label17);
            this.grbTelefones.Controls.Add(this.label13);
            this.grbTelefones.Controls.Add(this.textBox2);
            this.grbTelefones.Controls.Add(this.textBox1);
            this.grbTelefones.Controls.Add(this.label12);
            this.grbTelefones.Controls.Add(this.label11);
            this.grbTelefones.Controls.Add(this.comboBox1);
            this.grbTelefones.Controls.Add(this.label10);
            this.grbTelefones.Controls.Add(this.label9);
            this.grbTelefones.Controls.Add(this.btnAlterarTel);
            this.grbTelefones.Controls.Add(this.btnTel);
            this.grbTelefones.Location = new System.Drawing.Point(518, 329);
            this.grbTelefones.Name = "grbTelefones";
            this.grbTelefones.Size = new System.Drawing.Size(596, 276);
            this.grbTelefones.TabIndex = 24;
            this.grbTelefones.TabStop = false;
            this.grbTelefones.Text = "Telefones";
            this.grbTelefones.Enter += new System.EventHandler(this.grbTelefones_Enter);
            // 
            // btnAlterarTel
            // 
            this.btnAlterarTel.Enabled = false;
            this.btnAlterarTel.Location = new System.Drawing.Point(82, 233);
            this.btnAlterarTel.Name = "btnAlterarTel";
            this.btnAlterarTel.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarTel.TabIndex = 47;
            this.btnAlterarTel.Text = "&Alterar";
            this.btnAlterarTel.UseVisualStyleBackColor = true;
            // 
            // btnTel
            // 
            this.btnTel.FlatAppearance.BorderSize = 0;
            this.btnTel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTel.Location = new System.Drawing.Point(497, 195);
            this.btnTel.Name = "btnTel";
            this.btnTel.Size = new System.Drawing.Size(75, 23);
            this.btnTel.TabIndex = 38;
            this.btnTel.Text = "apagueaqui";
            this.btnTel.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(407, 120);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 62;
            this.label14.Text = "Telefone:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(366, 117);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.MaxLength = 60;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(35, 20);
            this.textBox3.TabIndex = 61;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(465, 117);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.MaxLength = 60;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(97, 20);
            this.textBox4.TabIndex = 56;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(311, 120);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 13);
            this.label15.TabIndex = 60;
            this.label15.Text = "DDD:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(311, 95);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 13);
            this.label16.TabIndex = 59;
            this.label16.Text = "Etiqueta:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Residencial Fixo (Casa)",
            "Celular",
            "Trabalho",
            "Fax Comercial",
            "Fax Residencial"});
            this.comboBox2.Location = new System.Drawing.Point(366, 92);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(196, 21);
            this.comboBox2.TabIndex = 58;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(311, 68);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 13);
            this.label17.TabIndex = 57;
            this.label17.Text = "Outros";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(123, 120);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 55;
            this.label13.Text = "Telefone:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(82, 117);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.MaxLength = 60;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(35, 20);
            this.textBox2.TabIndex = 54;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(181, 117);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.MaxLength = 60;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(97, 20);
            this.textBox1.TabIndex = 48;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 120);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 53;
            this.label12.Text = "DDD:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 52;
            this.label11.Text = "Etiqueta:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Residencial Fixo (Casa)",
            "Celular",
            "Trabalho",
            "Fax Comercial",
            "Fax Residencial"});
            this.comboBox1.Location = new System.Drawing.Point(82, 92);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(196, 21);
            this.comboBox1.TabIndex = 51;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 50;
            this.label10.Text = "Principal";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 13);
            this.label9.TabIndex = 49;
            this.label9.Text = "Adicionar Telefone:";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(169, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 20);
            this.button1.TabIndex = 25;
            this.button1.Text = "&Buscar Novamente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(869, 610);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(121, 50);
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FormCliente
            // 
            this.AcceptButton = this.btnInserir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnlimpar;
            this.ClientSize = new System.Drawing.Size(1137, 677);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.grbTelefones);
            this.Controls.Add(this.grbEndereco);
            this.Controls.Add(this.grbDadosGerais);
            this.Controls.Add(this.btnInserir);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormCliente";
            this.Text = "Registro de Clientes";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.grbDadosGerais.ResumeLayout(false);
            this.grbDadosGerais.PerformLayout();
            this.grbEndereco.ResumeLayout(false);
            this.grbEndereco.PerformLayout();
            this.grbTelefones.ResumeLayout(false);
            this.grbTelefones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnDesativar;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpDataCad;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIdCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnEmail;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clnAtivo;
        private System.Windows.Forms.GroupBox grbDadosGerais;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox grbEndereco;
        private System.Windows.Forms.GroupBox grbTelefones;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cmBoxEstado;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.CheckBox chBoxId;
        private System.Windows.Forms.CheckBox chBoxNome;
        private System.Windows.Forms.Button btnTel;
        private System.Windows.Forms.MaskedTextBox mskTxtCep;
        private System.Windows.Forms.Button btnBuscarCep;
        private System.Windows.Forms.TextBox txtUf;
        private System.Windows.Forms.ComboBox cmBoxUf;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button btnAlterarCep;
        private System.Windows.Forms.Button btnAlterarTel;
        private System.Windows.Forms.Button btnCadastroManual;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCancelar;
    }
}

