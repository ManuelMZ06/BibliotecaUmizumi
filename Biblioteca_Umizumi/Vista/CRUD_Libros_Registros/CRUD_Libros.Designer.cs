namespace Biblioteca_Umizumi.Vista.CRUD_Libros_Registros
{
    partial class CRUD_Libros
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvLibros = new System.Windows.Forms.DataGridView();
            this.btnAgregarLibro = new System.Windows.Forms.Button();
            this.btnActualizarLibro = new System.Windows.Forms.Button();
            this.lblDatos = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbAutor = new System.Windows.Forms.ComboBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnAutorCategoria = new System.Windows.Forms.Button();
            this.nudStock = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.cbProveedor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 24F);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitulo.Location = new System.Drawing.Point(647, 30);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(470, 61);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "REGISTROS INVENTARIO";
            // 
            // dgvLibros
            // 
            this.dgvLibros.AllowUserToAddRows = false;
            this.dgvLibros.AllowUserToDeleteRows = false;
            this.dgvLibros.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibros.Location = new System.Drawing.Point(841, 240);
            this.dgvLibros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvLibros.Name = "dgvLibros";
            this.dgvLibros.RowHeadersWidth = 62;
            this.dgvLibros.RowTemplate.Height = 28;
            this.dgvLibros.Size = new System.Drawing.Size(824, 512);
            this.dgvLibros.TabIndex = 1;
            // 
            // btnAgregarLibro
            // 
            this.btnAgregarLibro.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAgregarLibro.FlatAppearance.BorderSize = 0;
            this.btnAgregarLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarLibro.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnAgregarLibro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregarLibro.Location = new System.Drawing.Point(1284, 171);
            this.btnAgregarLibro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarLibro.Name = "btnAgregarLibro";
            this.btnAgregarLibro.Size = new System.Drawing.Size(160, 50);
            this.btnAgregarLibro.TabIndex = 3;
            this.btnAgregarLibro.Text = "Agregar";
            this.btnAgregarLibro.UseVisualStyleBackColor = false;
            this.btnAgregarLibro.Click += new System.EventHandler(this.btnAgregarLibro_Click);
            // 
            // btnActualizarLibro
            // 
            this.btnActualizarLibro.BackColor = System.Drawing.Color.Gold;
            this.btnActualizarLibro.FlatAppearance.BorderSize = 0;
            this.btnActualizarLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarLibro.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnActualizarLibro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnActualizarLibro.Location = new System.Drawing.Point(1078, 171);
            this.btnActualizarLibro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActualizarLibro.Name = "btnActualizarLibro";
            this.btnActualizarLibro.Size = new System.Drawing.Size(160, 50);
            this.btnActualizarLibro.TabIndex = 4;
            this.btnActualizarLibro.Text = "Actualizar";
            this.btnActualizarLibro.UseVisualStyleBackColor = false;
            this.btnActualizarLibro.Click += new System.EventHandler(this.btnActualizarLibro_Click);
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 18F);
            this.lblDatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDatos.Location = new System.Drawing.Point(238, 106);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(378, 42);
            this.lblDatos.TabIndex = 5;
            this.lblDatos.Text = "I N G R E S A R       D A T O S";
            this.lblDatos.Click += new System.EventHandler(this.lblDatos_Click);
            // 
            // txtTitulo
            // 
            this.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitulo.Font = new System.Drawing.Font("Malgun Gothic", 10.8F);
            this.txtTitulo.Location = new System.Drawing.Point(237, 188);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(562, 36);
            this.txtTitulo.TabIndex = 6;
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecioCompra.Font = new System.Drawing.Font("Malgun Gothic", 10.8F);
            this.txtPrecioCompra.Location = new System.Drawing.Point(237, 449);
            this.txtPrecioCompra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(562, 36);
            this.txtPrecioCompra.TabIndex = 10;
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecioVenta.Font = new System.Drawing.Font("Malgun Gothic", 10.8F);
            this.txtPrecioVenta.Location = new System.Drawing.Point(237, 508);
            this.txtPrecioVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(562, 36);
            this.txtPrecioVenta.TabIndex = 11;
            // 
            // cbEstado
            // 
            this.cbEstado.Font = new System.Drawing.Font("Malgun Gothic", 10.8F);
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(237, 568);
            this.cbEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(562, 38);
            this.cbEstado.TabIndex = 13;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Font = new System.Drawing.Font("Malgun Gothic", 10.8F);
            this.txtDescripcion.Location = new System.Drawing.Point(237, 634);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(562, 222);
            this.txtDescripcion.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 10.8F);
            this.label1.Location = new System.Drawing.Point(37, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 30);
            this.label1.TabIndex = 15;
            this.label1.Text = "Titulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 10.8F);
            this.label2.Location = new System.Drawing.Point(37, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 30);
            this.label2.TabIndex = 16;
            this.label2.Text = "Autor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 10.8F);
            this.label4.Location = new System.Drawing.Point(35, 429);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 30);
            this.label4.TabIndex = 18;
            this.label4.Text = "Precio de Compra";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Malgun Gothic", 10.8F);
            this.label5.Location = new System.Drawing.Point(822, 946);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 30);
            this.label5.TabIndex = 19;
            this.label5.Text = "Stock";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Malgun Gothic", 10.8F);
            this.label6.Location = new System.Drawing.Point(37, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 30);
            this.label6.TabIndex = 20;
            this.label6.Text = "Categoría";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Malgun Gothic", 10.8F);
            this.label7.Location = new System.Drawing.Point(37, 488);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 30);
            this.label7.TabIndex = 21;
            this.label7.Text = "Precio de Venta";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Malgun Gothic", 10.8F);
            this.label8.Location = new System.Drawing.Point(38, 548);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 30);
            this.label8.TabIndex = 22;
            this.label8.Text = "Estado";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Malgun Gothic", 10.8F);
            this.label9.Location = new System.Drawing.Point(38, 614);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 30);
            this.label9.TabIndex = 23;
            this.label9.Text = "Descripción";
            // 
            // cbAutor
            // 
            this.cbAutor.Font = new System.Drawing.Font("Malgun Gothic", 10.8F);
            this.cbAutor.FormattingEnabled = true;
            this.cbAutor.Location = new System.Drawing.Point(237, 251);
            this.cbAutor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbAutor.Name = "cbAutor";
            this.cbAutor.Size = new System.Drawing.Size(562, 38);
            this.cbAutor.TabIndex = 24;
            // 
            // cbCategoria
            // 
            this.cbCategoria.Font = new System.Drawing.Font("Malgun Gothic", 10.8F);
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(237, 316);
            this.cbCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(562, 38);
            this.cbCategoria.TabIndex = 25;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.btnRegresar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRegresar.Location = new System.Drawing.Point(14, 14);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(78, 65);
            this.btnRegresar.TabIndex = 26;
            this.btnRegresar.Text = "←";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnAutorCategoria
            // 
            this.btnAutorCategoria.BackColor = System.Drawing.Color.Gray;
            this.btnAutorCategoria.FlatAppearance.BorderSize = 0;
            this.btnAutorCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutorCategoria.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnAutorCategoria.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAutorCategoria.Location = new System.Drawing.Point(980, 774);
            this.btnAutorCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAutorCategoria.Name = "btnAutorCategoria";
            this.btnAutorCategoria.Size = new System.Drawing.Size(267, 50);
            this.btnAutorCategoria.TabIndex = 27;
            this.btnAutorCategoria.Text = "Ingresar Autor/Categoría";
            this.btnAutorCategoria.UseVisualStyleBackColor = false;
            this.btnAutorCategoria.Click += new System.EventHandler(this.btnAutorCategoria_Click);
            // 
            // nudStock
            // 
            this.nudStock.Enabled = false;
            this.nudStock.Location = new System.Drawing.Point(824, 939);
            this.nudStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudStock.Name = "nudStock";
            this.nudStock.Size = new System.Drawing.Size(184, 26);
            this.nudStock.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(1284, 774);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(267, 50);
            this.button1.TabIndex = 29;
            this.button1.Text = "Ingresar Proveedor";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbProveedor
            // 
            this.cbProveedor.Font = new System.Drawing.Font("Malgun Gothic", 10.8F);
            this.cbProveedor.FormattingEnabled = true;
            this.cbProveedor.Location = new System.Drawing.Point(237, 381);
            this.cbProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbProveedor.Name = "cbProveedor";
            this.cbProveedor.Size = new System.Drawing.Size(562, 38);
            this.cbProveedor.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 10.8F);
            this.label3.Location = new System.Drawing.Point(38, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 30);
            this.label3.TabIndex = 30;
            this.label3.Text = "Proveedor";
            // 
            // CRUD_Libros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1688, 882);
            this.Controls.Add(this.cbProveedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nudStock);
            this.Controls.Add(this.btnAutorCategoria);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.cbAutor);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.txtPrecioVenta);
            this.Controls.Add(this.txtPrecioCompra);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.btnActualizarLibro);
            this.Controls.Add(this.btnAgregarLibro);
            this.Controls.Add(this.dgvLibros);
            this.Controls.Add(this.lblTitulo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CRUD_Libros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUD_Libros";
            this.Load += new System.EventHandler(this.CRUD_Libros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvLibros;
        private System.Windows.Forms.Button btnAgregarLibro;
        private System.Windows.Forms.Button btnActualizarLibro;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbAutor;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnAutorCategoria;
        private System.Windows.Forms.NumericUpDown nudStock;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbProveedor;
        private System.Windows.Forms.Label label3;
    }
}