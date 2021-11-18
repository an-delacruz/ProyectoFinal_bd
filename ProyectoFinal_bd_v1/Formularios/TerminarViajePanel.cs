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
    public partial class TerminarViajePanel : Form
    {
        ConexionBD con = new ConexionBD("Capturista");
        public TerminarViajePanel()
        {
            InitializeComponent();
        }
        void ActualizarGridViajes()
        {
            con.ActualizarGrid(this.dgvViajesEnProceso, "SELECT CLAVEVIAJE AS 'Clave', CPEMISOR AS 'Origen', CPDESTINO AS 'Destino', RFCEMISOR AS 'Cliente Emisor', " +
                "RFCDESTINO AS 'Cliente Destino', CLAVEOPERADOR AS 'Operador', PLACASTRACTOR AS 'Tractor', PLACASCAJA AS 'Caja', " +
                "VIAJEFINALIZADO AS 'Finalizado' FROM VIAJE WHERE VIAJEFINALIZADO = 0");
        }
        private void btnTerminarViaje_Click(object sender, EventArgs e)
        {
            try
            {
                Viaje miViajeFinalizado = new Viaje();
                miViajeFinalizado.ClaveViaje = int.Parse(txtIdViaje.Text);
                DialogResult res = MessageBox.Show("Confirme que el viaje " + miViajeFinalizado.ClaveViaje + " ha finalizado", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    if (miViajeFinalizado.FinalizarViaje())
                    {
                        MessageBox.Show("Operacion realizada correctamente", "La base de datos a sido modificada",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ActualizarGridViajes();

                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void TerminarViajePanel_Load(object sender, EventArgs e)
        {
            ActualizarGridViajes();
        }

    }
}
