﻿namespace CRUDTodoWinFormsMVP.Views
{
    partial class TaskView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            txtSearch = new TextBox();
            tabControl1 = new TabControl();
            tabPageTaskList = new TabPage();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAddNew = new Button();
            btnSearch = new Button();
            dataGridView1 = new DataGridView();
            tabPageTaskDetail = new TabPage();
            btnCancel = new Button();
            btnSave = new Button();
            cbStatus = new ComboBox();
            txtTaskDescription = new TextBox();
            txtTaskTitle = new TextBox();
            txtTaskId = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPageTaskList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPageTaskDetail.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(549, 100);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(142, 30);
            label1.Name = "label1";
            label1.Size = new Size(169, 37);
            label1.TabIndex = 0;
            label1.Text = "TODO TASKS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(8, 3);
            label2.Name = "label2";
            label2.Size = new Size(74, 28);
            label2.TabIndex = 1;
            label2.Text = "Search:";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(88, 6);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(282, 25);
            txtSearch.TabIndex = 2;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageTaskList);
            tabControl1.Controls.Add(tabPageTaskDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 100);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(549, 350);
            tabControl1.TabIndex = 1;
            // 
            // tabPageTaskList
            // 
            tabPageTaskList.Controls.Add(btnDelete);
            tabPageTaskList.Controls.Add(btnEdit);
            tabPageTaskList.Controls.Add(btnAddNew);
            tabPageTaskList.Controls.Add(btnSearch);
            tabPageTaskList.Controls.Add(dataGridView1);
            tabPageTaskList.Controls.Add(txtSearch);
            tabPageTaskList.Controls.Add(label2);
            tabPageTaskList.Location = new Point(4, 24);
            tabPageTaskList.Name = "tabPageTaskList";
            tabPageTaskList.Padding = new Padding(3);
            tabPageTaskList.Size = new Size(541, 322);
            tabPageTaskList.TabIndex = 0;
            tabPageTaskList.Text = "Task List";
            tabPageTaskList.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(457, 71);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 28);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.Location = new Point(457, 37);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 28);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAddNew
            // 
            btnAddNew.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddNew.Location = new Point(457, 3);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(75, 28);
            btnAddNew.TabIndex = 5;
            btnAddNew.Text = "Add";
            btnAddNew.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.Location = new Point(376, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 28);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(8, 37);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(443, 277);
            dataGridView1.TabIndex = 3;
            // 
            // tabPageTaskDetail
            // 
            tabPageTaskDetail.Controls.Add(btnCancel);
            tabPageTaskDetail.Controls.Add(btnSave);
            tabPageTaskDetail.Controls.Add(cbStatus);
            tabPageTaskDetail.Controls.Add(txtTaskDescription);
            tabPageTaskDetail.Controls.Add(txtTaskTitle);
            tabPageTaskDetail.Controls.Add(txtTaskId);
            tabPageTaskDetail.Controls.Add(label6);
            tabPageTaskDetail.Controls.Add(label5);
            tabPageTaskDetail.Controls.Add(label4);
            tabPageTaskDetail.Controls.Add(label3);
            tabPageTaskDetail.Location = new Point(4, 24);
            tabPageTaskDetail.Name = "tabPageTaskDetail";
            tabPageTaskDetail.Padding = new Padding(3);
            tabPageTaskDetail.Size = new Size(541, 322);
            tabPageTaskDetail.TabIndex = 1;
            tabPageTaskDetail.Text = "Task Detail";
            tabPageTaskDetail.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Location = new Point(352, 242);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 29);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(271, 242);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 29);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // cbStatus
            // 
            cbStatus.AutoCompleteCustomSource.AddRange(new string[] { "earrings", "in progress", "completed" });
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "Pendiente", "En Proceso", "Finalizada" });
            cbStatus.Location = new Point(208, 202);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(219, 23);
            cbStatus.TabIndex = 8;
            // 
            // txtTaskDescription
            // 
            txtTaskDescription.Location = new Point(208, 81);
            txtTaskDescription.Multiline = true;
            txtTaskDescription.Name = "txtTaskDescription";
            txtTaskDescription.Size = new Size(219, 115);
            txtTaskDescription.TabIndex = 6;
            // 
            // txtTaskTitle
            // 
            txtTaskTitle.Location = new Point(208, 52);
            txtTaskTitle.Name = "txtTaskTitle";
            txtTaskTitle.Size = new Size(219, 23);
            txtTaskTitle.TabIndex = 5;
            // 
            // txtTaskId
            // 
            txtTaskId.Location = new Point(208, 23);
            txtTaskId.Name = "txtTaskId";
            txtTaskId.Size = new Size(219, 23);
            txtTaskId.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(85, 197);
            label6.Name = "label6";
            label6.Size = new Size(69, 28);
            label6.TabIndex = 3;
            label6.Text = "Status:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(78, 80);
            label5.Name = "label5";
            label5.Size = new Size(116, 28);
            label5.TabIndex = 2;
            label5.Text = "Description:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(78, 52);
            label4.Name = "label4";
            label4.Size = new Size(53, 28);
            label4.TabIndex = 1;
            label4.Text = "Title:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(78, 24);
            label3.Name = "label3";
            label3.Size = new Size(76, 28);
            label3.TabIndex = 0;
            label3.Text = "Task ID:";
            // 
            // TaskView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "TaskView";
            Text = "TaskView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPageTaskList.ResumeLayout(false);
            tabPageTaskList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPageTaskDetail.ResumeLayout(false);
            tabPageTaskDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtSearch;
        private Label label2;
        private TabControl tabControl1;
        private TabPage tabPageTaskList;
        private TabPage tabPageTaskDetail;
        private DataGridView dataGridView1;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAddNew;
        private Button btnSearch;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox cbStatus;
        private TextBox txtTaskDescription;
        private TextBox txtTaskTitle;
        private TextBox txtTaskId;
        private Button btnCancel;
        private Button btnSave;
    }
}