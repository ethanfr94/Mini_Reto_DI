using MiniReto_interfaz_principal;
using Newtonsoft.Json;
using ProyectoIntermodular.Clases;
using ProyectoIntermodular.Formularios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
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

        public async Task<List<Incidencias>> GetIncidencias()
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


        public async Task<Profesor> ObtenerProfesor()
        {
            try
            {
                // Formar la URL con el ID de la incidencia
                string url = $"http://localhost:4000/obtenerProfesores";

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


    }

}

