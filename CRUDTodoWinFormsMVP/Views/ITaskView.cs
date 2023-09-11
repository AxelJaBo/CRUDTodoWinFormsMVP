using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDTodoWinFormsMVP.Views
{
    public interface ITaskView
    {
        //Properties - Fields
        string TaskId { get; set; }
        string TaskTitle { get; set; }
        string TaskDescription { get; set; }
        string TaskStatus { get; set; }

        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessfull { get; set; }
        string Message { get; set; }

        //Events
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        //Methods
        void SetTaskListBindingSource(BindingSource taskList);
        void Show();//Optional
    }
}
