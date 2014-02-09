using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeskApi.Models.Messages
{
    class BaseMessage
    {
        string Direction { get; private set; }
        string Body { get; private set; }
        string Created_At { get; private set; }
        string Updated_At { get; private set; }
        string Hidden_At { get; private set; }
        bool Hidden { get; private set; }
        List<Dictionary<string, string>> Links { get; private set; }
    }
}
