
namespace CapaPresentacioon
{
    partial class frmAlumno
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtLugarNacimiento = new System.Windows.Forms.TextBox();
            this.btnEstudiar = new System.Windows.Forms.Button();
            this.btnTrabajar = new System.Windows.Forms.Button();
            this.btnAprobarExamen = new System.Windows.Forms.Button();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnEscribir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(109, 22);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(100, 22);
            this.txtApellidos.TabIndex = 0;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(109, 61);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(100, 22);
            this.txtNombres.TabIndex = 1;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(109, 98);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 22);
            this.txtEdad.TabIndex = 2;
            // 
            // txtLugarNacimiento
            // 
            this.txtLugarNacimiento.Location = new System.Drawing.Point(109, 140);
            this.txtLugarNacimiento.Name = "txtLugarNacimiento";
            this.txtLugarNacimiento.Size = new System.Drawing.Size(100, 22);
            this.txtLugarNacimiento.TabIndex = 3;
            // 
            // btnEstudiar
            // 
            this.btnEstudiar.Location = new System.Drawing.Point(42, 189);
            this.btnEstudiar.Name = "btnEstudiar";
            this.btnEstudiar.Size = new System.Drawing.Size(75, 23);
            this.btnEstudiar.TabIndex = 4;
            this.btnEstudiar.Text = "Estudiar";
            this.btnEstudiar.UseVisualStyleBackColor = true;
            this.btnEstudiar.Click += new System.EventHandler(this.btnEstudiar_Click);
            // 
            // btnTrabajar
            // 
            this.btnTrabajar.Location = new System.Drawing.Point(159, 189);
            this.btnTrabajar.Name = "btnTrabajar";
            this.btnTrabajar.Size = new System.Drawing.Size(75, 23);
            this.btnTrabajar.TabIndex = 5;
            this.btnTrabajar.Text = "Trabajar";
            this.btnTrabajar.UseVisualStyleBackColor = true;
            this.btnTrabajar.Click += new System.EventHandler(this.btnTrabajar_Click);
            // 
            // btnAprobarExamen
            // 
            this.btnAprobarExamen.Location = new System.Drawing.Point(281, 189);
            this.btnAprobarExamen.Name = "btnAprobarExamen";
            this.btnAprobarExamen.Size = new System.Drawing.Size(122, 23);
            this.btnAprobarExamen.TabIndex = 6;
            this.btnAprobarExamen.Text = "AprobarExamen";
            this.btnAprobarExamen.UseVisualStyleBackColor = true;
            this.btnAprobarExamen.Click += new System.EventHandler(this.btnAprobarExamen_Click);
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(281, 60);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(75, 23);
            this.btnLeer.TabIndex = 7;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEscribir
            // 
            this.btnEscribir.Location = new System.Drawing.Point(281, 98);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(75, 23);
            this.btnEscribir.TabIndex = 8;
            this.btnEscribir.Text = "Escribir";
            this.btnEscribir.UseVisualStyleBackColor = true;
            this.btnEscribir.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // frmAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 473);
            this.Controls.Add(this.btnEscribir);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.btnAprobarExamen);
            this.Controls.Add(this.btnTrabajar);
            this.Controls.Add(this.btnEstudiar);
            this.Controls.Add(this.txtLugarNacimiento);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtApellidos);
            this.Name = "frmAlumno";
            this.Text = "Trabajr con la clase Alumno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtLugarNacimiento;
        private System.Windows.Forms.Button btnEstudiar;
        private System.Windows.Forms.Button btnTrabajar;
        private System.Windows.Forms.Button btnAprobarExamen;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnEscribir;
    }
}

