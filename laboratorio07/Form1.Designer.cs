namespace Laboratorio07
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblCodigo = new Label();
            lblNombre = new Label();
            txtCodigo = new TextBox();
            txtNombre = new TextBox();
            cboCondicionContrato = new ComboBox();
            lblCondicionContrato = new Label();
            lblEspecialidad = new Label();
            cboEspecialidad = new ComboBox();
            cboTipoActividad = new ComboBox();
            lblTipoActividad = new Label();
            cboTipoAfiliacion = new ComboBox();
            lblTipoAfiliacion = new Label();
            btnCrear = new Button();
            btnMostrar = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            txtResulatdo = new TextBox();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(12, 9);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(58, 20);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Codigo";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(211, 9);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(12, 32);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(161, 27);
            txtCodigo.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(211, 32);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(309, 27);
            txtNombre.TabIndex = 3;
            // 
            // cboCondicionContrato
            // 
            cboCondicionContrato.FormattingEnabled = true;
            cboCondicionContrato.Items.AddRange(new object[] { "Estable", "Contratado" });
            cboCondicionContrato.Location = new Point(574, 32);
            cboCondicionContrato.Name = "cboCondicionContrato";
            cboCondicionContrato.Size = new Size(159, 28);
            cboCondicionContrato.TabIndex = 4;
            // 
            // lblCondicionContrato
            // 
            lblCondicionContrato.AutoSize = true;
            lblCondicionContrato.Location = new Point(574, 9);
            lblCondicionContrato.Name = "lblCondicionContrato";
            lblCondicionContrato.Size = new Size(159, 20);
            lblCondicionContrato.TabIndex = 5;
            lblCondicionContrato.Text = "Condicion de Contrato";
            lblCondicionContrato.Click += label3_Click;
            // 
            // lblEspecialidad
            // 
            lblEspecialidad.AutoSize = true;
            lblEspecialidad.Location = new Point(10, 83);
            lblEspecialidad.Name = "lblEspecialidad";
            lblEspecialidad.Size = new Size(93, 20);
            lblEspecialidad.TabIndex = 6;
            lblEspecialidad.Text = "Especialidad";
            // 
            // cboEspecialidad
            // 
            cboEspecialidad.FormattingEnabled = true;
            cboEspecialidad.Items.AddRange(new object[] { "Estructura", "Recursos Hidricos" });
            cboEspecialidad.Location = new Point(12, 106);
            cboEspecialidad.Name = "cboEspecialidad";
            cboEspecialidad.Size = new Size(184, 28);
            cboEspecialidad.TabIndex = 7;
            // 
            // cboTipoActividad
            // 
            cboTipoActividad.FormattingEnabled = true;
            cboTipoActividad.Items.AddRange(new object[] { "Supervisión de Obras", "Supervisión  de Vías" });
            cboTipoActividad.Location = new Point(305, 106);
            cboTipoActividad.Name = "cboTipoActividad";
            cboTipoActividad.Size = new Size(175, 28);
            cboTipoActividad.TabIndex = 8;
            // 
            // lblTipoActividad
            // 
            lblTipoActividad.AutoSize = true;
            lblTipoActividad.Location = new Point(305, 83);
            lblTipoActividad.Name = "lblTipoActividad";
            lblTipoActividad.Size = new Size(127, 20);
            lblTipoActividad.TabIndex = 9;
            lblTipoActividad.Text = "Tipo de Actividad";
            // 
            // cboTipoAfiliacion
            // 
            cboTipoAfiliacion.FormattingEnabled = true;
            cboTipoAfiliacion.Items.AddRange(new object[] { "AFP", "SNP" });
            cboTipoAfiliacion.Location = new Point(574, 106);
            cboTipoAfiliacion.Name = "cboTipoAfiliacion";
            cboTipoAfiliacion.Size = new Size(159, 28);
            cboTipoAfiliacion.TabIndex = 10;
            // 
            // lblTipoAfiliacion
            // 
            lblTipoAfiliacion.AutoSize = true;
            lblTipoAfiliacion.Location = new Point(574, 83);
            lblTipoAfiliacion.Name = "lblTipoAfiliacion";
            lblTipoAfiliacion.Size = new Size(129, 20);
            lblTipoAfiliacion.TabIndex = 11;
            lblTipoAfiliacion.Text = "Tipo De Afiliacion";
            lblTipoAfiliacion.Click += label6_Click;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(12, 393);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(94, 29);
            btnCrear.TabIndex = 12;
            btnCrear.Text = "Crear Objeto";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(181, 393);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(149, 29);
            btnMostrar.TabIndex = 13;
            btnMostrar.Text = "Mostrar Objeto";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(493, 393);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 14;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Firebrick;
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(639, 393);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 15;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // txtResulatdo
            // 
            txtResulatdo.BackColor = Color.White;
            txtResulatdo.CausesValidation = false;
            txtResulatdo.Location = new Point(12, 140);
            txtResulatdo.Multiline = true;
            txtResulatdo.Name = "txtResulatdo";
            txtResulatdo.Size = new Size(721, 247);
            txtResulatdo.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtResulatdo);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnMostrar);
            Controls.Add(btnCrear);
            Controls.Add(lblTipoAfiliacion);
            Controls.Add(cboTipoAfiliacion);
            Controls.Add(lblTipoActividad);
            Controls.Add(cboTipoActividad);
            Controls.Add(cboEspecialidad);
            Controls.Add(lblEspecialidad);
            Controls.Add(lblCondicionContrato);
            Controls.Add(cboCondicionContrato);
            Controls.Add(txtNombre);
            Controls.Add(txtCodigo);
            Controls.Add(lblNombre);
            Controls.Add(lblCodigo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigo;
        private Label lblNombre;
        private TextBox txtCodigo;
        private TextBox txtNombre;
        private ComboBox cboCondicionContrato;
        private Label lblCondicionContrato;
        private Label lblEspecialidad;
        private ComboBox cboEspecialidad;
        private ComboBox cboTipoActividad;
        private Label lblTipoActividad;
        private ComboBox cboTipoAfiliacion;
        private Label lblTipoAfiliacion;
        private Button btnCrear;
        private Button btnMostrar;
        private Button btnLimpiar;
        private Button btnSalir;
        private TextBox txtResulatdo;
    }
}
