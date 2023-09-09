using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CRUDTodoWinFormsMVP.Models;

namespace CRUDTodoWinFormsMVP._Repositories
{
    public class TaskRepository : BaseRepository, ITaskRepository
    {
        public TaskRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void AddTask(TaskModel taskModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "insert into Task values (@title, @description @status)";
                command.Parameters.Add("@title", SqlDbType.NVarChar).Value = taskModel.Title;
                command.Parameters.Add("@description", SqlDbType.NVarChar).Value = taskModel.Description;
                command.Parameters.Add("@status", SqlDbType.NVarChar).Value = taskModel.StatusTask;
                command.ExecuteNonQuery();
            }
        }
        public void EditTask(TaskModel taskModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"update Task set Task_Name=@title, Task_Description=@description, Task_Status=@status where Task_Id=@id";
                command.Parameters.Add("@title", SqlDbType.NVarChar).Value = taskModel.Title;
                command.Parameters.Add("@description", SqlDbType.NVarChar).Value = taskModel.Description;
                command.Parameters.Add("@status", SqlDbType.NVarChar).Value = taskModel.StatusTask;
                command.Parameters.Add("@id", SqlDbType.Int).Value = taskModel.Id;
                command.ExecuteNonQuery();
            }
        }
        public void DeleteTask(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "delete from Task where Task_Id=@id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        IEnumerable<TaskModel> ITaskRepository.GetAllTasks()
        {
            var taskList = new List<TaskModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * from Task order by Task_Id desc";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var taskModel = new TaskModel();
                        taskModel.Id = (int)reader[0];
                        taskModel.Title = reader[1].ToString();
                        taskModel.Description = reader[2].ToString();
                        taskModel.StatusTask = reader[3].ToString();
                        taskList.Add(taskModel);
                    }
                }
            }
            return taskList;
        }
    }
}
