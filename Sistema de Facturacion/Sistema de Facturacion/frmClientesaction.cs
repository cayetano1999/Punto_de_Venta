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
    public partial class frmClientesaction : Form
    {
        public frmClientesaction()
        {
            InitializeComponent();
        }

        Conexion cn = new Conexion();

        private void btneditar_Click(object sender, EventArgs e)
        {

            Clientes cl = new Clientes();
            cl.Nombre = txtnombrecliente2.Text;
            cl.Identificacion = txtidentificacion2.Text;
            cl.Email = txtemail2.Text;
            cl.Tipo_Cliente = combotipocliente2.Text;
            cl.Direccion = txtdireccion2.Text;
            cl.Id_Cliente = int.Parse(lblid.Text);
            cn.EDITAR_CLIENTE(cl);
            this.Close();
            
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            cn.ELIMINAR(int.Parse(lblid.Text), "Cliente", "Id_Cliente");
            this.Close();
        }
    }
}
