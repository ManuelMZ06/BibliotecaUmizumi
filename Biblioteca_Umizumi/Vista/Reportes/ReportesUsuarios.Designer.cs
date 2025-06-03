namespace Biblioteca_Umizumi.Vista.Reportes
{
    partial class ReportesUsuarios
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
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnPDF = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.txtRol = new System.Windows.Forms.TextBox();
            this.lblSidebar = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(12, 11);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(69, 50);
            this.btnRegresar.TabIndex = 38;
            this.btnRegresar.Text = "←";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.Gray;
            this.btnExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcel.FlatAppearance.BorderSize = 0;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnExcel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExcel.Location = new System.Drawing.Point(994, 582);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(237, 40);
            this.btnExcel.TabIndex = 37;
            this.btnExcel.Text = "Importar a Excel";
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnPDF
            // 
            this.btnPDF.BackColor = System.Drawing.Color.Gray;
            this.btnPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPDF.FlatAppearance.BorderSize = 0;
            this.btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDF.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnPDF.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPDF.Location = new System.Drawing.Point(646, 582);
            this.btnPDF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(237, 40);
            this.btnPDF.TabIndex = 36;
            this.btnPDF.Text = "Importar a PDF";
            this.btnPDF.UseVisualStyleBackColor = false;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 10.8F);
            this.label3.Location = new System.Drawing.Point(29, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 25);
            this.label3.TabIndex = 35;
            this.label3.Text = "Estado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 10.8F);
            this.label2.Location = new System.Drawing.Point(29, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 25);
            this.label2.TabIndex = 34;
            this.label2.Text = "Rol";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(458, 85);
            this.dgvUsuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowHeadersWidth = 62;
            this.dgvUsuarios.RowTemplate.Height = 28;
            this.dgvUsuarios.Size = new System.Drawing.Size(900, 468);
            this.dgvUsuarios.TabIndex = 32;
            // 
            // dtpFin
            // 
            this.dtpFin.Font = new System.Drawing.Font("Malgun Gothic", 10.8F);
            this.dtpFin.Location = new System.Drawing.Point(34, 378);
            this.dtpFin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.ShowCheckBox = true;
            this.dtpFin.Size = new System.Drawing.Size(389, 31);
            this.dtpFin.TabIndex = 31;
            // 
            // dtpInicio
            // 
            this.dtpInicio.Font = new System.Drawing.Font("Malgun Gothic", 10.8F);
            this.dtpInicio.Location = new System.Drawing.Point(34, 337);
            this.dtpInicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.ShowCheckBox = true;
            this.dtpInicio.Size = new System.Drawing.Size(389, 31);
            this.dtpInicio.TabIndex = 30;
            // 
            // txtRol
            // 
            this.txtRol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRol.Font = new System.Drawing.Font("Malgun Gothic", 10.8F);
            this.txtRol.Location = new System.Drawing.Point(34, 211);
            this.txtRol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRol.Name = "txtRol";
            this.txtRol.Size = new System.Drawing.Size(389, 31);
            this.txtRol.TabIndex = 28;
            // 
            // lblSidebar
            // 
            this.lblSidebar.AutoSize = true;
            this.lblSidebar.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 24F);
            this.lblSidebar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSidebar.Location = new System.Drawing.Point(686, 23);
            this.lblSidebar.Name = "lblSidebar";
            this.lblSidebar.Size = new System.Drawing.Size(460, 47);
            this.lblSidebar.TabIndex = 27;
            this.lblSidebar.Text = "REPORTES SOBRE USUARIOS";
            // 
            // cbEstado
            // 
            this.cbEstado.Font = new System.Drawing.Font("Malgun Gothic", 10.8F);
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Todos",
            "Activo",
            "Inactivo"});
            this.cbEstado.Location = new System.Drawing.Point(34, 289);
            this.cbEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(389, 33);
            this.cbEstado.TabIndex = 39;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Gray;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscar.Location = new System.Drawing.Point(137, 454);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(178, 40);
            this.btnBuscar.TabIndex = 40;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 18F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(168, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 38);
            this.label4.TabIndex = 41;
            this.label4.Text = "FILTROS";
            // 
            // ReportesUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1391, 648);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.txtRol);
            this.Controls.Add(this.lblSidebar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ReportesUsuarios";
            this.Text = "ReportesUsuarios";
            this.Load += new System.EventHandler(this.ReportesUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.TextBox txtRol;
        private System.Windows.Forms.Label lblSidebar;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label4;
    }
}