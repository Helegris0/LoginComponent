using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserModel;

namespace LoginClient {
    class Logger {
        private String fileLocation;

        public Logger(string fileLocation) {
            this.fileLocation = fileLocation;
        }

        public void Log() {
            User user = UserContainer.Instance.ActiveUser;
            if (user != null) {
                Log(DateTime.Now + ";valid;" + user.Username);
            } else {
                Log(DateTime.Now + ";invalid");
            }
        }

        private void Log(string line) {
            using (StreamWriter sw = new StreamWriter(fileLocation, true)) {
                sw.WriteLine(line);
            }
        }
    }
}
