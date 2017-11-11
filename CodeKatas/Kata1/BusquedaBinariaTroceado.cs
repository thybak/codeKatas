using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKatas.Kata1
{
    public class BusquedaBinariaTroceado : Busqueda
    {
        public int BusquedaBinaria(int numero, int[] numeros)
        {
            int resultado = 0;
            int indice = numeros.Length / 2;
            List<int> numerosAux = numeros.ToList();

            while(numerosAux.Count > 0)
            {
                if (numero == numerosAux.ElementAt(indice))
                {
                    resultado += indice;
                    break;
                } else if (numero < numerosAux.ElementAt(indice))
                {
                    numerosAux = numerosAux.Take(indice).ToList();
                } else if (numero > numerosAux.ElementAt(indice))
                {
                    numerosAux = numerosAux.Skip(indice + 1).Take(numerosAux.Count - indice + 1).ToList();
                    resultado += indice + 1;
                }
                indice = numerosAux.Count / 2;
            }

            if (numerosAux.Count == 0)
            {
                resultado = -1;
            }

            return resultado;
        }
    }
}
