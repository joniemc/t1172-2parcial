using System;

namespace figuras { 


    public class Program { 
        public static void Main(string[] args) {

            Console.WriteLine("Ingrese la altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el ancho: ");
            double ancho = Convert.ToDouble(Console.ReadLine());

            Figura figura2 = new Figura();
            Figura miFigura = new Figura(altura, ancho);

            Console.WriteLine("El area del objeto es: {0}",miFigura.CalcularArea());
            Console.WriteLine("El valor de altura objeto2 es: {0}",figura2.Altura);

            
            Console.WriteLine();

            Console.ReadLine();
        }
    }

    public class Figura {
        double altura;
        double ancho;

        public Figura() { }
        public Figura(double altura, double ancho)
        {
            Altura = altura;
            Ancho = ancho;
        }


        public double Altura
        {
            get {
                return this.altura;
            }
            set {
                this.altura = value;
            }
        }

        public double Ancho
        {
            get {
                return this.ancho;
            }
            set {
                this.ancho = value;
            }
        }

        public double CalcularArea() {
            return Altura*Ancho;
        }


    }

}