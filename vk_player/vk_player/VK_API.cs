using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace vk_player
{
    public static class VK_API
    {
       public static  WebRequest req ;
       public static WebResponse resp;
       public static Uri url;
        public static XDocument doc;
        static auth_Forms frm = new auth_Forms();

        public static string Error { get; set; }
        public static string token;


        static public Boolean connect()
        {
           

            frm.ShowDialog();
            if (VK_API.token.Length < 2) { return false; }
            return true;

        }




        public static XDocument XDGet(string query)
        {
            try
            {
                url = new Uri("https://api.vk.com/method/" + query + "&access_token=" + token);
                req = WebRequest.Create(url);
                resp = req.GetResponse();
                doc = XDocument.Load(resp.GetResponseStream());
                return doc;
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                return null;
            }


        }

        public static String SGet(string query)
        {
            try
            {
                url = new Uri("https://api.vk.com/method/" + query+"&access_token=" + token);
                req = WebRequest.Create(url);
                resp = req.GetResponse();
                Stream stream = resp.GetResponseStream();
                StreamReader sr = new StreamReader(stream);
                string page= sr.ReadToEnd();
                sr.Close();
                return page;


            }
            catch (Exception ex)
            {
                Error = ex.Message;
                return null;
            }

        }

    }
}
