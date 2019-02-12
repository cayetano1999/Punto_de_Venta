using Sistema_de_Facturacion.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;


namespace Sistema_de_Facturacion
{
    public partial class frmNuevafactura : Form
    {
        public frmNuevafactura()
        {
            InitializeComponent();
            cn.llenarcombo(combocliente);
        }
        
        public int Codigo = 0;

        int total = 0;
        decimal impuesto = 0;
        double iva = 0;
        double subtotal = 0;
        public int existencia;
        public int cantidad;
        public string producto;
        public string accion;
        public bool error;
       


        Metodos metodos = new Metodos();
        frmMenu menu = new frmMenu();
        Conexion cn = new Conexion();

        private void btnproductos_Click(object sender, EventArgs e)
        {
           
        }

        private void btnproductos_Click_1(object sender, EventArgs e)
        {
            
        }


        public void alerta() {

            
            if (dgvfactura.Rows.Count > 0)
            {


                metodos.Mensajes("Hay una factura en proceso", "alerta");
               

            }

        
        }


        public bool verificarcombos() {

            bool retornar = false;

            if (combocliente.Text == "Seleccione el cliente..." && combopago.Text == "Seleccione...")
            {


                metodos.Mensajes("No has seleccionado del cliente ni el tipo de pago", "alerta");
                combocliente.BackColor = Color.Red;
                combopago.BackColor = Color.Red;
                retornar = false;

            }

            else if (combopago.Text == "Seleccione...")
            {

                metodos.Mensajes("No has seleccionado el tipo de pago", "alerta");
                combopago.BackColor = Color.Red;
                retornar = false;

            }

            else if (combocliente.Text == "Seleccione el cliente...")
            {

                metodos.Mensajes("No has seleccionado el cliente", "alerta");
                combocliente.BackColor = Color.Red;
                retornar = false;

            }

            else {

                retornar = true;

            }

            return retornar;
        
        }





        private void frmNuevafactura_Load(object sender, EventArgs e)
        {

            lblusuario.Text = "->[" + LoadData.Nombre + " ( " + LoadData.Tipo_Usuario + " )" + "]";
            combovendedor.Items.Add ( LoadData.Nombre);
            combovendedor.SelectedIndex = 0;
            combocliente.SelectedIndex = 0;
            combopago.SelectedIndex = 0;
        }

        private void btnproductos_Click_2(object sender, EventArgs e)
        {
            if (dgvfactura.Rows.Count > 0)
            {

                metodos.Mensajes("Hay una facura en proceso", "alerta");


            }

            else{
            menu.productotab();
            this.Hide();
            menu.Show();
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvproductos.Rows.Count == 0)
                {

                    metodos.Mensajes("El producto [" + comboproducto.Text + "] no existe", "error");

                }

                else
                {

                    if (verificarcombos() == true)
                    {



                        for (int d = 0; d < dgvfactura.Rows.Count; d++)
                        {

                            if (comboproducto.Text == dgvfactura.Rows[d].Cells["DESCRIPCION"].Value.ToString())
                            {

                                metodos.Mensajes("Este producto ya está en pre-factura", "error");
                                dgvfactura.Rows.RemoveAt(d);

                            }


                        }



                        if (Codigo == 0)
                        {

                            metodos.Mensajes("Debes seleccionar el producto desde el DataGrid", "error");


                        }

                        else if (txtcantidad.Text.Length == 0)
                        {

                            metodos.Mensajes("La cantidad debe ser mayor a 0", "error");
                            txtcantidad.Text = "1";

                        }


                        else if (existencia < int.Parse(txtcantidad.Text))
                        {

                            metodos.Mensajes("La cantidad solicitada es mayor que la disponible", "error");
                            comboproducto.Text = "1";

                        }

                        else
                        {

                            
                                int g = dgvfactura.Rows.Add();
                                int valor = dgvfactura.Rows.Count;
                                dgvfactura.Rows[valor - 1].Cells[0].Value = Codigo;
                                dgvfactura.Rows[valor - 1].Cells[1].Value = comboproducto.Text;
                                dgvfactura.Rows[valor - 1].Cells[2].Value = txtcantidad.Text; ;
                                dgvfactura.Rows[valor - 1].Cells[3].Value = txtprecio.Text;
                                dgvfactura.Rows[valor - 1].Cells[4].Value = int.Parse(dgvfactura.Rows[valor - 1].Cells[2].Value.ToString()) * int.Parse(dgvfactura.Rows[valor - 1].Cells[3].Value.ToString());
                                try
                                {
                                    dgvfactura.Rows[valor - 1].Cells[5].Value = Image.FromFile("C:\\icon\\elim.png");
                                    //esta es la imagen de eliminar que aparece en la factura, no te va funcionar porque fue agregada desde mi pc. 
                                }
                                catch { 
                                
                                metodos.Mensajes("Falta la carpeta icon en el disco local C", "error");
                           
                                }
                                for (int c = 0; c < valor; c++)
                                {


                                    DataGridViewRow fila = dgvfactura.Rows[c];
                                    total = total + int.Parse(fila.Cells["columtotal"].Value.ToString());


                                }

                                iva = total * double.Parse(LoadDataConfig.IVA.ToString());
                                subtotal = total - iva;
                                lbltotal.Text = total.ToString();
                                lbliva.Text = iva.ToString();
                                lblsubtotal.Text = subtotal.ToString();
                                total = 0;
                                Codigo = 0;

                                comboproducto.Text = "";
                                txtcantidad.Text = "1";
                                txtprecio.Text = "";
                            


                        }


                    }

                }
                comboproducto.Focus();
            }

