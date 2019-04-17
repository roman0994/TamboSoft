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
        System.Threading.Thread t;
        AnimalApi_Negocio animalapinegocio;
        public PruebaSincronizacion()
        {
            InitializeComponent();
             animalapinegocio = new AnimalApi_Negocio();
        }

        private async void btnSincronizar_Click(object sender, EventArgs e)
        {
            List<AnimalApi> listado = new List<AnimalApi>();
            try
            {
                dataGridView1.DataSource = null;
                progressBar1.Style = ProgressBarStyle.Marquee;
                btnSincronizar.Enabled = false;
                btnSubir.Enabled = false;
                lbSincronizacion.Text = "En proceso...";
                t = new System.Threading.Thread(start);
                t.Start();



                listado = await TraerListadoAnimalesApi();
                List<AnimalApi> listaInexistentes = animalapinegocio.Comparar_ApiBase(listado, Principal.Tambo.Id_tambo);
                List<AnimalApi> listaModificados = animalapinegocio.CompararModif_ApiBase(listado, Principal.Tambo.Id_tambo);

                if (listaInexistentes.Count > 0)
                {
                    dataGridView1.DataSource = listaInexistentes;

                    DialogResult dialogResult = MessageBox.Show(this, "¿Desea guardar los nuevos registros?", "Guardar",
                        MessageBoxButtons.YesNo);
                    if (dialogResult.Equals(DialogResult.Yes))
                    {
                        foreach (var item in listaInexistentes)
                        {
                            animalapinegocio.Insertar(item);
                            
                        }
                        foreach (var item in listaModificados)
                        {
                            animalapinegocio.Actualizar(item);
                        }
                        MessageBox.Show("Los animales fueron subidos correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show(this, "No se obtuvieron registros nuevos");
                }
                finishProcess();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocurrió un error al sincronizar " + ex.Message);
                
            }
           
        }

        private void start()
        {
            longProcess(15);
        }

        private void longProcess(int seconds)
        {
            System.Threading.Thread.Sleep(seconds * 1000);
            if (this.InvokeRequired) this.Invoke(new Action(finishProcess));
        }

        private void finishProcess()
        {
            progressBar1.Style = ProgressBarStyle.Blocks;
            lbSincronizacion.Text = "Finalizado";
            btnSincronizar.Enabled = true;
            btnSubir.Enabled = true;
        }


        public async  Task<List<AnimalApi>> TraerListadoAnimalesApi()
        {
            List<AnimalApi> listado = new List<AnimalApi>();
            try
            {
                ComunicacionApi comApi = new ComunicacionApi();



                var Url = "http://localhost:8081/api/animales";
                listado = await comApi.Get<List<AnimalApi>>(Url);
                listado = listado.Where(x => x.IdTambo == Principal.Tambo.Id_tambo).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocurrio un error al sincronizar " + ex.Message);

            }
            return listado;


        }

        private async void btnSubir_Click(object sender, EventArgs e)
        {
            try
            {

                dataGridView1.DataSource = null;
                progressBar1.Style = ProgressBarStyle.Marquee;
                btnSincronizar.Enabled = false;
                btnSubir.Enabled = false;
                lbSincronizacion.Text = "En proceso...";
                t = new System.Threading.Thread(start);
                t.Start();


                AnimalApi_Negocio an = new AnimalApi_Negocio();
                AnimalApi animal = new AnimalApi();
                List<AnimalApi> listaAnimalesBase = an.RecuperarTodos(); //La lista se llena correctamente
                List<AnimalApi> listadoanimalesApi = await TraerListadoAnimalesApi();
                List<AnimalApi> listaResultado = new List<AnimalApi>();
                List<AnimalApi> listaModificados = new List<AnimalApi>();
                List<AnimalApi> listaNuevos = new List<AnimalApi>();

                ComunicacionApi comApi = new ComunicacionApi();
                var Url = "http://localhost:8081/api/animales";

                foreach (var item in listaAnimalesBase)
                {
                    animal = item;

                    if (!listadoanimalesApi.Exists(x => x.Rp == animal.Rp))
                    {
                        Url = "http://localhost:8081/api/animales";
                        animal = await comApi.Post<string, AnimalApi>(Url, animal);

                        if (!comApi.response.IsSuccessStatusCode)
                        {
                            MessageBox.Show(this, "No se pudo subir correctamente el registro " + item.NombreAnimal);
                        }
                        else
                        {
                            listaNuevos.Add(animal);
                            listaResultado.Add(animal);
                        }
                    }
                    else
                    {
                        Url = "http://localhost:8081/api/animales/" + animal.Rp;
                        await comApi.Put<string, AnimalApi>(Url, animal);

                        if (!comApi.response.IsSuccessStatusCode)
                        {
                            MessageBox.Show(this, "No se pudo subir correctamente el registro " + item.NombreAnimal);
                        }
                        if (comApi.response.StatusCode == System.Net.HttpStatusCode.NoContent)
                        {
                            
                            listaResultado.Add(animal);
                            listaModificados.Add(animal);
                        }
                        
                    }

                }

                dataGridView1.DataSource = listaResultado;

                string nombres = "";
                string mensaje = "";

                

                if (listaModificados.Count == 0 && listaNuevos.Count == 0)
                {
                    MessageBox.Show(this, "La sincronizacion se realizó correctamente. No hubo cambios ");
                }
                else if (listaNuevos.Count > 0)
                {
                    nombres = "";
                    mensaje = "Los siguientes animales fueron dados de alta:\n";
                    foreach (var nuevo in listaNuevos)
                    {
                        nombres = nombres + nuevo.NombreAnimal + "\n";
                    }
                    mensaje = mensaje + nombres;
                    if (listaModificados.Count > 0)
                    {

                        mensaje = mensaje + "\n **Los registros se sincronizaron correctamente";
                    }
                    MessageBox.Show(this, mensaje);
                }
                else
                {
                    MessageBox.Show(this, "La sincronizacion se realizó correctamente. ");
                }

                finishProcess();

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);

            }



            //AnimalApi animal = new AnimalApi
            //{
            //    Rp = 3,
            //    FechaNacimiento = DateTime.Now,
            //    Edad = 12,
            //    Foto = "NN",
            //    NombreAnimal = "Natalia Natalia",
            //    EstadoAnimal = "Vivo",
            //    Hba = 12345,
            //    Categoria = "Vaca",
            //    RpMadre = 12,
            //    RpPadre = 11,
            //    HbaMadre = 1523,
            //    HbaPadre = 1445,
            //    IdTambo = 1,
            //    IdRaza = 1,
            //    Habilitado = true
            //};

            //ComunicacionApi api = new ComunicacionApi();
            //var Url = "http://localhost:8081/api/animales/3";
            //animal = await api.Put<string, AnimalApi>(Url, animal);
            //MessageBox.Show(this, animal.NombreAnimal + " Fue registrado con exito");
        }

        private void PruebaSincronizacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (t != null && t.IsAlive)
            {
                t.Abort();
                t = null;
            }
        }
    }
}
