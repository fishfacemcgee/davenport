using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeskApi.Models.Messages
{
    class Tweet : BaseMessage
    {
        string Type { get; private set; }
        string To { get; private set; }
        string From { get; private set; }
    }
}
