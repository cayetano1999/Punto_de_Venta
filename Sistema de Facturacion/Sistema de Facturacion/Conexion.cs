using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using Sistema_de_Facturacion.clases;

namespace Sistema_de_Facturacion
{
    class Conexion
    {

        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        Metodos metodos = new Metodos();
        DataTable dt;

        public Conexion()
        {

            try
            {
                //cn = new SqlConnection("Server=tcp:cayetano.database.windows.net,1433;Initial Catalog=Sistema_Facturacion;Persist Security Info=False;User ID=cayetano1999;Password=02300893167Az;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                ////cn.Open();


                 cn = new SqlConnection("Data Source=WINDOWS-N0UF27K\\SQLEXPRESS;Initial Catalog=Sistema_Facturacion;Integrated Security=True");
                cn.Open();
            }
            catch (Exception x)
            {
                MessageBox.Show("No se pudo conectar con Azure");

                try
                {


                    //MessageBox.Show("CONECTADO A LA DB LOCAL");
                }
                catch
                {

                    MessageBox.Show("Se intentó conectar la aplicacion a Azure y no se logró. Se intentó conectar la aplicacion a la base de datos local y no se logró");

                }
            }
        }

        internal Facturas Facturas
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        internal Producto Producto
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        internal DetalleFactura DetalleFactura
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        internal LoadDataConfig LoadDataConfig
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }



        public bool VERIFICAR_USUARIO(Usuarios us)
        {


            bool retornar = false;
            try
            {
                string sql = "select *from Usuario where Usuario='" + us.Usuario + "' and Contrasena='" + us.Contrasena + "'";
                dt = new DataTable();

                cmd = cn.CreateCommand();
                cmd.CommandText = ("select *from Usuario where Usuario='" + us.Usuario + "' and Contrasena='" + us.Contrasena + "'");
                dr = cmd.ExecuteReader();
                dt.Load(dr);
                if (dt.Rows.Count == 0)
                {
                    retornar = false;
                }

                else
                {
                    DataRow filas = dt.Rows[0];

                    LoadData.ID = int.Parse(filas["Id_Usuario"].ToString());
                    LoadData.Nombre = filas["Nombre_Completo"].ToString();
                    LoadData.Email = filas["Email"].ToString();
                    LoadData.Usuario = filas["Usuario"].ToString();
                    LoadData.Tipo_Usuario = filas["Tipo_Usuario"].ToString();
                    retornar = true;
                }
            }
            catch
            {

                metodos.Mensajes("Error al acceder a la DB, comunicate con el administrador", "error");

            }
            return retornar;

        }


        public void GUARDAR_USUARIO(Usuarios users)
        {

            try
            {
                if (users != null)
                {
                    cmd = cn.CreateCommand();
                    cmd.CommandText = ("insert into Usuario values (@Email, @Nombre_Completo, @Usuario, @Contrasena, @Fecha, @Tipo_Usuario)");
                    cmd.Parameters.AddWithValue("@Email", users.Email);
                    cmd.Parameters.AddWithValue("@Nombre_Completo", users.Nombre_Completo);
                    cmd.Parameters.AddWithValue("@Usuario", users.Usuario);
                    cmd.Parameters.AddWithValue("@Contrasena", users.Contrasena);
                    cmd.Parameters.AddWithValue("@Fecha", users.Fecha);
                    cmd.Parameters.AddWithValue("@Tipo_Usuario", users.Tipo_Usuario);
                    cmd.ExecuteNonQuery();
                    metodos.Mensajes("Usuario agregado!", "bien");

                }

            }
            catch
            {


                metodos.Mensajes("Ha ocurrido un error al guardar el usuario, intente nuevamente", "error");

            }

        }


        public void MOSTRAR(DataGridView dgv, string Tabla, string Campo, int cantidad)
        {

            try
            {
                dt = new DataTable();
                cmd = cn.CreateCommand();
                cmd.CommandText = ("select* from " + Tabla + " order by " + Campo + " desc OFFSET 0 ROWS FETCH NEXT " + cantidad + " ROWS ONLY ");

                dr = cmd.ExecuteReader();
                dt.Load(dr);
                dgv.DataSource = dt;


                try
                {
                    for (int r = 0; r < dgv.Rows.Count; r++)
                    {

                        if (dgv.Rows[r].Cells["Existencia"].Value.ToString() == "0")
                        {

                            //MessageBox.Show(dgvproductos.Rows[r].Cells[3].Value.ToString());

                            dgv.Rows[r].DefaultCellStyle.BackColor = Color.IndianRed;
                            dgv.Rows[r].DefaultCellStyle.ForeColor = Color.White;

                        }

                    }
                }
                catch
                {

                }
            }

            catch
            {


                metodos.Mensajes("Ha ocurrido un error al mostrar los datos", "error");

            }



        }


