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
    public partial class frmRector : Form
    {
        public frmRector()
        {
            InitializeComponent();
        }
        // Instanciar la clase a traves de un objeto
        // En esta parte del codigo se declaran variables globales
        CapaNegocio.Rector rector1 = new CapaNegocio.Rector();
        
        private void button1_Click(object sender, EventArgs e)
        {
            //Leer datos del formulario
            string apellidos = txtApellidos.Text;
            string nombres = txtNombres.Text;
            int edad = int.Parse(txtEdad.Text);
            string especialidad = txtEspecialidad.Text;
            string universidad = txtUniversidad.Text;
            string gradoInstruccion = txtGradoInstruccion.Text;
            rector1.Apellidos = apellidos;
            rector1.Nombres = nombres;
            rector1.Edad = edad;
            rector1.Especialidad = especialidad;
            rector1.Universidad = universidad;
            rector1.GradoInstruccion = gradoInstruccion;
            MessageBox.Show("Se han registrado correctamente los datos de rector 1");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            // Mostrar los datos almacenados en el objeto 1
            string apellidos = rector1.Apellidos;
            string nombres = rector1.Nombres;
            int edad = rector1.Edad;
            string especialidad = rector1.Especialidad;
            string universidad = rector1.Universidad;
            string gradoInstruccion = rector1.GradoInstruccion;
            MessageBox.Show("Apellidos: " + apellidos + " Nombres: " + nombres + " Edad" + edad + " Especialidad: " + especialidad + "Universidad: " + universidad + "Grado de Instruccion: " + gradoInstruccion);
        }

        private void btnRepresentar_Click(object sender, EventArgs e)
        {
            //Mostrar el metodo u operación Representar
            MessageBox.Show(rector1.Representar());
        }

        private void btnAdministrar_Click(object sender, EventArgs e)
        {
            //Mostrar el metodo u operación Administrar
            MessageBox.Show(rector1.Administrar());
        }

        private void btnReglamentar_Click(object sender, EventArgs e)
        {
            //Mostrar el metodo u operación Reglamentar
            MessageBox.Show(rector1.Reglamentar());
        }

        private void btnDirigir_Click(object sender, EventArgs e)
        {
            //Mostrar el metodo u operación Dirigir
            MessageBox.Show(rector1.Dirigir());
        }
    }
}
