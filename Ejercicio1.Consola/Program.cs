using Ejercicio1.Entidades;
using RecuperatorioPrimerParcialPooTema1;

namespace Ejercicio1.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleExtensions.ShowMessage("Se desea saber los datos de una esfera.");
            int Radio = ConsoleExtensions.ReadInt("Ingrese el Radio: ");
            Esfera esfera = new Esfera(Radio);

            Console.WriteLine($"{esfera.InformarDatos()}");

            ConsoleExtensions.EsperarPresionDeTecla("");
        }
    }
}