        public void EDITAR_USUARIO(Usuarios us)
        {

            try
            {
                cmd = cn.CreateCommand();
                cmd.CommandText = ("update Usuario set Email=@Email, Nombre_Completo=@Nombre, Usuario=@Usuario, Contrasena=@Contrasena, Tipo_Usuario=@Tipo_Usuario where Id_Usuario=@id");
                cmd.Parameters.AddWithValue("@Email", us.Email);
                cmd.Parameters.AddWithValue("@Nombre", us.Nombre_Completo);
                cmd.Parameters.AddWithValue("@Usuario", us.Usuario);
                cmd.Parameters.AddWithValue("@Contrasena", us.Contrasena);
                cmd.Parameters.AddWithValue("@id", us.Id_Usuario);
                cmd.Parameters.AddWithValue("@Tipo_Usuario", us.Tipo_Usuario);
                cmd.ExecuteNonQuery();
                metodos.Mensajes("Usuario editado correctamente!", "bien");
            }
            catch (SqlException e)
            {

                metodos.Mensajes("Ha ocurrido un error al editar el usuario", "error");

            }

        }



        public void ELIMINAR(int id, string Tabla, string Campo)
        {
            try
            {
                cmd = cn.CreateCommand();
                cmd.CommandText = ("delete from " + Tabla + " where " + Campo + "  =@id");
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@Tabla", Tabla);
                cmd.ExecuteNonQuery();
                metodos.Mensajes(Tabla + " eliminado correctamente", "bien");
            }
            catch
            {

                metodos.Mensajes("Ha ocurrido un error al eliminar", "error");

            }

        }


        public void BUSQUEDA(DataGridView dgv, string busqueda, string Tabla, string Campo, int Cantidad)
        {


            try
            {
                dt = new DataTable();
                cmd = cn.CreateCommand();
                cmd.CommandText = ("select *from " + Tabla + " where " + Campo + " like '%" + busqueda + "%' order by " + Campo + " OFFSET 0 ROWS FETCH NEXT " + Cantidad + " ROWS ONLY   ");
                cmd.Parameters.AddWithValue("@Tabla", Tabla);
                dr = cmd.ExecuteReader();
                dt.Load(dr);
                dgv.DataSource = dt;

                try
                {
                    for (int r = 0; r < dgv.Rows.Count; r++)
                    {

                        if (dgv.Rows[r].Cells["Existencia"].Value.ToString() == "0")
                        {

                            //MessageBox.Show(dgvproductos.Rows[r].Cells[3].Value.ToString());

                            dgv.Rows[r].DefaultCellStyle.BackColor = Color.IndianRed;
                            dgv.Rows[r].DefaultCellStyle.ForeColor = Color.White;

                        }

                    }
                }
                catch
                {

                }
            }

            catch
            {

                metodos.Mensajes("Ha ocurrido un error mientras se realizaba la busqueda", "error");

            }

        }



        public void BUSQUEDA_SELECTIVA(DataGridView dgv, string busqueda, int cantidad)
        {
            try
            {
                dt = new DataTable();
                cmd = cn.CreateCommand();
                cmd.CommandText = ("select Codigo_Producto, Descripcion, Precio, Existencia from Productos Where Descripcion like '%" + busqueda + "%' order by Descripcion  OFFSET 0 ROWS FETCH NEXT " + cantidad + " ROWS ONLY ");
                dr = cmd.ExecuteReader();
                dt.Load(dr);
                dgv.DataSource = dt;
            }
            catch
            {

            }
        }

        //------------------------------PRODUCTOS

        public void AGREGAR_PRODUCTOS(Producto pr)
        {

            try
            {
                cmd = cn.CreateCommand();
                cmd.CommandText = ("insert into Productos values (@Descripcion, @Precio, @Existencia, @PIVA, @Fecha, @Id_Proveedor)");
                cmd.Parameters.AddWithValue("@Descripcion", pr.Descripcion);
                cmd.Parameters.AddWithValue("@Precio", pr.Precio);
                cmd.Parameters.AddWithValue("@Existencia", pr.Existencias);
                cmd.Parameters.AddWithValue("@PIVA", pr.PIVA);
                cmd.Parameters.AddWithValue("@Fecha", pr.Fecha);
                cmd.Parameters.AddWithValue("@Id_Proveedor", pr.Id_Proveedor);
                cmd.ExecuteNonQuery();
                metodos.Mensajes("El producto " + pr.Descripcion + " fue agregado!", "bien");


            }
            catch
            {


                metodos.Mensajes("Ha ocurrido un error al guardar el producto", "error");


            }
        }


