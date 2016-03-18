using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using UserModel;

namespace LoginService {
    public class LoginService : ILoginService {
        private string csvPath = "D:\\codes.csv";

        public User Login(string username, string password) {
            User user = new UserTextLoader(csvPath, new FileReader())
                .LoadUsers()
                .Where(u => username.Equals(u.Username))
                .First();

            if (password.Equals(user.Password)) {
                return user;
            }

            return null;
        }
    }
}
