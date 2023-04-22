
namespace SGPropriedade3
{
    partial class Form_Cd_ServiçosExecutados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Cd_ServiçosExecutados));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboColaborador = new System.Windows.Forms.ComboBox();
            this.cboTalhão = new System.Windows.Forms.ComboBox();
            this.cboServiço = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbDeCasa = new System.Windows.Forms.RadioButton();
            this.rbAPagar = new System.Windows.Forms.RadioButton();
            this.rbPago = new System.Windows.Forms.RadioButton();
            this.dgvServiçosExecutados = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dgvclnidExecuçãoAtividades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvclnColaborador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvclnTalhão = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvclnAtividade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvclnDataComeço = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvclndataTermino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvclnSituação = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvclnCadastroServiço_idserviço = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvclnColaborador_idColaborador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvclnTalhão_idTalhão = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnExcluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiçosExecutados)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboColaborador);
            this.groupBox1.Controls.Add(this.cboTalhão);
            this.groupBox1.Controls.Add(this.cboServiço);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(59, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 254);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informaçoes da Execução de Atividades";
            // 
            // cboColaborador
            // 
            this.cboColaborador.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboColaborador.FormattingEnabled = true;
            this.cboColaborador.Location = new System.Drawing.Point(6, 198);
            this.cboColaborador.Name = "cboColaborador";
            this.cboColaborador.Size = new System.Drawing.Size(160, 29);
            this.cboColaborador.TabIndex = 5;
            this.cboColaborador.Text = "Selecione ";
            // 
            // cboTalhão
            // 
            this.cboTalhão.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTalhão.FormattingEnabled = true;
            this.cboTalhão.Location = new System.Drawing.Point(5, 135);
            this.cboTalhão.Name = "cboTalhão";
            this.cboTalhão.Size = new System.Drawing.Size(160, 29);
            this.cboTalhão.TabIndex = 4;
            this.cboTalhão.Text = "Selecione ";
            // 
            // cboServiço
            // 
            this.cboServiço.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboServiço.FormattingEnabled = true;
            this.cboServiço.Location = new System.Drawing.Point(6, 74);
            this.cboServiço.Name = "cboServiço";
            this.cboServiço.Size = new System.Drawing.Size(160, 29);
            this.cboServiço.TabIndex = 3;
            this.cboServiço.Text = "Selecione ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(9, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Talhão";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(6, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Colaborador";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(6, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Serviço";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(313, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 237);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações complementares";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(132, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 21);
            this.label7.TabIndex = 11;
            this.label7.Text = "Data de Termino";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(132, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Data de inicio";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(136, 166);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 29);
            this.dateTimePicker2.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(136, 85);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 29);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbDeCasa);
            this.groupBox3.Controls.Add(this.rbAPagar);
            this.groupBox3.Controls.Add(this.rbPago);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Teal;
            this.groupBox3.Location = new System.Drawing.Point(6, 46);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(98, 154);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Situação";
            // 
            // rbDeCasa
            // 
            this.rbDeCasa.AutoSize = true;
            this.rbDeCasa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDeCasa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbDeCasa.Location = new System.Drawing.Point(6, 93);
            this.rbDeCasa.Name = "rbDeCasa";
            this.rbDeCasa.Size = new System.Drawing.Size(58, 25);
            this.rbDeCasa.TabIndex = 2;
            this.rbDeCasa.TabStop = true;
            this.rbDeCasa.Text = "casa";
            this.rbDeCasa.UseVisualStyleBackColor = true;
            // 
            // rbAPagar
            // 
            this.rbAPagar.AutoSize = true;
            this.rbAPagar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAPagar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbAPagar.Location = new System.Drawing.Point(6, 62);
            this.rbAPagar.Name = "rbAPagar";
            this.rbAPagar.Size = new System.Drawing.Size(78, 25);
            this.rbAPagar.TabIndex = 1;
            this.rbAPagar.TabStop = true;
            this.rbAPagar.Text = "Apagar";
            this.rbAPagar.UseVisualStyleBackColor = true;
            // 
            // rbPago
            // 
            this.rbPago.AutoSize = true;
            this.rbPago.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPago.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbPago.Location = new System.Drawing.Point(6, 31);
            this.rbPago.Name = "rbPago";
            this.rbPago.Size = new System.Drawing.Size(62, 25);
            this.rbPago.TabIndex = 0;
            this.rbPago.TabStop = true;
            this.rbPago.Text = "Pago";
            this.rbPago.UseVisualStyleBackColor = true;
            // 
            // dgvServiçosExecutados
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            this.dgvServiçosExecutados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvServiçosExecutados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvServiçosExecutados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvServiçosExecutados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvServiçosExecutados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServiçosExecutados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvclnidExecuçãoAtividades,
            this.dgvclnColaborador,
            this.dgvclnTalhão,
            this.dgvclnAtividade,
            this.dgvclnDataComeço,
            this.dgvclndataTermino,
            this.dgvclnSituação,
            this.dgvclnCadastroServiço_idserviço,
            this.dgvclnColaborador_idColaborador,
            this.dgvclnTalhão_idTalhão,
            this.btnEditar,
            this.btnExcluir});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvServiçosExecutados.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvServiçosExecutados.Location = new System.Drawing.Point(121, 440);
            this.dgvServiçosExecutados.Name = "dgvServiçosExecutados";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvServiçosExecutados.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvServiçosExecutados.Size = new System.Drawing.Size(854, 467);
            this.dgvServiçosExecutados.TabIndex = 2;
            this.dgvServiçosExecutados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServiços_CellContentClick);
            this.dgvServiçosExecutados.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvServiços_DataBindingComplete);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnLimpar);
            this.groupBox4.Controls.Add(this.btnPesquisar);
            this.groupBox4.Controls.Add(this.txtPesquisar);
            this.groupBox4.Location = new System.Drawing.Point(708, 94);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(477, 63);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
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
            this.btnLimpar.Location = new System.Drawing.Point(328, 16);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(134, 29);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
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
            this.txtPesquisar.Location = new System.Drawing.Point(0, 17);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(272, 29);
            this.txtPesquisar.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(285, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(322, 30);
            this.label5.TabIndex = 14;
            this.label5.Text = "Cadastro de serfiços executados";
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Image = global::SgPropriedade_3._0.Properties.Resources.baixar__1_;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(59, 99);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(124, 49);
            this.btnSalvar.TabIndex = 15;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dgvclnidExecuçãoAtividades
            // 
            this.dgvclnidExecuçãoAtividades.DataPropertyName = "idExecuçãoAtividades";
            this.dgvclnidExecuçãoAtividades.HeaderText = "idExecuçãoAtividades";
            this.dgvclnidExecuçãoAtividades.Name = "dgvclnidExecuçãoAtividades";
            this.dgvclnidExecuçãoAtividades.Visible = false;
            // 
            // dgvclnColaborador
            // 
            this.dgvclnColaborador.DataPropertyName = "Colaborador";
            this.dgvclnColaborador.HeaderText = "Colaborador";
            this.dgvclnColaborador.Name = "dgvclnColaborador";
            // 
            // dgvclnTalhão
            // 
            this.dgvclnTalhão.DataPropertyName = "Talhão";
            this.dgvclnTalhão.HeaderText = "Talhão";
            this.dgvclnTalhão.Name = "dgvclnTalhão";
            // 
            // dgvclnAtividade
            // 
            this.dgvclnAtividade.DataPropertyName = "CadastroServiço";
            this.dgvclnAtividade.HeaderText = "Atividade";
            this.dgvclnAtividade.Name = "dgvclnAtividade";
            // 
            // dgvclnDataComeço
            // 
            this.dgvclnDataComeço.DataPropertyName = "dataInicio";
            this.dgvclnDataComeço.HeaderText = "Data de Inicio";
            this.dgvclnDataComeço.Name = "dgvclnDataComeço";
            // 
            // dgvclndataTermino
            // 
            this.dgvclndataTermino.DataPropertyName = "dataTermino";
            this.dgvclndataTermino.HeaderText = "Data de termino";
            this.dgvclndataTermino.Name = "dgvclndataTermino";
            // 
            // dgvclnSituação
            // 
            this.dgvclnSituação.DataPropertyName = "situação";
            this.dgvclnSituação.HeaderText = "Situação";
            this.dgvclnSituação.Name = "dgvclnSituação";
            // 
            // dgvclnCadastroServiço_idserviço
            // 
            this.dgvclnCadastroServiço_idserviço.DataPropertyName = "CadastroServiço_idserviço";
            this.dgvclnCadastroServiço_idserviço.HeaderText = "CadastroServiço_idserviço";
            this.dgvclnCadastroServiço_idserviço.Name = "dgvclnCadastroServiço_idserviço";
            this.dgvclnCadastroServiço_idserviço.Visible = false;
            // 
            // dgvclnColaborador_idColaborador
            // 
            this.dgvclnColaborador_idColaborador.DataPropertyName = "Colaborador_idColaborador";
            this.dgvclnColaborador_idColaborador.HeaderText = "Colaborador_idColaborador";
            this.dgvclnColaborador_idColaborador.Name = "dgvclnColaborador_idColaborador";
            this.dgvclnColaborador_idColaborador.Visible = false;
            // 
            // dgvclnTalhão_idTalhão
            // 
            this.dgvclnTalhão_idTalhão.DataPropertyName = "Talhão_idTalhão";
            this.dgvclnTalhão_idTalhão.HeaderText = "Talhão_idTalhão";
            this.dgvclnTalhão_idTalhão.Name = "dgvclnTalhão_idTalhão";
            this.dgvclnTalhão_idTalhão.Visible = false;
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
            // Form_Cd_ServiçosExecutados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1217, 937);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.dgvServiçosExecutados);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_Cd_ServiçosExecutados";
            this.Text = "Form_Cd_ServiçosExecutados";
            this.Load += new System.EventHandler(this.Form_ExecuçãodeAtividades_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiçosExecutados)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboColaborador;
        private System.Windows.Forms.ComboBox cboTalhão;
        private System.Windows.Forms.ComboBox cboServiço;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbDeCasa;
        private System.Windows.Forms.RadioButton rbAPagar;
        private System.Windows.Forms.RadioButton rbPago;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dgvServiçosExecutados;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvclnidExecuçãoAtividades;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvclnColaborador;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvclnTalhão;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvclnAtividade;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvclnDataComeço;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvclndataTermino;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvclnSituação;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvclnCadastroServiço_idserviço;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvclnColaborador_idColaborador;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvclnTalhão_idTalhão;
        private System.Windows.Forms.DataGridViewImageColumn btnEditar;
        private System.Windows.Forms.DataGridViewImageColumn btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
    }
}