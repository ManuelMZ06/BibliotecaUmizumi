namespace Biblioteca_Umizumi.Vista.CRUD_Libros_Registros
{
    partial class Autor_Categoria
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
            this.btnActualizarAutor = new System.Windows.Forms.Button();
            this.btnAgregarAutor = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnActulizarCategoria = new System.Windows.Forms.Button();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.dgvAutores = new System.Windows.Forms.DataGridView();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreAutor = new System.Windows.Forms.TextBox();
            this.cbEstadoAutor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbEstadoCategoria = new System.Windows.Forms.ComboBox();
            this.txtNombreCategoria = new System.Windows.Forms.TextBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // btnActualizarAutor
            // 
            this.btnActualizarAutor.BackColor = System.Drawing.Color.Goldenrod;
            this.btnActualizarAutor.FlatAppearance.BorderSize = 0;
            this.btnActualizarAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarAutor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnActualizarAutor.Location = new System.Drawing.Point(1178, 175);
            this.btnActualizarAutor.Name = "btnActualizarAutor";
            this.btnActualizarAutor.Size = new System.Drawing.Size(160, 42);
            this.btnActualizarAutor.TabIndex = 7;
            this.btnActualizarAutor.Text = "Actualizar";
            this.btnActualizarAutor.UseVisualStyleBackColor = false;
            this.btnActualizarAutor.Click += new System.EventHandler(this.btnActualizarAutor_Click_1);
            // 
            // btnAgregarAutor
            // 
            this.btnAgregarAutor.BackColor = System.Drawing.Color.OliveDrab;
            this.btnAgregarAutor.FlatAppearance.BorderSize = 0;
            this.btnAgregarAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarAutor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregarAutor.Location = new System.Drawing.Point(1178, 248);
            this.btnAgregarAutor.Name = "btnAgregarAutor";
            this.btnAgregarAutor.Size = new System.Drawing.Size(160, 42);
            this.btnAgregarAutor.TabIndex = 6;
            this.btnAgregarAutor.Text = "Agregar";
            this.btnAgregarAutor.UseVisualStyleBackColor = false;
            this.btnAgregarAutor.Click += new System.EventHandler(this.btnAgregarAutor_Click_1);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(565, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(302, 42);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Autores y Categorías";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // btnActulizarCategoria
            // 
            this.btnActulizarCategoria.BackColor = System.Drawing.Color.Goldenrod;
            this.btnActulizarCategoria.FlatAppearance.BorderSize = 0;
            this.btnActulizarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActulizarCategoria.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnActulizarCategoria.Location = new System.Drawing.Point(1178, 821);
            this.btnActulizarCategoria.Name = "btnActulizarCategoria";
            this.btnActulizarCategoria.Size = new System.Drawing.Size(160, 42);
            this.btnActulizarCategoria.TabIndex = 11;
            this.btnActulizarCategoria.Text = "Actualizar";
            this.btnActulizarCategoria.UseVisualStyleBackColor = false;
            this.btnActulizarCategoria.Click += new System.EventHandler(this.btnActulizarCategoria_Click);
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.BackColor = System.Drawing.Color.OliveDrab;
            this.btnAgregarCategoria.FlatAppearance.BorderSize = 0;
            this.btnAgregarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCategoria.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregarCategoria.Location = new System.Drawing.Point(1178, 894);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(160, 42);
            this.btnAgregarCategoria.TabIndex = 10;
            this.btnAgregarCategoria.Text = "Agregar";
            this.btnAgregarCategoria.UseVisualStyleBackColor = false;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click_1);
            // 
            // dgvAutores
            // 
            this.dgvAutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutores.Location = new System.Drawing.Point(241, 175);
            this.dgvAutores.Name = "dgvAutores";
            this.dgvAutores.RowHeadersWidth = 62;
            this.dgvAutores.RowTemplate.Height = 28;
            this.dgvAutores.Size = new System.Drawing.Size(901, 513);
            this.dgvAutores.TabIndex = 12;
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Location = new System.Drawing.Point(241, 783);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.RowHeadersWidth = 62;
            this.dgvCategorias.RowTemplate.Height = 28;
            this.dgvCategorias.Size = new System.Drawing.Size(901, 513);
            this.dgvCategorias.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 42);
            this.label1.TabIndex = 14;
            this.label1.Text = "Autores ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(250, 721);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 42);
            this.label2.TabIndex = 15;
            this.label2.Text = "Categorías";
            // 
            // txtNombreAutor
            // 
            this.txtNombreAutor.Location = new System.Drawing.Point(12, 209);
            this.txtNombreAutor.Name = "txtNombreAutor";
            this.txtNombreAutor.Size = new System.Drawing.Size(211, 26);
            this.txtNombreAutor.TabIndex = 16;
            // 
            // cbEstadoAutor
            // 
            this.cbEstadoAutor.FormattingEnabled = true;
            this.cbEstadoAutor.Location = new System.Drawing.Point(12, 275);
            this.cbEstadoAutor.Name = "cbEstadoAutor";
            this.cbEstadoAutor.Size = new System.Drawing.Size(130, 28);
            this.cbEstadoAutor.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 24);
            this.label4.TabIndex = 20;
            this.label4.Text = "Estado";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 875);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 24);
            this.label5.TabIndex = 24;
            this.label5.Text = "Estado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 802);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 24);
            this.label6.TabIndex = 23;
            this.label6.Text = "Nombre";
            // 
            // cbEstadoCategoria
            // 
            this.cbEstadoCategoria.FormattingEnabled = true;
            this.cbEstadoCategoria.Location = new System.Drawing.Point(12, 902);
            this.cbEstadoCategoria.Name = "cbEstadoCategoria";
            this.cbEstadoCategoria.Size = new System.Drawing.Size(130, 28);
            this.cbEstadoCategoria.TabIndex = 22;
            // 
            // txtNombreCategoria
            // 
            this.txtNombreCategoria.Location = new System.Drawing.Point(12, 829);
            this.txtNombreCategoria.Name = "txtNombreCategoria";
            this.txtNombreCategoria.Size = new System.Drawing.Size(211, 26);
            this.txtNombreCategoria.TabIndex = 21;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(12, 12);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(78, 65);
            this.btnRegresar.TabIndex = 25;
            this.btnRegresar.Text = "←";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // Autor_Categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1412, 1317);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbEstadoCategoria);
            this.Controls.Add(this.txtNombreCategoria);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbEstadoAutor);
            this.Controls.Add(this.txtNombreAutor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCategorias);
            this.Controls.Add(this.dgvAutores);
            this.Controls.Add(this.btnActulizarCategoria);
            this.Controls.Add(this.btnAgregarCategoria);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnActualizarAutor);
            this.Controls.Add(this.btnAgregarAutor);
            this.Name = "Autor_Categoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autor_Categoria";
            this.Load += new System.EventHandler(this.Autor_Categoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnActualizarAutor;
        private System.Windows.Forms.Button btnAgregarAutor;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnActulizarCategoria;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.DataGridView dgvAutores;
        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreAutor;
        private System.Windows.Forms.ComboBox cbEstadoAutor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbEstadoCategoria;
        private System.Windows.Forms.TextBox txtNombreCategoria;
        private System.Windows.Forms.Button btnRegresar;
    }
}