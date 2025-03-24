using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wGestionClientesBanco
{
    class GestorClientes
    {
        private static GestorClientes _instancia;

        private List<Cliente> clientes;

        private GestorClientes()
        {
            clientes = new List<Cliente>();
        }

        public static GestorClientes Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new GestorClientes();

                }
                return _instancia;
                    
            }
        }

        public void AgregarCliente(Cliente cliente)
        {
            if (clientes.Any(c => c.Identificacion == cliente.Identificacion))
                throw new InvalidOperationException("Ya existe un cliente con esta identificación.");
            clientes.Add(cliente);
        }

        public void EliminarCliente(string identificacion)
        {
            var cliente = clientes.FirstOrDefault(c => c.Identificacion == identificacion);
            if (cliente != null)
                clientes.Remove(cliente);
            else
                throw new KeyNotFoundException("Cliente no encontrado.");
        }

        public List<Cliente> ObtenerClientes()
        {
            return clientes;
        } 
    }
}
