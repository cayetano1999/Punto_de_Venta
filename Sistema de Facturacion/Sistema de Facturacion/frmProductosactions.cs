using Sistema_de_Facturacion.clases;
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
    public partial class frmProductosactions : Form
    {
        public frmProductosactions()
        {
            InitializeComponent();
        }

        Conexion cn = new Conexion();

        Metodos metodos = new Metodos();


        public void Validarprecio() {

            if (txtprecio.Text.Length == 0)
            {

            }

            else
            {
                try
                {

                    if (txtprecio.Text.Length > 0)
                    {
                        int x = int.Parse(txtprecio.Text);
                    }

                }
                catch
                {

                    metodos.Mensajes("Valor no valido", "error");
                    txtprecio.BackColor = Color.IndianRed;
                    txtprecio.ForeColor = Color.White;
                    txtprecio.Text = "1";
                }
            }
        
        }


        public void validarexistencia() {
            if (txtexistencia.Text.Length == 0)
            {

            }

            else
            {
                try
                {

                    if (txtexistencia.Text.Length > 0)
                    {
                        int x = int.Parse(txtexistencia.Text);
                    }



                }
                catch
                {

                    metodos.Mensajes("Valor no valido", "error");
                    txtexistencia.BackColor = Color.IndianRed;
                    txtexistencia.ForeColor = Color.White;
                    txtexistencia.Text = "1";
                }
            }
        
        }


        private void btneditar_Click(object sender, EventArgs e)
        {
            try
            {
                Producto pr = new Producto();
                pr.Descripcion = txtdescripcion.Text;
                pr.Existencias = int.Parse(txtexistencia.Text);
                pr.PIVA = double.Parse(txtpiva.Text.ToString());
                pr.Precio = double.Parse(txtprecio.Text);
                pr.Codigo_Producto = int.Parse(lblid.Text);
                pr.Id_Proveedor = cn.CARGARID(comboproveedor.Text);
                cn.EDITAR_PRODUCTOS(pr);
                this.Close();
            }
            catch {

                metodos.Mensajes("La cantidad o el Precio tienen valores no validos", "error");
            
            
            }
           
           
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            
            cn.ELIMINAR(int.Parse(lblid.Text), "Productos", "Codigo_Producto");
            this.Close();
        }

        private void frmProductosactions_Load(object sender, EventArgs e)
        {
            comboproveedor.SelectedItem = comboproveedor.Text;
            cn.llenarproveedor(comboproveedor);
        }

        private void txtprecio_TextChanged(object sender, EventArgs e)
        {
            Validarprecio();
        }

        private void txtexistencia_TextChanged(object sender, EventArgs e)
        {


            validarexistencia();
            

       }

        
    }
}
