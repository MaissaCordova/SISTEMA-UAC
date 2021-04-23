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
    public partial class frmPpp : Form
    {
        public frmPpp()
        {
            InitializeComponent();
        }
        // Instanciar la clase a traves de un objeto
        // En esta parte del codigo se declaran variables globales
        CapaNegocio.Ppp practicante1 = new CapaNegocio.Ppp();

        private void btnLeer_Click(object sender, EventArgs e)
        {
            //Leer datos del formulario
            string apellidos = txtApellidos.Text;
            string nombres = txtNombres.Text;
            string dni = txtDni.Text;
            string profesion = txtProfesion.Text;
            string empresa = txtEmpresa.Text;
            practicante1.Apellidos = apellidos;
            practicante1.Nombres = nombres;
            practicante1.Dni = dni;
            practicante1.Profesion = profesion;
            practicante1.Empresa = empresa;
            MessageBox.Show("Se ha registrado correctamente los datos del Practicante");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            //Mostrar los datos almacenados en el objeto 1
            string apellidos = practicante1.Apellidos;
            string nombres = practicante1.Nombres;
            string dni = practicante1.Dni;
            string profesion = practicante1.Profesion;
            string empresa = practicante1.Empresa;
            MessageBox.Show("Apellidos: " + apellidos + "   Nombres: " + nombres + "   Edad: " + dni + "   Profesion: " + profesion + "   Empresa: " + empresa);
        }

        private void btnAprender_Click(object sender, EventArgs e)
        {
            //Mostrar el metodo u operacion Aprender
            MessageBox.Show(practicante1.Aprender());
        }

        private void btnTrabajar_Click(object sender, EventArgs e)
        {
            //Mostrar el metodo u operacion Trabajar
            MessageBox.Show(practicante1.Trabajar());
        }

        private void btnAdquirirExperiencia_Click(object sender, EventArgs e)
        {
            //Mostrar el metodo u operacion Adquirir Experiencia
            MessageBox.Show(practicante1.AdquirirExperiencia());
        }

        private void btnReforzar_Click(object sender, EventArgs e)
        {
            //Mostrar el metodo u operacion Adquirir Experiencia
            MessageBox.Show(practicante1.Reforzar());
        }
    }
}
