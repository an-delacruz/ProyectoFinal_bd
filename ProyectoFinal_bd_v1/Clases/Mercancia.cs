using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace ProyectoFinal_bd_v1
{
    class Mercancia
    {
        private int _intClaveMercancia;

        public int ClaveMercancia
        {
            get { return _intClaveMercancia; }
            set { _intClaveMercancia = value; }
        }

        private string _strDescripMercancia;

        public string DescripMercancia
        {
            get { return _strDescripMercancia; }
            set { _strDescripMercancia = value; }
        }

        private decimal _decimalPeso;

        public decimal Peso
        {
            get { return _decimalPeso; }
            set { _decimalPeso = value; }
        }

        private decimal _decimalVolumen;

        public decimal Volumen
        {
            get { return _decimalVolumen; }
            set { _decimalVolumen = value; }
        }

        private string _strUnidadMedida;

        public string UnidadMedida
        {
            get { return _strUnidadMedida; }
            set { _strUnidadMedida = value; }
        }


        private decimal _decprecioUnitario;

        public decimal PrecioUnitario
        {
            get { return _decprecioUnitario; }
            set { _decprecioUnitario = value; }
        }



        public bool InsertarMercancia(ConexionBD conbd, SqlTransaction sqlTransaction)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conbd.AbrirConexion();
            cmd.Transaction = sqlTransaction;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "MERCANCIAACCIONES";

            cmd.Parameters.AddWithValue("@CLAVEMERCANCIA", this.ClaveMercancia);
            cmd.Parameters.AddWithValue("@DESCRIPMERCANCIA", this.DescripMercancia);
            cmd.Parameters.AddWithValue("@PESO", this.Peso);
            cmd.Parameters.AddWithValue("@VOLUMEN", this.Volumen);
            cmd.Parameters.AddWithValue("@UNIDADMEDIDA", this.UnidadMedida);
            cmd.Parameters.AddWithValue("@PRECIOUNITARIO", this.PrecioUnitario);

            int filasafectadas = cmd.ExecuteNonQuery();
            if (filasafectadas > 0)
                return true;
            else
                return false;




        }
    }
}
