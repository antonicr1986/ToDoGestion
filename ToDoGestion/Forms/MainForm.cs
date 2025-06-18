using ToDoGestion.Data;
using ToDoGestion.Models;
using System;
using System.Linq;
using System.Windows.Forms;

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
            var tareas = db.Tasks.ToList();
            dataGridViewTasks.DataSource = tareas;
        }

        private void BtnAdd_Click (object sender, EventArgs e)
        {
            //Open Form for Add Task
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewTasks.CurrentRow != null)
            {          
                int id = (int)dataGridViewTasks.CurrentRow.Cells["Id"].Value;
                using var db = new AppDbContext();
                var tarea = db.Tasks.Find(id);
                if (tarea != null)
                {
                    db.Tasks.Remove(tarea);
                    db.SaveChanges();
                    LoadTasks();
                }
            }
        }

    }
}
