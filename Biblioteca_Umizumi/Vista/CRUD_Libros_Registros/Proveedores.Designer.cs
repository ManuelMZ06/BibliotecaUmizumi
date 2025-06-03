namespace Biblioteca_Umizumi.Vista.CRUD_Libros_Registros
{
    partial class Proveedores
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDatos = new System.Windows.Forms.Label();
            this.btnActualizarLibro = new System.Windows.Forms.Button();
            this.btnAgregarLibro = new System.Windows.Forms.Button();
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 10.8F);
            this.label1.Location = new System.Drawing.Point(33, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 30);
            this.label1.TabIndex = 35;
            this.label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Malgun Gothic", 10.8F);
            this.txtNombre.Location = new System.Drawing.Point(144, 322);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(562, 36);
            this.txtNombre.TabIndex = 34;
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 18F);
            this.lblDatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDatos.Location = new System.Drawing.Point(208, 255);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(392, 42);
            this.lblDatos.TabIndex = 33;
            this.lblDatos.Text = "I N G R E S A R         D A T O S";
            // 
            // btnActualizarLibro
            // 
            this.btnActualizarLibro.BackColor = System.Drawing.Color.Gold;
            this.btnActualizarLibro.FlatAppearance.BorderSize = 0;
            this.btnActualizarLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarLibro.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnActualizarLibro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnActualizarLibro.Location = new System.Drawing.Point(973, 135);
            this.btnActualizarLibro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActualizarLibro.Name = "btnActualizarLibro";
            this.btnActualizarLibro.Size = new System.Drawing.Size(160, 50);
            this.btnActualizarLibro.TabIndex = 32;
            this.btnActualizarLibro.Text = "Actualizar";
            this.btnActualizarLibro.UseVisualStyleBackColor = false;
            this.btnActualizarLibro.Click += new System.EventHandler(this.btnActualizarLibro_Click);
            // 
            // btnAgregarLibro
            // 
            this.btnAgregarLibro.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAgregarLibro.FlatAppearance.BorderSize = 0;
            this.btnAgregarLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarLibro.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnAgregarLibro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregarLibro.Location = new System.Drawing.Point(1191, 135);
            this.btnAgregarLibro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarLibro.Name = "btnAgregarLibro";
            this.btnAgregarLibro.Size = new System.Drawing.Size(160, 50);
            this.btnAgregarLibro.TabIndex = 31;
            this.btnAgregarLibro.Text = "Agregar";
            this.btnAgregarLibro.UseVisualStyleBackColor = false;
            this.btnAgregarLibro.Click += new System.EventHandler(this.btnAgregarLibro_Click);
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.AllowUserToAddRows = false;
            this.dgvProveedores.AllowUserToDeleteRows = false;
            this.dgvProveedores.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.Location = new System.Drawing.Point(731, 210);
            this.dgvProveedores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.RowHeadersWidth = 62;
            this.dgvProveedores.RowTemplate.Height = 28;
            this.dgvProveedores.Size = new System.Drawing.Size(824, 478);
            this.dgvProveedores.TabIndex = 30;
            this.dgvProveedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProveedores_CellContentClick);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 24F);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitulo.Location = new System.Drawing.Point(634, 41);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(522, 61);
            this.lblTitulo.TabIndex = 29;
            this.lblTitulo.Text = "REGISTROS PROVEEDORES";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefono.Font = new System.Drawing.Font("Malgun Gothic", 10.8F);
            this.txtTelefono.Location = new System.Drawing.Point(144, 378);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(562, 36);
            this.txtTelefono.TabIndex = 37;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Malgun Gothic", 10.8F);
            this.txtEmail.Location = new System.Drawing.Point(144, 441);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(562, 36);
            this.txtEmail.TabIndex = 38;
            // 
            // txtDireccion
            // 
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccion.Font = new System.Drawing.Font("Malgun Gothic", 10.8F);
            this.txtDireccion.Location = new System.Drawing.Point(144, 501);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(562, 36);
            this.txtDireccion.TabIndex = 39;
            // 
            // cbEstado
            // 
            this.cbEstado.Font = new System.Drawing.Font("Malgun Gothic", 10.8F);
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Activado",
            "Desactivado"});
            this.cbEstado.Location = new System.Drawing.Point(144, 560);
            this.cbEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(303, 38);
            this.cbEstado.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 10.8F);
            this.label2.Location = new System.Drawing.Point(33, 380);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 30);
            this.label2.TabIndex = 41;
            this.label2.Text = "Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 10.8F);
            this.label3.Location = new System.Drawing.Point(33, 504);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 30);
            this.label3.TabIndex = 42;
            this.label3.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 10.8F);
            this.label4.Location = new System.Drawing.Point(35, 444);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 30);
            this.label4.TabIndex = 43;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Malgun Gothic", 10.8F);
            this.label5.Location = new System.Drawing.Point(35, 560);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 30);
            this.label5.TabIndex = 44;
            this.label5.Text = "Estado";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(14, 14);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(78, 65);
            this.btnRegresar.TabIndex = 45;
            this.btnRegresar.Text = "←";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1587, 752);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.btnActualizarLibro);
            this.Controls.Add(this.btnAgregarLibro);
            this.Controls.Add(this.dgvProveedores);
            this.Controls.Add(this.lblTitulo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Proveedores";
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.Proveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Button btnActualizarLibro;
        private System.Windows.Forms.Button btnAgregarLibro;
        private System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRegresar;
    }
}