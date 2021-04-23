using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Asignatura
    {
        //atributos
        private string especialidad;
        private string docente;
        private int aula;
        
        //Propiedades
        public string Especialidad
        {
            get { return especialidad; } //Lectura de atributo
            set { especialidad = value; } //Escrbir atributo
        }
        public string Docente
        {
            get { return Docente; }
            set { docente = value; }
        }
        public int Aula
        {
            get { return aula; }
            set { aula = value; }
        }

        //Metodos u operaciones
        public string Aprender()
        {
            return "No se ha implementado el metodo Aprender";
        }
        public string Estudiar()
        {
            return "No se ha implementado el metodo Estudiar";
        }
        public string Conocer()
        {
            return "No se ha implementado el metodo Conocer";
        }
        public string Clasificar()
        {
            return "No se ha implementado el metodo Clasificar";
        }
    }
}
