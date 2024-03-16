using System;

namespace HerenciaPOO {

    public class Program
    {
        public static void Main(string[] args)
        {
            Rectangulo rectangulo = new Rectangulo();
            Console.WriteLine(rectangulo);

            Console.ReadLine();
            
        }
    }

    public class Rectangulo {
        public Rectangulo() { }

        public override string ToString()
        {
            return "Hola mundo de la sobreescritura de funciones o metodos";
        }
    }
}
