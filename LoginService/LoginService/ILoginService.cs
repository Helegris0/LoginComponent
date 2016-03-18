using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace LoginService {
    [ServiceContract]
    public interface ILoginService {
        [OperationContract]
        bool Login(string username, string password);
    }
}
