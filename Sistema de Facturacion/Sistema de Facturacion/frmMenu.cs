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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }
        Conexion cn = new Conexion();
        Metodos metodos = new Metodos();
        int num=0;
        public int indextab;
        bool configuracion;
        bool productos;
        

        public void productotab() {

            comboproveedor.Items.Clear();
            tabmenu.SelectedIndex = 0;
            lblcabeza.Text = "PRODUCTOS";
            cn.MOSTRAR(dgvproductos, "ProductosJoin","Codigo_Producto", 15);
            txtiva.Text = metodos.convertiriva();
            txtiva.Enabled = false;
            cn.llenarproveedor(comboproveedor);


            for (int r = 0; r < dgvproductos.Rows.Count; r++)
            {

                if (dgvproductos.Rows[r].Cells["Existencia"].Value.ToString() == "0")
                {

                    //MessageBox.Show(dgvproductos.Rows[r].Cells[3].Value.ToString());

                    dgvproductos.Rows[r].DefaultCellStyle.BackColor = Color.IndianRed;
                    dgvproductos.Rows[r].DefaultCellStyle.ForeColor = Color.White;

                }

            }

   
        }

        public void usuariostab() {

            tabmenu.SelectedIndex = 2;
            lblcabeza.Text = "USUARIOS";
            cn.SQL(dgvusuarios, "select *from USUARIOSMOSTRAR");

           
        }

        public void nuevafactura() {

            frmNuevafactura nuevafactura = new frmNuevafactura();
            this.Close();
            nuevafactura.Show();
        }

        public void adminfactura() {


            tabmenu.SelectedIndex = 3;
            lblcabeza.Text = "ADMINISTRAR FACTURAS";
            cn.MOSTRAR(dgvAdministrar, "AdministrarFactura", "Id_Factura", 15);
        }

        public void reportefacturatab() {


            tabmenu.SelectedIndex = 5;
            lblcabeza.Text = "REPORTES";
        
        }

        public void configuraciontab() {

            tabmenu.SelectedIndex = 4;
            lblcabeza.Text = "CONFIGURACION";
            cn.CARGARCONFIG();
            decimal c = LoadDataConfig.IVA;
            txtnombreempresa.Text = LoadDataConfig.Nombre_Empresa;
            txtdireccion.Text = LoadDataConfig.Direccion_Empresa;
            txtcorreoconf.Text = LoadDataConfig.Email;
            txtnci.Text = LoadDataConfig.NCI;
            txttelefono.Text = LoadDataConfig.Telefono;
            txtpiedepagina.Text = LoadDataConfig.Pie_Pagina;
            txtimpuestosiva.Text = c.ToString();
            comboestado.Text = LoadDataConfig.Estado;

        
        }

        public void proveedorestab() {

            tabmenu.SelectedIndex = 6;
            lblcabeza.Text = "PROVEEDORES";
           
            cn.MOSTRAR(dgvproveedores, "Proveedor", "Id_Proveedor", 15);
            comboproveedor.SelectedIndex = 0;
        }


        private void btnproductos_Click(object sender, EventArgs e)
        {

            productotab();

            

        } 
        
        
        public void clientetab() {


            tabmenu.SelectedIndex = 1;
            lblcabeza.Text = "CLIENTES";
            cn.MOSTRAR(dgvclientes, "Cliente", "Id_Cliente", 10);
        
        
        }

        private void btnclientes_Click(object sender, EventArgs e)
        {
            clientetab();

            
        }

        

        private void btnnuevafactura_Click(object sender, EventArgs e)
        {

            nuevafactura();
        }


        private void btnusuarios_Click(object sender, EventArgs e)
        {
            if (LoadData.Tipo_Usuario == "Administrador")
            {
                usuariostab();
            }
            else {

                metodos.Mensajes("No tienes acceso a este modulo", "error");

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            reportefacturatab();


        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            adminfactura();
        }

        private void btnconfiguracion_Click(object sender, EventArgs e)
        {

            if (LoadData.Tipo_Usuario == "Administrador")
            {
                  configuraciontab();
            }

            else
            {

                metodos.Mensajes("No tienes acceso a este modulo", "error");

            }
          
            


        }




        private void btnguardarproducto_Click(object sender, EventArgs e)
        {

            if (productos == true)
            {

                int x; int y;

                try
                {

                    x = int.Parse(txtprecio.Text);
                    y = int.Parse(txtexistencia.Text);


                    if (x > 0 && y > 0)
                    {
                        if (labelvalidar.Visible == false && lblvalidarprecio.Visible == false && lblvalidarexistencia.Visible == false)
                        {
                            Producto pr = new Producto();
                            pr.Descripcion = txtdescripcion.Text;
                            pr.Existencias = int.Parse(txtexistencia.Text);
                            pr.PIVA = double.Parse(txtiva.Text.ToString());
                            pr.Precio = double.Parse(txtprecio.Text.ToString());
                            pr.Fecha = DateTime.Now;
                            pr.Id_Proveedor = cn.CARGARID(comboproveedor.Text);
                            cn.AGREGAR_PRODUCTOS(pr);
                            cn.MOSTRAR(dgvproductos, "ProductosJoin", "Codigo_Producto", 15);
                            limpiar();
                        }
                        else
                        {

                            metodos.Mensajes("No se puede agregar el producto", "alerta");

                        }
                    }
                    else
                    {


                        metodos.Mensajes("La cantidad y existencia deben ser mayor a 0", "error");

                    }


                }
                catch
                {


                    metodos.Mensajes("Verifica los digitos en [Precio] y [Cantidad]", "error");

                }
            }
            else { 
            
            metodos.Mensajes("Hay datos no validos", "error");
            
            
            }
            




        }





        private void btnguardarcliente_Click(object sender, EventArgs e)
        {
            if (lblvalidarnombre.Visible == false && lblvalidaridentificacion.Visible == false && lblvalidaremail.Visible == false)
            {
                Clientes cl = new Clientes();
                cl.Nombre = txtnombre.Text;
                cl.Identificacion = txtidentificacion.Text;
                cl.Email = txtemailcliente1.Text;
                cl.Direccion = txtdireccioncliente.Text;
                cl.Tipo_Cliente = combotipocliente.Text;
                cn.GUARDAR_CLIENTE(cl);
                cn.MOSTRAR(dgvclientes, "Cliente", "Id_Cliente", 12);
                //comboproveedor.SelectedIndex = 0;
                txtnombre.Text = "";
                txtidentificacion.Text = "";
                txtemailcliente1.Text = "";
                txtdireccion.Text = "";
            }
            else {

                metodos.Mensajes("Hay datos no validos","alerta");
            
            
            }
            

        }

        private void btnactualizarconfig_Click(object sender, EventArgs e)
        {
            //string[] impuesto = txtimpuestosiva.Text.Split('.');

           //string impuestoneto = impuesto[0] +","+ impuesto[1];

           //decimal x = decimal.Parse(impuestoneto);

           //decimal y = x * 10000;


            try
            {
                if (configuracion == true)
                {
                    Configuracion cf = new Configuracion();
                    cf.Nombre_Empresa = txtnombreempresa.Text;
                    cf.Direccion_Empresa = txtdireccion.Text;
                    cf.Email = txtcorreoconf.Text;
                    cf.NCI = txtnci.Text;
                    cf.Telefono = txttelefono.Text;
                    try
                    {
                        cf.IVA = decimal.Parse(txtimpuestosiva.Text);
                    }
                    catch
                    {

                        metodos.Mensajes("El 'PIVA' no es valido", "error");
                    }
                    cf.Estado = comboestado.Text;
                    cf.Pie_Pagina = txtpiedepagina.Text;

                    cn.UPDATEIVA(decimal.Parse(txtimpuestosiva.Text));
                    cn.CONFIGURACION(cf);
                    cn.CARGARCONFIG();
                }
                else {

                    metodos.Mensajes("Hay datos no validos","error");
                
                }
            }
            catch {


                metodos.Mensajes("Completa todos los campos", "error");
            
            }
            
        }

        private void tabmenu_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (tabmenu.SelectedIndex == 2) {


                
            
            }



        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

            this.Text = "->[" + LoadData.Nombre + " ( " + LoadData.Tipo_Usuario + " )" + "]";
            combotipocliente.SelectedIndex = 0;
            txtemailcliente1.Text = "";
        }


        private void btncerrar_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            this.Close();
            login.Show();
        }

        private void btnproveedor_Click(object sender, EventArgs e)
        {
            proveedorestab();


        }

        private void btnagregarproveedor_Click(object sender, EventArgs e)
        {
            frmAgregarproveedor proveedor = new frmAgregarproveedor();
            proveedor.btneditar.Visible = false;
            proveedor.btneliminar.Visible = false;
            proveedor.btnagregaruser.Visible = true;
            proveedor.btnagregaruser.Text = "GUARDAR PROVEEDOR";
            proveedor.ShowDialog();
            cn.MOSTRAR(dgvproveedores, "Proveedor", "Id_Proveedor", 15);
        }

        private void btnnuevousuario_Click(object sender, EventArgs e)
        {
            frmUsuario usuario = new frmUsuario();
            usuario.ShowDialog();
        }


        //evento cell doble click

        private void dgvusuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                frmUsuario user = new frmUsuario();

                user.txtnombre.Text = dgvusuarios.Rows[e.RowIndex].Cells[1].Value.ToString();

                user.txtemail.Text = dgvusuarios.Rows[e.RowIndex].Cells[2].Value.ToString();
                user.txtusuario.Text = dgvusuarios.Rows[e.RowIndex].Cells[3].Value.ToString();
                user.combotipousuario.Text = dgvusuarios.Rows[e.RowIndex].Cells[5].Value.ToString();
                user.lblnuevousuario.Text = "ACCIONDES DE USUARIO";
                user.btnagregaruser.Visible = false;
                user.btneditar.Visible = true;
                user.btneliminar.Visible = true;
                user.accion = "editar";
                user.lblid.Text = dgvusuarios.Rows[e.RowIndex].Cells[0].Value.ToString();
                user.ShowDialog();
                usuariostab();
                
            }
            catch {

                metodos.Mensajes("Debes hacer doble click en el registro", "alerta");

            }


        }

        private void txtbusquedausuario_TextChanged(object sender, EventArgs e)
        {
            
            cn.BUSQUEDA(dgvusuarios, txtbusquedausuario.Text.ToString(), "USUARIOSMOSTRAR", "Nombre_Completo", 15);
           
        }




        private void dgvproductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                frmProductosactions pro = new frmProductosactions();

                pro.txtdescripcion.Text = dgvproductos.Rows[e.RowIndex].Cells[1].Value.ToString();
                pro.txtprecio.Text = dgvproductos.Rows[e.RowIndex].Cells[2].Value.ToString();
                pro.txtexistencia.Text = dgvproductos.Rows[e.RowIndex].Cells[3].Value.ToString();
                pro.txtpiva.Text = dgvproductos.Rows[e.RowIndex].Cells[4].Value.ToString();
                pro.lblid.Text = dgvproductos.Rows[e.RowIndex].Cells[0].Value.ToString();
                pro.comboproveedor.Text = dgvproductos.Rows[e.RowIndex].Cells[6].Value.ToString();
                pro.txtpiva.Enabled = false;

                pro.ShowDialog();
                cn.MOSTRAR(dgvproductos, "ProductosJoin", "Codigo_Producto", 15);
            }
            catch {
                metodos.Mensajes("Debes hacer doble click en el registro", "alerta");
            }

        }

        private void txtbusquedaproductos_TextChanged(object sender, EventArgs e)
        {
            cn.BUSQUEDA(dgvproductos, txtbusquedaproductos.Text, "ProductosJoin", "Descripcion",15);
        }






        private void btneditar_Click(object sender, EventArgs e)
        {
            





        }



        public void limpiar() {

            comboproveedor.SelectedIndex = 0;
            txtdescripcion.Text = "";
            txtexistencia.Text = "1";
            txtprecio.Text = "1";
        
        
        
        }

        private void txtemailcliente_TextChanged(object sender, EventArgs e)
        {
            if (cn.SQLVALIDATE("Cliente", "Email", txtemailcliente1.Text) == true)
            {

                lblvalidaremail.Visible = true;
                txtemailcliente1.BackColor = Color.IndianRed;
                lblvalidaremail.Text = "Este Email ya esta registrado";



            }
            else {


                lblvalidaremail.Visible = false;
                txtemailcliente1.BackColor = Color.White;
               
            
            }
        }

        private void txtbusquedaclientes_TextChanged(object sender, EventArgs e)
        {
            cn.BUSQUEDA(dgvclientes, txtbusquedaclientes.Text, "Cliente", "Nombre", 10);
        }

        private void dgvclientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)

        {
            try
            {
                frmClientesaction cliente = new frmClientesaction();

                cliente.lblid.Text = dgvclientes.Rows[e.RowIndex].Cells[0].Value.ToString();
                cliente.txtnombrecliente2.Text = dgvclientes.Rows[e.RowIndex].Cells[1].Value.ToString();
                cliente.txtidentificacion2.Text = dgvclientes.Rows[e.RowIndex].Cells[2].Value.ToString();
                cliente.txtemail2.Text = dgvclientes.Rows[e.RowIndex].Cells[3].Value.ToString();
                cliente.txtdireccion2.Text = dgvclientes.Rows[e.RowIndex].Cells[4].Value.ToString();
                cliente.combotipocliente2.Text = dgvclientes.Rows[e.RowIndex].Cells[5].Value.ToString();

                cliente.ShowDialog();
                cn.MOSTRAR(dgvclientes, "Cliente", "Id_Cliente", 15);
            }
            catch { 
            
            
            
            
            }
        }

        private void txtidentificacion_TextChanged(object sender, EventArgs e)
        {
            int x = txtidentificacion.Text.Length;
            if (x >11) {

                metodos.Mensajes("La identificacion solo debe tener 10 digitos", "error");
            
            
            }


            if (cn.SQLVALIDATE("Cliente", "Identificacion", txtidentificacion.Text) == true)
            {


                lblvalidaridentificacion.Visible = true;
                lblvalidaridentificacion.Text = "Esta identificación ya existe";
                txtidentificacion.BackColor = Color.IndianRed;

            }
            else {

                lblvalidaridentificacion.Visible = false;
                txtidentificacion.BackColor = Color.White;
            
            }


        }

        private void dgvproveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                frmAgregarproveedor proveedor = new frmAgregarproveedor();
                proveedor.lblid.Text = dgvproveedores.Rows[e.RowIndex].Cells[0].Value.ToString();
                proveedor.txtempresa.Text = dgvproveedores.Rows[e.RowIndex].Cells[1].Value.ToString();
                proveedor.txtemail.Text = dgvproveedores.Rows[e.RowIndex].Cells[2].Value.ToString();
                proveedor.txttelefono.Text = dgvproveedores.Rows[e.RowIndex].Cells[3].Value.ToString();
                proveedor.txtrepresentante.Text = dgvproveedores.Rows[e.RowIndex].Cells[4].Value.ToString();
                proveedor.txtdireccion.Text = dgvproveedores.Rows[e.RowIndex].Cells[5].Value.ToString();
                proveedor.combotipocliente2.Text = dgvproveedores.Rows[e.RowIndex].Cells[6].Value.ToString();

                proveedor.lblnuevousuario.Text = "ACCIONDES DE PROVEEDORES";
                proveedor.btnagregaruser.Visible = false;
                proveedor.btneditar.Visible = true;
                proveedor.btneliminar.Visible = true;

                proveedor.ShowDialog();
                cn.MOSTRAR(dgvproveedores, "Proveedor", "Id_Proveedor", 15);

            }
            catch {


                metodos.Mensajes("Debes hacer doble click en el registro", "alerta");
            
            }
        }

        private void txtbuscarproveedores_TextChanged(object sender, EventArgs e)
        {
            cn.BUSQUEDA(dgvproveedores, txtbuscarproveedores.Text, "Proveedor", "Empresa", 15);
        }

       
        private void tbtbusquedafactura_TextChanged(object sender, EventArgs e)
        {
            cn.BUSQUEDA(dgvAdministrar, tbtbusquedafactura.Text, "AdministrarFactura", "Id_Factura", 15);
        }

        private void dgvAdministrar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                frmEditarfactura factura = new frmEditarfactura();

                factura.lblnombre.Text = dgvAdministrar.Rows[e.RowIndex].Cells["Cliente"].Value.ToString();
                factura.lblid.Text = dgvAdministrar.Rows[e.RowIndex].Cells["Id_Factura"].Value.ToString();
                factura.lbltotal.Text = dgvAdministrar.Rows[e.RowIndex].Cells["Total"].Value.ToString();
                factura.lblvendedor.Text = dgvAdministrar.Rows[e.RowIndex].Cells["Vendedor"].Value.ToString();
                factura.lblfecha.Text = Convert.ToDateTime( dgvAdministrar.Rows[e.RowIndex].Cells["Fecha"].Value.ToString()).ToString("yyyy-MM-dd");
                factura.lblpago.Text = dgvAdministrar.Rows[e.RowIndex].Cells["Tipo_Pago"].Value.ToString();

                factura.ShowDialog();
                cn.MOSTRAR(dgvAdministrar, "AdministrarFactura", "Id_Factura", 15);
            }
            catch {

                metodos.Mensajes("Debes hacer doble click en el registro", "alerta");
            
            }

        }


        private void verreporte_Click(object sender, EventArgs e)
        {




            try
            {
                frmReportedefactura reporte = new frmReportedefactura();
                string fecha = Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString()).ToString("yyyy/MM/dd");
                reporte.fecharepor = fecha.ToString();
                reporte.fechadetallada = dateTimePicker1.Text.ToString();
                reporte.ShowDialog();
            }
            catch { 
            
            
            
            }
            
          


        }

        private void dgvproductos_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            for (int r = 0; r < dgvproductos.Rows.Count; r++)
            {

                if (dgvproductos.Rows[r].Cells["Existencia"].Value.ToString() == "0")
                {

                    //MessageBox.Show(dgvproductos.Rows[r].Cells[3].Value.ToString());

                    dgvproductos.Rows[r].DefaultCellStyle.BackColor = Color.IndianRed;
                    dgvproductos.Rows[r].DefaultCellStyle.ForeColor = Color.White;

                }

            }
        }

      

        private void txtpiedepagina_TextChanged(object sender, EventArgs e)
        {
            lblleng.Text = txtpiedepagina.Text.Length.ToString();

            if (int.Parse(lblleng.Text)<6)
            {

                lblvalidarpie.Text = "El pie de facture Debe ser mayor a 5 caracteres";
                txtpiedepagina.BackColor = Color.IndianRed;
                configuracion = false;
            }

            else {

                lblvalidarpie.Text = "";
                txtpiedepagina.BackColor = Color.White;
                configuracion = true;
            
            }

        }



        public void timerdashload() {


            num++;


            for (int x = 0; x < 11; x++)
            {
                if (txtmasvendido.Text.Length > 2) {

                    lblcargando.Text=("Actualizando...");
                }


                lblcargando.Visible = true;
                lbltimer.Text = num.ToString();
               

            }

            if (num == 3)
            {
                lblcargando.Visible = false;
                timerdash.Stop();

                try
                {
                    
                    string[] producto = cn.MASVENDIDO().ToString().Split('+');
                    string[] vendedorestrella = cn.VENDEDORESTRELLA().ToString().Split('+');

                    try
                    {
                        txtdetalles.Text = vendedorestrella[0] + " PRODUCTOS [" + Convert.ToDouble(vendedorestrella[1].ToString()).ToString("N") + "]";
                    }
                    catch
                    {

                        metodos.Mensajes("No se han realizado ventas", "alerta");

                    }

                    try
                    {
                        txttotaldeventas.Text = cn.COUNT(DateTime.Today.ToString("yyyy / MM / dd"), "Factura", true) + "  VENTAS";
                    }
                    catch {

                        txttotaldeventas.Text = "0";
                    }
                    try
                    {
                        txttotalvendido.Text = cn.SUM(DateTime.Today.ToString("yyyy/MM/dd"), "decimal") + " RD$";
                    }
                    catch {

                        txttotalvendido.Text = "0 RD$";
                    
                    }

                    try
                    {
                        cn.PRODUCTODEHOY(txtmasvendido, txtcantidadmasvendido);
                    }
                    catch {

                        txtmasvendido.Text = "";
                        txtcantidadmasvendido.Text = "";

                    }

                    try
                    {
                        txtvendedorestrella.Text = vendedorestrella[2].ToString();
                    }

                    catch {

                        txtvendedorestrella.Text = "";
                    
                    }
                    

                    try
                    {
                        txtcantidadproductos.Text = cn.COUNT(null, "Productos", false).ToString();
                    }
                    catch {

                        txtcantidadproductos.Text = "0";
                    
                    }

                    try
                    {
                        txtproveedores.Text = cn.COUNT(null, "Proveedor", false).ToString();
                    }
                    catch {

                        txtproveedores.Text = "";
                    }

                    try
                    {
                        txtclientes.Text = cn.COUNT(null, "Cliente", false).ToString();
                    }
                    catch {

                        txtclientes.Text = "0";
                    
                    }

                    try
                    {
                        cn.TOPVENDEDORES(txtvendedor1, txtvendedor2, txtvendedor3);
                    }
                    catch {
                        txtvendedor1.Text = "";
                        txtvendedor2.Text = "";
                        txtvendedor3.Text = "";
                    
                    }

                    try
                    {
                        cn.TOPPRODUCTOS(txtproducto1, txtproducto2, txtproducto3);
                    }

                    catch {

                        txtproducto1.Text = "";
                        txtproducto2.Text = "";
                        txtproducto3.Text = "";
                    
                    }

                    try
                    {
                        txtagotados.Text = cn.SQLCOUNTESPETIAL("Productos", "Existencia", "0").ToString();
                    }
                    catch {

                        txtagotados.Text = "";
                    
                    }


                    //cn.contadornotificacion(dgvDatos, lblnumero, int.Parse(lblID.Text));
                    num = 0;
                }
                catch {

                    metodos.Mensajes("Error al cargar datos","error");
                
                }
                


            }
        
        
        
        
        }





        private void picturelogo_Click(object sender, EventArgs e)
        {
            try
            {
                tabmenu.SelectedIndex = 7;
                lblcabeza.Text = "DASHBOARD";
                timerdash.Start();
            }

            catch {

                metodos.Mensajes("No hay ventas","alerta");
            
            
            }
          

            



        }

        private void txtdescripcion_TextChanged(object sender, EventArgs e)
        {
            if (cn.SQLVALIDATE("Productos", "Descripcion", txtdescripcion.Text) == true)
            {


                labelvalidar.Text = "El producto ya existe";
                labelvalidar.Visible = true;
                txtdescripcion.BackColor = Color.IndianRed;
                productos = false;


            }

            else if (txtdescripcion.Text.Trim().Length < 5) {

                labelvalidar.Text = "Minimo 5 caracteres";
                labelvalidar.Visible = true;
                txtdescripcion.BackColor = Color.IndianRed;
                productos = false;
            
            }

            else
            {

                txtdescripcion.BackColor = Color.White;
                labelvalidar.Visible = false;
                productos = true;

            }

        }

        private void txtprecio_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(txtprecio.Text);
                lblvalidarprecio.Visible = false;
                txtprecio.BackColor = Color.White;
                productos = true;
            }
            catch {

                lblvalidarprecio.Text = "Precio no valido";
                lblvalidarprecio.Visible = true;
                txtprecio.BackColor = Color.IndianRed;
                productos = false;


            
            
            }
        }

        private void txtexistencia_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(txtexistencia.Text);
                lblvalidarexistencia.Visible = false;
                txtexistencia.BackColor = Color.White;
                productos = true;
            }
            catch
            {

                lblvalidarexistencia.Text = "Cantidad no valida";
                lblvalidarexistencia.Visible = true;
                txtexistencia.BackColor = Color.IndianRed;
                productos = false;




            }


        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            if (txtnombre.Text.Length < 6)
            {

                lblvalidarnombre.Visible = true;
                lblvalidarnombre.Text = "El nombre debe tener como minino 6 caracteres";
                txtnombre.BackColor = Color.IndianRed;



            }

            else {

                lblvalidarnombre.Visible = false; ;

                txtnombre.BackColor = Color.White;
            
            
            }
        }

        private void lblcabeza_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void comboestado_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void tabconfiguracion_DoubleClick(object sender, EventArgs e)
        {
            comboestado.Visible = true;
        }

        private void tabconfiguracion_Click(object sender, EventArgs e)
        {

        }

        private void panel32_DoubleClick(object sender, EventArgs e)
        {
            comboestado.Visible = false;
        }

        private void lbltimer_Click(object sender, EventArgs e)
        {

        }

        private void timerdash_Tick(object sender, EventArgs e)
        {
            timerdashload();
        }

        private void label34_Click(object sender, EventArgs e)
        {
            Agotados();
        }


        public void Agotados() {


            frmProductosagotados agotados = new frmProductosagotados();
            agotados.ShowDialog();
        
        
        }

        private void panel31_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtnombreempresa_TextChanged(object sender, EventArgs e)
        {
            if (txtnombreempresa.Text.Trim().Length < 5)
            {


                lblvalidarempresa.Text = "Debe ser mayor a 5 caracteres";
                txtnombreempresa.BackColor = Color.IndianRed;
                configuracion = false;


            }
            else {

                lblvalidarempresa.Text = "";
                txtnombreempresa.BackColor = Color.White;
                configuracion = true;
            
            }
        }

        private void txtnci_TextChanged(object sender, EventArgs e)
        {

            if (txtnci.Text.Length <10)
            {

                lblvalidarnci.Text = "Debe tener 10 caracteres";
                txtnci.BackColor = Color.IndianRed;
                configuracion = false;


            }
            else {


                lblvalidarnci.Text = "";
                txtnci.BackColor = Color.White;
                configuracion = true;

            }

        }

        private void txtdireccion_TextChanged(object sender, EventArgs e)
        {
            if (txtdireccion.Text.Trim().Length < 7)
            {

                lblvalidardireccion.Text = "Debe tener como mimino 7 caracteres";
                txtdireccion.BackColor = Color.IndianRed;
                configuracion = false;

            }

            else {

                lblvalidardireccion.Text = "";
                txtdireccion.BackColor = Color.White;
                configuracion = true;
            
            }
        }

        private void txttelefono_TextChanged(object sender, EventArgs e)
        {
            if (txttelefono.Text.Trim().Length < 10) {

                lblvalidartelefono.Text = "Debe tener como minimo 10 caracteres";
                txttelefono.BackColor = Color.IndianRed;
                configuracion = false;
            
            }
            else{

                lblvalidartelefono.Text = "";
                txttelefono.BackColor = Color.White;
                configuracion = true;
            
            
            }
        }

        private void txtcorreoconf_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if(txtcorreoconf.Text.Trim().Length==0){

                    lblvalidaremailconf.Text = "El correo es obligatorio";
                    txtcorreoconf.BackColor = Color.IndianRed;
                    configuracion = false;
                
                }

                string[] email = txtcorreoconf.Text.ToString().Split('@');
                string[] espacios = txtcorreoconf.Text.ToString().Split(' ');

                if (espacios.Length > 0)
                {

                    if (email.Length == 0)
                    {



                        lblvalidaremailconf.Text = "El correo no cumple con los requisitos";
                        txtcorreoconf.BackColor = Color.IndianRed;
                        configuracion = false;

                    }

                    else if (email[1].ToString().Length == 0)
                    {

                        
                        lblvalidaremailconf.Text = "Falta el dominio 'EJ: @hotmail'";
                        txtcorreoconf.BackColor = Color.IndianRed;
                        configuracion = false;

                    }

                    else if (email[0].ToString().Length == 0)
                    {


                        lblvalidaremailconf.Text = "El correo no cumple con los requisitos";
                        txtcorreoconf.BackColor = Color.IndianRed;
                        configuracion = false;

                    }

                    else {

                        lblvalidaremailconf.Text = "";
                        txtcorreoconf.BackColor = Color.White;
                        configuracion = true;
                    
                    }
                }

                else
                {

                   lblvalidaremailconf.Text = "El correo no puede tener espacio";
                   txtcorreoconf.BackColor = Color.IndianRed;
                   configuracion = false;


                }
            }
            catch { 
            
            }


           
        }

        private void txtimpuestosiva_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string[] iva = txtimpuestosiva.Text.Split('.');

                if (txtimpuestosiva.Text.Length == 0)
                {

                    lblvalidariva.Text = "El IVA es obligatorio";
                    txtimpuestosiva.BackColor = Color.IndianRed;
                    configuracion = false;

                }

                else if (iva.Length > 2)
                {

                    lblvalidariva.Text = "Exceso de puntos decimales en la cifra.";
                    txtimpuestosiva.BackColor = Color.IndianRed;
                    configuracion = false;


                }

                else if (iva.Length == 0)
                {

                    lblvalidariva.Text = "El IVA debe tener un punto decimal. EJ: 0.18";
                    txtimpuestosiva.BackColor = Color.IndianRed;
                    configuracion = false;



                }

                else
                {

                    lblvalidariva.Text = "";
                    txtimpuestosiva.BackColor = Color.White;
                    configuracion = true;


                }
            }
            catch { 
            
            
            
            }

       }
       

            }
        


        }
    
       
