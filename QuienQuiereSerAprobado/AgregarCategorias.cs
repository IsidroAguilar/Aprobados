using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuienQuiereSerAprobado
{
    public partial class AgregarCategorias : Form
    {
        public AgregarCategorias()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var categoria = txtCategoria.Text;
            if (categoria != "")
            {
                listBoxCategorias.Items.Add(categoria);
                txtCategoria.Clear();
            }
            else
                MessageBox.Show("Ingrese una nueva categoria o continue a la siguiente ventana", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            listBoxCategorias.Items.Remove(listBoxCategorias.SelectedItem);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AgregarPreguntas nextForm = new AgregarPreguntas();
            nextForm.Show();
            this.Hide();
        }
    }
}
