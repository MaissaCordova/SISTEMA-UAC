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
    public partial class frmJefePractica : Form
    {
        public frmJefePractica()
        {
            InitializeComponent();
        }
        // Instanciar la clase a traves de un objeto
        // En esta parte del codigo se declaran variables globales
        CapaNegocio.JefePractica jefe1 = new CapaNegocio.JefePractica();
        private void btnLeer_Click(object sender, EventArgs e)
        {
            //Leer datos del formulario
            string apellidos = txtApellidos.Text;
            string nombres = txtNombres.Text;
            string dni = txtDni.Text;
            string profesion = txtProfesion.Text;
            jefe1.Apellidos = apellidos;
            jefe1.Nombres = nombres;
            jefe1.Dni = dni;
            jefe1.Profesion = profesion;
            MessageBox.Show("Se ha registrado correctamente los datos del Jefe Practica");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            //Mostrar los datos almacenados en el objeto 1
            string apellidos = jefe1.Apellidos;
            string nombres = jefe1.Nombres;
            string dni = jefe1.Dni;
            string profesion = jefe1.Profesion;
            MessageBox.Show(" Apellidos: " + apellidos + " Nombres:" + nombres + " Dni:" + dni + "Profesion: " + profesion);
        }

        private void btnBrindarAyuda_Click(object sender, EventArgs e)
        {
            //Mostrar el metodo u operacion Brindar ayuda
            MessageBox.Show(jefe1.BrindarAyuda());
        }

        private void btnSupervisar_Click(object sender, EventArgs e)
        {
            //Mostrar el metodo u operacion Supervisar
            MessageBox.Show(jefe1.Supervisar());
        }

        private void btnControlar_Click(object sender, EventArgs e)
        {
            //Mostrar el metodo u operacion Controlar
            MessageBox.Show(jefe1.Controlar());
        }
    }
}
