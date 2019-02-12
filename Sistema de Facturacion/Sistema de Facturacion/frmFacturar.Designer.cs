namespace Sistema_de_Facturacion
{
    partial class frmFacturar
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFacturar));
            this.Detalle_FacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetFactura = new Sistema_de_Facturacion.DataSetFactura();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Detalle_FacturaTableAdapter = new Sistema_de_Facturacion.DataSetFacturaTableAdapters.Detalle_FacturaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Detalle_FacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // Detalle_FacturaBindingSource
            // 
            this.Detalle_FacturaBindingSource.DataMember = "Detalle_Factura";
            this.Detalle_FacturaBindingSource.DataSource = this.DataSetFactura;
            // 
            // DataSetFactura
            // 
            this.DataSetFactura.DataSetName = "DataSetFactura";
            this.DataSetFactura.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Detalle_FacturaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_de_Facturacion.factura.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(600, 584);
            this.reportViewer1.TabIndex = 0;
            // 
            // Detalle_FacturaTableAdapter
            // 
            this.Detalle_FacturaTableAdapter.ClearBeforeFill = true;
            // 
            // frmFacturar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 584);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFacturar";
            this.Text = "FACTURA";
            this.Load += new System.EventHandler(this.frmFacturar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Detalle_FacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetFactura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Detalle_FacturaBindingSource;
        private DataSetFactura DataSetFactura;
        private DataSetFacturaTableAdapters.Detalle_FacturaTableAdapter Detalle_FacturaTableAdapter;
    }
}