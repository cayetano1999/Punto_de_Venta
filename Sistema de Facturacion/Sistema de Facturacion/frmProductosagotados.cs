using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Facturacion
{
    public partial class frmProductosagotados : Form
    {
        public frmProductosagotados()
        {
            InitializeComponent();
        }

        private void frmProductosagotados_Load(object sender, EventArgs e)
        {
            this.ProductosJoinTableAdapter.Fill(this.DataSetAgotados.ProductosJoin);
            ReportParameter empresa = new ReportParameter("empresa", LoadDataConfig.Nombre_Empresa.ToUpper());
            ReportParameter direccion = new ReportParameter("direccion", LoadDataConfig.Direccion_Empresa);
            ReportParameter telefono = new ReportParameter("telefono", LoadDataConfig.Telefono);
            ReportParameter correo = new ReportParameter("correo", LoadDataConfig.Email);

            this.reportproductosagotados.LocalReport.SetParameters(new ReportParameter[] {
                empresa, 
                direccion,
                telefono,
                correo
            });
            // TODO: esta línea de código carga datos en la tabla 'DataSetAgotados.ProductosJoin' Puede moverla o quitarla según sea necesario.
            

            this.reportproductosagotados.RefreshReport();
        }
    }
}
