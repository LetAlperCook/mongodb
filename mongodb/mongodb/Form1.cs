namespace mongodb
{
    public partial class Form1 : Form
    {
        string username_input, password_input = "";
        string correct_username = "admin";
        string correct_password = "alperkaan3131";
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            username_input = usernameTB.Text;
            password_input = passwordTB.Text;
            if (username_input.Equals(correct_username) && password_input.Equals(correct_password)) { MessageBox.Show($"Ho�geldiniz {username_input} Bey/Han�m"); }
            else { MessageBox.Show("Hatal� Giri�"); }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) { passwordTB.UseSystemPasswordChar = true; }
            else { passwordTB.UseSystemPasswordChar = false; }
        }
    }
}