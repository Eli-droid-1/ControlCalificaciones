using System;
using System.Drawing;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public class frmNuevaMateria : Form
    {
        private CN_Calificaciones cn = new CN_Calificaciones();
        private TextBox txtMateria = new TextBox();
        private Button btnGuardar = new Button();
        private Button btnCancelar = new Button();

        public frmNuevaMateria()
        {
            Text = "Nueva materia";
            ClientSize = new Size(320, 120);
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;

            Controls.Add(new Label { Text = "Materia:", Left = 15, Top = 20, Width = 80 });
            txtMateria.SetBounds(100, 17, 200, 23);
            Controls.Add(txtMateria);

            btnGuardar.Text = "Guardar";
            btnGuardar.SetBounds(100, 65, 95, 30);
            btnGuardar.Click += BtnGuardar_Click;
            Controls.Add(btnGuardar);

            btnCancelar.Text = "Cancelar";
            btnCancelar.SetBounds(205, 65, 95, 30);
            btnCancelar.Click += (s, e) => { DialogResult = DialogResult.Cancel; };
            Controls.Add(btnCancelar);

            AcceptButton = btnGuardar;
            CancelButton = btnCancelar;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                cn.InsertarMateria(txtMateria.Text);
                MessageBox.Show("Materia guardada exitosamente.");
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}