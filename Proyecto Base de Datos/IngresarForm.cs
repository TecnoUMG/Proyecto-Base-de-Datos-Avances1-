using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Base_de_Datos
{
    public partial class IngresarForm : Form
    {
        public IngresarForm()
        {
            InitializeComponent();
        }

        private void lblNombreProducto_Click(object sender, EventArgs e)
        {

        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            // Busca todos los TextBox en el formulario
            var cajasVacias = this.Controls.OfType<TextBox>().Where(tb => string.IsNullOrWhiteSpace(tb.Text)).ToList();

            if (cajasVacias.Any())
            {
                MessageBox.Show("Hay campos vacíos. Por favor, completa todos los datos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Ingresado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Aquí puedes agregar la lógica para guardar los datos
            }
        }

        private void IngresarForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            OpcionesForm opcionesForm = new OpcionesForm();
            opcionesForm.Show();
            this.Hide();
        }
    }
}
