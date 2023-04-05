using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Bibloteca_ejer58;

namespace test_archivos
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CompararArchivos()
        {

            PuntoDat puntoData = new PuntoDat();
            PuntoDat text = new PuntoDat();
            string ruta = AppDomain.CurrentDomain.BaseDirectory + "prueba.dat";

            puntoData.Contenido = "contenido de archivo .dat";

            puntoData.Guardar(ruta, puntoData);

            text = text.Leer(ruta);

            Assert.AreEqual("contenido de archivo .dat", text.Contenido);

        }
    }
}
