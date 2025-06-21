using GestorDeTareas.Services;
using System;
using System.Linq;
using System.Windows.Forms;
using ToDoGestion.Data;
using ToDoGestion.Forms;
using ToDoGestion.Models;

namespace ToDoGestion
{
    public partial class MainForm : Form
    {

        private TaskServices _service;

        public MainForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _service = new TaskServices();
            LoadTasks();
        }

        private void LoadTasks()
        {
            using var db = new AppDbContext();
            var tareas = db.Tareas.ToList();
            dataGridViewTasks.DataSource = tareas;

            // Ocultar la columna "Id"
            if (dataGridViewTasks.Columns.Contains("Id"))
            {
                dataGridViewTasks.Columns["Id"].Visible = false;
            }

            // Ajuste automático de columnas y filas
            dataGridViewTasks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Esperar a que se ajusten los tamaños y luego ajustar el ancho del DataGridView
            dataGridViewTasks.Refresh();

            int totalWidth = 0;
            foreach (DataGridViewColumn col in dataGridViewTasks.Columns)
            {
                if (col.Visible)
                    totalWidth += col.Width;
            }

            totalWidth += 4; // margen extra

            dataGridViewTasks.Width = totalWidth;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var form = new FormAddTask();
            form.ShowDialog();
            LoadTasks();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewTasks.CurrentRow?.DataBoundItem is Tarea tarea)
            {
                var form = new FormEditTask(tarea);
                form.ShowDialog();
                LoadTasks();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewTasks.CurrentRow?.DataBoundItem is Tarea tarea)
            {
                _service.EliminarTarea(tarea.Id);
                LoadTasks();
            }
        }
    }
}
