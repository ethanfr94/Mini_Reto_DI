using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

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
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Hay campos sin rellenar.\nPor favor, complete todos los campos.",
                                "Campos Incompletos",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }
            else if (!Regex.IsMatch(email, emailPattern))
            {
                MessageBox.Show("El formato del correo electrónico es incorrecto.\nPor favor, ingrese un correo válido.",
                                "Formato Incorrecto",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            // Aquí iria otro "else if" para verificar las credenciales con las de la API


            // Autenticación exitosa: abre el formulario principal en otro hilo
            Thread thread = new Thread(() =>
            {
                Application.SetCompatibleTextRenderingDefault(false);
                Application.EnableVisualStyles();

                Principal principal = new Principal(email);
                Application.Run(principal);
            });

            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();

            // Cierra el formulario actual (Login)
            this.Close();
        }
    }
}
