using ToDoGestion.Data;

namespace ToDoGestion
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Create BD if not exists
            using (var db = new AppDbContext())
            {
                db.Database.EnsureCreated();
            }

            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}