using System;
using System.IO;
using System.Net;

namespace Mathletics
{

    // WOLFRAM API KEY           : 3A3XVA-U94H7LH2JK
    // HOME PAGE FOR API         : https://products.wolframalpha.com/api/
    // DOCS FOR API WE ARE USING : https://products.wolframalpha.com/short-answers-api/documentation/
    //read the links provided above if you want to understand what this code does.
    
    static class Wolf
    {
        private const string URL = "http://api.wolframalpha.com/v1/result";
        private const string KEY = "3A3XVA-U94H7LH2JK";

        /// <summary>
        /// queries wolfram api to get result for a query
        /// </summary>
        /// <param name="query">the query for which a reult will be reutrned</param>
        /// <returns>result of the query from wolfram api</returns>
        public static string GetSolution(string query)
        {
            Console.WriteLine($"[DBG]     : calling wolfram for response to : {query}");
            WebRequest req = WebRequest.Create($"{URL}?appid={KEY}&i={query}%3f"); // set request url and parameters
            req.Credentials = CredentialCache.DefaultCredentials; 
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse(); // send request
            Console.WriteLine($"[WLF] STT : {resp.StatusDescription}");
            string result = "err"; // default return value
            // read response data
            using (Stream dat = resp.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(dat))
                {
                    result = (reader.ReadToEnd()); // set read data to a var
                }
            }
            return result; // return response data
        }
    }
}
