using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserModel;

namespace LoginClient {
    class UserContainer {
        private static UserContainer instance;
        public User ActiveUser { get; set; }

        private UserContainer() {
        }

        public static UserContainer Instance {
            get {
                if (instance == null) {
                    instance = new UserContainer();
                }
                return instance;
            }
        }
    }
}
