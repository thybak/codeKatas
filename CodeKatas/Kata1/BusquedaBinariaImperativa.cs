using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKatas.Kata1
{
    public class BusquedaBinariaImperativa : Busqueda
    {
        public int BusquedaBinaria(int numero, int[] numeros)
        {
            int limInferior = 0, limSuperior = numeros.Length - 1;

            while (limInferior <= limSuperior)
            {
                int indice = limInferior + ((limSuperior - limInferior) / 2);
                if (numero == numeros[indice])
                {
                    return indice;
                } else if (numero < numeros[indice])
                {
                    limSuperior = indice - 1;
                } else
                {
                    limInferior = indice + 1;
                }
            }

            return -1;
        }
    }
}
