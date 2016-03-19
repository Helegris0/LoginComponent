using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginClient {
    public partial class LoginForm : Form {

        public LoginForm() {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            if (!"".Equals(txtUsername.Text) && !"".Equals(txtPassword.Text)) {

                if (new ServiceConsumer().Login(txtUsername.Text, txtPassword.Text)) {
                    this.Close();
                } else {
                    MessageBox.Show("Invalid username or password.", "Login unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
