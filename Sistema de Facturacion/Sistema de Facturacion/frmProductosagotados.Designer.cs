namespace Sistema_de_Facturacion
{
    partial class frmProductosagotados
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
            this.reportproductosagotados = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ProductosJoinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetAgotados = new Sistema_de_Facturacion.DataSetAgotados();
            this.ProductosJoinTableAdapter = new Sistema_de_Facturacion.DataSetAgotadosTableAdapters.ProductosJoinTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosJoinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetAgotados)).BeginInit();
            this.SuspendLayout();
            // 
            // reportproductosagotados
            // 
            this.reportproductosagotados.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ProductosJoinBindingSource;
            this.reportproductosagotados.LocalReport.DataSources.Add(reportDataSource1);
            this.reportproductosagotados.LocalReport.ReportEmbeddedResource = "Sistema_de_Facturacion.ReportAgotados.rdlc";
            this.reportproductosagotados.Location = new System.Drawing.Point(0, 0);
            this.reportproductosagotados.Name = "reportproductosagotados";
            this.reportproductosagotados.Size = new System.Drawing.Size(838, 689);
            this.reportproductosagotados.TabIndex = 0;
            // 
            // ProductosJoinBindingSource
            // 
            this.ProductosJoinBindingSource.DataMember = "ProductosJoin";
            this.ProductosJoinBindingSource.DataSource = this.DataSetAgotados;
            // 
            // DataSetAgotados
            // 
            this.DataSetAgotados.DataSetName = "DataSetAgotados";
            this.DataSetAgotados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ProductosJoinTableAdapter
            // 
            this.ProductosJoinTableAdapter.ClearBeforeFill = true;
            // 
            // frmProductosagotados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 689);
            this.Controls.Add(this.reportproductosagotados);
            this.Name = "frmProductosagotados";
            this.Text = "frmProductosagotados";
            this.Load += new System.EventHandler(this.frmProductosagotados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductosJoinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetAgotados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportproductosagotados;
        private System.Windows.Forms.BindingSource ProductosJoinBindingSource;
        private DataSetAgotados DataSetAgotados;
        private DataSetAgotadosTableAdapters.ProductosJoinTableAdapter ProductosJoinTableAdapter;
    }
}