using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacioon
{
    public partial class frmLaboratorio : Form
    {
        public frmLaboratorio()
        {
            InitializeComponent();
        }
        //Instanciar la clas a traves de un objeto
        CapaNegocio.Laboratorio Laboratorio1 = new CapaNegocio.Laboratorio();

       private void btnLeer_Click(object sender, EventArgs e)
        {
            //Leer los datos del formulario
            string elementos = txtElementos.Text;
            int foro = int.Parse(txtForo.Text);
            string carrera = txtCarrera.Text;
            int cantidadAlumnos = int.Parse(txtCantidadAlumnos.Text);
            Laboratorio1.Apellidos = elementos;
            Laboratorio1.Foro = foro;
            Laboratorio1.Carrera = carrera;
            Laboratorio1.CantidadAlumnos = cantidadAlumnos;
            MessageBox.Show("Se han registrado correctamente los datos de la Asignatura");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            //Mostrar los datos almacenados en el objeto 1
            string elementos = Laboratorio1.Apellidos;
            int foro = Laboratorio1.Foro;
            string carrera = Laboratorio1.Carrera;
            int cantidadAlumnos = Laboratorio1.CantidadAlumnos;
            MessageBox.Show("Elementos: " + elementos + "Foro: " + foro + "Tipo: " + carrera + "CantidadAlumnos" + cantidadAlumnos);
        }

        private void btnInvestigar_Click(object sender, EventArgs e)
        {
            //Mostrar el metodo u operacion Investigar
            MessageBox.Show(Laboratorio1.Investigar());
        }

        private void btnExperimentar_Click(object sender, EventArgs e)
        {
            //Mostrar el metodo u operacion Experimentar
            MessageBox.Show(Laboratorio1.Experimentar());
        }

        private void btnAprender_Click(object sender, EventArgs e)
        {
            //Mostrar el metodo u operacion Aprender
            MessageBox.Show(Laboratorio1.Aprender());
        }

        private void btnAnalizar_Click(object sender, EventArgs e)
        {
            //Mostrar el metodo u operacion Analizar
            MessageBox.Show(Laboratorio1.Analizar());
        }
    }
}
