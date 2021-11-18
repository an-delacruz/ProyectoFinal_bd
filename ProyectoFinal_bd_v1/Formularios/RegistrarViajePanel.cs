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
    public partial class RegistrarViajePanel : Form
    {
        ConexionBD con = new ConexionBD("Capturista");
        public RegistrarViajePanel()
        {
            InitializeComponent();
        }

        private void txtDistanciaViaje_KeyPress(object sender, KeyPressEventArgs e)
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
            }
        }

        private void txtDieselAsignado_KeyPress(object sender, KeyPressEventArgs e)
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
            }
        }

        private void RegistrarViajePanel_Load(object sender, EventArgs e)
        {
            dgvViajes.ReadOnly = true;
            dgvViajes.AllowUserToAddRows = false;
            dgvViajes.AllowUserToDeleteRows = false;
            dgvViajes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvViajes.MultiSelect = false;
            dgvViajes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;



            #region DataGridViews
            dgvOperadorLista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ActualizarGridOperadores();
            dgvOperadorLista.Enabled = false;

            dgvTractorLista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTractorLista.Enabled = false;
            ActualizarGridTractores();

            dgvCajaLista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ActualizarGridCajas();
            dgvCajaLista.Enabled = false;

            dgvViajes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ActualizarGridViajes();
            #endregion
            #region ComboBox
            LlenarCiudades(cboDestino);
            LlenarCiudades(cboOrigen);
            LlenarClientesDestino();
            LlenarClientesEmisor();
            LlenarCaja();
            LlenarTractor();
            LlenarOperador();
            #endregion



        }
        #region Llenar ComboBox
        void LlenarCiudades(ComboBox cbo)
        {
            try
            {
                ConexionBD conbd = new ConexionBD("Capturista");
                string query = "SELECT CODIGOPOSTAL, NOMBRECIUDAD FROM CIUDAD";
                SqlDataAdapter da = new SqlDataAdapter(query, conbd.AbrirConexion());

                DataSet ds = new DataSet();
                da.Fill(ds, "Ciudad");
                cbo.DisplayMember = "NOMBRECIUDAD";
                cbo.ValueMember = "CODIGOPOSTAL";
                cbo.DataSource = ds.Tables["Ciudad"];
                //cboDestino.DisplayMember = "NOMBRECIUDAD";
                //cboDestino.ValueMember = "CODIGOPOSTAL";
                //cboDestino.DataSource = ds.Tables["Ciudad"];
                conbd.CerrarConexion();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }
        void LlenarClientesEmisor()
        {
            ConexionBD conbd = new ConexionBD("Capturista");
            string query = "SELECT RFC, RAZONSOCIAL FROM CLIENTEMISOR";
            SqlDataAdapter da = new SqlDataAdapter(query, conbd.AbrirConexion());

            DataSet ds = new DataSet();
            da.Fill(ds, "Cliente");
            cboClienteOrigen.DisplayMember = "RAZONSOCIAL";
            cboClienteOrigen.ValueMember = "RFC";
            cboClienteOrigen.DataSource = ds.Tables["Cliente"];
            conbd.CerrarConexion();
        }
        void LlenarClientesDestino()
        {
            ConexionBD conbd = new ConexionBD("Capturista");
            string query = "SELECT RFC, RAZONSOCIAL FROM CLIENTEDESTINO";
            SqlDataAdapter da = new SqlDataAdapter(query, conbd.AbrirConexion());

            DataSet ds = new DataSet();
            da.Fill(ds, "Cliente");
            cboClienteDestino.DisplayMember = "RAZONSOCIAL";
            cboClienteDestino.ValueMember = "RFC";
            cboClienteDestino.DataSource = ds.Tables["Cliente"];
            conbd.CerrarConexion();
        }
        void LlenarCaja()
        {
            cboCaja.Items.Clear();
            ConexionBD conbd = new ConexionBD("Capturista");
            SqlCommand cmd = new SqlCommand("SELECT PLACASCAJA FROM CAJA where Disponible=1");
            cmd.Connection = conbd.AbrirConexion();
            SqlDataReader sqlReader = cmd.ExecuteReader();
            while (sqlReader.Read())
            {
                cboCaja.Items.Add(sqlReader["PLACASCAJA"].ToString());
            }
            sqlReader.Close();
            conbd.CerrarConexion();
        }
        void LlenarTractor()
        {
            cboTractor.Items.Clear();
            ConexionBD conbd = new ConexionBD("Capturista");
            SqlCommand cmd = new SqlCommand("SELECT PLACASTRACTOR FROM TRACTOR WHERE DISPONIBLE=1");
            cmd.Connection = conbd.AbrirConexion();
            SqlDataReader sqlReader = cmd.ExecuteReader();
            while (sqlReader.Read())
            {
                cboTractor.Items.Add(sqlReader["PLACASTRACTOR"].ToString());
            }
            sqlReader.Close();
            conbd.CerrarConexion();
        }
        void LlenarOperador()
        {
            cboOperadores.Items.Clear();
            ConexionBD conbd = new ConexionBD("Capturista");
            SqlCommand cmd = new SqlCommand("SELECT CLAVEOPERADOR FROM OPERADOR where Disponible=1");
            cmd.Connection = conbd.AbrirConexion();
            SqlDataReader sqlReader = cmd.ExecuteReader();
            while (sqlReader.Read())
            {
                cboOperadores.Items.Add(sqlReader["CLAVEOPERADOR"].ToString());
            }
            sqlReader.Close();
            conbd.CerrarConexion();
        }
        #endregion

        #region MetodosActualizarGrid
        void ActualizarGridViajes()
        {
            con.ActualizarGrid(this.dgvViajes, "SELECT Clave, Origen, C2.NOMBRECIUDAD AS 'Destino', [Cliente Emisor], [Cliente Destino],Operador, Tractor, Caja, Finalizado  FROM(SELECT CLAVEVIAJE AS 'Clave', C.NOMBRECIUDAD AS 'Origen', CPDESTINO AS 'Destino', CE.RAZONSOCIAL AS 'Cliente Emisor', CD.RAZONSOCIAL AS 'Cliente Destino', CLAVEOPERADOR AS 'Operador', PLACASTRACTOR AS 'Tractor', PLACASCAJA AS 'Caja', VIAJEFINALIZADO AS 'Finalizado' FROM VIAJE AS V JOIN CLIENTEDESTINO AS CD ON CD.RFC = RFCDESTINO JOIN CLIENTEMISOR AS CE ON  CE.RFC = RFCEMISOR JOIN CIUDAD AS C ON C.CODIGOPOSTAL = CPEMISOR) AS V JOIN CIUDAD AS C2 ON C2.CODIGOPOSTAL = V.Destino");
        }
        void ActualizarGridOperadores()
        {
            this.con.ActualizarGrid(dgvOperadorLista, "SELECT CLAVEOPERADOR AS 'Clave Operador', Nombre, DISPONIBLE AS 'Disponible' FROM OPERADOR");
        }
        void ActualizarGridTractores()
        {
            this.con.ActualizarGrid(dgvTractorLista, "SELECT PLACASTRACTOR AS 'Placas Tractor', Modelo, DISPONIBLE AS 'Disponible' FROM TRACTOR");
        }
        void ActualizarGridCajas()
        {
            this.con.ActualizarGrid(dgvCajaLista, "SELECT PLACASCAJA AS 'Placas Caja', NUMEROCAJA AS 'No. Caja', DISPONIBLE AS 'Disponible' FROM CAJA");
        }
        #endregion

        private void btnAgregarViaje_Click(object sender, EventArgs e)
        {
            ConexionBD conbd = new ConexionBD("Capturista");
            //Se inicia la transaccion indicando el nivel de bloqueo
            SqlTransaction sqlTransaction = conbd.BeginTransaction(IsolationLevel.ReadCommitted);
            try
            {
                if (cboOrigen.SelectedIndex == -1 || cboDestino.SelectedIndex == -1 || cboClienteOrigen.SelectedIndex == -1 || cboClienteDestino.SelectedIndex == -1 || cboOperadores.SelectedIndex == -1 ||
                    cboTractor.SelectedIndex == -1 || cboCaja.SelectedIndex == -1)
                {
                    throw new Exception("Verifique que todos los campos han sido llenados.");
                }
                else
                {
                    Viaje miViaje = new Viaje();
                    miViaje.CPOrigen = cboOrigen.SelectedValue.ToString();
                    miViaje.CPDestino = cboDestino.SelectedValue.ToString();
                    miViaje.RFCEmisor = cboClienteOrigen.SelectedValue.ToString();
                    miViaje.RFCDestino = cboClienteDestino.SelectedValue.ToString();
                    miViaje.ClaveOperador = int.Parse(cboOperadores.SelectedItem.ToString());
                    miViaje.PlacasTractor = cboTractor.SelectedItem.ToString();
                    miViaje.PlacasCaja = cboCaja.SelectedItem.ToString();
                    //Se ejecuta la funcion de las acciones de un viaje
                    if (miViaje.InsertarViaje(conbd, sqlTransaction))
                    {
                        //Si la transaccion se realiza se hace commit
                        sqlTransaction.Commit();
                        MessageBox.Show("Operacion realizada correctamente", "La base de datos a sido modificada",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    ActualizarGridViajes();
                    ActualizarGridOperadores();
                    ActualizarGridTractores();
                    ActualizarGridCajas();
                    LimpiarDatosViajes();

                }
            }
            catch (Exception Ex)
            {
                //Si tenemos un error se ejecuta el rollback
                sqlTransaction.Rollback();
                MessageBox.Show(Ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Viaje miViaje = new Viaje();
            try
            {
                miViaje.ClaveViaje = int.Parse(dgvViajes.CurrentRow.Cells[0].Value.ToString());
                miViaje.CPOrigen = cboOrigen.SelectedValue.ToString();
                miViaje.CPDestino = cboDestino.SelectedValue.ToString();
                miViaje.RFCEmisor = cboClienteOrigen.SelectedValue.ToString();
                miViaje.RFCDestino = cboClienteDestino.SelectedValue.ToString();
                miViaje.ClaveOperador = int.Parse(cboOperadores.SelectedItem.ToString());
                miViaje.PlacasTractor = cboTractor.SelectedItem.ToString();
                miViaje.PlacasCaja = cboCaja.SelectedItem.ToString();

                if (miViaje.ActualizarViaje())
                {
                    MessageBox.Show("Operacion realizada correctamente", "La base de datos a sido modificada",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                ActualizarGridViajes();
                ActualizarGridOperadores();
                ActualizarGridTractores();
                ActualizarGridCajas();
                LimpiarDatosViajes();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btnEliminarViaje_Click(object sender, EventArgs e)
        {
            ConexionBD conbd = new ConexionBD("Capturista");
            SqlTransaction sqlTransaction = conbd.BeginTransaction(IsolationLevel.ReadCommitted);
            try
            {
                Viaje eliminarViaje = new Viaje();
                eliminarViaje.ClaveViaje = int.Parse(dgvViajes.CurrentRow.Cells[0].Value.ToString());

                var res = MessageBox.Show("¿Esta seguro que quiere eliminar la informacion del viaje seleccionado?" +
                    "\nEsta operacion es permanente.", 
                    "Confirmacion de eliminacion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (res == DialogResult.Yes)
                {
                    if (eliminarViaje.EliminarViaje(conbd, sqlTransaction))
                    {
                        sqlTransaction.Commit();
                        ActualizarGridViajes();
                        ActualizarGridCajas();
                        ActualizarGridOperadores();
                        ActualizarGridTractores();
                    }

                }
                else
                {
                    return;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                sqlTransaction.Rollback();
            }

        }
        void LimpiarDatosViajes()
        {
            foreach (Control control in grpViaje.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
            }
            cboCaja.SelectedIndex = -1;
            cboClienteDestino.SelectedIndex = -1;
            cboClienteOrigen.SelectedIndex = -1;
            cboDestino.SelectedIndex = -1;
            cboOrigen.SelectedIndex = -1;
            cboOperadores.SelectedIndex = -1;
            cboTractor.SelectedIndex = -1;
        }

        private void dgvViajes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //cboOrigen.SelectedItem = dgvViajes.CurrentRow.Cells[1].Value.ToString();
            //cboDestino.SelectedItem = dgvViajes.CurrentRow.Cells[2].Value.ToString();
            //cboClienteOrigen.SelectedItem = dgvViajes.CurrentRow.Cells[3].Value.ToString();
            //cboClienteDestino.SelectedItem = dgvViajes.CurrentRow.Cells[4].Value.ToString();
            //cboOperadores.SelectedItem = dgvViajes.CurrentRow.Cells[5].Value.ToString();
            //cboTractor.SelectedItem = dgvViajes.CurrentRow.Cells[6].Value.ToString();
            //cboCaja.SelectedItem = dgvViajes.CurrentRow.Cells[7].Value.ToString();
        }

        private void dgvViajes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //cboOrigen.SelectedItem = dgvViajes.CurrentRow.Cells[1].Value.ToString();
            //cboDestino.SelectedItem = dgvViajes.CurrentRow.Cells[2].Value.ToString();
            //cboClienteOrigen.SelectedItem = dgvViajes.CurrentRow.Cells[3].Value.ToString();
            //cboClienteDestino.SelectedItem = dgvViajes.CurrentRow.Cells[4].Value.ToString();
            //cboOperadores.SelectedItem = dgvViajes.CurrentRow.Cells[5].Value.ToString();
            //cboTractor.SelectedItem = dgvViajes.CurrentRow.Cells[6].Value.ToString();
            //cboCaja.SelectedItem = dgvViajes.CurrentRow.Cells[7].Value.ToString();
        }
    }
}
