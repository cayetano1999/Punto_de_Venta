using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Facturacion.clases
{
   public class Metodos
    {

        public Metodos()
        {

        }


        public int id;

        public void Mensajes(string mensaje, string tipo)
        {

            frmMensajes mensajero = new frmMensajes();
            mensajero.txtmensaje.Text = mensaje.ToString();

            if (tipo == "error")
            {

                mensajero.pictuerebad.Visible = true;

            }

            else if (tipo == "pregunta")
            {

                mensajero.picturepregunta.Visible = true;

            }

            else if (tipo == "bien")
            {

                mensajero.pictureok.Visible = true;

            }
            else if (tipo == "eliminar usuario") {

                frmUsuario user = new frmUsuario();
                mensajero.btnaceptar.Visible = false;
                mensajero.picturepregunta.Visible = true;
                mensajero.lblmensaje.Text = "Eliminar Usuario";
                mensajero.accion = "eliminar usuario";
                mensajero.id = id;
                
                
            
            }

            else if (tipo == "alerta") {

                mensajero.picturealerta.Visible = true;
            
            
            
            }

            else if (tipo == "salir") {

                mensajero.picturepregunta.Visible = true;
            
            }
            mensajero.ShowDialog();



        }


        public string convertiriva() {

            string retornar;

            //string[] impuesto = LoadDataConfig.IVA.ToString().Split('.');

             //retornar= impuesto[0] + "," + impuesto[1];

            return LoadDataConfig.IVA.ToString();
        
        
        
        }

        public static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

       


       
    }
}
