using System;

namespace Biblioteca_final_Herramientas_1
{
    partial class PrestamoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMaterial = new System.Windows.Forms.TextBox();
            this.txtCodigoPersona = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cbAutores = new System.Windows.Forms.ComboBox();
            this.cbMateriales = new System.Windows.Forms.ComboBox();
            this.cbPersonas = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtMaterial
            // 
            this.txtMaterial.Location = new System.Drawing.Point(59, 218);
            this.txtMaterial.Name = "txtMaterial";
            this.txtMaterial.Size = new System.Drawing.Size(100, 31);
            this.txtMaterial.TabIndex = 5;
            this.txtMaterial.Text = "Material";
            // 
            // txtCodigoPersona
            // 
            this.txtCodigoPersona.Location = new System.Drawing.Point(59, 79);
            this.txtCodigoPersona.Name = "txtCodigoPersona";
            this.txtCodigoPersona.Size = new System.Drawing.Size(160, 31);
            this.txtCodigoPersona.TabIndex = 3;
            this.txtCodigoPersona.Text = "Codigo Persona";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(59, 354);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(105, 38);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cbAutores
            // 
            this.cbAutores.FormattingEnabled = true;
            this.cbAutores.Location = new System.Drawing.Point(274, 79);
            this.cbAutores.Name = "cbAutores";
            this.cbAutores.Size = new System.Drawing.Size(121, 33);
            this.cbAutores.TabIndex = 8;
            this.cbAutores.Text = "Autores";
            this.cbAutores.SelectedIndexChanged += new System.EventHandler(this.cbAutores_SelectedIndexChanged);
            // 
            // cbMateriales
            // 
            this.cbMateriales.FormattingEnabled = true;
            this.cbMateriales.Location = new System.Drawing.Point(274, 216);
            this.cbMateriales.Name = "cbMateriales";
            this.cbMateriales.Size = new System.Drawing.Size(147, 33);
            this.cbMateriales.TabIndex = 9;
            this.cbMateriales.Text = "Materiales";
            this.cbMateriales.SelectedIndexChanged += new System.EventHandler(this.cbMateriales_SelectedIndexChanged);
            // 
            // cbPersonas
            // 
            this.cbPersonas.FormattingEnabled = true;
            this.cbPersonas.Location = new System.Drawing.Point(274, 358);
            this.cbPersonas.Name = "cbPersonas";
            this.cbPersonas.Size = new System.Drawing.Size(135, 33);
            this.cbPersonas.TabIndex = 10;
            this.cbPersonas.Text = "Personas";
            // 
            // PrestamoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbPersonas);
            this.Controls.Add(this.cbMateriales);
            this.Controls.Add(this.cbAutores);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtMaterial);
            this.Controls.Add(this.txtCodigoPersona);
            this.Name = "PrestamoForm";
            this.Text = "PrestamoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void cbMateriales_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void cbAutores_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TextBox txtMaterial;
        private System.Windows.Forms.TextBox txtCodigoPersona;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cbAutores;
        private System.Windows.Forms.ComboBox cbMateriales;
        private System.Windows.Forms.ComboBox cbPersonas;
    }
}