using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUDTodoWinFormsMVP.Views;
using CRUDTodoWinFormsMVP.Models;
using CRUDTodoWinFormsMVP._Repositories;

namespace CRUDTodoWinFormsMVP.Presenters
{
    public class MainPresenter
    {
        private IMainView mainView;
        private readonly string sqlConnectionString;

        public MainPresenter(IMainView mainView, string sqlConnectionString)
        {
            this.mainView = mainView;
            this.sqlConnectionString = sqlConnectionString;
            this.mainView.ShowTaskView += ShowTasksView;
        }

        private void ShowTasksView(object? sender, EventArgs e)
        {
            ITaskView view = TaskView.GetInstance((MainView);
            ITaskRepository repository = new TaskRepository(sqlConnectionString);
            new TaskPresenter(view, repository);
        }
    }
}
