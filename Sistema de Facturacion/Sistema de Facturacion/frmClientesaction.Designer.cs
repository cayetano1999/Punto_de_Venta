namespace Sistema_de_Facturacion
{
    partial class frmClientesaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientesaction));
            this.panel1 = new System.Windows.Forms.Panel();
            this.combotipocliente2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.lblcliente = new System.Windows.Forms.TextBox();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtemail2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdireccion2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtidentificacion2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnombrecliente2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(134)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.combotipocliente2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblid);
            this.panel1.Controls.Add(this.lblcliente);
            this.panel1.Controls.Add(this.btneliminar);
            this.panel1.Controls.Add(this.btneditar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtemail2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtdireccion2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtidentificacion2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtnombrecliente2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 574);
            this.panel1.TabIndex = 2;
            // 
            // combotipocliente2
            // 
            this.combotipocliente2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.combotipocliente2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combotipocliente2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combotipocliente2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combotipocliente2.Items.AddRange(new object[] {
            "Multitareas",
            "Industriales",
            "Profesionales"});
            this.combotipocliente2.Location = new System.Drawing.Point(193, 423);
            this.combotipocliente2.Name = "combotipocliente2";
            this.combotipocliente2.Size = new System.Drawing.Size(328, 29);
            this.combotipocliente2.TabIndex = 82;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(190, 403);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 81;
            this.label5.Text = "TIPO CLIENTE";
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
            // lblcliente
            // 
            this.lblcliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblcliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(134)))), ((int)(((byte)(204)))));
            this.lblcliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblcliente.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcliente.ForeColor = System.Drawing.Color.White;
            this.lblcliente.Location = new System.Drawing.Point(-1, 35);
            this.lblcliente.Multiline = true;
            this.lblcliente.Name = "lblcliente";
            this.lblcliente.ReadOnly = true;
            this.lblcliente.Size = new System.Drawing.Size(712, 33);
            this.lblcliente.TabIndex = 78;
            this.lblcliente.Text = "OPCIONES DE CLIENTES";
            this.lblcliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.btneliminar.Location = new System.Drawing.Point(350, 484);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(166, 33);
            this.btneliminar.TabIndex = 77;
            this.btneliminar.Text = "   ELIMINAR CLIENTE";
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
            this.btneditar.Location = new System.Drawing.Point(182, 484);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(160, 33);
            this.btneditar.TabIndex = 76;
            this.btneditar.Text = "   EDITAR CLIENTE";
            this.btneditar.UseVisualStyleBackColor = false;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
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
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 72;
            this.label4.Text = "EMAIL";
            // 
            // txtemail2
            // 
            this.txtemail2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtemail2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtemail2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail2.Location = new System.Drawing.Point(193, 299);
            this.txtemail2.Multiline = true;
            this.txtemail2.Name = "txtemail2";
            this.txtemail2.Size = new System.Drawing.Size(328, 25);
            this.txtemail2.TabIndex = 71;
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
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 70;
            this.label3.Text = "DIRECCION";
            // 
            // txtdireccion2
            // 
            this.txtdireccion2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtdireccion2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtdireccion2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdireccion2.Location = new System.Drawing.Point(193, 363);
            this.txtdireccion2.Multiline = true;
            this.txtdireccion2.Name = "txtdireccion2";
            this.txtdireccion2.Size = new System.Drawing.Size(328, 25);
            this.txtdireccion2.TabIndex = 69;
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
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 68;
            this.label2.Text = "IDENTIFICACION";
            // 
            // txtidentificacion2
            // 
            this.txtidentificacion2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtidentificacion2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtidentificacion2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidentificacion2.Location = new System.Drawing.Point(193, 233);
            this.txtidentificacion2.Multiline = true;
            this.txtidentificacion2.Name = "txtidentificacion2";
            this.txtidentificacion2.Size = new System.Drawing.Size(328, 25);
            this.txtidentificacion2.TabIndex = 67;
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
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 66;
            this.label1.Text = "NOMBRE";
            // 
            // txtnombrecliente2
            // 
            this.txtnombrecliente2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtnombrecliente2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnombrecliente2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombrecliente2.Location = new System.Drawing.Point(193, 169);
            this.txtnombrecliente2.Multiline = true;
            this.txtnombrecliente2.Name = "txtnombrecliente2";
            this.txtnombrecliente2.Size = new System.Drawing.Size(328, 25);
            this.txtnombrecliente2.TabIndex = 65;
            // 
            // frmClientesaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 574);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmClientesaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CLIENTE";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lblid;
        public System.Windows.Forms.TextBox lblcliente;
        public System.Windows.Forms.Button btneliminar;
        public System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtemail2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtdireccion2;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtidentificacion2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtnombrecliente2;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox combotipocliente2;
    }
}