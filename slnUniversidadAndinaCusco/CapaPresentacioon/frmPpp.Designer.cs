
namespace CapaPresentacioon
{
    partial class frmPpp
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
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtProfesion = new System.Windows.Forms.TextBox();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnEscribir = new System.Windows.Forms.Button();
            this.btnAprender = new System.Windows.Forms.Button();
            this.btnTrabajar = new System.Windows.Forms.Button();
            this.btnAdquirirExperiencia = new System.Windows.Forms.Button();
            this.btnReforzar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(206, 31);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(100, 22);
            this.txtApellidos.TabIndex = 0;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(206, 60);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(100, 22);
            this.txtNombres.TabIndex = 1;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(206, 89);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 22);
            this.txtDni.TabIndex = 2;
            // 
            // txtProfesion
            // 
            this.txtProfesion.Location = new System.Drawing.Point(206, 118);
            this.txtProfesion.Name = "txtProfesion";
            this.txtProfesion.Size = new System.Drawing.Size(100, 22);
            this.txtProfesion.TabIndex = 3;
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(206, 147);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(100, 22);
            this.txtEmpresa.TabIndex = 4;
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(362, 58);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(75, 23);
            this.btnLeer.TabIndex = 5;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnEscribir
            // 
            this.btnEscribir.Location = new System.Drawing.Point(362, 100);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(75, 23);
            this.btnEscribir.TabIndex = 6;
            this.btnEscribir.Text = "Escribir";
            this.btnEscribir.UseVisualStyleBackColor = true;
            this.btnEscribir.Click += new System.EventHandler(this.btnEscribir_Click);
            // 
            // btnAprender
            // 
            this.btnAprender.Location = new System.Drawing.Point(69, 206);
            this.btnAprender.Name = "btnAprender";
            this.btnAprender.Size = new System.Drawing.Size(75, 23);
            this.btnAprender.TabIndex = 7;
            this.btnAprender.Text = "Aprender";
            this.btnAprender.UseVisualStyleBackColor = true;
            this.btnAprender.Click += new System.EventHandler(this.btnAprender_Click);
            // 
            // btnTrabajar
            // 
            this.btnTrabajar.Location = new System.Drawing.Point(168, 206);
            this.btnTrabajar.Name = "btnTrabajar";
            this.btnTrabajar.Size = new System.Drawing.Size(75, 23);
            this.btnTrabajar.TabIndex = 8;
            this.btnTrabajar.Text = "Trabajar";
            this.btnTrabajar.UseVisualStyleBackColor = true;
            this.btnTrabajar.Click += new System.EventHandler(this.btnTrabajar_Click);
            // 
            // btnAdquirirExperiencia
            // 
            this.btnAdquirirExperiencia.Location = new System.Drawing.Point(273, 206);
            this.btnAdquirirExperiencia.Name = "btnAdquirirExperiencia";
            this.btnAdquirirExperiencia.Size = new System.Drawing.Size(140, 23);
            this.btnAdquirirExperiencia.TabIndex = 9;
            this.btnAdquirirExperiencia.Text = "AdquirirExperiencia";
            this.btnAdquirirExperiencia.UseVisualStyleBackColor = true;
            this.btnAdquirirExperiencia.Click += new System.EventHandler(this.btnAdquirirExperiencia_Click);
            // 
            // btnReforzar
            // 
            this.btnReforzar.Location = new System.Drawing.Point(440, 205);
            this.btnReforzar.Name = "btnReforzar";
            this.btnReforzar.Size = new System.Drawing.Size(75, 23);
            this.btnReforzar.TabIndex = 10;
            this.btnReforzar.Text = "Reforzar";
            this.btnReforzar.UseVisualStyleBackColor = true;
            this.btnReforzar.Click += new System.EventHandler(this.btnReforzar_Click);
            // 
            // frmPpp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReforzar);
            this.Controls.Add(this.btnAdquirirExperiencia);
            this.Controls.Add(this.btnTrabajar);
            this.Controls.Add(this.btnAprender);
            this.Controls.Add(this.btnEscribir);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.txtEmpresa);
            this.Controls.Add(this.txtProfesion);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtApellidos);
            this.Name = "frmPpp";
            this.Text = "Ppp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtProfesion;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnEscribir;
        private System.Windows.Forms.Button btnAprender;
        private System.Windows.Forms.Button btnTrabajar;
        private System.Windows.Forms.Button btnAdquirirExperiencia;
        private System.Windows.Forms.Button btnReforzar;
    }
}