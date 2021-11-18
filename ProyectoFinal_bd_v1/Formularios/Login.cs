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

namespace ProyectoFinal_bd_v1.Formularios
{
    public partial class Login : Form
    {
        //ConexionBD con = new ConexionBD("");
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = "Administrador";
            txtContraseña.Text = "1234";
        }
        private void btnLogear_Click(object sender, EventArgs e)
        {
            String usuario, contraseña;

            try
            {
                usuario = txtUsuario.Text.ToString();
                contraseña = txtContraseña.Text.ToString();
                if (usuario == "Administrador" && contraseña == "1234")
                {
                    MessageBox.Show("Has iniciado sesion como administrador \nBievenido!");
                    Administrador pantallaAdministrador = new Administrador();
                    pantallaAdministrador.Show();
                    this.Hide();
                    //con.AbrirConexion();


                }
                else
                if (usuario == "Capturista" && contraseña == "1234")
                {
                    MessageBox.Show("Has iniciado sesion como capturista \nBievenido!");
                    Viajes pantallaCap = new Viajes();
                    pantallaCap.Show();
                    this.Hide();
                    //con.AbrirConexion();

                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecta! ", "Login invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
