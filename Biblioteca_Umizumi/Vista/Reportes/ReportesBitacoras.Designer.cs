namespace Biblioteca_Umizumi.Vista.Reportes
{
    partial class ReportesBitacoras
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
            this.tbBitacoras = new System.Windows.Forms.TabControl();
            this.tbSesiones = new System.Windows.Forms.TabPage();
            this.chkSoloAbiertas = new System.Windows.Forms.CheckBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnPDF = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvSesiones = new System.Windows.Forms.DataGridView();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblSidebar = new System.Windows.Forms.Label();
            this.tbAcciones = new System.Windows.Forms.TabPage();
            this.btnRegresar2 = new System.Windows.Forms.Button();
            this.btnExcelAcciones = new System.Windows.Forms.Button();
            this.btnPdfAcciones = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAccion = new System.Windows.Forms.TextBox();
            this.txtTabla = new System.Windows.Forms.TextBox();
            this.btnBuscarAcciones = new System.Windows.Forms.Button();
            this.dgvAcciones = new System.Windows.Forms.DataGridView();
            this.dtpFinAccion = new System.Windows.Forms.DateTimePicker();
            this.dtpInicioAccion = new System.Windows.Forms.DateTimePicker();
            this.txtUsuarioAccion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbBitacoras.SuspendLayout();
            this.tbSesiones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSesiones)).BeginInit();
            this.tbAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcciones)).BeginInit();
            this.SuspendLayout();
            // 
            // tbBitacoras
            // 
            this.tbBitacoras.Controls.Add(this.tbSesiones);
            this.tbBitacoras.Controls.Add(this.tbAcciones);
            this.tbBitacoras.Location = new System.Drawing.Point(1, 1);
            this.tbBitacoras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbBitacoras.Name = "tbBitacoras";
            this.tbBitacoras.SelectedIndex = 0;
            this.tbBitacoras.Size = new System.Drawing.Size(1313, 626);
            this.tbBitacoras.TabIndex = 64;
            // 
            // tbSesiones
            // 
            this.tbSesiones.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbSesiones.Controls.Add(this.label1);
            this.tbSesiones.Controls.Add(this.chkSoloAbiertas);
            this.tbSesiones.Controls.Add(this.btnBuscar);
            this.tbSesiones.Controls.Add(this.btnRegresar);
            this.tbSesiones.Controls.Add(this.btnExcel);
            this.tbSesiones.Controls.Add(this.btnPDF);
            this.tbSesiones.Controls.Add(this.label2);
            this.tbSesiones.Controls.Add(this.dgvSesiones);
            this.tbSesiones.Controls.Add(this.dtpFin);
            this.tbSesiones.Controls.Add(this.dtpInicio);
            this.tbSesiones.Controls.Add(this.txtUsuario);
            this.tbSesiones.Controls.Add(this.lblSidebar);
            this.tbSesiones.Location = new System.Drawing.Point(4, 25);
            this.tbSesiones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSesiones.Name = "tbSesiones";
            this.tbSesiones.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSesiones.Size = new System.Drawing.Size(1305, 597);
            this.tbSesiones.TabIndex = 0;
            this.tbSesiones.Text = "Bitácora de Sesiones";
            // 
            // chkSoloAbiertas
            // 
            this.chkSoloAbiertas.AutoSize = true;
            this.chkSoloAbiertas.Font = new System.Drawing.Font("Malgun Gothic", 10.8F);
            this.chkSoloAbiertas.Location = new System.Drawing.Point(33, 367);
            this.chkSoloAbiertas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkSoloAbiertas.Name = "chkSoloAbiertas";
            this.chkSoloAbiertas.Size = new System.Drawing.Size(177, 29);
            this.chkSoloAbiertas.TabIndex = 64;
            this.chkSoloAbiertas.Text = "Sesiones Abiertas";
            this.chkSoloAbiertas.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Gray;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscar.Location = new System.Drawing.Point(119, 421);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(178, 40);
            this.btnBuscar.TabIndex = 63;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(13, 12);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(69, 50);
            this.btnRegresar.TabIndex = 62;
            this.btnRegresar.Text = "←";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click_1);
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.Gray;
            this.btnExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcel.FlatAppearance.BorderSize = 0;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnExcel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExcel.Location = new System.Drawing.Point(922, 526);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(237, 40);
            this.btnExcel.TabIndex = 61;
            this.btnExcel.Text = "Importar a Excel";
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click_1);
            // 
            // btnPDF
            // 
            this.btnPDF.BackColor = System.Drawing.Color.Gray;
            this.btnPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPDF.FlatAppearance.BorderSize = 0;
            this.btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDF.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnPDF.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPDF.Location = new System.Drawing.Point(577, 526);
            this.btnPDF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(237, 40);
            this.btnPDF.TabIndex = 60;
            this.btnPDF.Text = "Importar a PDF";
            this.btnPDF.UseVisualStyleBackColor = false;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 10.8F);
            this.label2.Location = new System.Drawing.Point(28, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 59;
            this.label2.Text = "Usuario";
            // 
            // dgvSesiones
            // 
            this.dgvSesiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSesiones.Location = new System.Drawing.Point(451, 101);
            this.dgvSesiones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSesiones.Name = "dgvSesiones";
            this.dgvSesiones.RowHeadersWidth = 62;
            this.dgvSesiones.RowTemplate.Height = 28;
            this.dgvSesiones.Size = new System.Drawing.Size(797, 399);
            this.dgvSesiones.TabIndex = 57;
            this.dgvSesiones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSesiones_CellContentClick_1);
            // 
            // dtpFin
            // 
            this.dtpFin.Font = new System.Drawing.Font("Malgun Gothic", 10.8F);
            this.dtpFin.Location = new System.Drawing.Point(33, 311);
            this.dtpFin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.ShowCheckBox = true;
            this.dtpFin.Size = new System.Drawing.Size(385, 31);
            this.dtpFin.TabIndex = 56;
            // 
            // dtpInicio
            // 
            this.dtpInicio.Font = new System.Drawing.Font("Malgun Gothic", 10.8F);
            this.dtpInicio.Location = new System.Drawing.Point(33, 250);
            this.dtpInicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.ShowCheckBox = true;
            this.dtpInicio.Size = new System.Drawing.Size(385, 31);
            this.dtpInicio.TabIndex = 55;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Font = new System.Drawing.Font("Malgun Gothic", 10.8F);
            this.txtUsuario.Location = new System.Drawing.Point(33, 194);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(385, 31);
            this.txtUsuario.TabIndex = 54;
            // 
            // lblSidebar
            // 
            this.lblSidebar.AutoSize = true;
            this.lblSidebar.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 24F);
            this.lblSidebar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSidebar.Location = new System.Drawing.Point(645, 38);
            this.lblSidebar.Name = "lblSidebar";
            this.lblSidebar.Size = new System.Drawing.Size(452, 47);
            this.lblSidebar.TabIndex = 53;
            this.lblSidebar.Text = "REPORTES SOBRE SESIONES";
            // 
            // tbAcciones
            // 
            this.tbAcciones.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbAcciones.Controls.Add(this.label7);
            this.tbAcciones.Controls.Add(this.btnRegresar2);
            this.tbAcciones.Controls.Add(this.btnExcelAcciones);
            this.tbAcciones.Controls.Add(this.btnPdfAcciones);
            this.tbAcciones.Controls.Add(this.label3);
            this.tbAcciones.Controls.Add(this.label6);
            this.tbAcciones.Controls.Add(this.label5);
            this.tbAcciones.Controls.Add(this.label4);
            this.tbAcciones.Controls.Add(this.txtAccion);
            this.tbAcciones.Controls.Add(this.txtTabla);
            this.tbAcciones.Controls.Add(this.btnBuscarAcciones);
            this.tbAcciones.Controls.Add(this.dgvAcciones);
            this.tbAcciones.Controls.Add(this.dtpFinAccion);
            this.tbAcciones.Controls.Add(this.dtpInicioAccion);
            this.tbAcciones.Controls.Add(this.txtUsuarioAccion);
            this.tbAcciones.Location = new System.Drawing.Point(4, 25);
            this.tbAcciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAcciones.Name = "tbAcciones";
            this.tbAcciones.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAcciones.Size = new System.Drawing.Size(1305, 597);
            this.tbAcciones.TabIndex = 1;
            this.tbAcciones.Text = "Bitácora de Acciones";
            this.tbAcciones.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btnRegresar2
            // 
            this.btnRegresar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar2.Location = new System.Drawing.Point(13, 12);
            this.btnRegresar2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegresar2.Name = "btnRegresar2";
            this.btnRegresar2.Size = new System.Drawing.Size(69, 50);
            this.btnRegresar2.TabIndex = 77;
            this.btnRegresar2.Text = "←";
            this.btnRegresar2.UseVisualStyleBackColor = true;
            this.btnRegresar2.Click += new System.EventHandler(this.btnRegresar2_Click);
            // 
            // btnExcelAcciones
            // 
            this.btnExcelAcciones.BackColor = System.Drawing.Color.Gray;
            this.btnExcelAcciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcelAcciones.FlatAppearance.BorderSize = 0;
            this.btnExcelAcciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcelAcciones.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnExcelAcciones.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnExcelAcciones.Location = new System.Drawing.Point(922, 526);
            this.btnExcelAcciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExcelAcciones.Name = "btnExcelAcciones";
            this.btnExcelAcciones.Size = new System.Drawing.Size(237, 40);
            this.btnExcelAcciones.TabIndex = 76;
            this.btnExcelAcciones.Text = "Importar a Excel";
            this.btnExcelAcciones.UseVisualStyleBackColor = false;
            this.btnExcelAcciones.Click += new System.EventHandler(this.btnExcelAcciones_Click);
            // 
            // btnPdfAcciones
            // 
            this.btnPdfAcciones.BackColor = System.Drawing.Color.Gray;
            this.btnPdfAcciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPdfAcciones.FlatAppearance.BorderSize = 0;
            this.btnPdfAcciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPdfAcciones.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnPdfAcciones.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnPdfAcciones.Location = new System.Drawing.Point(577, 526);
            this.btnPdfAcciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPdfAcciones.Name = "btnPdfAcciones";
            this.btnPdfAcciones.Size = new System.Drawing.Size(237, 40);
            this.btnPdfAcciones.TabIndex = 75;
            this.btnPdfAcciones.Text = "Importar a PDF";
            this.btnPdfAcciones.UseVisualStyleBackColor = false;
            this.btnPdfAcciones.Click += new System.EventHandler(this.btnPdfAcciones_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 24F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(619, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(457, 47);
            this.label3.TabIndex = 74;
            this.label3.Text = "REPORTES SOBRE ACCIONES";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Malgun Gothic", 10.8F);
            this.label6.Location = new System.Drawing.Point(35, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 25);
            this.label6.TabIndex = 73;
            this.label6.Text = "Tabla";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Malgun Gothic", 10.8F);
            this.label5.Location = new System.Drawing.Point(35, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 25);
            this.label5.TabIndex = 72;
            this.label5.Text = "Acción";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 10.8F);
            this.label4.Location = new System.Drawing.Point(35, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 25);
            this.label4.TabIndex = 71;
            this.label4.Text = "Usuario";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtAccion
            // 
            this.txtAccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccion.Font = new System.Drawing.Font("Malgun Gothic", 10.8F);
            this.txtAccion.Location = new System.Drawing.Point(40, 247);
            this.txtAccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAccion.Name = "txtAccion";
            this.txtAccion.Size = new System.Drawing.Size(381, 31);
            this.txtAccion.TabIndex = 70;
            // 
            // txtTabla
            // 
            this.txtTabla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTabla.Font = new System.Drawing.Font("Malgun Gothic", 10.8F);
            this.txtTabla.Location = new System.Drawing.Point(40, 316);
            this.txtTabla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTabla.Name = "txtTabla";
            this.txtTabla.Size = new System.Drawing.Size(381, 31);
            this.txtTabla.TabIndex = 69;
            // 
            // btnBuscarAcciones
            // 
            this.btnBuscarAcciones.BackColor = System.Drawing.Color.Gray;
            this.btnBuscarAcciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarAcciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarAcciones.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnBuscarAcciones.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBuscarAcciones.Location = new System.Drawing.Point(128, 464);
            this.btnBuscarAcciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarAcciones.Name = "btnBuscarAcciones";
            this.btnBuscarAcciones.Size = new System.Drawing.Size(178, 40);
            this.btnBuscarAcciones.TabIndex = 68;
            this.btnBuscarAcciones.Text = "Buscar";
            this.btnBuscarAcciones.UseVisualStyleBackColor = false;
            this.btnBuscarAcciones.Click += new System.EventHandler(this.btnBuscarAcciones_Click);
            // 
            // dgvAcciones
            // 
            this.dgvAcciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAcciones.Location = new System.Drawing.Point(451, 101);
            this.dgvAcciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAcciones.Name = "dgvAcciones";
            this.dgvAcciones.RowHeadersWidth = 62;
            this.dgvAcciones.RowTemplate.Height = 28;
            this.dgvAcciones.Size = new System.Drawing.Size(797, 399);
            this.dgvAcciones.TabIndex = 67;
            // 
            // dtpFinAccion
            // 
            this.dtpFinAccion.Font = new System.Drawing.Font("Malgun Gothic", 10.8F);
            this.dtpFinAccion.Location = new System.Drawing.Point(40, 413);
            this.dtpFinAccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFinAccion.Name = "dtpFinAccion";
            this.dtpFinAccion.ShowCheckBox = true;
            this.dtpFinAccion.Size = new System.Drawing.Size(381, 31);
            this.dtpFinAccion.TabIndex = 66;
            // 
            // dtpInicioAccion
            // 
            this.dtpInicioAccion.Font = new System.Drawing.Font("Malgun Gothic", 10.8F);
            this.dtpInicioAccion.Location = new System.Drawing.Point(40, 365);
            this.dtpInicioAccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpInicioAccion.Name = "dtpInicioAccion";
            this.dtpInicioAccion.ShowCheckBox = true;
            this.dtpInicioAccion.Size = new System.Drawing.Size(381, 31);
            this.dtpInicioAccion.TabIndex = 65;
            // 
            // txtUsuarioAccion
            // 
            this.txtUsuarioAccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuarioAccion.Font = new System.Drawing.Font("Malgun Gothic", 10.8F);
            this.txtUsuarioAccion.Location = new System.Drawing.Point(40, 173);
            this.txtUsuarioAccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsuarioAccion.Name = "txtUsuarioAccion";
            this.txtUsuarioAccion.Size = new System.Drawing.Size(381, 31);
            this.txtUsuarioAccion.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 18F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(157, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 38);
            this.label1.TabIndex = 65;
            this.label1.Text = "FILTROS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 18F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(164, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 38);
            this.label7.TabIndex = 78;
            this.label7.Text = "FILTROS";
            // 
            // ReportesBitacoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1312, 625);
            this.Controls.Add(this.tbBitacoras);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ReportesBitacoras";
            this.Text = "ReportesBitacoras";
            this.Load += new System.EventHandler(this.ReportesBitacoras_Load);
            this.tbBitacoras.ResumeLayout(false);
            this.tbSesiones.ResumeLayout(false);
            this.tbSesiones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSesiones)).EndInit();
            this.tbAcciones.ResumeLayout(false);
            this.tbAcciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tbBitacoras;
        private System.Windows.Forms.TabPage tbSesiones;
        private System.Windows.Forms.TabPage tbAcciones;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAccion;
        private System.Windows.Forms.TextBox txtTabla;
        private System.Windows.Forms.Button btnBuscarAcciones;
        private System.Windows.Forms.DataGridView dgvAcciones;
        private System.Windows.Forms.DateTimePicker dtpFinAccion;
        private System.Windows.Forms.DateTimePicker dtpInicioAccion;
        private System.Windows.Forms.TextBox txtUsuarioAccion;
        private System.Windows.Forms.CheckBox chkSoloAbiertas;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvSesiones;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblSidebar;
        private System.Windows.Forms.Button btnRegresar2;
        private System.Windows.Forms.Button btnExcelAcciones;
        private System.Windows.Forms.Button btnPdfAcciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
    }
}