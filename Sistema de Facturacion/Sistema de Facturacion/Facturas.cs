using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Facturacion
{
    class Facturas
    {

       public int  Id_Factura {get; set;}
       public DateTime FECHA {get; set;}
       public int FK_IdUsuario {get; set;}
       public int FK_IdCliente {get; set;}
       public string Tipo_Pago { get; set; }

       internal Clientes Clientes
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
}
