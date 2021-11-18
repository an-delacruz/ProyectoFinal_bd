using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_bd_v1
{
    class Estado
    {
        private int _intClaveEstado;

        public int ClaveEstado
        {
            get { return _intClaveEstado; }
            set { _intClaveEstado = value; }
        }

        private string _strNombreEstado;

        public string NombreEstado
        {
            get { return _strNombreEstado; }
            set { _strNombreEstado = value; }
        }


    }
}
