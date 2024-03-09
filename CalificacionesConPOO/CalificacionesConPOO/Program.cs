using System;

namespace CalificacionesConPOO {
    public class Program { 
        public static void Main(string[] args)
        {
            //Declarar un arreglo de estudiantes
            Estudiante[] estudiantes;
            Console.WriteLine("Ingrese la cantidad de estudiantes: ");
            int cantidadEstudiantes = Convert.ToInt16(Console.ReadLine());
            estudiantes = new Estudiante[cantidadEstudiantes];

            for (int i=0; i<cantidadEstudiantes; i++) {
                
                Estudiante miEstudiante = new Estudiante();
                Console.WriteLine("===============estudiante #{0}===============", (i+1));
                Console.WriteLine("Ingrese el nombre completo del estudiante: ");
                miEstudiante.NombreCompleto = Console.ReadLine();
                Console.WriteLine("Ingrese el N° cuenta: ");
                miEstudiante.Cuenta = Console.ReadLine();
                Console.WriteLine("Ingrese calificación del estudiante: ");
                miEstudiante.CalificacionParcial = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();

                estudiantes[i] = miEstudiante;

            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("===============Resultado===============");
            int count = 1;
            foreach (Estudiante estudianteActual in estudiantes) {
                Console.WriteLine("===============estudiante #{0}===============",count++);
                Console.WriteLine("Nombre: {0}", estudianteActual.NombreCompleto);
                Console.WriteLine("Cuenta: {0}", estudianteActual.Cuenta);
                Console.WriteLine("Calificación: {0}", estudianteActual.CalificacionParcial);
                Console.WriteLine("Estado: {0}", estudianteActual.Estado);
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }

    public class Estudiante {
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
            double calificacionParcial) {
            NombreCompleto = nombreCompleto;
            Cuenta = cuenta;
            CalificacionParcial= calificacionParcial;
        }

        //Setters y Getters
        public string NombreCompleto {
            get {
                return this.nombreCompleto;
            }
            set {
                this.nombreCompleto = value; 
            }
        }
        public string Cuenta
        {
            get {
                return this.cuenta;
            }
            set { 
                this.cuenta = value;
            }
        }

        public double CalificacionParcial
        {
            get {
                return this.calificacionParcial;
            }
            set {
                if (value > 0) {
                    if (value <60)
                    {
                        this.estado = "REPROBO";
                    }
                    else if (value > 60) {
                        this.estado = "APROBO";
                    }

                    this.calificacionParcial = value;
                }
            }
        }

        public string Estado
        {
            get {
                return this.estado;
            }
        }
    }
}