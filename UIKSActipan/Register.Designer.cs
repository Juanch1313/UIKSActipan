
namespace UIKSActipan
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
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
            this.btnRegister = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLastNames = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtConPass = new System.Windows.Forms.TextBox();
            this.lbError = new System.Windows.Forms.Label();
            this.HidePass = new System.Windows.Forms.PictureBox();
            this.SeePass = new System.Windows.Forms.PictureBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HidePass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeePass)).BeginInit();
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
            this.barraTitulo.TabIndex = 1;
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
            this.label2.Location = new System.Drawing.Point(85, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(637, 55);
            this.label2.TabIndex = 2;
            this.label2.Text = "Registro de nuevo usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(90, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre del empleado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(87, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(265, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Apellidos del empleado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(174, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 28);
            this.label5.TabIndex = 5;
            this.label5.Text = "Usuario:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(472, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 28);
            this.label6.TabIndex = 6;
            this.label6.Text = "Contraseña:";
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
            this.btnRegister.Location = new System.Drawing.Point(333, 400);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(119, 52);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "Registrar";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(419, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(249, 28);
            this.label7.TabIndex = 8;
            this.label7.Text = "Confirmar contraseña:";
            // 
            // txtName
            // 
            this.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtName.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(115, 160);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(213, 22);
            this.txtName.TabIndex = 10;
            // 
            // txtLastNames
            // 
            this.txtLastNames.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLastNames.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastNames.Location = new System.Drawing.Point(115, 251);
            this.txtLastNames.MaxLength = 50;
            this.txtLastNames.Name = "txtLastNames";
            this.txtLastNames.Size = new System.Drawing.Size(213, 22);
            this.txtLastNames.TabIndex = 11;
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(115, 334);
            this.txtUser.MaxLength = 50;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(213, 22);
            this.txtUser.TabIndex = 12;
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(434, 247);
            this.txtPass.MaxLength = 50;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(213, 22);
            this.txtPass.TabIndex = 13;
            // 
            // txtConPass
            // 
            this.txtConPass.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConPass.Location = new System.Drawing.Point(434, 334);
            this.txtConPass.MaxLength = 50;
            this.txtConPass.Name = "txtConPass";
            this.txtConPass.PasswordChar = '*';
            this.txtConPass.Size = new System.Drawing.Size(213, 22);
            this.txtConPass.TabIndex = 14;
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbError.ForeColor = System.Drawing.Color.White;
            this.lbError.Location = new System.Drawing.Point(164, 465);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(0, 28);
            this.lbError.TabIndex = 17;
            // 
            // HidePass
            // 
            this.HidePass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HidePass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HidePass.Image = global::UIKSActipan.Properties.Resources.CloseEyeIcon;
            this.HidePass.Location = new System.Drawing.Point(672, 244);
            this.HidePass.Name = "HidePass";
            this.HidePass.Size = new System.Drawing.Size(25, 25);
            this.HidePass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HidePass.TabIndex = 15;
            this.HidePass.TabStop = false;
            this.HidePass.Click += new System.EventHandler(this.HidePass_Click);
            // 
            // SeePass
            // 
            this.SeePass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SeePass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SeePass.Image = global::UIKSActipan.Properties.Resources.EyeIcon;
            this.SeePass.Location = new System.Drawing.Point(672, 247);
            this.SeePass.Name = "SeePass";
            this.SeePass.Size = new System.Drawing.Size(25, 25);
            this.SeePass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SeePass.TabIndex = 8;
            this.SeePass.TabStop = false;
            this.SeePass.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtPosition
            // 
            this.txtPosition.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPosition.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPosition.Location = new System.Drawing.Point(434, 160);
            this.txtPosition.MaxLength = 50;
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(213, 22);
            this.txtPosition.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(493, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 28);
            this.label8.TabIndex = 18;
            this.label8.Text = "Posición:";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(800, 513);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.HidePass);
            this.Controls.Add(this.txtConPass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtLastNames);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.SeePass);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.barraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.barraTitulo.ResumeLayout(false);
            this.barraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HidePass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeePass)).EndInit();
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
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox SeePass;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLastNames;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtConPass;
        private System.Windows.Forms.PictureBox HidePass;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Label label8;
    }
}