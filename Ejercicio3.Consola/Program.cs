using Ejercicio3.Entidades;
using RecuperatorioPrimerParcialPooTema1;

namespace Ejercicio3.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kilos kilos = new Kilos(1);
            Libras libras = new Libras(1);

            Console.WriteLine($"Kilos: {kilos.GetPeso()}kg");
            Console.WriteLine($"Libras: {libras.GetPeso()}lb");

            // Conversión explícita entre tipos
            Kilos kilosConverted = (Kilos)libras;
            Libras librasConverted = (Libras)kilos;

            Console.WriteLine(
                $"Libras convertido a Kilos: {kilosConverted.GetPeso()}kg");
            Console.WriteLine(
                $"Kilos convertido a Libras: {librasConverted.GetPeso()}lb");

            // Operaciones aritméticas
            Kilos sumaKilos = kilos + kilosConverted;
            Libras sumaLibras = libras + librasConverted;

            Console.WriteLine($"Suma de Kilos: {sumaKilos.GetPeso()}kg");
            Console.WriteLine($"Suma de Libras: {sumaLibras.GetPeso()}lb");

            // Comparaciones
            Console.WriteLine(
                kilos == kilosConverted
                ? "Los pesos en Kg son iguales."
                : "Los pesos en kg no son iguales.");
            Console.WriteLine(
                libras == librasConverted
                ? "Los pesos en Lb son iguales."
                : "Los pesos en Lb no son iguales.");

            ConsoleExtensions.EsperarPresionDeTecla(" ");
        }
    }
}
