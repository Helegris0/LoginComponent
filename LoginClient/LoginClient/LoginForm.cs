using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserModel;

namespace LoginClient {
    public partial class LoginForm : Form {
        private string loginWebServiceName = "http://localhost:55303/LoginService.svc";

        public LoginForm() {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            if (!"".Equals(txtUsername.Text) && !"".Equals(txtPassword.Text)) {

                UserAccess userAccess = new UserAccess(loginWebServiceName);
                User user = userAccess.GetUser(txtUsername.Text, txtPassword.Text);

                if (user == null) {
                    MessageBox.Show("Invalid username or password.", "Login unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } else {
                    UserContainer.Instance.ActiveUser = user;
                    this.Close();
                }
            }
        }
    }
}
