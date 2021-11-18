using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_bd_v1
{
    class ClienteEmisor/*:IEquatable<ClienteEmisor>*/
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


        private string _strNombrePersonaContactoEmisor;

        public string NombrePersonaContactoEmisor
        {
            get { return _strNombrePersonaContactoEmisor; }
            set { _strNombrePersonaContactoEmisor = value; }
        }

        private string _strPuestoContactoEmisor;

        public string PuestoContactoEmisor
        {
            get { return _strPuestoContactoEmisor; }
            set { _strPuestoContactoEmisor = value; }
        }

        private string _strCodigoPostalEmisor;

        public string CodigoPostalEmisor
        {
            get { return _strCodigoPostalEmisor; }
            set { _strCodigoPostalEmisor = value; }
        }
        public bool IngresarClienteEmisor()
        {
            ConexionBD conbd = new ConexionBD("Administrador");
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conbd.AbrirConexion();

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "CLIENTEEMISORACCIONES";

            cmd.Parameters.AddWithValue("@RFC", this.RFC);
            cmd.Parameters.AddWithValue("@RAZONSOCIAL", this.RazonSocial);
            cmd.Parameters.AddWithValue("@DIRECCION", this.Direccion);
            cmd.Parameters.AddWithValue("@TELEFONO", this.Telefono);
            cmd.Parameters.AddWithValue("@NOMBREPERSONACONTACTO", this.NombrePersonaContactoEmisor);
            cmd.Parameters.AddWithValue("@PUESTOPERSONACONTACTO", this.PuestoContactoEmisor);
            cmd.Parameters.AddWithValue("@CODIGOPOSTAL", this.CodigoPostalEmisor);
            cmd.Parameters.AddWithValue("@ACCION", "INSERT");

            int filasafectadas = cmd.ExecuteNonQuery();
            if (filasafectadas > 0)
                return true;
            else
                return false;
        }
        public bool EliminarClienteEmisor()
        {
            ConexionBD conbd = new ConexionBD("Administrador");
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conbd.AbrirConexion();

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "CLIENTEEMISORACCIONES";

            cmd.Parameters.AddWithValue("@RFC", this.RFC);
            cmd.Parameters.AddWithValue("@RAZONSOCIAL", this.RazonSocial);
            cmd.Parameters.AddWithValue("@DIRECCION", this.Direccion);
            cmd.Parameters.AddWithValue("@TELEFONO", this.Telefono);
            cmd.Parameters.AddWithValue("@NOMBREPERSONACONTACTO", this.NombrePersonaContactoEmisor);
            cmd.Parameters.AddWithValue("@PUESTOPERSONACONTACTO", this.PuestoContactoEmisor);
            cmd.Parameters.AddWithValue("@CODIGOPOSTAL", this.CodigoPostalEmisor);
            cmd.Parameters.AddWithValue("@ACCION", "DELETE");

            int filasafectadas = cmd.ExecuteNonQuery();
            if (filasafectadas > 0)
                return true;
            else
                return false;
        }
        public bool ActualizarClienteEmisor()
        {
            ConexionBD conbd = new ConexionBD("Administrador");
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conbd.AbrirConexion();

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "CLIENTEEMISORACCIONES";

            cmd.Parameters.AddWithValue("@RFC", this.RFC);
            cmd.Parameters.AddWithValue("@RAZONSOCIAL", this.RazonSocial);
            cmd.Parameters.AddWithValue("@DIRECCION", this.Direccion);
            cmd.Parameters.AddWithValue("@TELEFONO", this.Telefono);
            cmd.Parameters.AddWithValue("@NOMBREPERSONACONTACTO", this.NombrePersonaContactoEmisor);
            cmd.Parameters.AddWithValue("@PUESTOPERSONACONTACTO", this.PuestoContactoEmisor);
            cmd.Parameters.AddWithValue("@CODIGOPOSTAL", this.CodigoPostalEmisor);
            cmd.Parameters.AddWithValue("@ACCION", "UPDATE");

            int filasafectadas = cmd.ExecuteNonQuery();
            if (filasafectadas > 0)
                return true;
            else
                return false;
        }
    }
}
