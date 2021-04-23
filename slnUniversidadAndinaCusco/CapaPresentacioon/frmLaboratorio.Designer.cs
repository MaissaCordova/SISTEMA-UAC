
namespace CapaPresentacioon
{
    partial class frmLaboratorio
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
            this.txtElementos = new System.Windows.Forms.TextBox();
            this.txtForo = new System.Windows.Forms.TextBox();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.txtCantidadAlumnos = new System.Windows.Forms.TextBox();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnEscribir = new System.Windows.Forms.Button();
            this.btnInvestigar = new System.Windows.Forms.Button();
            this.btnExperimentar = new System.Windows.Forms.Button();
            this.btnAprender = new System.Windows.Forms.Button();
            this.btnAnalizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtElementos
            // 
            this.txtElementos.Location = new System.Drawing.Point(147, 30);
            this.txtElementos.Name = "txtElementos";
            this.txtElementos.Size = new System.Drawing.Size(100, 22);
            this.txtElementos.TabIndex = 0;
            this.txtElementos.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtForo
            // 
            this.txtForo.Location = new System.Drawing.Point(147, 71);
            this.txtForo.Name = "txtForo";
            this.txtForo.Size = new System.Drawing.Size(100, 22);
            this.txtForo.TabIndex = 1;
            // 
            // txtCarrera
            // 
            this.txtCarrera.Location = new System.Drawing.Point(147, 112);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(100, 22);
            this.txtCarrera.TabIndex = 2;
            // 
            // txtCantidadAlumnos
            // 
            this.txtCantidadAlumnos.Location = new System.Drawing.Point(147, 154);
            this.txtCantidadAlumnos.Name = "txtCantidadAlumnos";
            this.txtCantidadAlumnos.Size = new System.Drawing.Size(100, 22);
            this.txtCantidadAlumnos.TabIndex = 3;
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(348, 71);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(75, 23);
            this.btnLeer.TabIndex = 4;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnEscribir
            // 
            this.btnEscribir.Location = new System.Drawing.Point(348, 112);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(75, 23);
            this.btnEscribir.TabIndex = 5;
            this.btnEscribir.Text = "Escribir";
            this.btnEscribir.UseVisualStyleBackColor = true;
            this.btnEscribir.Click += new System.EventHandler(this.btnEscribir_Click);
            // 
            // btnInvestigar
            // 
            this.btnInvestigar.Location = new System.Drawing.Point(71, 250);
            this.btnInvestigar.Name = "btnInvestigar";
            this.btnInvestigar.Size = new System.Drawing.Size(83, 23);
            this.btnInvestigar.TabIndex = 6;
            this.btnInvestigar.Text = "Investigar";
            this.btnInvestigar.UseVisualStyleBackColor = true;
            this.btnInvestigar.Click += new System.EventHandler(this.btnInvestigar_Click);
            // 
            // btnExperimentar
            // 
            this.btnExperimentar.Location = new System.Drawing.Point(395, 250);
            this.btnExperimentar.Name = "btnExperimentar";
            this.btnExperimentar.Size = new System.Drawing.Size(109, 23);
            this.btnExperimentar.TabIndex = 7;
            this.btnExperimentar.Text = "Experimentar";
            this.btnExperimentar.UseVisualStyleBackColor = true;
            this.btnExperimentar.Click += new System.EventHandler(this.btnExperimentar_Click);
            // 
            // btnAprender
            // 
            this.btnAprender.Location = new System.Drawing.Point(287, 250);
            this.btnAprender.Name = "btnAprender";
            this.btnAprender.Size = new System.Drawing.Size(75, 23);
            this.btnAprender.TabIndex = 8;
            this.btnAprender.Text = "Aprender";
            this.btnAprender.UseVisualStyleBackColor = true;
            this.btnAprender.Click += new System.EventHandler(this.btnAprender_Click);
            // 
            // btnAnalizar
            // 
            this.btnAnalizar.Location = new System.Drawing.Point(185, 250);
            this.btnAnalizar.Name = "btnAnalizar";
            this.btnAnalizar.Size = new System.Drawing.Size(75, 23);
            this.btnAnalizar.TabIndex = 9;
            this.btnAnalizar.Text = "Analizar";
            this.btnAnalizar.UseVisualStyleBackColor = true;
            this.btnAnalizar.Click += new System.EventHandler(this.btnAnalizar_Click);
            // 
            // frmLaboratorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAnalizar);
            this.Controls.Add(this.btnAprender);
            this.Controls.Add(this.btnExperimentar);
            this.Controls.Add(this.btnInvestigar);
            this.Controls.Add(this.btnEscribir);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.txtCantidadAlumnos);
            this.Controls.Add(this.txtCarrera);
            this.Controls.Add(this.txtForo);
            this.Controls.Add(this.txtElementos);
            this.Name = "frmLaboratorio";
            this.Text = "Laboratorio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtElementos;
        private System.Windows.Forms.TextBox txtForo;
        private System.Windows.Forms.TextBox txtCarrera;
        private System.Windows.Forms.TextBox txtCantidadAlumnos;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnEscribir;
        private System.Windows.Forms.Button btnInvestigar;
        private System.Windows.Forms.Button btnExperimentar;
        private System.Windows.Forms.Button btnAprender;
        private System.Windows.Forms.Button btnAnalizar;
    }
}