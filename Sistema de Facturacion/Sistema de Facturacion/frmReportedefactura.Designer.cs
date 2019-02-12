namespace Sistema_de_Facturacion
{
    partial class frmReportedefactura
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportedefactura));
            this.AdministrarFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetReporteFactura = new Sistema_de_Facturacion.DataSetReporteFactura();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.AdministrarFacturaTableAdapter = new Sistema_de_Facturacion.DataSetReporteFacturaTableAdapters.AdministrarFacturaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.AdministrarFacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReporteFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // AdministrarFacturaBindingSource
            // 
            this.AdministrarFacturaBindingSource.DataMember = "AdministrarFactura";
            this.AdministrarFacturaBindingSource.DataSource = this.DataSetReporteFactura;
            // 
            // DataSetReporteFactura
            // 
            this.DataSetReporteFactura.DataSetName = "DataSetReporteFactura";
            this.DataSetReporteFactura.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.AdministrarFacturaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_de_Facturacion.ReportInformeFacturas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(679, 650);
            this.reportViewer1.TabIndex = 0;
            // 
            // AdministrarFacturaTableAdapter
            // 
            this.AdministrarFacturaTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportedefactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 650);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReportedefactura";
            this.Text = "REPORTE FACTURA";
            this.Load += new System.EventHandler(this.frmReportedefactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AdministrarFacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReporteFactura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource AdministrarFacturaBindingSource;
        private DataSetReporteFactura DataSetReporteFactura;
        private DataSetReporteFacturaTableAdapters.AdministrarFacturaTableAdapter AdministrarFacturaTableAdapter;
    }
}