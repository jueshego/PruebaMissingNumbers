using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LogicaNegocio
{
    public class ReglasMissingNumbers : IMissingNumbers
    {
        public int cantA;
        public int cantB;
        public string cadenaA;
        public string cadenaB;
        private int[] ListA;
        private int[] ListB;
        public List<int> ListRes;

        public string Buscar()
        {
            try
            {
                ConvertirArrEnteros();

                ValidarCantidad();

                OrdenarArreglos();

                BuscarNumerosPerdidos();

                return ConvertirArrCadena();
            }     
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ValidarCantidad()
        {
            if (!ValidarCantidad(cantA, ListA))
                throw new Exception("El campo Cantidad A no es igual a la cantidad de números del Listado A");

            if (!ValidarCantidad(cantB, ListB))
                throw new Exception("El campo cantidad no es igual a la cantidad de números del Listado B");

            if (CompararListas())
                throw new Exception("El Listado A debe tener menor o igual cantidad de números del Listado B");
        }

        private bool ValidarCantidad(int cant, int[] lista)
        {
            return lista.Length == cant;
        }

        private bool CompararListas()
        {
            return ListA.Length > ListB.Length;
        }

        public void ConvertirArrEnteros()
        {
            try
            {
                ListA = Array.ConvertAll(cadenaA.Split(' '), Int32.Parse);
                ListB = Array.ConvertAll(cadenaB.Split(' '), Int32.Parse);
            }   
            catch(System.FormatException ex)
            {
                throw ex;
            }         
        }

        public void OrdenarArreglos()
        {
            Array.Sort(ListA);
            Array.Sort(ListB);
        }

        private void RegistrarNroPerdido(int nro)
        {
            if (ListRes.Any(x => x == nro))
                return;

            ListRes.Add(nro);
        }

        private void BuscarNumerosPerdidos()
        {
            ListRes = new List<int>();

            int i, j;
            i = j = 0;

            for (j = 0; j < cantB; j++)
            {
                int valorB = ListB[j];

                try
                {
                    int valorA = ListA[i];
                }
                catch(IndexOutOfRangeException)
                {
                    RegistrarNroPerdido(valorB);
                    continue;
                }
                               
                if (ListA[i] != ListB[j])
                {
                    RegistrarNroPerdido(valorB);
                }
                else
                {
                    i++;
                }
            }

            return;
        }

        public string ConvertirArrCadena()
        {
            return String.Join(" ", ListRes);
        }
    }
}
