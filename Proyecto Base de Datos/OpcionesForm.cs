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
    public partial class OpcionesForm : Form
    {
        public OpcionesForm()
        {
            InitializeComponent();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void OpcionesForm_Load(object sender, EventArgs e)
        {

        }

        private void IngresarButton_Click(object sender, EventArgs e)
        {
            IngresarForm ingresarForm = new IngresarForm();
            ingresarForm.Show();
            this.Hide();

        }
    }
}
