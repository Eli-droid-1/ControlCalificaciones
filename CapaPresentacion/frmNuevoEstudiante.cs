using System;
using System.Drawing;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public class frmNuevoEstudiante : Form
    {
        private CN_Calificaciones cn = new CN_Calificaciones();
        private TextBox txtCarnet = new TextBox();
        private TextBox txtNombres = new TextBox();
        private TextBox txtApellidos = new TextBox();
        private Button btnGuardar = new Button();
        private Button btnCancelar = new Button();

        public frmNuevoEstudiante()
        {
            Text = "Nuevo estudiante";
            ClientSize = new Size(320, 190);
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;

            Controls.Add(new Label { Text = "Carnet:", Left = 15, Top = 20, Width = 80 });
            txtCarnet.SetBounds(100, 17, 200, 23);
            Controls.Add(txtCarnet);

            Controls.Add(new Label { Text = "Nombres:", Left = 15, Top = 55, Width = 80 });
            txtNombres.SetBounds(100, 52, 200, 23);
            Controls.Add(txtNombres);

            Controls.Add(new Label { Text = "Apellidos:", Left = 15, Top = 90, Width = 80 });
            txtApellidos.SetBounds(100, 87, 200, 23);
            Controls.Add(txtApellidos);

            btnGuardar.Text = "Guardar";
            btnGuardar.SetBounds(100, 135, 95, 30);
            btnGuardar.Click += BtnGuardar_Click;
            Controls.Add(btnGuardar);

            btnCancelar.Text = "Cancelar";
            btnCancelar.SetBounds(205, 135, 95, 30);
            btnCancelar.Click += (s, e) => { DialogResult = DialogResult.Cancel; };
            Controls.Add(btnCancelar);

            AcceptButton = btnGuardar;
            CancelButton = btnCancelar;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                cn.InsertarEstudiante(txtCarnet.Text, txtNombres.Text, txtApellidos.Text);
                MessageBox.Show("Estudiante guardado exitosamente.");
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}