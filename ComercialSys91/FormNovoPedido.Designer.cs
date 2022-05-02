namespace ComercialSys91
{
    partial class FormNovoPedido
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
            this.grbDadosPedido = new System.Windows.Forms.GroupBox();
            this.lblData = new System.Windows.Forms.Label();
            this.cmbNomeCliente = new System.Windows.Forms.ComboBox();
            this.cmbNomeUsuario = new System.Windows.Forms.ComboBox();
            this.txtIdPedido = new System.Windows.Forms.TextBox();
            this.lblIdPedido = new System.Windows.Forms.Label();
            this.dtpDataCad = new System.Windows.Forms.DateTimePicker();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.lblNomeUsuario = new System.Windows.Forms.Label();
            this.btnInserirPedido = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblCodProduto = new System.Windows.Forms.Label();
            this.btnCriarPed = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.chBoxId = new System.Windows.Forms.CheckBox();
            this.chbDescricao = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grbItens = new System.Windows.Forms.GroupBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descrição = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorUnitário = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCodProduto = new System.Windows.Forms.ComboBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblValorUnit = new System.Windows.Forms.Label();
            this.txtValorUnit = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.grbDadosPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.grbItens.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDadosPedido
            // 
            this.grbDadosPedido.Controls.Add(this.lblData);
            this.grbDadosPedido.Controls.Add(this.cmbNomeCliente);
            this.grbDadosPedido.Controls.Add(this.cmbNomeUsuario);
            this.grbDadosPedido.Controls.Add(this.btnCriarPed);
            this.grbDadosPedido.Controls.Add(this.txtIdPedido);
            this.grbDadosPedido.Controls.Add(this.lblIdPedido);
            this.grbDadosPedido.Controls.Add(this.dtpDataCad);
            this.grbDadosPedido.Controls.Add(this.lblNomeCliente);
            this.grbDadosPedido.Controls.Add(this.lblNomeUsuario);
            this.grbDadosPedido.Controls.Add(this.label5);
            this.grbDadosPedido.Location = new System.Drawing.Point(12, 12);
            this.grbDadosPedido.Name = "grbDadosPedido";
            this.grbDadosPedido.Size = new System.Drawing.Size(684, 139);
            this.grbDadosPedido.TabIndex = 23;
            this.grbDadosPedido.TabStop = false;
            this.grbDadosPedido.Text = "Dados do Pedido";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(406, 92);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(33, 13);
            this.lblData.TabIndex = 46;
            this.lblData.Text = "Data:";
            // 
            // cmbNomeCliente
            // 
            this.cmbNomeCliente.Enabled = false;
            this.cmbNomeCliente.FormattingEnabled = true;
            this.cmbNomeCliente.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbNomeCliente.Location = new System.Drawing.Point(105, 63);
            this.cmbNomeCliente.Name = "cmbNomeCliente";
            this.cmbNomeCliente.Size = new System.Drawing.Size(274, 21);
            this.cmbNomeCliente.TabIndex = 45;
            // 
            // cmbNomeUsuario
            // 
            this.cmbNomeUsuario.Enabled = false;
            this.cmbNomeUsuario.FormattingEnabled = true;
            this.cmbNomeUsuario.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbNomeUsuario.Location = new System.Drawing.Point(105, 89);
            this.cmbNomeUsuario.Name = "cmbNomeUsuario";
            this.cmbNomeUsuario.Size = new System.Drawing.Size(274, 21);
            this.cmbNomeUsuario.TabIndex = 44;
            // 
            // txtIdPedido
            // 
            this.txtIdPedido.Location = new System.Drawing.Point(484, 63);
            this.txtIdPedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdPedido.Name = "txtIdPedido";
            this.txtIdPedido.ReadOnly = true;
            this.txtIdPedido.Size = new System.Drawing.Size(57, 20);
            this.txtIdPedido.TabIndex = 4;
            // 
            // lblIdPedido
            // 
            this.lblIdPedido.AutoSize = true;
            this.lblIdPedido.Location = new System.Drawing.Point(406, 66);
            this.lblIdPedido.Name = "lblIdPedido";
            this.lblIdPedido.Size = new System.Drawing.Size(72, 13);
            this.lblIdPedido.TabIndex = 4;
            this.lblIdPedido.Text = "ID do Pedido:";
            // 
            // dtpDataCad
            // 
            this.dtpDataCad.Enabled = false;
            this.dtpDataCad.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataCad.Location = new System.Drawing.Point(445, 89);
            this.dtpDataCad.Name = "dtpDataCad";
            this.dtpDataCad.Size = new System.Drawing.Size(96, 20);
            this.dtpDataCad.TabIndex = 17;
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Location = new System.Drawing.Point(22, 66);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(73, 13);
            this.lblNomeCliente.TabIndex = 5;
            this.lblNomeCliente.Text = "Nome Cliente:";
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.AutoSize = true;
            this.lblNomeUsuario.Location = new System.Drawing.Point(22, 92);
            this.lblNomeUsuario.Name = "lblNomeUsuario";
            this.lblNomeUsuario.Size = new System.Drawing.Size(77, 13);
            this.lblNomeUsuario.TabIndex = 6;
            this.lblNomeUsuario.Text = "Nome Usuário:";
            // 
            // btnInserirPedido
            // 
            this.btnInserirPedido.Enabled = false;
            this.btnInserirPedido.Location = new System.Drawing.Point(409, 52);
            this.btnInserirPedido.Name = "btnInserirPedido";
            this.btnInserirPedido.Size = new System.Drawing.Size(75, 23);
            this.btnInserirPedido.TabIndex = 13;
            this.btnInserirPedido.Text = "&Inserir";
            this.btnInserirPedido.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Insira as informações para cadastro de Cliente:";
            // 
            // btnlimpar
            // 
            this.btnlimpar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnlimpar.Enabled = false;
            this.btnlimpar.Location = new System.Drawing.Point(25, 359);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(74, 23);
            this.btnlimpar.TabIndex = 19;
            this.btnlimpar.Text = "&Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(100, 80);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescricao.MaxLength = 60;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(295, 20);
            this.txtDescricao.TabIndex = 2;
            // 
            // lblCodProduto
            // 
            this.lblCodProduto.AutoSize = true;
            this.lblCodProduto.Location = new System.Drawing.Point(22, 57);
            this.lblCodProduto.Name = "lblCodProduto";
            this.lblCodProduto.Size = new System.Drawing.Size(72, 13);
            this.lblCodProduto.TabIndex = 7;
            this.lblCodProduto.Text = "Cód. Produto:";
            // 
            // btnCriarPed
            // 
            this.btnCriarPed.Enabled = false;
            this.btnCriarPed.Location = new System.Drawing.Point(579, 87);
            this.btnCriarPed.Name = "btnCriarPed";
            this.btnCriarPed.Size = new System.Drawing.Size(75, 23);
            this.btnCriarPed.TabIndex = 14;
            this.btnCriarPed.Text = "&Criar Pedido";
            this.btnCriarPed.UseVisualStyleBackColor = true;
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
            this.comboBox3.Location = new System.Drawing.Point(619, 359);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(35, 21);
            this.comboBox3.TabIndex = 48;
            this.comboBox3.Visible = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(567, 363);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(46, 13);
            this.label18.TabIndex = 28;
            this.label18.Text = " - Inicial:";
            this.label18.Visible = false;
            // 
            // chBoxId
            // 
            this.chBoxId.AutoSize = true;
            this.chBoxId.Location = new System.Drawing.Point(496, 379);
            this.chBoxId.Name = "chBoxId";
            this.chBoxId.Size = new System.Drawing.Size(37, 17);
            this.chBoxId.TabIndex = 24;
            this.chBoxId.Text = "ID";
            this.chBoxId.UseVisualStyleBackColor = true;
            // 
            // chbDescricao
            // 
            this.chbDescricao.AutoSize = true;
            this.chbDescricao.Location = new System.Drawing.Point(496, 362);
            this.chbDescricao.Name = "chbDescricao";
            this.chbDescricao.Size = new System.Drawing.Size(74, 17);
            this.chbDescricao.TabIndex = 23;
            this.chbDescricao.Text = "Descrição";
            this.chbDescricao.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(427, 363);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Ordenar por:";
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
            this.Column1,
            this.ID,
            this.Descrição,
            this.ValorUnitário,
            this.Quantidade,
            this.TotalItem});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClientes.Location = new System.Drawing.Point(24, 152);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(630, 208);
            this.dgvClientes.TabIndex = 0;
            // 
            // grbItens
            // 
            this.grbItens.Controls.Add(this.lblValorTotal);
            this.grbItens.Controls.Add(this.txtValorTotal);
            this.grbItens.Controls.Add(this.lblQuantidade);
            this.grbItens.Controls.Add(this.txtQuantidade);
            this.grbItens.Controls.Add(this.btnInserirPedido);
            this.grbItens.Controls.Add(this.lblValorUnit);
            this.grbItens.Controls.Add(this.txtValorUnit);
            this.grbItens.Controls.Add(this.lblDescricao);
            this.grbItens.Controls.Add(this.cmbCodProduto);
            this.grbItens.Controls.Add(this.label1);
            this.grbItens.Controls.Add(this.comboBox3);
            this.grbItens.Controls.Add(this.dgvClientes);
            this.grbItens.Controls.Add(this.label18);
            this.grbItens.Controls.Add(this.lblCodProduto);
            this.grbItens.Controls.Add(this.label8);
            this.grbItens.Controls.Add(this.chbDescricao);
            this.grbItens.Controls.Add(this.txtDescricao);
            this.grbItens.Controls.Add(this.chBoxId);
            this.grbItens.Controls.Add(this.btnlimpar);
            this.grbItens.Location = new System.Drawing.Point(12, 157);
            this.grbItens.Name = "grbItens";
            this.grbItens.Size = new System.Drawing.Size(684, 404);
            this.grbItens.TabIndex = 24;
            this.grbItens.TabStop = false;
            this.grbItens.Text = "Itens de Pedido";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "#";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 25;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 45;
            // 
            // Descrição
            // 
            this.Descrição.HeaderText = "Descrição";
            this.Descrição.Name = "Descrição";
            this.Descrição.ReadOnly = true;
            this.Descrição.Width = 300;
            // 
            // ValorUnitário
            // 
            this.ValorUnitário.HeaderText = "Valor Unitário";
            this.ValorUnitário.Name = "ValorUnitário";
            this.ValorUnitário.ReadOnly = true;
            this.ValorUnitário.Width = 97;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            // 
            // TotalItem
            // 
            this.TotalItem.HeaderText = "TotalItem";
            this.TotalItem.Name = "TotalItem";
            this.TotalItem.ReadOnly = true;
            this.TotalItem.Width = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Insira as informações para cadastro do Pedido:";
            // 
            // cmbCodProduto
            // 
            this.cmbCodProduto.Enabled = false;
            this.cmbCodProduto.FormattingEnabled = true;
            this.cmbCodProduto.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbCodProduto.Location = new System.Drawing.Point(100, 54);
            this.cmbCodProduto.Name = "cmbCodProduto";
            this.cmbCodProduto.Size = new System.Drawing.Size(94, 21);
            this.cmbCodProduto.TabIndex = 47;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(23, 83);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 13);
            this.lblDescricao.TabIndex = 49;
            this.lblDescricao.Text = "Descrição:";
            // 
            // lblValorUnit
            // 
            this.lblValorUnit.AutoSize = true;
            this.lblValorUnit.Location = new System.Drawing.Point(23, 107);
            this.lblValorUnit.Name = "lblValorUnit";
            this.lblValorUnit.Size = new System.Drawing.Size(73, 13);
            this.lblValorUnit.TabIndex = 51;
            this.lblValorUnit.Text = "Valor Unitário:";
            // 
            // txtValorUnit
            // 
            this.txtValorUnit.Location = new System.Drawing.Point(100, 104);
            this.txtValorUnit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtValorUnit.MaxLength = 60;
            this.txtValorUnit.Name = "txtValorUnit";
            this.txtValorUnit.Size = new System.Drawing.Size(94, 20);
            this.txtValorUnit.TabIndex = 50;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(200, 107);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(65, 13);
            this.lblQuantidade.TabIndex = 53;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(271, 104);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQuantidade.MaxLength = 60;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(124, 20);
            this.txtQuantidade.TabIndex = 52;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Location = new System.Drawing.Point(446, 107);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(78, 13);
            this.lblValorTotal.TabIndex = 55;
            this.lblValorTotal.Text = "Valor Total R$:";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Location = new System.Drawing.Point(524, 104);
            this.txtValorTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtValorTotal.MaxLength = 60;
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(130, 20);
            this.txtValorTotal.TabIndex = 54;
            // 
            // FormNovoPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 573);
            this.Controls.Add(this.grbItens);
            this.Controls.Add(this.grbDadosPedido);
            this.Name = "FormNovoPedido";
            this.Text = "FormNovoPedido";
            this.grbDadosPedido.ResumeLayout(false);
            this.grbDadosPedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.grbItens.ResumeLayout(false);
            this.grbItens.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDadosPedido;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.CheckBox chBoxId;
        private System.Windows.Forms.CheckBox chbDescricao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.TextBox txtIdPedido;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblIdPedido;
        private System.Windows.Forms.DateTimePicker dtpDataCad;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.Label lblNomeUsuario;
        private System.Windows.Forms.Label lblCodProduto;
        private System.Windows.Forms.Button btnCriarPed;
        private System.Windows.Forms.Button btnInserirPedido;
        private System.Windows.Forms.Label label5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grbItens;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.ComboBox cmbNomeCliente;
        private System.Windows.Forms.ComboBox cmbNomeUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descrição;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorUnitário;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.ComboBox cmbCodProduto;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lblValorUnit;
        private System.Windows.Forms.TextBox txtValorUnit;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.TextBox txtValorTotal;
    }
}