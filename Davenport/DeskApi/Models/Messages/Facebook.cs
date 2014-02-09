using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeskApi.Models.Messages
{
    class Facebook : BaseMessage
    {
        string Status { get; private set; }
        string From_Facebook_Name { get; private set; }
    }
}