        public void EDITAR_PRODUCTOS(Producto pr)
        {

            try
            {
                cmd = cn.CreateCommand();
                cmd.CommandText = ("update Productos set Descripcion=@Descripcion, Precio=@Precio, Existencia=@Existencia, PIVA=@PIVA, Fecha=@Fecha, Id_Proveedor=@Id_Proveedor where Codigo_Producto = @id");
                cmd.Parameters.AddWithValue("@Descripcion", pr.Descripcion);
                cmd.Parameters.AddWithValue("@Precio", pr.Precio);
                cmd.Parameters.AddWithValue("@Existencia", pr.Existencias);
                cmd.Parameters.AddWithValue("@PIVA", pr.PIVA);
                cmd.Parameters.AddWithValue("@id", pr.Codigo_Producto);
                cmd.Parameters.AddWithValue("@Fecha", DateTime.Now);
                cmd.Parameters.AddWithValue("@Id_Proveedor", pr.Id_Proveedor);
                cmd.ExecuteNonQuery();
                metodos.Mensajes("Producto editado!", "bien");
            }
            catch
            {


                metodos.Mensajes("Ha ocurrido un error al editar el producto", "error");

            }




        }


        ////////////////////////////////CONFIG 



        public void CONFIGURACION(Configuracion cf)
        {

            try
            {
                dt = new DataTable();
                cmd = cn.CreateCommand();
                cmd.CommandText = ("select *from Configuracion");
                dr = cmd.ExecuteReader();
                dt.Load(dr);
                if (dt.Rows.Count > 0)
                {
                    cmd.CommandText = ("Update Configuracion set Nombre_Empresa = @Nombre_Empresa, Direccion_Empresa = @Direccion_Empresa, Email= @Email, NCI = @NCI, Telefono = @Telefono, IVA= @IVA, Pie_Pagina = @Pie_Pagina, Estado=@Estado ");
                    cmd.Parameters.AddWithValue("@Nombre_Empresa", cf.Nombre_Empresa);
                    cmd.Parameters.AddWithValue("@Direccion_Empresa", cf.Direccion_Empresa);
                    cmd.Parameters.AddWithValue("@Email", cf.Email);
                    try
                    {
                        cmd.Parameters.AddWithValue("@NCI", cf.NCI);
                    }
                    catch
                    {

                        metodos.Mensajes("El 'IVA' no es valido, debe ser una cantidad decimal EJ '0.18''", "error");


                    }
                    cmd.Parameters.AddWithValue("@Telefono", cf.Telefono);
                    cmd.Parameters.AddWithValue("@IVA", cf.IVA);
                    cmd.Parameters.AddWithValue("@Estado", cf.Estado);
                    cmd.Parameters.AddWithValue("@Pie_Pagina", cf.Pie_Pagina);

                    cmd.ExecuteNonQuery();
                    metodos.Mensajes("La configuracion ha sido actualizada", "bien");


                }

                else
                {


                    cmd.CommandText = ("insert into Configuracion values  (@Nombre_Empresa, @Direccion_Empresa, @Email, @NCI, @Telefono, @IVA, @Pie_Pagina, @Estado) ");
                    cmd.Parameters.AddWithValue("@Nombre_Empresa", cf.Nombre_Empresa);
                    cmd.Parameters.AddWithValue("@Direccion_Empresa", cf.Direccion_Empresa);
                    cmd.Parameters.AddWithValue("@Email", cf.Email);
                    cmd.Parameters.AddWithValue("@NCI", cf.NCI);
                    cmd.Parameters.AddWithValue("@Telefono", cf.Telefono);
                    cmd.Parameters.AddWithValue("@IVA", cf.IVA);
                    cmd.Parameters.AddWithValue("@Pie_Pagina", cf.Pie_Pagina);
                    cmd.Parameters.AddWithValue("@Estado", "Abierto");
                    cmd.ExecuteNonQuery();
                    metodos.Mensajes("Configuración guardada", "bien");
                }
            }

            catch
            {


                metodos.Mensajes("El 'IVA' no es valido, debe ser una cantidad decimal EJ '0.18''", "error");


            }



        }


