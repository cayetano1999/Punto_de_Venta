using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Facturacion
{
    class Producto
    {


        public int Codigo_Producto { get; set; }

        public string Descripcion { get; set; }

        public double Precio  {get; set;}

        public int Existencias { get; set; }

        public double PIVA  {get; set; }

        public DateTime Fecha { get; set; }

        public int Id_Proveedor { get; set; }

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

        
       

    }
}
