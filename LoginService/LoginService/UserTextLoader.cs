using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UserModel;

namespace LoginService {
    public class UserTextLoader : Loader<User> {
        public UserTextLoader(string fileName, IContentReader contentReader)
            : base(fileName, contentReader) {
        }

        public override List<User> LoadList() {
            List<User> userList = new List<User>();

            string content = contentReader.ReadFullContent(sourcePath);

            string[] lines = content.Split(
                new string[] { Environment.NewLine },
                StringSplitOptions.RemoveEmptyEntries
            );

            foreach (string line in lines) {
                string[] values = line.Split(';');
                userList.Add(new User(values[0], values[1], values[2]));
            }

            return userList;
        }
    }
}
