using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoginService {
    public class User {
        private string firstName;
        public string FirstName {
            get { return firstName; }
            set { firstName = value;
                if (LastName != null) {
                    CreateUsername();
                }
            }
        }

        private string lastName;
        public string LastName {
            get { return lastName; }
            set { lastName = value;
                if (FirstName != null) {
                    CreateUsername();
                }
            }
        }

        public string Username { get; set; }
        public string Password { get; set; }

        public User() {
        }

        public User(string firstName, string lastName, string password) {
            FirstName = firstName;
            LastName = lastName;
            Password = password;
            CreateUsername();
        }

        private void CreateUsername() {
            Username = FirstName.ToLower().Substring(0, 1) + LastName.ToLower();
        }

        public string GetName() {
            return String.Format("{0} {1}", FirstName, LastName);
        }
    }
}
