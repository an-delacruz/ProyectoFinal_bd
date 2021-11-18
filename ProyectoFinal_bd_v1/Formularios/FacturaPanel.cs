using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ProyectoFinal_bd_v1.bin.Debug.Reportes;
using CrystalDecisions.Shared;
using System.Diagnostics;

namespace ProyectoFinal_bd_v1.Formularios
{
    public partial class FacturaPanel : Form
    {
        #region Variables y conexion
        ConexionBD con = new ConexionBD("Capturista");
        SqlTransaction sqlTransaction = null;
        #endregion
        public FacturaPanel()
        {
            InitializeComponent();
        }

        void ActualizarGridMercancia()
        {
            con.ActualizarGrid(dgvMercanciaFactura, "SELECT CLAVEMERCANCIA, DESCRIPMERCANCIA, PRECIOUNITARIO FROM MERCANCIA");
            con.ActualizarGrid(dgvRegistroMercancia, "SELECT CLAVEMERCANCIA, DESCRIPMERCANCIA, PRECIOUNITARIO FROM MERCANCIA");
        }
        private void FacturaPanel_Load(object sender, EventArgs e)
        {
            grpMercancia.Enabled = true;
            grbMercanciaFactura.Enabled = false;
            btnGenerarFactura.Enabled = false;
            LlenarIva();
            txtClaveViaje.Focus();


            #region DataGridViews
            ActualizarGridMercancia();
            dgvMercanciaFactura.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRegistroMercancia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            #endregion
        }

