namespace login_page_winforms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
           string username=textBox1.Text;
           string password=textBox2.Text;
            if (username == "Aytac" && password == "aytac2004")
            {
                MessageBox.Show("Succesful");

            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
