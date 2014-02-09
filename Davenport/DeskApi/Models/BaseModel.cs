using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeskApi.Models
{
    class BaseModel
    {
        int                                 Id { get; private set; }
        string                              External_Id { get; private set; }
        // TODO: Investigate necessity of creating Custom Field class
        List<Dictionary<string, string>>    Custom_Fields { get; private set; }
        // TODO: Investigate necessity of creating Links class(es)
        List<Dictionary<string, string>>    Links { get; private set; }
        // Date fields (need to check if JSON.NET can safely convert into .NET-friendly date values
        string                              Created_At { get; private set; }
        string                              Updated_At { get; private set; }
        string                              Locked_Until { get; private set; }
    }
}
