using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Facturacion
{
    class DetalleFactura
    {



    public int  Id_DetalleFactura  {get; set;}
    public int Id_Factura { get; set; }
	public int Codigo_Producto {get; set;}
	public string Nombre_Producto {get; set;}
	public int Cantidad {get; set;}
	public int Precio {get; set;}
	public int Total{get; set;}

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
   


    }

    public class Detalle_Factura
    {
    }

    public class Class1
    {
    }
}
