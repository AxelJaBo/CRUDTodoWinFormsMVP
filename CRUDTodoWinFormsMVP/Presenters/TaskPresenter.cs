using CRUDTodoWinFormsMVP.Models;
using CRUDTodoWinFormsMVP.Views;

namespace CRUDTodoWinFormsMVP.Presenters
{
    public class TaskPresenter
    {
        //Fields
        private ITaskView view;
        private ITaskRepository repository;
        private BindingSource tasksBindingSource;
        private IEnumerable<TaskModel> taskList;

        public TaskPresenter(ITaskView view, ITaskRepository repository)
        {
            this.tasksBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;
            //Subscribe event handler methods to view events
            this.view.SearchEvent += SearchTask;
            this.view.AddNewEvent += AddNewTask;
            this.view.EditEvent += LoadSelectedTaskToEdit;
            this.view.DeleteEvent += DeleteSelectedTask;
            this.view.SaveEvent += SaveTask;
            this.view.CancelEvent += CancelAction;
            //Set pets binding source
            this.view.SetTaskListBindingSource(tasksBindingSource);
            //Load pet list view
            LoadAllTaskList();
            //Show view
            this.view.Show();
        }

        //Methods
        private void LoadAllTaskList()
        {
            taskList = repository.GetAllTasks();
            tasksBindingSource.DataSource = taskList;//Set data source
        }
        private void SearchTask(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
                taskList = repository.GetByValue(this.view.SearchValue);
            else taskList = repository.GetAllTasks();
            tasksBindingSource.DataSource = taskList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanviewFields();
        }

        private void SaveTask(object? sender, EventArgs e)
        {
            var model = new TaskModel();
            model.Id = Convert.ToInt32(view.TaskId);
            model.Title = view.TaskTitle;
            model.Description = view.TaskDescription;
            model.StatusTask = view.TaskStatus;
            try
            {
                new Common.ModelDataValidation().Validate(model);
                if (view.IsEdit)//Edit model
                {
                    repository.EditTask(model);
                    view.Message = "Task edited successfuly";
                }
                else //Add new model
                {
                    repository.AddTask(model);
                    view.Message = "Task added successfully";
                }
                view.IsSuccessfull = true;
                LoadAllTaskList();
                CleanviewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessfull = false;
                view.Message = ex.Message;
            }
        }

        private void CleanviewFields()
        {
            view.TaskId = "0";
            view.TaskTitle = "";
            view.TaskDescription = "";
            view.TaskStatus = "";
        }

        private void DeleteSelectedTask(object? sender, EventArgs e)
        {
            try
            {
                var task = (TaskModel)tasksBindingSource.Current;
                repository.DeleteTask(task.Id);
                view.IsSuccessfull = true;
                view.Message = "Task deleted successfully";
                LoadAllTaskList();
            }
            catch (Exception ex)
            {
                view.IsSuccessfull = false;
                view.Message = "An error ocurred, could not delete task";
            }
        }

        private void LoadSelectedTaskToEdit(object? sender, EventArgs e)
        {
            var task = (TaskModel)tasksBindingSource.Current;
            view.TaskId = task.Id.ToString();
            view.TaskTitle = task.Title;
            view.TaskDescription = task.Description;
            view.TaskStatus = task.StatusTask;
            view.IsEdit = true;
        }

        private void AddNewTask(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }
    }
}
