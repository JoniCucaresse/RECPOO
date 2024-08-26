
using Ejercicio02.Entidades;
using RecuperatorioPrimerParcialPooTema1;

namespace Ejercicio02.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cuil=ConsoleExtensions.ReadString("Ingrese un CUIL / CUIT(formato XX-XXXXXXXX-X): ");
            var tipo = ConsoleExtensions.ReadString("Ingrese si es 'hombre', 'mujer' o 'empresa': ");
            if(ValidadorCUILCUIT.Validar(cuil, tipo))
            {
                ConsoleExtensions.ShowMessage("El CUIL/CUIT ingresado es valido");
            }
            else
            {
                ConsoleExtensions.ShowMessage("El CUIL/CUIT ingresado NO es valido");
            }
            ConsoleExtensions.EsperarPresionDeTecla("");

        }
    }
}
