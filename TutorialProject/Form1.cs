namespace TutorialProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = "Last Name";
            label3.Text = "Full Name";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show($"Hello {textBox1.Text} {textBox2.Text}!");
            //textBox3.Text = ("Hello {textBox1.Text} {textBox2.Tex t}!");
            //progressBar1.Value += 10;
            //Form2 frm = new();
            //frm.Show();
            toolStripProgressBar1.Value += 5;
            toolStripStatusLabel1.Text = "Working...";
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created By Tim");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}