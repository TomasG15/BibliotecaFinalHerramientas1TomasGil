using System;
using System.Windows.Forms;

namespace Biblioteca_final_Herramientas_1
{
    public partial class PrestamoForm : Form
    {
        public PrestamoForm()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            cbPersonas.DataSource = Servicios.ObtenerPersonas();
            cbPersonas.DisplayMember = "Nombre";
            cbPersonas.ValueMember = "Codigo";

            cbMateriales.SelectedIndexChanged -= cbMateriales_SelectedIndexChanged;
            cbMateriales.DataSource = Servicios.ObtenerMateriales();
            cbMateriales.SelectedIndexChanged += cbMateriales_SelectedIndexChanged;

            var autores = Servicios.ObtenerAutores();
            cbAutores.DataSource = Servicios.ObtenerAutores();
            cbAutores.DisplayMember = "Nombre";
            cbAutores.ValueMember = "Codigo";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cbPersonas.SelectedItem == null || cbMateriales.SelectedItem == null || cbAutores.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una persona, un material y un autor.");
                return;
            }

            int codigoPersona = (int)cbPersonas.SelectedValue;
            string nombrePersona = cbPersonas.Text;
            string tituloLibro = cbMateriales.Text;
            string autor = cbAutores.Text;

            Prestamo nuevoPrestamo = new Prestamo(codigoPersona, nombrePersona, tituloLibro, autor, DateTime.Now);
            Servicios.GuardarPrestamo(nuevoPrestamo);

            MessageBox.Show("Préstamo guardado correctamente.");
        }
    }
}





