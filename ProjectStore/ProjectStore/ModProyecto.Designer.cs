namespace ProjectStore
{
    partial class ModProyecto
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
            btnCancelar = new Button();
            btnMod = new Button();
            txtResumen = new TextBox();
            cmbTutor = new ComboBox();
            label11 = new Label();
            cmbCiclo = new ComboBox();
            txtArchivos = new TextBox();
            label9 = new Label();
            txtMemoria = new TextBox();
            cmbTipo = new ComboBox();
            label2 = new Label();
            txtComentarios = new TextBox();
            label10 = new Label();
            dtpFechaPres = new DateTimePicker();
            txtLogo = new TextBox();
            txtNombre = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            nudAnioAcademico = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudAnioAcademico).BeginInit();
            SuspendLayout();
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label12.Location = new Point(24, 537);
            label12.Name = "label12";
            label12.Size = new Size(117, 15);
            label12.TabIndex = 136;
            label12.Text = "* Campos requeridos";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Brown;
            btnCancelar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(250, 530);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(80, 28);
            btnCancelar.TabIndex = 133;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnMod
            // 
            btnMod.BackColor = Color.DodgerBlue;
            btnMod.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnMod.ForeColor = Color.White;
            btnMod.Location = new Point(350, 530);
            btnMod.Name = "btnMod";
            btnMod.Size = new Size(80, 28);
            btnMod.TabIndex = 132;
            btnMod.Text = "Modificar";
            btnMod.UseVisualStyleBackColor = false;
            btnMod.Click += btnMod_Click;
            // 
            // txtResumen
            // 
            txtResumen.Location = new Point(24, 347);
            txtResumen.Multiline = true;
            txtResumen.Name = "txtResumen";
            txtResumen.ScrollBars = ScrollBars.Vertical;
            txtResumen.Size = new Size(406, 66);
            txtResumen.TabIndex = 158;
            // 
            // cmbTutor
            // 
            cmbTutor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTutor.FormattingEnabled = true;
            cmbTutor.Location = new Point(24, 103);
            cmbTutor.Name = "cmbTutor";
            cmbTutor.Size = new Size(180, 23);
            cmbTutor.TabIndex = 157;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label11.Location = new Point(24, 85);
            label11.Name = "label11";
            label11.Size = new Size(35, 15);
            label11.TabIndex = 156;
            label11.Text = "Tutor";
            // 
            // cmbCiclo
            // 
            cmbCiclo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCiclo.Enabled = false;
            cmbCiclo.FormattingEnabled = true;
            cmbCiclo.Location = new Point(24, 286);
            cmbCiclo.Name = "cmbCiclo";
            cmbCiclo.Size = new Size(406, 23);
            cmbCiclo.TabIndex = 155;
            // 
            // txtArchivos
            // 
            txtArchivos.Enabled = false;
            txtArchivos.Location = new Point(250, 225);
            txtArchivos.Name = "txtArchivos";
            txtArchivos.Size = new Size(180, 23);
            txtArchivos.TabIndex = 154;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label9.Location = new Point(250, 207);
            label9.Name = "label9";
            label9.Size = new Size(122, 15);
            label9.TabIndex = 153;
            label9.Text = "Archivos del Proyecto";
            // 
            // txtMemoria
            // 
            txtMemoria.Enabled = false;
            txtMemoria.Location = new Point(24, 225);
            txtMemoria.Name = "txtMemoria";
            txtMemoria.Size = new Size(180, 23);
            txtMemoria.TabIndex = 151;
            // 
            // cmbTipo
            // 
            cmbTipo.Enabled = false;
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(250, 42);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(180, 23);
            cmbTipo.TabIndex = 150;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.Location = new Point(250, 24);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 149;
            label2.Text = "Tipo *";
            // 
            // txtComentarios
            // 
            txtComentarios.Location = new Point(24, 451);
            txtComentarios.Multiline = true;
            txtComentarios.Name = "txtComentarios";
            txtComentarios.ScrollBars = ScrollBars.Vertical;
            txtComentarios.Size = new Size(406, 66);
            txtComentarios.TabIndex = 148;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label10.Location = new Point(24, 433);
            label10.Name = "label10";
            label10.Size = new Size(74, 15);
            label10.TabIndex = 147;
            label10.Text = "Comentarios";
            // 
            // dtpFechaPres
            // 
            dtpFechaPres.Format = DateTimePickerFormat.Short;
            dtpFechaPres.Location = new Point(24, 164);
            dtpFechaPres.Name = "dtpFechaPres";
            dtpFechaPres.Size = new Size(180, 23);
            dtpFechaPres.TabIndex = 146;
            dtpFechaPres.Value = new DateTime(2024, 11, 9, 0, 0, 0, 0);
            // 
            // txtLogo
            // 
            txtLogo.Enabled = false;
            txtLogo.Location = new Point(250, 164);
            txtLogo.Name = "txtLogo";
            txtLogo.Size = new Size(180, 23);
            txtLogo.TabIndex = 145;
            // 
            // txtNombre
            // 
            txtNombre.Enabled = false;
            txtNombre.Location = new Point(24, 42);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(180, 23);
            txtNombre.TabIndex = 144;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label8.Location = new Point(24, 146);
            label8.Name = "label8";
            label8.Size = new Size(133, 15);
            label8.TabIndex = 143;
            label8.Text = "Fecha de Presentación *";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label7.Location = new Point(24, 207);
            label7.Name = "label7";
            label7.Size = new Size(124, 15);
            label7.TabIndex = 142;
            label7.Text = "Memoria del Proyecto";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label6.Location = new Point(250, 146);
            label6.Name = "label6";
            label6.Size = new Size(103, 15);
            label6.TabIndex = 141;
            label6.Text = "Logo del Proyecto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.Location = new Point(24, 268);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 140;
            label5.Text = "Ciclo *";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.Location = new Point(250, 85);
            label4.Name = "label4";
            label4.Size = new Size(100, 15);
            label4.TabIndex = 139;
            label4.Text = "Año Académico *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.Location = new Point(24, 329);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 138;
            label3.Text = "Resumen";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.Location = new Point(24, 24);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 137;
            label1.Text = "Nombre *";
            // 
            // nudAnioAcademico
            // 
            nudAnioAcademico.Enabled = false;
            nudAnioAcademico.Location = new Point(250, 103);
            nudAnioAcademico.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nudAnioAcademico.Minimum = new decimal(new int[] { 2023, 0, 0, 0 });
            nudAnioAcademico.Name = "nudAnioAcademico";
            nudAnioAcademico.Size = new Size(180, 23);
            nudAnioAcademico.TabIndex = 152;
            nudAnioAcademico.Value = new decimal(new int[] { 2024, 0, 0, 0 });
            // 
            // ModProyecto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 576);
            Controls.Add(txtResumen);
            Controls.Add(cmbTutor);
            Controls.Add(label11);
            Controls.Add(cmbCiclo);
            Controls.Add(txtArchivos);
            Controls.Add(label9);
            Controls.Add(nudAnioAcademico);
            Controls.Add(txtMemoria);
            Controls.Add(cmbTipo);
            Controls.Add(label2);
            Controls.Add(txtComentarios);
            Controls.Add(label10);
            Controls.Add(dtpFechaPres);
            Controls.Add(txtLogo);
            Controls.Add(txtNombre);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label12);
            Controls.Add(btnCancelar);
            Controls.Add(btnMod);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ModProyecto";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Modificar Proyecto";
            ((System.ComponentModel.ISupportInitialize)nudAnioAcademico).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label12;
        private Button btnCancelar;
        private Button btnMod;
        private TextBox txtResumen;
        private ComboBox cmbTutor;
        private Label label11;
        private ComboBox cmbCiclo;
        private TextBox txtArchivos;
        private Label label9;
        private TextBox txtMemoria;
        private ComboBox cmbTipo;
        private Label label2;
        private TextBox txtComentarios;
        private Label label10;
        private DateTimePicker dtpFechaPres;
        private TextBox txtLogo;
        private TextBox txtNombre;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private NumericUpDown nudAnioAcademico;
    }
}