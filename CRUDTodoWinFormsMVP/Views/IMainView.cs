using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDTodoWinFormsMVP.Views
{
    public interface IMainView
    {
        event EventHandler ShowTaskView;
    }
}
