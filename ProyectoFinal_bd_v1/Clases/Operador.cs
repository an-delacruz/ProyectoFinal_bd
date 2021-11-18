using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_bd_v1
{
    class Operador
    {
        private int _intClaveOperador;

        public int ClaveOperador
        {
            get { return _intClaveOperador; }
            set { _intClaveOperador = value; }
        }

        private string _strRFC;

        public string RFC
        {
            get { return _strRFC; }
            set { _strRFC = value; }
        }

        private string _strNSS;

        public string NSS
        {
            get { return _strNSS; }
            set { _strNSS = value; }
        }

        private string _strNombre;

        public string Nombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }

        private string _strAppaterno;

        public string Appaterno
        {
            get { return _strAppaterno; }
            set { _strAppaterno = value; }
        }

        private string _strApmaterno;

        public string Apmaterno
        {
            get { return _strApmaterno; }
            set { _strApmaterno = value; }
        }

        private string _strTelefono;

        public string Telefono
        {
            get { return _strTelefono; }
            set { _strTelefono = value; }
        }

        private string _strDireccion;

        public string Direccion
        {
            get { return _strDireccion; }
            set { _strDireccion = value; }
        }

        private decimal  _decimalSalarioBase;

        public decimal SalarioBase
        {
            get { return _decimalSalarioBase; }
            set { _decimalSalarioBase = value; }
        }

        private Boolean _boolDisponible;

        public Boolean Disponible
        {
            get { return _boolDisponible; }
            set { _boolDisponible = value; }
        }


        public bool IngresarOperador()
        {
            ConexionBD conbd = new ConexionBD("Administrador");
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conbd.AbrirConexion();

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "OPERADORACCIONES";

            cmd.Parameters.AddWithValue("@CLAVEOPERADOR", this.ClaveOperador);
            cmd.Parameters.AddWithValue("@RFC", this.RFC);
            cmd.Parameters.AddWithValue("@NOMBRE", this.Nombre);
            cmd.Parameters.AddWithValue("@APPATERNO", this.Appaterno);
            cmd.Parameters.AddWithValue("@APMATERNO", this.Apmaterno);
            cmd.Parameters.AddWithValue("@TELEFONO", this.Telefono);
            cmd.Parameters.AddWithValue("@NSS", this.NSS);
            cmd.Parameters.AddWithValue("@DIRECCION", this.Direccion);
            cmd.Parameters.AddWithValue("@SALARIO", this.SalarioBase);
            cmd.Parameters.AddWithValue("@DISPONIBLE", this.Disponible);
            cmd.Parameters.AddWithValue("@ACCION", "INSERT");

            int filasafectadas = cmd.ExecuteNonQuery();
            if (filasafectadas > 0)
                return true;
            else
                return false;
        }
        public bool EliminarOperador()
        {
            ConexionBD conbd = new ConexionBD("Administrador");
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conbd.AbrirConexion();

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "OPERADORACCIONES";

            cmd.Parameters.AddWithValue("@CLAVEOPERADOR", this.ClaveOperador);
            cmd.Parameters.AddWithValue("@RFC", this.RFC);
            cmd.Parameters.AddWithValue("@NOMBRE", this.Nombre);
            cmd.Parameters.AddWithValue("@APPATERNO", this.Appaterno);
            cmd.Parameters.AddWithValue("@APMATERNO", this.Apmaterno);
            cmd.Parameters.AddWithValue("@TELEFONO", this.Telefono);
            cmd.Parameters.AddWithValue("@NSS", this.NSS);
            cmd.Parameters.AddWithValue("@DIRECCION", this.Direccion);
            cmd.Parameters.AddWithValue("@SALARIO", this.SalarioBase);
            cmd.Parameters.AddWithValue("@DISPONIBLE", this.Disponible);
            cmd.Parameters.AddWithValue("@ACCION", "DELETE");

            int filasafectadas = cmd.ExecuteNonQuery();
            if (filasafectadas > 0)
                return true;
            else
                return false;
        }
        public bool ActualizarOperador()
        {
            ConexionBD conbd = new ConexionBD("Administrador");
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conbd.AbrirConexion();

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "OPERADORACCIONES";

            cmd.Parameters.AddWithValue("@CLAVEOPERADOR", this.ClaveOperador);
            cmd.Parameters.AddWithValue("@RFC", this.RFC);
            cmd.Parameters.AddWithValue("@NOMBRE", this.Nombre);
            cmd.Parameters.AddWithValue("@APPATERNO", this.Appaterno);
            cmd.Parameters.AddWithValue("@APMATERNO", this.Apmaterno);
            cmd.Parameters.AddWithValue("@TELEFONO", this.Telefono);
            cmd.Parameters.AddWithValue("@NSS", this.NSS);
            cmd.Parameters.AddWithValue("@DIRECCION", this.Direccion);
            cmd.Parameters.AddWithValue("@SALARIO", this.SalarioBase);
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
