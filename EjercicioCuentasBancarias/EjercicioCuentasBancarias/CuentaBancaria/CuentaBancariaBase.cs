using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCuentasBancarias.CuentaBancaria
{
    public abstract class CuentaBancariaBase
    {
        //Definición de propiedades automaticas
        public string IdCuenta { get; set; }
        public string NombrePropietario { get; set; }
        public double Balance { get; set; }
        public double PorcentajeInteres { get; set; }

        //Constructor por defecto
        public CuentaBancariaBase() { }
        //Definición del constructor e inicialización de propiedades
        public CuentaBancariaBase(string idCuenta, string nombrePropietario, 
            double balance, double porcetajeInteres) {
            IdCuenta = idCuenta;
            NombrePropietario = nombrePropietario;
            Balance = balance;
            PorcentajeInteres = porcetajeInteres;
        }
        //Definición de Metodos abstractos
        public abstract double CalcularInteres();
        public abstract void Depositar(double monto);
        public abstract void Retirar(double monto);
    }
}
