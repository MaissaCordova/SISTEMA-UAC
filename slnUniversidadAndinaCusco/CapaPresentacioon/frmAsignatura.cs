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
    public partial class frmAsignatura : Form
    {
        public frmAsignatura()
        {
            InitializeComponent();
        }
        //Instanciar la clas a traves de un objeto
        CapaNegocio.Asignatura Asignatura1 = new CapaNegocio.Asignatura();

        private void btnLeer_Click(object sender, EventArgs e)
        {
            //Leer los datos del fromulario
            string especialidad = txtEspecialidad.Text;
            string docente = txtDocente.Text;
            int aula = int.Parse(txtAula.Text);
            Asignatura1.Especialidad = especialidad;
            Asignatura1.Docente = docente;
            Asignatura1.Aula = aula;
            MessageBox.Show("Se han registrado correctamente los datos de la Asignatura");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            //Mostrar los datos almacenados en el objeto 1
            string especialidad = Asignatura1.Especialidad;
            string docente = Asignatura1.Docente;
            int aula = Asignatura1.Aula;
            MessageBox.Show("Especialidad: " + especialidad + "Idiomas: " + docente + "Aula: " + aula);
        }

        private void btnAprender_Click(object sender, EventArgs e)
        {
            //Mostrar el metodo u operacion Aprender
            MessageBox.Show(Asignatura1.Aprender());
        }

        private void btnEstudiar_Click(object sender, EventArgs e)
        {
            //Mostrar el metodo u operacion Estudiar
            MessageBox.Show(Asignatura1.Estudiar());
        }

        private void btnConocer_Click(object sender, EventArgs e)
        {
            //Mostrar el metodo u operacion Conocer
            MessageBox.Show(Asignatura1.Conocer());
        }

        private void frmAsignatura_Load(object sender, EventArgs e)
        {

        }

        private void btnClasificar_Click(object sender, EventArgs e)
        {
            //Mostrar el metodo u operacion Clasificar
            MessageBox.Show(Asignatura1.Clasificar());
        }
    }
}
