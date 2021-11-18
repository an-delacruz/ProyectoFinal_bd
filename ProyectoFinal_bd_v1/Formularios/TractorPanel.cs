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
    public partial class TractorPanel : Form
    {
        ConexionBD con = new ConexionBD("Capturista");
        public TractorPanel()
        {
            InitializeComponent();
        }
        public void ActualizarGridTractor()
        {
            //Mando a traer los campos que tiene la tabla persona contacto
            this.con.ActualizarGrid(this.dgvTractor, "select * from ActualizarGridTractor");

        }
        private void TractorPanel_Load(object sender, EventArgs e)
        {
            ActualizarGridTractor();

            chkDisponibilidadTractor.Checked = true;

            dgvTractor.ReadOnly = true;
            dgvTractor.AllowUserToAddRows = false;
            dgvTractor.AllowUserToDeleteRows = false;
            dgvTractor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTractor.MultiSelect = false;
            dgvTractor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            txtPlacastractor.MaxLength = 9;
        }
        void LimpiarTractor()
        {
            foreach (Control control in grbTractor.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
            }
        }
        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            Administrador miAdmin = new Administrador();
            miAdmin.Show();
            this.Hide();
        }
        #region Acciones
        private void btnAgregarTractor_Click(object sender, EventArgs e)
        {
            try
            {
                Tractor miTractor = new Tractor();
                miTractor.PlacasTractor = txtPlacastractor.Text.ToUpper();
                miTractor.EquipoFrontal = txtEquipoFrontalTractor.Text.ToUpper();
                miTractor.Modelo = txtModeloTractor.Text.ToUpper();
                miTractor.Disponible = true;
                if (miTractor.IngresarTractor())
                {
                    MessageBox.Show("Operacion realizada correctamente", "La base de datos a sido modificada",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.ActualizarGridTractor();
                this.LimpiarTractor();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificarTractor_Click(object sender, EventArgs e)
        {
            try
            {
                Tractor miTractor = new Tractor();
                miTractor.PlacasTractor = txtPlacastractor.Text.ToUpper();
                miTractor.EquipoFrontal = txtEquipoFrontalTractor.Text.ToUpper();
                miTractor.Modelo = txtModeloTractor.Text.ToUpper();
                if (chkDisponibilidadTractor.Checked)
                    miTractor.Disponible = true;
                else
                    miTractor.Disponible = false;

                miTractor.PlacasTractor = this.dgvTractor.CurrentRow.Cells[0].Value.ToString();

                if (miTractor.ActualizarTractor())
                {
                    MessageBox.Show("Operacion realizada correctamente", "La base de datos a sido modificada",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.ActualizarGridTractor();
                this.LimpiarTractor();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                return;
            }
        }

        private void btnEliminarTractor_Click(object sender, EventArgs e)
        {
            try
            {
                Tractor miTractor = new Tractor();
                miTractor.PlacasTractor = this.dgvTractor.CurrentRow.Cells[0].Value.ToString();
                miTractor.EquipoFrontal = this.dgvTractor.CurrentRow.Cells[1].Value.ToString();
                miTractor.Modelo = this.dgvTractor.CurrentRow.Cells[2].Value.ToString();
                miTractor.Disponible= bool.Parse(this.dgvTractor.CurrentRow.Cells[3].Value.ToString());

                var resultado = MessageBox.Show("¿Desea eliminar el registro?", "Confirmación de eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    if (miTractor.EliminarTractor())
                    {
                        MessageBox.Show("Operacion realizada correctamente", "La base de datos a sido modificada",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    ActualizarGridTractor();
                    LimpiarTractor();
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

        private void dgvTractor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPlacastractor.Text = this.dgvTractor.CurrentRow.Cells[0].Value.ToString();
            txtEquipoFrontalTractor.Text = this.dgvTractor.CurrentRow.Cells[1].Value.ToString();
            txtModeloTractor.Text = this.dgvTractor.CurrentRow.Cells[2].Value.ToString();
            chkDisponibilidadTractor.Checked = bool.Parse(this.dgvTractor.CurrentRow.Cells[3].Value.ToString());
        }

        private void dgvTractor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPlacastractor.Text = this.dgvTractor.CurrentRow.Cells[0].Value.ToString();
            txtEquipoFrontalTractor.Text = this.dgvTractor.CurrentRow.Cells[1].Value.ToString();
            txtModeloTractor.Text = this.dgvTractor.CurrentRow.Cells[2].Value.ToString();
            chkDisponibilidadTractor.Checked = bool.Parse(this.dgvTractor.CurrentRow.Cells[3].Value.ToString());
        }
    }
}
