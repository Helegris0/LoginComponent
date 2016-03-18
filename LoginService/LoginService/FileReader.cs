using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoginService {
    public class FileReader : IContentReader {
        public string ReadFullContent(string fileName) {
            string text = System.IO.File.ReadAllText(fileName);
            return text;
        }
    }
}
