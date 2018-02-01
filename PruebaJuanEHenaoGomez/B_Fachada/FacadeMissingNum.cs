using C_LogicaNegocio;
using D_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Fachada
{
    public class FacadeMissingNum
    {
        public string RetornarNrosPerdidos(ListaNumeros listaNumeros)
        {
            try
            {
                ReglasMissingNumbers reglasMissingNumbers = new ReglasMissingNumbers
                {
                    cantA = Convert.ToInt32(listaNumeros.cantListA),
                    cantB = Convert.ToInt32(listaNumeros.cantListB),
                    cadenaA = listaNumeros.ListA,
                    cadenaB = listaNumeros.ListB,
                };

                return reglasMissingNumbers.Buscar();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