        #region MetodosExtra
        public int UltimoFolio()
        {
            int Folio;
            ConexionBD conbd = new ConexionBD("Capturista");
            SqlCommand cmd = new SqlCommand("SELECT IDENT_CURRENT('FACTURA')");
            cmd.Connection = conbd.AbrirConexion();
            Folio = int.Parse(cmd.ExecuteScalar().ToString());
            conbd.CerrarConexion();
            return Folio;
        }
        void LlenarIva()
        {
            try
            {
                ConexionBD conbd = new ConexionBD("Capturista");
                string query = "SELECT CLAVEIVA, CONCEPTOIVA FROM IVA";
                SqlDataAdapter da = new SqlDataAdapter(query, conbd.AbrirConexion());

                DataSet ds = new DataSet();
                da.Fill(ds, "IVA");
                cboConceptoIva.DisplayMember = "CONCEPTOIVA";
                cboConceptoIva.ValueMember = "CLAVEIVA";
                cboConceptoIva.DataSource = ds.Tables["IVA"];
                conbd.CerrarConexion();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }
        void LimpiarRegistroMercancia()
        {
            foreach (Control control in grpMercancia.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
            }
        }
        #endregion


        #region Restricciones
        private void txtClaveViaje_KeyPress(object sender, KeyPressEventArgs e)
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

        private const char SignoDecimal = '.'; // Carácter separador decimal
        private void txtFlete_KeyPress(object sender, KeyPressEventArgs e)
        {
            var textBox = (TextBox)sender;
            // Si el carácter pulsado no es un carácter válido se anula
            e.Handled = !char.IsDigit(e.KeyChar) // No es dígito
                        && !char.IsControl(e.KeyChar) // No es carácter de control (backspace)
                        && (e.KeyChar != SignoDecimal // No es signo decimal o es la 1ª posición o ya hay un signo decimal
                            || textBox.SelectionStart == 0
                            || textBox.Text.Contains(SignoDecimal));
        }

        private void txtClaveMercancia_KeyPress(object sender, KeyPressEventArgs e)
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



        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtDescripcionMercancia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtVolumen_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPrecioUnitario_KeyPress(object sender, KeyPressEventArgs e)
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
        #endregion
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ConexionBD conbd = new ConexionBD("Capturista");
            SqlTransaction sqlTransaction = conbd.BeginTransaction(IsolationLevel.ReadCommitted);
            try
            {
                Mercancia miMercancia = new Mercancia();
                miMercancia.ClaveMercancia = 0;

                miMercancia.DescripMercancia = txtDescripcionMercancia.Text;
                miMercancia.Peso = decimal.Parse(txtPeso.Text);
                miMercancia.Volumen = decimal.Parse(txtVolumen.Text);
                miMercancia.UnidadMedida = cmbUnidadMedida.Text;
                miMercancia.PrecioUnitario = decimal.Parse(txtPrecioUnitario.Text);
                miMercancia.UnidadMedida = cmbUnidadMedida.SelectedItem.ToString();
                if (cmbUnidadMedida.SelectedIndex == -1)
                {
                    throw new Exception("Seleccione un valor.");
                }

                if (miMercancia.InsertarMercancia(conbd, sqlTransaction))
                {
                    sqlTransaction.Commit();
                    MessageBox.Show("Operacion realizada correctamente", "La base de datos a sido modificada",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                ActualizarGridMercancia();
                LimpiarRegistroMercancia();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                sqlTransaction.Rollback();
                return; 
            }
        }

        private void btnAgregarFactura_Click(object sender, EventArgs e)
        {
            ConexionBD conbd = new ConexionBD("Capturista");
            SqlTransaction sqlTransaction = conbd.BeginTransaction(IsolationLevel.ReadCommitted);
            try
            {
                if (txtClaveViaje.Text == "" || txtFlete.Text == "" || cboConceptoIva.SelectedIndex == -1)
                {
                    throw new Exception("Llene todos los campos.");
                }
                else
                {
                    Factura miFactura = new Factura();
                    miFactura.ClaveViaje = int.Parse(txtClaveViaje.Text);
                    miFactura.Fecha = DateTime.Now.Date;
                    miFactura.HoraSalida = DateTime.Now.ToLocalTime();
                    miFactura.Subtotal = 0;
                    miFactura.Total = 0;
                    miFactura.ClaveIva = int.Parse(cboConceptoIva.SelectedValue.ToString());
                    miFactura.Flete = decimal.Parse(txtFlete.Text);

                    
                    if (miFactura.InsertarFactura(conbd, sqlTransaction))
                    {
                        sqlTransaction.Commit();
                        btnAgregarFactura.Enabled = false;
                        txtClaveViaje.Enabled = false;
                        cboConceptoIva.Enabled = false;
                        txtFlete.Enabled = false;
                        grpMercancia.Enabled = true;
                        grbMercanciaFactura.Enabled = true;
                        MessageBox.Show("Operacion realizada correctamente", "La base de datos a sido modificada",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                sqlTransaction.Rollback();
            }

        }

        private void btnAgregarMercAFactura_Click(object sender, EventArgs e)
        {
            ConexionBD conbd = new ConexionBD("Capturista");
            sqlTransaction = conbd.BeginTransaction(IsolationLevel.ReadCommitted);
            try
            {
                FacturaAux miFacturaAux = new FacturaAux();
                miFacturaAux.ClaveMercancia = int.Parse(txtClaveMercancia.Text);
                miFacturaAux.FolioAux = UltimoFolio();
                miFacturaAux.Cantidad = int.Parse(txtCantidad.Text);
                if (miFacturaAux.InsertarFacturaAux(conbd, sqlTransaction))
                {
                    txtCantidad.Clear();
                    txtClaveMercancia.Clear();
                    txtClaveMercancia.Focus();
                    btnGenerarFactura.Enabled = true;
                    sqlTransaction.Commit();
                    MessageBox.Show("Operacion realizada correctamente", "La base de datos a sido modificada",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                sqlTransaction.Rollback();
            }
        }

        private void btnGenerarFactura_Click(object sender, EventArgs e)
        {
            try
            {
                Factura miF = new Factura();
                miF.Folio = UltimoFolio();
                miF.ActualizarSubTotal(UltimoFolio());
                miF.ActualizarTotal(UltimoFolio());
                miF.ActualizarFactura();
                AbrirFactura(sender, e);
                MessageBox.Show("Operacion realizada correctamente", "Se ha generado la factura",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarFacturado();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        void AbrirFactura(object sender, EventArgs e)
        {

            try
            {
                string folio = UltimoFolio().ToString();

                RepFactura fac = new RepFactura();
                string exp = Application.StartupPath + "\\Facturas\\";
                ConnectionInfo crCon = new ConnectionInfo();
                crCon.ServerName = "189.179.246.12";
                crCon.DatabaseName = "PROYECTOFINAL";
                crCon.UserID = "CapturistaTransportes";
                crCon.Password = "TranspCapt-2020";
                fac.SetDatabaseLogon(crCon.UserID, crCon.Password);
                fac.ExportToDisk(ExportFormatType.PortableDocFormat, exp + "Factura-" + folio + ".pdf");
                Process.Start(exp + "Factura-" + UltimoFolio().ToString() + ".pdf");
                MessageBox.Show("Factura guardada");
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                throw;
            }

        }

        void LimpiarFacturado()
        {
            txtClaveViaje.Enabled = true;
            txtClaveViaje.Clear();
            cboConceptoIva.Enabled = true;
            txtFlete.Enabled = true;
            txtFlete.Clear();
            grpMercancia.Enabled = true;
            grbMercanciaFactura.Enabled = false;
            btnGenerarFactura.Enabled = false;
            LlenarIva();
            txtClaveViaje.Focus();
            btnAgregarFactura.Enabled = true;
        }
    }
}
