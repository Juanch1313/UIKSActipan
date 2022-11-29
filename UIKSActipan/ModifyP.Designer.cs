
namespace UIKSActipan
{
    partial class ModifyP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyP));
            this.barraTitulo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.btnMin = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvPatients = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.cbEscolaridad = new System.Windows.Forms.ComboBox();
            this.cbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.dtp_birthday = new System.Windows.Forms.DateTimePicker();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtOcupation = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnModify = new System.Windows.Forms.Button();
            this.txtCell = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLastNames = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // barraTitulo
            // 
            this.barraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(255)))), ((int)(((byte)(51)))));
            this.barraTitulo.Controls.Add(this.label1);
            this.barraTitulo.Controls.Add(this.Logo);
            this.barraTitulo.Controls.Add(this.btnMin);
            this.barraTitulo.Controls.Add(this.btnClose);
            this.barraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraTitulo.Location = new System.Drawing.Point(0, 0);
            this.barraTitulo.Name = "barraTitulo";
            this.barraTitulo.Size = new System.Drawing.Size(1199, 32);
            this.barraTitulo.TabIndex = 2;
            this.barraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barraTitulo_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "KS-Actipan";
            // 
            // Logo
            // 
            this.Logo.Image = global::UIKSActipan.Properties.Resources.KSLogo1;
            this.Logo.Location = new System.Drawing.Point(4, 5);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(47, 24);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 6;
            this.Logo.TabStop = false;
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.Image = global::UIKSActipan.Properties.Resources.MinimizeIcon;
            this.btnMin.Location = new System.Drawing.Point(1102, 4);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(25, 25);
            this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMin.TabIndex = 4;
            this.btnMin.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::UIKSActipan.Properties.Resources.CloseIcon;
            this.btnClose.Location = new System.Drawing.Point(1157, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 3;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.White;
            this.btnSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelect.FlatAppearance.BorderSize = 2;
            this.btnSelect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(544, 545);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(119, 50);
            this.btnSelect.TabIndex = 32;
            this.btnSelect.Text = "Seleccionar";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Visible = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 2;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(541, 123);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(119, 34);
            this.btnSearch.TabIndex = 31;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(17, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(221, 28);
            this.label6.TabIndex = 29;
            this.label6.Text = "Buscar por nombre:";
            // 
            // txtSearch
            // 
            this.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(244, 129);
            this.txtSearch.MaxLength = 50;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(291, 22);
            this.txtSearch.TabIndex = 30;
            // 
            // dgvPatients
            // 
            this.dgvPatients.BackgroundColor = System.Drawing.Color.White;
            this.dgvPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatients.Location = new System.Drawing.Point(17, 163);
            this.dgvPatients.Name = "dgvPatients";
            this.dgvPatients.Size = new System.Drawing.Size(646, 376);
            this.dgvPatients.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(102, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(463, 55);
            this.label2.TabIndex = 27;
            this.label2.Text = "Modificar Paciente";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.cbEstado);
            this.panel1.Controls.Add(this.cbGenero);
            this.panel1.Controls.Add(this.cbEscolaridad);
            this.panel1.Controls.Add(this.cbEstadoCivil);
            this.panel1.Controls.Add(this.dtp_birthday);
            this.panel1.Controls.Add(this.txtAdress);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtOcupation);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnModify);
            this.panel1.Controls.Add(this.txtCell);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtLastNames);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(669, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 575);
            this.panel1.TabIndex = 33;
            // 
            // cbEstado
            // 
            this.cbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Inactvio",
            "Activo"});
            this.cbEstado.Location = new System.Drawing.Point(346, 327);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(121, 28);
            this.cbEstado.TabIndex = 43;
            this.cbEstado.Text = "--Elige--";
            // 
            // cbGenero
            // 
            this.cbGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cbGenero.Location = new System.Drawing.Point(72, 239);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(121, 28);
            this.cbGenero.TabIndex = 42;
            this.cbGenero.Text = "--Elige--";
            // 
            // cbEscolaridad
            // 
            this.cbEscolaridad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEscolaridad.FormattingEnabled = true;
            this.cbEscolaridad.Items.AddRange(new object[] {
            "Leer y Escribir",
            "Preescolar",
            "Primaria",
            "Secundaria",
            "Preparatoria",
            "Licenciatura",
            "Maestria"});
            this.cbEscolaridad.Location = new System.Drawing.Point(346, 156);
            this.cbEscolaridad.Name = "cbEscolaridad";
            this.cbEscolaridad.Size = new System.Drawing.Size(121, 28);
            this.cbEscolaridad.TabIndex = 41;
            this.cbEscolaridad.Text = "--Elige--";
            // 
            // cbEstadoCivil
            // 
            this.cbEstadoCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstadoCivil.FormattingEnabled = true;
            this.cbEstadoCivil.Items.AddRange(new object[] {
            "Solter@",
            "Casad@",
            "Viud@",
            "Divorciad@"});
            this.cbEstadoCivil.Location = new System.Drawing.Point(346, 66);
            this.cbEstadoCivil.Name = "cbEstadoCivil";
            this.cbEstadoCivil.Size = new System.Drawing.Size(121, 28);
            this.cbEstadoCivil.TabIndex = 40;
            this.cbEstadoCivil.Text = "--Elige--";
            // 
            // dtp_birthday
            // 
            this.dtp_birthday.CustomFormat = "yyyy-MM-dd";
            this.dtp_birthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_birthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_birthday.Location = new System.Drawing.Point(28, 423);
            this.dtp_birthday.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtp_birthday.Name = "dtp_birthday";
            this.dtp_birthday.Size = new System.Drawing.Size(213, 26);
            this.dtp_birthday.TabIndex = 39;
            // 
            // txtAdress
            // 
            this.txtAdress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAdress.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdress.Location = new System.Drawing.Point(299, 414);
            this.txtAdress.MaxLength = 50;
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(213, 22);
            this.txtAdress.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(349, 383);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 28);
            this.label9.TabIndex = 37;
            this.label9.Text = "Domicilio:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(363, 296);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 28);
            this.label10.TabIndex = 35;
            this.label10.Text = "Estado:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(334, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 28);
            this.label11.TabIndex = 29;
            this.label11.Text = "Estado civil:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(334, 120);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(138, 28);
            this.label12.TabIndex = 30;
            this.label12.Text = "Escolaridad:";
            // 
            // txtOcupation
            // 
            this.txtOcupation.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtOcupation.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOcupation.Location = new System.Drawing.Point(299, 239);
            this.txtOcupation.MaxLength = 50;
            this.txtOcupation.Name = "txtOcupation";
            this.txtOcupation.Size = new System.Drawing.Size(213, 22);
            this.txtOcupation.TabIndex = 34;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(341, 208);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(131, 28);
            this.label13.TabIndex = 31;
            this.label13.Text = "Ocupacion:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(14, 383);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(236, 28);
            this.label7.TabIndex = 27;
            this.label7.Text = "Fecha de nacimiento:";
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.White;
            this.btnModify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModify.FlatAppearance.BorderSize = 2;
            this.btnModify.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnModify.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModify.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.Location = new System.Drawing.Point(237, 511);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(119, 52);
            this.btnModify.TabIndex = 26;
            this.btnModify.Text = "Modificar";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Visible = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // txtCell
            // 
            this.txtCell.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCell.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell.Location = new System.Drawing.Point(28, 327);
            this.txtCell.MaxLength = 10;
            this.txtCell.Name = "txtCell";
            this.txtCell.Size = new System.Drawing.Size(213, 22);
            this.txtCell.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(87, 296);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 28);
            this.label8.TabIndex = 23;
            this.label8.Text = "Telefono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 28);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nombre del paciente:";
            // 
            // txtName
            // 
            this.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtName.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(28, 66);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(213, 22);
            this.txtName.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(7, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 28);
            this.label4.TabIndex = 16;
            this.label4.Text = "Apellidos del paciente:";
            // 
            // txtLastNames
            // 
            this.txtLastNames.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLastNames.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastNames.Location = new System.Drawing.Point(28, 156);
            this.txtLastNames.MaxLength = 50;
            this.txtLastNames.Name = "txtLastNames";
            this.txtLastNames.Size = new System.Drawing.Size(213, 22);
            this.txtLastNames.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(87, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 28);
            this.label5.TabIndex = 17;
            this.label5.Text = "Genero:";
            // 
            // ModifyP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(1199, 607);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvPatients);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.barraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModifyP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModifyP";
            this.barraTitulo.ResumeLayout(false);
            this.barraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel barraTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.PictureBox btnMin;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvPatients;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.TextBox txtCell;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLastNames;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtOcupation;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtp_birthday;
        private System.Windows.Forms.ComboBox cbEstadoCivil;
        private System.Windows.Forms.ComboBox cbEscolaridad;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.ComboBox cbEstado;
    }
}