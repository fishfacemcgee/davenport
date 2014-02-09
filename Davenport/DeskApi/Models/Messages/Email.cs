using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeskApi.Models.Messages
{
    class Email : BaseMessage
    {
        string Status { get; private set;}
        string Subject { get; private set; }
        string From { get; private set; }
        string To { get; private set; }
        string Cc { get; private set; }
        string Bcc { get; private set; }
    }
}
