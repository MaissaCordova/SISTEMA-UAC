
namespace CapaPresentacioon
{
    partial class frmRector
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
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnEscribir = new System.Windows.Forms.Button();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtEspecialidad = new System.Windows.Forms.TextBox();
            this.txtUniversidad = new System.Windows.Forms.TextBox();
            this.txtGradoInstruccion = new System.Windows.Forms.TextBox();
            this.btnRepresentar = new System.Windows.Forms.Button();
            this.btnAdministrar = new System.Windows.Forms.Button();
            this.btnReglamentar = new System.Windows.Forms.Button();
            this.btnDirigir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(450, 33);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(75, 23);
            this.btnLeer.TabIndex = 0;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEscribir
            // 
            this.btnEscribir.Location = new System.Drawing.Point(450, 104);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(75, 23);
            this.btnEscribir.TabIndex = 1;
            this.btnEscribir.Text = "Escribir";
            this.btnEscribir.UseVisualStyleBackColor = true;
            this.btnEscribir.Click += new System.EventHandler(this.btnEscribir_Click);
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(154, 33);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(100, 22);
            this.txtApellidos.TabIndex = 2;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(154, 61);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(100, 22);
            this.txtNombres.TabIndex = 3;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(154, 89);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 22);
            this.txtEdad.TabIndex = 4;
            // 
            // txtEspecialidad
            // 
            this.txtEspecialidad.Location = new System.Drawing.Point(154, 117);
            this.txtEspecialidad.Name = "txtEspecialidad";
            this.txtEspecialidad.Size = new System.Drawing.Size(100, 22);
            this.txtEspecialidad.TabIndex = 5;
            // 
            // txtUniversidad
            // 
            this.txtUniversidad.Location = new System.Drawing.Point(154, 145);
            this.txtUniversidad.Name = "txtUniversidad";
            this.txtUniversidad.Size = new System.Drawing.Size(100, 22);
            this.txtUniversidad.TabIndex = 6;
            // 
            // txtGradoInstruccion
            // 
            this.txtGradoInstruccion.Location = new System.Drawing.Point(154, 174);
            this.txtGradoInstruccion.Name = "txtGradoInstruccion";
            this.txtGradoInstruccion.Size = new System.Drawing.Size(100, 22);
            this.txtGradoInstruccion.TabIndex = 7;
            // 
            // btnRepresentar
            // 
            this.btnRepresentar.Location = new System.Drawing.Point(33, 232);
            this.btnRepresentar.Name = "btnRepresentar";
            this.btnRepresentar.Size = new System.Drawing.Size(95, 23);
            this.btnRepresentar.TabIndex = 8;
            this.btnRepresentar.Text = "Representar";
            this.btnRepresentar.UseVisualStyleBackColor = true;
            this.btnRepresentar.Click += new System.EventHandler(this.btnRepresentar_Click);
            // 
            // btnAdministrar
            // 
            this.btnAdministrar.Location = new System.Drawing.Point(154, 231);
            this.btnAdministrar.Name = "btnAdministrar";
            this.btnAdministrar.Size = new System.Drawing.Size(105, 23);
            this.btnAdministrar.TabIndex = 9;
            this.btnAdministrar.Text = "Administrar";
            this.btnAdministrar.UseVisualStyleBackColor = true;
            this.btnAdministrar.Click += new System.EventHandler(this.btnAdministrar_Click);
            // 
            // btnReglamentar
            // 
            this.btnReglamentar.Location = new System.Drawing.Point(282, 232);
            this.btnReglamentar.Name = "btnReglamentar";
            this.btnReglamentar.Size = new System.Drawing.Size(104, 23);
            this.btnReglamentar.TabIndex = 10;
            this.btnReglamentar.Text = "Reglamentar";
            this.btnReglamentar.UseVisualStyleBackColor = true;
            this.btnReglamentar.Click += new System.EventHandler(this.btnReglamentar_Click);
            // 
            // btnDirigir
            // 
            this.btnDirigir.Location = new System.Drawing.Point(402, 232);
            this.btnDirigir.Name = "btnDirigir";
            this.btnDirigir.Size = new System.Drawing.Size(79, 23);
            this.btnDirigir.TabIndex = 11;
            this.btnDirigir.Text = "Dirigir";
            this.btnDirigir.UseVisualStyleBackColor = true;
            this.btnDirigir.Click += new System.EventHandler(this.btnDirigir_Click);
            // 
            // frmRector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDirigir);
            this.Controls.Add(this.btnReglamentar);
            this.Controls.Add(this.btnAdministrar);
            this.Controls.Add(this.btnRepresentar);
            this.Controls.Add(this.txtGradoInstruccion);
            this.Controls.Add(this.txtUniversidad);
            this.Controls.Add(this.txtEspecialidad);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.btnEscribir);
            this.Controls.Add(this.btnLeer);
            this.Name = "frmRector";
            this.Text = "Rector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnEscribir;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtEspecialidad;
        private System.Windows.Forms.TextBox txtUniversidad;
        private System.Windows.Forms.TextBox txtGradoInstruccion;
        private System.Windows.Forms.Button btnRepresentar;
        private System.Windows.Forms.Button btnAdministrar;
        private System.Windows.Forms.Button btnReglamentar;
        private System.Windows.Forms.Button btnDirigir;
    }
}