        public void CARGARCONFIG()
        {
            try
            {
                dt = new DataTable();
                cmd = cn.CreateCommand();
                cmd.CommandText = ("Select *from Configuracion");
                dr = cmd.ExecuteReader();
                dt.Load(dr);

                DataRow filas = dt.Rows[0];
                LoadDataConfig.Nombre_Empresa = filas["Nombre_Empresa"].ToString();
                LoadDataConfig.Direccion_Empresa = filas["Direccion_Empresa"].ToString();
                LoadDataConfig.Email = filas["Email"].ToString();
                LoadDataConfig.NCI = filas["NCI"].ToString();
                LoadDataConfig.Telefono = filas["Telefono"].ToString();
                LoadDataConfig.Pie_Pagina = filas["Pie_Pagina"].ToString();
                LoadDataConfig.IVA = decimal.Parse(filas["IVA"].ToString());
                LoadDataConfig.Estado = filas["Estado"].ToString();
            }
            catch
            {


            }
        }


        public bool ESTADO()
        {

            bool retornar = false;

            try
            {
                dt = new DataTable();
                cmd = cn.CreateCommand();
                cmd.CommandText = ("Select *from Configuracion");
                dr = cmd.ExecuteReader();
                dt.Load(dr);

                DataRow filas = dt.Rows[0];

                if (filas["Estado"].ToString() == "Abierto")
                {

                    retornar = true;


                }
                else
                {

                    retornar = false;

                }
            }
            catch
            {


            }

            return retornar;




        }

        public void GUARDAR_CLIENTE(Clientes cl)
        {

            try
            {
                cmd = cn.CreateCommand();
                cmd.CommandText = ("Insert into Cliente values (@Nombre, @Identificacion, @Email, @Direccion, @Tipo_Cliente)");
                cmd.Parameters.AddWithValue("@Nombre", cl.Nombre);
                cmd.Parameters.AddWithValue("@Identificacion", cl.Identificacion);
                cmd.Parameters.AddWithValue("@Email", cl.Email);
                cmd.Parameters.AddWithValue("@Direccion", cl.Direccion);
                cmd.Parameters.AddWithValue("@Tipo_Cliente", cl.Tipo_Cliente);
                cmd.ExecuteNonQuery();
                metodos.Mensajes("El cliente fue agregado correctamente!", "bien");
            }
            catch
            {


                metodos.Mensajes("Ha ocurrido un error al guardar el cliente", "error");

            }

        }



        public void EDITAR_CLIENTE(Clientes cl)
        {

            try
            {
                cmd = cn.CreateCommand();
                cmd.CommandText = ("update  Cliente set Nombre =@Nombre, Identificacion = @Identificacion, Email = @Email, Direccion = @Direccion, Tipo_Cliente = @Tipo_Cliente where Id_Cliente=@id");
                cmd.Parameters.AddWithValue("@Nombre", cl.Nombre);
                cmd.Parameters.AddWithValue("@Identificacion", cl.Identificacion);
                cmd.Parameters.AddWithValue("@Email", cl.Email);
                cmd.Parameters.AddWithValue("@Direccion", cl.Direccion);
                cmd.Parameters.AddWithValue("@Tipo_Cliente", cl.Tipo_Cliente);
                cmd.Parameters.AddWithValue("@id", cl.Id_Cliente);
                cmd.ExecuteNonQuery();
                metodos.Mensajes("Datos actualizados correctamente!", "bien");
            }
            catch
            {

                metodos.Mensajes("Ha ocurrido un error al editar el cliente", "error");

            }


        }


        public void REGISTRAR_PROVEEDOR(Proveedores pv)
        {


            try
            {
                cmd = cn.CreateCommand();
                cmd.CommandText = ("Insert into Proveedor values (@Empresa, @Email, @Telefono, @Representante, @Direccion, @Tipo_Proveedor)");
                cmd.Parameters.AddWithValue("@Empresa", pv.Empresa);
                cmd.Parameters.AddWithValue("@Email", pv.Email);
                cmd.Parameters.AddWithValue("@Telefono", pv.Telefono);
                cmd.Parameters.AddWithValue("@Representante", pv.Representante);
                cmd.Parameters.AddWithValue("@Direccion", pv.Direccion);
                cmd.Parameters.AddWithValue("@Tipo_Proveedor", pv.Tipo_Proveedor);
                cmd.ExecuteNonQuery();
                metodos.Mensajes("El Proveedor fue agregado correctamente!", "bien");
            }
            catch
            {


                metodos.Mensajes("Ha ocurrido un error al registar proveedor", "error");

            }



        }


