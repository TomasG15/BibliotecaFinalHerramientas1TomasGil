using System;
using System.Windows.Forms;

namespace Biblioteca_final_Herramientas_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPersonas_Click(object sender, EventArgs e)
        {
            RegistrarPersonaForm form = new RegistrarPersonaForm();
            form.ShowDialog();
        }

        private void btnMateriales_Click(object sender, EventArgs e)
        {
            RegistrarMaterialForm form = new RegistrarMaterialForm();
            form.ShowDialog();
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            PrestamoForm form = new PrestamoForm();
            form.ShowDialog();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            HistorialForm form = new HistorialForm();
            form.ShowDialog();
        }
    }
}