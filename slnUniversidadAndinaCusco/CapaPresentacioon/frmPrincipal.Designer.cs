
namespace CapaPresentacioon
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.alumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.docenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laboratorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignaturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jefePracticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alumnoToolStripMenuItem,
            this.docenteToolStripMenuItem,
            this.laboratorioToolStripMenuItem,
            this.asignaturaToolStripMenuItem,
            this.notasToolStripMenuItem,
            this.rectorToolStripMenuItem,
            this.pppToolStripMenuItem,
            this.jefePracticasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // alumnoToolStripMenuItem
            // 
            this.alumnoToolStripMenuItem.Name = "alumnoToolStripMenuItem";
            this.alumnoToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.alumnoToolStripMenuItem.Text = "Alumno";
            this.alumnoToolStripMenuItem.Click += new System.EventHandler(this.alumnoToolStripMenuItem_Click);
            // 
            // docenteToolStripMenuItem
            // 
            this.docenteToolStripMenuItem.Name = "docenteToolStripMenuItem";
            this.docenteToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.docenteToolStripMenuItem.Text = "Docente";
            this.docenteToolStripMenuItem.Click += new System.EventHandler(this.docenteToolStripMenuItem_Click);
            // 
            // laboratorioToolStripMenuItem
            // 
            this.laboratorioToolStripMenuItem.Name = "laboratorioToolStripMenuItem";
            this.laboratorioToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.laboratorioToolStripMenuItem.Text = "Laboratorio";
            this.laboratorioToolStripMenuItem.Click += new System.EventHandler(this.laboratorioToolStripMenuItem_Click);
            // 
            // asignaturaToolStripMenuItem
            // 
            this.asignaturaToolStripMenuItem.Name = "asignaturaToolStripMenuItem";
            this.asignaturaToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.asignaturaToolStripMenuItem.Text = "Asignatura";
            this.asignaturaToolStripMenuItem.Click += new System.EventHandler(this.asignaturaToolStripMenuItem_Click);
            // 
            // notasToolStripMenuItem
            // 
            this.notasToolStripMenuItem.Name = "notasToolStripMenuItem";
            this.notasToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.notasToolStripMenuItem.Text = "Notas";
            this.notasToolStripMenuItem.Click += new System.EventHandler(this.notasToolStripMenuItem_Click);
            // 
            // rectorToolStripMenuItem
            // 
            this.rectorToolStripMenuItem.Name = "rectorToolStripMenuItem";
            this.rectorToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.rectorToolStripMenuItem.Text = "Rector";
            this.rectorToolStripMenuItem.Click += new System.EventHandler(this.rectorToolStripMenuItem_Click);
            // 
            // pppToolStripMenuItem
            // 
            this.pppToolStripMenuItem.Name = "pppToolStripMenuItem";
            this.pppToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.pppToolStripMenuItem.Text = "Ppp";
            this.pppToolStripMenuItem.Click += new System.EventHandler(this.pppToolStripMenuItem_Click);
            // 
            // jefePracticasToolStripMenuItem
            // 
            this.jefePracticasToolStripMenuItem.Name = "jefePracticasToolStripMenuItem";
            this.jefePracticasToolStripMenuItem.Size = new System.Drawing.Size(101, 26);
            this.jefePracticasToolStripMenuItem.Text = "JefePractica";
            this.jefePracticasToolStripMenuItem.Click += new System.EventHandler(this.jefePracticasToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = " Informacion para la UAC";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem alumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem docenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laboratorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignaturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rectorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pppToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jefePracticasToolStripMenuItem;
    }
}