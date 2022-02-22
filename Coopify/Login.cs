namespace Coopify
{
    public partial class Login : Form
    {
        private readonly DBConnect db = new();
        public Login()
        {
            InitializeComponent();
            this.ActiveControl = this.txt_user;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            LoginAccount();
        }
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login_Closing();
        }
        private void txt_user_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                this.ActiveControl = this.txt_pass;
        }
        private void txt_pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                LoginAccount();
        }
        private void LoginAccount()
        {
            try
            {
                string usr = this.txt_user.Text,
                        pass = this.txt_pass.Text,
                        query = "select * from accounts where username ='" + usr + "' and password = '" + pass + "';";
                List<string>[] result = db.Select(query, new string[] { "username", "password" });
                if (usr.Equals(result[0][0] + "") && pass.Equals(result[1][0] + ""))
                {
                    //MessageBox.Show("Hello, "+result[0][0]);
                    new MainMenu(this).Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid user please try again!");
                    this.txt_user.Clear();
                    this.txt_pass.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Login_Closing()
        {
            this.Dispose();
        }
    }
}