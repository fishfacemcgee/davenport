using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeskApi.Models
{
    class Customer : BaseModel
    {
        string                              First_Name { get; private set; }
        string                              Last_Name { get; private set; }
        string                              Title { get; private set; }
        string                              Background { get; private set; }
        string                              Language { get; private set; }
        // TODO: Investigate necessity of creating Email class/object
        List<Dictionary<string, string>>    Emails { get; private set; }
        // TODO: Investigate necessity of creating Phone Number Class/Object
        List<Dictionary<string, string>>    Phone_Numbers { get; private set; }
        // TODO: Investigate necessity of creating Addresses Class/Object
        List<Dictionary<string, string>>    Addresses { get; private set; }

    }
}
