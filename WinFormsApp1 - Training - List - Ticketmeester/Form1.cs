namespace WinFormsApp1___Training___List___Ticketmeester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void HellowWorldBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Hello { HelloWorldTB.Text }");
        }
    }
}