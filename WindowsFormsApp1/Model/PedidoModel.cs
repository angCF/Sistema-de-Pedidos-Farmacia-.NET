using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    public class PedidoModel
    {
        public string NombreMedicamento { get; set; }
        public string TipoMedicamento { get; set; }
        public int Cantidad { get; set; }
        public string Distribuidor { get; set; }
        public List<string> Sucursales { get; set; }
    }

}
