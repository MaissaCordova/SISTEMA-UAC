
namespace CapaPresentacioon
{
    partial class frmDocente
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
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnEscribir = new System.Windows.Forms.Button();
            this.btnMatricular = new System.Windows.Forms.Button();
            this.btnEnseñar = new System.Windows.Forms.Button();
            this.btnAprobarAlumno = new System.Windows.Forms.Button();
            this.btnDesaprobarAlumno = new System.Windows.Forms.Button();
            this.txtFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(122, 31);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(100, 22);
            this.txtApellidos.TabIndex = 0;
            this.txtApellidos.TextChanged += new System.EventHandler(this.txtApellidos_TextChanged);
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(122, 71);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(100, 22);
            this.txtNombres.TabIndex = 1;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(122, 112);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 22);
            this.txtEdad.TabIndex = 2;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(122, 151);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 22);
            this.txtDni.TabIndex = 3;
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(310, 71);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(75, 23);
            this.btnLeer.TabIndex = 5;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnEscribir
            // 
            this.btnEscribir.Location = new System.Drawing.Point(310, 112);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(75, 23);
            this.btnEscribir.TabIndex = 6;
            this.btnEscribir.Text = "Escribir";
            this.btnEscribir.UseVisualStyleBackColor = true;
            this.btnEscribir.Click += new System.EventHandler(this.btnEscribir_Click);
            // 
            // btnMatricular
            // 
            this.btnMatricular.Location = new System.Drawing.Point(56, 245);
            this.btnMatricular.Name = "btnMatricular";
            this.btnMatricular.Size = new System.Drawing.Size(84, 23);
            this.btnMatricular.TabIndex = 7;
            this.btnMatricular.Text = "Matricular";
            this.btnMatricular.UseVisualStyleBackColor = true;
            this.btnMatricular.Click += new System.EventHandler(this.btnMatricular_Click);
            // 
            // btnEnseñar
            // 
            this.btnEnseñar.Location = new System.Drawing.Point(166, 245);
            this.btnEnseñar.Name = "btnEnseñar";
            this.btnEnseñar.Size = new System.Drawing.Size(75, 23);
            this.btnEnseñar.TabIndex = 8;
            this.btnEnseñar.Text = "Enseñar";
            this.btnEnseñar.UseVisualStyleBackColor = true;
            this.btnEnseñar.Click += new System.EventHandler(this.btnEnseñar_Click);
            // 
            // btnAprobarAlumno
            // 
            this.btnAprobarAlumno.Location = new System.Drawing.Point(285, 244);
            this.btnAprobarAlumno.Name = "btnAprobarAlumno";
            this.btnAprobarAlumno.Size = new System.Drawing.Size(75, 23);
            this.btnAprobarAlumno.TabIndex = 9;
            this.btnAprobarAlumno.Text = "AprobarAlumno";
            this.btnAprobarAlumno.UseVisualStyleBackColor = true;
            this.btnAprobarAlumno.Click += new System.EventHandler(this.btnAprobarAlumno_Click);
            // 
            // btnDesaprobarAlumno
            // 
            this.btnDesaprobarAlumno.Location = new System.Drawing.Point(400, 244);
            this.btnDesaprobarAlumno.Name = "btnDesaprobarAlumno";
            this.btnDesaprobarAlumno.Size = new System.Drawing.Size(96, 23);
            this.btnDesaprobarAlumno.TabIndex = 10;
            this.btnDesaprobarAlumno.Text = "DesaprobarAlumno";
            this.btnDesaprobarAlumno.UseVisualStyleBackColor = true;
            this.btnDesaprobarAlumno.Click += new System.EventHandler(this.btnDesaprobarAlumno_Click);
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.Location = new System.Drawing.Point(122, 192);
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(200, 22);
            this.txtFechaNacimiento.TabIndex = 11;
            // 
            // frmDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtFechaNacimiento);
            this.Controls.Add(this.btnDesaprobarAlumno);
            this.Controls.Add(this.btnAprobarAlumno);
            this.Controls.Add(this.btnEnseñar);
            this.Controls.Add(this.btnMatricular);
            this.Controls.Add(this.btnEscribir);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtApellidos);
            this.Name = "frmDocente";
            this.Text = "Docente";
            this.Load += new System.EventHandler(this.frmDocente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnEscribir;
        private System.Windows.Forms.Button btnMatricular;
        private System.Windows.Forms.Button btnEnseñar;
        private System.Windows.Forms.Button btnAprobarAlumno;
        private System.Windows.Forms.Button btnDesaprobarAlumno;
        private System.Windows.Forms.DateTimePicker txtFechaNacimiento;
    }
}