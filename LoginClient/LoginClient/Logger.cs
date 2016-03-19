using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginClient {
    class Logger {
        private String fileLocation;

        public Logger(string fileLocation) {
            this.fileLocation = fileLocation;
        }

        public void LogValid() {
            Log(DateTime.Now + ";valid;" + UserContainer.Instance.ActiveUser.Username);
        }

        public void LogInvalid() {
            Log(DateTime.Now + ";invalid");
        }

        private void Log(string line) {
            using (StreamWriter sw = new StreamWriter(fileLocation, true)) {
                sw.WriteLine(line);
            }
        }
    }
}
