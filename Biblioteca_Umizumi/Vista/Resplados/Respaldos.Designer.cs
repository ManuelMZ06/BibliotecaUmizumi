namespace Biblioteca_Umizumi.Vista.Resplados
{
    partial class Respaldos
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
            this.lblSidebar = new System.Windows.Forms.Label();
            this.pbRespaldos = new System.Windows.Forms.PictureBox();
            this.btnSeleccionarRuta = new System.Windows.Forms.Button();
            this.btnRestarura = new System.Windows.Forms.Button();
            this.btnRespaldar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.txtRuta = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbRespaldos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSidebar
            // 
            this.lblSidebar.AutoSize = true;
            this.lblSidebar.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSidebar.Location = new System.Drawing.Point(12, 9);
            this.lblSidebar.Name = "lblSidebar";
            this.lblSidebar.Size = new System.Drawing.Size(237, 42);
            this.lblSidebar.TabIndex = 1;
            this.lblSidebar.Text = "R E S P A L D O S";
            // 
            // pbRespaldos
            // 
            this.pbRespaldos.Location = new System.Drawing.Point(497, 31);
            this.pbRespaldos.Name = "pbRespaldos";
            this.pbRespaldos.Size = new System.Drawing.Size(519, 413);
            this.pbRespaldos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRespaldos.TabIndex = 2;
            this.pbRespaldos.TabStop = false;
            // 
            // btnSeleccionarRuta
            // 
            this.btnSeleccionarRuta.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSeleccionarRuta.FlatAppearance.BorderSize = 0;
            this.btnSeleccionarRuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarRuta.Location = new System.Drawing.Point(19, 287);
            this.btnSeleccionarRuta.Name = "btnSeleccionarRuta";
            this.btnSeleccionarRuta.Size = new System.Drawing.Size(390, 44);
            this.btnSeleccionarRuta.TabIndex = 18;
            this.btnSeleccionarRuta.Text = "Seleccionar Ruta";
            this.btnSeleccionarRuta.UseVisualStyleBackColor = false;
            this.btnSeleccionarRuta.Click += new System.EventHandler(this.btnSeleccionarRuta_Click);
            // 
            // btnRestarura
            // 
            this.btnRestarura.BackColor = System.Drawing.Color.Beige;
            this.btnRestarura.FlatAppearance.BorderSize = 0;
            this.btnRestarura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestarura.Location = new System.Drawing.Point(19, 213);
            this.btnRestarura.Name = "btnRestarura";
            this.btnRestarura.Size = new System.Drawing.Size(390, 44);
            this.btnRestarura.TabIndex = 19;
            this.btnRestarura.Text = "Restaurar Respaldo";
            this.btnRestarura.UseVisualStyleBackColor = false;
            this.btnRestarura.Click += new System.EventHandler(this.btnRestarura_Click);
            // 
            // btnRespaldar
            // 
            this.btnRespaldar.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnRespaldar.FlatAppearance.BorderSize = 0;
            this.btnRespaldar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRespaldar.Location = new System.Drawing.Point(19, 135);
            this.btnRespaldar.Name = "btnRespaldar";
            this.btnRespaldar.Size = new System.Drawing.Size(390, 44);
            this.btnRespaldar.TabIndex = 20;
            this.btnRespaldar.Text = "Crear Respaldo";
            this.btnRespaldar.UseVisualStyleBackColor = false;
            this.btnRespaldar.Click += new System.EventHandler(this.btnRespaldar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegresar.Location = new System.Drawing.Point(19, 417);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(76, 63);
            this.btnRegresar.TabIndex = 21;
            this.btnRegresar.Text = "←";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnCerrarSesión_Click);
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(12, 360);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.ReadOnly = true;
            this.txtRuta.Size = new System.Drawing.Size(478, 26);
            this.txtRuta.TabIndex = 22;
            // 
            // Respaldos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1032, 505);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnRespaldar);
            this.Controls.Add(this.btnRestarura);
            this.Controls.Add(this.btnSeleccionarRuta);
            this.Controls.Add(this.pbRespaldos);
            this.Controls.Add(this.lblSidebar);
            this.Name = "Respaldos";
            this.Text = "Respaldos";
            this.Load += new System.EventHandler(this.Respaldos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbRespaldos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSidebar;
        private System.Windows.Forms.PictureBox pbRespaldos;
        private System.Windows.Forms.Button btnSeleccionarRuta;
        private System.Windows.Forms.Button btnRestarura;
        private System.Windows.Forms.Button btnRespaldar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.TextBox txtRuta;
    }
}