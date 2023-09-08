using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CRUDTodoWinFormsMVP.Models
{
    public class TaskModel
    {
        //Fields
        private int id;
        private string title;
        private string description;
        private bool isCompleted;

        //Properties-Validations
        [DisplayName("Tasj ID")]
        public int Id { get => id; set => id = value; }

        [DisplayName("Title")]
        [Required(ErrorMessage = "Task name is required")]
        [StringLength(15, MinimumLength =3, ErrorMessage = "Task name must be between 3 and 15 characters")]
        public string Title { get => title; set => title = value; }

        [DisplayName("Description")]
        [Required(ErrorMessage = "Task description is required")]
        [StringLength(40, MinimumLength = 10, ErrorMessage = "Task description must be between 10 and 40 characters")]
        public string Description { get => description; set => description = value; }

        public bool IsCompleted { get => isCompleted; set => isCompleted = value; }
    }
}
