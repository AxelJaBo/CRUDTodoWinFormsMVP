namespace CRUDTodoWinFormsMVP.Models
{
    public interface ITaskRepository
    {
        void AddTask(TaskModel taskModel);
        void EditTask(TaskModel taskModel);
        void DeleteTask(int id);
        IEnumerable<TaskModel> GetAllTasks();
        IEnumerable<TaskModel> GetByValue(string value);//Searchs
    }
}
