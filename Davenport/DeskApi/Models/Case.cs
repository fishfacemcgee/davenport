using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeskApi.Models
{
    class Case
    {
        int                                 Id          { get; private set; }
        string                              External_Id { get; private set; }
        string                              Blurb       { get; private set; }
        int                                 Priority    { get; private set; }
        string                              Description { get; private set; }
        List<string>                        Labels { get; private set; }
        string                              Language { get; private set; }
        // TOOD: Investigate necessity of creating Custom Field class
        List<Dictionary<string, string>>    Custom_Fields { get; private set; }
        // Date fields (need to check if JSON.NET can safely convert into .NET-friendly date values
        string                              Created_At { get; private set; }
        string                              Updated_At { get; private set; }
        string                              Received_At { get; private set; }
        string                              Locked_Until { get; private set; }
        string                              First_Opened_At { get; private set; }
        string                              Opened_At { get; private set; }
        string                              First_Resolved_At { get; private set; }
        string                              Resolved_At { get; private set; }
        // End Date Fields

        string Status
        {
            get;
            set
            {
                List<string> predefinedStatuses = new List<string>(
                    new string[] { "new", "open", "pending", "resolved", "closed" }
                );

                Status = setSmartDefault(predefinedStatuses, value, "new");
            }
        }
        string Type
        {
            get;
            set
            {
                List<string> predefinedTypes = new List<string>(
                    new string[] { "chat", "twitter", "email", "qna", "facebook", "phone" }
                );

                Type = setSmartDefault(predefinedTypes, value, "email");
            }
        }

        /// <summary>
        ///     <para>
        ///         Utility function to check a given value against a List of predefined
        ///         values deemed exepcted by the Desk.com API
        ///     </para>
        ///     <para>
        ///         http://dev.desk.com/API/cases/#fields
        ///     </para>
        /// </summary>
        /// <param name="predefinedValues">A List of String values listed in the Desk.com API as expected values for a property</param>
        /// <param name="valueToCheck">The value to return after a successful check or set to safeFallback</param>
        /// <param name="safeFallback">The value to fall back to if valueToCheck is not in the predefinedValues List</param>
        /// <returns>A valid value for the given Case property</returns>
        private string setSmartDefault(List<string> predefinedValues, string valueToCheck, string safeFallback)
        {
            if (predefinedValues.IndexOf(valueToCheck) == -1)
            {
                valueToCheck = safeFallback;
            }

            return valueToCheck;
        }
    }
}
