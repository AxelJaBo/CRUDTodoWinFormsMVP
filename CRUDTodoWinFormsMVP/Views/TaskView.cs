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
    public partial class TaskView : Form, ITaskView
    {
        //Fields
        private string message;
        private bool isSuccessful;
        private bool isEdit;
        private readonly string sqlConnectionString;

        //Constructor
        public TaskView(string sqlConnectionString)
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPageTaskDetail);
            this.sqlConnectionString = sqlConnectionString;
        }

        private void AssociateAndRaiseViewEvents()
        {
            //Search
            btnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };
            //Add new
            btnAddNew.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageTaskList);
                tabControl1.TabPages.Add(tabPageTaskDetail);
                tabPageTaskDetail.Text = "Add new task";
            };
            //Edit
            btnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageTaskList);
                tabControl1.TabPages.Add(tabPageTaskDetail);
                tabPageTaskDetail.Text = "Edit task";
            };
            //Save changes
            btnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    tabControl1.TabPages.Remove(tabPageTaskDetail);
                    tabControl1.TabPages.Add(tabPageTaskList);
                }
                MessageBox.Show(Message);
            };
            //Cancel
            btnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageTaskDetail);
                tabControl1.TabPages.Add(tabPageTaskList);
            };
            //Delete
            btnDelete.Click += delegate
            {
                var result = MessageBox.Show("Are you sure you want to delete the selected task?", "Waning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };
        }

        public string TaskId { get => txtTaskId.Text; set => txtTaskId.Text = value; }
        public string TaskTitle { get => txtTaskTitle.Text; set => txtTaskTitle.Text = value; }
        public string TaskDescription { get => txtTaskDescription.Text; set => txtTaskDescription.Text = value; }
        public string TaskStatus { get => cbStatus.Text; set => cbStatus.Text = value; }
        public string SearchValue { get => txtSearch.Text; set => txtSearch.Text = value; }
        public bool IsEdit { get => isEdit; set => isEdit = value; }
        public bool IsSuccessfull { get => isSuccessful; set => isSuccessful = value; }
        public string Message { get => message; set => message = value; }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        //Methods
        public void SetTaskListBindingSource(BindingSource taskList)
        {
            dataGridView1.DataSource = taskList;
        }

        //Singleton pattern (Open a single form instance)
        private static TaskView instance;
        public static View GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new TaskView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }
            return instance;
        }
    }
}
