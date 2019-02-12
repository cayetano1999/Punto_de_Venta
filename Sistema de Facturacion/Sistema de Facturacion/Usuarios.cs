using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Facturacion
{
    public class Usuarios
    {

        public int Id_Usuario { get; set; }
        public string Email { get; set; }
        public string Nombre_Completo {get; set;}
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public DateTime Fecha { get; set; }
        public string Tipo_Usuario { get; set; }

        internal LoadData LoadData
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
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


        



    }
}
