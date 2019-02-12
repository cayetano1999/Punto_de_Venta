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
    public partial class frmAgregarproveedor : Form
    {
        public frmAgregarproveedor()
        {
            InitializeComponent();
        }

        Conexion cn = new Conexion();

        private void btnagregaruser_Click(object sender, EventArgs e)
        {

            Proveedores pv = new Proveedores();
            pv.Empresa = txtempresa.Text;
            pv.Email = txtemail.Text;
            pv.Representante = txtrepresentante.Text;
            pv.Telefono = txttelefono.Text;
            pv.Direccion = txtdireccion.Text;
            pv.Tipo_Proveedor = combotipocliente2.Text;
            pv.Id_Proveedor = int.Parse(lblid.Text);

            cn.REGISTRAR_PROVEEDOR(pv);
            this.Close();


        }

        private void frmAgregarproveedor_Load(object sender, EventArgs e)
        {
          
        }

        private void btneditar_Click(object sender, EventArgs e)
        {

            Proveedores pv = new Proveedores();
            pv.Empresa = txtempresa.Text;
            pv.Email = txtemail.Text;
            pv.Representante = txtrepresentante.Text;
            pv.Telefono = txttelefono.Text;
            pv.Direccion = txtdireccion.Text;
            pv.Tipo_Proveedor = combotipocliente2.Text;
            pv.Id_Proveedor = int.Parse(lblid.Text);

            cn.EDITAR_PROVEEDO(pv);
            this.Close();


        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
         
            cn.ELIMINAR(int.Parse(lblid.Text), "Proveedor", "Id_Proveedor");
            this.Close();
        }
    }
}
