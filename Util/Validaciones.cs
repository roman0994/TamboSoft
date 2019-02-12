﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    public class Validaciones
    {
        public bool ValidarCargaEventosTipo1(DateTime fecha, int indexAnimal, int indexEvento, int indexSubevento1)
        {
            if (fecha == null || indexAnimal == -1 || indexEvento == -1 || indexSubevento1 == -1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool ValidarCargaEventosTipo2(DateTime fecha, int indexAnimal, int indexEvento, int indexSubevento1, int indexSubevento2)
        {
            if (fecha == null || indexAnimal == -1 || indexEvento == -1 || indexSubevento1 == -1 || indexSubevento2 == -1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool ValidarCargaEventosTipo3(DateTime fecha, int indexAnimal, int indexEvento, int indexSubevento1, int indexSubevento2, int indexSubevento3)
        {
            if (fecha == null || indexAnimal == -1 || indexEvento == -1 || indexSubevento1 == -1 || indexSubevento2 == -1 || indexSubevento3 == -1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool ValidarCargaEventosTipo4(DateTime fecha, int indexAnimal, int indexEvento, int indexSubevento1, int indexSubevento2, int indexSubevento3, int indexSubevento4)
        {
            if (fecha == null || indexAnimal == -1 || indexEvento == -1 || indexSubevento1 == -1 || indexSubevento2 == -1 || indexSubevento3 == -1 || indexSubevento4 == -1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool ValidarCargaControles(int indexAnimal, DateTime fecha, string primerControl, string segundoControl, string porcGrasa, string kgGrasa)
        {
            if (indexAnimal != -1 && fecha != null && primerControl != null && primerControl != "Lts del 1er ordeñe. Formato: XX,XX" && segundoControl != null && segundoControl != "Lts del 2do ordeñe. Formato: XX,XX" && porcGrasa != null && porcGrasa != "Formato: XX,XX" && kgGrasa != null && kgGrasa != "Formato: XX,XX")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ValidarEdicionControles(int indexAnimal, DateTime fecha, string primerControl, string segundoControl, string porcGrasa, string kgGrasa)
        {
            if (indexAnimal != -1 && fecha != null && primerControl != null && primerControl != string.Empty && segundoControl != null && segundoControl != string.Empty && porcGrasa != null && porcGrasa != string.Empty && kgGrasa != null && kgGrasa != string.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ValidarCargaAnimales(int indexCategoria, int indexSexo, int indexRaza, string edad, string nombre, string hba)
        {
            if (indexCategoria != -1 && indexSexo != -1 && indexRaza != -1 && edad != null && edad != "Edad del animal" && nombre != null && nombre != "Nombre del animal" && hba != null && hba != "Código numérico")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ValidarEdicionAnimales(int indexCategoria, int indexSexo, int indexRaza, string edad, string nombre, string hba)
        {
            if (indexCategoria != -1 && indexSexo != -1 && indexRaza != -1 && edad != null && edad != string.Empty && nombre != null && nombre != string.Empty && hba != null && hba != string.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ValidarCargaTambos(int indexProvincia, int indexLocalidad, string nombre, string superficie)
        {
            if (indexProvincia != -1 && indexLocalidad != -1 && nombre != null && nombre != "Nombre tambo" && superficie != null && superficie != "Ej: 200,00")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ValidarEdicionTambos(int indexProvincia, int indexLocalidad, string nombre, string superficie)
        {
            if (indexProvincia != -1 && indexLocalidad != -1 && nombre != null && nombre != string.Empty && superficie != null && superficie != string.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ValidarDni(string dni)
        {
            int i;

            if (string.IsNullOrEmpty(dni))
            {
                //vacío
                return true;
            }
            else if (dni.Trim().Length != 8)
            {
                //Distinto a ocho caracteres
                return true;
            }
            else if (!int.TryParse(dni, out i))
            {
                //no numérico
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ValidarValorDecimal(string texto)
        {
            decimal i;
            if (decimal.TryParse(texto, out i))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ValidarEntero(string texto)
        {
            int i;
            if (int.TryParse(texto, out i))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /*public bool ValidarTexto(string texto)
        {
            string i;
            if (string.TryParse(texto, out i))
            {
                return true;
            }
            else
            {
                return false;
            }
        }*/

    }
}
