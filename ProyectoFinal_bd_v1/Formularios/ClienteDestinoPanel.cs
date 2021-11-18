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
    public partial class ClienteDestinoPanel : Form
    {
        ConexionBD con = new ConexionBD("Administrador");
        
        public ClienteDestinoPanel()
        {
            InitializeComponent();
        }
        public void ActualizarGridClienteDestino()
        {
            //Mando a traer los campos que tiene la tabla persona contacto
            this.con.ActualizarGrid(this.dgvClienteDestino, "select * from ActualizarGridClienteDestino");
            //ListarPersonaContacto();
        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            Administrador miAdmin = new Administrador();
            miAdmin.Show();
            this.Hide();
        }

        #region Acciones
        private void btnAgregarClienteDestino_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteDestino miClienteDestino = new ClienteDestino();
                //validar();
                miClienteDestino.RFC = txtRFCClienteDestino.Text.ToUpper();
                miClienteDestino.RazonSocial = txtRazonSClienteDestino.Text.ToUpper();
                miClienteDestino.Direccion = txtDireccionClienteDestino.Text.ToUpper();
                miClienteDestino.Telefono = txtTelefonoClienteDestino.Text.ToUpper();
                miClienteDestino.NombrePersonaContactoDestino = txtNombrePersonaContactoDestino.Text.ToUpper();
                miClienteDestino.PuestoContactoDestino = txtPuestoDestino.Text.ToUpper();
                miClienteDestino.CodigoPostalDestino = cmbCiudadClienteDestino.SelectedValue.ToString();
                if (miClienteDestino.InsertarClienteDestino())
                {
                    MessageBox.Show("Operacion realizada correctamente", "La base de datos a sido modificada",
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.ActualizarGridClienteDestino();
                this.Limpiar();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminarClienteDestino_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteDestino miClienteDestino = new ClienteDestino();
                miClienteDestino.RFC = this.dgvClienteDestino.CurrentRow.Cells[0].Value.ToString();
                miClienteDestino.RazonSocial = this.dgvClienteDestino.CurrentRow.Cells[1].Value.ToString();
                miClienteDestino.Direccion = this.dgvClienteDestino.CurrentRow.Cells[2].Value.ToString();
                miClienteDestino.Telefono = this.dgvClienteDestino.CurrentRow.Cells[3].Value.ToString();
                miClienteDestino.NombrePersonaContactoDestino = this.dgvClienteDestino.CurrentRow.Cells[4].Value.ToString();
                miClienteDestino.PuestoContactoDestino = this.dgvClienteDestino.CurrentRow.Cells[5].Value.ToString();
                miClienteDestino.CodigoPostalDestino = this.dgvClienteDestino.CurrentRow.Cells[6].Value.ToString();


                var resultado = MessageBox.Show("¿Desea eliminar el registro?", "Confirmación de eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    if(miClienteDestino.EliminarClienteDestino())
                    {
                        MessageBox.Show("Operacion realizada correctamente", "La base de datos a sido modificada",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    ActualizarGridClienteDestino();
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

        private void btnModificarClienteDestino_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteDestino miClienteDestino = new ClienteDestino();
                miClienteDestino.RFC = txtRFCClienteDestino.Text.ToUpper();
                miClienteDestino.RazonSocial = txtRazonSClienteDestino.Text.ToUpper();
                miClienteDestino.Direccion = txtDireccionClienteDestino.Text.ToUpper();
                miClienteDestino.Telefono = txtTelefonoClienteDestino.Text.ToUpper();
                miClienteDestino.NombrePersonaContactoDestino = txtNombrePersonaContactoDestino.Text.ToUpper();
                miClienteDestino.PuestoContactoDestino = txtPuestoDestino.Text.ToUpper();
                miClienteDestino.CodigoPostalDestino = cmbCiudadClienteDestino.SelectedValue.ToString();
                if (miClienteDestino.ActualizarClienteDestino())
                {
                    MessageBox.Show("Operacion realizada correctamente", "La base de datos a sido modificada",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.ActualizarGridClienteDestino();
                this.Limpiar();

            }
            catch (SqlException E)
            {
                MessageBox.Show(E.Message);
                return;
            }
        }
        #endregion
        private void ClienteDestinoPanel_Load(object sender, EventArgs e)
        {
            dgvClienteDestino.ReadOnly = true;
            dgvClienteDestino.AllowUserToAddRows = false;
            dgvClienteDestino.AllowUserToDeleteRows = false;
            dgvClienteDestino.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClienteDestino.MultiSelect = false;
            dgvClienteDestino.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            ActualizarGridClienteDestino();
            LlenarCiudades();

            txtRFCClienteDestino.MaxLength = 13;
            txtTelefonoClienteDestino.MaxLength = 10;
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
                cmbCiudadClienteDestino.DisplayMember = "NOMBRECIUDAD";
                cmbCiudadClienteDestino.ValueMember = "CODIGOPOSTAL";
                cmbCiudadClienteDestino.DataSource = ds.Tables["Ciudad"];
                conbd.CerrarConexion();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }
        public void Limpiar()
        {
            foreach (Control control in grbCliente.Controls)
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
            cmbCiudadClienteDestino.SelectedIndex = -1;
        }

        #region Restricciones
        private void txtTelefonoClienteDestino_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtNombrePersonaContactoDestino_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPuestoDestino_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        #endregion

        private void dgvClienteDestino_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRFCClienteDestino.Text = this.dgvClienteDestino.CurrentRow.Cells[0].Value.ToString();
            txtRazonSClienteDestino.Text = this.dgvClienteDestino.CurrentRow.Cells[1].Value.ToString();
            txtDireccionClienteDestino.Text = this.dgvClienteDestino.CurrentRow.Cells[2].Value.ToString();
            txtTelefonoClienteDestino.Text = this.dgvClienteDestino.CurrentRow.Cells[3].Value.ToString();
            txtNombrePersonaContactoDestino.Text = this.dgvClienteDestino.CurrentRow.Cells[4].Value.ToString();
            txtPuestoDestino.Text = this.dgvClienteDestino.CurrentRow.Cells[5].Value.ToString();
            cmbCiudadClienteDestino.SelectedValue = this.dgvClienteDestino.CurrentRow.Cells[6].Value.ToString();
        }

        private void dgvClienteDestino_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRFCClienteDestino.Text = this.dgvClienteDestino.CurrentRow.Cells[0].Value.ToString();
            txtRazonSClienteDestino.Text = this.dgvClienteDestino.CurrentRow.Cells[1].Value.ToString();
            txtDireccionClienteDestino.Text = this.dgvClienteDestino.CurrentRow.Cells[2].Value.ToString();
            txtTelefonoClienteDestino.Text = this.dgvClienteDestino.CurrentRow.Cells[3].Value.ToString();
            txtNombrePersonaContactoDestino.Text = this.dgvClienteDestino.CurrentRow.Cells[4].Value.ToString();
            txtPuestoDestino.Text = this.dgvClienteDestino.CurrentRow.Cells[5].Value.ToString();
            cmbCiudadClienteDestino.SelectedValue = this.dgvClienteDestino.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
