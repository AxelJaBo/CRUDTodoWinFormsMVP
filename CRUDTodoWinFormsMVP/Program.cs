using System.Configuration;
using CRUDTodoWinFormsMVP._Repositories;
using CRUDTodoWinFormsMVP.Models;
using CRUDTodoWinFormsMVP.Presenters;
using CRUDTodoWinFormsMVP.Views;

namespace CRUDTodoWinFormsMVP
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            string sqlConnectionString = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;
            ITaskView view = new TaskView();
            ITaskRepository repository = new TaskRepository(sqlConnectionString);
            new TaskPresenter(view, repository);
            Application.Run((Form)view);
        }
    }
}