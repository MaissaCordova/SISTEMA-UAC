using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Notas
    {
        //atribute
        private string curso;
        private int valor;
        //Propiedades
        public string Curso
        {
            get { return curso; } //Lectura atributo
            set { curso = value; } //Escritura del atributo
        }
        public int Valor
        {
            get { return valor; }
            set { valor = value; }
        }
        //Metodos u operaciones
        public string Aprobar()
        {
            return "No se ha implementado el metodo aprobar";
        }
        public string Desaprobar()
        {
            return "No se ha implementado el metodo desaprobar ";
        }
        public string Incrementar()
        {
            return "No se ha implementado el metodo incrementar";
        }
        public string Disminuir()
        {
            return "No se ha implementado el método disminuir";
        }
    }
}
