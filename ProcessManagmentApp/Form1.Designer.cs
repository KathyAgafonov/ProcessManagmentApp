namespace ProcessManagmentApp
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.txtProcess = new System.Windows.Forms.TextBox();
            this.btbEndTask = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lblTasksCounter = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btbReload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(-4, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(582, 376);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "";
            this.columnHeader3.Width = 41;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 270;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "PID";
            this.columnHeader2.Width = 270;
            // 
            // txtProcess
            // 
            this.txtProcess.ForeColor = System.Drawing.Color.DarkGray;
            this.txtProcess.Location = new System.Drawing.Point(3, 412);
            this.txtProcess.Name = "txtProcess";
            this.txtProcess.Size = new System.Drawing.Size(461, 23);
            this.txtProcess.TabIndex = 3;
            this.txtProcess.TabStop = false;
            this.txtProcess.Text = "Enter a process name or process ID or choose from the list and then click End tas" +
    "k";
            this.txtProcess.Enter += new System.EventHandler(this.txtProcess_Enter);
            this.txtProcess.Leave += new System.EventHandler(this.txtProcess_Leave);
            // 
            // btbEndTask
            // 
            this.btbEndTask.Location = new System.Drawing.Point(496, 412);
            this.btbEndTask.Name = "btbEndTask";
            this.btbEndTask.Size = new System.Drawing.Size(75, 24);
            this.btbEndTask.TabIndex = 4;
            this.btbEndTask.Text = "End task";
            this.btbEndTask.UseVisualStyleBackColor = true;
            this.btbEndTask.Click += new System.EventHandler(this.btnEndTask_Click_1);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(3, 464);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total open tasks: ";
            // 
            // lblTasksCounter
            // 
            this.lblTasksCounter.AutoSize = true;
            this.lblTasksCounter.Location = new System.Drawing.Point(106, 464);
            this.lblTasksCounter.Name = "lblTasksCounter";
            this.lblTasksCounter.Size = new System.Drawing.Size(0, 15);
            this.lblTasksCounter.TabIndex = 7;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(-1, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(678, 407);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(670, 379);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Processes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btbReload
            // 
            this.btbReload.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btbReload.Location = new System.Drawing.Point(496, 459);
            this.btbReload.Name = "btbReload";
            this.btbReload.Size = new System.Drawing.Size(75, 24);
            this.btbReload.TabIndex = 9;
            this.btbReload.Text = "Reload";
            this.btbReload.UseVisualStyleBackColor = true;
            this.btbReload.Click += new System.EventHandler(this.btbReload_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 492);
            this.Controls.Add(this.btbReload);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtProcess);
            this.Controls.Add(this.lblTasksCounter);
            this.Controls.Add(this.btbEndTask);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Task Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private TextBox txtProcess;
        private Button btbEndTask;
        private ErrorProvider errorProvider1;
        private ColumnHeader columnHeader3;
        private Label lblTasksCounter;
        private Label label2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btbReload;
    }
}