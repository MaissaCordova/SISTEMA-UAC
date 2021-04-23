using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Docente
    {
        //atribute
        private string apellidos;
        private string nombres;
        private int edad;
        private string dni;
        private string estudios;
        private DateTime fechaNacimiento;
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
        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        public string Estudios
        {
            get { return estudios; }
            set { estudios = value; }
        }
        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }
        // Metodos u operaciones
        public string Matricular()
        {
            return "No se ha implementado el método matricular";
        }
        public string Enseñar()
        {
            return "No se ha implementado el metodo enseñar";
        }
        public string AprobarAlumno()
        {
            return "No se ha implementado el metodo aprobar alumno";
        }
        public string DesaprobarAlumno()
        {
            return "No se ha implementado el metodo desaprobar alumno";
        }
    }
}
