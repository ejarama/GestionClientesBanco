using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wGestionClientesBanco
{
    public abstract class Cliente
    {
        public string Nombre { get; set; }
        public string Identificacion { get; set; }
        public decimal Saldo { get; set; }

        public Cliente(string nombre, string identificacion, decimal saldo)
        {
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(identificacion) || saldo < 0)
            {
                throw new ArgumentException("Datos inválidos. Verifique el nombre, identificación y saldo.");
            }

            Nombre = nombre;
            Identificacion = identificacion;
            Saldo = saldo;
        }

        public abstract string CalcularBeneficio();


    }
}
