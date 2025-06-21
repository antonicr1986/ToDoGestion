using ToDoGestion.Data;
using ToDoGestion.Models;
using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Linq;

namespace GestorDeTareas.Services
{
    public class TaskServices
    {
        private readonly AppDbContext _context;

        public TaskServices()
        {
            _context = new AppDbContext();
            _context.Database.EnsureCreated();
        }

        public List<Tarea> ObtenerTareas() => _context.Tareas.ToList();

        public void AgregarTarea(Tarea tarea)
        {
            _context.Tareas.Add(tarea);
            _context.SaveChanges();
        }

        public void EditarTarea(Tarea tarea)
        {
            _context.Tareas.Update(tarea);
            _context.SaveChanges();
        }

        public void EliminarTarea(int id)
        {
            var tarea = _context.Tareas.Find(id);
            if (tarea != null)
            {
                _context.Tareas.Remove(tarea);
                _context.SaveChanges();
            }
        }
    }
}
