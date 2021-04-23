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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void alumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Llamar al formulario alumno
            frmAlumno formulario = new frmAlumno();
            formulario.Show();
        }

        private void docenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Llamar al formulario docente
            frmDocente formulario = new frmDocente();
            formulario.Show();
        }

        private void notasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Llamar al formulario notas
            frmNotas formulario = new frmNotas();
            formulario.Show();
        }

        private void asignaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Llamar al formulario asignatura
            frmAsignatura formulario = new frmAsignatura();
            formulario.Show();
        }

        private void rectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Llamar al formulario asignatura
            frmRector formulario = new frmRector();
            formulario.Show();
        }

        private void laboratorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Llamar al formulario asignatura
            frmLaboratorio formulario = new frmLaboratorio();
            formulario.Show();
        }

        private void pppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Llamar al formulario asignatura
            frmPpp formulario = new frmPpp();
            formulario.Show();
        }

        private void jefePracticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Llamar al formulario asignatura
            frmJefePractica formulario = new frmJefePractica();
            formulario.Show();
        }
    }
}
