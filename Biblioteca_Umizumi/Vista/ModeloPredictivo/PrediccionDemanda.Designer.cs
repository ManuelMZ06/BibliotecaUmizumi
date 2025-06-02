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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblSidebar = new System.Windows.Forms.Label();
            this.cbLibros = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnPredecir = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.chartPrediccion = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartPrediccion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSidebar
            // 
            this.lblSidebar.AutoSize = true;
            this.lblSidebar.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSidebar.Location = new System.Drawing.Point(380, 9);
            this.lblSidebar.Name = "lblSidebar";
            this.lblSidebar.Size = new System.Drawing.Size(335, 42);
            this.lblSidebar.TabIndex = 1;
            this.lblSidebar.Text = "Predicción de Demanda";
            // 
            // cbLibros
            // 
            this.cbLibros.FormattingEnabled = true;
            this.cbLibros.Location = new System.Drawing.Point(12, 130);
            this.cbLibros.Name = "cbLibros";
            this.cbLibros.Size = new System.Drawing.Size(296, 28);
            this.cbLibros.TabIndex = 2;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(12, 180);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(296, 26);
            this.dtpFecha.TabIndex = 3;
            // 
            // btnPredecir
            // 
            this.btnPredecir.FlatAppearance.BorderSize = 0;
            this.btnPredecir.Location = new System.Drawing.Point(12, 237);
            this.btnPredecir.Name = "btnPredecir";
            this.btnPredecir.Size = new System.Drawing.Size(275, 43);
            this.btnPredecir.TabIndex = 4;
            this.btnPredecir.Text = "Predecir";
            this.btnPredecir.UseVisualStyleBackColor = true;
            this.btnPredecir.Click += new System.EventHandler(this.btnPredecir_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(154, 448);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(36, 37);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "0";
            // 
            // chartPrediccion
            // 
            chartArea3.Name = "ChartArea1";
            this.chartPrediccion.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartPrediccion.Legends.Add(legend3);
            this.chartPrediccion.Location = new System.Drawing.Point(413, 85);
            this.chartPrediccion.Name = "chartPrediccion";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartPrediccion.Series.Add(series3);
            this.chartPrediccion.Size = new System.Drawing.Size(1016, 502);
            this.chartPrediccion.TabIndex = 6;
            this.chartPrediccion.Text = "Gráfico";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegresar.Location = new System.Drawing.Point(12, 9);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(76, 63);
            this.btnRegresar.TabIndex = 15;
            this.btnRegresar.Text = "←";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 42);
            this.label1.TabIndex = 16;
            this.label1.Text = "Cantidad de demanda ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(354, 42);
            this.label2.TabIndex = 17;
            this.label2.Text = "estimada para esa fecha:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // PrediccionDemanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1483, 775);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.chartPrediccion);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnPredecir);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.cbLibros);
            this.Controls.Add(this.lblSidebar);
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
        private System.Windows.Forms.Label label2;
    }
}