            catch {


                metodos.Mensajes("Error al registrar la factura","error");
            
            
            }
           
        }



        private void dgvfactura_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (this.dgvfactura.Columns[e.ColumnIndex].Name == "columneliminar")
                {
                    if (this.dgvfactura.Columns[e.ColumnIndex].Name == "columneliminar")
                    {




                        try
                        {
                            string n = dgvfactura.CurrentRow.Cells["columtotal"].Value.ToString();
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


                        }







                    }


                }
            }
            catch { 
            
            
            
            
            }
        


        }



         private void dgvproductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                DataGridViewRow fila = dgvproductos.Rows[e.RowIndex];

                existencia = int.Parse(fila.Cells["Existencia"].Value.ToString());
                string x = fila.Cells["Precio"].Value.ToString();

                if (existencia <= 0)
                {

                    metodos.Mensajes("Este producto está agotado", "error");
                    txtprecio.Text = "1";
                    comboproducto.Text = "";
                    error = true;

                }

                else if (existencia <= 5)
                {


                    metodos.Mensajes("Este producto se está agotando!", "alerta");
                    error = false;
                }
                else
                {

                    error = false;

                }


                try
                {
                    if (error == false)
                    {
                        Codigo = int.Parse(fila.Cells["Codigo_Producto"].Value.ToString());
                        comboproducto.Text = dgvproductos.Rows[e.RowIndex].Cells[1].Value.ToString();


                        txtprecio.Enabled = false;
                        txtprecio.Text = x;
                        txtcantidad.Focus();
                    }

                }
                catch
                {
                }
            }
            catch { 
            
            
            
            }
        }



        private void btnadministrar_Click(object sender, EventArgs e)
        {

            if (dgvfactura.Rows.Count > 0)
            {

                metodos.Mensajes("Hay una facura en proceso", "alerta");


            }

            else{

            menu.adminfactura();
            this.Hide();
            menu.Show();
            }
        }



        private void btnreportes_Click(object sender, EventArgs e)
        {
            if (dgvfactura.Rows.Count > 0)
            {

                metodos.Mensajes("Hay una facura en proceso", "alerta");


            }

            else{
            
            menu.reportefacturatab();
            this.Hide();
            menu.Show();
            }
        }

        private void btnclientes_Click(object sender, EventArgs e)
        {
            if (dgvfactura.Rows.Count > 0)
            {

                metodos.Mensajes("Hay una facura en proceso", "alerta");


            }

            else{
            menu.clientetab();
            this.Hide();
            menu.Show();
            }
        }

        private void btnusuarios_Click(object sender, EventArgs e)
        {
            if (LoadData.Tipo_Usuario == "Administrador")
            {


                if (dgvfactura.Rows.Count > 0)
                {

                    metodos.Mensajes("Hay una facura en proceso", "alerta");


                }

                else
                {
                    menu.usuariostab();
                    this.Hide();
                    menu.Show();

                }
            }
            else {

                metodos.Mensajes("No tienes acceso a este modulo", "error");
            
            }
        }


        private void btnconfig_Click(object sender, EventArgs e)
        {
            if (LoadData.Tipo_Usuario == "Administrador")
            {

                if (dgvfactura.Rows.Count > 0)
                {

                    metodos.Mensajes("Hay una facura en proceso", "alerta");


                }


                else
                {
                    menu.configuraciontab();
                    this.Hide();
                    menu.Show();
                }
            }
            else {


                metodos.Mensajes("No tienes acceso a este modulo", "error");
            
            }
        }

        private void comboproducto_TextChanged(object sender, EventArgs e)
        {
            cn.BUSQUEDA_SELECTIVA(dgvproductos, comboproducto.Text, 10);
        }




    
        private void dgvproductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = System.Windows.Forms.Cursors.WaitCursor;

                try
                {


                    if (LoadDataConfig.Estado=="Abierto")
                    {

                        if (verificarcombos() == true)
                        {


                            string[] CLIENTEID = combocliente.Text.Split('-');



                            if (dgvfactura.Rows.Count > 0)
                            {
                                lblimprimiendo.Visible = true;

                                for (int x = 0; x < dgvfactura.Rows.Count; x++)
                                {

                                    int[] codigo = new int[dgvfactura.Rows.Count];
                                    string[] producto = new string[dgvfactura.Rows.Count];
                                    int[] precio = new int[dgvfactura.Rows.Count];
                                    int[] cantidad = new int[dgvfactura.Rows.Count];
                                    int[] total = new int[dgvfactura.Rows.Count];


                                    codigo[x] = int.Parse(dgvfactura.Rows[x].Cells["COLUMCODIGO"].Value.ToString());
                                    producto[x] = dgvfactura.Rows[x].Cells["DESCRIPCION"].Value.ToString();
                                    precio[x] = int.Parse(dgvfactura.Rows[x].Cells["PRECIO"].Value.ToString());
                                    cantidad[x] = int.Parse(dgvfactura.Rows[x].Cells["CANTIDAD"].Value.ToString());
                                    total[x] = int.Parse(dgvfactura.Rows[x].Cells["columtotal"].Value.ToString());

                                    int totalfactura = int.Parse(lbltotal.Text);
                                    double impuesto = double.Parse(lbliva.Text);
                                    decimal subtotal = decimal.Parse(lblsubtotal.Text);

                                    if (x == 0)
                                    {
                                        Facturas factura = new Facturas();
                                        factura.FECHA = DateTime.Now;
                                        factura.FK_IdCliente = int.Parse(CLIENTEID[0]);
                                        factura.FK_IdUsuario = LoadData.ID;
                                        factura.Tipo_Pago = combopago.Text;
                                        cn.GUARDARFACTURA(factura);
                                    }

                                    DetalleFactura detalles = new DetalleFactura();
                                    detalles.Id_Factura = cn.ULTIMOREGISTRO();
                                    detalles.Codigo_Producto = codigo[x];
                                    detalles.Nombre_Producto = producto[x].ToString();
                                    detalles.Precio = precio[x];
                                    detalles.Cantidad = cantidad[x];
                                    detalles.Total = total[x];
                                    cn.GUARDARDETALLES(detalles);
                                    cn.DESCONTAR(cantidad[x], codigo[x]);


                                }

                                try
                                {
                                    frmFacturar facturalista = new frmFacturar();
                                    facturalista.Id = cn.ULTIMOREGISTRO();
                                    facturalista.Cliente = CLIENTEID[1].ToString();
                                    facturalista.Tipopago = combopago.Text;
                                    facturalista.Codigofactura = cn.ULTIMOREGISTRO().ToString();
                                    facturalista.ShowDialog();
                                }
                                catch
                                {


                                    metodos.Mensajes("Este ordenador no puede imprimir facturas", "error");


                                }



                                limpiar();

                            }

                            else
                            {

                                metodos.Mensajes("No se ha realizado la pre-facturación", "error");

                            }

                            lblimprimiendo.Visible = false;
                            Cursor = System.Windows.Forms.Cursors.Default;
                        }
                    }
                    else
                    {

                        metodos.Mensajes("El estado del sistema es [CERRADO] No se puede facturar", "error");
                        Cursor = System.Windows.Forms.Cursors.Default;
                    }
                }

                catch
                {

                }
                Cursor = System.Windows.Forms.Cursors.Default;
            }
            catch {

                metodos.Mensajes("No se pudo realizar la factura","error");
            
            }


        }





        private void combocliente_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void combocliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combocliente.Text != "Seleccione el cliente...")
            {


                
                combocliente.BackColor = Color.White;

            }

           

        }



        public void limpiar() {

            comboproducto.Text = "";
            txtcantidad.Text ="1";
            txtprecio.Text = "";
            lbliva.Text = "0";
            lblsubtotal.Text = "0";
            lbltotal.Text = "0";
            combocliente.SelectedIndex = 0;
            combopago.SelectedIndex = 0;
            dgvfactura.Rows.Clear();

        
        
        }

       

        private void txtcantidad_TextChanged(object sender, EventArgs e)
        {
            try
            {
                try
                {
                     cantidad = int.Parse(txtcantidad.Text);
                }
                catch { 
                

                
                }
                if (cantidad > existencia) {


                    metodos.Mensajes("La cantidad solicitada es mayor que la cantidad disponible", "alerta");
                    txtcantidad.Text = "1";
                
                
                }


                if(txtcantidad.Text.Length==0){
                

                
                }
                else if (txtcantidad.Text.Length > 0) { 


                int x = int.Parse(txtcantidad.Text);
                if (x <= 0)
                {

                    metodos.Mensajes("La cantidad de producto debe ser mayor a 0", "error");
                    txtcantidad.Text = "1";

                }
                }
            }

            catch {

                metodos.Mensajes("Solo se puede agregar numeros", "error");
                txtcantidad.Text = "1";
            
            }
        }

        private void combopago_SelectedIndexChanged(object sender, EventArgs e)
        {
             if (combopago.Text != "Seleccione...")
            {

                
                combopago.BackColor = Color.White;

            }
        }

        private void lblsubtotal_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lblsub.Text = Convert.ToDouble(lblsubtotal.Text).ToString("N");
            }
            catch { 
            
                
            
            }

        }

        private void lbliva_TextChanged(object sender, EventArgs e)
        {
            try
            {
                iva1.Text = Convert.ToDouble(lbliva.Text).ToString("N");
            }
            catch { 
            
            }
        }

        private void lbltotal_TextChanged(object sender, EventArgs e)

        {
            try
            {
                total1.Text = Convert.ToDouble(lbltotal.Text).ToString("N");
            }
            catch { 
            
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {

            if (dgvfactura.Rows.Count > 0)
            {

                metodos.Mensajes("Hay una facura en proceso", "alerta");


            }

            else { 
            frmLogin login = new frmLogin();
            this.Close();
            login.Show();
            }

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {

            if (dgvfactura.Rows.Count > 0)
            {


                metodos.Mensajes("Hay una factura en proceso", "alerta");


            }
            else
            {
                frmMenu menu = new frmMenu();
                menu.tabmenu.SelectedIndex = 7;
                menu.lblcabeza.Text = "DASHBOARD";
                menu.timerdash.Start();
                this.Close();
                menu.Show();
            }
        }

        private void dgvproductos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

       
       
        
    }
}
