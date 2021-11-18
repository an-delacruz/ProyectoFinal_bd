using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoFinal_bd_v1
{
    class ConexionBD
    {

        //static private string CadenaConexion = "Data Source=189.179.246.12; Initial Catalog = PROYECTOFINAL; User ID=SOFTWARE; Password=123;Integrated Security=False";
        //static private string CadenaConexion = "Data Source = JOSE-CABRERA; Initial Catalog = SOFTWARE; Integrated Security = True";
        SqlConnection Conexion;
        public ConexionBD(string usuario)
        {
            if (usuario == "Administrador")
            {
                Conexion = new SqlConnection( "Data Source=189.179.246.12; Initial Catalog = PROYECTOFINAL; User ID=AdminTransportes; Password=TranspAdmin-2020;Integrated Security=False");
            }
            else
            {
                Conexion = new SqlConnection( "Data Source=189.179.246.12; Initial Catalog = PROYECTOFINAL; User ID=CapturistaTransportes; Password=TranspCapt-2020;Integrated Security=False");
            }
        }
        //private SqlConnection Conexion = new SqlConnection();
        
        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }
        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
        public SqlTransaction BeginTransaction(System.Data.IsolationLevel insolationLevel)
        {
            if (Conexion.State == ConnectionState.Closed)
            {
                Conexion.Open();
                
            }
            return Conexion.BeginTransaction(insolationLevel);
        }
        public void ActualizarGrid(DataGridView dg, String Consulta)
        {
            //abrimos conexion con nuestra base de datos
            this.AbrirConexion();

            //Nos sirve para llenar los datos en el data grid view, que estan en la base de datos.
            System.Data.DataSet ds = new System.Data.DataSet();

            //es un intermediario entre data set y la base de datos
            SqlDataAdapter da = new SqlDataAdapter(Consulta, Conexion);


            //Fill es para llenado del data gri, y como parametros se manda el dataset, y la tabla
            //que se ocupara de la base de datos

            da.Fill(ds, "Generico");


            dg.DataSource = ds;
            //DataMember nos traera todo el contenido del nombre de nuestra tabla.
            dg.DataMember = "Generico";

            //Nos desconectamos
            this.CerrarConexion();


        }
    }
}
