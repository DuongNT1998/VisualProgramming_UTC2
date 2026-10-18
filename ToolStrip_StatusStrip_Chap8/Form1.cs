namespace ToolStrip_Chap8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Open clicked";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Save clicked";
        }

        private void dropDown_Click(object sender, EventArgs e)
        {
            ToolStripItem clickedItem = sender as ToolStripItem;

            if (clickedItem != null)
            {
                if (clickedItem.Text == "Option A")
                {
                    lblStatus.Text = "Option A selected";
                }
                else if (clickedItem.Text == "Option B")
                {
                    lblStatus.Text = "Option B selected";
                }
                else if (clickedItem.Text == "Option C")
                {
                    lblStatus.Text = "Option C selected";
                }
            }
        }

        private void toolComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblStatus.Text = "Priority: " + toolComboBox.SelectedItem;
        }

        private void toolTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                lblStatus.Text = "Entered: " + toolTextBox.Text;
        }

        private void splitButton_ButtonClick(object sender, EventArgs e)
        {
            lblStatus.Text = "Split button clicked";
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Tool A chosen";
        }

        private void toolBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Tool B chosen";
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Setting clicked";
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Help information here");
        }
        

    }
}