        public void EDITAR_PROVEEDO(Proveedores pv)
        {

            try
            {
                cmd = cn.CreateCommand();
                cmd.CommandText = ("update  Proveedor set Empresa= @Empresa, Email =  @Email, Telefono = @Telefono, Representante = @Representante, Direccion=  @Direccion, Tipo_Proveedor =  @Tipo_Proveedor where Id_Proveedor=@id");
                cmd.Parameters.AddWithValue("@Empresa", pv.Empresa);
                cmd.Parameters.AddWithValue("@Email", pv.Email);
                cmd.Parameters.AddWithValue("@Telefono", pv.Telefono);
                cmd.Parameters.AddWithValue("@Representante", pv.Representante);
                cmd.Parameters.AddWithValue("@Direccion", pv.Direccion);
                cmd.Parameters.AddWithValue("@Tipo_Proveedor", pv.Tipo_Proveedor);
                cmd.Parameters.AddWithValue("@id", pv.Id_Proveedor);
                cmd.ExecuteNonQuery();
                metodos.Mensajes("El Proveedor fue editado correctamente!", "bien");
            }

            catch
            {

                metodos.Mensajes("Ha ocurrido un error al editar proveedor", "error");




            }




        }



        public void GUARDARFACTURA(Facturas cs)
        {

            try
            {
                cmd = cn.CreateCommand();
                cmd.CommandText = ("Insert into Factura values (@FECHA, @FK_IdUsuario, @FK_IdCliente, @Tipo_Pago)");
                cmd.Parameters.AddWithValue("@FECHA", cs.FECHA);
                cmd.Parameters.AddWithValue("@FK_IdUsuario", cs.FK_IdUsuario);
                cmd.Parameters.AddWithValue("@FK_IdCliente", cs.FK_IdCliente);
                cmd.Parameters.AddWithValue("@Tipo_Pago", cs.Tipo_Pago);
                cmd.ExecuteNonQuery();
            }
            catch
            {


                metodos.Mensajes("Ha ocurrido un error al guardar la factura", "error");

            }


        }



        public void GUARDARDETALLES(DetalleFactura df)
        {

            try
            {
                cmd = cn.CreateCommand();
                cmd.CommandText = ("Insert into Detalle_Factura values (@Codigo_Producto, @Cantidad, @Precio, @Total, @Id_Factura, @Nombre_Producto)");
                cmd.Parameters.AddWithValue("@Id_Factura", df.Id_Factura);
                cmd.Parameters.AddWithValue("@Codigo_Producto", df.Codigo_Producto);
                cmd.Parameters.AddWithValue("@Nombre_Producto", df.Nombre_Producto.ToString());
                cmd.Parameters.AddWithValue("@Cantidad", df.Cantidad);
                cmd.Parameters.AddWithValue("@Precio", df.Precio);
                cmd.Parameters.AddWithValue("@Total", df.Total);

                cmd.ExecuteNonQuery();
            }

            catch
            {

                metodos.Mensajes("Ha ocurrido un error al registar proveedor", "error");

            }



        }


        public int ULTIMOREGISTRO()
        {
            int retorno = 0;

            try
            {
                dt = new DataTable();

                cmd = cn.CreateCommand();
                cmd.CommandText = ("SELECT TOP 1 * FROM Factura ORDER BY Id_Factura DESC");
                dr = cmd.ExecuteReader();
                dt.Load(dr);

                DataRow fila = dt.Rows[0];

                retorno = int.Parse(fila["Id_Factura"].ToString());
            }
            catch
            {




            }

            return retorno;

        }



        public void DESCONTAR(int cantidad, int codigo)
        {

            try
            {
                cmd = cn.CreateCommand();
                cmd.CommandText = ("update Productos set Existencia = Existencia-@cantidad where Codigo_Producto=@codigo");
                cmd.Parameters.AddWithValue("@cantidad", cantidad);
                cmd.Parameters.AddWithValue("@codigo", codigo);
                cmd.ExecuteNonQuery();
            }
            catch
            {





            }




        }


