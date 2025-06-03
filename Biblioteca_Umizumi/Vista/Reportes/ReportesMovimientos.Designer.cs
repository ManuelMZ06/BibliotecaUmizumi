namespace Biblioteca_Umizumi.Vista.Reportes
{
    partial class ReportesMovimientos
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvReporteLibros = new System.Windows.Forms.DataGridView();
            this.lblSidebar = new System.Windows.Forms.Label();
            this.cbAnio = new System.Windows.Forms.ComboBox();
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.cbTrimestre = new System.Windows.Forms.ComboBox();
            this.cbTipoMovimiento = new System.Windows.Forms.ComboBox();
            this.cbLibro = new System.Windows.Forms.ComboBox();
            this.btnLimpiarFiltros = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(12, 11);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(69, 50);
            this.btnRegresar.TabIndex = 37;
            this.btnRegresar.Text = "←";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.Gray;
            this.btnExcel.FlatAppearance.BorderSize = 0;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnExcel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExcel.Location = new System.Drawing.Point(987, 578);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(237, 40);
            this.btnExcel.TabIndex = 36;
            this.btnExcel.Text = "Importar a Excel";
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnPDF
            // 
            this.btnPDF.BackColor = System.Drawing.Color.Gray;
            this.btnPDF.FlatAppearance.BorderSize = 0;
            this.btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDF.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnPDF.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPDF.Location = new System.Drawing.Point(639, 578);
            this.btnPDF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(237, 40);
            this.btnPDF.TabIndex = 35;
            this.btnPDF.Text = "Importar a PDF";
            this.btnPDF.UseVisualStyleBackColor = false;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 18F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(109, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 38);
            this.label1.TabIndex = 34;
            this.label1.Text = "FILTROS";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Gray;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscar.Location = new System.Drawing.Point(83, 563);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(178, 40);
            this.btnBuscar.TabIndex = 33;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvReporteLibros
            // 
            this.dgvReporteLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporteLibros.Location = new System.Drawing.Point(324, 85);
            this.dgvReporteLibros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvReporteLibros.Name = "dgvReporteLibros";
            this.dgvReporteLibros.RowHeadersWidth = 62;
            this.dgvReporteLibros.RowTemplate.Height = 28;
            this.dgvReporteLibros.Size = new System.Drawing.Size(900, 468);
            this.dgvReporteLibros.TabIndex = 32;
            // 
            // lblSidebar
            // 
            this.lblSidebar.AutoSize = true;
            this.lblSidebar.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 24F);
            this.lblSidebar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSidebar.Location = new System.Drawing.Point(506, 18);
            this.lblSidebar.Name = "lblSidebar";
            this.lblSidebar.Size = new System.Drawing.Size(520, 47);
            this.lblSidebar.TabIndex = 27;
            this.lblSidebar.Text = "REPORTES SOBRE MOVIMIENTOS";
            // 
            // cbAnio
            // 
            this.cbAnio.Font = new System.Drawing.Font("Malgun Gothic", 10.8F);
            this.cbAnio.FormattingEnabled = true;
            this.cbAnio.Location = new System.Drawing.Point(76, 154);
            this.cbAnio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbAnio.Name = "cbAnio";
            this.cbAnio.Size = new System.Drawing.Size(197, 33);
            this.cbAnio.TabIndex = 38;
            // 
            // cbMes
            // 
            this.cbMes.Font = new System.Drawing.Font("Malgun Gothic", 10.8F);
            this.cbMes.FormattingEnabled = true;
            this.cbMes.Location = new System.Drawing.Point(76, 226);
            this.cbMes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(197, 33);
            this.cbMes.TabIndex = 39;
            // 
            // cbTrimestre
            // 
            this.cbTrimestre.Font = new System.Drawing.Font("Malgun Gothic", 10.8F);
            this.cbTrimestre.FormattingEnabled = true;
            this.cbTrimestre.Location = new System.Drawing.Point(76, 300);
            this.cbTrimestre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTrimestre.Name = "cbTrimestre";
            this.cbTrimestre.Size = new System.Drawing.Size(197, 33);
            this.cbTrimestre.TabIndex = 40;
            // 
            // cbTipoMovimiento
            // 
            this.cbTipoMovimiento.Font = new System.Drawing.Font("Malgun Gothic", 10.8F);
            this.cbTipoMovimiento.FormattingEnabled = true;
            this.cbTipoMovimiento.Location = new System.Drawing.Point(76, 376);
            this.cbTipoMovimiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTipoMovimiento.Name = "cbTipoMovimiento";
            this.cbTipoMovimiento.Size = new System.Drawing.Size(197, 33);
            this.cbTipoMovimiento.TabIndex = 41;
            // 
            // cbLibro
            // 
            this.cbLibro.Font = new System.Drawing.Font("Malgun Gothic", 10.8F);
            this.cbLibro.FormattingEnabled = true;
            this.cbLibro.Location = new System.Drawing.Point(76, 454);
            this.cbLibro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbLibro.Name = "cbLibro";
            this.cbLibro.Size = new System.Drawing.Size(197, 33);
            this.cbLibro.TabIndex = 42;
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.BackColor = System.Drawing.Color.Gray;
            this.btnLimpiarFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarFiltros.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnLimpiarFiltros.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(83, 507);
            this.btnLimpiarFiltros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(178, 40);
            this.btnLimpiarFiltros.TabIndex = 44;
            this.btnLimpiarFiltros.Text = "Limpiar Filtros";
            this.btnLimpiarFiltros.UseVisualStyleBackColor = false;
            this.btnLimpiarFiltros.Click += new System.EventHandler(this.btnLimpiarFiltros_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 10.8F);
            this.label2.Location = new System.Drawing.Point(71, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 25);
            this.label2.TabIndex = 45;
            this.label2.Text = "Año";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 10.8F);
            this.label3.Location = new System.Drawing.Point(71, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 25);
            this.label3.TabIndex = 46;
            this.label3.Text = "Mes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 10.8F);
            this.label4.Location = new System.Drawing.Point(71, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 25);
            this.label4.TabIndex = 47;
            this.label4.Text = "Trimestre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Malgun Gothic", 10.8F);
            this.label5.Location = new System.Drawing.Point(71, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 25);
            this.label5.TabIndex = 48;
            this.label5.Text = "Tipo de Movimiento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Malgun Gothic", 10.8F);
            this.label6.Location = new System.Drawing.Point(71, 422);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 25);
            this.label6.TabIndex = 49;
            this.label6.Text = "Libro";
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Gray;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnActualizar.Location = new System.Drawing.Point(324, 578);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(178, 40);
            this.btnActualizar.TabIndex = 50;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // ReportesMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1308, 648);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLimpiarFiltros);
            this.Controls.Add(this.cbLibro);
            this.Controls.Add(this.cbTipoMovimiento);
            this.Controls.Add(this.cbTrimestre);
            this.Controls.Add(this.cbMes);
            this.Controls.Add(this.cbAnio);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvReporteLibros);
            this.Controls.Add(this.lblSidebar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ReportesMovimientos";
            this.Text = "ReportesMovimientos";
            this.Load += new System.EventHandler(this.ReportesMovimientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteLibros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvReporteLibros;
        private System.Windows.Forms.Label lblSidebar;
        private System.Windows.Forms.ComboBox cbAnio;
        private System.Windows.Forms.ComboBox cbMes;
        private System.Windows.Forms.ComboBox cbTrimestre;
        private System.Windows.Forms.ComboBox cbTipoMovimiento;
        private System.Windows.Forms.ComboBox cbLibro;
        private System.Windows.Forms.Button btnLimpiarFiltros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnActualizar;
    }
}