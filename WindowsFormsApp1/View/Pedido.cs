using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Controller;
using WindowsFormsApp1.Model;


namespace WindowsFormsApp1
{
    public partial class Pedido : Form
    {
        public Pedido()
        {
            InitializeComponent();
            this.Text = "Formulario de Pedidos";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var pedido = new PedidoModel
            {
                NombreMedicamento = nombreMedicamento.Text.Trim(),
                TipoMedicamento = tipoMedicamento.Text,
                Cantidad = int.TryParse(cantidad.Text, out int cant) ? cant : 0,
                Distribuidor = groupBoxDistribuidor.Controls
                                .OfType<RadioButton>()
                                .FirstOrDefault(r => r.Checked)?.Text,
                Sucursales = new List<string>()
            };

            if (checkBoxPrincipal.Checked)
                pedido.Sucursales.Add("Calle de la Rosa n. 28");
            if (checkBoxSecundaria.Checked)
                pedido.Sucursales.Add("Calle Alcazabilla n. 3");

            var controller = new PedidoController();
            var (esValido, mensajeError) = controller.ValidarPedido(pedido);

            if (!esValido)
            {
                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var resumen = new ResumenPedido(pedido, this);
            resumen.ShowDialog();
        }



        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            this.limpiarFormulario();
        }
        public void limpiarFormulario()
        {
            nombreMedicamento.Clear();
            cantidad.Clear();

            tipoMedicamento.SelectedIndex = -1;

            foreach (RadioButton rb in groupBoxDistribuidor.Controls.OfType<RadioButton>())
            {
                rb.Checked = false;
            }

            checkBoxPrincipal.Checked = false;
            checkBoxSecundaria.Checked = false;

            nombreMedicamento.Focus();
        }

        private void tipoMedicamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
