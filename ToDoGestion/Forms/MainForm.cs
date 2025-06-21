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
        public MainForm()
        {
            InitializeComponent();
            LoadTasks();
        }

        private void LoadTasks()
        {
            using var db = new AppDbContext();
            var tareas = db.Tareas.ToList();
            dataGridViewTasks.DataSource = tareas;
        }

        private void BtnAdd_Click (object sender, EventArgs e)
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
