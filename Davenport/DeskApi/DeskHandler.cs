using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.IO.Compression;
using System.Diagnostics;

namespace DeskApi
{
    public class DeskHandler
    {
        /*
         * TODO: Throw specified exceptions based on Status Code
         * 
         * Known Statuses:
         * 
         *  200 Success                 Request was successful
         *  201 Created                 Resource successfully created; a Location header should
         *      be included with the location of the new resource
         *  202 Accepted                Request was accepted but requires processing
         *  204 No Content              Request was successful, but not response data for client
         *  304 Not Modified            Resource has not been modified since ETag provided
         *  400 Bad Request             Generic error (such as not being able to parse JSON)
         *  401 Unauthorized            Required authorization fails
         *  403 Forbidden               Auth'd User does not have acess to requested resource
         *  404 Not Found               Resource not found
         *  405 Method Not Allowed      HTTP Verb not valid for requested action
         *  409 Conflict                Request could not be processed due to a conflict (eg case was locked)
         *  415 Unsupported Media Type  Did not use Content-Type of application/json
         *  422 Unprocessable Entity    Failure due to validation errors. Specific erros are detailed in errors response
         *  429 Too Many Requests       Rate Limit Reached
         *  501 Not Implemented         Data Type not Implemented
         */
        private const String _ENDPOINT = "/api/v2/";
        private const String _PROTOCOL = "https://";
        public String HostName { get; private set; }
        public String BaseUrl { get; private set; }

        public DeskHandler(String hostName = "")
        {
            HostName = hostName;
            BaseUrl = _PROTOCOL + HostName + _ENDPOINT;
            Debug.WriteLine(BaseUrl);
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

        private void apiRequest()
        {
            var handler = new HttpClientHandler();
            if (handler.SupportsAutomaticDecompression)
            {
                handler.AutomaticDecompression = System.Net.DecompressionMethods.Deflate | System.Net.DecompressionMethods.GZip;
            }

            var client = new HttpClient(handler);
            HttpRequestMessage request = getDeskRequestMessage();
            
        }

        private HttpRequestMessage getDeskRequestMessage()
        {
            HttpRequestMessage message = new HttpRequestMessage();

            message.Headers = new HttpRequestHeaders();
            message.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            message.Headers.AcceptCharset.Add(new StringWithQualityHeaderValue("utf-8"));

            message.Content.Headers.ContentType.MediaType = "application/json";

            return message;
        }
    }
}
