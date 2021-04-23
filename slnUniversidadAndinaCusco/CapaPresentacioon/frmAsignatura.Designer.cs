
namespace CapaPresentacioon
{
    partial class frmAsignatura
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
            this.txtEspecialidad = new System.Windows.Forms.TextBox();
            this.txtDocente = new System.Windows.Forms.TextBox();
            this.txtAula = new System.Windows.Forms.TextBox();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnEscribir = new System.Windows.Forms.Button();
            this.btnAprender = new System.Windows.Forms.Button();
            this.btnEstudiar = new System.Windows.Forms.Button();
            this.btnConocer = new System.Windows.Forms.Button();
            this.btnClasificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEspecialidad
            // 
            this.txtEspecialidad.Location = new System.Drawing.Point(177, 40);
            this.txtEspecialidad.Name = "txtEspecialidad";
            this.txtEspecialidad.Size = new System.Drawing.Size(100, 22);
            this.txtEspecialidad.TabIndex = 0;
            // 
            // txtDocente
            // 
            this.txtDocente.Location = new System.Drawing.Point(177, 83);
            this.txtDocente.Name = "txtDocente";
            this.txtDocente.Size = new System.Drawing.Size(100, 22);
            this.txtDocente.TabIndex = 1;
            // 
            // txtAula
            // 
            this.txtAula.Location = new System.Drawing.Point(177, 126);
            this.txtAula.Name = "txtAula";
            this.txtAula.Size = new System.Drawing.Size(100, 22);
            this.txtAula.TabIndex = 2;
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(351, 58);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(75, 23);
            this.btnLeer.TabIndex = 3;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnEscribir
            // 
            this.btnEscribir.Location = new System.Drawing.Point(351, 104);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(75, 23);
            this.btnEscribir.TabIndex = 4;
            this.btnEscribir.Text = "Escribir";
            this.btnEscribir.UseVisualStyleBackColor = true;
            this.btnEscribir.Click += new System.EventHandler(this.btnEscribir_Click);
            // 
            // btnAprender
            // 
            this.btnAprender.Location = new System.Drawing.Point(69, 191);
            this.btnAprender.Name = "btnAprender";
            this.btnAprender.Size = new System.Drawing.Size(75, 23);
            this.btnAprender.TabIndex = 5;
            this.btnAprender.Text = "Aprender";
            this.btnAprender.UseVisualStyleBackColor = true;
            this.btnAprender.Click += new System.EventHandler(this.btnAprender_Click);
            // 
            // btnEstudiar
            // 
            this.btnEstudiar.Location = new System.Drawing.Point(188, 191);
            this.btnEstudiar.Name = "btnEstudiar";
            this.btnEstudiar.Size = new System.Drawing.Size(75, 23);
            this.btnEstudiar.TabIndex = 6;
            this.btnEstudiar.Text = "Estudiar";
            this.btnEstudiar.UseVisualStyleBackColor = true;
            this.btnEstudiar.Click += new System.EventHandler(this.btnEstudiar_Click);
            // 
            // btnConocer
            // 
            this.btnConocer.Location = new System.Drawing.Point(311, 191);
            this.btnConocer.Name = "btnConocer";
            this.btnConocer.Size = new System.Drawing.Size(75, 23);
            this.btnConocer.TabIndex = 7;
            this.btnConocer.Text = "Conocer";
            this.btnConocer.UseVisualStyleBackColor = true;
            this.btnConocer.Click += new System.EventHandler(this.btnConocer_Click);
            // 
            // btnClasificar
            // 
            this.btnClasificar.Location = new System.Drawing.Point(432, 190);
            this.btnClasificar.Name = "btnClasificar";
            this.btnClasificar.Size = new System.Drawing.Size(75, 23);
            this.btnClasificar.TabIndex = 8;
            this.btnClasificar.Text = "Clasificar";
            this.btnClasificar.UseVisualStyleBackColor = true;
            this.btnClasificar.Click += new System.EventHandler(this.btnClasificar_Click);
            // 
            // frmAsignatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClasificar);
            this.Controls.Add(this.btnConocer);
            this.Controls.Add(this.btnEstudiar);
            this.Controls.Add(this.btnAprender);
            this.Controls.Add(this.btnEscribir);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.txtAula);
            this.Controls.Add(this.txtDocente);
            this.Controls.Add(this.txtEspecialidad);
            this.Name = "frmAsignatura";
            this.Text = "Asignatura";
            this.Load += new System.EventHandler(this.frmAsignatura_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEspecialidad;
        private System.Windows.Forms.TextBox txtDocente;
        private System.Windows.Forms.TextBox txtAula;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnEscribir;
        private System.Windows.Forms.Button btnAprender;
        private System.Windows.Forms.Button btnEstudiar;
        private System.Windows.Forms.Button btnConocer;
        private System.Windows.Forms.Button btnClasificar;
    }
}