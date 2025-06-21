using GestorDeTareas.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoGestion.Models;

namespace ToDoGestion.Forms
{
    public partial class FormAddTask : Form
    {
        private TaskServices _service;


        public FormAddTask()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _service = new TaskServices();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var nuevaTarea = new Tarea
            {
                Titulo = textBoxTitulo.Text,
                Descripcion = textBoxDescripcion.Text,
                Completada = checkBoxCompletada.Checked
            };
            _service.AgregarTarea(nuevaTarea);
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
