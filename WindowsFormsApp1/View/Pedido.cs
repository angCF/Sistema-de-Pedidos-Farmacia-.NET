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

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    // Validar nombre del medicamento
        //    if (string.IsNullOrWhiteSpace(nombreMedicamento.Text) || !System.Text.RegularExpressions.Regex.IsMatch(nombreMedicamento.Text, @"[a-zA-Z0-9]"))
        //    {
        //        MessageBox.Show("El nombre del medicamento debe contener caracteres alfanuméricos.", "Campo inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        nombreMedicamento.Focus();
        //        return;
        //    }

        //    // Validar selección en el ComboBox
        //    if (tipoMedicamento.SelectedIndex == -1)
        //    {
        //        MessageBox.Show("Debe seleccionar un tipo de medicamento.", "Campo obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        tipoMedicamento.Focus();
        //        return;
        //    }

        //    // Validar que cantidad no esté vacía y sea un número positivo
        //    if (string.IsNullOrWhiteSpace(cantidad.Text) || !int.TryParse(cantidad.Text, out int cantidadValor) || cantidadValor <= 0)
        //    {
        //        MessageBox.Show("Ingrese una cantidad válida.", "Campo obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        cantidad.Focus();
        //        return;
        //    }

        //    // Validar que se haya seleccionado al menos un RadioButton en groupBoxDistribuidor
        //    bool radioSeleccionado = groupBoxDistribuidor.Controls
        //        .OfType<RadioButton>()
        //        .Any(rb => rb.Checked);

        //    if (!radioSeleccionado)
        //    {
        //        MessageBox.Show("Debe seleccionar un distribuidor.", "Campo obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }

        //    // Validar que al menos un CheckBox esté seleccionado en el GroupBox
        //    if (!checkBoxPrincipal.Checked && !checkBoxSecundaria.Checked)
        //    {
        //        MessageBox.Show("Debe seleccionar al menos una opción de distribuidor.", "Campo obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }

        //    // Si todo es válido:
        //    MessageBox.Show("Todos los datos están correctos.", "Validación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //}

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

            var resumen = new ResumenPedido(pedido);
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
            // Limpiar TextBox
            nombreMedicamento.Clear();
            cantidad.Clear();

            // Resetear ComboBox
            tipoMedicamento.SelectedIndex = -1;

            // Desmarcar RadioButtons del groupBoxDistribuidor
            foreach (RadioButton rb in groupBoxDistribuidor.Controls.OfType<RadioButton>())
            {
                rb.Checked = false;
            }

            // Desmarcar CheckBoxes
            checkBoxPrincipal.Checked = false;
            checkBoxSecundaria.Checked = false;

            // Opcional: devolver el foco al primer campo
            nombreMedicamento.Focus();
        }

    }
}
