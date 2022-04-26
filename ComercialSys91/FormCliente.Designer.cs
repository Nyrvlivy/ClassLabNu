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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.grbInserir = new System.Windows.Forms.GroupBox();
            this.chklistOrdenar = new System.Windows.Forms.CheckedListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.grbInserir.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.btnInserir.Location = new System.Drawing.Point(335, 158);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 24);
            this.btnInserir.TabIndex = 3;
            this.btnInserir.Text = "&Inserir";
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIdCli,
            this.clnNome,
            this.clnCpf,
            this.clnEmail,
            this.clnAtivo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientes.DefaultCellStyle = dataGridViewCellStyle2;
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
            this.btnBuscar.Location = new System.Drawing.Point(113, 75);
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
            this.btnlimpar.Location = new System.Drawing.Point(336, 187);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(74, 23);
            this.btnlimpar.TabIndex = 19;
            this.btnlimpar.Text = "&Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // grbInserir
            // 
            this.grbInserir.Controls.Add(this.chklistOrdenar);
            this.grbInserir.Controls.Add(this.label8);
            this.grbInserir.Controls.Add(this.dgvClientes);
            this.grbInserir.Controls.Add(this.txtId);
            this.grbInserir.Controls.Add(this.txtNome);
            this.grbInserir.Controls.Add(this.btnlimpar);
            this.grbInserir.Controls.Add(this.txtCpf);
            this.grbInserir.Controls.Add(this.btnBuscar);
            this.grbInserir.Controls.Add(this.txtEmail);
            this.grbInserir.Controls.Add(this.label1);
            this.grbInserir.Controls.Add(this.dtpDataCad);
            this.grbInserir.Controls.Add(this.label2);
            this.grbInserir.Controls.Add(this.label7);
            this.grbInserir.Controls.Add(this.label3);
            this.grbInserir.Controls.Add(this.chkAtivo);
            this.grbInserir.Controls.Add(this.label4);
            this.grbInserir.Controls.Add(this.btnDesativar);
            this.grbInserir.Controls.Add(this.btnInserir);
            this.grbInserir.Controls.Add(this.btnAlterar);
            this.grbInserir.Controls.Add(this.label5);
            this.grbInserir.Controls.Add(this.label6);
            this.grbInserir.Controls.Add(this.btnListar);
            this.grbInserir.Location = new System.Drawing.Point(12, 12);
            this.grbInserir.Name = "grbInserir";
            this.grbInserir.Size = new System.Drawing.Size(1102, 311);
            this.grbInserir.TabIndex = 22;
            this.grbInserir.TabStop = false;
            this.grbInserir.Text = "Dados Gerais";
            // 
            // chklistOrdenar
            // 
            this.chklistOrdenar.FormattingEnabled = true;
            this.chklistOrdenar.Items.AddRange(new object[] {
            "Nome",
            "Id"});
            this.chklistOrdenar.Location = new System.Drawing.Point(984, 266);
            this.chklistOrdenar.Name = "chklistOrdenar";
            this.chklistOrdenar.Size = new System.Drawing.Size(94, 34);
            this.chklistOrdenar.TabIndex = 23;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox4);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.textBox12);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.textBox11);
            this.groupBox1.Controls.Add(this.textBox9);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Location = new System.Drawing.Point(12, 329);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 282);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Endereço";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(518, 329);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(596, 282);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Telefones";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Adicionar Telefone:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Principal";
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
            this.comboBox1.Location = new System.Drawing.Point(80, 92);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(196, 21);
            this.comboBox1.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Etiqueta:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 120);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "DDD:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(179, 117);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.MaxLength = 60;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(97, 20);
            this.textBox1.TabIndex = 24;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(80, 117);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.MaxLength = 60;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(35, 20);
            this.textBox2.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(121, 120);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Telefone:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(417, 121);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 37;
            this.label14.Text = "Telefone:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(376, 118);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.MaxLength = 60;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(35, 20);
            this.textBox3.TabIndex = 36;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(475, 118);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.MaxLength = 60;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(97, 20);
            this.textBox4.TabIndex = 31;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(321, 121);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 13);
            this.label15.TabIndex = 35;
            this.label15.Text = "DDD:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(321, 96);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 13);
            this.label16.TabIndex = 34;
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
            this.comboBox2.Location = new System.Drawing.Point(376, 93);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(196, 21);
            this.comboBox2.TabIndex = 33;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(321, 69);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 13);
            this.label17.TabIndex = 32;
            this.label17.Text = "Outros";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(102, 92);
            this.textBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox7.MaxLength = 60;
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(361, 20);
            this.textBox7.TabIndex = 10;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(23, 96);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(64, 13);
            this.label18.TabIndex = 11;
            this.label18.Text = "Logradouro:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(23, 195);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(74, 13);
            this.label20.TabIndex = 13;
            this.label20.Text = "Complemento:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(23, 36);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(103, 13);
            this.label21.TabIndex = 24;
            this.label21.Text = "Adicionar Endereço:";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(102, 192);
            this.textBox9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox9.MaxLength = 60;
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(361, 20);
            this.textBox9.TabIndex = 26;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(102, 141);
            this.textBox11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox11.MaxLength = 60;
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(361, 20);
            this.textBox11.TabIndex = 28;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(23, 168);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(43, 13);
            this.label22.TabIndex = 29;
            this.label22.Text = "Estado:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(23, 144);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(43, 13);
            this.label23.TabIndex = 30;
            this.label23.Text = "Cidade:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(23, 71);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(31, 13);
            this.label19.TabIndex = 12;
            this.label19.Text = "CEP:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(377, 168);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(24, 13);
            this.label24.TabIndex = 31;
            this.label24.Text = "UF:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(102, 67);
            this.maskedTextBox1.Mask = "00000-999";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(61, 20);
            this.maskedTextBox1.TabIndex = 32;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(23, 120);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(47, 13);
            this.label25.TabIndex = 33;
            this.label25.Text = "Número:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(102, 117);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox5.MaxLength = 11;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(49, 20);
            this.textBox5.TabIndex = 34;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(158, 120);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(37, 13);
            this.label26.TabIndex = 36;
            this.label26.Text = "Bairro:";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(199, 117);
            this.textBox12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox12.MaxLength = 60;
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(264, 20);
            this.textBox12.TabIndex = 35;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
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
            this.comboBox3.Location = new System.Drawing.Point(102, 166);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(268, 21);
            this.comboBox3.TabIndex = 38;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
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
            this.comboBox4.Location = new System.Drawing.Point(407, 165);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(56, 21);
            this.comboBox4.TabIndex = 38;
            // 
            // FormCliente
            // 
            this.AcceptButton = this.btnInserir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnlimpar;
            this.ClientSize = new System.Drawing.Size(1126, 635);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbInserir);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormCliente";
            this.Text = "Registro de Clientes";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.grbInserir.ResumeLayout(false);
            this.grbInserir.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.GroupBox grbInserir;
        private System.Windows.Forms.CheckedListBox chklistOrdenar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
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
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox textBox12;
    }
}

