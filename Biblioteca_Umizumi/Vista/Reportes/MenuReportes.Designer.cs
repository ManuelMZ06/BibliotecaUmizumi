namespace Biblioteca_Umizumi.Vista.Reportes
{
    partial class MenuReportes
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
            this.label8 = new System.Windows.Forms.Label();
            this.btnReporteLibros = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnReportesUsuarios = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Engravers MT", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(326, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(405, 37);
            this.label8.TabIndex = 25;
            this.label8.Text = "R E P O R T E R Í A";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // btnReporteLibros
            // 
            this.btnReporteLibros.BackColor = System.Drawing.Color.Lavender;
            this.btnReporteLibros.FlatAppearance.BorderSize = 0;
            this.btnReporteLibros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteLibros.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteLibros.Location = new System.Drawing.Point(47, 126);
            this.btnReporteLibros.Name = "btnReporteLibros";
            this.btnReporteLibros.Size = new System.Drawing.Size(297, 269);
            this.btnReporteLibros.TabIndex = 26;
            this.btnReporteLibros.Text = "📚 Reportes sobre Libros";
            this.btnReporteLibros.UseVisualStyleBackColor = false;
            this.btnReporteLibros.Click += new System.EventHandler(this.btnReporteLibros_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Thistle;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(734, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(297, 269);
            this.button2.TabIndex = 29;
            this.button2.Text = "🧾Reportes de Bitácoras";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnReportesUsuarios
            // 
            this.btnReportesUsuarios.BackColor = System.Drawing.Color.Honeydew;
            this.btnReportesUsuarios.FlatAppearance.BorderSize = 0;
            this.btnReportesUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportesUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportesUsuarios.Location = new System.Drawing.Point(392, 126);
            this.btnReportesUsuarios.Name = "btnReportesUsuarios";
            this.btnReportesUsuarios.Size = new System.Drawing.Size(297, 269);
            this.btnReportesUsuarios.TabIndex = 28;
            this.btnReportesUsuarios.Text = "👤Reportes sobre Usuarios";
            this.btnReportesUsuarios.UseVisualStyleBackColor = false;
            this.btnReportesUsuarios.Click += new System.EventHandler(this.btnReportesUsuarios_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(12, 9);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(78, 48);
            this.btnRegresar.TabIndex = 30;
            this.btnRegresar.Text = "←";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // MenuReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1086, 431);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnReportesUsuarios);
            this.Controls.Add(this.btnReporteLibros);
            this.Controls.Add(this.label8);
            this.Name = "MenuReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuReportes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnReporteLibros;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnReportesUsuarios;
        private System.Windows.Forms.Button btnRegresar;
    }
}