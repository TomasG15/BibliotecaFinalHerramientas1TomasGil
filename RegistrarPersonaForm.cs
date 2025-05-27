using System;
using System.Windows.Forms;

namespace Biblioteca_final_Herramientas_1
{
    public partial class RegistrarPersonaForm : Form
    {
        public RegistrarPersonaForm()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string codigo = txtCodigo.Text;

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(codigo))
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return;
            }

            MessageBox.Show("Persona registrada con éxito: " + nombre + " (" + codigo + ")");
            txtNombre.Clear();
            txtCodigo.Clear();
        }

        private void btnGuardar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            string codigoPersona = txtCodigo.Text;
            string material = txtCodigo.Text;

            Prestamo nuevoPrestamo = new Prestamo(codigoPersona, material, DateTime.Now);
            Servicios.ListaMovimientos.Add(nuevoPrestamo);

            MessageBox.Show("Préstamo registrado correctamente.");

        }
    }
    }

