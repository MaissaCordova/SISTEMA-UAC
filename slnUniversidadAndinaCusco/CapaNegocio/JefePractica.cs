using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class JefePractica
    {
        private string apellidos;
        private string nombres;
        private string dni;
        private string profesion;

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }
        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        public string Profesion
        {
            get { return profesion; }
            set { profesion = value; }
        }

        //Metodos u operaciones
        public string BrindarAyuda()
        {
            return "No se ha implementado el metodo de brindar ayuda";
        }
        public string Supervisar()
        {
            return "No se ha implementado el metodo supervisar";
        }
        public string Controlar()
        {
            return "No se ha implementado el metodo de controlar";
        }
    }
}
