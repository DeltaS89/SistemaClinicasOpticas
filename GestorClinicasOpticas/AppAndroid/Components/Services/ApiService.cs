using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using AppAndroid.Components.Model;
using AppAndroid.Components.Constant;
using System.Text;

namespace AppAndroid.Components.Services
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;

        public ApiService()
        {
            _httpClient = new HttpClient();
        }

        // Métodos para Doctores
        public async Task<bool> AgregarDoctorAsync(Doctor doctor)
        {
            var url = $"{ApiUrls.BaseUrl}/Doctores";
            var json = JsonConvert.SerializeObject(doctor);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(url, content);

            return response.IsSuccessStatusCode;
        }

        public async Task<List<Doctor>> GetDoctoresAsync()
        {
            var url = $"{ApiUrls.BaseUrl}/Doctores";
            var response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<Doctor>>(json);
            }
            else
            {
                // Puedes manejar errores o lanzar una excepción si es necesario.
                return new List<Doctor>();
            }
        }

        public async Task<bool> EliminarDoctorAsync(int id)
        {
            var url = $"{ApiUrls.BaseUrl}/Doctores/{id}";
            var response = await _httpClient.DeleteAsync(url);

            return response.IsSuccessStatusCode;
        }

        public async Task<bool> ModificarDoctorAsync(Doctor doctor)
        {
            var url = $"{ApiUrls.BaseUrl}/Doctores/{doctor.Id}";
            var json = JsonConvert.SerializeObject(doctor);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PutAsync(url, content);

            return response.IsSuccessStatusCode;
        }

        // Métodos para Pacientes
        public async Task<bool> AgregarPacienteAsync(Paciente paciente)
        {
            var url = $"{ApiUrls.BaseUrl}/Pacientes";
            var json = JsonConvert.SerializeObject(paciente);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(url, content);

            return response.IsSuccessStatusCode;
        }

        public async Task<List<Paciente>> GetPacientesAsync()
        {
            var url = $"{ApiUrls.BaseUrl}/Pacientes";
            var response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<Paciente>>(json);
            }
            else
            {
                // Puedes manejar errores o lanzar una excepción si es necesario.
                return new List<Paciente>();
            }
        }

        public async Task<bool> EliminarPacienteAsync(int id)
        {
            var url = $"{ApiUrls.BaseUrl}/Pacientes/{id}";
            var response = await _httpClient.DeleteAsync(url);

            return response.IsSuccessStatusCode;
        }

        public async Task<bool> ModificarPacienteAsync(Paciente paciente)
        {
            var url = $"{ApiUrls.BaseUrl}/Pacientes/{paciente.Id}";
            var json = JsonConvert.SerializeObject(paciente);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PutAsync(url, content);

            return response.IsSuccessStatusCode;
        }

        // Métodos para Examenes
        public async Task<bool> AgregarExamenAsync(Examen examen)
        {
            var url = $"{ApiUrls.BaseUrl}/Examenes";
            var json = JsonConvert.SerializeObject(examen);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(url, content);

            return response.IsSuccessStatusCode;
        }

        public async Task<List<Examen>> GetExamenesAsync()
        {
            var url = $"{ApiUrls.BaseUrl}/Examenes";
            var response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<Examen>>(json);
            }
            else
            {
                // Puedes manejar errores o lanzar una excepción si es necesario.
                return new List<Examen>();
            }
        }

        public async Task<bool> EliminarExamenAsync(int id)
        {
            var url = $"{ApiUrls.BaseUrl}/Examenes/{id}";
            var response = await _httpClient.DeleteAsync(url);

            return response.IsSuccessStatusCode;
        }

        public async Task<bool> ModificarExamenAsync(Examen examen)
        {
            var url = $"{ApiUrls.BaseUrl}/Examenes/{examen.Id}";
            var json = JsonConvert.SerializeObject(examen);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PutAsync(url, content);

            return response.IsSuccessStatusCode;
        }
    }
}