        public int MOSTRAR2(int id)
        {

            int retorno = 0;
            try
            {
                dt = new DataTable();
                cmd = cn.CreateCommand();
                cmd.CommandText = ("select sum(Total) as Total from Detalle_Factura where Id_Factura = @ide ");
                cmd.Parameters.AddWithValue("@ide", id);
                dr = cmd.ExecuteReader();
                dt.Load(dr);



                DataRow fila = dt.Rows[0];

                retorno = int.Parse(fila["Total"].ToString());
            }
            catch
            {




            }

            return retorno;


        }


        public void MOSTRARFACTURA(DataGridView dgv, string id)
        {


            try
            {
                dt = new DataTable();
                cmd = cn.CreateCommand();
                cmd.CommandText = ("select Codigo_Producto as CODIGO, Nombre_Producto as DESCRIPCION,  Cantidad as CANTIDAD, Precio as PRECIO, Total as TOTAL from Detalle_Factura where Id_Factura = @id");
                cmd.Parameters.AddWithValue("@id", id);
                dr = cmd.ExecuteReader();
                dt.Load(dr);
                dgv.DataSource = dt;
                dr.Close();
            }
            catch
            {


                metodos.Mensajes("Error al mostrar facturas", "error");

            }





        }


        public void UPDATE(int existencia, int codigoproducto)
        {

            try
            {
                cmd = cn.CreateCommand();
                cmd.CommandText = ("update Productos set Existencia = Existencia+@existencia where Codigo_Producto =@codigo");
                cmd.Parameters.AddWithValue("@existencia", existencia);
                cmd.Parameters.AddWithValue("@codigo", codigoproducto);
                cmd.ExecuteNonQuery();
            }
            catch
            {

                metodos.Mensajes("Error al actualizar el inventario", "error");

            }

        }


        public void DELETEPRODUCTS(int idfac, int codigo)
        {

            try
            {
                cmd = cn.CreateCommand();
                cmd.CommandText = ("delete from Detalle_Factura where Id_Factura=@id and Codigo_Producto=@codigo");
                cmd.Parameters.AddWithValue("@id", idfac);
                cmd.Parameters.AddWithValue("@codigo", codigo);
                cmd.ExecuteNonQuery();
            }
            catch
            {

                metodos.Mensajes("Ha ocurrido un error al eliminar el producto", "error");

            }


        }



        public int CARGARID(string campo)
        {


            int retorno = 0;
            try
            {
                dt = new DataTable();
                cmd = cn.CreateCommand();
                cmd.CommandText = ("select Id_Proveedor from Proveedor where Empresa = @campo");
                cmd.Parameters.AddWithValue("@campo", campo);
                dr = cmd.ExecuteReader();
                dt.Load(dr);



                DataRow fila = dt.Rows[0];

                retorno = int.Parse(fila["Id_Proveedor"].ToString());
            }
            catch
            {



            }

            return retorno;

        }



        public int TOTALREGISTRO(string tabla)
        {


            int retorno = 0;
            try
            {
                dt = new DataTable();
                cmd = cn.CreateCommand();
                cmd.CommandText = ("select count(*) as Total from " + tabla + "");
                cmd.Parameters.AddWithValue("@tabla", tabla);
                dr = cmd.ExecuteReader();
                dt.Load(dr);



                DataRow fila = dt.Rows[0];

                retorno = int.Parse(fila["Total"].ToString());
            }
            catch
            {

            }

            return retorno;

        }


        public void SQL(DataGridView dgv, string query)
        {
            try
            {
                dt = new DataTable();
                cmd = cn.CreateCommand();
                cmd.CommandText = (query);
                dr = cmd.ExecuteReader();
                dt.Load(dr);
                dgv.DataSource = dt;
            }
            catch
            {


            }


        }



        public void UPDATEIVA(decimal valor)
        {

            try
            {
                cmd = cn.CreateCommand();
                cmd.CommandText = ("update Productos set PIVA = @valor where Codigo_Producto !='0'");
                cmd.Parameters.AddWithValue("@valor", valor);
                cmd.ExecuteNonQuery();
            }
            catch
            {



            }

        }

        public void UPDATEESTADO()
        {


            try
            {
                cmd = cn.CreateCommand();
                cmd.CommandText = ("update Configuracion set Estado='Abierto'");
                cmd.ExecuteNonQuery();
            }
            catch
            {



            }


        }



