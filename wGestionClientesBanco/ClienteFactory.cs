using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wGestionClientesBanco
{
    class ClienteFactory
    {
        public static Cliente CrearCliente(string tipo, string nombre, string identificacion, decimal saldo, int cantidadCuentasActivas = 0)
        {
            if (tipo == "Corporativo")
            {
                return new ClienteCorporativo(nombre, identificacion, saldo);
            }
            else if (tipo == "Individual")
            {
                return new ClienteIndividual(nombre, identificacion, saldo, cantidadCuentasActivas);
            }
            else
            {
                throw new ArgumentException("Tipo de empleado no valido");
            }

        }
    }
}
