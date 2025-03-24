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
                lblAplicaCredito.Visible = true;
                txtAplicaCredito.Visible = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}
