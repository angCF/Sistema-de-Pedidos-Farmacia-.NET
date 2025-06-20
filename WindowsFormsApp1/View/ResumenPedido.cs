using System;
using System.Windows.Forms;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1
{
    public partial class ResumenPedido : Form
    {
        private Pedido formPedido;
        public ResumenPedido(PedidoModel pedido, Pedido formPedido)
        {
            InitializeComponent();
            this.formPedido = formPedido;
            this.Text = $"Pedido al distribuidor {pedido.Distribuidor}";

            string linea1 = $"{pedido.Cantidad} unidades del {pedido.TipoMedicamento} {pedido.NombreMedicamento}";
            string linea2 = "Para la farmacia situada en: ";
            string linea3 = string.Join(" y para la situada en ", pedido.Sucursales);

            pedidoDistribuidor.Text = $"{linea1}\n\n{linea2}\n\n{linea3}";
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
            formPedido.limpiarFormulario();
            this.Close();


        }

        private void ResumenPedido_Load(object sender, EventArgs e)
        {

        }
    }
}
