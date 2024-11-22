using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectStore.Entities;

namespace ProjectStore
{
    public partial class AddProfesor : Form
    {
        public AddProfesor()
        {
            InitializeComponent();
            cargaComboGenero();    // Carga los géneros en el combo
        }

        // Carga los géneros del enum al combo
        private void cargaComboGenero()
        {
            foreach (Genero genero in Enum.GetValues(typeof(Genero)))
            {
                cmbGenero.Items.Add(genero);
            }
        }

        // Guarda los datos del profesor y lo añade a la lista
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (new[] { txtNombre.Text, txtApellidos.Text, txtDni.Text, txtEmail.Text, txtContraseña.Text, cmbGenero.Text }.Any(c => string.IsNullOrWhiteSpace(c)))
            {
                MessageBox.Show("Faltan campos por rellenar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Profesor profesor = new Profesor
                {
                    Nombre = txtNombre.Text,
                    Apellidos = txtApellidos.Text,
                    Dni = txtDni.Text,
                    Email = txtEmail.Text,
                    Contraseña = txtContraseña.Text,
                    Telefono = txtTelefono.Text,
                    Genero = (Genero) cmbGenero.SelectedItem,
                    FechaNacimiento = dtpFechaNac.Value,
                    Especialidad = txtEspecialidad.Text,
                    Activo = true
                };
                Principal.profesores.Add(profesor);
                DialogResult = DialogResult.OK;
            }
        }

        // Cierra el formulario sin guardar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
