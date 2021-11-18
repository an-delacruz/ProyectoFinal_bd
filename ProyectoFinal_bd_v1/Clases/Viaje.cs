using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_bd_v1
{
    class Viaje
    {
        private int _intClaveViaje;

        public int ClaveViaje
        {
            get { return _intClaveViaje; }
            set {_intClaveViaje = value; }
        }

        private decimal _decimalDieselAsignado;

        public decimal DieselAsignado
        {
            get { return _decimalDieselAsignado; }
            set { _decimalDieselAsignado = value; }
        }

        private decimal _decimalDistancia;

        public decimal Distancia

        {
            get { return _decimalDistancia; }
            set { _decimalDistancia = value; }
        }
            
        
        private int _intClaveOrigen;

        public int ClaveOrigen
        {
            get { return _intClaveOrigen; }
            set { _intClaveOrigen = value; }
        }
        private int _intClaveDestino;

        public int ClaveDestino
        {
            get { return _intClaveDestino; }
            set { _intClaveDestino = value; }
        }

        private Boolean _blnViajeFinalizado;

        public Boolean ViajeFinalizado
        {
            get { return _blnViajeFinalizado; }
            set { _blnViajeFinalizado = value; }
        }

        private decimal _decimalDieselConsumido;

        public decimal DieselConsumido
        {
            get { return _decimalDieselConsumido; }
            set { _decimalDieselConsumido = value; }
        }

        private string _strcpOrigen;

        public string CPOrigen
        {
            get { return _strcpOrigen; }
            set { _strcpOrigen = value; }
        }
        private string _strcpDestino;

        public string CPDestino
        {
            get { return _strcpDestino; }
            set { _strcpDestino = value; }
        }
        private string _strRFCEmisor;

        public string RFCEmisor
        {
            get { return _strRFCEmisor; }
            set { _strRFCEmisor = value; }
        }
        private string _strRFCDestino;

        public string RFCDestino
        {
            get { return _strRFCDestino; }
            set { _strRFCDestino = value; }
        }
        private int _intClaveOperador;

        public int ClaveOperador
        {
            get { return _intClaveOperador; }
            set { _intClaveOperador = value; }
        }
        private string _strplacasTractor;

        public string PlacasTractor
        {
            get { return _strplacasTractor; }
            set { _strplacasTractor = value; }
        }
        private string _strplacasCaja;

        public string PlacasCaja
        {
            get { return _strplacasCaja; }
            set { _strplacasCaja = value; }
        }
        public bool InsertarViaje(ConexionBD conbd, SqlTransaction sqlTransaction)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conbd.AbrirConexion();
            cmd.Transaction = sqlTransaction;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "VIAJEACCIONES";

            cmd.Parameters.AddWithValue("@CLAVEVIAJE", this.ClaveViaje);
            //cmd.Parameters.AddWithValue("@VIAJEFINALIZADO", this.ViajeFinalizado);
            cmd.Parameters.AddWithValue("@CPEMISOR", this.CPOrigen);
            cmd.Parameters.AddWithValue("@CPDESTINO", this.CPDestino);
            cmd.Parameters.AddWithValue("@RFCEMISOR", this.RFCEmisor);
            cmd.Parameters.AddWithValue("@RFCDESTINO", this.RFCDestino);
            cmd.Parameters.AddWithValue("@PLACASTRACTOR", this.PlacasTractor);
            cmd.Parameters.AddWithValue("@PLACASCAJA", this.PlacasCaja);
            cmd.Parameters.AddWithValue("@CLAVEOPERADOR", this.ClaveOperador);
            cmd.Parameters.AddWithValue("@ACCION", "INSERT");

            int filasafectadas = cmd.ExecuteNonQuery();
            if (filasafectadas > 0)
                return true;
            else
                return false;
        }
        public bool ActualizarViaje()
        {
            ConexionBD conbd = new ConexionBD("Capturista");
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conbd.AbrirConexion();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "VIAJEACCIONES";

            cmd.Parameters.AddWithValue("@CLAVEVIAJE", this.ClaveViaje);
            cmd.Parameters.AddWithValue("@CPEMISOR", this.CPOrigen);
            cmd.Parameters.AddWithValue("@CPDESTINO", this.CPDestino);
            cmd.Parameters.AddWithValue("@RFCEMISOR", this.RFCEmisor);
            cmd.Parameters.AddWithValue("@RFCDESTINO", this.RFCDestino);
            cmd.Parameters.AddWithValue("@PLACASTRACTOR", this.PlacasTractor);
            cmd.Parameters.AddWithValue("@PLACASCAJA", this.PlacasCaja);
            cmd.Parameters.AddWithValue("@CLAVEOPERADOR", this.ClaveOperador);
            cmd.Parameters.AddWithValue("@ACCION", "UPDATE");

            int filasafectadas = cmd.ExecuteNonQuery();
            if (filasafectadas > 0)
                return true;
            else
                return false;
        }
        public bool EliminarViaje(ConexionBD conbd, SqlTransaction sqlTransaction)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conbd.AbrirConexion();
            cmd.Transaction = sqlTransaction;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "VIAJEACCIONES";

            cmd.Parameters.AddWithValue("@CLAVEVIAJE", this.ClaveViaje);
            cmd.Parameters.AddWithValue("@CPEMISOR", " ");
            cmd.Parameters.AddWithValue("@CPDESTINO", " ");
            cmd.Parameters.AddWithValue("@RFCEMISOR", " ");
            cmd.Parameters.AddWithValue("@RFCDESTINO", " ");
            cmd.Parameters.AddWithValue("@PLACASTRACTOR", " ");
            cmd.Parameters.AddWithValue("@PLACASCAJA",  " ");
            cmd.Parameters.AddWithValue("@CLAVEOPERADOR", " ");
            cmd.Parameters.AddWithValue("@ACCION", "DELETE");

            int filasafectadas = cmd.ExecuteNonQuery();
            if (filasafectadas > 0)
                return true;
            else
                return false;
        }
        public bool FinalizarViaje()
        {
            ConexionBD conbd = new ConexionBD("Capturista");
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conbd.AbrirConexion();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "FINALIZARVIAJE";

            cmd.Parameters.AddWithValue("@CLAVEVIAJE", this.ClaveViaje);

            int filasafectadas = cmd.ExecuteNonQuery();
            if (filasafectadas > 0)
                return true;
            else
                return false;
        }
    }
}
