using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeKatas.Kata1;

namespace CodeKatasTest
{
    [TestClass]
    public class Kata1
    {
        public Busqueda oBusqueda { get; set; }

        private void LanzarBusqueda()
        {
            Assert.AreEqual(-1, oBusqueda.BusquedaBinaria(3, new int[] { }));
            Assert.AreEqual(-1, oBusqueda.BusquedaBinaria(3, new int[] { 1 }));
            Assert.AreEqual(0, oBusqueda.BusquedaBinaria(1, new int[] { 1 }));

            Assert.AreEqual(0, oBusqueda.BusquedaBinaria(1, new int[] { 1, 3, 5 }));
            Assert.AreEqual(1, oBusqueda.BusquedaBinaria(3, new int[] { 1, 3, 5 }));
            Assert.AreEqual(2, oBusqueda.BusquedaBinaria(5, new int[] { 1, 3, 5 }));
            Assert.AreEqual(-1, oBusqueda.BusquedaBinaria(0, new int[] { 1, 3, 5 }));
            Assert.AreEqual(-1, oBusqueda.BusquedaBinaria(2, new int[] { 1, 3, 5 }));
            Assert.AreEqual(-1, oBusqueda.BusquedaBinaria(4, new int[] { 1, 3, 5 }));
            Assert.AreEqual(-1, oBusqueda.BusquedaBinaria(6, new int[] { 1, 3, 5 }));

            Assert.AreEqual(0, oBusqueda.BusquedaBinaria(1, new int[] { 1, 3, 5, 7 }));
            Assert.AreEqual(1, oBusqueda.BusquedaBinaria(3, new int[] { 1, 3, 5, 7 }));
            Assert.AreEqual(2, oBusqueda.BusquedaBinaria(5, new int[] { 1, 3, 5, 7 }));
            Assert.AreEqual(3, oBusqueda.BusquedaBinaria(7, new int[] { 1, 3, 5, 7 }));
            Assert.AreEqual(-1, oBusqueda.BusquedaBinaria(0, new int[] { 1, 3, 5, 7 }));
            Assert.AreEqual(-1, oBusqueda.BusquedaBinaria(2, new int[] { 1, 3, 5, 7 }));
            Assert.AreEqual(-1, oBusqueda.BusquedaBinaria(4, new int[] { 1, 3, 5, 7 }));
            Assert.AreEqual(-1, oBusqueda.BusquedaBinaria(6, new int[] { 1, 3, 5, 7 }));
            Assert.AreEqual(-1, oBusqueda.BusquedaBinaria(8, new int[] { 1, 3, 5, 7 }));
        }

        [TestMethod]
        public void BusquedaBinariaImperativa()
        {
            oBusqueda = new BusquedaBinariaImperativa();
            LanzarBusqueda();
        }

        [TestMethod]
        public void BusquedaBinariaRecursiva()
        {
            oBusqueda = new BusquedaBinariaRecursiva();
            LanzarBusqueda();
        }

        [TestMethod]
        public void BusquedaBinariaTroceadoRecursivo()
        {
            oBusqueda = new BusquedaBinariaTroceadoRecursivo();
            LanzarBusqueda();
        }

        [TestMethod]
        public void BusquedaBinariaTroceado()
        {
            oBusqueda = new BusquedaBinariaTroceado();
            LanzarBusqueda();
        }

        [TestMethod]
        public void BusquedaBinariaFuncional()
        {
            oBusqueda = new BusquedaBinariaFuncional();
            LanzarBusqueda();
        }
    }
}
