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
    public partial class FormEditTask : Form
    {

        private TaskServices _service;
        private Tarea _tarea;


        public FormEditTask(Tarea tarea)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _service = new TaskServices();
            _tarea = tarea;

            textBoxTitulo.Text = _tarea.Titulo;
            textBoxDescripcion.Text = _tarea.Descripcion;
            checkBoxCompletada.Checked = _tarea.Completada;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _tarea.Titulo = textBoxTitulo.Text;
            _tarea.Descripcion = textBoxDescripcion.Text;
            _tarea.Completada = checkBoxCompletada.Checked;

            _service.EditarTarea(_tarea);
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
