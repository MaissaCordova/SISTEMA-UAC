using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Rector
    {
        //atributos
        private string apellidos;
        private string nombres;
        private int edad;
        private string especialidad;
        private string universidad;
        private string gradoInstruccion;
        //Propiedades
        public string Apellidos
        {
            get { return apellidos; } //Lectura atributo
            set { apellidos = value; } //Escritura del atributo
        }
        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public string Especialidad
        {
            get { return especialidad; }
            set { especialidad = value; }
        }
        public string Universidad
        {
            get { return universidad; }
            set { universidad = value; }
        }
        public string GradoInstruccion
        {
            get { return gradoInstruccion; }
            set { gradoInstruccion = value; }
        }

        //Metodos u operaciones
        public string Representar()
        {
            return "No se ha implementado el metodo representar";
        }
        public string Administrar()
        {
            return "No se ha implementado el método administrar";
        }
        public string Reglamentar()
        {
            return "No se ha implementado el metodo reglamentar";
        }
        public string Dirigir()
        {
            return "No se ha implementado el metodo dirigir";
        }
    }
}
