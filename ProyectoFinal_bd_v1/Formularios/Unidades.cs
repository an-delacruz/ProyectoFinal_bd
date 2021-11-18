using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ProyectoFinal_bd_v1.Formularios.ReportViewers;


namespace ProyectoFinal_bd_v1.Formularios
{
    public partial class Unidades : Form
    {
        public Unidades()
        {
            InitializeComponent();
        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            Administrador miAdmin = new Administrador();
            miAdmin.Show();
            this.Hide();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            btMaximisar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Normal;
            btMaximisar.Visible = true;
            btnRestaurar.Visible = false;
        }

        private void btMaximisar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btMaximisar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void AbrirFormEnPanel(object formhija)
        {
            if (this.Centro.Controls.Count > 0)
                this.Centro.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Centro.Controls.Add(fh);
            this.Centro.Tag = fh;
            fh.Show();

        }
        private void btnOperador_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new OperadorPanel());

        }

        private void btnCaja_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new CajaPanel());

        }

        private void btnTractor_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new TractorPanel());

        }

        private void picRegresar_Click(object sender, EventArgs e)
        {
            Administrador miAdmi = new Administrador();
            miAdmi.Show();
            this.Hide();
        }

        private void btnOperador_Click_1(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new OperadorPanel());

        }

        private void btnCaja_Click_1(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new CajaPanel());

        }

        private void btnTractor_Click_1(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new TractorPanel());

        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnReporteOperador_Click(object sender, EventArgs e)
        {
            Submenup.Visible = false;
            RepOperadorGanancias miOp = new RepOperadorGanancias();
            miOp.Show();
            this.Close();
        }

        private void btnReporteCaja_Click(object sender, EventArgs e)
        {
            Submenup.Visible = false;
            RepCajaGanancias miC = new RepCajaGanancias();
            miC.Show();
            this.Close();
        }

        private void btnReporteTractor_Click(object sender, EventArgs e)
        {
            Submenup.Visible = false;
            RepTractorGanancias miT = new RepTractorGanancias();
            miT.Show();
            this.Close();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            Submenup.Visible = true;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new InicioPanel());

        }

        private void Unidades_Load(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new InicioPanel());

        }
    }
}
