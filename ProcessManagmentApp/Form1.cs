using System.Diagnostics;

namespace ProcessManagmentApp
{
    public partial class Form1 : Form
    {
        Process[] processCollection;
        Process process;

        ListViewItem item;

        public Form1()
        {
            InitializeComponent();
        }

        private void setAsListView()
        {
            processCollection = Process.GetProcesses();
            String[] arr = new string[3];
            ListViewItem itm;
            int counter = 1;
            foreach (Process p in processCollection)
            {
                arr[0] = Convert.ToString(counter++);
                arr[1] = Convert.ToString(p.ProcessName);
                arr[2] = Convert.ToString(p.Id);

                itm = new ListViewItem(arr);
                itm.Tag = p;
                listView1.Items.Add(itm);
            }
        }

        private void loadProcessList() // Initialize and load the list of processes
        {
            listView1.Items.Clear();
            txtProcess.Text = "";
            if (txtProcess.Text == "")
            {
                txtProcess.Text = "Enter a process name or process ID or choose from the list and then click End task";
                txtProcess.ForeColor = Color.DarkGray;
            }
            setAsListView();
            lblTasksCounter.Text = Convert.ToString(listView1.Items.Count);

        }

        private void Form1_Load(object sender, EventArgs e)
        { 
            loadProcessList();
            txtProcess.Text = "Enter a process name or process ID or choose from the list and then click End task";
            txtProcess.ForeColor = Color.DarkGray;
        }

        private void txtProcess_Enter(object sender, EventArgs e) // Clicking on the text box will cause the user instructions to disappear
        {
            if(txtProcess.Text == "Enter a process name or process ID or choose from the list and then click End task")
            {
                txtProcess.Text = "";
                txtProcess.ForeColor = Color.Black;
            }
        }

        private void txtProcess_Leave(object sender, EventArgs e) // If no text has been entered into the box and the user has left the text box, the user instructions will be displayed again
        {
            if (txtProcess.Text == "")
            {
                txtProcess.Text = "Enter a process name or process ID or choose from the list and then click End task";
                txtProcess.ForeColor = Color.DarkGray;
            }
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e) // To select a process from the list by clicking on the line of that process
        {
            item = listView1.SelectedItems[0];
            process = (Process)item.Tag;
            txtProcess.Text = process.ProcessName; // Enter the name of the selected process in the text box
            txtProcess.ForeColor = Color.Black;
        }

        private void btbReload_Click(object sender, EventArgs e) //Initialize the list of active processes
        {
            loadProcessList();
        }

        private void btnEndTask_Click_1(object sender, EventArgs e) // Closing a selected process
        {
            if (txtProcess.Text == "Enter a process name or process ID or choose from the list and then click End task") // If no input is entered, a message will be displayed to the user
                MessageBox.Show("Please select a process that you want to end", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else
            {
                if (listView1.FindItemWithText(txtProcess.Text) == null) // If the requested process is not found, a message will be displayed to the user
                    MessageBox.Show("The Process " + txtProcess.Text + " doesn't exists", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else // If the requested process is found, it will be closed
                {
                    int index = listView1.FindItemWithText(txtProcess.Text).Index;
                    process = processCollection[index];
                    process.Kill();
                    loadProcessList();
                }
            }
        }
    }
}