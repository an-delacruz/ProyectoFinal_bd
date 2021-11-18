using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_bd_v1.Formularios
{
    public partial class ClienteEmisorPanel : Form
    {
        ConexionBD con = new ConexionBD("Administrador");
        public ClienteEmisorPanel()
        {
            InitializeComponent();
        }
        public void ActualizarGridClienteEmisor()
        {
            //Mando a traer los campos que tiene la tabla persona contacto
            this.con.ActualizarGrid(this.dgvClienteEmisor, "Select * from ActualizarGridClienteEmisor");
            //ListarPersonaContacto();
        }
        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            Administrador miAdmin = new Administrador();
            miAdmin.Show();
            this.Hide();
        }

        #region Acciones
        private void btnAgregarClienteOrigen_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteEmisor miClienteEmisor = new ClienteEmisor();
                miClienteEmisor.RFC = txtRFCClienteOrigen.Text.ToUpper();
                miClienteEmisor.RazonSocial = txtRazonSClienteOrigen.Text.ToUpper();
                miClienteEmisor.Direccion = txtDireccionClienteOrigen.Text.ToUpper();
                miClienteEmisor.Telefono = txtTelefonoClienteOrigen.Text.ToUpper();
                miClienteEmisor.NombrePersonaContactoEmisor = txtNombrePersonaContactoOrigen.Text.ToUpper();
                miClienteEmisor.PuestoContactoEmisor = txtPuestoClienteOrigen.Text.ToUpper();
                miClienteEmisor.CodigoPostalEmisor = cmbCiudadClienteOrigen.SelectedValue.ToString();

                if (miClienteEmisor.IngresarClienteEmisor())
                {
                    this.ActualizarGridClienteEmisor();
                    MessageBox.Show("Operacion realizada correctamente", "La base de datos a sido modificada",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Limpiar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnEliminarClienteOrigen_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteEmisor miClienteEmisor = new ClienteEmisor();
                miClienteEmisor.RFC = this.dgvClienteEmisor.CurrentRow.Cells[0].Value.ToString();
                miClienteEmisor.RazonSocial = this.dgvClienteEmisor.CurrentRow.Cells[1].Value.ToString();
                miClienteEmisor.Direccion = this.dgvClienteEmisor.CurrentRow.Cells[2].Value.ToString();
                miClienteEmisor.Telefono = this.dgvClienteEmisor.CurrentRow.Cells[3].Value.ToString();
                miClienteEmisor.NombrePersonaContactoEmisor = this.dgvClienteEmisor.CurrentRow.Cells[4].Value.ToString();
                miClienteEmisor.PuestoContactoEmisor = this.dgvClienteEmisor.CurrentRow.Cells[5].Value.ToString();
                miClienteEmisor.CodigoPostalEmisor = this.dgvClienteEmisor.CurrentRow.Cells[6].Value.ToString();

                var resultado = MessageBox.Show("¿Desea eliminar el registro?", "Confirmación de eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {

                    if (miClienteEmisor.EliminarClienteEmisor())
                    {
                        MessageBox.Show("Operacion realizada correctamente", "La base de datos a sido modificada",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    ActualizarGridClienteEmisor();
                    Limpiar();

                }
                else
                {
                    return;
                }
            }
            catch (SqlException E)
            {
                MessageBox.Show(E.Message);
                return;
            }
        }

        private void btnModificarClienteOrigen_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteEmisor miClienteEmisor = new ClienteEmisor();
                miClienteEmisor.RFC = txtRFCClienteOrigen.Text.ToUpper();
                miClienteEmisor.RazonSocial = txtRazonSClienteOrigen.Text.ToUpper();
                miClienteEmisor.Direccion = txtDireccionClienteOrigen.Text.ToUpper();
                miClienteEmisor.Telefono = txtTelefonoClienteOrigen.Text.ToUpper();
                miClienteEmisor.NombrePersonaContactoEmisor = txtNombrePersonaContactoOrigen.Text.ToUpper();
                miClienteEmisor.PuestoContactoEmisor = txtPuestoClienteOrigen.Text.ToUpper();
                miClienteEmisor.CodigoPostalEmisor = cmbCiudadClienteOrigen.SelectedValue.ToString();

                if (miClienteEmisor.ActualizarClienteEmisor())
                {
                    MessageBox.Show("Operacion realizada correctamente", "La base de datos a sido modificada",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.ActualizarGridClienteEmisor();
                this.Limpiar();

            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                return;
            }
        }
        #endregion
        public void Limpiar()
        {
            foreach (Control control in grbClienteOrigen.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
            }
            foreach (Control c in grbPersonaContacto.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
            cmbCiudadClienteOrigen.SelectedIndex = -1;
        }

        #region Restricciones
        private void txtTelefonoClienteOrigen_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
                MessageBox.Show("Solo se permiten numeros");
            }
        }

        private void txtNombrePersonaContactoOrigen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPuestoClienteOrigen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        #endregion

        private void dgvClienteEmisor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRFCClienteOrigen.Text = this.dgvClienteEmisor.CurrentRow.Cells[0].Value.ToString();
            txtRazonSClienteOrigen.Text = this.dgvClienteEmisor.CurrentRow.Cells[1].Value.ToString();
            txtDireccionClienteOrigen.Text = this.dgvClienteEmisor.CurrentRow.Cells[2].Value.ToString();
            txtTelefonoClienteOrigen.Text = this.dgvClienteEmisor.CurrentRow.Cells[3].Value.ToString();
            txtNombrePersonaContactoOrigen.Text = this.dgvClienteEmisor.CurrentRow.Cells[4].Value.ToString();
            txtPuestoClienteOrigen.Text = this.dgvClienteEmisor.CurrentRow.Cells[5].Value.ToString();
            cmbCiudadClienteOrigen.SelectedValue = this.dgvClienteEmisor.CurrentRow.Cells[6].Value.ToString();
        }

        private void dgvClienteEmisor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRFCClienteOrigen.Text = this.dgvClienteEmisor.CurrentRow.Cells[0].Value.ToString();
            txtRazonSClienteOrigen.Text = this.dgvClienteEmisor.CurrentRow.Cells[1].Value.ToString();
            txtDireccionClienteOrigen.Text = this.dgvClienteEmisor.CurrentRow.Cells[2].Value.ToString();
            txtTelefonoClienteOrigen.Text = this.dgvClienteEmisor.CurrentRow.Cells[3].Value.ToString();
            txtNombrePersonaContactoOrigen.Text = this.dgvClienteEmisor.CurrentRow.Cells[4].Value.ToString();
            txtPuestoClienteOrigen.Text = this.dgvClienteEmisor.CurrentRow.Cells[5].Value.ToString();
            cmbCiudadClienteOrigen.SelectedValue = this.dgvClienteEmisor.CurrentRow.Cells[6].Value.ToString();
        }

        private void ClienteEmisorPanel_Load(object sender, EventArgs e)
        {
            dgvClienteEmisor.ReadOnly = true;
            dgvClienteEmisor.AllowUserToAddRows = false;
            dgvClienteEmisor.AllowUserToDeleteRows = false;
            dgvClienteEmisor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClienteEmisor.MultiSelect = false;
            dgvClienteEmisor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.ActualizarGridClienteEmisor();
            LlenarCiudades();

        }

        private void txtRazonSClienteOrigen_TextChanged(object sender, EventArgs e)
        {

        }
        void LlenarCiudades()
        {
            try
            {
                ConexionBD conbd = new ConexionBD("Administrador");
                string query = "SELECT CODIGOPOSTAL, NOMBRECIUDAD FROM CIUDAD";
                //cmd.Connection = conbd.AbrirConexion();
                SqlDataAdapter da = new SqlDataAdapter(query, conbd.AbrirConexion());

                DataSet ds = new DataSet();
                da.Fill(ds, "Ciudad");
                cmbCiudadClienteOrigen.DisplayMember = "NOMBRECIUDAD";
                cmbCiudadClienteOrigen.ValueMember = "CODIGOPOSTAL";
                cmbCiudadClienteOrigen.DataSource = ds.Tables["Ciudad"];
                conbd.CerrarConexion();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }
    }
}
