using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_bd_v1
{
    class Tractor
    {
        private string _strPlacasTractor;

        public string PlacasTractor
        {
            get { return _strPlacasTractor; }
            set { _strPlacasTractor = value; }
        }

        private string _strEquipoFrontal;

        public string EquipoFrontal
        {
            get { return _strEquipoFrontal; }
            set { _strEquipoFrontal = value; }
        }

        private string _strModelo;

        public string Modelo
        {
            get { return _strModelo; }
            set { _strModelo = value; }
        }



        private Boolean _blnDisponible;

        public Boolean Disponible
        {
            get { return _blnDisponible; }
            set { _blnDisponible = value; }
        }

        public bool IngresarTractor()
        {
            ConexionBD conbd = new ConexionBD("Administrador");
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conbd.AbrirConexion();

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "TRACTORACCIONES";

            cmd.Parameters.AddWithValue("@PLACASTRACTOR", this.PlacasTractor);
            cmd.Parameters.AddWithValue("@EQUIPOFRONTAL", this.EquipoFrontal);
            cmd.Parameters.AddWithValue("@MODELO", this.Modelo);
            cmd.Parameters.AddWithValue("@DISPONIBLE", this.Disponible);
            cmd.Parameters.AddWithValue("@ACCION", "INSERT");


            int filasafectadas = cmd.ExecuteNonQuery();
            if (filasafectadas > 0)
                return true;
            else
                return false;
        }
        public bool EliminarTractor()
        {
            ConexionBD conbd = new ConexionBD("Administrador");
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conbd.AbrirConexion();

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "TRACTORACCIONES";

            cmd.Parameters.AddWithValue("@PLACASTRACTOR", this.PlacasTractor);
            cmd.Parameters.AddWithValue("@EQUIPOFRONTAL", this.EquipoFrontal);
            cmd.Parameters.AddWithValue("@MODELO", this.Modelo);
            cmd.Parameters.AddWithValue("@DISPONIBLE", this.Disponible);
            cmd.Parameters.AddWithValue("@ACCION", "DELETE");

            int filasafectadas = cmd.ExecuteNonQuery();
            if (filasafectadas > 0)
                return true;
            else
                return false;
        }
        public bool ActualizarTractor()
        {
            ConexionBD conbd = new ConexionBD("Administrador");
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conbd.AbrirConexion();

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "TRACTORACCIONES";

            cmd.Parameters.AddWithValue("@PLACASTRACTOR", this.PlacasTractor);
            cmd.Parameters.AddWithValue("@EQUIPOFRONTAL", this.EquipoFrontal);
            cmd.Parameters.AddWithValue("@MODELO", this.Modelo);
            cmd.Parameters.AddWithValue("@DISPONIBLE", this.Disponible);
            cmd.Parameters.AddWithValue("@ACCION", "UPDATE");

            int filasafectadas = cmd.ExecuteNonQuery();
            if (filasafectadas > 0)
                return true;
            else
                return false;
        }
    }
}
