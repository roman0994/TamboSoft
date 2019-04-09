using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TamboSoft.Models;
using TamboSoft.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TamboSoft.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Listado_Sincronizacion : ContentPage
	{
        List<Item> Lista_Item;
        ComunicacionApi comApi;
        SincronizacionVM sincronizacionvm;
        public ObservableCollection<ItemSeleccionable<Animal>> Animales { get; set; }
        AnimalVM animalvm;
        Item item;

        public List<Animal> AnimalParaAgregar { get; set; }

        public ObservableCollection<Animal> AnimalParaReemplazar { get; set; }

        public Listado_Sincronizacion ()
		{
			InitializeComponent ();

            comApi = new ComunicacionApi(); //primer linea a usar
            Animales = new ObservableCollection<ItemSeleccionable<Animal>>();
            AnimalParaAgregar = new List<Animal>();
            Lista_Item = new List<Item>();
            animalvm = new AnimalVM();

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Device.BeginInvokeOnMainThread(async () =>
            {
                try
                {
                    var Url = "http://localhost:8080/api/animal/"; //segunda linea, parametro url

                    var result = await comApi.Get<List<Animal>>(Url); //tercera linea, llamada del get

                    if (result != null)
                    {
                        foreach (var i in result)
                        {
                            item = new Item();
                            item.Text = "RP: " + i.RP.ToString();
                            item.Description = "Nombre: " + i.NombreAnimal.ToString() + " Tipo: " + i.Categoria + " Estado: " + i.EstadoAnimal;
                            Lista_Item.Add(item);
                        }
                        //Animales = new ObservableCollection<ItemSeleccionable<Animal>>(result.Select(pk => new ItemSeleccionable<Animal> { Item = pk, estaSeleccionado = true }));
                        //Animales = result;
                        listView.ItemsSource = Lista_Item;

                    }
                }
                catch (Exception ex)
                {

                    await DisplayAlert("Error", ex.Message, "Aceptar");
                }




            });
        }


        private async void OnItemGuardar(object sender, EventArgs e)
        {
            try
            {

                if (Lista_Item.Count > 0)
                {
                    await animalvm.Guardar_Animales(Lista_Item);
                }
                Task.WaitAll();
                await DisplayAlert("Animales", "Se cargaron todos los animales con exito", "Aceptar");
            }
            catch (Exception ex)
            {

                await DisplayAlert("ERROR", ex.Message, "Aceptar");
            }
        }




    }
}