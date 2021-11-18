using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_bd_v1.Formularios.ReportViewers
{
    public partial class RepOperadorGanancias : Form
    {
        public RepOperadorGanancias()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Unidades miU = new Unidades();
            miU.Show();
            this.Close();
        }


        void CargarReporte()
        {
            ReportDocument fac = new ReportDocument();
            fac.Load(Application.StartupPath + "\\Reportes\\RepOperadoresGanancias.rpt");

            crvOperadorGanancias.ReportSource = fac;
            crvOperadorGanancias.Refresh();
        }

        private void RepOperadorGanancias_Load(object sender, EventArgs e)
        {
            CargarReporte();
        }
    }
}
