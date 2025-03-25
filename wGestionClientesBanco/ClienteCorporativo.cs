using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wGestionClientesBanco
{
    public class ClienteCorporativo : Cliente
    {
        public bool AccesoLineaCredito { get; private set; }

        public ClienteCorporativo(string nombre, string identificacion, decimal saldo) : base(nombre, identificacion, saldo)
        {
            AccesoLineaCredito = saldo > 50000000;
           
        }

        public override string CalcularBeneficio() => AccesoLineaCredito ? "Acceso a línea de crédito aprobado." : "No cuenta con saldo suficiente para acceso a línea de crédito.";
    }
}
