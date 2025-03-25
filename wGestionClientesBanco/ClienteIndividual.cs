using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wGestionClientesBanco
{
    public class ClienteIndividual : Cliente
    {
        public int CantidadCuentasActivas { get; set; }

        public ClienteIndividual(string nombre, string identificacion, decimal saldo, int cantidadCuentasActivas) : base(nombre, identificacion, saldo)
        {
            if (cantidadCuentasActivas > 3)
            {
               throw new InvalidOperationException("Clientes Individuales no pueden tener más de 3 cuentas activas.");
            }

            CantidadCuentasActivas = cantidadCuentasActivas;
        }

        public override string CalcularBeneficio() => $" Cliente Individual con {CantidadCuentasActivas} cuentas activas.";

    }
    
}
