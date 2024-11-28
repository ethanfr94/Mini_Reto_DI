﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ProjectStore
{
    internal class APIConnection
    {
        private readonly HttpClient client;

        public APIConnection()
        {
            client = new HttpClient();
        }

        // ===== Métodos de Alumno =====

        // Obtiene un alumno por su ID.
        public async Task<Alumno> GetAlumnoById(string id)
        {
            try
            {
                string url = $"http://localhost:4000/alumnos/{id}";
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string responseJson = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Alumno>(responseJson) ?? null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        // Obtiene todos los alumnos.
        public async Task<List<Alumno>> GetAllAlumnos()
        {
            try
            {
                string url = "http://localhost:4000/alumnos";
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string responseJson = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<Alumno>>(responseJson) ?? new List<Alumno>();
            }
            catch (Exception)
            {
                return null;
            }
        }

        // Inserta un nuevo alumno.
        public async Task<bool> PostAlumno(Alumno alumno)
        {
            return await PostEntity("http://localhost:4000/alumnos", alumno);
        }

        // Actualiza un alumno.
        public async Task<bool> UpdateAlumno(Alumno alumno)
        {
            return await UpdateEntity($"http://localhost:4000/alumnos/{alumno}", alumno);
        }

        // ===== Métodos de Profesor =====

        // Obtiene un profesor por correo y contraseña.
        public async Task<Profesor> GetProfesorByCredentials(string correo, string password)
        {
            try
            {
                string url = $"http://localhost:4000/profesores/email/{correo}?contraseña={password}";
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string responseJson = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Profesor>(responseJson) ?? null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        // Obtiene todos los profesores.
        public async Task<List<Profesor>> GetAllProfesores()
        {
            try
            {
                string url = "http://localhost:4000/profesores";
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string responseJson = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<Profesor>>(responseJson) ?? new List<Profesor>();
            }
            catch (Exception)
            {
                return null;
            }
        }

        // Obtiene un profesor por su ID.
        public async Task<Profesor> GetProfesorById(string id)
        {
            try
            {
                string url = $"http://localhost:4000/profesores/{id}";
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string responseJson = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Profesor>(responseJson) ?? null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        // Inserta un nuevo profesor.
        public async Task<bool> PostProfesor(Profesor profesor)
        {
            return await PostEntity("http://localhost:4000/profesores", profesor);
        }

        // Actualiza un profesor.
        public async Task<bool> UpdateProfesor(Profesor profesor)
        {
            return await UpdateEntity($"http://localhost:4000/profesores/{profesor}", profesor);
        }

        // ===== Métodos de Ciclo =====

        // Obtiene un ciclo por su ID.
        public async Task<Ciclo> GetCicloById(string id)
        {
            try
            {
                string url = $"http://localhost:4000/ciclos/codciclos/{id}";
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string responseJson = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Ciclo>(responseJson) ?? null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        // Obtiene todos los ciclos.
        public async Task<List<Ciclo>> GetAllCiclos()
        {
            try
            {
                string url = "http://localhost:4000/ciclos";
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string responseJson = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<Ciclo>>(responseJson) ?? new List<Ciclo>();
            }
            catch (Exception)
            {
                return null;
            }
        }

        // ===== Métodos de Proyecto =====

        // Obtiene un proyecto por su ID.
        public async Task<Proyecto> GetProyectoById(string id)
        {
            try
            {
                string url = $"http://localhost:4000/proyectos/idproyecto/{id}";
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string responseJson = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Proyecto>(responseJson) ?? null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        // Obtiene todos los proyectos.
        public async Task<List<Proyecto>> GetAllProyectos()
        {
            try
            {
                string url = "http://localhost:4000/proyectos";
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string responseJson = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<Proyecto>>(responseJson) ?? new List<Proyecto>();
            }
            catch (Exception)
            {
                return null;
            }
        }

        // Inserta un nuevo proyecto.
        public async Task<bool> PostProyecto(Proyecto proyecto)
        {
            var client = new HttpClient();
            var jsonContent = JsonConvert.SerializeObject(proyecto);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            try
            {
                var response = await client.PostAsync("http://localhost:4000/proyectos", content);
                response.EnsureSuccessStatusCode(); // Lanza una excepción si el código de respuesta no es exitoso
                return true;
            }
            catch (HttpRequestException e)
            {
                // Captura la excepción y maneja el error adecuadamente
                MessageBox.Show("Error al enviar la solicitud: " + e.Message);
                return false;
            }
        }

        // Actualiza un proyecto.
        public async Task<bool> UpdateProyecto(Proyecto proyecto)
        {
            return await UpdateEntity($"http://localhost:4000/proyectos/{proyecto}", proyecto);
        }

        // ===== Métodos Genéricos =====

        // Método genérico para actualizar una entidad.
        private async Task<bool> UpdateEntity<T>(string url, T entidad)
        {
            try
            {
                string jsonData = JsonConvert.SerializeObject(entidad);
                StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PutAsync(url, content);
                response.EnsureSuccessStatusCode();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Método genérico para insertar una entidad.
        private async Task<bool> PostEntity<T>(string url, T entidad)
        {
            try
            {
                string jsonData = JsonConvert.SerializeObject(entidad);
                StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(url, content);
                response.EnsureSuccessStatusCode();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<String> GetLogo(int id_proyecto, string etapa_proyecto)
        {
            try
            {
                string url = $"http://localhost:4000/proyectos/ficheros?idProyecto={id_proyecto}&tipo={etapa_proyecto}";
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string responseJson = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<String>(responseJson);
            }
            catch (Exception)
            {
                return null;
            }
        }
        public async Task<bool> ModLogo(int id_proyecto)
        {
            try
            {
                string jsonData = JsonConvert.SerializeObject(id_proyecto);
                StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PutAsync($"http://localhost:4000/proyectos/ficheros?idProyecto={id_proyecto}", content);
                response.EnsureSuccessStatusCode();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
