namespace recycling
{
    public partial class startSite : Form
    {
        public startSite()
        {
            InitializeComponent();
            logInPage.Visible = false;
            signUpPage.Visible = false;
            parentBox.Checked = false;
            Globals.i = -1;
        }

        public static class Globals
        {
            public static string name;
            public static string password;
            public static string status;
            public static int statmentClick;
            public static int buttonClick;
            public static int i;
        }

        private void logIn_Click(object sender, EventArgs e)
        {
            startMenu.Visible = false;
            logInPage.Visible = true;

        }

        private void returnStartM_Click(object sender, EventArgs e)
        {
            logInPage.Visible = false;
            startMenu.Visible = true;
        }

        private void logInSubmit_Click(object sender, EventArgs e)
        {
            Globals.name = nameBox.Text;
            Globals.password = passBox.Text;

            bool loginSuccessful = false;

            using (StreamReader sr = new StreamReader(File.Open(@"C:\Users\nina.vazae\Desktop\Recycling-main\code\detailes.txt", FileMode.Open)))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    var creds = line.Split(' ');

                    if (Globals.name == creds[0])
                    {
                        if (Globals.password == creds[1] && "parent" == creds[2])
                        {
                            Globals.status = "parent";
                            loginSuccessful = true;
                            break;
                        }else if(Globals.password == creds[1])
                        {
                            loginSuccessful = true;
                            break;
                        }
                    }   
                }
                sr.Close();
            }

            if(loginSuccessful == true)
            {
                MenuSelect menuSelect = new MenuSelect();
                menuSelect.Show();
                Hide();
            }
            else
            {
                label2.Text = "Try again";
            }
        }

        private void returnSign_Click(object sender, EventArgs e)
        {
            signUpPage.Visible = false;
            startMenu.Visible = true;
        }

        private void signUp_Click(object sender, EventArgs e)
        {
            startMenu.Visible = false;
            signUpPage.Visible = true;
        }

        private void sumbitSign_Click(object sender, EventArgs e)
        {
            Globals.name = nameSign.Text;
            Globals.password = passSign.Text;
            string line;
            if(parentBox.Checked == true)
            {
                line = $"{Globals.name} {Globals.password} parent ,";
                Globals.status = "parent";
            }
            else
            {
                line = $"{Globals.name} {Globals.password} child ,";
            }

            string[] lines = { line };

            File.AppendAllLines(@"C:\Users\nina.vazae\Desktop\Recycling-main\code\detailes.txt", lines);

            sumbitSign.Visible = false;
        }

        private void passwordChange_Click(object sender, EventArgs e)
        {
            ChangePassword changepassword = new ChangePassword();
            changepassword.Show();
            Hide();
        }
    }
}