using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_bd_v1
{
    class FacturaAux
    {

        private int _intFolioAux;

        public int FolioAux
        {
            get { return _intFolioAux; }
            set { _intFolioAux = value; }
        }

        private int _intCantidad;

        public int Cantidad
        {
            get { return _intCantidad; }
            set { _intCantidad = value; }
        }
        private int _intClaveMercancia;

        public int ClaveMercancia
        {
            get { return _intClaveMercancia; }
            set { _intClaveMercancia = value; }
        }

        public bool InsertarFacturaAux(ConexionBD conbd, SqlTransaction sqlTransaction)
        {
            //ConexionBD conbd = new ConexionBD();
            SqlCommand cmd = new SqlCommand();


            cmd.Connection = conbd.AbrirConexion();
            cmd.Transaction = sqlTransaction;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "FACTURAAUXACCIONES";

            cmd.Parameters.AddWithValue("@FOLIOAUX", this.FolioAux);
            cmd.Parameters.AddWithValue("@CLAVEMERCANCIA", this.ClaveMercancia);
            cmd.Parameters.AddWithValue("@CANTIDAD", this.Cantidad);
            cmd.Parameters.AddWithValue("@ACCION", "INSERT");

            int filasafectadas = cmd.ExecuteNonQuery();
            if (filasafectadas > 0)
                return true;
            else
                return false;
        }
        public bool ActualizarFacturaAux()
        {
            ConexionBD conbd = new ConexionBD("Capturista");
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conbd.AbrirConexion();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "FACTURAAUXACCIONES";

            cmd.Parameters.AddWithValue("@FOLIOAUX", this.FolioAux);
            cmd.Parameters.AddWithValue("@CLAVEMERCANCIA", this.ClaveMercancia);
            cmd.Parameters.AddWithValue("@CANTIDAD", this.Cantidad);
            cmd.Parameters.AddWithValue("@ACCION", "UPDATE");

            int filasafectadas = cmd.ExecuteNonQuery();
            if (filasafectadas > 0)
                return true;
            else
                return false;
        }
        public bool EliminarFacturaAux()
        {
            ConexionBD conbd = new ConexionBD("Capturista");
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conbd.AbrirConexion();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "FACTURAAUXACCIONES";

            cmd.Parameters.AddWithValue("@FOLIOAUX", this.FolioAux);
            cmd.Parameters.AddWithValue("@CLAVEMERCANCIA", this.ClaveMercancia);
            cmd.Parameters.AddWithValue("@CANTIDAD", this.Cantidad);
            cmd.Parameters.AddWithValue("@ACCION", "DELETE");

            int filasafectadas = cmd.ExecuteNonQuery();
            if (filasafectadas > 0)
                return true;
            else
                return false;
        }

    }
}
