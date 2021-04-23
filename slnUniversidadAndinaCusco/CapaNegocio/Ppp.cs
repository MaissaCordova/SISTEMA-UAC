using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Ppp
    {
        private string apellidos;
        private string nombres;
        private string dni;
        private string profesion;
        private string empresa;

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

        public string Empresa
        {
            get { return empresa; }
            set { empresa = value; }
        }

        //Metodos u operaciones
        public string Aprender()
        {
            return "No se ha implementado el metodo aprender";
        }
        public string Trabajar()
        {
            return "No se ha implementado el metodo trabajar";
        }
        public string AdquirirExperiencia()
        {
            return "No se ha implementado el metodo adquirir experiencia";
        }
        public string Reforzar()
        {
            return "No se ha implementado el metodo reforzar";
        }
    }
}