        public void llenarproveedor(ComboBox cb)
        {

            try
            {
                cmd = cn.CreateCommand();
                cmd.CommandText = "SELECT Empresa from Proveedor";

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter();
                dr = cmd.ExecuteReader();



                while (dr.Read())
                {
                    cb.Items.Add(dr["Empresa"].ToString());

                }

                dr.Close();

            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());

            }

        }



        public void llenarcombo(ComboBox cb)
        {

            try
            {
                cmd = cn.CreateCommand();
                cmd.CommandText = "SELECT CONCAT (Id_Cliente,'  -  ', Nombre) as Nombres from Cliente";

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter();
                dr = cmd.ExecuteReader();



                while (dr.Read())
                {
                    cb.Items.Add(dr["Nombres"].ToString());

                }

                dr.Close();

            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());

            }

        }


        //CONSULTAS PARA REPORTES

        public string COUNT(string fecha, string tabla, bool condicion)
        {


            string total = "0";
            try
            {
                string q1 = "select COUNT(*) AS Total from " + tabla + " where FECHA = @fecha";
                string q2 = "select COUNT(*) AS Total from " + tabla;

                dt = new DataTable();
                cmd = cn.CreateCommand();
                if (condicion == true)
                {
                    cmd.CommandText = (q1);
                    cmd.Parameters.AddWithValue("@fecha", fecha.ToString());
                }
                else
                {

                    cmd.CommandText = (q2);

                }


                dr = cmd.ExecuteReader();
                dt.Load(dr);

                DataRow fila = dt.Rows[0];

                total = fila["Total"].ToString();
            }
            catch
            {


            }


            return total.ToString();

        }


        public string SUM(string fecha, string cifra)
        {
            string suma = "0";



            try
            {


                dt = new DataTable();
                cmd = cn.CreateCommand();
                cmd.CommandText = ("select SUM(Total) as Total from Detalle_Factura d inner join Factura f on f.Id_Factura = d.Id_Factura where f.FECHA = @fecha");
                cmd.Parameters.AddWithValue("@fecha", fecha);
                dr = cmd.ExecuteReader();
                dt.Load(dr);
                DataRow fila = dt.Rows[0];
                int toal = int.Parse(fila["Total"].ToString());
                suma = fila["Total"].ToString();

                if (cifra == "decimal")
                {
                    try
                    {
                        suma = Convert.ToDouble(suma.ToString()).ToString("N");
                    }
                    catch
                    {



                    }
                }

                else
                {

                    suma = toal.ToString();

                }
            }
            catch
            {




            }

            return suma;

        }




        public string MASVENDIDO()
        {
            string devolver = "0";
            string total = "0";
            try
            {

                dt = new DataTable();
                cmd = cn.CreateCommand();
                cmd.CommandText = (" Select top 1  MAX(Total) as Total, Nombre_Producto from ProductosVendidos group by Nombre_Producto order by Total desc");
                dr = cmd.ExecuteReader();
                dt.Load(dr);


                DataRow filas = dt.Rows[0];

                string producto = filas["Nombre_Producto"].ToString();
                try
                {
                    total = Convert.ToDouble(filas["Total"].ToString()).ToString("N");
                }
                catch
                {


                }

                devolver = producto + " + " + total;
            }

            catch
            {

            }

            return devolver;


        }



        public string VENDEDORESTRELLA()
        {

            string devolver = "";
            try
            {
                dt = new DataTable();
                cmd = cn.CreateCommand();
                cmd.CommandText = ("TopVendedor");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fecha", DateTime.Today.ToString("yyyy/MM/dd"));
                dr = cmd.ExecuteReader();
                dt.Load(dr);
                DataRow filas = dt.Rows[0];
                string ventas = filas["Ventas"].ToString();
                string total = filas["Total"].ToString();
                string vendedor = filas["Vendedor"].ToString();

                devolver = ventas + " + " + total + " + " + vendedor;
            }
            catch
            {

                devolver = "  +   +   ";

            }

            return devolver;


        }



        public void TOPPRODUCTOS(TextBox producto1, TextBox producto2, TextBox producto3)
        {
            try
            {
                string[] nombres = new string[3];
                string[] total = new string[3];
                dt = new DataTable();
                cmd = cn.CreateCommand();
                cmd.CommandText = ("select *from TopProductosTotal");
                dr = cmd.ExecuteReader();
                dt.Load(dr);

                for (int c = 0; c <= 2; c++)
                {
                    DataRow filas = dt.Rows[c];
                    nombres[c] = filas["Nombre_Producto"].ToString();
                    total[c] = filas["Total"].ToString();


                }

                producto1.Text = nombres[0].ToString().ToUpper() + "   " + Convert.ToDouble(total[0].ToString()).ToString("N") + " Ventas";
                producto2.Text = nombres[1].ToString().ToUpper() + "   " + Convert.ToDouble(total[1].ToString()).ToString("N") + " Ventas"; ;
                producto3.Text = nombres[2].ToString().ToUpper() + "   " + Convert.ToDouble(total[2].ToString()).ToString("N") + " Ventas"; ;
            }
            catch
            {

                producto1.Text = "";
                producto2.Text = "";
                producto3.Text = "";



            }




        }




        public void TOPVENDEDORES(TextBox producto1, TextBox producto2, TextBox producto3)
        {
            try
            {
                string[] nombres = new string[3];
                string[] total = new string[3];
                dt = new DataTable();
                cmd = cn.CreateCommand();
                cmd.CommandText = ("select *from TopVendoresTotal");
                dr = cmd.ExecuteReader();
                dt.Load(dr);

                for (int c = 0; c <= 2; c++)
                {
                    DataRow filas = dt.Rows[c];
                    nombres[c] = filas["Vendedor"].ToString();
                    total[c] = filas["Total"].ToString();



                }

                producto1.Text = nombres[0].ToString().ToUpper();
                producto2.Text = nombres[1].ToString().ToUpper();
                producto3.Text = nombres[2].ToString().ToUpper();
            }
            catch
            {
                producto1.Text = "";
                producto2.Text = "";
                producto3.Text = "";


            }




        }



        public string SQLCOUNTESPETIAL(string tabla, string campo, string valor)
        {


            dt = new DataTable();
            cmd = cn.CreateCommand();
            cmd.CommandText = ("Select COUNT(*) as Total from " + tabla + " where " + campo + " = @valor");
            cmd.Parameters.AddWithValue("@valor", valor);
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            DataRow filas = dt.Rows[0];
            string total = filas["Total"].ToString();


            string devolver = total;

            return total;




        }


        public bool SQLVALIDATE(string tabla, string campo, string clave)
        {
            bool retornar;

            dt = new DataTable();
            cmd = cn.CreateCommand();
            cmd.CommandText = ("select *from " + tabla + " where " + campo + " = @clave");
            cmd.Parameters.AddWithValue("@clave", clave);
            dr = cmd.ExecuteReader();
            dt.Load(dr);

            if (dt.Rows.Count > 0)
            {



                retornar = true;

            }
            else
            {

                retornar = false;

            }

            return retornar;


        }





        public void BUSQUEDAUSERS(DataGridView dgv, string busqueda, string Tabla, string Campo, int Cantidad)
        {


            try
            {
                dt = new DataTable();
                cmd = cn.CreateCommand();
                cmd.CommandText = ("select Id_Usuario, Nombre_Completo, Email, Usuario, Fecha *from " + Tabla + " where " + Campo + " like '%" + busqueda + "%' order by " + Campo + " OFFSET 0 ROWS FETCH NEXT " + Cantidad + " ROWS ONLY   ");
                cmd.Parameters.AddWithValue("@Tabla", Tabla);
                dr = cmd.ExecuteReader();
                dt.Load(dr);
                dgv.DataSource = dt;



            }
            catch
            {



            }




        }













        public void PRODUCTODEHOY(TextBox t1, TextBox t2)
        {

            // MessageBox.Show(DateTime.Today.ToShortDateString());

            string devolver = "";
            try
            {
                dt = new DataTable();
                cmd = cn.CreateCommand();
                cmd.CommandText = ("ProductosVendidosFecha");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fecha", DateTime.Today.ToString("yyyy/MM/dd"));
                dr = cmd.ExecuteReader();
                dt.Load(dr);
                DataRow filas = dt.Rows[0];

                t2.Text = Convert.ToDouble(filas["Total"].ToString()).ToString("N") + " VENTAS";
                t1.Text = filas["Nombre_Producto"].ToString();


            }
            catch
            {

                devolver = "  +   +   ";

            }

        }


        public string insertarImagen(PictureBox pbImagen, string descripcion)
        {
            string mensaje = "Se inserto la imagen";
            try
            {
                cmd = new SqlCommand("Insert into Imagen(Foto,Descripcion) values(@Foto,@Descripcion)", cn);
                cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar);
                cmd.Parameters.Add("@Foto", SqlDbType.Image);

                cmd.Parameters["@Descripcion"].Value = descripcion;
                System.IO.MemoryStream ms = new System.IO.MemoryStream();

                pbImagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                cmd.Parameters["@Foto"].Value = ms.GetBuffer();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                mensaje = "No se inserto la imagen: " + ex.ToString();
            }
            return mensaje;



        }
    }
}

