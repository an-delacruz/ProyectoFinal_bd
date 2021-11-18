using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_bd_v1
{
    class Caja
    {
        private string _strPlacasCaja;

        public string PlacasCaja
        {
            get { return _strPlacasCaja; }
            set { _strPlacasCaja = value; }
        }

        private int _intNumeroCaja;

        public int NumeroCaja
            {
            get { return _intNumeroCaja; }
            set { _intNumeroCaja = value; }
        }

        private Boolean _blnDisponible;

        public Boolean Disponible
        {
            get { return _blnDisponible; }
            set { _blnDisponible = value; }
        }

        public bool IngresarCaja()
        {
            ConexionBD conbd = new ConexionBD("Administrador");
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conbd.AbrirConexion();

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "CAJAACCIONES";

            cmd.Parameters.AddWithValue("@PLACASCAJA", this.PlacasCaja);
            cmd.Parameters.AddWithValue("@NUMEROCAJA", this.NumeroCaja);
            cmd.Parameters.AddWithValue("@DISPONIBLE", this.Disponible);
            cmd.Parameters.AddWithValue("@ACCION", "INSERT");


            int filasafectadas = cmd.ExecuteNonQuery();
            if (filasafectadas > 0)
                return true;
            else
                return false;
        }
        public bool EliminarCaja()
        {
            ConexionBD conbd = new ConexionBD("Administrador");
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conbd.AbrirConexion();

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "CAJAACCIONES";

            cmd.Parameters.AddWithValue("@PLACASCAJA", this.PlacasCaja);
            cmd.Parameters.AddWithValue("@NUMEROCAJA", this.NumeroCaja);
            cmd.Parameters.AddWithValue("@DISPONIBLE", this.Disponible);
            cmd.Parameters.AddWithValue("@ACCION", "DELETE");

            int filasafectadas = cmd.ExecuteNonQuery();
            if (filasafectadas > 0)
                return true;
            else
                return false;
        }
        public bool ActualizarCaja()
        {
            ConexionBD conbd = new ConexionBD("Administrador");
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conbd.AbrirConexion();

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "CAJAACCIONES";

            cmd.Parameters.AddWithValue("@PLACASCAJA", this.PlacasCaja);
            cmd.Parameters.AddWithValue("@NUMEROCAJA", this.NumeroCaja);
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
