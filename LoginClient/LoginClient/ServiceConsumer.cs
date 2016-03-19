using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserModel;

namespace LoginClient {
    class ServiceConsumer {
        private string loginWebServiceName = "http://localhost:55303/LoginService.svc";
        private string logFileLocation = ConfigurationManager.AppSettings["logfilelocation"];
        private Logger logger;

        public ServiceConsumer() {
            logger = new Logger(logFileLocation);
        }

        public bool Login(string username, string password) {
            UserAccess userAccess = new UserAccess(loginWebServiceName);
            User user = userAccess.GetUser(username, password);

            if (user != null) {
                UserContainer.Instance.ActiveUser = user;
                logger.LogValid();
                return true;
            }
            logger.LogInvalid();
            return false;
        }
    }
}
