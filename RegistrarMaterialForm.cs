using System;
using System.Collections.Generic;
using System.Windows.Forms;




namespace Biblioteca_final_Herramientas_1
{
    public partial class RegistrarMaterialForm : Form
    {
        private readonly Material nuevoMaterial;

        public RegistrarMaterialForm()
        {
            Material nuevo = new Material("Nuevo libro", "Alguien", "1"); // Constructor requires 3 arguments
            Servicios.GuardarMaterial(nuevo);
            List<Material> lista = Servicios.ObtenerMateriales();
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text;
            string autor = txtAutor.Text;

            if (string.IsNullOrWhiteSpace(titulo) || string.IsNullOrWhiteSpace(autor))
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return;
            }

            MessageBox.Show("Material registrado: " + titulo + " de " + autor);
            txtTitulo.Clear();
            txtAutor.Clear();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text;
            string autor = txtAutor.Text;

            if (string.IsNullOrWhiteSpace(titulo) || string.IsNullOrWhiteSpace(autor))
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return;
            }

            Material nuevoMaterial = new Material(titulo, autor, Guid.NewGuid().ToString()); // Pass required arguments

            Servicios.GuardarMaterial(nuevoMaterial); // Save the material

            MessageBox.Show("Material guardado correctamente.");
            txtTitulo.Clear();
            txtAutor.Clear();
        }
    }
    }

