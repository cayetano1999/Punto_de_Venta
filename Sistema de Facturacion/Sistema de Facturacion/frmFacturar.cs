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
    public partial class frmFacturar : Form
    {
        public frmFacturar()
        {
            InitializeComponent();
        }

        public int Id;
        public string Empresa;
        public string Direccion;
        public string Telefono;
        public string Vendedor;
        public string Fecha;
        public string Codigofactura;
        public string Pie;
        public double Iva;
        public double sub;
        public string Cliente;
        public string Tipopago;
        Conexion cn = new Conexion();

        private void frmFacturar_Load(object sender, EventArgs e)
        {




            Iva = cn.MOSTRAR2(Id) * 0.18;
            sub = cn.MOSTRAR2(Id) - Iva;

            decimal prueba = decimal.Parse(cn.MOSTRAR2(Id).ToString());

          

            // TODO: esta línea de código carga datos en la tabla 'DataSetFactura.Detalle_Factura' Puede moverla o quitarla según sea necesario.
            this.Detalle_FacturaTableAdapter.Fill(this.DataSetFactura.Detalle_Factura, Id);

            ReportParameter empresa = new ReportParameter("empresa", LoadDataConfig.Nombre_Empresa);

            ReportParameter direccion = new ReportParameter("direccion", LoadDataConfig.Direccion_Empresa);

            ReportParameter telefono = new ReportParameter("telefono", LoadDataConfig.Telefono);

            ReportParameter vendedor = new ReportParameter("vendedor", LoadData.Nombre);

            ReportParameter codigo = new ReportParameter("codigo", Codigofactura);

            ReportParameter pie = new ReportParameter("piepagina", LoadDataConfig.Pie_Pagina);

            ReportParameter fecha = new ReportParameter("fecha", DateTime.Now.ToString());

            ReportParameter total = new ReportParameter("total", cn.MOSTRAR2(Id).ToString("N"));

            ReportParameter piva = new ReportParameter("piva", Iva.ToString("N"));

            ReportParameter subtotal = new ReportParameter("subtotal", sub.ToString("N"));

            ReportParameter cliente = new ReportParameter("cliente", Cliente);

            ReportParameter tipopago = new ReportParameter("tipopago", Tipopago);

            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { empresa, direccion, telefono, vendedor, codigo, pie, fecha, total, piva, subtotal, cliente, tipopago });
            this.reportViewer1.LocalReport.Refresh();

            this.reportViewer1.RefreshReport();
            //this.reportViewer1.SetDisplayMode (DisplayMode.PrintLayout) ;
            //this.reportViewer1.SetDisplayMode(DisplayMode.Normal);

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.reportViewer1.SetDisplayMode (DisplayMode.PrintLayout) ;
            this.reportViewer1.SetDisplayMode(DisplayMode.Normal);
        }
    }
}
