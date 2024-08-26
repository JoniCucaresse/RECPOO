using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicio02.Entidades
{
    public static class ValidadorCUILCUIT
    {
        public static bool Validar(string cuil, string tipo)
        {
            if (!EsFormatoValido(cuil))
            {
                return false;

            }
            return TipoCuil(cuil, tipo);
        }

        public static bool EsFormatoValido(string cuil)
        {
            return Regex.IsMatch(cuil, @"^\d{2}-\d{8}-\d{1}$");
        }

        private static bool TipoCuil(string cuil, string tipo)
        {
            string tipoCuil = cuil.Split('-')[0];
            if (tipo == "hombre" && tipoCuil == "20")
            {
                return true;
            }
            else if (tipo == "mujer" && tipoCuil == "27")
            {
                return true;
            }
            else if (tipo == "empresa" && tipoCuil == "30")
            {
                return true;
            }
            return false;
        }
    }
}
