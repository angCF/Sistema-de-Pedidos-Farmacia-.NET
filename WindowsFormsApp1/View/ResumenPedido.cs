using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1
{
    public partial class ResumenPedido : Form
    {
        public ResumenPedido(PedidoModel pedido)
        {
            InitializeComponent();
            this.Text = $"Pedido al distribuidor {pedido.Distribuidor}";

            string linea1 = $"{pedido.Cantidad} unidades del {pedido.TipoMedicamento} {pedido.NombreMedicamento}";
            string linea2 = "Para la farmacia situada en " + string.Join(" y para la situada en ", pedido.Sucursales);

            pedidoDistribuidor.Text = $"{linea1}\n{linea2}";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pedido enviado", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
