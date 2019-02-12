using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Facturacion
{
    class Configuracion
    {

        public int Id_Configuracion { get; set; }
        public string Nombre_Empresa { get; set; }
        public string Direccion_Empresa { get; set; }
        public string Email { get; set; }
        public string NCI { get; set; }
        public string Telefono { get; set; }
        public Decimal IVA { get; set; }
        public string Pie_Pagina { get; set; }
        public string Estado { get; set; }

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




    }
}
