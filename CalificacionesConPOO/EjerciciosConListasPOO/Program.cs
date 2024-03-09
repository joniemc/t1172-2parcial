using System;

namespace EjerciciosConListasPOO {

    public class Program
    {
        public static void Main(string[] args)
        {
            List<Estudiante> estudiantes = new List<Estudiante>();
            int opcion = 0;
            int count = 1;
            do {
                Menu();
                opcion = Convert.ToInt16(Console.ReadLine());
                
                if (opcion==1) {
                    Estudiante miEstudiante = new Estudiante();
                    Console.WriteLine("===============Estudiante #{0}===============", count);
                    Console.WriteLine("Ingrese el nombre completo del estudiante: ");
                    miEstudiante.NombreCompleto = Console.ReadLine();
                    Console.WriteLine("Ingrese el N° cuenta: ");
                    miEstudiante.Cuenta = Console.ReadLine();
                    Console.WriteLine("Ingrese calificación del estudiante: ");
                    miEstudiante.CalificacionParcial = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine();

                    estudiantes.Add(miEstudiante);
                }

                count++;
            } while (opcion!=0);

            count = 1;
            //Recorrido del arreglo para desplegar información en pantalla
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("===============Resultado===============");
            foreach (Estudiante estudianteActual in estudiantes) {
                Console.WriteLine("===============estudiante #{0}===============", count++);
                Console.WriteLine("Nombre: {0}", estudianteActual.NombreCompleto);
                Console.WriteLine("Cuenta: {0}", estudianteActual.Cuenta);
                Console.WriteLine("Calificación: {0}", estudianteActual.CalificacionParcial);
                Console.WriteLine("Estado: {0}", estudianteActual.Estado);
                Console.WriteLine();
            }

            double promedio = estudiantes.Average(estudianteActual => estudianteActual.CalificacionParcial);
            double minimo = estudiantes.Min(estudianteActual => estudianteActual.CalificacionParcial);
            double maximo = estudiantes.Max(estudianteActual => estudianteActual.CalificacionParcial);

            Console.WriteLine("Promedio: {0}",promedio);
            Console.WriteLine("Maximo: {0}",maximo);
            Console.WriteLine("Minimo: {0}", minimo);
        }
        public static void Menu() {
            Console.WriteLine("Menu");
            Console.WriteLine("0. Salir");
            Console.WriteLine("1. Ingresar calificaciones");
        }
    }
    public class Estudiante
    {
        //Propiedades o Atributos
        private string nombreCompleto;
        private string cuenta;
        private double calificacionParcial;
        private string estado;

        //Constructores
        //Constructor por defecto
        public Estudiante() { }

        //Constructor con parametros
        public Estudiante(string nombreCompleto, string cuenta,
            double calificacionParcial)
        {
            NombreCompleto = nombreCompleto;
            Cuenta = cuenta;
            CalificacionParcial= calificacionParcial;
        }

        //Setters y Getters
        public string NombreCompleto
        {
            get
            {
                return this.nombreCompleto;
            }
            set
            {
                this.nombreCompleto = value;
            }
        }
        public string Cuenta
        {
            get
            {
                return this.cuenta;
            }
            set
            {
                this.cuenta = value;
            }
        }

        public double CalificacionParcial
        {
            get
            {
                return this.calificacionParcial;
            }
            set
            {
                if (value > 0)
                {
                    if (value <60)
                    {
                        this.estado = "REPROBO";
                    }
                    else if (value > 60)
                    {
                        this.estado = "APROBO";
                    }

                    this.calificacionParcial = value;
                }
            }
        }

        public string Estado
        {
            get
            {
                return this.estado;
            }
        }
    }
}
