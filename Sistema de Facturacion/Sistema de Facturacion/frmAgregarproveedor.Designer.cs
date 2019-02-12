namespace Sistema_de_Facturacion
{
    partial class frmAgregarproveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarproveedor));
            this.lblid = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txttelefono = new System.Windows.Forms.MaskedTextBox();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnagregaruser = new System.Windows.Forms.Button();
            this.combotipocliente2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblnuevousuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtrepresentante = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtempresa = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.BackColor = System.Drawing.Color.Transparent;
            this.lblid.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.ForeColor = System.Drawing.Color.White;
            this.lblid.Location = new System.Drawing.Point(12, 15);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(15, 17);
            this.lblid.TabIndex = 79;
            this.lblid.Text = "0";
            this.lblid.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(134)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.txttelefono);
            this.panel1.Controls.Add(this.btneliminar);
            this.panel1.Controls.Add(this.btneditar);
            this.panel1.Controls.Add(this.btnagregaruser);
            this.panel1.Controls.Add(this.combotipocliente2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblid);
            this.panel1.Controls.Add(this.lblnuevousuario);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtdireccion);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtrepresentante);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtemail);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtempresa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 609);
            this.panel1.TabIndex = 1;
            // 
            // txttelefono
            // 
            this.txttelefono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txttelefono.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelefono.Location = new System.Drawing.Point(193, 297);
            this.txttelefono.Mask = "(999)000-0000";
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(328, 29);
            this.txttelefono.TabIndex = 88;
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
            this.btneliminar.Location = new System.Drawing.Point(361, 526);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(160, 33);
            this.btneliminar.TabIndex = 87;
            this.btneliminar.Text = "    ELIMINAR";
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
            this.btneditar.Location = new System.Drawing.Point(193, 526);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(160, 33);
            this.btneditar.TabIndex = 86;
            this.btneditar.Text = "EDITAR ";
            this.btneditar.UseVisualStyleBackColor = false;
            this.btneditar.Visible = false;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnagregaruser
            // 
            this.btnagregaruser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnagregaruser.BackColor = System.Drawing.Color.Black;
            this.btnagregaruser.FlatAppearance.BorderSize = 0;
            this.btnagregaruser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagregaruser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregaruser.ForeColor = System.Drawing.Color.White;
            this.btnagregaruser.Location = new System.Drawing.Point(271, 526);
            this.btnagregaruser.Name = "btnagregaruser";
            this.btnagregaruser.Size = new System.Drawing.Size(171, 33);
            this.btnagregaruser.TabIndex = 85;
            this.btnagregaruser.Text = "AGREGAR USUARIO";
            this.btnagregaruser.UseVisualStyleBackColor = false;
            this.btnagregaruser.Click += new System.EventHandler(this.btnagregaruser_Click);
            // 
            // combotipocliente2
            // 
            this.combotipocliente2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.combotipocliente2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combotipocliente2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combotipocliente2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combotipocliente2.Items.AddRange(new object[] {
            "Independiente",
            "Empresa"});
            this.combotipocliente2.Location = new System.Drawing.Point(193, 491);
            this.combotipocliente2.Name = "combotipocliente2";
            this.combotipocliente2.Size = new System.Drawing.Size(328, 29);
            this.combotipocliente2.TabIndex = 84;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(190, 471);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 17);
            this.label6.TabIndex = 83;
            this.label6.Text = "TIPO DE PROVEEDOR";
            // 
            // lblnuevousuario
            // 
            this.lblnuevousuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblnuevousuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(134)))), ((int)(((byte)(204)))));
            this.lblnuevousuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblnuevousuario.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnuevousuario.ForeColor = System.Drawing.Color.White;
            this.lblnuevousuario.Location = new System.Drawing.Point(-5, 52);
            this.lblnuevousuario.Multiline = true;
            this.lblnuevousuario.Name = "lblnuevousuario";
            this.lblnuevousuario.ReadOnly = true;
            this.lblnuevousuario.Size = new System.Drawing.Size(712, 33);
            this.lblnuevousuario.TabIndex = 78;
            this.lblnuevousuario.Text = "REGISTRAR NUEVO PROVEEDOR";
            this.lblnuevousuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(190, 409);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 75;
            this.label5.Text = "DIRECCION";
            // 
            // txtdireccion
            // 
            this.txtdireccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtdireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtdireccion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdireccion.Location = new System.Drawing.Point(193, 431);
            this.txtdireccion.Multiline = true;
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(328, 25);
            this.txtdireccion.TabIndex = 74;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(190, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 72;
            this.label4.Text = "TELEFONO";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(190, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 70;
            this.label3.Text = "REPRESENTANTE";
            // 
            // txtrepresentante
            // 
            this.txtrepresentante.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtrepresentante.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtrepresentante.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrepresentante.Location = new System.Drawing.Point(193, 363);
            this.txtrepresentante.Multiline = true;
            this.txtrepresentante.Name = "txtrepresentante";
            this.txtrepresentante.Size = new System.Drawing.Size(328, 25);
            this.txtrepresentante.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(190, 211);
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
            this.txtemail.Location = new System.Drawing.Point(193, 233);
            this.txtemail.Multiline = true;
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(328, 25);
            this.txtemail.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(190, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 66;
            this.label1.Text = "EMPRESA";
            // 
            // txtempresa
            // 
            this.txtempresa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtempresa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtempresa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtempresa.Location = new System.Drawing.Point(193, 169);
            this.txtempresa.Multiline = true;
            this.txtempresa.Name = "txtempresa";
            this.txtempresa.Size = new System.Drawing.Size(328, 25);
            this.txtempresa.TabIndex = 65;
            // 
            // frmAgregarproveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(703, 609);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAgregarproveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PROVEEDORES";
            this.Load += new System.EventHandler(this.frmAgregarproveedor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox lblnuevousuario;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtrepresentante;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtempresa;
        public System.Windows.Forms.ComboBox combotipocliente2;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button btneliminar;
        public System.Windows.Forms.Button btneditar;
        public System.Windows.Forms.Button btnagregaruser;
        public System.Windows.Forms.MaskedTextBox txttelefono;

    }
}