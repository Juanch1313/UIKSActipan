
namespace UIKSActipan
{
    partial class RegisterP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterP));
            this.barraTitulo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.btnMin = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.dtp_birthday = new System.Windows.Forms.DateTimePicker();
            this.cbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.cbEscolaridad = new System.Windows.Forms.ComboBox();
            this.txtOcupacion = new System.Windows.Forms.TextBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
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
            this.barraTitulo.Size = new System.Drawing.Size(800, 32);
            this.barraTitulo.TabIndex = 2;
            this.barraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barraTitulo_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(57, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "KS-Actipan";
            // 
            // Logo
            // 
            this.Logo.Image = global::UIKSActipan.Properties.Resources.KSLogo1;
            this.Logo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
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
            this.btnMin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnMin.Location = new System.Drawing.Point(703, 4);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(25, 25);
            this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMin.TabIndex = 4;
            this.btnMin.TabStop = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::UIKSActipan.Properties.Resources.CloseIcon;
            this.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClose.Location = new System.Drawing.Point(758, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 3;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(65, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(666, 55);
            this.label2.TabIndex = 3;
            this.label2.Text = "Registro de nuevo paciente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(55, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre del paciente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(55, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "Apellidos del paciente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(55, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 28);
            this.label5.TabIndex = 6;
            this.label5.Text = "Genero:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(55, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 28);
            this.label6.TabIndex = 7;
            this.label6.Text = "Numero telefonico:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(55, 392);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 28);
            this.label7.TabIndex = 8;
            this.label7.Text = "Domicilio:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(444, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(236, 28);
            this.label8.TabIndex = 9;
            this.label8.Text = "Fecha de nacimiento:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(444, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 28);
            this.label9.TabIndex = 10;
            this.label9.Text = "Estado civil:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(444, 250);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(317, 28);
            this.label10.TabIndex = 11;
            this.label10.Text = "Ultimo grado de escolaridad:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(444, 319);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 28);
            this.label11.TabIndex = 12;
            this.label11.Text = "Ocupación:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(444, 392);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 28);
            this.label12.TabIndex = 13;
            this.label12.Text = "Estado:";
            // 
            // txtName
            // 
            this.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtName.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(60, 135);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(213, 22);
            this.txtName.TabIndex = 14;
            // 
            // txtApellidos
            // 
            this.txtApellidos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellidos.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.Location = new System.Drawing.Point(61, 211);
            this.txtApellidos.MaxLength = 50;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(213, 22);
            this.txtApellidos.TabIndex = 15;
            // 
            // cbGenero
            // 
            this.cbGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cbGenero.Location = new System.Drawing.Point(61, 281);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(121, 28);
            this.cbGenero.TabIndex = 19;
            this.cbGenero.Text = "--Elige--";
            // 
            // txtTelefono
            // 
            this.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(60, 350);
            this.txtTelefono.MaxLength = 10;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(213, 22);
            this.txtTelefono.TabIndex = 20;
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDomicilio.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDomicilio.Location = new System.Drawing.Point(60, 423);
            this.txtDomicilio.MaxLength = 50;
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(213, 22);
            this.txtDomicilio.TabIndex = 21;
            // 
            // dtp_birthday
            // 
            this.dtp_birthday.CustomFormat = "yyyy-MM-dd";
            this.dtp_birthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_birthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_birthday.Location = new System.Drawing.Point(449, 136);
            this.dtp_birthday.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtp_birthday.Name = "dtp_birthday";
            this.dtp_birthday.Size = new System.Drawing.Size(217, 26);
            this.dtp_birthday.TabIndex = 22;
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
            this.cbEstadoCivil.Location = new System.Drawing.Point(449, 212);
            this.cbEstadoCivil.Name = "cbEstadoCivil";
            this.cbEstadoCivil.Size = new System.Drawing.Size(121, 28);
            this.cbEstadoCivil.TabIndex = 23;
            this.cbEstadoCivil.Text = "--Elige--";
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
            this.cbEscolaridad.Location = new System.Drawing.Point(449, 281);
            this.cbEscolaridad.Name = "cbEscolaridad";
            this.cbEscolaridad.Size = new System.Drawing.Size(121, 28);
            this.cbEscolaridad.TabIndex = 24;
            this.cbEscolaridad.Text = "--Elige--";
            // 
            // txtOcupacion
            // 
            this.txtOcupacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtOcupacion.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOcupacion.Location = new System.Drawing.Point(449, 350);
            this.txtOcupacion.MaxLength = 50;
            this.txtOcupacion.Name = "txtOcupacion";
            this.txtOcupacion.Size = new System.Drawing.Size(213, 22);
            this.txtOcupacion.TabIndex = 25;
            // 
            // cbEstado
            // 
            this.cbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Inactivo",
            "Activo"});
            this.cbEstado.Location = new System.Drawing.Point(449, 424);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(121, 28);
            this.cbEstado.TabIndex = 26;
            this.cbEstado.Text = "--Elige--";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.White;
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.FlatAppearance.BorderSize = 2;
            this.btnRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(313, 469);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(119, 52);
            this.btnRegister.TabIndex = 27;
            this.btnRegister.Text = "Registrar";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // RegisterP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(800, 539);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.txtOcupacion);
            this.Controls.Add(this.cbEscolaridad);
            this.Controls.Add(this.cbEstadoCivil);
            this.Controls.Add(this.dtp_birthday);
            this.Controls.Add(this.txtDomicilio);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.cbGenero);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.barraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegisterP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterP";
            this.barraTitulo.ResumeLayout(false);
            this.barraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel barraTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.PictureBox btnMin;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.DateTimePicker dtp_birthday;
        private System.Windows.Forms.ComboBox cbEstadoCivil;
        private System.Windows.Forms.ComboBox cbEscolaridad;
        private System.Windows.Forms.TextBox txtOcupacion;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Button btnRegister;
    }
}