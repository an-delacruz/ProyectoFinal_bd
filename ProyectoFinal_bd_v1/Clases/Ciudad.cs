using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_bd_v1
{
    class Ciudad
    {
        private string _strCodigoPostal;

        public string CodigoPostal
        {
            get { return _strCodigoPostal; }
            set { _strCodigoPostal = value; }
        }

        private string _strNombreCiudad;

        public string NombreCiudad
        {
            get { return _strNombreCiudad; }
            set { _strNombreCiudad = value; }
        }

        private int _intClaveEstado;

        public int ClaveEstado
        {
            get { return _intClaveEstado; }
            set { _intClaveEstado = value; }
        }

    }
}
