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
    public partial class RepViajes : Form
    {
        public RepViajes()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Administrador admin = new Administrador();
            admin.Show();
            this.Close();
        }
        void CargarReporte()
        {
            ReportDocument fac = new ReportDocument();
            fac.Load(Application.StartupPath + "\\Reportes\\RepViajes.rpt");

            crvReporteViajes.ReportSource = fac;
            crvReporteViajes.Refresh();
        }

        private void RepViajes_Load(object sender, EventArgs e)
        {
            CargarReporte();
        }
    }
}
