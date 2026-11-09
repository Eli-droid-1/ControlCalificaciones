namespace CapaPresentacion
{
    partial class frmCalificaciones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dgvCalificaciones = new System.Windows.Forms.DataGridView();
            this.cboEstudiante = new System.Windows.Forms.ComboBox();
            this.cboMateria = new System.Windows.Forms.ComboBox();
            this.btnNuevoEstudiante = new System.Windows.Forms.Button();
            this.btnNuevaMateria = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalificaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estudiante";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Materia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(422, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nota 1";
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(382, 85);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(127, 22);
            this.txtNota1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(578, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nota 2";
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(542, 85);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(127, 22);
            this.txtNota2.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(740, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nota 3";
            // 
            // txtNota3
            // 
            this.txtNota3.Location = new System.Drawing.Point(702, 85);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(127, 22);
            this.txtNota3.TabIndex = 9;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(22, 145);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(91, 41);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(135, 145);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(90, 41);
            this.btnActualizar.TabIndex = 11;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(247, 145);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(85, 41);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(351, 145);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(88, 41);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // dgvCalificaciones
            // 
            this.dgvCalificaciones.AllowUserToAddRows = false;
            this.dgvCalificaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCalificaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCalificaciones.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCalificaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCalificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCalificaciones.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCalificaciones.Location = new System.Drawing.Point(12, 223);
            this.dgvCalificaciones.MultiSelect = false;
            this.dgvCalificaciones.Name = "dgvCalificaciones";
            this.dgvCalificaciones.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCalificaciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCalificaciones.RowHeadersWidth = 51;
            this.dgvCalificaciones.RowTemplate.Height = 24;
            this.dgvCalificaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCalificaciones.Size = new System.Drawing.Size(770, 225);
            this.dgvCalificaciones.TabIndex = 14;
            // 
            // cboEstudiante
            // 
            this.cboEstudiante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstudiante.FormattingEnabled = true;
            this.cboEstudiante.Location = new System.Drawing.Point(6, 83);
            this.cboEstudiante.Name = "cboEstudiante";
            this.cboEstudiante.Size = new System.Drawing.Size(177, 24);
            this.cboEstudiante.TabIndex = 15;
            // 
            // cboMateria
            // 
            this.cboMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMateria.FormattingEnabled = true;
            this.cboMateria.Location = new System.Drawing.Point(189, 83);
            this.cboMateria.Name = "cboMateria";
            this.cboMateria.Size = new System.Drawing.Size(170, 24);
            this.cboMateria.TabIndex = 16;
            // 
            // btnNuevoEstudiante
            // 
            this.btnNuevoEstudiante.Location = new System.Drawing.Point(469, 146);
            this.btnNuevoEstudiante.Name = "btnNuevoEstudiante";
            this.btnNuevoEstudiante.Size = new System.Drawing.Size(136, 40);
            this.btnNuevoEstudiante.TabIndex = 17;
            this.btnNuevoEstudiante.Text = "Nuevo Estudiante";
            this.btnNuevoEstudiante.UseVisualStyleBackColor = true;
            // 
            // btnNuevaMateria
            // 
            this.btnNuevaMateria.Location = new System.Drawing.Point(633, 145);
            this.btnNuevaMateria.Name = "btnNuevaMateria";
            this.btnNuevaMateria.Size = new System.Drawing.Size(129, 41);
            this.btnNuevaMateria.TabIndex = 18;
            this.btnNuevaMateria.Text = "Nueva Materia";
            this.btnNuevaMateria.UseVisualStyleBackColor = true;
            // 
            // frmCalificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 473);
            this.Controls.Add(this.btnNuevaMateria);
            this.Controls.Add(this.btnNuevoEstudiante);
            this.Controls.Add(this.cboMateria);
            this.Controls.Add(this.cboEstudiante);
            this.Controls.Add(this.dgvCalificaciones);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtNota3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCalificaciones";
            this.Text = "Control de Calificaciones";
            this.Load += new System.EventHandler(this.frmCalificaciones_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalificaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dgvCalificaciones;
        private System.Windows.Forms.ComboBox cboEstudiante;
        private System.Windows.Forms.ComboBox cboMateria;
        private System.Windows.Forms.Button btnNuevoEstudiante;
        private System.Windows.Forms.Button btnNuevaMateria;
    }
}

