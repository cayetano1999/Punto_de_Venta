namespace Sistema_de_Facturacion
{
    partial class frmMensajes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMensajes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblmensaje = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnno = new System.Windows.Forms.Button();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.txtmensaje = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picturepregunta = new System.Windows.Forms.PictureBox();
            this.pictuerebad = new System.Windows.Forms.PictureBox();
            this.pictureok = new System.Windows.Forms.PictureBox();
            this.picturealerta = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturepregunta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictuerebad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturealerta)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(134)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.lblmensaje);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 46);
            this.panel1.TabIndex = 0;
            // 
            // lblmensaje
            // 
            this.lblmensaje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblmensaje.AutoSize = true;
            this.lblmensaje.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmensaje.ForeColor = System.Drawing.Color.White;
            this.lblmensaje.Location = new System.Drawing.Point(13, 10);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(98, 25);
            this.lblmensaje.TabIndex = 60;
            this.lblmensaje.Text = "MENSAJE";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(134)))), ((int)(((byte)(204)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnno);
            this.panel2.Controls.Add(this.btnaceptar);
            this.panel2.Location = new System.Drawing.Point(0, 255);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(603, 46);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(235, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "ACEPTAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnno
            // 
            this.btnno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnno.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnno.ForeColor = System.Drawing.Color.White;
            this.btnno.Location = new System.Drawing.Point(3, 5);
            this.btnno.Name = "btnno";
            this.btnno.Size = new System.Drawing.Size(132, 34);
            this.btnno.TabIndex = 1;
            this.btnno.Text = "NO";
            this.btnno.UseVisualStyleBackColor = true;
            this.btnno.Visible = false;
            this.btnno.Click += new System.EventHandler(this.btnno_Click);
            // 
            // btnaceptar
            // 
            this.btnaceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnaceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaceptar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaceptar.ForeColor = System.Drawing.Color.White;
            this.btnaceptar.Location = new System.Drawing.Point(446, 5);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(132, 34);
            this.btnaceptar.TabIndex = 0;
            this.btnaceptar.Text = "SI";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Visible = false;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // txtmensaje
            // 
            this.txtmensaje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtmensaje.BackColor = System.Drawing.Color.White;
            this.txtmensaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmensaje.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmensaje.Location = new System.Drawing.Point(0, 179);
            this.txtmensaje.Name = "txtmensaje";
            this.txtmensaje.ReadOnly = true;
            this.txtmensaje.Size = new System.Drawing.Size(603, 28);
            this.txtmensaje.TabIndex = 2;
            this.txtmensaje.Text = "Datos Guardados!";
            this.txtmensaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // picturepregunta
            // 
            this.picturepregunta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picturepregunta.Image = ((System.Drawing.Image)(resources.GetObject("picturepregunta.Image")));
            this.picturepregunta.Location = new System.Drawing.Point(242, 76);
            this.picturepregunta.Name = "picturepregunta";
            this.picturepregunta.Size = new System.Drawing.Size(105, 97);
            this.picturepregunta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturepregunta.TabIndex = 6;
            this.picturepregunta.TabStop = false;
            this.picturepregunta.Visible = false;
            // 
            // pictuerebad
            // 
            this.pictuerebad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictuerebad.Image = ((System.Drawing.Image)(resources.GetObject("pictuerebad.Image")));
            this.pictuerebad.Location = new System.Drawing.Point(242, 76);
            this.pictuerebad.Name = "pictuerebad";
            this.pictuerebad.Size = new System.Drawing.Size(105, 97);
            this.pictuerebad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictuerebad.TabIndex = 5;
            this.pictuerebad.TabStop = false;
            this.pictuerebad.Visible = false;
            // 
            // pictureok
            // 
            this.pictureok.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureok.Image = ((System.Drawing.Image)(resources.GetObject("pictureok.Image")));
            this.pictureok.Location = new System.Drawing.Point(242, 76);
            this.pictureok.Name = "pictureok";
            this.pictureok.Size = new System.Drawing.Size(105, 97);
            this.pictureok.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureok.TabIndex = 3;
            this.pictureok.TabStop = false;
            this.pictureok.Visible = false;
            // 
            // picturealerta
            // 
            this.picturealerta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picturealerta.Image = ((System.Drawing.Image)(resources.GetObject("picturealerta.Image")));
            this.picturealerta.Location = new System.Drawing.Point(242, 76);
            this.picturealerta.Name = "picturealerta";
            this.picturealerta.Size = new System.Drawing.Size(105, 97);
            this.picturealerta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturealerta.TabIndex = 7;
            this.picturealerta.TabStop = false;
            this.picturealerta.Visible = false;
            // 
            // frmMensajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(603, 301);
            this.Controls.Add(this.picturealerta);
            this.Controls.Add(this.picturepregunta);
            this.Controls.Add(this.pictuerebad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureok);
            this.Controls.Add(this.txtmensaje);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMensajes";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmMensajes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picturepregunta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictuerebad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturealerta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TextBox txtmensaje;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox pictuerebad;
        public System.Windows.Forms.PictureBox picturepregunta;
        public System.Windows.Forms.PictureBox pictureok;
        public System.Windows.Forms.Label lblmensaje;
        public System.Windows.Forms.PictureBox picturealerta;
        public System.Windows.Forms.Button btnaceptar;
        public System.Windows.Forms.Button btnno;
        public System.Windows.Forms.Button button1;
    }
}