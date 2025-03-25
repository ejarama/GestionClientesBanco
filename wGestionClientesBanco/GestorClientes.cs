using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            try
            {
                if (clientes.Any(c => c.Identificacion == cliente.Identificacion))
                    throw new InvalidOperationException("Ya existe un cliente con esta identificación.");
                clientes.Add(cliente);
            }
            catch (Exception ex)
            {

                throw ex; 
            }
        }

        public void EliminarCliente(string identificacion)
        {
            try
            {
                var cliente = clientes.FirstOrDefault(c => c.Identificacion == identificacion);
                if (cliente != null)
                    clientes.Remove(cliente);
                else
                    throw new InvalidOperationException("Cliente no encontrado.");

            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        public List<Cliente> ObtenerClientes()
        {
            try
            {
                return clientes;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        } 

        public void EditarCliente(string identificacion, string nuevoNombre, decimal nuevoSaldo)
        {
            try
            {
                var cliente = clientes.FirstOrDefault(c => c.Identificacion == identificacion);
                if (cliente == null)
                {
                    throw new InvalidOperationException("Cliente no encontrado.");
                }

                cliente.Nombre = nuevoNombre;
                cliente.Saldo = nuevoSaldo;
                
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
