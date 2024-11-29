namespace ProjectStore
{
    partial class ModProfesor
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
            label12 = new Label();
            txtEspecialidad = new TextBox();
            label10 = new Label();
            btnCancelar = new Button();
            btnMod = new Button();
            dtpFechaNac = new DateTimePicker();
            cmbGenero = new ComboBox();
            txtTelefono = new TextBox();
            txtContraseña = new TextBox();
            txtEmail = new TextBox();
            txtDni = new TextBox();
            txtApellidos = new TextBox();
            txtNombre = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            chkActivo = new CheckBox();
            SuspendLayout();
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label12.Location = new Point(19, 372);
            label12.Name = "label12";
            label12.Size = new Size(117, 15);
            label12.TabIndex = 113;
            label12.Text = "* Campos requeridos";
            // 
            // txtEspecialidad
            // 
            txtEspecialidad.Enabled = false;
            txtEspecialidad.Location = new Point(24, 286);
            txtEspecialidad.Name = "txtEspecialidad";
            txtEspecialidad.Size = new Size(406, 23);
            txtEspecialidad.TabIndex = 112;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label10.Location = new Point(24, 268);
            label10.Name = "label10";
            label10.Size = new Size(72, 15);
            label10.TabIndex = 111;
            label10.Text = "Especialidad";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Brown;
            btnCancelar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(250, 365);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(80, 28);
            btnCancelar.TabIndex = 110;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnMod
            // 
            btnMod.BackColor = Color.DodgerBlue;
            btnMod.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnMod.ForeColor = Color.White;
            btnMod.Location = new Point(350, 365);
            btnMod.Name = "btnMod";
            btnMod.Size = new Size(80, 28);
            btnMod.TabIndex = 109;
            btnMod.Text = "Modificar";
            btnMod.UseVisualStyleBackColor = false;
            btnMod.Click += btnMod_Click;
            // 
            // dtpFechaNac
            // 
            dtpFechaNac.Enabled = false;
            dtpFechaNac.Format = DateTimePickerFormat.Short;
            dtpFechaNac.Location = new Point(250, 103);
            dtpFechaNac.Name = "dtpFechaNac";
            dtpFechaNac.Size = new Size(180, 23);
            dtpFechaNac.TabIndex = 108;
            // 
            // cmbGenero
            // 
            cmbGenero.Enabled = false;
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Location = new Point(24, 164);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(180, 23);
            cmbGenero.TabIndex = 107;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(250, 164);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(180, 23);
            txtTelefono.TabIndex = 106;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(250, 225);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(180, 23);
            txtContraseña.TabIndex = 105;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(24, 225);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(180, 23);
            txtEmail.TabIndex = 104;
            // 
            // txtDni
            // 
            txtDni.Enabled = false;
            txtDni.Location = new Point(24, 103);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(180, 23);
            txtDni.TabIndex = 103;
            // 
            // txtApellidos
            // 
            txtApellidos.Enabled = false;
            txtApellidos.Location = new Point(250, 42);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(180, 23);
            txtApellidos.TabIndex = 102;
            // 
            // txtNombre
            // 
            txtNombre.Enabled = false;
            txtNombre.Location = new Point(24, 42);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(180, 23);
            txtNombre.TabIndex = 101;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label8.Location = new Point(250, 85);
            label8.Name = "label8";
            label8.Size = new Size(119, 15);
            label8.TabIndex = 100;
            label8.Text = "Fecha de Nacimiento";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label7.Location = new Point(24, 146);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 99;
            label7.Text = "Género *";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label6.Location = new Point(250, 146);
            label6.Name = "label6";
            label6.Size = new Size(86, 15);
            label6.TabIndex = 98;
            label6.Text = "Teléfono Móvil";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.Location = new Point(250, 207);
            label5.Name = "label5";
            label5.Size = new Size(74, 15);
            label5.TabIndex = 97;
            label5.Text = "Contraseña *";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.Location = new Point(24, 207);
            label4.Name = "label4";
            label4.Size = new Size(112, 15);
            label4.TabIndex = 96;
            label4.Text = "Correo Electrónico *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.Location = new Point(24, 85);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 95;
            label3.Text = "DNI *";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.Location = new Point(250, 24);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 94;
            label2.Text = "Apellidos *";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.Location = new Point(24, 24);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 93;
            label1.Text = "Nombre *";
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkActivo.Location = new Point(24, 329);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(117, 19);
            chkActivo.TabIndex = 114;
            chkActivo.Text = "¿Profesor Activo?";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // ModProfesor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 409);
            Controls.Add(chkActivo);
            Controls.Add(label12);
            Controls.Add(txtEspecialidad);
            Controls.Add(label10);
            Controls.Add(btnCancelar);
            Controls.Add(btnMod);
            Controls.Add(dtpFechaNac);
            Controls.Add(cmbGenero);
            Controls.Add(txtTelefono);
            Controls.Add(txtContraseña);
            Controls.Add(txtEmail);
            Controls.Add(txtDni);
            Controls.Add(txtApellidos);
            Controls.Add(txtNombre);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ModProfesor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modificar Profesor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label12;
        private TextBox txtEspecialidad;
        private Label label10;
        private Button btnCancelar;
        private Button btnMod;
        private DateTimePicker dtpFechaNac;
        private ComboBox cmbGenero;
        private TextBox txtTelefono;
        private TextBox txtContraseña;
        private TextBox txtEmail;
        private TextBox txtDni;
        private TextBox txtApellidos;
        private TextBox txtNombre;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private CheckBox chkActivo;
    }
}