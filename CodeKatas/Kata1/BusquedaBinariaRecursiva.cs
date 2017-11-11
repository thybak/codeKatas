using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKatas.Kata1
{
    public class BusquedaBinariaRecursiva : Busqueda
    {

        private int BusquedaBinariaAux (int numero, int[] numeros, int limiteInferior, int limiteSuperior)
        {
            if (limiteInferior > limiteSuperior)
            {
                return -1;
            }

            var indice = limiteInferior + (limiteSuperior - limiteInferior) / 2;
            if (numero == numeros[indice])
            {
                return indice;
            } else if (numero < numeros[indice])
            {
                return BusquedaBinariaAux(numero, numeros, limiteInferior, indice - 1);
            }
            else
            {
                return BusquedaBinariaAux(numero, numeros, indice + 1, limiteSuperior);
            }
        }

        public int BusquedaBinaria(int numero, int[] numeros)
        {
            if (numeros.Length == 0)
            {
                return -1;
            }
            return BusquedaBinariaAux(numero, numeros, 0, numeros.Length - 1);
        }
    }
}
