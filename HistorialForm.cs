using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Biblioteca_final_Herramientas_1
{
    public partial class HistorialForm : Form
    {
        public HistorialForm()
        {
            InitializeComponent();
        }

        private void btnVerHistorial_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Historial de préstamos: (aquí irán los registros)");
        }

        private void btnVerHistorial_Click_1(object sender, EventArgs e)
        {
            lstHistorial.Items.Clear();

            lstHistorial.Items.Add("---- MATERIALES REGISTRADOS ----");
            foreach (var material in Servicios.ListaMateriales)
            {
                lstHistorial.Items.Add($"Título: {material.Titulo}, Autor: {material.Autor}");
            }
            lstHistorial.Items.Add("---- PRÉSTAMOS REGISTRADOS ----");
            foreach (var movimiento in Servicios.ListaMovimientos)
            {
                lstHistorial.Items.Add($"Persona: {movimiento.CodigoPersona}, Material: {movimiento.TituloLibro}, Fecha: {movimiento.Fecha}");
            }
        }
    }
}