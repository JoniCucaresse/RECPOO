using Ejercicio1.Entidades;

namespace Ejercicio1.Test
{
    [TestClass]
    public class TestEsfera
    {
        [TestMethod]
        public void CalcularArea_DeberiaCalcularCorrectamente()
        {
            // Arrange
            int radio = 1;
            Esfera esfera = new Esfera(radio);

            // Act
            double area = esfera.CalcularArea();

            // Assert
            Assert.AreEqual(12.566370614359172, area);
        }
        [TestMethod]
        public void CalcularVolumen_DeberiaCalcularCorrectamente()
        {
            // Arrange
            int radio = 1;
            Esfera esfera = new Esfera(radio);

            // Act
            double volumen = esfera.CalcularVolumen();

            // Assert
            Assert.AreEqual(3.141592653589793, volumen);
        }

        [TestMethod]
        public void CalcularDiametro_DeberiaCalcularCorrectamente()
        {
            // Arrange
            int radio = 1;
            Esfera esfera = new Esfera(radio);

            // Act
            double diametro = esfera.GetDiametro();

            // Assert
            Assert.AreEqual(2, diametro);
        }
        [TestMethod]
        public void ImprimirInformacion_DeberiaRetornarInformacionCorrecta()
        {
            // Arrange
            int radio = 1;
            Esfera esfera = new Esfera(radio);

            // Act
            string informacion = esfera.InformarDatos();

            // Assert
            StringAssert.Contains("La esfera de radio 1", informacion);
            StringAssert.Contains("Diametro: 2}", informacion);
            StringAssert.Contains("Volumen:  3.141592653589793", informacion);
            StringAssert.Contains("Área: 12.566370614359172", informacion);
        }

    }
}