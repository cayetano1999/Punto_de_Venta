using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Sistema_de_Facturacion.clases;

namespace Sistema_de_Facturacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        Metodos metodos = new Metodos();
        //private frmLogin login = null;

        int x = Screen.PrimaryScreen.Bounds.Height;
        int y = Screen.PrimaryScreen.Bounds.Width;



        private void Form1_Load(object sender, EventArgs e)
        {
            string idioma = Thread.CurrentThread.CurrentCulture.NativeName.ToString();

            if (idioma != "español (República Dominicana)")
            {

                metodos.Mensajes("El Sistema Operativo no esta configurado en Español (RD)", "alerta");
                metodos.Mensajes("El sistema iniciará de todos modos", "alerta");

            }

            else if (y < 1366 || x < 768)
            {


                metodos.Mensajes("La resolición requerida es de 1366px * 768px", "error");

            }


            

                timer1.Start();
            



        }
        int tiempo = 0;
        int prueba = 0;


        //Clicks










        //Metodos Locales

       

        private void animacionimagen()
        {


            if (label1.Text == "3")
            {
                //pictureBox1.Visible = false;
                //this.login = new frmLogin();
                //this.login.TopLevel = false;
                //this.login.Dock = DockStyle.None;
                //this.login.Visible = true;
                //this.Controls.Add(this.login);

                frmLogin login = new frmLogin();
                this.Visible = false;
                login.ShowDialog();

                

            }

           
        }






        //Animaciones

        //Logo
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            tiempo++;
            if (tiempo > 0 && tiempo <=5)
            {
                label1.Text = tiempo.ToString();
                animacionimagen();
            }
        }

        private void timerlogin_Tick(object sender, EventArgs e)
        {
            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
           

            
        }

        

      






    }
}
