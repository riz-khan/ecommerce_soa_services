using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SOO_CLIENT
{
    class Authenticate
    {
        public bool LoginUser(string username, string password)
        {

            string baseAddress = "http://localhost:8080/userservice/login/"+username+"/"+password;
            string body = ""; 
            string res = SendRequest(baseAddress , "GET", "text/xml", body);

            if(res == "" || res == null){
                return false;
            }

            XmlDocument xd = new XmlDocument();
            xd.LoadXml(res);

            XmlElement root = xd.DocumentElement;
            XmlNodeList nodes = root.SelectNodes("token");
            foreach (XmlNode node in nodes)
            {
                Program.authToken = node.InnerText;
            }

            XmlElement root2 = xd.DocumentElement;
            XmlNodeList nodes2 = root2.SelectNodes("uuid");
            foreach (XmlNode node in nodes2)
            {
                Program.userUuid = node.InnerText;
            }

            return true;
        
        }

        public bool LogOutUser(string uuid)
        {
            string baseAddress = "http://localhost:8080/userservice/logout/"+uuid;
            string body = "";
            string res = SendRequest(baseAddress, "GET", "text/xml", body);

            if (res == "true")
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        public bool AuthenticateUser(string token) {
            string baseAddress = "http://localhost:8080/userservice/authenticate/"+token;
            string body = "";
            string res = SendRequest(baseAddress, "GET", "text/xml", body);

            if (res == "true")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string SendRequest(string uri, string method, string contentType, string body)
        {
            string responseBody = null;

            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(uri);
            req.Method = method;
            if (!String.IsNullOrEmpty(contentType))
            {
                req.ContentType = contentType;
            }
            if (!String.IsNullOrEmpty(body))
            {
                byte[] bodyBytes = Encoding.UTF8.GetBytes(body);
                req.GetRequestStream().Write(bodyBytes, 0, bodyBytes.Length);
                req.GetRequestStream().Close();
            }

            HttpWebResponse resp;
            try
            {
                resp = (HttpWebResponse)req.GetResponse();
            }
            catch (WebException e)
            {
                resp = (HttpWebResponse)e.Response;
            }

            Stream respStream = resp.GetResponseStream();

            if (respStream != null)
            {
                responseBody = new StreamReader(respStream).ReadToEnd();
            }
            else
            {
                Console.WriteLine("HttpWebResponse.GetResponseStream returned null");
            }
            return responseBody;
        }

    }
}
