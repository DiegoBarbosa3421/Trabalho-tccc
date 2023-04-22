
namespace SGPropriedade3
{
    partial class Form_Cd_Faturamento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Cd_Faturamento));
            this.dgvFaturamento = new System.Windows.Forms.DataGridView();
            this.dgvclnidFAturamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvclnTalhão = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvclnTipodeCafé = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvclnQuntidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvclnDataFaturamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvclnFaturamentoUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvclnFaturamentoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnExcluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtQuantidadeDisponivel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboAno = new System.Windows.Forms.ComboBox();
            this.rbDespolpado = new System.Windows.Forms.RadioButton();
            this.rbDescascado = new System.Windows.Forms.RadioButton();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboTalhão = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValorAreccadadoUnidade = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValorArrecadadoTotal = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaturamento)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFaturamento
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Teal;
            this.dgvFaturamento.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFaturamento.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvFaturamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFaturamento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFaturamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFaturamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvclnidFAturamento,
            this.dgvclnTalhão,
            this.dgvclnTipodeCafé,
            this.dgvclnQuntidade,
            this.dgvclnDataFaturamento,
            this.dgvclnFaturamentoUnitario,
            this.dgvclnFaturamentoTotal,
            this.btnEditar,
            this.btnExcluir});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFaturamento.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFaturamento.GridColor = System.Drawing.Color.White;
            this.dgvFaturamento.Location = new System.Drawing.Point(424, 237);
            this.dgvFaturamento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvFaturamento.Name = "dgvFaturamento";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFaturamento.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFaturamento.Size = new System.Drawing.Size(977, 755);
            this.dgvFaturamento.TabIndex = 22;
            this.dgvFaturamento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFaturamento_CellContentClick);
            this.dgvFaturamento.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvFaturamento_DataBindingComplete);
            // 
            // dgvclnidFAturamento
            // 
            this.dgvclnidFAturamento.DataPropertyName = "idFaturamento";
            this.dgvclnidFAturamento.HeaderText = "idFaturamento";
            this.dgvclnidFAturamento.Name = "dgvclnidFAturamento";
            this.dgvclnidFAturamento.Visible = false;
            // 
            // dgvclnTalhão
            // 
            this.dgvclnTalhão.DataPropertyName = "nomeTalhão";
            this.dgvclnTalhão.HeaderText = "Talhão";
            this.dgvclnTalhão.Name = "dgvclnTalhão";
            // 
            // dgvclnTipodeCafé
            // 
            this.dgvclnTipodeCafé.DataPropertyName = "tipoDeCafé";
            this.dgvclnTipodeCafé.HeaderText = "Tipo de café";
            this.dgvclnTipodeCafé.Name = "dgvclnTipodeCafé";
            // 
            // dgvclnQuntidade
            // 
            this.dgvclnQuntidade.DataPropertyName = "quantidadeFaturamento";
            this.dgvclnQuntidade.HeaderText = "Quantidade de       café comercializada";
            this.dgvclnQuntidade.Name = "dgvclnQuntidade";
            this.dgvclnQuntidade.Width = 120;
            // 
            // dgvclnDataFaturamento
            // 
            this.dgvclnDataFaturamento.DataPropertyName = "dataFAturamento";
            this.dgvclnDataFaturamento.HeaderText = "Data de Faturamento";
            this.dgvclnDataFaturamento.Name = "dgvclnDataFaturamento";
            this.dgvclnDataFaturamento.Width = 120;
            // 
            // dgvclnFaturamentoUnitario
            // 
            this.dgvclnFaturamentoUnitario.DataPropertyName = "valorUnitarioArrecadado";
            this.dgvclnFaturamentoUnitario.HeaderText = "Faturamento por Unidade";
            this.dgvclnFaturamentoUnitario.Name = "dgvclnFaturamentoUnitario";
            this.dgvclnFaturamentoUnitario.Width = 120;
            // 
            // dgvclnFaturamentoTotal
            // 
            this.dgvclnFaturamentoTotal.DataPropertyName = "valorTotalArrecadado";
            this.dgvclnFaturamentoTotal.HeaderText = "Faturamento   total Arrecadado";
            this.dgvclnFaturamentoTotal.Name = "dgvclnFaturamentoTotal";
            this.dgvclnFaturamentoTotal.Width = 170;
            // 
            // btnEditar
            // 
            this.btnEditar.HeaderText = "";
            this.btnEditar.Image = global::SgPropriedade_3._0.Properties.Resources.caneta_esferografica;
            this.btnEditar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.btnEditar.Name = "btnEditar";
            // 
            // btnExcluir
            // 
            this.btnExcluir.HeaderText = "";
            this.btnExcluir.Image = global::SgPropriedade_3._0.Properties.Resources.cancelar;
            this.btnExcluir.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.btnExcluir.Name = "btnExcluir";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtQuantidadeDisponivel);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cboAno);
            this.groupBox1.Controls.Add(this.rbDespolpado);
            this.groupBox1.Controls.Add(this.rbDescascado);
            this.groupBox1.Controls.Add(this.txtQuantidade);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboTalhão);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtValorAreccadadoUnidade);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtValorArrecadadoTotal);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(38, 223);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(378, 769);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações de transação de café";
            // 
            // txtQuantidadeDisponivel
            // 
            this.txtQuantidadeDisponivel.BackColor = System.Drawing.SystemColors.Window;
            this.txtQuantidadeDisponivel.Enabled = false;
            this.txtQuantidadeDisponivel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidadeDisponivel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtQuantidadeDisponivel.Location = new System.Drawing.Point(244, 714);
            this.txtQuantidadeDisponivel.Name = "txtQuantidadeDisponivel";
            this.txtQuantidadeDisponivel.Size = new System.Drawing.Size(100, 35);
            this.txtQuantidadeDisponivel.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(5, 714);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(219, 42);
            this.label8.TabIndex = 26;
            this.label8.Text = "Quantidade de café disponivel\r\n\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(31, 253);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(211, 21);
            this.label7.TabIndex = 25;
            this.label7.Text = "Selecione o tipo de produção";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(31, 59);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 67);
            this.label6.TabIndex = 24;
            this.label6.Text = "Selecione o ano correspondente a produção a sercomercializada";
            // 
            // cboAno
            // 
            this.cboAno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAno.FormattingEnabled = true;
            this.cboAno.Location = new System.Drawing.Point(31, 138);
            this.cboAno.Name = "cboAno";
            this.cboAno.Size = new System.Drawing.Size(211, 29);
            this.cboAno.TabIndex = 23;
            // 
            // rbDespolpado
            // 
            this.rbDespolpado.AutoSize = true;
            this.rbDespolpado.Location = new System.Drawing.Point(31, 322);
            this.rbDespolpado.Name = "rbDespolpado";
            this.rbDespolpado.Size = new System.Drawing.Size(143, 24);
            this.rbDespolpado.TabIndex = 22;
            this.rbDespolpado.TabStop = true;
            this.rbDespolpado.Text = "Café Despolpado";
            this.rbDespolpado.UseVisualStyleBackColor = true;
            this.rbDespolpado.CheckedChanged += new System.EventHandler(this.rbDespolpado_CheckedChanged);
            // 
            // rbDescascado
            // 
            this.rbDescascado.AutoSize = true;
            this.rbDescascado.Location = new System.Drawing.Point(31, 286);
            this.rbDescascado.Name = "rbDescascado";
            this.rbDescascado.Size = new System.Drawing.Size(140, 24);
            this.rbDescascado.TabIndex = 21;
            this.rbDescascado.TabStop = true;
            this.rbDescascado.Text = "Café Descascado";
            this.rbDescascado.UseVisualStyleBackColor = true;
            this.rbDescascado.CheckedChanged += new System.EventHandler(this.rbDescascado_CheckedChanged);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.Location = new System.Drawing.Point(31, 418);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(211, 29);
            this.txtQuantidade.TabIndex = 20;
            this.txtQuantidade.TextChanged += new System.EventHandler(this.txtQuantidade_TextChanged);
            this.txtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidade_KeyPress);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(31, 358);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 48);
            this.label5.TabIndex = 19;
            this.label5.Text = "Adicione a quantidade que sera comercializada";
            // 
            // cboTalhão
            // 
            this.cboTalhão.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTalhão.FormattingEnabled = true;
            this.cboTalhão.Location = new System.Drawing.Point(31, 212);
            this.cboTalhão.Name = "cboTalhão";
            this.cboTalhão.Size = new System.Drawing.Size(211, 29);
            this.cboTalhão.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(31, 179);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "Selecione o talhão ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(31, 533);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Valor total arrecadado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(31, 607);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Data ";
            // 
            // txtValorAreccadadoUnidade
            // 
            this.txtValorAreccadadoUnidade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorAreccadadoUnidade.Location = new System.Drawing.Point(31, 492);
            this.txtValorAreccadadoUnidade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtValorAreccadadoUnidade.Name = "txtValorAreccadadoUnidade";
            this.txtValorAreccadadoUnidade.Size = new System.Drawing.Size(211, 29);
            this.txtValorAreccadadoUnidade.TabIndex = 1;
            this.txtValorAreccadadoUnidade.TextChanged += new System.EventHandler(this.txtValorAreccadadoUnidade_TextChanged);
            this.txtValorAreccadadoUnidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorAreccadadoUnidade_KeyPress);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(31, 640);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(211, 29);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(31, 459);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Valor arrecadado por unidade";
            // 
            // txtValorArrecadadoTotal
            // 
            this.txtValorArrecadadoTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorArrecadadoTotal.Location = new System.Drawing.Point(31, 566);
            this.txtValorArrecadadoTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtValorArrecadadoTotal.Name = "txtValorArrecadadoTotal";
            this.txtValorArrecadadoTotal.Size = new System.Drawing.Size(211, 29);
            this.txtValorArrecadadoTotal.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnLimpar);
            this.groupBox3.Controls.Add(this.btnPesquisar);
            this.groupBox3.Controls.Add(this.txtPesquisar);
            this.groupBox3.Location = new System.Drawing.Point(685, 119);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(716, 92);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.Teal;
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(492, 26);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(216, 45);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(428, 24);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(56, 47);
            this.btnPesquisar.TabIndex = 6;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.Location = new System.Drawing.Point(26, 32);
            this.txtPesquisar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(388, 29);
            this.txtPesquisar.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(458, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(246, 30);
            this.label9.TabIndex = 23;
            this.label9.Text = "Cadastro de Faturameto";
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Image = global::SgPropriedade_3._0.Properties.Resources.baixar__1_;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(38, 162);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(124, 49);
            this.btnSalvar.TabIndex = 24;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // Form_Cd_Faturamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1449, 1015);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvFaturamento);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_Cd_Faturamento";
            this.Text = "Form_Cd_Financeiro";
            this.Load += new System.EventHandler(this.Form_Cd_Faturamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaturamento)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFaturamento;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValorAreccadadoUnidade;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValorArrecadadoTotal;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboTalhão;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.RadioButton rbDespolpado;
        private System.Windows.Forms.RadioButton rbDescascado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboAno;
        private System.Windows.Forms.TextBox txtQuantidadeDisponivel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvclnidFAturamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvclnTalhão;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvclnTipodeCafé;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvclnQuntidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvclnDataFaturamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvclnFaturamentoUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvclnFaturamentoTotal;
        private System.Windows.Forms.DataGridViewImageColumn btnEditar;
        private System.Windows.Forms.DataGridViewImageColumn btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
    }
}