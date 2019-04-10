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

            dataGridView1.DataSource = await comApi.Get<List<Animal>>(Url);

        }

        private async void btnSubir_Click(object sender, EventArgs e)
        {
            Animal_Negocio an = new Animal_Negocio();
            List<AnimalApi> listaAnimales = new List<AnimalApi>
            {
                new AnimalApi{Rp=2,Fecha_nacimiento= DateTime.Now,Edad=2,Foto="Puta",Nombre_animal="Pepe",Estado_animal="Vivo",Hba=1,Categoria="Vaca",Rp_madre=1,Rp_padre=1,Hba_madre=1,Hba_padre=1,Habilitado=true,Id_raza=1,Id_tambo=1 }

            }; 
            
            ComunicacionApi comApi = new ComunicacionApi();
            var Url = "http://localhost:8080/api/animal";
            dataGridView1.DataSource= await comApi.Post<string, List<AnimalApi>>(Url,listaAnimales);
        }
    }
}
