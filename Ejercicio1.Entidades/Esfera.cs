using System.Text;

namespace Ejercicio1.Entidades
{
    public class Esfera
    {
        private readonly int radio;
        private double Diametro()=> radio * 2;
        public int GetRadio() => radio;
        public double GetDiametro() => Diametro();

        public Esfera(int radio)
        {
            if (radio <= 0)
            {
                throw new ArgumentException("La esfera ingresada no es valida");
            }
            else
            {
                this.radio = radio; 
            }
        }

        public double CalcularArea() => 4 * Math.PI * Math.Pow(radio, 2);

        public double CalcularVolumen()=>(4/3)*Math.PI* Math.Pow(radio, 3);

        public string InformarDatos()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"La esfera de radio {radio}");
            sb.AppendLine($"Diametro: {Diametro()}");
            sb.AppendLine($"Volumen:  {CalcularVolumen()}");
            sb.AppendLine($"Área: {CalcularArea()}");
            return sb.ToString();
        }

    }
}
