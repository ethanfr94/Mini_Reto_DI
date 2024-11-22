using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using ProjectStore.Entities;

namespace ProjectStore
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void OnClickLogin(object sender, EventArgs e)
        {
            // Obtiene el email y contraseña del campo de texto
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            // Expresión regular para validar el formato del correo
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Verifica si algún campo está vacío
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Hay campos sin rellenar.\nPor favor, complete todos los campos.",
                                "Campos Incompletos",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                txtPassword.Text = String.Empty;
                return;
            }
            // Verifica si el correo tiene un formato válido
            else if (!Regex.IsMatch(email, emailPattern))
            {
                MessageBox.Show("El formato del correo electrónico es incorrecto.\nPor favor, ingrese un correo válido.",
                                "Formato Incorrecto",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                txtPassword.Text = String.Empty;
                return;
            }

            // Aquí se realizaría la verificación de credenciales, por ejemplo, con una API o base de datos
            txtEmail.Text = String.Empty;
            txtPassword.Text = String.Empty;

            // Abre el formulario principal en un hilo separado para evitar bloquear la UI
            Thread thread = new Thread(() =>
            {
                Application.SetCompatibleTextRenderingDefault(false);
                Application.EnableVisualStyles();

                Principal principal = new Principal(email);
                Application.Run(principal);
            });

            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            this.Close();
        }

        private void OnClickLink(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Abre la aplicación de correo predeterminada
            try
            {
                System.Diagnostics.Process.Start("mailto:" + llbContact.Text);
            }
            catch (System.ComponentModel.Win32Exception ex)
            {
                MessageBox.Show("No se pudo abrir el cliente de correo. Asegúrese de tener un cliente de correo predeterminado configurado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
