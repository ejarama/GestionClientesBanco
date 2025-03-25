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

                if (txtCuentasActivas.Text == "")
                    txtCuentasActivas.Text = "0";
                if (!int.TryParse(txtCuentasActivas.Text, out int cuentasActivas) || cuentasActivas <0)
                {
                    MessageBox.Show("Error en la cantidad de cuentas activas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                var cliente = ClienteFactory.CrearCliente(tipoCliente, nombre, identificacion, saldo, cuentasActivas);
                
                GestorClientes.Instancia.AgregarCliente(cliente);

                MessageBox.Show("Cliente agregado con éxito. \n" + cliente.CalcularBeneficio(), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //MessageBox.Show(cliente.CalcularBeneficio(), "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
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
            txtIdentificacion.Focus();
            txtCuentasActivas.Clear();
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
            try
            {
                string identificacion = txtIdentificacion.Text.Trim().ToUpper();
                if (string.IsNullOrWhiteSpace(identificacion))
                {
                    MessageBox.Show("El campo identificación no puede estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                GestorClientes.Instancia.EliminarCliente(identificacion);
                MessageBox.Show("Cliente fue eliminado con éxito.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            try
            {
                List<Cliente> listaClientes = GestorClientes.Instancia.ObtenerClientes();
                actualizarLista(listaClientes);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                string identificacion = txtIdentificacion.Text.Trim().ToUpper();
                if (string.IsNullOrWhiteSpace(identificacion))
                {
                    MessageBox.Show("El campo identificación no puede estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //busca el cliente con esa identificación
                var cliente = GestorClientes.Instancia.ObtenerClientes()
                                .FirstOrDefault(c => c.Identificacion == identificacion);

                if (cliente == null)
                {
                    MessageBox.Show("Cliente no encontrado.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //valida los datos a ingresar

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

                if (!decimal.TryParse(txtSaldo.Text, out decimal saldo) || saldo < 0)
                {
                    MessageBox.Show("Ingrese un saldo valido mayor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (txtCuentasActivas.Text == "")
                    txtCuentasActivas.Text = "0";
                if (!int.TryParse(txtCuentasActivas.Text, out int cuentasActivas) || cuentasActivas < 0)
                {
                    MessageBox.Show("Error en la cantidad de cuentas activas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                cliente.Nombre = nombre;
                cliente.Saldo = saldo;
                if (tipoCliente == "Individual")
                {
                    if (cuentasActivas > 3)
                        throw new InvalidOperationException("Clientes Individuales no pueden tener más de 3 cuentas activas.");

                }
                MessageBox.Show("Cliente fue actualizado con éxito.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                LimpiarCampos();


            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error: {ex.Message}","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtIdentificacion_Leave(object sender, EventArgs e)
        {
            try
            {
                string identificacion = txtIdentificacion.Text.Trim().ToUpper();
                if (!string.IsNullOrWhiteSpace(identificacion))
                {
                    //busca el cliente con esa identificación
                    var cliente = GestorClientes.Instancia.ObtenerClientes()
                                    .FirstOrDefault(c => c.Identificacion == identificacion);

                    if (cliente != null)
                    {
                        txtNombre.Text = cliente.Nombre;
                        txtSaldo.Text = cliente.Saldo.ToString();

                    }
                    else
                    {
                        txtNombre.Clear();
                        txtSaldo.Clear();
                        txtCuentasActivas.Clear();
                    }
                    return;

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void lstClientes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (lstClientes.SelectedItem != null)
                {
                    var clienteSeleccionado = lstClientes.SelectedItem.ToString();

                    // Extraer la identificación
                    string identificacion = clienteSeleccionado.Split(new[] { "Identificación: ", ", " }, StringSplitOptions.None)[1];

                    // Buscar el cliente usando la identificación
                    var cliente = GestorClientes.Instancia.ObtenerClientes()
                                        .FirstOrDefault(c => c.Identificacion == identificacion);

                    if (cliente != null)
                    {
                        txtIdentificacion.Text = cliente.Identificacion;
                        txtNombre.Text = cliente.Nombre;
                        txtSaldo.Text = cliente.Saldo.ToString();

                    }
                    else
                    {
                        txtNombre.Clear();
                        txtSaldo.Clear();
                        txtCuentasActivas.Clear();
                    }
                    return;

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
