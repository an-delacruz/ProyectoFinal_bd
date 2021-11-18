﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ProyectoFinal_bd_v1.Formularios
{
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
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

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            btMaximisar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            Administrador miAdmi = new Administrador();
            miAdmi.Show();
            this.Hide();
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


        private void btnClienteEmisorPanel_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new ClienteEmisorPanel());

        }

        private void btnClienteDestinoPanel_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new ClienteDestinoPanel());

        }

        private void picRegresar_Click(object sender, EventArgs e)
        {
            Administrador miAdmi = new Administrador();
            miAdmi.Show();
            this.Hide();
        }

        private void izquierdo_Paint(object sender, PaintEventArgs e)
        {

        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);
        private void pnlSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClienteEmisorPanel_Click_1(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new ClienteEmisorPanel());

        }

        private void btnClienteDestinoPanel_Click_1(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new ClienteDestinoPanel());

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new InicioPanel());

        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new InicioPanel());

        }
    }
}
