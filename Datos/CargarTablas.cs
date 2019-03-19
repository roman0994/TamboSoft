using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class CargarTablas
    {
        public void CargaTablasData()
        {  
            /*con.CreateTable<Provincia>();
            con.CreateTable<Localidad>();
            con.CreateTable<Animal>();
            con.CreateTable<Tambo>();
            con.CreateTable<Raza>();
            con.CreateTable<Desc_Subevento>();
            con.CreateTable<Control_Animal>();
            con.CreateTable<Evento>();
            con.CreateTable<Evento_Animal>();
            con.CreateTable<Evento_Subevento>();
            con.CreateTable<EventoAnimal_DescSubevento>();
            con.CreateTable<Inseminador>();
            con.CreateTable<SubEvento>();
            con.CreateTable<Tambo_Inseminador>();*/

            InicializarTablas();
        }

        private void InicializarTablas()
        {
            InicializarProvincias();
            InicializarLocalidades();
            //InicializarTambo();
            InicializarRazas();
            //InicializarAnimales();
            InicializarSubevento();
            InicializarEvento();
            InicializarDesc_Subevento();
            InicializarEvento_Subevento();
            //InicializarInseminador();


        }

        public void InicializarRazas()
        {
            Raza_Datos razaDatos = new Raza_Datos();
            if (razaDatos.HayRazas() == false)
            {
                List<Raza> items = new List<Raza> {
                new Raza {Nombre_raza = "Holando Argentino",Estado_raza = true },
                new Raza {Nombre_raza = "Yersey",Estado_raza = true },
                new Raza {Nombre_raza = "Cruza",Estado_raza = true },
                new Raza {Nombre_raza = "Shorthorn",Estado_raza = true },
                new Raza {Nombre_raza = "Pardo Suiza",Estado_raza = true },
                new Raza {Nombre_raza = "Holstein Negro",Estado_raza = true },
                new Raza {Nombre_raza = "Holstein Rojo",Estado_raza = true },
                new Raza {Nombre_raza = "Guernsey",Estado_raza = true },
                new Raza {Nombre_raza = "Pardo Suiza Americana",Estado_raza = true },
                new Raza {Nombre_raza = "Charolais",Estado_raza = true },
                new Raza {Nombre_raza = "Limousin",Estado_raza = true },
                new Raza {Nombre_raza = "Fleck vieh - Simmental",Estado_raza = true },
                new Raza {Nombre_raza = "Ayrshire",Estado_raza = true },
                new Raza {Nombre_raza = "Otra",Estado_raza = true },
            };

                foreach (var item in items)
                {
                    razaDatos.Insertar(item);
                }
            }
        }


        public void InicializarProvincias()
        {

            Provincia_Datos provDatos = new Provincia_Datos();
            if (provDatos.HayProvincias() == false)
            {
                List<Provincia> items = new List<Provincia> {
                    new Provincia{Nombre_provincia = "Buenos Aires" },
                    new Provincia{Nombre_provincia = "Catamarca" },
                    new Provincia{Nombre_provincia = "Chaco" },
                    new Provincia{Nombre_provincia = "Chubut" },
                    new Provincia{Nombre_provincia = "Córdoba" },
                    new Provincia{Nombre_provincia = "Corrientes" },
                    new Provincia{Nombre_provincia = "Entre Rios" },
                    new Provincia{Nombre_provincia = "Formosa" },
                    new Provincia{Nombre_provincia = "Jujuy" },
                    new Provincia{Nombre_provincia = "La Pampa" },
                    new Provincia{Nombre_provincia = "La Rioja" },
                    new Provincia{Nombre_provincia = "Mendoza" },
                    new Provincia{Nombre_provincia = "Misiones" },
                    new Provincia{Nombre_provincia = "Neuquén" },
                    new Provincia{Nombre_provincia = "Río Negro" },
                    new Provincia{Nombre_provincia = "Salta" },
                    new Provincia{Nombre_provincia = "San Juan" },
                    new Provincia{Nombre_provincia = "Santa Cruz" },
                    new Provincia{Nombre_provincia = "Santa Fe" },
                    new Provincia{Nombre_provincia = "Santiago del Estero" },
                    new Provincia{Nombre_provincia = "Tierra del Fuego" },
                    new Provincia{Nombre_provincia = "Tucumán" }

                };

                foreach (var item in items)
                {
                    provDatos.Insertar(item);
                }
            }
        }


        public void InicializarLocalidades()
        {

            Localidad_Datos localidadDatos = new Localidad_Datos();
            if (localidadDatos.HayLocalidades() == false)
            {
                List<Localidad> items = new List<Localidad>
                {
                    new Localidad{ Nombre_localidad = "Alicia",Id_provincia=5 },
                    new Localidad{ Nombre_localidad = "Carlos Pellegrini",Id_provincia=19 },
                    new Localidad{ Nombre_localidad = "Corral de Bustos",Id_provincia=5 },
                    new Localidad{ Nombre_localidad = "Landeta",Id_provincia=19 },
                    new Localidad{ Nombre_localidad = "Piamonte",Id_provincia=19 },
                    new Localidad{ Nombre_localidad = "San Jorge",Id_provincia=19 }

                };

                foreach (var item in items)
                {
                    localidadDatos.Insertar(item);
                }
            }
        }

        public void InicializarSubevento()
        {
            Subevento_Datos subeventoDatos = new Subevento_Datos();
            if (subeventoDatos.HaySubeventos() == false)
            {
                List<Subevento> items = new List<Subevento>
                {
                    new Subevento{ Nombre_subevento = "Sexo cria", Estado_subevento = true },
                    new Subevento{ Nombre_subevento = "Tipo parto", Estado_subevento = true },
                    new Subevento{ Nombre_subevento = "Estado cria", Estado_subevento = true },
                    new Subevento{ Nombre_subevento = "Causa aborto", Estado_subevento = true },
                    new Subevento{ Nombre_subevento = "Causa de no inseminar", Estado_subevento = true },
                    new Subevento{ Nombre_subevento = "Medicacion genital", Estado_subevento = true },
                    new Subevento{ Nombre_subevento = "Via de aplicacion", Estado_subevento = true },
                    new Subevento{ Nombre_subevento = "Especificacion venta", Estado_subevento = true },
                    new Subevento{ Nombre_subevento = "Tipo enfermedad", Estado_subevento = true },
                    new Subevento{ Nombre_subevento = "Medicamento", Estado_subevento = true },
                    new Subevento{ Nombre_subevento = "Diagnostico utero", Estado_subevento = true },
                    new Subevento{ Nombre_subevento = "Enfermedad utero", Estado_subevento = true },
                    new Subevento{ Nombre_subevento = "Enfermedad ovario", Estado_subevento = true },
                    new Subevento{ Nombre_subevento = "Causa rechazo", Estado_subevento = true },
                    new Subevento{ Nombre_subevento = "Tipo analisis", Estado_subevento = true },
                    new Subevento{ Nombre_subevento = "Especificacion muerte", Estado_subevento = true },
                    new Subevento{ Nombre_subevento = "Inseminador", Estado_subevento = true },
                    new Subevento{ Nombre_subevento = "Inseminador", Estado_subevento = true }

            };
                foreach (var item in items)
                {
                    subeventoDatos.Insertar(item);
                }
            }
        }


        public void InicializarEvento()
        {
            Evento_Datos eventoDatos = new Evento_Datos();
            if (eventoDatos.HayEventos() == false)
            {
                List<Evento> items = new List<Evento>
                {
                    new Evento{Nombre_evento="Parto" },
                    new Evento{Nombre_evento="Aborto" },
                    new Evento{Nombre_evento="Celo" },
                    new Evento{Nombre_evento="Venta" },
                    new Evento{Nombre_evento="Muerte" },
                    new Evento{Nombre_evento="Enfermedad" },
                    new Evento{Nombre_evento="Tacto Rectal" },
                    new Evento{Nombre_evento="Medicacion" },
                    new Evento{Nombre_evento="Rechazo" },
                    new Evento{Nombre_evento="Analisis" },
                    new Evento{Nombre_evento="Servicio" }

                };


                foreach (var item in items)
                {
                    eventoDatos.Insertar(item);
                }
            }
        }


        public void InicializarEvento_Subevento()
        {
            Evento_Subevento_Datos eventoSubeventoDatos = new Evento_Subevento_Datos();
            if (eventoSubeventoDatos.HayEventos_Subeventos() == false)
            {
                List<Evento_Subevento> items = new List<Evento_Subevento>
                {
                    new Evento_Subevento{Id_evento=1,Id_subevento=1},
                    new Evento_Subevento{Id_evento=1,Id_subevento=2},
                    new Evento_Subevento{Id_evento=1,Id_subevento=3},
                    new Evento_Subevento{Id_evento=2,Id_subevento=4},
                    new Evento_Subevento{Id_evento=3,Id_subevento=5},
                    new Evento_Subevento{Id_evento=3,Id_subevento=6},
                    new Evento_Subevento{Id_evento=3,Id_subevento=7},
                    new Evento_Subevento{Id_evento=4,Id_subevento=8},
                    new Evento_Subevento{Id_evento=6,Id_subevento=9},
                    new Evento_Subevento{Id_evento=7,Id_subevento=6},
                    new Evento_Subevento{Id_evento=6,Id_subevento=10},
                    new Evento_Subevento{Id_evento=8,Id_subevento=10},
                    new Evento_Subevento{Id_evento=7,Id_subevento=11},
                    new Evento_Subevento{Id_evento=7,Id_subevento=12},
                    new Evento_Subevento{Id_evento=7,Id_subevento=13},
                    new Evento_Subevento{Id_evento=9,Id_subevento=14},
                    new Evento_Subevento{Id_evento=8,Id_subevento=7},
                    new Evento_Subevento{Id_evento=10,Id_subevento=15},
                    new Evento_Subevento{Id_evento=5,Id_subevento=16},
                    new Evento_Subevento{Id_evento=11,Id_subevento=17}

                };
                foreach (var item in items)
                {
                    eventoSubeventoDatos.Insertar(item);
                }
            }
        }

        public void InicializarDesc_Subevento()
        {

            Desc_Subevento_Datos eventoSubeventoDatos = new Desc_Subevento_Datos();
            if (eventoSubeventoDatos.HayDescripciones() == false)
            {
                List<Desc_Subevento> items = new List<Desc_Subevento>
                {
                    new Desc_Subevento{Descripcion="Hembra",Abreviacion="H",Estado_desc=true,Id_subevento=1},
                    new Desc_Subevento{Descripcion="Macho",Abreviacion="M",Estado_desc=true,Id_subevento=1},
                    new Desc_Subevento{Descripcion="Mell. Hembra-Macho",Abreviacion="HM",Estado_desc=true,Id_subevento=1},
                    new Desc_Subevento{Descripcion="Mell. Hembra-Hembra",Abreviacion="HH",Estado_desc=true,Id_subevento=1},
                    new Desc_Subevento{Descripcion="Mell. Macho-Macho",Abreviacion="MM",Estado_desc=true,Id_subevento=1},
                    new Desc_Subevento{Descripcion="Normal",Abreviacion="N",Estado_desc=true,Id_subevento=2},
                    new Desc_Subevento{Descripcion="Cesarea",Abreviacion="C",Estado_desc=true,Id_subevento=2},
                    new Desc_Subevento{Descripcion="Prematuro",Abreviacion="Pre",Estado_desc=true,Id_subevento=2},
                    new Desc_Subevento{Descripcion="Fetotomia",Abreviacion="F",Estado_desc=true,Id_subevento=2},
                    new Desc_Subevento{Descripcion="Parto con ayuda",Abreviacion="A",Estado_desc=true,Id_subevento=2},
                    new Desc_Subevento{Descripcion="Episiotomia",Abreviacion="E",Estado_desc=true,Id_subevento=2},
                    new Desc_Subevento{Descripcion="Muerto",Abreviacion="M",Estado_desc=true,Id_subevento=3},
                    new Desc_Subevento{Descripcion="Vivo",Abreviacion="V",Estado_desc=true,Id_subevento=3},
                    new Desc_Subevento{Descripcion="Brucelosis",Abreviacion="B",Estado_desc=true,Id_subevento=4},
                    new Desc_Subevento{Descripcion="DVB",Abreviacion="DVB",Estado_desc=true,Id_subevento=4},
                    new Desc_Subevento{Descripcion="Haemophilus",Abreviacion="Ha",Estado_desc=true,Id_subevento=4},
                    new Desc_Subevento{Descripcion="Hiperestrogenismo",Abreviacion="Hi",Estado_desc=true,Id_subevento=4},
                    new Desc_Subevento{Descripcion="IBR",Abreviacion="IBR",Estado_desc=true,Id_subevento=4},
                    new Desc_Subevento{Descripcion="Leptospirosis",Abreviacion="Lep",Estado_desc=true,Id_subevento=4},
                    new Desc_Subevento{Descripcion="Stress",Abreviacion="SS",Estado_desc=true,Id_subevento=4},
                    new Desc_Subevento{Descripcion="Traumatismo",Abreviacion="T",Estado_desc=true,Id_subevento=4},
                    new Desc_Subevento{Descripcion="Trichomoniasis",Abreviacion="Tri",Estado_desc=true,Id_subevento=4},
                    new Desc_Subevento{Descripcion="Vibriosis",Abreviacion="V",Estado_desc=true,Id_subevento=4},
                    new Desc_Subevento{Descripcion="Flujo anormal",Abreviacion="FA",Estado_desc=true,Id_subevento=5},
                    new Desc_Subevento{Descripcion="Flujo con sangre",Abreviacion="FCS",Estado_desc=true,Id_subevento=5},
                    new Desc_Subevento{Descripcion="Irregular",Abreviacion="Irr",Estado_desc=true,Id_subevento=5},
                    new Desc_Subevento{Descripcion="Olvido o causa externa",Abreviacion="OCE",Estado_desc=true,Id_subevento=5},
                    new Desc_Subevento{Descripcion="Por celo debil",Abreviacion="CD",Estado_desc=true,Id_subevento=5},
                    new Desc_Subevento{Descripcion="Por prescripcion",Abreviacion="PP",Estado_desc=true,Id_subevento=5},
                    new Desc_Subevento{Descripcion="Por rechazo",Abreviacion="PR",Estado_desc=true,Id_subevento=5},
                    new Desc_Subevento{Descripcion="Por tratamiento",Abreviacion="PT",Estado_desc=true,Id_subevento=5},
                    new Desc_Subevento{Descripcion="Lotagen-prostaglandina",Abreviacion="LotPros",Estado_desc=true,Id_subevento=6},
                    new Desc_Subevento{Descripcion="Prostaglandina",Abreviacion="Pros",Estado_desc=true,Id_subevento=6},
                    new Desc_Subevento{Descripcion="Terramicina",Abreviacion="Terra",Estado_desc=true,Id_subevento=6},
                    new Desc_Subevento{Descripcion="Intra-muscular",Abreviacion="IM",Estado_desc=true,Id_subevento=7},
                    new Desc_Subevento{Descripcion="Intre-uterina y muscular",Abreviacion="IUyM",Estado_desc=true,Id_subevento=7},
                    new Desc_Subevento{Descripcion="Intra-venosa",Abreviacion="IV",Estado_desc=true,Id_subevento=7},
                    new Desc_Subevento{Descripcion="Retencion con extraccion",Abreviacion="RCE",Estado_desc=true,Id_subevento=7},
                    new Desc_Subevento{Descripcion="Subcutanea",Abreviacion="Sub",Estado_desc=true,Id_subevento=7},
                    new Desc_Subevento{Descripcion="Aherencia utero",Abreviacion="AdhU",Estado_desc=true,Id_subevento=8},
                    new Desc_Subevento{Descripcion="Cria terneros",Abreviacion="CrT",Estado_desc=true,Id_subevento=8},
                    new Desc_Subevento{Descripcion="Desc. por leucosis",Abreviacion="DPL",Estado_desc=true,Id_subevento=8},
                    new Desc_Subevento{Descripcion="Desgano rectal",Abreviacion="DR",Estado_desc=true,Id_subevento=8},
                    new Desc_Subevento{Descripcion="Dureza ordeño",Abreviacion="DO",Estado_desc=true,Id_subevento=8},
                    new Desc_Subevento{Descripcion="Fin vida util",Abreviacion="FVU",Estado_desc=true,Id_subevento=8},
                    new Desc_Subevento{Descripcion="Indocilidad",Abreviacion="Ind",Estado_desc=true,Id_subevento=8},
                    new Desc_Subevento{Descripcion="Lesion p/aft.",Abreviacion="Les",Estado_desc=true,Id_subevento=8},
                    new Desc_Subevento{Descripcion="Mastitis cronica",Abreviacion="MasC",Estado_desc=true,Id_subevento=8},
                    new Desc_Subevento{Descripcion="Otra causa",Abreviacion="OtraC",Estado_desc=true,Id_subevento=8},
                    new Desc_Subevento{Descripcion="Por Patas",Abreviacion="PPatas",Estado_desc=true,Id_subevento=8},
                    new Desc_Subevento{Descripcion="Produccion baja",Abreviacion="ProdB",Estado_desc=true,Id_subevento=8},
                    new Desc_Subevento{Descripcion="Puncion rumen",Abreviacion="PunRu",Estado_desc=true,Id_subevento=8},
                    new Desc_Subevento{Descripcion="R. parametritis",Abreviacion="RPar",Estado_desc=true,Id_subevento=8},
                    new Desc_Subevento{Descripcion="Secada (rechazo)",Abreviacion="Sec",Estado_desc=true,Id_subevento=8},
                    new Desc_Subevento{Descripcion="Septicemia",Abreviacion="Sep",Estado_desc=true,Id_subevento=8},
                    new Desc_Subevento{Descripcion="Subfertilidad",Abreviacion="Subf",Estado_desc=true,Id_subevento=8},
                    new Desc_Subevento{Descripcion="Tuberculosis",Abreviacion="Tub",Estado_desc=true,Id_subevento=8},
                    new Desc_Subevento{Descripcion="Ubre",Abreviacion="Ub",Estado_desc=true,Id_subevento=8},
                    new Desc_Subevento{Descripcion="Muerte accidental",Abreviacion="MA",Estado_desc=true,Id_subevento=16},
                    new Desc_Subevento{Descripcion="Muerte por aftosa",Abreviacion="MpA",Estado_desc=true,Id_subevento=16},
                    new Desc_Subevento{Descripcion="Muerte por anaplasmosis",Abreviacion="MpAn",Estado_desc=true,Id_subevento=16},
                    new Desc_Subevento{Descripcion="Muerte por carbunclo",Abreviacion="MpC",Estado_desc=true,Id_subevento=16},
                    new Desc_Subevento{Descripcion="Muerte por causa desconocida",Abreviacion="MpCd",Estado_desc=true,Id_subevento=16},
                    new Desc_Subevento{Descripcion="Muerte por hemorragia",Abreviacion="MpH",Estado_desc=true,Id_subevento=16},
                    new Desc_Subevento{Descripcion="Muerte por intoxicacion",Abreviacion="MpI",Estado_desc=true,Id_subevento=16},
                    new Desc_Subevento{Descripcion="Muerte por leucosis",Abreviacion="MpL",Estado_desc=true,Id_subevento=16},
                    new Desc_Subevento{Descripcion="Muerte por parto",Abreviacion="MpPar",Estado_desc=true,Id_subevento=16},
                    new Desc_Subevento{Descripcion="Muerte por peritonitis",Abreviacion="MpPer",Estado_desc=true,Id_subevento=16},
                    new Desc_Subevento{Descripcion="Muerte por prolapso matriz",Abreviacion="MpPro",Estado_desc=true,Id_subevento=16},
                    new Desc_Subevento{Descripcion="Muerte por ret. pericard.",Abreviacion="MpRet",Estado_desc=true,Id_subevento=16},
                    new Desc_Subevento{Descripcion="Muerte por sindrome vaca caida",Abreviacion="MpSvc",Estado_desc=true,Id_subevento=16},
                    new Desc_Subevento{Descripcion="Muerte por timpanismo",Abreviacion="MpT",Estado_desc=true,Id_subevento=16},
                    new Desc_Subevento{Descripcion="Abceso",Abreviacion="Ab",Estado_desc=true,Id_subevento=9},
                    new Desc_Subevento{Descripcion="Artritis digital",Abreviacion="ArD",Estado_desc=true,Id_subevento=9},
                    new Desc_Subevento{Descripcion="Brucelosis",Abreviacion="Bru",Estado_desc=true,Id_subevento=9},
                    new Desc_Subevento{Descripcion="Cercivitis",Abreviacion="Cer",Estado_desc=true,Id_subevento=9},
                    new Desc_Subevento{Descripcion="Dermatitis verrucosa",Abreviacion="Der",Estado_desc=true,Id_subevento=9},
                    new Desc_Subevento{Descripcion="Desgarro Rectal",Abreviacion="Des",Estado_desc=true,Id_subevento=9},
                    new Desc_Subevento{Descripcion="Escarsa",Abreviacion="Esc",Estado_desc=true,Id_subevento=9},
                    new Desc_Subevento{Descripcion="Flujo anormal",Abreviacion="FA",Estado_desc=true,Id_subevento=9},
                    new Desc_Subevento{Descripcion="Free-martins",Abreviacion="Free",Estado_desc=true,Id_subevento=9},
                    new Desc_Subevento{Descripcion="Hipocalcemia",Abreviacion="Hipo",Estado_desc=true,Id_subevento=9},
                    new Desc_Subevento{Descripcion="Indigestion",Abreviacion="Ind",Estado_desc=true,Id_subevento=9},
                    new Desc_Subevento{Descripcion="Leucosis",Abreviacion="Leu",Estado_desc=true,Id_subevento=9},
                    new Desc_Subevento{Descripcion="Mastitis",Abreviacion="Mas",Estado_desc=true,Id_subevento=9},
                    new Desc_Subevento{Descripcion="Prolapso",Abreviacion="Pro",Estado_desc=true,Id_subevento=9},
                    new Desc_Subevento{Descripcion="Querato-conjuntivitis",Abreviacion="Que",Estado_desc=true,Id_subevento=9},
                    new Desc_Subevento{Descripcion="Renga",Abreviacion="Ren",Estado_desc=true,Id_subevento=9},
                    new Desc_Subevento{Descripcion="Sindrome vaca caida",Abreviacion="SVC",Estado_desc=true,Id_subevento=9},
                    new Desc_Subevento{Descripcion="Tenosinovitis",Abreviacion="Ten",Estado_desc=true,Id_subevento=9},
                    new Desc_Subevento{Descripcion="Tetano",Abreviacion="Tet",Estado_desc=true,Id_subevento=9},
                    new Desc_Subevento{Descripcion="Timpanismo",Abreviacion="Tim",Estado_desc=true,Id_subevento=9},
                    new Desc_Subevento{Descripcion="Prostaglandina",Abreviacion="Pro",Estado_desc=true,Id_subevento=10},
                    new Desc_Subevento{Descripcion="Librada a servicio",Abreviacion="Lib",Estado_desc=true,Id_subevento=11},
                    new Desc_Subevento{Descripcion="Preñada",Abreviacion="Preñ",Estado_desc=true,Id_subevento=11},
                    new Desc_Subevento{Descripcion="Preñada dudosa",Abreviacion="PreñD",Estado_desc=true,Id_subevento=11},
                    new Desc_Subevento{Descripcion="Vacia anormal",Abreviacion="VacA",Estado_desc=true,Id_subevento=11},
                    new Desc_Subevento{Descripcion="Vacia normal",Abreviacion="VacN",Estado_desc=true,Id_subevento=11},
                    new Desc_Subevento{Descripcion="Involucion uterina lenta",Abreviacion="IUL",Estado_desc=true,Id_subevento=11},
                    new Desc_Subevento{Descripcion="Involucion uterina normal",Abreviacion="IUN",Estado_desc=true,Id_subevento=11},
                    new Desc_Subevento{Descripcion="Abceso paravaginal",Abreviacion="AbcPa",Estado_desc=true,Id_subevento=12},
                    new Desc_Subevento{Descripcion="Adherencia uterina",Abreviacion="AdhU",Estado_desc=true,Id_subevento=12},
                    new Desc_Subevento{Descripcion="Cervicitis",Abreviacion="Cer",Estado_desc=true,Id_subevento=12},
                    new Desc_Subevento{Descripcion="Desgarros utero-vaginal",Abreviacion="DesUV",Estado_desc=true,Id_subevento=12},
                    new Desc_Subevento{Descripcion="Endometritis 1",Abreviacion="End1",Estado_desc=true,Id_subevento=12},
                    new Desc_Subevento{Descripcion="Endometritis 2",Abreviacion="End2",Estado_desc=true,Id_subevento=12},
                    new Desc_Subevento{Descripcion="Endometritis 3",Abreviacion="End3",Estado_desc=true,Id_subevento=12},
                    new Desc_Subevento{Descripcion="Endometritis y retencion",Abreviacion="EntyR",Estado_desc=true,Id_subevento=12},
                    new Desc_Subevento{Descripcion="Flujo con pus",Abreviacion="FcP",Estado_desc=true,Id_subevento=12},
                    new Desc_Subevento{Descripcion="Flujo hemorragico",Abreviacion="FH",Estado_desc=true,Id_subevento=12},
                    new Desc_Subevento{Descripcion="Involucion uterina lenta",Abreviacion="IUL",Estado_desc=true,Id_subevento=12},
                    new Desc_Subevento{Descripcion="Metritis",Abreviacion="Met",Estado_desc=true,Id_subevento=12},
                    new Desc_Subevento{Descripcion="Mucometra",Abreviacion="Muc",Estado_desc=true,Id_subevento=12},
                    new Desc_Subevento{Descripcion="Neumovagina",Abreviacion="Neu",Estado_desc=true,Id_subevento=12},
                    new Desc_Subevento{Descripcion="Parametritis",Abreviacion="Par",Estado_desc=true,Id_subevento=12},
                    new Desc_Subevento{Descripcion="Paravaginitis",Abreviacion="Para",Estado_desc=true,Id_subevento=12},
                    new Desc_Subevento{Descripcion="Piometria",Abreviacion="Piom",Estado_desc=true,Id_subevento=12},
                    new Desc_Subevento{Descripcion="Salpingitis",Abreviacion="Sal",Estado_desc=true,Id_subevento=12},
                    new Desc_Subevento{Descripcion="Tumor de utero",Abreviacion="Tum",Estado_desc=true,Id_subevento=12},
                    new Desc_Subevento{Descripcion="Urovagina",Abreviacion="Uro",Estado_desc=true,Id_subevento=12},
                    new Desc_Subevento{Descripcion="Vaginitis",Abreviacion="Vag",Estado_desc=true,Id_subevento=12},
                    new Desc_Subevento{Descripcion="Adherencia ovario",Abreviacion="AdhO",Estado_desc=true,Id_subevento=13},
                    new Desc_Subevento{Descripcion="Anesto ovarico",Abreviacion="AnesO",Estado_desc=true,Id_subevento=13},
                    new Desc_Subevento{Descripcion="C. luteo persistente",Abreviacion="CLP",Estado_desc=true,Id_subevento=13},
                    new Desc_Subevento{Descripcion="CLOD",Abreviacion="CLOD",Estado_desc=true,Id_subevento=13},
                    new Desc_Subevento{Descripcion="CLOI",Abreviacion="CLOI",Estado_desc=true,Id_subevento=13},
                    new Desc_Subevento{Descripcion="FOLOD < 0,8",Abreviacion="FDm",Estado_desc=true,Id_subevento=13},
                    new Desc_Subevento{Descripcion="FOLOD > 0,8",Abreviacion="FDM",Estado_desc=true,Id_subevento=13},
                    new Desc_Subevento{Descripcion="FOLOI < 0,8",Abreviacion="FIm",Estado_desc=true,Id_subevento=13},
                    new Desc_Subevento{Descripcion="FOLOI > 0,8",Abreviacion="FIM",Estado_desc=true,Id_subevento=13},
                    new Desc_Subevento{Descripcion="Quiste/s ovarico/s",Abreviacion="Quis",Estado_desc=true,Id_subevento=13},
                    new Desc_Subevento{Descripcion="Salpingitis u/bilat.",Abreviacion="Salp",Estado_desc=true,Id_subevento=13},
                    new Desc_Subevento{Descripcion="Tumor ovarico",Abreviacion="Tum",Estado_desc=true,Id_subevento=13},
                    new Desc_Subevento{Descripcion="Baja produccion",Abreviacion="BProd",Estado_desc=true,Id_subevento=14},
                    new Desc_Subevento{Descripcion="Infertilidad",Abreviacion="Inf",Estado_desc=true,Id_subevento=14},
                    new Desc_Subevento{Descripcion="Patas",Abreviacion="Patas",Estado_desc=true,Id_subevento=14},
                    new Desc_Subevento{Descripcion="Por aborto",Abreviacion="PorAb",Estado_desc=true,Id_subevento=14},
                    new Desc_Subevento{Descripcion="Por edad",Abreviacion="PorEd",Estado_desc=true,Id_subevento=14},
                    new Desc_Subevento{Descripcion="Por enfermedad",Abreviacion="PorEnf",Estado_desc=true,Id_subevento=14},
                    new Desc_Subevento{Descripcion="Por tuberculosis",Abreviacion="PorTub",Estado_desc=true,Id_subevento=14},
                    new Desc_Subevento{Descripcion="BPA",Abreviacion="BPA",Estado_desc=true,Id_subevento=15},
                    new Desc_Subevento{Descripcion="Tuberculosis",Abreviacion="Tub",Estado_desc=true,Id_subevento=15},
                    new Desc_Subevento{Descripcion="Inseminador",Abreviacion="Ins",Estado_desc=true,Id_subevento=17},
                    new Desc_Subevento{Descripcion="Muertos",Abreviacion="Muerts",Estado_desc=true,Id_subevento=3},
                    new Desc_Subevento{Descripcion="Uno vivo y otro muerto",Abreviacion="V-M",Estado_desc=true,Id_subevento=3},
                    new Desc_Subevento{Descripcion="Vivos",Abreviacion="Vivos",Estado_desc=true,Id_subevento=3},
                    new Desc_Subevento{Descripcion="Actinom/bacilosis",Abreviacion="Papera",Estado_desc=true,Id_subevento=9},
                    new Desc_Subevento{Descripcion="Popodem-Pietin",Abreviacion="Pietin",Estado_desc=true,Id_subevento=9},
                    new Desc_Subevento{Descripcion="Volver a revisar",Abreviacion="VR",Estado_desc=true,Id_subevento=11},
                    new Desc_Subevento{Descripcion="Volver a revisar",Abreviacion="VR",Estado_desc=true,Id_subevento=12},
                    new Desc_Subevento{Descripcion="Ovario/s Funcional/es",Abreviacion="Funcio",Estado_desc=true,Id_subevento=13},
                    new Desc_Subevento{Descripcion="Vacia",Abreviacion="Vacia",Estado_desc=true,Id_subevento=14},
                    new Desc_Subevento{Descripcion="Negativo",Abreviacion="(-)",Estado_desc=true,Id_subevento=19},
                    new Desc_Subevento{Descripcion="Positivo",Abreviacion="(+)",Estado_desc=true,Id_subevento=19}

                };

                foreach (var item in items)
                {
                    eventoSubeventoDatos.Insertar(item);
                }
            }
        }

    }
}

