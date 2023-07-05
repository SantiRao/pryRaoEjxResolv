namespace pryRaoEjxResolv
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mrcRegMed = new System.Windows.Forms.GroupBox();
            this.cmbEspecialiadMedico = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRegistrarMedico = new System.Windows.Forms.Button();
            this.mrcRegEsp = new System.Windows.Forms.GroupBox();
            this.txtAgregarEspecialidad = new System.Windows.Forms.TextBox();
            this.lblEspecialidadRegistro = new System.Windows.Forms.Label();
            this.btnRegistrarEspecialidad = new System.Windows.Forms.Button();
            this.mrcConsulta = new System.Windows.Forms.GroupBox();
            this.lstConsulta = new System.Windows.Forms.ListBox();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.btnConsultarEspecialidad = new System.Windows.Forms.Button();
            this.cmbConsultaEspecialidad = new System.Windows.Forms.ComboBox();
            this.mrcRegMed.SuspendLayout();
            this.mrcRegEsp.SuspendLayout();
            this.mrcConsulta.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcRegMed
            // 
            this.mrcRegMed.Controls.Add(this.cmbEspecialiadMedico);
            this.mrcRegMed.Controls.Add(this.txtNombre);
            this.mrcRegMed.Controls.Add(this.txtMatricula);
            this.mrcRegMed.Controls.Add(this.label4);
            this.mrcRegMed.Controls.Add(this.label5);
            this.mrcRegMed.Controls.Add(this.label6);
            this.mrcRegMed.Controls.Add(this.btnRegistrarMedico);
            this.mrcRegMed.Location = new System.Drawing.Point(11, 11);
            this.mrcRegMed.Margin = new System.Windows.Forms.Padding(2);
            this.mrcRegMed.Name = "mrcRegMed";
            this.mrcRegMed.Padding = new System.Windows.Forms.Padding(2);
            this.mrcRegMed.Size = new System.Drawing.Size(305, 159);
            this.mrcRegMed.TabIndex = 19;
            this.mrcRegMed.TabStop = false;
            this.mrcRegMed.Text = "Registro Medico";
            // 
            // cmbEspecialiadMedico
            // 
            this.cmbEspecialiadMedico.FormattingEnabled = true;
            this.cmbEspecialiadMedico.Location = new System.Drawing.Point(92, 113);
            this.cmbEspecialiadMedico.Margin = new System.Windows.Forms.Padding(2);
            this.cmbEspecialiadMedico.Name = "cmbEspecialiadMedico";
            this.cmbEspecialiadMedico.Size = new System.Drawing.Size(76, 21);
            this.cmbEspecialiadMedico.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(92, 67);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(76, 20);
            this.txtNombre.TabIndex = 14;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(92, 24);
            this.txtMatricula.Margin = new System.Windows.Forms.Padding(2);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(76, 20);
            this.txtMatricula.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 113);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Especialidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 72);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 26);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Matricula";
            // 
            // btnRegistrarMedico
            // 
            this.btnRegistrarMedico.Location = new System.Drawing.Point(203, 110);
            this.btnRegistrarMedico.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrarMedico.Name = "btnRegistrarMedico";
            this.btnRegistrarMedico.Size = new System.Drawing.Size(58, 25);
            this.btnRegistrarMedico.TabIndex = 10;
            this.btnRegistrarMedico.Text = "Registrar";
            this.btnRegistrarMedico.UseVisualStyleBackColor = true;
            this.btnRegistrarMedico.Click += new System.EventHandler(this.btnRegistrarMedico_Click);
            // 
            // mrcRegEsp
            // 
            this.mrcRegEsp.Controls.Add(this.txtAgregarEspecialidad);
            this.mrcRegEsp.Controls.Add(this.lblEspecialidadRegistro);
            this.mrcRegEsp.Controls.Add(this.btnRegistrarEspecialidad);
            this.mrcRegEsp.Location = new System.Drawing.Point(320, 14);
            this.mrcRegEsp.Margin = new System.Windows.Forms.Padding(2);
            this.mrcRegEsp.Name = "mrcRegEsp";
            this.mrcRegEsp.Padding = new System.Windows.Forms.Padding(2);
            this.mrcRegEsp.Size = new System.Drawing.Size(281, 156);
            this.mrcRegEsp.TabIndex = 18;
            this.mrcRegEsp.TabStop = false;
            this.mrcRegEsp.Text = "Registro Especialidad";
            // 
            // txtAgregarEspecialidad
            // 
            this.txtAgregarEspecialidad.Location = new System.Drawing.Point(133, 24);
            this.txtAgregarEspecialidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtAgregarEspecialidad.Name = "txtAgregarEspecialidad";
            this.txtAgregarEspecialidad.Size = new System.Drawing.Size(76, 20);
            this.txtAgregarEspecialidad.TabIndex = 13;
            // 
            // lblEspecialidadRegistro
            // 
            this.lblEspecialidadRegistro.AutoSize = true;
            this.lblEspecialidadRegistro.Location = new System.Drawing.Point(12, 26);
            this.lblEspecialidadRegistro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEspecialidadRegistro.Name = "lblEspecialidadRegistro";
            this.lblEspecialidadRegistro.Size = new System.Drawing.Size(110, 13);
            this.lblEspecialidadRegistro.TabIndex = 9;
            this.lblEspecialidadRegistro.Text = "Agregue Especialidad";
            // 
            // btnRegistrarEspecialidad
            // 
            this.btnRegistrarEspecialidad.Location = new System.Drawing.Point(133, 54);
            this.btnRegistrarEspecialidad.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrarEspecialidad.Name = "btnRegistrarEspecialidad";
            this.btnRegistrarEspecialidad.Size = new System.Drawing.Size(75, 28);
            this.btnRegistrarEspecialidad.TabIndex = 10;
            this.btnRegistrarEspecialidad.Text = "Registrar";
            this.btnRegistrarEspecialidad.UseVisualStyleBackColor = true;
            this.btnRegistrarEspecialidad.Click += new System.EventHandler(this.btnRegistrarEspecialidad_Click);
            // 
            // mrcConsulta
            // 
            this.mrcConsulta.Controls.Add(this.lstConsulta);
            this.mrcConsulta.Controls.Add(this.lblEspecialidad);
            this.mrcConsulta.Controls.Add(this.btnConsultarEspecialidad);
            this.mrcConsulta.Controls.Add(this.cmbConsultaEspecialidad);
            this.mrcConsulta.Location = new System.Drawing.Point(11, 174);
            this.mrcConsulta.Margin = new System.Windows.Forms.Padding(2);
            this.mrcConsulta.Name = "mrcConsulta";
            this.mrcConsulta.Padding = new System.Windows.Forms.Padding(2);
            this.mrcConsulta.Size = new System.Drawing.Size(590, 214);
            this.mrcConsulta.TabIndex = 17;
            this.mrcConsulta.TabStop = false;
            this.mrcConsulta.Text = "Consulta";
            // 
            // lstConsulta
            // 
            this.lstConsulta.FormattingEnabled = true;
            this.lstConsulta.Location = new System.Drawing.Point(234, 17);
            this.lstConsulta.Margin = new System.Windows.Forms.Padding(2);
            this.lstConsulta.Name = "lstConsulta";
            this.lstConsulta.Size = new System.Drawing.Size(342, 186);
            this.lstConsulta.TabIndex = 17;
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(3, 20);
            this.lblEspecialidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(122, 13);
            this.lblEspecialidad.TabIndex = 0;
            this.lblEspecialidad.Text = "Seleccione especialidad";
            // 
            // btnConsultarEspecialidad
            // 
            this.btnConsultarEspecialidad.Location = new System.Drawing.Point(125, 50);
            this.btnConsultarEspecialidad.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultarEspecialidad.Name = "btnConsultarEspecialidad";
            this.btnConsultarEspecialidad.Size = new System.Drawing.Size(91, 26);
            this.btnConsultarEspecialidad.TabIndex = 2;
            this.btnConsultarEspecialidad.Text = "Consultar";
            this.btnConsultarEspecialidad.UseVisualStyleBackColor = true;
            this.btnConsultarEspecialidad.Click += new System.EventHandler(this.btnConsultarEspecialidad_Click);
            // 
            // cmbConsultaEspecialidad
            // 
            this.cmbConsultaEspecialidad.FormattingEnabled = true;
            this.cmbConsultaEspecialidad.Items.AddRange(new object[] {
            ""});
            this.cmbConsultaEspecialidad.Location = new System.Drawing.Point(125, 17);
            this.cmbConsultaEspecialidad.Margin = new System.Windows.Forms.Padding(2);
            this.cmbConsultaEspecialidad.Name = "cmbConsultaEspecialidad";
            this.cmbConsultaEspecialidad.Size = new System.Drawing.Size(92, 21);
            this.cmbConsultaEspecialidad.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 399);
            this.Controls.Add(this.mrcRegMed);
            this.Controls.Add(this.mrcRegEsp);
            this.Controls.Add(this.mrcConsulta);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.mrcRegMed.ResumeLayout(false);
            this.mrcRegMed.PerformLayout();
            this.mrcRegEsp.ResumeLayout(false);
            this.mrcRegEsp.PerformLayout();
            this.mrcConsulta.ResumeLayout(false);
            this.mrcConsulta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcRegMed;
        private System.Windows.Forms.ComboBox cmbEspecialiadMedico;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRegistrarMedico;
        private System.Windows.Forms.GroupBox mrcRegEsp;
        private System.Windows.Forms.TextBox txtAgregarEspecialidad;
        private System.Windows.Forms.Label lblEspecialidadRegistro;
        private System.Windows.Forms.Button btnRegistrarEspecialidad;
        private System.Windows.Forms.GroupBox mrcConsulta;
        private System.Windows.Forms.ListBox lstConsulta;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.Button btnConsultarEspecialidad;
        private System.Windows.Forms.ComboBox cmbConsultaEspecialidad;
    }
}

