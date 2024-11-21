namespace MiniReto_interfaz_principal
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }


        private void tsmiVerCiclos_Click(object sender, EventArgs e)
        {
            ltvListaPrincipal.Items.Clear();
            ltvListaPrincipal.Columns.Clear();
            ltvListaPrincipal.Columns.Add("Codigo", 35);
            ltvListaPrincipal.Columns.Add("Ciclo", 100);
            ltvListaPrincipal.Columns.Add("Etapa", 50);
            ltvListaPrincipal.Columns.Add("Titulo", 100);
            ltvListaPrincipal.Columns.Add("Curriculo", 100);
            ltvListaPrincipal.Columns.Add("Familia", 100);

        }

        private void tsmiVerProfesores_Click(object sender, EventArgs e)
        {
            ltvListaPrincipal.Items.Clear();
            ltvListaPrincipal.Columns.Clear();
            ltvListaPrincipal.Columns.Add("Id", 25);
            ltvListaPrincipal.Columns.Add("Nombre", 100);
            ltvListaPrincipal.Columns.Add("Apellidos", 100);
            ltvListaPrincipal.Columns.Add("Dni", 100);
            ltvListaPrincipal.Columns.Add("Email", 100);
            ltvListaPrincipal.Columns.Add("Contraseña", 100);
            ltvListaPrincipal.Columns.Add("Telefono", 100);
            ltvListaPrincipal.Columns.Add("Genero", 25);
            ltvListaPrincipal.Columns.Add("Fecha de Nacimiento", 100);
            ltvListaPrincipal.Columns.Add("Especialidad", 100);
            ltvListaPrincipal.Columns.Add("Activo", 25);
            ltvListaPrincipal.Columns.Add("Admin", 25);
        }

        private void tsmiVerAlumnos_Click(object sender, EventArgs e)
        {
            ltvListaPrincipal.Items.Clear();
            ltvListaPrincipal.Columns.Clear();
            ltvListaPrincipal.Columns.Add("Id", 25);
            ltvListaPrincipal.Columns.Add("Nombre", 100);
            ltvListaPrincipal.Columns.Add("Apellidos", 100);
            ltvListaPrincipal.Columns.Add("Dni", 100);
            ltvListaPrincipal.Columns.Add("Email", 100);
            ltvListaPrincipal.Columns.Add("Contraseña", 100);
            ltvListaPrincipal.Columns.Add("Telefono", 100);
            ltvListaPrincipal.Columns.Add("Genero", 35);
            ltvListaPrincipal.Columns.Add("Fecha de Nacimiento", 100);
            ltvListaPrincipal.Columns.Add("Activo", 25);
            ltvListaPrincipal.Columns.Add("Admin", 25);
        }

        private void verProyectosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ltvListaPrincipal.Items.Clear();
            ltvListaPrincipal.Columns.Clear();
            ltvListaPrincipal.Columns.Add("Id", 35);
            ltvListaPrincipal.Columns.Add("Nombre", 100);
            ltvListaPrincipal.Columns.Add("Tipo", 100);
            ltvListaPrincipal.Columns.Add("Resumen", 100);
            ltvListaPrincipal.Columns.Add("Año Academico", 100);
            ltvListaPrincipal.Columns.Add("Fecha Presentacion", 100);
            ltvListaPrincipal.Columns.Add("Logo", 100);
            ltvListaPrincipal.Columns.Add("Memoria", 100);
            ltvListaPrincipal.Columns.Add("Archivos", 100);
            ltvListaPrincipal.Columns.Add("Comentarios", 100);
            ltvListaPrincipal.Columns.Add("Ciclo", 35);
            ltvListaPrincipal.Columns.Add("Tutor", 35);
        }
    }
}
