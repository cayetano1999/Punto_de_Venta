namespace Sistema_de_Facturacion
{
    partial class frmProductosactions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductosactions));
            this.label4 = new System.Windows.Forms.Label();
            this.txtexistencia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpiva = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.comboproveedor = new System.Windows.Forms.ComboBox();
            this.lblid = new System.Windows.Forms.Label();
            this.lblnuevousuario = new System.Windows.Forms.TextBox();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 72;
            this.label4.Text = "EXISTENCIA";
            // 
            // txtexistencia
            // 
            this.txtexistencia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtexistencia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtexistencia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtexistencia.Location = new System.Drawing.Point(193, 299);
            this.txtexistencia.MaxLength = 6;
            this.txtexistencia.Multiline = true;
            this.txtexistencia.Name = "txtexistencia";
            this.txtexistencia.Size = new System.Drawing.Size(328, 25);
            this.txtexistencia.TabIndex = 71;
            this.txtexistencia.TextChanged += new System.EventHandler(this.txtexistencia_TextChanged);
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
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 70;
            this.label3.Text = "PIVA";
            // 
            // txtpiva
            // 
            this.txtpiva.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtpiva.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpiva.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpiva.Location = new System.Drawing.Point(193, 363);
            this.txtpiva.Multiline = true;
            this.txtpiva.Name = "txtpiva";
            this.txtpiva.Size = new System.Drawing.Size(328, 25);
            this.txtpiva.TabIndex = 69;
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
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 68;
            this.label2.Text = "PRECIO";
            // 
            // txtprecio
            // 
            this.txtprecio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtprecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtprecio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprecio.Location = new System.Drawing.Point(193, 233);
            this.txtprecio.MaxLength = 6;
            this.txtprecio.Multiline = true;
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(328, 25);
            this.txtprecio.TabIndex = 67;
            this.txtprecio.TextChanged += new System.EventHandler(this.txtprecio_TextChanged);
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
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 66;
            this.label1.Text = "DESCRIPCION";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtdescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtdescripcion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescripcion.Location = new System.Drawing.Point(193, 169);
            this.txtdescripcion.MaxLength = 80;
            this.txtdescripcion.Multiline = true;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(328, 25);
            this.txtdescripcion.TabIndex = 65;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(134)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.comboproveedor);
            this.panel1.Controls.Add(this.lblid);
            this.panel1.Controls.Add(this.lblnuevousuario);
            this.panel1.Controls.Add(this.btneliminar);
            this.panel1.Controls.Add(this.btneditar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtexistencia);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtpiva);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtprecio);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtdescripcion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 574);
            this.panel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(190, 400);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 81;
            this.label5.Text = "PROVEEDOR";
            // 
            // comboproveedor
            // 
            this.comboproveedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboproveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboproveedor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboproveedor.FormattingEnabled = true;
            this.comboproveedor.Items.AddRange(new object[] {
            "Seleccione..."});
            this.comboproveedor.Location = new System.Drawing.Point(193, 429);
            this.comboproveedor.Name = "comboproveedor";
            this.comboproveedor.Size = new System.Drawing.Size(328, 29);
            this.comboproveedor.TabIndex = 80;
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
            this.lblid.Size = new System.Drawing.Size(22, 17);
            this.lblid.TabIndex = 79;
            this.lblid.Text = "ID";
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
            this.lblnuevousuario.Text = "OPCIONES DE PRODUCTOS";
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
            this.btneliminar.Location = new System.Drawing.Point(355, 485);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(166, 33);
            this.btneliminar.TabIndex = 77;
            this.btneliminar.Text = "   ELIMINAR PRODUCTO";
            this.btneliminar.UseVisualStyleBackColor = false;
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
            this.btneditar.Location = new System.Drawing.Point(187, 485);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(160, 33);
            this.btneditar.TabIndex = 76;
            this.btneditar.Text = "   EDITAR PRODUCTO";
            this.btneditar.UseVisualStyleBackColor = false;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // frmProductosactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 574);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProductosactions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRODUCTOS";
            this.Load += new System.EventHandler(this.frmProductosactions_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btneliminar;
        public System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtexistencia;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtpiva;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lblid;
        public System.Windows.Forms.TextBox lblnuevousuario;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox comboproveedor;
    }
}