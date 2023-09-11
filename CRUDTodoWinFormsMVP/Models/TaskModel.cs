using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CRUDTodoWinFormsMVP.Models
{
    public class TaskModel
    {
        //Fields
        private int id;
        private string title;
        private string description;
        private string statusTask;

        //Properties-Validations
        [DisplayName("Task ID")]
        public int Id { get => id; set => id = value; }

        [DisplayName("Title")]
        [Required(ErrorMessage = "Task name is required")]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "Task name must be between 3 and 15 characters")]
        public string Title { get => title; set => title = value; }

        [DisplayName("Description")]
        [Required(ErrorMessage = "Task description is required")]
        [StringLength(40, MinimumLength = 5, ErrorMessage = "Task description must be between 5 and 30 characters")]
        public string Description { get => description; set => description = value; }

        [DisplayName("Status")]
        [Required(ErrorMessage = "Task status is required")]
        [StringLength(40, MinimumLength = 5, ErrorMessage = "Task description must be between 5 and 30 characters")]
        public string StatusTask { get => statusTask; set => statusTask = value; }
    }
}
