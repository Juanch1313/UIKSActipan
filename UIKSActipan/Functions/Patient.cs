using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIKSActipan.Functions
{
    public class Patient
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public char genero { get; set; }
        public string telefono { get; set; }
        public string domicilio { get; set; }
        public string nacimiento { get; set; }
        public string estadoCivil { get; set; }
        public string escolaridad { get; set; }
        public string ocupacion { get; set; }
        public bool estado { get; set; }

        public Patient(){ }
        public Patient(int id, string nombre, string apellidos, char genero, string telefono, string domicilio, string nacimiento
                       , string estadoCivil, string escolaridad, string ocupacion, bool estado)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.genero = genero;
            this.telefono = telefono;
            this.domicilio = domicilio;
            this.nacimiento = nacimiento;
            this.estadoCivil = estadoCivil;
            this.escolaridad = escolaridad;
            this.ocupacion = ocupacion;
            this.estado = estado;
        }
    }
}
