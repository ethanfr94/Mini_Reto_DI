using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;


namespace ProjectStore
{
    internal class ConexionApi
    {
        private HttpClient client;

        public ConexionApi()
        {
            client = new HttpClient();
        }

        public async Task<Profesor> ProfesorporCorreoPassword(string correo, string password)
        {
            try
            {
                HttpClient client = new HttpClient();
                string encodedCorreo = System.Web.HttpUtility.UrlEncode(correo);
                string encodedPassword = System.Web.HttpUtility.UrlEncode(password);
                string url = $"http://localhost:4000/profesores/email/{encodedCorreo}?contraseña={encodedPassword}";

                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string responseJson = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Profesor>(responseJson);
            }
            catch
            {
                return null;
            }
        }



        /*    public async Task<List<Incidencias>> GetIncidencias()
            {
                try
                {
                    // Cambiar por  ip de  equipo

                    // ip 10.0.22.11
                    HttpResponseMessage response = await client.GetAsync("http://10.0.22.11:8080/api/incidencias");
                    response.EnsureSuccessStatusCode();

                    string responseJson = await response.Content.ReadAsStringAsync();

                    List<Incidencias> incidencias = JsonConvert.DeserializeObject<List<Incidencias>>(responseJson);
                    return incidencias;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Se produjo un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }

            public async Task<bool> ActualizarIncidencia(int id, Incidencias incidencia)
            {
                try
                {
                    // Convertir el objeto incidencia a formato JSON
                    string jsonData = JsonConvert.SerializeObject(incidencia);
                    StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                    // Realizar la solicitud PUT
                    HttpResponseMessage response = await client.PutAsync($"http://localhost:8080/api/incidencias/{id}", content);
                    response.EnsureSuccessStatusCode();

                    // La incidencia se actualizó correctamente
                    return true;
                }
                catch (Exception)
                {
                    // Hubo un error al actualizar la incidencia
                    return false;
                }
            }
        */

        public async Task<List<Profesor>> ProfesorporCorreo(String correo, String password)
        {
            try
            {
                // Cambiar por  ip de  equipo

                // ip 10.0.22.11
                HttpResponseMessage response = await client.GetAsync($"http://localhost:4000/profesores/email/{correo}");
                response.EnsureSuccessStatusCode();
                string responseJson = await response.Content.ReadAsStringAsync();
                List<Profesor> profesor = JsonConvert.DeserializeObject<List<Profesor>>(responseJson);
                return profesor;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se produjo un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public async Task<List<Profesor>> ObtenerProfesor()
        {
            try
            {
                // Formar la URL con el ID de la incidencia
                string url = "http://localhost:4000/profesores";
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseJson = await response.Content.ReadAsStringAsync();
                List<Profesor> profesores = JsonConvert.DeserializeObject<List<Profesor>>(responseJson);
                return profesores;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public async Task<Profesor> ObtenerProfesorIndividual(int id)
        {
            try
            {
                // Formar la URL con el ID de la incidencia
                string url = $"http://localhost:4000/profesores/{id}";
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseJson = await response.Content.ReadAsStringAsync();
                Profesor profesor = JsonConvert.DeserializeObject<Profesor>(responseJson);
                return profesor;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public async Task<Proyecto> ObtenerProyectoIndividual(int id)
        {
            try
            {
                // Formar la URL con el ID de la incidencia
                string url = $"http://localhost:4000/proyectos/idproyecto/{id}";
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseJson = await response.Content.ReadAsStringAsync();
                Proyecto proyecto = JsonConvert.DeserializeObject<Proyecto>(responseJson);
                return proyecto;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public async Task<List<Proyecto>> ObtenerProyectos()
        {
            try
            {
                // Cambiar por  ip de  equipo

                // ip 10.0.22.11
                HttpResponseMessage response = await client.GetAsync($"http://localhost:4000/proyectos");
                response.EnsureSuccessStatusCode();

                string responseJson = await response.Content.ReadAsStringAsync();

                List<Proyecto> proyectos = JsonConvert.DeserializeObject<List<Proyecto>>(responseJson);
                return proyectos;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se produjo un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public async Task<Alumno> ObtenerAlumnoindividual(int id)
        {
            try
            {
                // Cambiar por  ip de  equipo

                // ip 10.0.22.11
                HttpResponseMessage response = await client.GetAsync($"http://localhost:4000/alumnos/{id}");
                response.EnsureSuccessStatusCode();

                string responseJson = await response.Content.ReadAsStringAsync();

                Alumno alumno = JsonConvert.DeserializeObject<Alumno>(responseJson);
                return alumno;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se produjo un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public async Task<List<Alumno>> ObtenerAlumnos()
        {
            try
            {
                // Cambiar por  ip de  equipo

                // ip 10.0.22.11
                HttpResponseMessage response = await client.GetAsync("http://localhost:4000/alumnos");
                response.EnsureSuccessStatusCode();

                string responseJson = await response.Content.ReadAsStringAsync();

                List<Alumno> alumnos = JsonConvert.DeserializeObject<List<Alumno>>(responseJson);
                return alumnos;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se produjo un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public async Task<Ciclo> ObtenerCiclosindividual(int id)
        {
            try
            {
                // Cambiar por  ip de  equipo

                // ip 10.0.22.11
                HttpResponseMessage response = await client.GetAsync($"http://localhost:4000/ciclos/codciclos/{id}");
                response.EnsureSuccessStatusCode();

                string responseJson = await response.Content.ReadAsStringAsync();

                Ciclo ciclo = JsonConvert.DeserializeObject<Ciclo>(responseJson);
                return ciclo;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se produjo un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public async Task<List<Ciclo>> ObtenerCiclos()
        {
            try
            {
                // Cambiar por  ip de  equipo
                // ip 10.0.22.11
                HttpResponseMessage response = await client.GetAsync("http://localhost:4000/ciclos");
                response.EnsureSuccessStatusCode();

                string responseJson = await response.Content.ReadAsStringAsync();

                List<Ciclo> ciclos = JsonConvert.DeserializeObject<List<Ciclo>>(responseJson);
                return ciclos;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se produjo un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public async Task<bool> ActualizarProyecto(int id, Proyecto proyecto)
        {
            try
            {
                // Convertir el objeto incidencia a formato JSON
                string jsonData = JsonConvert.SerializeObject(proyecto);
                StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                // Realizar la solicitud PUT
                HttpResponseMessage response = await client.PutAsync($"http://localhost:4000/actualizarProyecto{id}", content);
                response.EnsureSuccessStatusCode();

                // La incidencia se actualizó correctamente
                return true;
            }
            catch (Exception)
            {
                // Hubo un error al actualizar la incidencia
                return false;
            }
        }

    }

}

