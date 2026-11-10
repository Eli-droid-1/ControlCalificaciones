using System;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmCalificaciones : Form
    {
        private CN_Calificaciones cn = new CN_Calificaciones();
        private int idSeleccionada = 0;

        public frmCalificaciones()
        {
            InitializeComponent();
            this.Load += FrmCalificaciones_Load;
            btnGuardar.Click += BtnGuardar_Click;
            btnActualizar.Click += BtnActualizar_Click;
            btnEliminar.Click += BtnEliminar_Click;
            btnLimpiar.Click += BtnLimpiar_Click;
            dgvCalificaciones.CellClick += dgvCalificaciones_CellClick;
            btnNuevoEstudiante.Click += BtnNuevoEstudiante_Click;
            btnNuevaMateria.Click += BtnNuevaMateria_Click;

            var btnAutores = new Button { Text = "Autores", Width = 90, Height = btnNuevaMateria.Height };
            btnAutores.Left = btnNuevaMateria.Right + 10;
            btnAutores.Top = btnNuevaMateria.Top;
            btnAutores.Click += (s, e) => new frmAutores().ShowDialog();
            btnNuevaMateria.Parent.Controls.Add(btnAutores);
        }

        private void FrmCalificaciones_Load(object sender, EventArgs e)
        {
            CargarCombos();
            Cargar();
        }
        private void CargarCombos()
        {
            cboEstudiante.DisplayMember = "nombre";
            cboEstudiante.ValueMember = "id_estudiante";
            cboEstudiante.DataSource = cn.ListarEstudiantes();
            cboEstudiante.SelectedIndex = -1;

            cboMateria.DisplayMember = "nombre_materia";
            cboMateria.ValueMember = "id_materia";
            cboMateria.DataSource = cn.ListarMaterias();
            cboMateria.SelectedIndex = -1;
        }

        private void Cargar()
        {
            dgvCalificaciones.DataSource = cn.Listar();
            FormatearGrid();
            Limpiar();
        }

        private void FormatearGrid()
        {
            dgvCalificaciones.Columns["id_calificacion"].Visible = false;
            dgvCalificaciones.Columns["id_estudiante"].Visible = false;
            dgvCalificaciones.Columns["id_materia"].Visible = false;
            //Titulos legibles
            dgvCalificaciones.Columns["carnet"].HeaderText = "Carnet";
            dgvCalificaciones.Columns["estudiante"].HeaderText = "Estudiante";
            dgvCalificaciones.Columns["nombre_materia"].HeaderText = "Materia";
            dgvCalificaciones.Columns["nota1"].HeaderText = "Nota 1";
            dgvCalificaciones.Columns["nota2"].HeaderText = "Nota 2";
            dgvCalificaciones.Columns["nota3"].HeaderText = "Nota 3";
            dgvCalificaciones.Columns["promedio"].HeaderText = "Promedio";
            dgvCalificaciones.Columns["estado"].HeaderText = "Estado";
            //columnas ocupen todo el anchor
            dgvCalificaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //comportamiento mas comodo
            dgvCalificaciones.RowHeadersVisible = false;
            dgvCalificaciones.ReadOnly = true;
            dgvCalificaciones.AllowUserToAddRows = false;
            dgvCalificaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCalificaciones.MultiSelect = false;
        }

        private void Limpiar()
        {
            cboEstudiante.SelectedIndex = -1;
            cboMateria.SelectedIndex = -1;
            txtNota1.Clear();
            txtNota2.Clear();
            txtNota3.Clear();
            idSeleccionada = 0;
            dgvCalificaciones.ClearSelection();
            cboEstudiante.Focus();
        }

        private bool LeerCampos(out int idEstudiante, out int idMateria,
                        out decimal nota1, out decimal nota2, out decimal nota3)
        {
            idEstudiante = 0; idMateria = 0; nota1 = 0; nota2 = 0; nota3 = 0;

            if (cboEstudiante.SelectedValue == null || cboMateria.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un estudiante y una materia.");
                return false;
            }

            idEstudiante = Convert.ToInt32(cboEstudiante.SelectedValue);
            idMateria = Convert.ToInt32(cboMateria.SelectedValue);

            if (!decimal.TryParse(txtNota1.Text, out nota1) ||
                !decimal.TryParse(txtNota2.Text, out nota2) ||
                !decimal.TryParse(txtNota3.Text, out nota3))
            {
                MessageBox.Show("Por favor ingrese notas válidas.");
                return false;
            }
            return true;
        }
        

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            int idEst, idMat;
            decimal n1, n2, n3;
            if (!LeerCampos(out idEst, out idMat, out n1, out n2, out n3)) return;

            try
            {
                cn.Insertar(idEst, idMat, n1, n2, n3);
                MessageBox.Show("Calificación guardada exitosamente.");
                Cargar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (idSeleccionada == 0)
            {
                MessageBox.Show("Seleccione una calificación para actualizar.");
                return;
            }
            int idEst, idMat;
            decimal n1, n2, n3;
            if (!LeerCampos(out idEst, out idMat, out n1, out n2, out n3)) return;

            try
            {
                cn.Actualizar(idSeleccionada, idEst, idMat, n1, n2, n3);
                MessageBox.Show("Calificación actualizada exitosamente.");
                Cargar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionada == 0)
            {
                MessageBox.Show("Seleccione una calificación para eliminar.");
                return;
            }

            DialogResult r = MessageBox.Show("¿Está seguro de eliminar esta calificación?", "Confirmar", MessageBoxButtons.YesNo);
            if (r != DialogResult.Yes) return;

            try
            {
                cn.Eliminar(idSeleccionada);
                MessageBox.Show("Calificación eliminada exitosamente.");
                Cargar();
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void BtnNuevoEstudiante_Click(object sender, EventArgs e)
        {
            using (frmNuevoEstudiante f = new frmNuevoEstudiante())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    CargarCombos();
                }
            }
        }

        private void BtnNuevaMateria_Click(object sender, EventArgs e)
        {
            using (frmNuevaMateria f = new frmNuevaMateria())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    CargarCombos();
                }
            }
        }
        private void dgvCalificaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow fila = dgvCalificaciones.Rows[e.RowIndex];
            idSeleccionada = Convert.ToInt32(fila.Cells["id_calificacion"].Value);
            cboEstudiante.SelectedValue = Convert.ToInt32(fila.Cells["id_estudiante"].Value);
            cboMateria.SelectedValue = Convert.ToInt32(fila.Cells["id_materia"].Value);
            txtNota1.Text = fila.Cells["nota1"].Value.ToString();
            txtNota2.Text = fila.Cells["nota2"].Value.ToString();
            txtNota3.Text = fila.Cells["nota3"].Value.ToString();
        }
        private void frmCalificaciones_Load_1(object sender, EventArgs e)
        {

        }
    }
}
