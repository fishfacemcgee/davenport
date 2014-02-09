using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeskApi.Models.Messages
{
    class Community : BaseMessage
    {
        string Subject { get; private set; }
    }
}
