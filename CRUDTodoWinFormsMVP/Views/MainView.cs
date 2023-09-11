using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDTodoWinFormsMVP.Views
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
            btnTasks.Click += delegate { ShowTaskView?.Invoke(this, EventArgs.Empty); };
        }

        public event EventHandler ShowTaskView;
    }
}

