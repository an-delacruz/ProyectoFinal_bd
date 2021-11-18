using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_bd_v1.Formularios
{
    public partial class OperadorPanel : Form
    {
        ConexionBD con = new ConexionBD("Administrador");
        public OperadorPanel()
        {
            InitializeComponent();
        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            Administrador miAdmin = new Administrador();
            miAdmin.Show();
            this.Hide();
        }
        public void ActualizarGridOperador()
        {
            //Mando a traer los campos que tiene la tabla persona contacto
            this.con.ActualizarGrid(this.dgvOperadorPanel, "Select * from ActualizarGridOperador");

        }
        private void OperadorPanel_Load(object sender, EventArgs e)
        {
            ActualizarGridOperador();
            chkDisponibilidadOperador.Checked = true;
            dgvOperadorPanel.ReadOnly = true;
            dgvOperadorPanel.AllowUserToAddRows = false;
            dgvOperadorPanel.AllowUserToDeleteRows = false;
            dgvOperadorPanel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOperadorPanel.MultiSelect = false;
            dgvOperadorPanel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            txtNSSOperador.MaxLength = 11;
            txtRFCOperador.MaxLength = 13;
            txtTelefonoOperador.MaxLength = 10;
        }
        void LimpiarOperador()
        {
            foreach (Control control in grbOperador.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
            }
        }
        #region Acciones
        private void btnAgregarOperador_Click(object sender, EventArgs e)
        {
            try
            {
                Operador miOperador = new Operador();
                miOperador.ClaveOperador = 0;
                miOperador.RFC = txtRFCOperador.Text;
                miOperador.NSS = txtNSSOperador.Text;
                miOperador.Nombre = txtNombreOperador.Text;
                miOperador.Apmaterno = txtApmaternoOperador.Text;
                miOperador.Appaterno = txtAppaternoOperador.Text;
                miOperador.Telefono = txtTelefonoOperador.Text;
                miOperador.Direccion = txtDireccionOperador.Text;
                miOperador.SalarioBase = decimal.Parse(txtSalarioBaseOperador.Text);
                miOperador.Disponible = true;
                if(miOperador.IngresarOperador())
                {
                    MessageBox.Show("Operacion realizada correctamente", "La base de datos a sido modificada",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                ActualizarGridOperador();
                LimpiarOperador();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                return;

            }

            
        }

        private void btnModificarOperador_Click(object sender, EventArgs e)
        {
            try
            {
                Operador miOperador = new Operador();
                miOperador.RFC = txtRFCOperador.Text;
                miOperador.NSS = txtNSSOperador.Text;
                miOperador.Nombre = txtNombreOperador.Text;
                miOperador.Apmaterno = txtApmaternoOperador.Text;
                miOperador.Appaterno = txtAppaternoOperador.Text;
                miOperador.Telefono = txtTelefonoOperador.Text;
                miOperador.Direccion = txtDireccionOperador.Text;
                miOperador.SalarioBase = decimal.Parse(txtSalarioBaseOperador.Text);
                if (chkDisponibilidadOperador.Checked)
                    miOperador.Disponible = true;
                else
                    miOperador.Disponible = false;

                miOperador.ClaveOperador = int.Parse(dgvOperadorPanel.CurrentRow.Cells[0].Value.ToString());
                if(miOperador.ActualizarOperador())
                {
                    MessageBox.Show("Operacion realizada correctamente", "La base de datos a sido modificada",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                ActualizarGridOperador();
                LimpiarOperador();

            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                return;
            }
        }

        private void btnEliminarOperador_Click(object sender, EventArgs e)
        {
            try
            {
                Operador miOperador = new Operador();

                miOperador.ClaveOperador = int.Parse(dgvOperadorPanel.CurrentRow.Cells[0].Value.ToString());
                miOperador.RFC= (dgvOperadorPanel.CurrentRow.Cells[1].Value.ToString());
                miOperador.Nombre= (dgvOperadorPanel.CurrentRow.Cells[2].Value.ToString());
                miOperador.Appaterno= (dgvOperadorPanel.CurrentRow.Cells[3].Value.ToString());
                miOperador.Apmaterno= (dgvOperadorPanel.CurrentRow.Cells[4].Value.ToString());
                miOperador.Telefono= (dgvOperadorPanel.CurrentRow.Cells[5].Value.ToString());
                miOperador.NSS=dgvOperadorPanel.CurrentRow.Cells[6].Value.ToString();
                miOperador.Direccion= (dgvOperadorPanel.CurrentRow.Cells[7].Value.ToString());
                miOperador.SalarioBase=decimal.Parse(dgvOperadorPanel.CurrentRow.Cells[8].Value.ToString());
                miOperador.Disponible= bool.Parse(dgvOperadorPanel.CurrentRow.Cells[9].Value.ToString());


                var res = MessageBox.Show("¿Desea eliminar al operador? \nEsta operacion es permanente.", "Confirmacion de eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    if (miOperador.EliminarOperador())
                    {
                        MessageBox.Show("Operacion realizada correctamente", "La base de datos a sido modificada",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    ActualizarGridOperador();
                    LimpiarOperador();

                }
                else
                {
                    return;
                }

            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                return;
            }
        }
        #endregion

        private void dgvOperadorPanel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRFCOperador.Text = this.dgvOperadorPanel.CurrentRow.Cells[1].Value.ToString();
            txtNSSOperador.Text = this.dgvOperadorPanel.CurrentRow.Cells[2].Value.ToString();
            txtNombreOperador.Text = this.dgvOperadorPanel.CurrentRow.Cells[3].Value.ToString();
            txtAppaternoOperador.Text = this.dgvOperadorPanel.CurrentRow.Cells[4].Value.ToString();
            txtApmaternoOperador.Text = this.dgvOperadorPanel.CurrentRow.Cells[5].Value.ToString();
            txtTelefonoOperador.Text = this.dgvOperadorPanel.CurrentRow.Cells[6].Value.ToString();
            txtDireccionOperador.Text = this.dgvOperadorPanel.CurrentRow.Cells[7].Value.ToString();
            txtSalarioBaseOperador.Text = this.dgvOperadorPanel.CurrentRow.Cells[8].Value.ToString();
            chkDisponibilidadOperador.Text = this.dgvOperadorPanel.CurrentRow.Cells[9].Value.ToString();
        }

        private void dgvOperadorPanel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRFCOperador.Text = this.dgvOperadorPanel.CurrentRow.Cells[1].Value.ToString();
            txtNSSOperador.Text = this.dgvOperadorPanel.CurrentRow.Cells[2].Value.ToString();
            txtNombreOperador.Text = this.dgvOperadorPanel.CurrentRow.Cells[3].Value.ToString();
            txtAppaternoOperador.Text = this.dgvOperadorPanel.CurrentRow.Cells[4].Value.ToString();
            txtApmaternoOperador.Text = this.dgvOperadorPanel.CurrentRow.Cells[5].Value.ToString();
            txtTelefonoOperador.Text = this.dgvOperadorPanel.CurrentRow.Cells[6].Value.ToString();
            txtDireccionOperador.Text = this.dgvOperadorPanel.CurrentRow.Cells[7].Value.ToString();
            txtSalarioBaseOperador.Text = this.dgvOperadorPanel.CurrentRow.Cells[8].Value.ToString();
            chkDisponibilidadOperador.Text = this.dgvOperadorPanel.CurrentRow.Cells[9].Value.ToString();
        }

        #region Restricciones
        private void txtNombreOperador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtAppaternoOperador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtApmaternoOperador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNSSOperador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void txtTelefonoOperador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void txtSalarioBaseOperador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }
        #endregion
    }
}
