namespace Biblioteca_Umizumi.Vista.Reportes
{
    partial class ReportesLibros
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
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.txtPrecioCompraMax = new System.Windows.Forms.TextBox();
            this.txtPrecioCompraMin = new System.Windows.Forms.TextBox();
            this.txtPrecioVentaMax = new System.Windows.Forms.TextBox();
            this.txtPrecioVentaMin = new System.Windows.Forms.TextBox();
            this.chkStockBajo = new System.Windows.Forms.CheckBox();
            this.dgvReporteLibros = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPDF = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSidebar
            // 
            this.lblSidebar.AutoSize = true;
            this.lblSidebar.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSidebar.Location = new System.Drawing.Point(643, 30);
            this.lblSidebar.Name = "lblSidebar";
            this.lblSidebar.Size = new System.Drawing.Size(310, 42);
            this.lblSidebar.TabIndex = 1;
            this.lblSidebar.Text = "Reportes Sobre Libros";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(26, 122);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(187, 26);
            this.txtAutor.TabIndex = 2;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(26, 195);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(187, 26);
            this.txtCategoria.TabIndex = 3;
            // 
            // dtpInicio
            // 
            this.dtpInicio.Location = new System.Drawing.Point(26, 265);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.ShowCheckBox = true;
            this.dtpInicio.Size = new System.Drawing.Size(200, 26);
            this.dtpInicio.TabIndex = 4;
            this.dtpInicio.ValueChanged += new System.EventHandler(this.dtpInicio_ValueChanged);
            // 
            // dtpFin
            // 
            this.dtpFin.Location = new System.Drawing.Point(26, 316);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.ShowCheckBox = true;
            this.dtpFin.Size = new System.Drawing.Size(200, 26);
            this.dtpFin.TabIndex = 5;
            // 
            // txtPrecioCompraMax
            // 
            this.txtPrecioCompraMax.Location = new System.Drawing.Point(26, 467);
            this.txtPrecioCompraMax.Name = "txtPrecioCompraMax";
            this.txtPrecioCompraMax.Size = new System.Drawing.Size(187, 26);
            this.txtPrecioCompraMax.TabIndex = 7;
            this.txtPrecioCompraMax.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtPrecioCompraMin
            // 
            this.txtPrecioCompraMin.Location = new System.Drawing.Point(26, 399);
            this.txtPrecioCompraMin.Name = "txtPrecioCompraMin";
            this.txtPrecioCompraMin.Size = new System.Drawing.Size(187, 26);
            this.txtPrecioCompraMin.TabIndex = 6;
            // 
            // txtPrecioVentaMax
            // 
            this.txtPrecioVentaMax.Location = new System.Drawing.Point(26, 619);
            this.txtPrecioVentaMax.Name = "txtPrecioVentaMax";
            this.txtPrecioVentaMax.Size = new System.Drawing.Size(187, 26);
            this.txtPrecioVentaMax.TabIndex = 9;
            // 
            // txtPrecioVentaMin
            // 
            this.txtPrecioVentaMin.Location = new System.Drawing.Point(26, 540);
            this.txtPrecioVentaMin.Name = "txtPrecioVentaMin";
            this.txtPrecioVentaMin.Size = new System.Drawing.Size(187, 26);
            this.txtPrecioVentaMin.TabIndex = 8;
            // 
            // chkStockBajo
            // 
            this.chkStockBajo.AutoSize = true;
            this.chkStockBajo.Location = new System.Drawing.Point(26, 676);
            this.chkStockBajo.Name = "chkStockBajo";
            this.chkStockBajo.Size = new System.Drawing.Size(112, 24);
            this.chkStockBajo.TabIndex = 10;
            this.chkStockBajo.Text = "Stock Bajo";
            this.chkStockBajo.UseVisualStyleBackColor = true;
            // 
            // dgvReporteLibros
            // 
            this.dgvReporteLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporteLibros.Location = new System.Drawing.Point(296, 97);
            this.dgvReporteLibros.Name = "dgvReporteLibros";
            this.dgvReporteLibros.RowHeadersWidth = 62;
            this.dgvReporteLibros.RowTemplate.Height = 28;
            this.dgvReporteLibros.Size = new System.Drawing.Size(1012, 660);
            this.dgvReporteLibros.TabIndex = 11;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(12, 736);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(255, 35);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Filtros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Autor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Categoría";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Precio de Compra Mínimo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 512);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Precio de Venta Mínimo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 439);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "Precio de CompraMáximo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 591);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "Precio de Venta Máximo";
            // 
            // btnPDF
            // 
            this.btnPDF.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPDF.FlatAppearance.BorderSize = 0;
            this.btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDF.Location = new System.Drawing.Point(1368, 329);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(171, 44);
            this.btnPDF.TabIndex = 21;
            this.btnPDF.Text = "Importar a PDF";
            this.btnPDF.UseVisualStyleBackColor = false;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExcel.FlatAppearance.BorderSize = 0;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Location = new System.Drawing.Point(1368, 390);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(171, 44);
            this.btnExcel.TabIndex = 22;
            this.btnExcel.Text = "Importar a Excel";
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(1420, 694);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(78, 63);
            this.btnRegresar.TabIndex = 26;
            this.btnRegresar.Text = "←";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // ReportesLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1585, 798);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvReporteLibros);
            this.Controls.Add(this.chkStockBajo);
            this.Controls.Add(this.txtPrecioVentaMax);
            this.Controls.Add(this.txtPrecioVentaMin);
            this.Controls.Add(this.txtPrecioCompraMax);
            this.Controls.Add(this.txtPrecioCompraMin);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.lblSidebar);
            this.Name = "ReportesLibros";
            this.Text = "ReportesLibros";
            this.Load += new System.EventHandler(this.ReportesLibros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteLibros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSidebar;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.TextBox txtPrecioCompraMax;
        private System.Windows.Forms.TextBox txtPrecioCompraMin;
        private System.Windows.Forms.TextBox txtPrecioVentaMax;
        private System.Windows.Forms.TextBox txtPrecioVentaMin;
        private System.Windows.Forms.CheckBox chkStockBajo;
        private System.Windows.Forms.DataGridView dgvReporteLibros;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnRegresar;
    }
}