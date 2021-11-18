using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_bd_v1
{
    class Factura
    {
        private int _intFolio;

        public int Folio
        {
            get { return _intFolio; }
            set { _intFolio = value; }
        }

        private DateTime _dtmFecha;

        public DateTime Fecha
        {
            get { return _dtmFecha; }
            set { _dtmFecha = value; }
        }

        private DateTime _timespanHoraSalida;

        public DateTime HoraSalida
        {
            get { return _timespanHoraSalida; }
            set { _timespanHoraSalida = value; }
        }

        private decimal _decimalFlete;

        public decimal Flete
        {
            get { return _decimalFlete; }
            set { _decimalFlete = value; }
        }

        private int _intClaveIva;

        public int ClaveIva
        {
            get { return _intClaveIva; }
            set { _intClaveIva = value; }
        }

        private decimal _decimalSubtotal;

        public decimal Subtotal
        {
            get { return _decimalSubtotal; }
            set { _decimalSubtotal = value; }
        }

        private decimal _decimalTotal;

        public decimal Total
        {
            get { return _decimalTotal; }
            set { _decimalTotal = value; }
        }


        private int _intClaveViaje;

        public int ClaveViaje
        {
            get { return _intClaveViaje; }
            set { _intClaveViaje = value; }
        }

        public bool InsertarFactura(ConexionBD conbd, SqlTransaction sqlTransaction)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conbd.AbrirConexion();
            cmd.Transaction = sqlTransaction;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "FACTURAACCIONES";

            cmd.Parameters.AddWithValue("@FOLIO", this.Folio);
            cmd.Parameters.AddWithValue("@FECHA", this.Fecha);
            cmd.Parameters.AddWithValue("@HORASALIDA", this.HoraSalida);
            cmd.Parameters.AddWithValue("@SUBTOTAL", this.Subtotal);
            cmd.Parameters.AddWithValue("@CLAVEIVA", this.ClaveIva);
            cmd.Parameters.AddWithValue("@TOTAL", this.Total);
            cmd.Parameters.AddWithValue("@CLAVEVIAJE", this.ClaveViaje);
            cmd.Parameters.AddWithValue("@FLETE", this.Flete);
            cmd.Parameters.AddWithValue("@ACCION", "INSERT");

            int filasafectadas = cmd.ExecuteNonQuery();
            if (filasafectadas > 0)
                return true;
            else
                return false;
        }
        public bool ActualizarFactura()
        {
            ConexionBD conbd = new ConexionBD("Capturista");
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conbd.AbrirConexion();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "FACTURAACCIONES";

            cmd.Parameters.AddWithValue("@FOLIO", this.Folio);
            cmd.Parameters.AddWithValue("@FECHA", DateTime.Now.Date);
            cmd.Parameters.AddWithValue("@HORASALIDA", DateTime.Now.ToLocalTime());
            cmd.Parameters.AddWithValue("@SUBTOTAL", this.Subtotal);
            cmd.Parameters.AddWithValue("@CLAVEIVA", this.ClaveIva);
            cmd.Parameters.AddWithValue("@TOTAL", this.Total);
            cmd.Parameters.AddWithValue("@CLAVEVIAJE", this.ClaveViaje);
            cmd.Parameters.AddWithValue("@FLETE", this.Flete);
            cmd.Parameters.AddWithValue("@ACCION", "UPDATE");

            int filasafectadas = cmd.ExecuteNonQuery();
            if (filasafectadas > 0)
                return true;
            else
                return false;
        }
        public bool EliminarFactura()
        {
            ConexionBD conbd = new ConexionBD("Capturista");
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conbd.AbrirConexion();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "FACTURAACCIONES";

            cmd.Parameters.AddWithValue("@FOLIO", this.Folio);
            cmd.Parameters.AddWithValue("@FECHA", this.Fecha);
            cmd.Parameters.AddWithValue("@HORASALIDA", this.HoraSalida);
            cmd.Parameters.AddWithValue("@SUBTOTAL", this.Subtotal);
            cmd.Parameters.AddWithValue("@CLAVEIVA", this.ClaveIva);
            cmd.Parameters.AddWithValue("@TOTAL", this.Total);
            cmd.Parameters.AddWithValue("@CLAVEVIAJE", this.ClaveViaje);
            cmd.Parameters.AddWithValue("@FLETE", this.Flete);
            cmd.Parameters.AddWithValue("@ACCION", "DELETE");

            int filasafectadas = cmd.ExecuteNonQuery();
            if (filasafectadas > 0)
                return true;
            else
                return false;
        }

        public void ActualizarSubTotal(int Folio)
        {
            decimal SubTotalx = 0;
            ConexionBD conbd = new ConexionBD("Capturista");
            SqlCommand cmd = new SqlCommand("SELECT dbo.CALCULARSUBTOTAL(@Folio)");
            cmd.Connection = conbd.AbrirConexion();
            cmd.Parameters.AddWithValue("@Folio", Folio);
            SubTotalx = decimal.Parse(cmd.ExecuteScalar().ToString());
            conbd.CerrarConexion();
            this.Subtotal = SubTotalx;        
        }
        public void ActualizarTotal(int Folio)
        {
            decimal Totalx = 0;
            ConexionBD conbd = new ConexionBD("Capturista");
            SqlCommand cmd = new SqlCommand("SELECT dbo.CALCULARTOTAL(@Folio)");
            cmd.Connection = conbd.AbrirConexion();
            cmd.Parameters.AddWithValue("@Folio", Folio);
            Totalx = decimal.Parse(cmd.ExecuteScalar().ToString());
            conbd.CerrarConexion();
            this.Total = Totalx;
        }
    }
}
