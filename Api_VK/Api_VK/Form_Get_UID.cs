using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml.Linq;
using System.Xml;

namespace Api_VK
{

    public partial class Form_Get_UID : Form
    {
        #region // объявление переменных
        XDocument doc;
        Uri url;
        string fields = "fields=sex,bdate,city,country,photo_50,photo_100,photo_200_orig,photo_200,photo_400_orig,photo_max,photo_max_orig,photo_id,online,online_mobile,domain,has_mobile,contacts,connections,site,education,universities,schools,can_post,can_see_all_posts,can_see_audio,can_write_private_message,status,last_seen,common_count,relation,relatives,counters,screen_name,maiden_name,timezone,occupation,activities,interests,music,movies,tv,books,games,about,quotes,personal,friends_status ";

        WebRequest req;
        WebResponse resp;

        string str_token;

        #endregion
        public Form_Get_UID()
        {
            InitializeComponent();
        }

        private void cmd_get_uid_Click(object sender, EventArgs e)
        {
            get_users();

        }

        private void get_users()
        {
            try
            {

                str_token = File.ReadAllText("25422596.txt");
               // MessageBox.Show(str_token);
                url = new Uri("https://api.vk.com/method/users.get.xml?" + fields + "&access_token=" + str_token);
                req = WebRequest.Create(url);
                resp = req.GetResponse();
                doc = XDocument.Load(resp.GetResponseStream());


                //url = new Uri("https://api.vk.com/method/users.get.xml?" + fields + "&access_token=" + str_token);
                //req = WebRequest.Create(url);
                //resp = req.GetResponse();
                //Stream stream = resp.GetResponseStream();
                //StreamReader sr = new StreamReader(stream);
                //string page_xml = sr.ReadToEnd();
                //sr.Close();
                //File.WriteAllText("user_Info", page_xml);

                var users = from us in doc.Descendants("user")
                            select new
                            {
                                uid = us.Element("uid").Value,
                                lastnm = us.Element("first_name").Value,
                                photo = us.Element("photo_200_orig").Value
                            };

                foreach (var item in users)
                {
                    lbl_name.Text = item.lastnm;
                    lbl_uid.Text = item.uid;
                    pb.ImageLocation = item.photo;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Auth_Form frm = new Auth_Form();
                frm.ShowDialog();
            }

        }

        private void Form_Get_UID_Load(object sender, EventArgs e)
        {

        }
    }
}
