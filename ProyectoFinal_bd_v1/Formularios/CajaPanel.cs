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
    public partial class CajaPanel : Form
    {
        ConexionBD con = new ConexionBD("Administrador");
        public CajaPanel()
        {
            InitializeComponent();
        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            Administrador miAdmin = new Administrador();
            miAdmin.Show();
            this.Hide();
        }
        public void ActualizarGridCaja()
        {
            //Mando a traer los campos que tiene la tabla persona contacto
            this.con.ActualizarGrid(this.dgvCaja, "select * from ActualizarGridCaja");

        }
        private void CajaPanel_Load(object sender, EventArgs e)
        {
            ActualizarGridCaja();
            chkDisponibleCaja.Checked = true;

            dgvCaja.ReadOnly = true;
            dgvCaja.AllowUserToAddRows = false;
            dgvCaja.AllowUserToDeleteRows = false;
            dgvCaja.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCaja.MultiSelect = false;
            dgvCaja.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            txtNumeroCaja.MaxLength = 5;
            txtPlacasCaja.MaxLength = 9;
        }
        void LimpiarCaja()
        {
            foreach (Control control in grbCaja.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
            }
        }

        private void btnAgregarCaja_Click(object sender, EventArgs e)
        {
            try
            {
                Caja miCaja = new Caja();
                miCaja.PlacasCaja = txtPlacasCaja.Text.ToUpper();
                miCaja.NumeroCaja = int.Parse(txtNumeroCaja.Text);
                miCaja.Disponible = bool.Parse(chkDisponibleCaja.Checked.ToString().ToUpper());
                miCaja.Disponible = true;

                if (miCaja.IngresarCaja())
                {
                    MessageBox.Show("Operacion realizada correctamente", "La base de datos a sido modificada",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.ActualizarGridCaja();
                this.LimpiarCaja();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificarCaja_Click(object sender, EventArgs e)
        {
            try
            {
                Caja miCaja = new Caja();
                miCaja.PlacasCaja = txtPlacasCaja.Text.ToUpper();
                miCaja.NumeroCaja = int.Parse(txtNumeroCaja.Text);
                miCaja.Disponible = bool.Parse(chkDisponibleCaja.Checked.ToString().ToUpper());


                //miCaja.PlacasCaja = this.dgvCaja.CurrentRow.Cells[0].Value.ToString();
                if (miCaja.ActualizarCaja())
                {
                    MessageBox.Show("Operacion realizada correctamente", "La base de datos a sido modificada",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.ActualizarGridCaja();
                this.LimpiarCaja();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                return;
            }
        }

        private void btnEliminarCaja_Click(object sender, EventArgs e)
        {
            try
            {
                Caja miCaja = new Caja();
                miCaja.PlacasCaja = this.dgvCaja.CurrentRow.Cells[0].Value.ToString();
               miCaja.NumeroCaja = int.Parse(this.dgvCaja.CurrentRow.Cells[1].Value.ToString());
                miCaja.Disponible = bool.Parse(this.dgvCaja.CurrentRow.Cells[2].Value.ToString());

                var resultado = MessageBox.Show("¿Desea eliminar el registro?", "Confirmación de eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    if (miCaja.EliminarCaja())
                    {
                        MessageBox.Show("Operacion realizada correctamente", "La base de datos a sido modificada",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    ActualizarGridCaja();
                    LimpiarCaja();

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

        private void dgvCaja_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPlacasCaja.Text = this.dgvCaja.CurrentRow.Cells[0].Value.ToString();
            txtNumeroCaja.Text = this.dgvCaja.CurrentRow.Cells[1].Value.ToString();
            chkDisponibleCaja.Checked = bool.Parse(this.dgvCaja.CurrentRow.Cells[2].Value.ToString());
        }

        private void dgvCaja_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPlacasCaja.Text = this.dgvCaja.CurrentRow.Cells[0].Value.ToString();
            txtNumeroCaja.Text = this.dgvCaja.CurrentRow.Cells[1].Value.ToString();
            chkDisponibleCaja.Checked = bool.Parse(this.dgvCaja.CurrentRow.Cells[2].Value.ToString());
        }

        private void txtNumeroCaja_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
