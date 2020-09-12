using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Veterinaria
    {
        private string _nombre;
        private string _calle;
        private int _alturaCalle;

        public Veterinaria(string _nombre, string _calle, int _alturaCalle)
        {

        }

        public string Nombre
        {
            set { _nombre = value; }
            get { return _nombre;  }
        }
        public string Calle
        {
            set { _calle = value;  }
            get { return _calle;  }
        }
        public int Altura
        {
            set { _alturaCalle = value; }
            get { return _alturaCalle;  }
        }

        
        
    }
}
