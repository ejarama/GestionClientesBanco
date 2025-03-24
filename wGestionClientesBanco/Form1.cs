using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wGestionClientesBanco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbTipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string tipoCliente = cmbTipoCliente.SelectedItem.ToString();

                if (tipoCliente == "Individual")
                {
                    lblCuentasActivas.Visible = true;
                    txtCuentasActivas.Visible = true;
                    lblAplicaCredito.Visible = false;
                    txtAplicaCredito.Visible = false;
                }
                else
                {
                    lblCuentasActivas.Visible = false;
                    txtCuentasActivas.Visible = false;
                   
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string tipoCliente = "";
                if (cmbTipoCliente.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar un tipo de cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    tipoCliente = cmbTipoCliente.SelectedItem.ToString();
                }


                string nombre = txtNombre.Text.Trim().ToUpper();
                if (string.IsNullOrWhiteSpace(nombre))
                {
                    MessageBox.Show("El nombre no puede estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string identificacion = txtIdentificacion.Text.Trim().ToUpper();
                if (string.IsNullOrWhiteSpace(identificacion))
                {
                    MessageBox.Show("El campo identificación no puede estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!decimal.TryParse(txtSaldo.Text, out decimal saldo) || saldo < 0)
                {
                    MessageBox.Show("Ingrese un saldo valido mayor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

               
                if (!int.TryParse(txtCuentasActivas.Text, out int cuentasActivas) || cuentasActivas < 0)
                {
                    MessageBox.Show("Error en la cantidad de cuentas activas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                var cliente = ClienteFactory.CrearCliente(tipoCliente, nombre, identificacion, saldo, cuentasActivas);
                
                GestorClientes.Instancia.AgregarCliente(cliente);

                MessageBox.Show("Cliente agregado con éxito.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(cliente.CalcularBeneficio(), "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List<Cliente> listaClientes = new List<Cliente>();
                listaClientes = GestorClientes.Instancia.ObtenerClientes();
                actualizarLista(listaClientes);
                LimpiarCampos();

            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LimpiarCampos()
        {
            txtNombre.Clear();
            txtIdentificacion.Clear();
            txtSaldo.Clear();
            cmbTipoCliente.SelectedItem = 0;
            txtNombre.Focus();
        }

        public void actualizarLista(List<Cliente> listaClientes)
        {
            lstClientes.Items.Clear();
            
            foreach (var cliente in listaClientes)
            {
                lstClientes.Items.Add($"{cliente.Nombre} - Identificación: {cliente.Identificacion}, Saldo: {cliente.Saldo}");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
