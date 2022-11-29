
namespace UIKSActipan
{
    partial class ModifyE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyE));
            this.barraTitulo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.btnMin = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvEmploys = new System.Windows.Forms.DataGridView();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtLastNames = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.HidePass = new System.Windows.Forms.PictureBox();
            this.SeePass = new System.Windows.Forms.PictureBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnModify = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmploys)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.barraTitulo.Size = new System.Drawing.Size(1000, 32);
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
            this.btnMin.Location = new System.Drawing.Point(903, 4);
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
            this.btnClose.Location = new System.Drawing.Point(958, 4);
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
            this.label2.Location = new System.Drawing.Point(97, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(490, 55);
            this.label2.TabIndex = 2;
            this.label2.Text = "Modificar Empleado";
            // 
            // dgvEmploys
            // 
            this.dgvEmploys.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmploys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmploys.Location = new System.Drawing.Point(12, 162);
            this.dgvEmploys.Name = "dgvEmploys";
            this.dgvEmploys.Size = new System.Drawing.Size(646, 251);
            this.dgvEmploys.TabIndex = 3;
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(56, 203);
            this.txtUser.MaxLength = 50;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(213, 22);
            this.txtUser.TabIndex = 22;
            // 
            // txtLastNames
            // 
            this.txtLastNames.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLastNames.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastNames.Location = new System.Drawing.Point(56, 134);
            this.txtLastNames.MaxLength = 50;
            this.txtLastNames.Name = "txtLastNames";
            this.txtLastNames.Size = new System.Drawing.Size(213, 22);
            this.txtLastNames.TabIndex = 21;
            // 
            // txtName
            // 
            this.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtName.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(56, 55);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(213, 22);
            this.txtName.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(115, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 28);
            this.label5.TabIndex = 17;
            this.label5.Text = "Usuario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(28, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(265, 28);
            this.label4.TabIndex = 16;
            this.label4.Text = "Apellidos del empleado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(34, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 28);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nombre del empleado:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.HidePass);
            this.panel1.Controls.Add(this.SeePass);
            this.panel1.Controls.Add(this.txtPosition);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnModify);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtUser);
            this.panel1.Controls.Add(this.txtLastNames);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(673, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 467);
            this.panel1.TabIndex = 25;
            // 
            // HidePass
            // 
            this.HidePass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HidePass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HidePass.Image = global::UIKSActipan.Properties.Resources.CloseEyeIcon;
            this.HidePass.Location = new System.Drawing.Point(285, 269);
            this.HidePass.Name = "HidePass";
            this.HidePass.Size = new System.Drawing.Size(25, 25);
            this.HidePass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HidePass.TabIndex = 31;
            this.HidePass.TabStop = false;
            this.HidePass.Click += new System.EventHandler(this.HidePass_Click);
            // 
            // SeePass
            // 
            this.SeePass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SeePass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SeePass.Image = global::UIKSActipan.Properties.Resources.EyeIcon;
            this.SeePass.Location = new System.Drawing.Point(285, 272);
            this.SeePass.Name = "SeePass";
            this.SeePass.Size = new System.Drawing.Size(25, 25);
            this.SeePass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SeePass.TabIndex = 30;
            this.SeePass.TabStop = false;
            this.SeePass.Click += new System.EventHandler(this.SeePass_Click);
            // 
            // txtPosition
            // 
            this.txtPosition.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPosition.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPosition.Location = new System.Drawing.Point(56, 344);
            this.txtPosition.MaxLength = 50;
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(213, 22);
            this.txtPosition.TabIndex = 29;
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(56, 272);
            this.txtPass.MaxLength = 50;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(213, 22);
            this.txtPass.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(97, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 28);
            this.label7.TabIndex = 27;
            this.label7.Text = "Contraseña:";
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
            this.btnModify.Location = new System.Drawing.Point(107, 394);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(119, 52);
            this.btnModify.TabIndex = 26;
            this.btnModify.Text = "Modificar";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Visible = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(115, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 28);
            this.label8.TabIndex = 23;
            this.label8.Text = "Posición:";
            // 
            // txtSearch
            // 
            this.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(239, 128);
            this.txtSearch.MaxLength = 50;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(291, 22);
            this.txtSearch.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(221, 28);
            this.label6.TabIndex = 23;
            this.label6.Text = "Buscar por nombre:";
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
            this.btnSearch.Location = new System.Drawing.Point(536, 122);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(119, 34);
            this.btnSearch.TabIndex = 25;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.btnSelect.Location = new System.Drawing.Point(539, 428);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(119, 50);
            this.btnSelect.TabIndex = 26;
            this.btnSelect.Text = "Seleccionar";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Visible = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // ModifyE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(1000, 499);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvEmploys);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.barraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModifyE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModifyE";
            this.barraTitulo.ResumeLayout(false);
            this.barraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmploys)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.DataGridView dgvEmploys;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtLastNames;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.PictureBox HidePass;
        private System.Windows.Forms.PictureBox SeePass;
    }
}