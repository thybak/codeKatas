using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKatas.Kata1
{
    public class BusquedaBinariaTroceadoRecursivo : Busqueda
    {
        private int BusquedaBinariaAuxiliar(int numero, int[] numeros)
        {
            if (numeros.Length == 0)
            {
                return -1;
            }

            var indice = numeros.Length / 2;
            if (numero == numeros[indice])
            {
                return indice;
            }
            else if (numero < numeros[indice])
            {
                return BusquedaBinariaAuxiliar(numero, numeros.Take(indice).ToArray());
            }
            else
            {
                var resultado = BusquedaBinariaAuxiliar(numero, numeros.Skip(indice + 1).Take(numeros.Length - indice + 1).ToArray());
                return resultado == -1 ? resultado : resultado + indice + 1;
            }
        }

        public int BusquedaBinaria(int numero, int[] numeros)
        {
            return BusquedaBinariaAuxiliar(numero, numeros);
        }
    }
}
