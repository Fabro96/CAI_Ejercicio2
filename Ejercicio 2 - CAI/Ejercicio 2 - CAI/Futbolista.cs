using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2___CAI
{
    class Futbolista
    {
        private string _nombre;
        private string _apellido;
        private int _edad;
        private string _posicion;
        private string _equipo;

        public Futbolista(string _nombre, string _apellido, int _edad, string _posicion, string _equipo)
        {
            
        }        
        public string Nombre
        {
            set
            {
                _nombre = value;
            }
            get
            {
                return _nombre;
            }
        }
        public string Apellido
        {
            set
            {
                _apellido = value;
            }
            get
            {
                return _apellido;
            }
        }
        public int Edad
        {
            set
            {
                _edad = value;
            }
            get
            {
                return _edad;
            }
        }
        public string Posicion
        {
            set
            {
                _posicion = value;
            }
            get
            {
                return _posicion;
            }
        }
        public string Equipo
        {
            set
            {
                _equipo = value;
            }
            get
            {
                return _equipo;
            }
        }
    }
}
