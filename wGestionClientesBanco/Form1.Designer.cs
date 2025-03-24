
namespace wGestionClientesBanco
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbTipoCliente = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblIdentificacion = new System.Windows.Forms.Label();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.lstClientes = new System.Windows.Forms.ListBox();
            this.lblCuentasActivas = new System.Windows.Forms.Label();
            this.txtCuentasActivas = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblGestionCliente = new System.Windows.Forms.Label();
            this.lblAplicaCredito = new System.Windows.Forms.Label();
            this.txtAplicaCredito = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbTipoCliente
            // 
            this.cmbTipoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoCliente.FormattingEnabled = true;
            this.cmbTipoCliente.Items.AddRange(new object[] {
            "Corporativo",
            "Individual"});
            this.cmbTipoCliente.Location = new System.Drawing.Point(96, 190);
            this.cmbTipoCliente.Name = "cmbTipoCliente";
            this.cmbTipoCliente.Size = new System.Drawing.Size(377, 45);
            this.cmbTipoCliente.TabIndex = 0;
            this.cmbTipoCliente.Text = "Tipo de Cliente";
            this.cmbTipoCliente.SelectedIndexChanged += new System.EventHandler(this.cmbTipoCliente_SelectedIndexChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(339, 297);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(323, 44);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(89, 300);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(132, 37);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lblIdentificacion
            // 
            this.lblIdentificacion.AutoSize = true;
            this.lblIdentificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentificacion.Location = new System.Drawing.Point(89, 394);
            this.lblIdentificacion.Name = "lblIdentificacion";
            this.lblIdentificacion.Size = new System.Drawing.Size(203, 37);
            this.lblIdentificacion.TabIndex = 4;
            this.lblIdentificacion.Text = "Identificación";
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentificacion.Location = new System.Drawing.Point(339, 387);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(323, 44);
            this.txtIdentificacion.TabIndex = 3;
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(89, 468);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(99, 37);
            this.lblSaldo.TabIndex = 6;
            this.lblSaldo.Text = "Saldo";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldo.Location = new System.Drawing.Point(339, 465);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(323, 44);
            this.txtSaldo.TabIndex = 5;
            // 
            // lstClientes
            // 
            this.lstClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstClientes.FormattingEnabled = true;
            this.lstClientes.ItemHeight = 37;
            this.lstClientes.Location = new System.Drawing.Point(721, 190);
            this.lstClientes.Name = "lstClientes";
            this.lstClientes.Size = new System.Drawing.Size(522, 485);
            this.lstClientes.TabIndex = 7;
            // 
            // lblCuentasActivas
            // 
            this.lblCuentasActivas.AutoSize = true;
            this.lblCuentasActivas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuentasActivas.Location = new System.Drawing.Point(89, 544);
            this.lblCuentasActivas.Name = "lblCuentasActivas";
            this.lblCuentasActivas.Size = new System.Drawing.Size(386, 37);
            this.lblCuentasActivas.TabIndex = 9;
            this.lblCuentasActivas.Text = "Cantidad Cuentas Activas";
            this.lblCuentasActivas.Visible = false;
            // 
            // txtCuentasActivas
            // 
            this.txtCuentasActivas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuentasActivas.Location = new System.Drawing.Point(524, 537);
            this.txtCuentasActivas.Name = "txtCuentasActivas";
            this.txtCuentasActivas.Size = new System.Drawing.Size(138, 44);
            this.txtCuentasActivas.TabIndex = 8;
            this.txtCuentasActivas.Visible = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(150, 743);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(172, 86);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(437, 743);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(172, 86);
            this.btnEditar.TabIndex = 11;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(734, 743);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 86);
            this.button1.TabIndex = 12;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1018, 743);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 86);
            this.button2.TabIndex = 13;
            this.button2.Text = "Mostrar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblGestionCliente
            // 
            this.lblGestionCliente.AutoSize = true;
            this.lblGestionCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionCliente.Location = new System.Drawing.Point(380, 63);
            this.lblGestionCliente.Name = "lblGestionCliente";
            this.lblGestionCliente.Size = new System.Drawing.Size(567, 55);
            this.lblGestionCliente.TabIndex = 14;
            this.lblGestionCliente.Text = "GESTION DE CLIENTES";
            // 
            // lblAplicaCredito
            // 
            this.lblAplicaCredito.AutoSize = true;
            this.lblAplicaCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAplicaCredito.Location = new System.Drawing.Point(89, 629);
            this.lblAplicaCredito.Name = "lblAplicaCredito";
            this.lblAplicaCredito.Size = new System.Drawing.Size(348, 37);
            this.lblAplicaCredito.TabIndex = 15;
            this.lblAplicaCredito.Text = "Aplica Línea de Crédito";
            this.lblAplicaCredito.Visible = false;
            // 
            // txtAplicaCredito
            // 
            this.txtAplicaCredito.Enabled = false;
            this.txtAplicaCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAplicaCredito.Location = new System.Drawing.Point(522, 622);
            this.txtAplicaCredito.Name = "txtAplicaCredito";
            this.txtAplicaCredito.Size = new System.Drawing.Size(140, 44);
            this.txtAplicaCredito.TabIndex = 16;
            this.txtAplicaCredito.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 879);
            this.Controls.Add(this.txtAplicaCredito);
            this.Controls.Add(this.lblAplicaCredito);
            this.Controls.Add(this.lblGestionCliente);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblCuentasActivas);
            this.Controls.Add(this.txtCuentasActivas);
            this.Controls.Add(this.lstClientes);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.lblIdentificacion);
            this.Controls.Add(this.txtIdentificacion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.cmbTipoCliente);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTipoCliente;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblIdentificacion;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.ListBox lstClientes;
        private System.Windows.Forms.Label lblCuentasActivas;
        private System.Windows.Forms.TextBox txtCuentasActivas;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblGestionCliente;
        private System.Windows.Forms.Label lblAplicaCredito;
        private System.Windows.Forms.TextBox txtAplicaCredito;
    }
}

