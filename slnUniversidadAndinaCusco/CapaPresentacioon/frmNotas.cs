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
    public partial class frmNotas : Form
    {
        public frmNotas()
        {
            InitializeComponent();
        }
        // Instanciar la clase a traves de un objeto
        // En esta parte del codigo se declaran variables globales
        CapaNegocio.Notas notas1 = new CapaNegocio.Notas();
        private void txtCurso_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            //Leer datos del formulario
            string curso = txtCurso.Text;
            int valor = int.Parse(txtValor.Text);
            notas1.Curso = curso;
            notas1.Valor = valor;
            MessageBox.Show("Se han registrado correctamente los datos de Notas1");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            //Mostrar los datos almacenados en el objeto 1
            string curso = notas1.Curso;
            int valor = notas1.Valor;
            MessageBox.Show("Curso: " + curso + "Valor: " + valor);
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            //Mostrar el metodo u operacion Aprobar
            MessageBox.Show(notas1.Aprobar());
        }

        private void btnDesaprobar_Click(object sender, EventArgs e)
        {
            //Mostrar el metodo u operacion Desaprobar
            MessageBox.Show(notas1.Desaprobar());
        }

        private void btnIncrementar_Click(object sender, EventArgs e)
        {
            //Mostrar el metodo u operacion Incrementar
            MessageBox.Show(notas1.Incrementar());
        }

        private void btnDisminuir_Click(object sender, EventArgs e)
        {
            //Mostrar el metodo u operacion Disminuir
            MessageBox.Show(notas1.Disminuir());
        }
    }
}
