namespace BranchingPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnDisplayGreeting_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Hello, {txtUserName.Text}!", "Greetings", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}