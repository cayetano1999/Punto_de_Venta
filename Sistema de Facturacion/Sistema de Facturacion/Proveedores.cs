using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Facturacion
{
    class Proveedores
    {

        public int Id_Proveedor { get; set; }
        public string Empresa { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Representante { get; set; }
        public string Direccion { get; set; }
        public string Tipo_Proveedor { get; set; }

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
}
