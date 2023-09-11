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

