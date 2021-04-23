
namespace CapaPresentacioon
{
    partial class frmJefePractica
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
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnEscribir = new System.Windows.Forms.Button();
            this.btnBrindarAyuda = new System.Windows.Forms.Button();
            this.btnSupervisar = new System.Windows.Forms.Button();
            this.btnControlar = new System.Windows.Forms.Button();
            this.txtProfesion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(140, 65);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(100, 22);
            this.txtApellidos.TabIndex = 0;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(140, 100);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(100, 22);
            this.txtNombres.TabIndex = 1;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(140, 139);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 22);
            this.txtDni.TabIndex = 2;
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(300, 100);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(75, 23);
            this.btnLeer.TabIndex = 3;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnEscribir
            // 
            this.btnEscribir.Location = new System.Drawing.Point(300, 139);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(75, 23);
            this.btnEscribir.TabIndex = 4;
            this.btnEscribir.Text = "Escribir";
            this.btnEscribir.UseVisualStyleBackColor = true;
            this.btnEscribir.Click += new System.EventHandler(this.btnEscribir_Click);
            // 
            // btnBrindarAyuda
            // 
            this.btnBrindarAyuda.Location = new System.Drawing.Point(64, 244);
            this.btnBrindarAyuda.Name = "btnBrindarAyuda";
            this.btnBrindarAyuda.Size = new System.Drawing.Size(117, 23);
            this.btnBrindarAyuda.TabIndex = 5;
            this.btnBrindarAyuda.Text = "BrindarAyuda";
            this.btnBrindarAyuda.UseVisualStyleBackColor = true;
            this.btnBrindarAyuda.Click += new System.EventHandler(this.btnBrindarAyuda_Click);
            // 
            // btnSupervisar
            // 
            this.btnSupervisar.Location = new System.Drawing.Point(214, 244);
            this.btnSupervisar.Name = "btnSupervisar";
            this.btnSupervisar.Size = new System.Drawing.Size(89, 23);
            this.btnSupervisar.TabIndex = 6;
            this.btnSupervisar.Text = "Supervisar";
            this.btnSupervisar.UseVisualStyleBackColor = true;
            this.btnSupervisar.Click += new System.EventHandler(this.btnSupervisar_Click);
            // 
            // btnControlar
            // 
            this.btnControlar.Location = new System.Drawing.Point(333, 244);
            this.btnControlar.Name = "btnControlar";
            this.btnControlar.Size = new System.Drawing.Size(75, 23);
            this.btnControlar.TabIndex = 7;
            this.btnControlar.Text = "Controlar";
            this.btnControlar.UseVisualStyleBackColor = true;
            this.btnControlar.Click += new System.EventHandler(this.btnControlar_Click);
            // 
            // txtProfesion
            // 
            this.txtProfesion.Location = new System.Drawing.Point(140, 180);
            this.txtProfesion.Name = "txtProfesion";
            this.txtProfesion.Size = new System.Drawing.Size(100, 22);
            this.txtProfesion.TabIndex = 8;
            // 
            // frmJefePractica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtProfesion);
            this.Controls.Add(this.btnControlar);
            this.Controls.Add(this.btnSupervisar);
            this.Controls.Add(this.btnBrindarAyuda);
            this.Controls.Add(this.btnEscribir);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtApellidos);
            this.Name = "frmJefePractica";
            this.Text = "JefePractica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnEscribir;
        private System.Windows.Forms.Button btnBrindarAyuda;
        private System.Windows.Forms.Button btnSupervisar;
        private System.Windows.Forms.Button btnControlar;
        private System.Windows.Forms.TextBox txtProfesion;
    }
}