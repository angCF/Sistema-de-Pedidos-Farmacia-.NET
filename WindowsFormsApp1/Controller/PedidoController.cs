using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.Controller
{
    public class PedidoController
    {
        public (bool esValido, string mensajeError) ValidarPedido(PedidoModel pedido)
        {
            if (string.IsNullOrWhiteSpace(pedido.NombreMedicamento) ||
                !System.Text.RegularExpressions.Regex.IsMatch(pedido.NombreMedicamento, @"[a-zA-Z0-9]"))
                return (false, "El nombre del medicamento debe contener caracteres alfanuméricos.");

            if (string.IsNullOrWhiteSpace(pedido.TipoMedicamento))
                return (false, "Seleccione un tipo de medicamento.");

            if (pedido.Cantidad <= 0)
                return (false, "Ingrese una cantidad válida.");

            if (string.IsNullOrWhiteSpace(pedido.Distribuidor))
                return (false, "Seleccione un distribuidor.");

            if (pedido.Sucursales == null || pedido.Sucursales.Count == 0)
                return (false, "Seleccione al menos una farmacia.");

            return (true, string.Empty);
        }
    }
}

