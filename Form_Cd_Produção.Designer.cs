
namespace SGPropriedade3
{
    partial class Form_Produção
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Produção));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.rbColaborador = new System.Windows.Forms.RadioButton();
            this.rbData = new System.Windows.Forms.RadioButton();
            this.rbTalhão = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.dgvProdução = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.cboTalhão = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboColaborador = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbDespolpado = new System.Windows.Forms.RadioButton();
            this.rbLimpo = new System.Windows.Forms.RadioButton();
            this.rbNatural = new System.Windows.Forms.RadioButton();
            this.rbSeco = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dgvclnIdProdução = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvclnColaborador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvclnTalhão = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvclnObservação = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvclnDataInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvclnDataFim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvclnQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvclnCustoUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvclnCustoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnExcluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdução)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dateTimePicker3);
            this.groupBox3.Controls.Add(this.dateTimePicker4);
            this.groupBox3.Controls.Add(this.rbColaborador);
            this.groupBox3.Controls.Add(this.rbData);
            this.groupBox3.Controls.Add(this.rbTalhão);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.btnLimpar);
            this.groupBox3.Controls.Add(this.btnPesquisar);
            this.groupBox3.Controls.Add(this.txtPesquisar);
            this.groupBox3.Location = new System.Drawing.Point(935, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(512, 116);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker3.Location = new System.Drawing.Point(6, 17);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(132, 29);
            this.dateTimePicker3.TabIndex = 16;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker4.Location = new System.Drawing.Point(147, 17);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(132, 29);
            this.dateTimePicker4.TabIndex = 17;
            // 
            // rbColaborador
            // 
            this.rbColaborador.AutoSize = true;
            this.rbColaborador.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbColaborador.Location = new System.Drawing.Point(187, 78);
            this.rbColaborador.Name = "rbColaborador";
            this.rbColaborador.Size = new System.Drawing.Size(111, 24);
            this.rbColaborador.TabIndex = 11;
            this.rbColaborador.TabStop = true;
            this.rbColaborador.Text = "Colaborador";
            this.rbColaborador.UseVisualStyleBackColor = true;
            this.rbColaborador.CheckedChanged += new System.EventHandler(this.rbColaborador_CheckedChanged);
            // 
            // rbData
            // 
            this.rbData.AutoSize = true;
            this.rbData.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbData.Location = new System.Drawing.Point(112, 78);
            this.rbData.Name = "rbData";
            this.rbData.Size = new System.Drawing.Size(59, 24);
            this.rbData.TabIndex = 10;
            this.rbData.TabStop = true;
            this.rbData.Text = "Data";
            this.rbData.UseVisualStyleBackColor = true;
            this.rbData.CheckedChanged += new System.EventHandler(this.rbData_CheckedChanged);
            // 
            // rbTalhão
            // 
            this.rbTalhão.AutoSize = true;
            this.rbTalhão.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTalhão.Location = new System.Drawing.Point(26, 78);
            this.rbTalhão.Name = "rbTalhão";
            this.rbTalhão.Size = new System.Drawing.Size(70, 24);
            this.rbTalhão.TabIndex = 9;
            this.rbTalhão.TabStop = true;
            this.rbTalhão.Text = "Talhão";
            this.rbTalhão.UseVisualStyleBackColor = true;
            this.rbTalhão.CheckedChanged += new System.EventHandler(this.rbTalhão_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(233, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Selecioneuma opção de Pesquisa";
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
            this.btnLimpar.Location = new System.Drawing.Point(337, 13);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(134, 29);
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
            this.btnPesquisar.Location = new System.Drawing.Point(285, 15);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(37, 29);
            this.btnPesquisar.TabIndex = 6;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.Location = new System.Drawing.Point(6, 17);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(266, 29);
            this.txtPesquisar.TabIndex = 5;
            // 
            // dgvProdução
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Teal;
            this.dgvProdução.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProdução.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvProdução.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProdução.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProdução.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdução.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvclnIdProdução,
            this.dgvclnColaborador,
            this.dgvclnTalhão,
            this.dgvclnObservação,
            this.dgvclnDataInicio,
            this.dgvclnDataFim,
            this.dgvclnQuantidade,
            this.dgvclnCustoUnitario,
            this.dgvclnCustoTotal,
            this.btnEditar,
            this.btnExcluir});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProdução.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProdução.Location = new System.Drawing.Point(304, 140);
            this.dgvProdução.Name = "dgvProdução";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProdução.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProdução.Size = new System.Drawing.Size(1161, 861);
            this.dgvProdução.TabIndex = 13;
            this.dgvProdução.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdução_CellContentClick);
            this.dgvProdução.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvProdução_DataBindingComplete);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtQuantidade);
            this.groupBox1.Controls.Add(this.cboTalhão);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboColaborador);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCustos);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(66, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 736);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações da Produção";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(7, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 21);
            this.label6.TabIndex = 23;
            this.label6.Text = "Quantidade Produzida";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.Location = new System.Drawing.Point(11, 256);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(175, 29);
            this.txtQuantidade.TabIndex = 24;
            this.txtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidade_KeyPress);
            // 
            // cboTalhão
            // 
            this.cboTalhão.FormattingEnabled = true;
            this.cboTalhão.Location = new System.Drawing.Point(11, 535);
            this.cboTalhão.Name = "cboTalhão";
            this.cboTalhão.Size = new System.Drawing.Size(121, 28);
            this.cboTalhão.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(7, 511);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 21);
            this.label5.TabIndex = 21;
            this.label5.Text = "Talhão";
            // 
            // cboColaborador
            // 
            this.cboColaborador.FormattingEnabled = true;
            this.cboColaborador.Location = new System.Drawing.Point(11, 450);
            this.cboColaborador.Name = "cboColaborador";
            this.cboColaborador.Size = new System.Drawing.Size(121, 28);
            this.cboColaborador.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(7, 426);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 21);
            this.label4.TabIndex = 19;
            this.label4.Text = "Colaborador envolvido";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(11, 680);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(132, 29);
            this.dateTimePicker2.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(7, 646);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Data de Termino";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbDespolpado);
            this.groupBox2.Controls.Add(this.rbLimpo);
            this.groupBox2.Controls.Add(this.rbNatural);
            this.groupBox2.Controls.Add(this.rbSeco);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Teal;
            this.groupBox2.Location = new System.Drawing.Point(11, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 175);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de Produção do café";
            // 
            // rbDespolpado
            // 
            this.rbDespolpado.AutoSize = true;
            this.rbDespolpado.Location = new System.Drawing.Point(10, 76);
            this.rbDespolpado.Name = "rbDespolpado";
            this.rbDespolpado.Size = new System.Drawing.Size(117, 25);
            this.rbDespolpado.TabIndex = 9;
            this.rbDespolpado.TabStop = true;
            this.rbDespolpado.Text = "Despolpado";
            this.rbDespolpado.UseVisualStyleBackColor = true;
            // 
            // rbLimpo
            // 
            this.rbLimpo.AutoSize = true;
            this.rbLimpo.Location = new System.Drawing.Point(10, 135);
            this.rbLimpo.Name = "rbLimpo";
            this.rbLimpo.Size = new System.Drawing.Size(114, 25);
            this.rbLimpo.TabIndex = 8;
            this.rbLimpo.TabStop = true;
            this.rbLimpo.Text = "Descascado";
            this.rbLimpo.UseVisualStyleBackColor = true;
            // 
            // rbNatural
            // 
            this.rbNatural.AutoSize = true;
            this.rbNatural.Location = new System.Drawing.Point(10, 46);
            this.rbNatural.Name = "rbNatural";
            this.rbNatural.Size = new System.Drawing.Size(81, 25);
            this.rbNatural.TabIndex = 6;
            this.rbNatural.TabStop = true;
            this.rbNatural.Text = "Natural";
            this.rbNatural.UseVisualStyleBackColor = true;
            // 
            // rbSeco
            // 
            this.rbSeco.AutoSize = true;
            this.rbSeco.Location = new System.Drawing.Point(10, 105);
            this.rbSeco.Name = "rbSeco";
            this.rbSeco.Size = new System.Drawing.Size(64, 25);
            this.rbSeco.TabIndex = 7;
            this.rbSeco.TabStop = true;
            this.rbSeco.Text = "Seco";
            this.rbSeco.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(11, 601);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(132, 29);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(7, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 56);
            this.label2.TabIndex = 1;
            this.label2.Text = "Custos de produção por unidade";
            // 
            // txtCustos
            // 
            this.txtCustos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustos.Location = new System.Drawing.Point(11, 378);
            this.txtCustos.Name = "txtCustos";
            this.txtCustos.Size = new System.Drawing.Size(175, 29);
            this.txtCustos.TabIndex = 4;
            this.txtCustos.TextChanged += new System.EventHandler(this.txtCustos_TextChanged);
            this.txtCustos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustos_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(12, 577);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data de Inicio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(370, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(227, 30);
            this.label8.TabIndex = 16;
            this.label8.Text = "Cadastro de Produção";
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Image = global::SgPropriedade_3._0.Properties.Resources.baixar__1_;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(66, 85);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(124, 49);
            this.btnSalvar.TabIndex = 17;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dgvclnIdProdução
            // 
            this.dgvclnIdProdução.DataPropertyName = "idprodução";
            this.dgvclnIdProdução.HeaderText = "IdProdução";
            this.dgvclnIdProdução.Name = "dgvclnIdProdução";
            this.dgvclnIdProdução.Visible = false;
            // 
            // dgvclnColaborador
            // 
            this.dgvclnColaborador.DataPropertyName = "nomeColaborador";
            this.dgvclnColaborador.HeaderText = "Colaborador";
            this.dgvclnColaborador.Name = "dgvclnColaborador";
            this.dgvclnColaborador.Width = 150;
            // 
            // dgvclnTalhão
            // 
            this.dgvclnTalhão.DataPropertyName = "nomeTalhão";
            this.dgvclnTalhão.HeaderText = "Talhão";
            this.dgvclnTalhão.Name = "dgvclnTalhão";
            // 
            // dgvclnObservação
            // 
            this.dgvclnObservação.DataPropertyName = "observação";
            this.dgvclnObservação.HeaderText = "Observação";
            this.dgvclnObservação.Name = "dgvclnObservação";
            this.dgvclnObservação.Width = 150;
            // 
            // dgvclnDataInicio
            // 
            this.dgvclnDataInicio.DataPropertyName = "dataInicio";
            this.dgvclnDataInicio.HeaderText = "Data Incio";
            this.dgvclnDataInicio.Name = "dgvclnDataInicio";
            this.dgvclnDataInicio.Width = 120;
            // 
            // dgvclnDataFim
            // 
            this.dgvclnDataFim.DataPropertyName = "dataTermino";
            this.dgvclnDataFim.HeaderText = "Data Fim";
            this.dgvclnDataFim.Name = "dgvclnDataFim";
            this.dgvclnDataFim.Width = 120;
            // 
            // dgvclnQuantidade
            // 
            this.dgvclnQuantidade.DataPropertyName = "quantidade";
            this.dgvclnQuantidade.HeaderText = "Quantidade Produzida";
            this.dgvclnQuantidade.Name = "dgvclnQuantidade";
            // 
            // dgvclnCustoUnitario
            // 
            this.dgvclnCustoUnitario.DataPropertyName = "custoUnitario";
            this.dgvclnCustoUnitario.HeaderText = "Custos Unitario";
            this.dgvclnCustoUnitario.Name = "dgvclnCustoUnitario";
            // 
            // dgvclnCustoTotal
            // 
            this.dgvclnCustoTotal.DataPropertyName = "custoTotal";
            this.dgvclnCustoTotal.HeaderText = "Custo Total";
            this.dgvclnCustoTotal.Name = "dgvclnCustoTotal";
            // 
            // btnEditar
            // 
            this.btnEditar.HeaderText = "";
            this.btnEditar.Image = global::SgPropriedade_3._0.Properties.Resources.caneta_esferografica;
            this.btnEditar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Width = 50;
            // 
            // btnExcluir
            // 
            this.btnExcluir.HeaderText = "";
            this.btnExcluir.Image = global::SgPropriedade_3._0.Properties.Resources.cancelar;
            this.btnExcluir.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Width = 50;
            // 
            // Form_Produção
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1504, 1013);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgvProdução);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_Produção";
            this.Text = "Form_Produção";
            this.Load += new System.EventHandler(this.Form_Produção_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdução)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.DataGridView dgvProdução;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboColaborador;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbDespolpado;
        private System.Windows.Forms.RadioButton rbLimpo;
        private System.Windows.Forms.RadioButton rbNatural;
        private System.Windows.Forms.RadioButton rbSeco;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboTalhão;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.RadioButton rbColaborador;
        private System.Windows.Forms.RadioButton rbData;
        private System.Windows.Forms.RadioButton rbTalhão;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvclnIdProdução;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvclnColaborador;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvclnTalhão;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvclnObservação;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvclnDataInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvclnDataFim;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvclnQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvclnCustoUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvclnCustoTotal;
        private System.Windows.Forms.DataGridViewImageColumn btnEditar;
        private System.Windows.Forms.DataGridViewImageColumn btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
    }
}