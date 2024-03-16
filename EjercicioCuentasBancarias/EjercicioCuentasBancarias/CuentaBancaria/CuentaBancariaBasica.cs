using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCuentasBancarias.CuentaBancaria
{
    public class CuentaBancariaBasica : CuentaBancariaBase
    {
        public CuentaBancariaBasica(string idCuenta, string nombrePropietario,
            double balance, double porcentajeInteres) : base(idCuenta, nombrePropietario, balance, porcentajeInteres) { }
        public override double CalcularInteres()
        {
            double interesGanado = base.Balance * base.PorcentajeInteres;
            return interesGanado;
        }

        public override void Depositar(double monto)
        {
            base.Balance += monto;
        }

        public override void Retirar(double monto)
        {
            base.Balance -= monto;
        }

        public override string ToString()
        {
            string respuesta = "Id Cuenta: " + base.IdCuenta+
                "\nNombre Propietario: " + base.NombrePropietario+
                "\nBalance: " + base.Balance+
                "\nPorcentaje Interes: " + base.PorcentajeInteres+
                "\nInteresesGanados: "+ CalcularInteres();
            return respuesta;
        }
    }
}
