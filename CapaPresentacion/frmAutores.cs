using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public class frmAutores : Form
    {
        public frmAutores()
        {
            Text = "Autores del proyecto";
            ClientSize = new Size(480, 300);
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;

            Controls.Add(new Label
            {
                Text = "Proyecto: Control de Calificaciones",
                Left = 15,
                Top = 15,
                Width = 440,
                Font = new Font("Segoe UI", 11, FontStyle.Bold)
            });

            var dgv = new DataGridView
            {
                Left = 15,
                Top = 50,
                Width = 450,
                Height = 190,
                ReadOnly = true,
                AllowUserToAddRows = false,
                RowHeadersVisible = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect
            };
            dgv.Columns.Add("nombre", "Nombre");
            dgv.Columns.Add("carnet", "Carnet");
            dgv.Columns.Add("rol", "Rol");

            // CAMBIEN ESTOS DATOS POR LOS DEL GRUPO
            dgv.Rows.Add("Valeria Magaña", "261274", "Base de datos, lógica e integración");
            dgv.Rows.Add("Debbie Navarrete", "260016", "Diseño de interfaz");
            
            Controls.Add(dgv);

            var btnCerrar = new Button { Text = "Cerrar", Left = 370, Top = 255, Width = 95, Height = 30 };
            btnCerrar.Click += (s, e) => Close();
            Controls.Add(btnCerrar);
            CancelButton = btnCerrar;
        }
    }
}