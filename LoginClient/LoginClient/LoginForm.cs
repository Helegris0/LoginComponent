using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserModel;

namespace LoginClient {
    public partial class LoginForm : Form {
        private string loginWebServiceName = "http://localhost:55303/LoginService.svc";
        private string logFileLocation = ConfigurationManager.AppSettings["logfilelocation"];

        public LoginForm() {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            if (!"".Equals(txtUsername.Text) && !"".Equals(txtPassword.Text)) {

                UserAccess userAccess = new UserAccess(loginWebServiceName);
                User user = userAccess.GetUser(txtUsername.Text, txtPassword.Text);

                DateTime dateTime = DateTime.Now;

                if (user == null) {
                    MessageBox.Show("Invalid username or password.", "Login unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Log(dateTime + ";invalid");
                } else {
                    UserContainer.Instance.ActiveUser = user;
                    Log(dateTime + ";valid;" + UserContainer.Instance.ActiveUser.Username);
                    this.Close();
                }
            }
        }

        private void Log(string line) {
            using (StreamWriter sw = new StreamWriter(logFileLocation, true)) {
                sw.WriteLine(line);
            }
        }
    }
}
