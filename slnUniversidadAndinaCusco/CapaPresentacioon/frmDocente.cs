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
    public partial class frmDocente : Form
    {
        public frmDocente()
        {
            InitializeComponent();
        }
        // Instanciar la clase a traves de un objeto
        // En esta parte del codigo se declaran variables globales
        CapaNegocio.Docente docente1 = new CapaNegocio.Docente();

        private void btnLeer_Click(object sender, EventArgs e)
        {
            //Leer datos del formulario
            string apellidos = txtApellidos.Text;
            string nombres = txtNombres.Text;
            int edad = int.Parse(txtEdad.Text);
            string dni = txtDni.Text;
            DateTime fechaNacimiento = DateTime.Parse(txtFechaNacimiento.Text);
            docente1.Apellidos = apellidos;
            docente1.Nombres = nombres;
            docente1.Edad = edad;
            docente1.Dni = dni;
            docente1.FechaNacimiento = fechaNacimiento;
            MessageBox.Show("Se han registrado correctamente los datos de Docente1");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            //Mostrar los datos almacenados en el objeto 1
            string apellidos = docente1.Apellidos;
            string nombres = docente1.Nombres;
            int edad = docente1.Edad;
            string dni = docente1.Dni;
            DateTime fechaNacimiento = docente1.FechaNacimiento;
            MessageBox.Show("Apellidos: " + apellidos + "Nombres: " + nombres + "Edad: " + edad + "Dni: " + dni + "fecha de Nacimiento: " + fechaNacimiento);
        }

        private void btnMatricular_Click(object sender, EventArgs e)
        {
            //Mostrar el metodo u operacion Matricular
            MessageBox.Show(docente1.Matricular());
        }

        private void btnEnseñar_Click(object sender, EventArgs e)
        {
            //Mostrar el metodo u operacion Enseñar
            MessageBox.Show(docente1.Enseñar());
        }

        private void btnAprobarAlumno_Click(object sender, EventArgs e)
        {
            //Mostrar el metodo u operacion AprobarAlumno
            MessageBox.Show(docente1.AprobarAlumno());
        }

        private void btnDesaprobarAlumno_Click(object sender, EventArgs e)
        {
            //Mostrar el metodo u operacion DesaprobarAlumno
            MessageBox.Show(docente1.DesaprobarAlumno());
        }

        private void frmDocente_Load(object sender, EventArgs e)
        {

        }

        private void txtApellidos_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
