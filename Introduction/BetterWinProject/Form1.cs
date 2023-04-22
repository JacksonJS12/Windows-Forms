namespace BetterWinProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sayHelloBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Hello {firstNameTextBox.Text} {lastNameTextBox.Text}!");
        }
    }
}