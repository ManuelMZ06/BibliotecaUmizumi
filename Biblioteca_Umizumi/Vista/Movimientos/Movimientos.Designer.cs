namespace Biblioteca_Umizumi.Vista.Movimientos
{
    partial class Movimientos
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
            this.dgvMovimientos = new System.Windows.Forms.DataGridView();
            this.lblSidebar = new System.Windows.Forms.Label();
            this.cbLibro = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTipoMovimiento = new System.Windows.Forms.ComboBox();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnPDF = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimientos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMovimientos
            // 
            this.dgvMovimientos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovimientos.Location = new System.Drawing.Point(538, 150);
            this.dgvMovimientos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMovimientos.Name = "dgvMovimientos";
            this.dgvMovimientos.RowHeadersWidth = 62;
            this.dgvMovimientos.RowTemplate.Height = 28;
            this.dgvMovimientos.Size = new System.Drawing.Size(848, 478);
            this.dgvMovimientos.TabIndex = 0;
            // 
            // lblSidebar
            // 
            this.lblSidebar.AutoSize = true;
            this.lblSidebar.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 24F);
            this.lblSidebar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSidebar.Location = new System.Drawing.Point(803, 62);
            this.lblSidebar.Name = "lblSidebar";
            this.lblSidebar.Size = new System.Drawing.Size(385, 61);
            this.lblSidebar.TabIndex = 1;
            this.lblSidebar.Text = "M O V I M I E N T O S";
            this.lblSidebar.Click += new System.EventHandler(this.lblSidebar_Click);
            // 
            // cbLibro
            // 
            this.cbLibro.Font = new System.Drawing.Font("Malgun Gothic", 10.8F);
            this.cbLibro.FormattingEnabled = true;
            this.cbLibro.Location = new System.Drawing.Point(216, 176);
            this.cbLibro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbLibro.Name = "cbLibro";
            this.cbLibro.Size = new System.Drawing.Size(280, 38);
            this.cbLibro.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 10.8F);
            this.label1.Location = new System.Drawing.Point(48, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 30);
            this.label1.TabIndex = 16;
            this.label1.Text = "Libro";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbTipoMovimiento
            // 
            this.cbTipoMovimiento.Font = new System.Drawing.Font("Malgun Gothic", 10.8F);
            this.cbTipoMovimiento.FormattingEnabled = true;
            this.cbTipoMovimiento.Location = new System.Drawing.Point(216, 238);
            this.cbTipoMovimiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTipoMovimiento.Name = "cbTipoMovimiento";
            this.cbTipoMovimiento.Size = new System.Drawing.Size(280, 38);
            this.cbTipoMovimiento.TabIndex = 17;
            // 
            // nudCantidad
            // 
            this.nudCantidad.Font = new System.Drawing.Font("Malgun Gothic", 10.8F);
            this.nudCantidad.Location = new System.Drawing.Point(216, 299);
            this.nudCantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudCantidad.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(120, 36);
            this.nudCantidad.TabIndex = 18;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObservaciones.Font = new System.Drawing.Font("Malgun Gothic", 10.8F);
            this.txtObservaciones.Location = new System.Drawing.Point(216, 362);
            this.txtObservaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(280, 192);
            this.txtObservaciones.TabIndex = 19;
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.Gray;
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnIngresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIngresar.Location = new System.Drawing.Point(223, 578);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(267, 50);
            this.btnIngresar.TabIndex = 20;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 10.8F);
            this.label2.Location = new System.Drawing.Point(42, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 30);
            this.label2.TabIndex = 21;
            this.label2.Text = "Movimiento";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 10.8F);
            this.label3.Location = new System.Drawing.Point(42, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 30);
            this.label3.TabIndex = 22;
            this.label3.Text = "Cantidad";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 10.8F);
            this.label4.Location = new System.Drawing.Point(48, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 30);
            this.label4.TabIndex = 23;
            this.label4.Text = "Observaciones";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(14, 14);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(78, 65);
            this.btnRegresar.TabIndex = 26;
            this.btnRegresar.Text = "←";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnPDF
            // 
            this.btnPDF.BackColor = System.Drawing.Color.Gray;
            this.btnPDF.FlatAppearance.BorderSize = 0;
            this.btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDF.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnPDF.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPDF.Location = new System.Drawing.Point(663, 652);
            this.btnPDF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(267, 50);
            this.btnPDF.TabIndex = 27;
            this.btnPDF.Text = "Exportar PDF";
            this.btnPDF.UseVisualStyleBackColor = false;
            this.btnPDF.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.Gray;
            this.btnExcel.FlatAppearance.BorderSize = 0;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnExcel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExcel.Location = new System.Drawing.Point(1019, 652);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(267, 50);
            this.btnExcel.TabIndex = 28;
            this.btnExcel.Text = "Exportar Excel";
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.button2_Click);
            // 
            // Movimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1449, 734);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.cbTipoMovimiento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbLibro);
            this.Controls.Add(this.lblSidebar);
            this.Controls.Add(this.dgvMovimientos);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Movimientos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimientos";
            this.Load += new System.EventHandler(this.Movimientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimientos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMovimientos;
        private System.Windows.Forms.Label lblSidebar;
        private System.Windows.Forms.ComboBox cbLibro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTipoMovimiento;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Button btnExcel;
    }
}