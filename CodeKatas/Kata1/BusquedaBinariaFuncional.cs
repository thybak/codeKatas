using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKatas.Kata1
{
    public class BusquedaBinariaFuncional : Busqueda
    {
        private Func<int, int[], int, int, int> BusquedaFuncional()
        {
            Func<int, int[], int, int, int> busquedaFuncionalAux = null;
            busquedaFuncionalAux = (bus, tot, limInf, limSup) =>
            {
                if (limInf > limSup)
                {
                    return -1;
                }
                var indice = limInf + ((limSup - limInf) / 2);
                if (bus == tot[indice])
                {
                    return indice;
                }
                else if (bus < tot[indice])
                {
                    return busquedaFuncionalAux(bus, tot, limInf, indice - 1);
                }
                else
                {
                    return busquedaFuncionalAux(bus, tot, indice + 1, limSup);
                }
            };
            return busquedaFuncionalAux;
        }

        public int BusquedaBinaria(int numero, int[] numeros)
        {
            Func<int, int[], int> busquedaFuncional = null;
            busquedaFuncional = (num, nums) =>
            {
                var busquedaBinariaAux = BusquedaFuncional();
                return busquedaBinariaAux(num, nums, 0, nums.Length - 1);
            };
            return busquedaFuncional(numero, numeros);
        }
    }
}
