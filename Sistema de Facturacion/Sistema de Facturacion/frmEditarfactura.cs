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
    public partial class frmEditarfactura : Form
    {
        public frmEditarfactura()
        {
            InitializeComponent();
        }



        int total = 0;
        int impuesto = 0;
        double iva = 0;
        double subtotal = 0;
        public string producto;
        int registrosfacturas = 0;
        int x = 0;
        string[] codigo = new string[50];
        int[] cantidad = new int[50];
        bool verfactura = true;


        int total2 = 0;

        Conexion cn = new Conexion();
        Metodos metodos = new Metodos();


        
        public void Eliminar() {

            for (int x = 0; x < dgvfactura.Rows.Count; x++)
            {

                int[] codigo = new int[dgvfactura.Rows.Count];
                string[] producto = new string[dgvfactura.Rows.Count];
                int[] precio = new int[dgvfactura.Rows.Count];
                int[] cantidad = new int[dgvfactura.Rows.Count];
                int[] total = new int[dgvfactura.Rows.Count];


                codigo[x] = int.Parse(dgvfactura.Rows[x].Cells["CODIGO"].Value.ToString());
                producto[x] = dgvfactura.Rows[x].Cells["DESCRIPCION"].Value.ToString();
                precio[x] = int.Parse(dgvfactura.Rows[x].Cells["PRECIO"].Value.ToString());
                cantidad[x] = int.Parse(dgvfactura.Rows[x].Cells["CANTIDAD"].Value.ToString());
                total[x] = int.Parse(dgvfactura.Rows[x].Cells["TOTAL"].Value.ToString());

                cn.UPDATE(cantidad[x], codigo[x]);
                cn.DELETEPRODUCTS(int.Parse(lblid.Text), codigo[x]);

            }

            cn.ELIMINAR(int.Parse(lblid.Text), "Factura", "Id_Factura");
            cn.ELIMINAR(int.Parse(lblid.Text), "Detalle_Factura", "Id_Factura");
            cn.MOSTRARFACTURA(dgvfactura, lblid.Text);
            btneliminar.Enabled = false;
            btneditar.Enabled = false;
            btnimprimir.Enabled = false;
            lbltotal.Text = "0";
            lblsubtotal.Text = "0";
            lbliva.Text = "0";
            
        
        }

        
        
        
        
        
     

        private void frmEditarfactura_Load_1(object sender, EventArgs e)
        {
            cn.MOSTRARFACTURA(dgvfactura, lblid.Text);

            try
            {
                DataGridViewImageColumn dgc = new DataGridViewImageColumn();

                dgc.AutoSizeMode = dgvfactura.Columns[4].AutoSizeMode;
                dgc.HeaderText = "ELIMINAR";
                dgc.Name = "columneliminar";
                dgc.Image = Image.FromFile("C:\\icon\\elim.png");
                dgvfactura.Columns.Add(dgc);

                int total2 = int.Parse(lbltotal.Text);
                iva = total2 * double.Parse(LoadDataConfig.IVA.ToString());

                subtotal = total2 - iva;

                lbliva.Text = iva.ToString();
                lblsubtotal.Text = subtotal.ToString();
                registrosfacturas = dgvfactura.Rows.Count;
            }
            catch {

                metodos.Mensajes("Falta la carpeta icon en el disco local C", "error");
            
            }



        }

        private void dgvfactura_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvfactura.Columns[e.ColumnIndex].Name == "columneliminar")
            {


                if (dgvfactura.Rows.Count == 0) {


                    btneditar.Enabled = false;
                
                }

                try { 
                if (x <= 50)
                {
                    x++;
                    int y = x - 1;

                    codigo[y] = dgvfactura.Rows[e.RowIndex].Cells["CODIGO"].Value.ToString();
                    cantidad[y] = int.Parse(dgvfactura.Rows[e.RowIndex].Cells["CANTIDAD"].Value.ToString());


                    if (this.dgvfactura.Columns[e.ColumnIndex].Name == "columneliminar")
                    {




                        try
                        {
                            string n = dgvfactura.CurrentRow.Cells["Total"].Value.ToString();
                            total = int.Parse(lbltotal.Text) - int.Parse(n.ToString());
                            iva = total * double.Parse(LoadDataConfig.IVA.ToString());
                            subtotal = total - iva;
                            lbltotal.Text = total.ToString();
                            lbliva.Text = iva.ToString();
                            lblsubtotal.Text = subtotal.ToString();
                            lbltotal.Text = total.ToString();
                            total = 0;
                            dgvfactura.Rows.Remove(dgvfactura.CurrentRow);
                        }
                        catch
                        {



                            lbltotal.Text = "0";
                            lbliva.Text = "0";
                            lblsubtotal.Text = "0";
                            btneditar.Enabled = false;


                        }


                    }


                }

                else {


                    metodos.Mensajes("El arreglo ya no puede almacenar mas productos","error");
                
                }
                
            }

                catch
                {

                    metodos.Mensajes("El arreglo esta lleno", "error");

                }


          }


            
        }


        private void btneditar_Click(object sender, EventArgs e)
        {
            if (cn.ESTADO() == true)
            {
                if (dgvfactura.Rows.Count == 0)
                {

                    metodos.Mensajes("La factura no se puede editar, Eliminala", "error");

                }

                else
                {

                    for (int x = 0; x < codigo.Length; x++)
                    {
                        try
                        {
                            if (cantidad[x] == 0)
                            {

                                break;

                            }

                            cn.UPDATE(cantidad[x], int.Parse(codigo[x].ToString()));
                            cn.DELETEPRODUCTS(int.Parse(lblid.Text), int.Parse(codigo[x].ToString()));

                        }
                        catch
                        {


                        }

                    }
                    metodos.Mensajes("Los productos eliminados se han movido al inventario", "bien");
                }
            }
            else {

                metodos.Mensajes("No se pueden modificar facturas en este momento","error");
            
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (cn.ESTADO() == true)
            {
                Eliminar();
            }
            else {

                metodos.Mensajes("No se pueden modificar facturas en este momento","error");
            
            }

        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {


                frmFacturar facturalista = new frmFacturar();
                facturalista.Id = int.Parse(lblid.Text);
                facturalista.Cliente = lblnombre.Text;
                facturalista.Tipopago = lblpago.Text;
                facturalista.Codigofactura = lblid.Text;
                facturalista.ShowDialog();
            

            

        }

        private void lblsubtotal_TextChanged(object sender, EventArgs e)
        {
            lblsub1.Text = Convert.ToDouble (lblsubtotal.Text.ToString()).ToString("N");
        }

        private void lbltotal_TextChanged(object sender, EventArgs e)
        {

            lbltotal1.Text = Convert.ToDouble(lbltotal.Text.ToString()).ToString("N");

        }

        private void lbliva_TextChanged(object sender, EventArgs e)
        {
            lbliba1.Text = Convert.ToDouble(lbliva.Text.ToString()).ToString("N");
        }
    }
}
