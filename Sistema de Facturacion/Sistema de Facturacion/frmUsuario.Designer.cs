namespace Sistema_de_Facturacion
{
    partial class frmUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblid = new System.Windows.Forms.Label();
            this.lblnuevousuario = new System.Windows.Forms.TextBox();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtrepetircontrasena = new System.Windows.Forms.TextBox();
            this.btnagregaruser = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcontrasena = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.combotipousuario = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(134)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.combotipousuario);
            this.panel1.Controls.Add(this.lblid);
            this.panel1.Controls.Add(this.lblnuevousuario);
            this.panel1.Controls.Add(this.btneliminar);
            this.panel1.Controls.Add(this.btneditar);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtrepetircontrasena);
            this.panel1.Controls.Add(this.btnagregaruser);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtusuario);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtcontrasena);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtemail);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtnombre);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 574);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblid
            // 
            this.lblid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblid.AutoSize = true;
            this.lblid.BackColor = System.Drawing.Color.Transparent;
            this.lblid.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.ForeColor = System.Drawing.Color.White;
            this.lblid.Location = new System.Drawing.Point(12, 15);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(137, 17);
            this.lblid.TabIndex = 79;
            this.lblid.Text = "NOMBRE COMPLETO";
            this.lblid.Visible = false;
            // 
            // lblnuevousuario
            // 
            this.lblnuevousuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblnuevousuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(134)))), ((int)(((byte)(204)))));
            this.lblnuevousuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblnuevousuario.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnuevousuario.ForeColor = System.Drawing.Color.White;
            this.lblnuevousuario.Location = new System.Drawing.Point(-1, 35);
            this.lblnuevousuario.Multiline = true;
            this.lblnuevousuario.Name = "lblnuevousuario";
            this.lblnuevousuario.ReadOnly = true;
            this.lblnuevousuario.Size = new System.Drawing.Size(712, 33);
            this.lblnuevousuario.TabIndex = 78;
            this.lblnuevousuario.Text = "REGISTRAR NUEVO USUARIO";
            this.lblnuevousuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btneliminar
            // 
            this.btneliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btneliminar.BackColor = System.Drawing.Color.IndianRed;
            this.btneliminar.FlatAppearance.BorderSize = 0;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.ForeColor = System.Drawing.Color.White;
            this.btneliminar.Image = ((System.Drawing.Image)(resources.GetObject("btneliminar.Image")));
            this.btneliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btneliminar.Location = new System.Drawing.Point(361, 507);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(160, 33);
            this.btneliminar.TabIndex = 77;
            this.btneliminar.Text = "    ELIMINAR USUARIO";
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Visible = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btneditar
            // 
            this.btneditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btneditar.BackColor = System.Drawing.Color.SteelBlue;
            this.btneditar.FlatAppearance.BorderSize = 0;
            this.btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneditar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditar.ForeColor = System.Drawing.Color.White;
            this.btneditar.Image = ((System.Drawing.Image)(resources.GetObject("btneditar.Image")));
            this.btneditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btneditar.Location = new System.Drawing.Point(193, 507);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(160, 33);
            this.btneditar.TabIndex = 76;
            this.btneditar.Text = "EDITAR USUARIO";
            this.btneditar.UseVisualStyleBackColor = false;
            this.btneditar.Visible = false;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(190, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 17);
            this.label5.TabIndex = 75;
            this.label5.Text = "REPETIR CONTRASEÑA";
            // 
            // txtrepetircontrasena
            // 
            this.txtrepetircontrasena.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtrepetircontrasena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtrepetircontrasena.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrepetircontrasena.Location = new System.Drawing.Point(193, 408);
            this.txtrepetircontrasena.Multiline = true;
            this.txtrepetircontrasena.Name = "txtrepetircontrasena";
            this.txtrepetircontrasena.PasswordChar = '*';
            this.txtrepetircontrasena.Size = new System.Drawing.Size(328, 25);
            this.txtrepetircontrasena.TabIndex = 74;
            // 
            // btnagregaruser
            // 
            this.btnagregaruser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnagregaruser.BackColor = System.Drawing.Color.Black;
            this.btnagregaruser.FlatAppearance.BorderSize = 0;
            this.btnagregaruser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagregaruser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregaruser.ForeColor = System.Drawing.Color.White;
            this.btnagregaruser.Location = new System.Drawing.Point(271, 507);
            this.btnagregaruser.Name = "btnagregaruser";
            this.btnagregaruser.Size = new System.Drawing.Size(171, 33);
            this.btnagregaruser.TabIndex = 73;
            this.btnagregaruser.Text = "AGREGAR USUARIO";
            this.btnagregaruser.UseVisualStyleBackColor = false;
            this.btnagregaruser.Click += new System.EventHandler(this.btnagregaruser_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(190, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 72;
            this.label4.Text = "USUARIO";
            // 
            // txtusuario
            // 
            this.txtusuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtusuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtusuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.Location = new System.Drawing.Point(193, 276);
            this.txtusuario.Multiline = true;
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(328, 25);
            this.txtusuario.TabIndex = 71;
            this.txtusuario.TextChanged += new System.EventHandler(this.txtusuario_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(190, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 70;
            this.label3.Text = "CONTRASEÑA";
            // 
            // txtcontrasena
            // 
            this.txtcontrasena.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtcontrasena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcontrasena.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontrasena.Location = new System.Drawing.Point(193, 340);
            this.txtcontrasena.Multiline = true;
            this.txtcontrasena.Name = "txtcontrasena";
            this.txtcontrasena.PasswordChar = '*';
            this.txtcontrasena.Size = new System.Drawing.Size(328, 25);
            this.txtcontrasena.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(190, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 68;
            this.label2.Text = "EMAIL";
            // 
            // txtemail
            // 
            this.txtemail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtemail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtemail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(193, 210);
            this.txtemail.Multiline = true;
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(328, 25);
            this.txtemail.TabIndex = 67;
            this.txtemail.TextChanged += new System.EventHandler(this.txtemail_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(190, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 66;
            this.label1.Text = "NOMBRE COMPLETO";
            // 
            // txtnombre
            // 
            this.txtnombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(193, 146);
            this.txtnombre.Multiline = true;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(328, 25);
            this.txtnombre.TabIndex = 65;
            this.txtnombre.TextChanged += new System.EventHandler(this.txtnombre_TextChanged);
            // 
            // combotipousuario
            // 
            this.combotipousuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combotipousuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combotipousuario.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combotipousuario.FormattingEnabled = true;
            this.combotipousuario.Items.AddRange(new object[] {
            "Seleccione el tipo de usuario...",
            "Administrador",
            "Vendedor"});
            this.combotipousuario.Location = new System.Drawing.Point(193, 467);
            this.combotipousuario.Name = "combotipousuario";
            this.combotipousuario.Size = new System.Drawing.Size(328, 28);
            this.combotipousuario.TabIndex = 80;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(190, 447);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 17);
            this.label6.TabIndex = 81;
            this.label6.Text = "TIPO DE USUARIO";
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(711, 574);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "USUARIO";
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtnombre;
        public System.Windows.Forms.TextBox txtusuario;
        public System.Windows.Forms.TextBox txtcontrasena;
        public System.Windows.Forms.TextBox txtemail;
        public System.Windows.Forms.TextBox txtrepetircontrasena;
        public System.Windows.Forms.TextBox lblnuevousuario;
        public System.Windows.Forms.Button btneliminar;
        public System.Windows.Forms.Button btneditar;
        public System.Windows.Forms.Button btnagregaruser;
        public System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox combotipousuario;
    }
}