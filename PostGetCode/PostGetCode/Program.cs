using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Http;

namespace PostGetCode
{
    class Program
    {
        private static HttpClient client;
        private static IEnumerable<KeyValuePair<String, String>> query;
        private static HttpResponseMessage respMsg;
        private static HttpContent respMsgCont;
        private static String urlToAccess;

        static void Main(string[] args)
        {

            
            UrlToAccess = "http://requestb.in/1dwys581";

            getReq(UrlToAccess);
            postReq(UrlToAccess);

            
            Console.ReadKey();
        }

        static async void getReq(String url)
        {
            Client = new HttpClient();
            RespMsg = await client.GetAsync(url);
            RespMsgCont = respMsg.Content;

            String myContent = await respMsgCont.ReadAsStringAsync();
            var headers = respMsgCont.Headers;

            
            Console.WriteLine(myContent);
            
        }

        static async void postReq(String url)
        {
            Client = new HttpClient();
            Query = new List<KeyValuePair<String, String>>()
            {
                new KeyValuePair<string, string>("1", "GetTyreByDocument"),
                new KeyValuePair<string,string>("2","DontGetTyreByDocument")

            };

            HttpContent queries = new FormUrlEncodedContent(query);

            RespMsg = await client.PostAsync(url,queries);


            RespMsgCont = respMsg.Content;

            String myContent = await respMsgCont.ReadAsStringAsync();
            var headers = respMsgCont.Headers;

            Console.WriteLine(myContent);

           
        }

        

        public static IEnumerable<KeyValuePair<string, string>> Query
        {
            get
            {
                return query;
            }

            set
            {
                query = value;
            }
        }

        public static HttpResponseMessage RespMsg
        {
            get
            {
                return respMsg;
            }

            set
            {
                respMsg = value;
            }
        }

        public static HttpContent RespMsgCont
        {
            get
            {
                return respMsgCont;
            }

            set
            {
                respMsgCont = value;
            }
        }

        public static HttpClient Client
        {
            get
            {
                return client;
            }

            set
            {
                client = value;
            }
        }

        public static string UrlToAccess
        {
            get
            {
                return urlToAccess;
            }

            set
            {
                urlToAccess = value;
            }
        }
    }
}
