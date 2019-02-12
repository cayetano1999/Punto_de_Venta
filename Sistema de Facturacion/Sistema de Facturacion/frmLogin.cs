using Sistema_de_Facturacion.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Facturacion
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        Conexion cn = new Conexion();
        Metodos metodos = new Metodos();


        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnacceder_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            //frmImagen img = new frmImagen();
            //img.ShowDialog();
        }

        private void btnacceder_Click_1(object sender, EventArgs e)
        {
            

            Usuarios users = new Usuarios();

            users.Usuario = txtusuario.Text.ToString();
            users.Contrasena = Metodos.CreateMD5( txtcontrasena.Text.ToString());
            if (cn.ESTADO() == true)
            {
                if (cn.VERIFICAR_USUARIO(users) == true)
                {
                    cn.CARGARCONFIG();

                    frmNuevafactura nuevafactura = new frmNuevafactura();
                    this.Visible = false;
                    nuevafactura.Show();


                }
                else
                {

                    metodos.Mensajes("Usuario o Contraseña incorrecto", "error");


                }
            }
            else {

                metodos.Mensajes("El sistema esta cerrado", "error");
            
            }


            
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_DoubleClick(object sender, EventArgs e)
        {
            cn.UPDATEESTADO();
        }
    }
}
