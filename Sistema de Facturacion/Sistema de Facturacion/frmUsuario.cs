using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_de_Facturacion.clases;

namespace Sistema_de_Facturacion
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        Conexion cn = new Conexion();
        Metodos metodos = new Metodos();


        public string accion;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }








        public bool valudarusuario()
        {
            bool retornar = false;

            string[] correo;
            string[] usuario;

            txtusuario.Text = txtusuario.Text.Trim();
            txtnombre.Text = txtnombre.Text.ToUpper();


            correo = txtemail.Text.Split('@');
            usuario = txtusuario.Text.Split(' ');

            if (txtcontrasena.Text != txtrepetircontrasena.Text)
            {

                metodos.Mensajes("Las contraseñas deben ser iguales", "error");

            }

            else if (usuario.Length > 1)
            {

                metodos.Mensajes("El campo usuario no puede incluir espacio", "error");

            }
            else if (correo.Length<=1) {


                metodos.Mensajes("La dirección de correo no es valida", "error");
            
            }


            else
            {


                if (txtnombre.Text.Length > 2 && correo.Length > 1 && txtcontrasena.Text.Length >= 6 && txtusuario.Text.Length > 5)
                {


                    retornar = true;

                }

                else
                {

                    retornar = false;

                }



            }



            return retornar;
        }



        private void frmUsuario_Load(object sender, EventArgs e)
        {
            if (lblnuevousuario.Text != "ACCIONDES DE USUARIO") {
                combotipousuario.SelectedIndex = 0;

            }
            


        }



        private void btnagregaruser_Click(object sender, EventArgs e)
        {
            if (valudarusuario() == true)
            {

                Usuarios users = new Usuarios();

                users.Email = txtemail.Text.ToString();
                users.Nombre_Completo = txtnombre.Text;
                users.Contrasena = Metodos.CreateMD5( txtcontrasena.Text.ToString());
                users.Usuario = txtusuario.Text.ToString();
                users.Tipo_Usuario = combotipousuario.Text;
                users.Fecha = DateTime.Now;
                cn.GUARDAR_USUARIO(users);

                this.Close();


            }





        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (valudarusuario() == true)
            {
                if (combotipousuario.Text != "Seleccione el tipo de usuario...")
                {

                    Usuarios users = new Usuarios();
                    users.Tipo_Usuario = combotipousuario.Text;
                    users.Id_Usuario = int.Parse(lblid.Text);
                    users.Email = txtemail.Text.ToString();
                    users.Nombre_Completo = txtnombre.Text.ToUpper();
                    users.Contrasena = Metodos.CreateMD5(txtcontrasena.Text.ToString());
                    users.Usuario = txtusuario.Text.ToString();

                    LoadData.Nombre = users.Nombre_Completo;
                    LoadData.Email = users.Email;
                    LoadData.Usuario = users.Usuario;
                    cn.EDITAR_USUARIO(users);
                    this.Close();
                }
                else {

                    metodos.Mensajes("Debes asignar un rol al usuario", "alerta");
                    combotipousuario.BackColor = Color.IndianRed;
                
                }


            }

            else {

                metodos.Mensajes("No se pudo editar el usuario", "error");
            
            }






        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            metodos.id = int.Parse(lblid.Text);
            metodos.Mensajes("Seguro que desea eliminar a "+txtnombre.Text+"?", "eliminar usuario");
            this.Close();
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {
            if (btnagregaruser.Visible==true) { 
            if(cn.SQLVALIDATE("Usuario", "Email", txtemail.Text)==true){


                txtemail.Text = "";
            
            
            }
            }
        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

            if (btnagregaruser.Visible==true)
            {
                if (cn.SQLVALIDATE("Usuario", "Usuario", txtusuario.Text) == true)
                {

                    txtusuario.Text = "";



                }
            }
        }

    }
       
    
}
