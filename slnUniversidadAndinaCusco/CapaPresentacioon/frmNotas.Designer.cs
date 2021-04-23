
namespace CapaPresentacioon
{
    partial class frmNotas
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
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnEscribir = new System.Windows.Forms.Button();
            this.btnAprobar = new System.Windows.Forms.Button();
            this.btnDesaprobar = new System.Windows.Forms.Button();
            this.btnIncrementar = new System.Windows.Forms.Button();
            this.btnDisminuir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCurso
            // 
            this.txtCurso.Location = new System.Drawing.Point(172, 43);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(100, 22);
            this.txtCurso.TabIndex = 0;
            this.txtCurso.TextChanged += new System.EventHandler(this.txtCurso_TextChanged);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(172, 99);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 22);
            this.txtValor.TabIndex = 1;
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(326, 41);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(75, 23);
            this.btnLeer.TabIndex = 2;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnEscribir
            // 
            this.btnEscribir.Location = new System.Drawing.Point(326, 97);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(75, 23);
            this.btnEscribir.TabIndex = 3;
            this.btnEscribir.Text = "Escribir";
            this.btnEscribir.UseVisualStyleBackColor = true;
            this.btnEscribir.Click += new System.EventHandler(this.btnEscribir_Click);
            // 
            // btnAprobar
            // 
            this.btnAprobar.Location = new System.Drawing.Point(74, 192);
            this.btnAprobar.Name = "btnAprobar";
            this.btnAprobar.Size = new System.Drawing.Size(75, 23);
            this.btnAprobar.TabIndex = 4;
            this.btnAprobar.Text = "Aprobar";
            this.btnAprobar.UseVisualStyleBackColor = true;
            this.btnAprobar.Click += new System.EventHandler(this.btnAprobar_Click);
            // 
            // btnDesaprobar
            // 
            this.btnDesaprobar.Location = new System.Drawing.Point(188, 192);
            this.btnDesaprobar.Name = "btnDesaprobar";
            this.btnDesaprobar.Size = new System.Drawing.Size(92, 23);
            this.btnDesaprobar.TabIndex = 5;
            this.btnDesaprobar.Text = "Desaprobar";
            this.btnDesaprobar.UseVisualStyleBackColor = true;
            this.btnDesaprobar.Click += new System.EventHandler(this.btnDesaprobar_Click);
            // 
            // btnIncrementar
            // 
            this.btnIncrementar.Location = new System.Drawing.Point(326, 191);
            this.btnIncrementar.Name = "btnIncrementar";
            this.btnIncrementar.Size = new System.Drawing.Size(98, 23);
            this.btnIncrementar.TabIndex = 6;
            this.btnIncrementar.Text = "Incrementar";
            this.btnIncrementar.UseVisualStyleBackColor = true;
            this.btnIncrementar.Click += new System.EventHandler(this.btnIncrementar_Click);
            // 
            // btnDisminuir
            // 
            this.btnDisminuir.Location = new System.Drawing.Point(468, 191);
            this.btnDisminuir.Name = "btnDisminuir";
            this.btnDisminuir.Size = new System.Drawing.Size(83, 23);
            this.btnDisminuir.TabIndex = 7;
            this.btnDisminuir.Text = "Disminuir";
            this.btnDisminuir.UseVisualStyleBackColor = true;
            this.btnDisminuir.Click += new System.EventHandler(this.btnDisminuir_Click);
            // 
            // frmNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDisminuir);
            this.Controls.Add(this.btnIncrementar);
            this.Controls.Add(this.btnDesaprobar);
            this.Controls.Add(this.btnAprobar);
            this.Controls.Add(this.btnEscribir);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtCurso);
            this.Name = "frmNotas";
            this.Text = "Notas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnEscribir;
        private System.Windows.Forms.Button btnAprobar;
        private System.Windows.Forms.Button btnDesaprobar;
        private System.Windows.Forms.Button btnIncrementar;
        private System.Windows.Forms.Button btnDisminuir;
    }
}