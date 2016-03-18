using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginService {
    public interface IContentReader {
        string ReadFullContent(string fileName);
    }
}
