using CRUDTodoWinFormsMVP._Repositories;
using CRUDTodoWinFormsMVP.Models;
using CRUDTodoWinFormsMVP.Views;

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
            ITaskView view = TaskView.GetInstance((MainView)mainView);
            ITaskRepository repository = new TaskRepository(sqlConnectionString);
            new TaskPresenter(view, repository);
        }
    }
}
