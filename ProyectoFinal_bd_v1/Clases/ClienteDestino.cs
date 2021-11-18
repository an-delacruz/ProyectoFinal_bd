using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_bd_v1
{
    class ClienteDestino
    {
        private string _strRFC;

        public string RFC
        {
            get { return _strRFC; }
            set { _strRFC = value; }
        }

        private string _strRazonSocial;

        public string RazonSocial
        {
            get { return _strRazonSocial; }
            set { _strRazonSocial = value; }
        }


        private string _strDireccion;

        public string Direccion
        {
            get { return _strDireccion; }
            set { _strDireccion = value; }
        }

        private string _strTelefono;

        public string Telefono
        {
            get { return _strTelefono; }
            set { _strTelefono = value; }
        }



        private string _strNombrePersonaContactoDestino;

        public string NombrePersonaContactoDestino
        {
            get { return _strNombrePersonaContactoDestino; }
            set { _strNombrePersonaContactoDestino = value; }
        }

        private string _strPuestoContactoDestino;

        public string PuestoContactoDestino
        {
            get { return _strPuestoContactoDestino; }
            set { _strPuestoContactoDestino = value; }
        }

        private string _strCodigoPostalDestino;

        public string CodigoPostalDestino
        {
            get { return _strCodigoPostalDestino; }
            set { _strCodigoPostalDestino = value; }
        }

        public bool InsertarClienteDestino()
        {
            ConexionBD conbd = new ConexionBD("Administrador");
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conbd.AbrirConexion();

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "CLIENTEDESTINOACCIONES";

            cmd.Parameters.AddWithValue("@RFC", this.RFC);
            cmd.Parameters.AddWithValue("@RAZONSOCIAL", this.RazonSocial);
            cmd.Parameters.AddWithValue("@DIRECCION", this.Direccion);
            cmd.Parameters.AddWithValue("@TELEFONO", this.Telefono);
            cmd.Parameters.AddWithValue("@NOMBREPERSONACONTACTO", this.NombrePersonaContactoDestino);
            cmd.Parameters.AddWithValue("@PUESTOPERSONACONTACTO", this.PuestoContactoDestino);
            cmd.Parameters.AddWithValue("@CODIGOPOSTAL", this.CodigoPostalDestino);
            cmd.Parameters.AddWithValue("@ACCION", "INSERT");

            int filasafectadas = cmd.ExecuteNonQuery();
            if (filasafectadas > 0)
                return true;
            else
                return false;
        }
        public bool EliminarClienteDestino()
        {
            ConexionBD conbd = new ConexionBD("Administrador");
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conbd.AbrirConexion();

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "CLIENTEDESTINOACCIONES";

            cmd.Parameters.AddWithValue("@RFC", this.RFC);
            cmd.Parameters.AddWithValue("@RAZONSOCIAL", this.RazonSocial);
            cmd.Parameters.AddWithValue("@DIRECCION", this.Direccion);
            cmd.Parameters.AddWithValue("@TELEFONO", this.Telefono);
            cmd.Parameters.AddWithValue("@NOMBREPERSONACONTACTO", this.NombrePersonaContactoDestino);
            cmd.Parameters.AddWithValue("@PUESTOPERSONACONTACTO", this.PuestoContactoDestino);
            cmd.Parameters.AddWithValue("@CODIGOPOSTAL", this.CodigoPostalDestino);
            cmd.Parameters.AddWithValue("@ACCION", "DELETE");

            int filasafectadas = cmd.ExecuteNonQuery();
            if (filasafectadas > 0)
                return true;
            else
                return false;
        }
        public bool ActualizarClienteDestino()
        {
            ConexionBD conbd = new ConexionBD("Administrador");
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conbd.AbrirConexion();

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "CLIENTEDESTINOACCIONES";

            cmd.Parameters.AddWithValue("@RFC", this.RFC);
            cmd.Parameters.AddWithValue("@RAZONSOCIAL", this.RazonSocial);
            cmd.Parameters.AddWithValue("@DIRECCION", this.Direccion);
            cmd.Parameters.AddWithValue("@TELEFONO", this.Telefono);
            cmd.Parameters.AddWithValue("@NOMBREPERSONACONTACTO", this.NombrePersonaContactoDestino);
            cmd.Parameters.AddWithValue("@PUESTOPERSONACONTACTO", this.PuestoContactoDestino);
            cmd.Parameters.AddWithValue("@CODIGOPOSTAL", this.CodigoPostalDestino);
            cmd.Parameters.AddWithValue("@ACCION", "UPDATE");

            int filasafectadas = cmd.ExecuteNonQuery();
            if (filasafectadas > 0)
                return true;
            else
                return false;
        }
    }
}
