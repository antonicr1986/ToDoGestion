namespace ToDoGestion
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewTasks = new DataGridView();
            buttonAdd = new Button();
            buttonDelete = new Button();
            buttonEditTask = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTasks).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewTasks
            // 
            dataGridViewTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTasks.Location = new Point(12, 12);
            dataGridViewTasks.Name = "dataGridViewTasks";
            dataGridViewTasks.Size = new Size(556, 150);
            dataGridViewTasks.TabIndex = 0;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(301, 192);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Add Task";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += BtnAdd_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(493, 192);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "Delete Task";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += btnDelete_Click;
            // 
            // buttonEditTask
            // 
            buttonEditTask.Location = new Point(403, 192);
            buttonEditTask.Name = "buttonEditTask";
            buttonEditTask.Size = new Size(75, 23);
            buttonEditTask.TabIndex = 3;
            buttonEditTask.Text = "Edit Task";
            buttonEditTask.UseVisualStyleBackColor = true;
            buttonEditTask.Click += btnEditar_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 237);
            Controls.Add(buttonEditTask);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridViewTasks);
            Name = "MainForm";
            Text = "Gestor de tareas";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTasks).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewTasks;
        private Button buttonAdd;
        private Button buttonDelete;
        private Button buttonEditTask;
    }
}
