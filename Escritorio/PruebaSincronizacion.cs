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
        List<AnimalApi> listaInexistentes;
        List<AnimalApi> listaModificados;
        public PruebaSincronizacion()
        {
            InitializeComponent();
            this.dataGridView1.AutoGenerateColumns = false;
             animalapinegocio = new AnimalApi_Negocio();
            listaInexistentes = new List<AnimalApi>();
            listaModificados = new List<AnimalApi>();
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
                listaInexistentes = animalapinegocio.Comparar_ApiBase(listado, Principal.Tambo.Id_tambo);
                listaModificados = animalapinegocio.CompararModif_ApiBase(listado, Principal.Tambo.Id_tambo);

                if (listaInexistentes.Count > 0)
                {
                    dataGridView1.DataSource = listaInexistentes;
                    MessageBox.Show("Se obtuvieron registros nuevos", "Registros nuevos", MessageBoxButtons.OK);
                    btnGuardar.Text = "Guardar Nuevos";
                    btnGuardar.Visible = true;
                    //DialogResult dialogResult = MessageBox.Show(this, "¿Desea guardar los nuevos registros?", "Guardar",
                      //  MessageBoxButtons.YesNo);
                    //if (dialogResult.Equals(DialogResult.Yes))
                    //{
                    //    foreach (var item in listaInexistentes)
                    //    {
                    //        animalapinegocio.Insertar(item);
                            
                    //    }
                    //    MessageBox.Show("Los animales fueron guardados correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //}
                   
                }
                if (listaModificados.Count > 0)
                {
                    //DialogResult dialogResult2 = MessageBox.Show(this, "¿Desea actualizar los registros modificados?", "Guardar", MessageBoxButtons.YesNo);
                    dataGridView1.DataSource = listaModificados;
                    MessageBox.Show("Se obtuvieron registros existentes que sufrieron modificaciones", "Actualizacion de registros", MessageBoxButtons.OK);
                    btnGuardar.Text = "Guardar Modificados";
                    btnGuardar.Visible = true;
                    //foreach (var item in listaModificados)
                    //{
                    //    animalapinegocio.Actualizar(item);
                    //}
                    //MessageBox.Show("Los animales fueron actualizados correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                if (listaInexistentes.Count == 0 && listaModificados.Count == 0)
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
                btnGuardar.Visible = false;
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

                    if (listadoanimalesApi.Count == 0 || !listadoanimalesApi.Exists(x => x.Rp == animal.Rp))
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




        }

        private void PruebaSincronizacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (t != null && t.IsAlive)
            {
                t.Abort();
                t = null;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (btnGuardar.Text == "Guardar Nuevos")
            {
                foreach (var item in listaInexistentes)
                {
                    animalapinegocio.Insertar(item);

                }
                MessageBox.Show("Los animales fueron guardados correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnGuardar.Visible = false;
            }
            else if(btnGuardar.Text == "Guardar Modificados")
            {
                foreach (var item in listaModificados)
                {
                    animalapinegocio.Actualizar(item);
                }
                MessageBox.Show("Los animales fueron actualizados correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnGuardar.Visible = false;

            }
        }
    }
}
