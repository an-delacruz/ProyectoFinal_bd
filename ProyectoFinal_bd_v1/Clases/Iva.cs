using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_bd_v1
{
    class Iva
    {

        private int _intClaveIva;

        public int ClaveIva
        {
            get { return _intClaveIva; }
            set { _intClaveIva = value; }
        }

        private decimal _decimalPorcentajeIva;

        public decimal PorcentajeIva
        {
            get { return _decimalPorcentajeIva; }
            set { _decimalPorcentajeIva = value; }
        }

        private string _strConceptoIva;

        public string ConceptoIva
        {
            get { return _strConceptoIva; }
            set { _strConceptoIva = value; }
        }


    }
}
