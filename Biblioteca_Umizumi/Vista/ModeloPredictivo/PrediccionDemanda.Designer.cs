namespace Biblioteca_Umizumi.Vista.ModeloPredictivo
{
    partial class PrediccionDemanda
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblSidebar = new System.Windows.Forms.Label();
            this.cbLibros = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnPredecir = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.chartPrediccion = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartPrediccion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSidebar
            // 
            this.lblSidebar.AutoSize = true;
            this.lblSidebar.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 24F);
            this.lblSidebar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSidebar.Location = new System.Drawing.Point(340, 34);
            this.lblSidebar.Name = "lblSidebar";
            this.lblSidebar.Size = new System.Drawing.Size(612, 47);
            this.lblSidebar.TabIndex = 1;
            this.lblSidebar.Text = "P R E D I C C I Ó N       D E      D E M A N D A";
            // 
            // cbLibros
            // 
            this.cbLibros.Font = new System.Drawing.Font("Malgun Gothic", 10.8F);
            this.cbLibros.FormattingEnabled = true;
            this.cbLibros.Location = new System.Drawing.Point(55, 221);
            this.cbLibros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbLibros.Name = "cbLibros";
            this.cbLibros.Size = new System.Drawing.Size(373, 33);
            this.cbLibros.TabIndex = 2;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Malgun Gothic", 10.8F);
            this.dtpFecha.Location = new System.Drawing.Point(55, 320);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(373, 31);
            this.dtpFecha.TabIndex = 3;
            // 
            // btnPredecir
            // 
            this.btnPredecir.BackColor = System.Drawing.Color.Gray;
            this.btnPredecir.FlatAppearance.BorderSize = 0;
            this.btnPredecir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPredecir.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnPredecir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPredecir.Location = new System.Drawing.Point(111, 388);
            this.btnPredecir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPredecir.Name = "btnPredecir";
            this.btnPredecir.Size = new System.Drawing.Size(237, 40);
            this.btnPredecir.TabIndex = 4;
            this.btnPredecir.Text = "Predecir";
            this.btnPredecir.UseVisualStyleBackColor = false;
            this.btnPredecir.Click += new System.EventHandler(this.btnPredecir_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 18F);
            this.lblResultado.Location = new System.Drawing.Point(892, 534);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(32, 38);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "0";
            // 
            // chartPrediccion
            // 
            chartArea1.Name = "ChartArea1";
            this.chartPrediccion.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartPrediccion.Legends.Add(legend1);
            this.chartPrediccion.Location = new System.Drawing.Point(451, 105);
            this.chartPrediccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartPrediccion.Name = "chartPrediccion";
            this.chartPrediccion.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartPrediccion.Series.Add(series1);
            this.chartPrediccion.Size = new System.Drawing.Size(842, 402);
            this.chartPrediccion.TabIndex = 6;
            this.chartPrediccion.Text = "Gráfico";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegresar.Location = new System.Drawing.Point(11, 7);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(68, 50);
            this.btnRegresar.TabIndex = 15;
            this.btnRegresar.Text = "←";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 18F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(289, 534);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(556, 38);
            this.label1.TabIndex = 16;
            this.label1.Text = "Cantidad de demanda estimada para esa fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 10.8F);
            this.label3.Location = new System.Drawing.Point(56, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Libro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 10.8F);
            this.label4.Location = new System.Drawing.Point(50, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Fecha";
            // 
            // PrediccionDemanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1318, 611);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.chartPrediccion);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnPredecir);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.cbLibros);
            this.Controls.Add(this.lblSidebar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PrediccionDemanda";
            this.Text = "PrediccionDemanda";
            this.Load += new System.EventHandler(this.PrediccionDemanda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartPrediccion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSidebar;
        private System.Windows.Forms.ComboBox cbLibros;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnPredecir;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPrediccion;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}