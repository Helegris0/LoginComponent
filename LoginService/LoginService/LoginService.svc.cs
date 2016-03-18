using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace LoginService {
    public class LoginService : ILoginService {
        private String path = "D:\\codes.csv";

        public bool Login(string username, string password) {
            User user = new UserTextLoader(path, new FileReader())
                .LoadUsers()
                .Where(u => username.Equals(u.Username))
                .First();
            return password.Equals(user.Password);
        }
    }
}
