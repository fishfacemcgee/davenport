using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Net.Http;
using System.Diagnostics;

namespace DeskApi
{
    public class DeskHandler
    {

        private const String ENDPOINT = "/api/v2/";
        private const String PROTOCOL = "https://";
        public String BaseUrl { get; private set; }

        public DeskHandler(String baseUrl = "")
        {
            BaseUrl = baseUrl;
            Debug.WriteLine(PROTOCOL + BaseUrl + ENDPOINT);
        }

        public void getCases()
        {
            // We may need to call getMessage from here in order to ensure we
            // have content to preview with. More API Doc research necessary
        }

        public void getMessage(int caseId)
        {

        }

        public void getReplies(int caseId)
        {

        }

        public void createReply(int caseId)
        {

        }

        public void createNote(int caseId)
        {

        }

        public void listAttachments(int caseId)
        {

        }

        public void createAttachment(int caseId)
        {

        }

        public void updateCase(int caseId)
        {
            /* 
             * This will likely need to take an Array/Object containing values
             * or a JSON string containing the data already prepared
             * 
             */
        }
    }
}
