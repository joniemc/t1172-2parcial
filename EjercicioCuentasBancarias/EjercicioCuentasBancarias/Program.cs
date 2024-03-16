 using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioCuentasBancarias.CuentaBancaria;

namespace EjercicioCuentasBancarias
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<CuentaBancariaBase> listaCuentaBancaria = new List<CuentaBancariaBase>(); 
            int opcion = 0;
            do {
                Menu();
                opcion = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine();

                switch (opcion) {
                    case 1:
                        int opcionTipoCuenta = 0;
                        Console.WriteLine("Elija su Opción\n");
                        Console.WriteLine("1.Cuenta Básica" +
                            "\r\n2.Cuenta Premium" +
                            "\r\n3.Cancelar");


                        opcionTipoCuenta = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("=================Datos de Registro: =================");
                        Console.WriteLine("Ingrese el N° de cuenta: ");
                        string cuenta = Console.ReadLine();
                        Console.WriteLine("Ingrese el Nombre: ");
                        string nombreCompleto = Console.ReadLine();
                        Console.WriteLine("Ingrese el Monto Inicial: ");
                        double balance = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingrese el Interes: ");
                        double interes = Convert.ToDouble(Console.ReadLine());

                        if (opcionTipoCuenta == 1) {
                            CuentaBancariaBasica nuevaCuentaB = new CuentaBancariaBasica(cuenta, nombreCompleto,
                                balance,interes);
                            listaCuentaBancaria.Add(nuevaCuentaB);
                        }
                        else if (opcionTipoCuenta == 2) {
                            CuentaBancariaPremiun nuevaCuentaP = new CuentaBancariaPremiun(cuenta, nombreCompleto,
                                balance, interes);
                            listaCuentaBancaria.Add(nuevaCuentaP);
                        }
                        else {
                            Console.WriteLine("Gracias..");
                        }
                        Console.WriteLine("===================================================");
                        Console.WriteLine();

                        break;
                    case 2:
                        Console.WriteLine();
                        Console.WriteLine("=================Elimiar numero de cuenta=================");
                        Console.WriteLine();
                        Console.WriteLine("Ingrese el numero de cuenta que desea eliminar: ");
                        string cuentaBorrar = Console.ReadLine();

                        bool estadoBorrar = false;
                        
                        foreach (CuentaBancariaBase cuentaActual in listaCuentaBancaria) {
                            if (cuentaActual.IdCuenta.Equals(cuentaBorrar)) {
                                estadoBorrar = true;
                            }
                        }
                        
                        if (!estadoBorrar)
                        {
                            Console.WriteLine("No se encontro el registro.");
                        }
                        else {
                            //Find Metodo que sirve para buscar dentro de la lista
                            CuentaBancariaBase temporal = listaCuentaBancaria.Find(c => c.IdCuenta==cuentaBorrar );
                            listaCuentaBancaria.Remove(temporal);
                            Console.WriteLine("Eliminado con Exito..");
                        }
                        Console.WriteLine("===================================================");
                        Console.WriteLine();
                        break;
                    case 5:
                        Console.WriteLine();
                        Console.WriteLine("=================Reporte de Cuentas=================");
                        Console.WriteLine();
                        foreach (CuentaBancariaBase cuentaActual in listaCuentaBancaria) {
                            Console.WriteLine(cuentaActual.ToString());
                            Console.WriteLine();
                        }
                        Console.WriteLine("===================================================");
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine("Opción Invalida...");
                        break;
                }

            } while (opcion!=6);
        }
        public static void Menu() { 
            Console.WriteLine("Control de Cuentas Bancarias\n");
            Console.WriteLine("1.Agregar cuenta" +
                "\r\n2.Borrar cuenta" +
                "\r\n3.Depositar" +
                "\r\n4.Retirar" +
                "\r\n5.Imprimir reporte" +
                "\r\n6.Salir");
        }
    }
}
