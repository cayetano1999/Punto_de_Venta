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
    public partial class frmReportedefactura : Form
    {
        public frmReportedefactura()
        {
            InitializeComponent();
        }


        Conexion cn = new Conexion();

        public string fecharepor;
        public string fechadetallada;
        

        private void frmReportedefactura_Load(object sender, EventArgs e)
        {
            //double impuestos = int.Parse(cn.SUM(fecharepor)) *  double.Parse("0.18");

            string x = cn.SUM(fecharepor,"entero").ToString();
          
            string iva = Convert.ToDouble(double.Parse(x.ToString()) *  double.Parse(LoadDataConfig.IVA.ToString())).ToString("N");

            
            
            string fechainicio = fecharepor.Replace('/', '-') + " 00:00:00:00.000";

            string fechahoy = DateTime.Now.ToString("yyyy-MM-dd")+" 23:59:00:00.000";
            

            


            //MessageBox.Show(impuestos.ToString());

            //DateTime date = DateTime.Parse(fecharepor);
            //string h=  Convert.ToDateTime(date.ToShortDateString()).ToString("MM/dd/yyyy");
            //MessageBox.Show(h.ToString());

            this.AdministrarFacturaTableAdapter.Fill(this.DataSetReporteFactura.AdministrarFactura,fecharepor);
            ReportParameter empresa = new ReportParameter("empresa", LoadDataConfig.Nombre_Empresa.ToUpper());
            ReportParameter direccion = new ReportParameter("direccion",LoadDataConfig.Direccion_Empresa);
            ReportParameter telefono = new ReportParameter("telefono", LoadDataConfig.Telefono);
            ReportParameter correo = new ReportParameter("correo", LoadDataConfig.Email);
            ReportParameter identificador = new ReportParameter("identificador", "REPORTE FAC-01");
            ReportParameter fechareporte = new ReportParameter("fechareporte", DateTime.Now.ToString());
            ReportParameter usuario = new ReportParameter("usuario", LoadData.Nombre.ToUpper());
            ReportParameter fecha = new ReportParameter("fecha", fechadetallada.ToString());
            ReportParameter totalfacturas = new ReportParameter("totalfacturas",cn.COUNT(fecharepor, "Factura", true));
            ReportParameter totaldeventas = new ReportParameter("totaldeventas", cn.SUM(fecharepor, "decimal"));
            ReportParameter ivaimpuestos = new ReportParameter("ivaimpuestos", iva.ToString());

            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] {
                empresa, 
                direccion,
                telefono,
                correo, 
                identificador, 
                fechareporte, 
                usuario, 
                fecha, 
                totalfacturas, 
                totaldeventas, 
                ivaimpuestos 
            });

            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();



            
        }
    }
}
