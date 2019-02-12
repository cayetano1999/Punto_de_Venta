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
    public partial class frmMensajes : Form
    {
        public frmMensajes()
        {
            InitializeComponent();
        }

        Conexion cn = new Conexion();

        public string accion;
        public int id;

        private void frmMensajes_Load(object sender, EventArgs e)
        {
            txtmensaje.Enabled = false;
            if (accion == "eliminar usuario") {
                button1.Visible = false;
                btnaceptar.Visible = true;
                btnno.Visible = true;
                btnno.Focus();
            
            }

            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnno_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {

            if (accion == "eliminar usuario") {

                

                cn.ELIMINAR(id, "Usuario", "Id_Usuario");
                this.Close();
            
            }

            else  if (accion == "salir") {

                
                
            
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
