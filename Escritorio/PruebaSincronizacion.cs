using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Negocio;
using Entidades;

namespace Escritorio
{
    public partial class PruebaSincronizacion : Form
    {
        public PruebaSincronizacion()
        {
            InitializeComponent();
        }

        private async void btnSincronizar_Click(object sender, EventArgs e)
        {
            /*HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:8080/");
            HttpResponseMessage response = client.GetAsync("Animals").Result;
            var animales = response.Content.ReadAsStreamAsync().Result;*/
            ComunicacionApi comApi = new ComunicacionApi();

            var Url = "http://localhost:8080/api/animal";

            dataGridView1.DataSource = await comApi.Get<List<AnimalApi>>(Url);

        }

        private async void btnSubir_Click(object sender, EventArgs e)
        {
            AnimalApi_Negocio an = new AnimalApi_Negocio();
            List<AnimalApi> listaAnimales = an.RecuperarTodos(); //La lista se llena correctamente
           
            ComunicacionApi comApi = new ComunicacionApi();
            var Url = "http://localhost:8080/api/animal";
            dataGridView1.DataSource = await comApi.Post<string, List<AnimalApi>>(Url,listaAnimales);
        }
    }
}
