using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;
using System.Data;
using System.Collections.Generic;

namespace Api_VK
{

    public partial class MainForm : Form
    {
        #region // объявление переменных
        public delegate void helper(string str);



        public delegate void helperDT(DataTable dt);
        public delegate void helperS2(string str1, string str2);

        helper guiview;
        helperS2 guiviewTime;
        helperDT getDT;
        XmlDocument Xdoc;
        XmlReader Xreader;
        byte[] bytes;
        string page_xml;
        string str_temp;
        MemoryStream M_stream;
        WebClient web;
        DataTable dt;
        Thread t;
        string uid, name, Lname, photo, phone;

        Uri url;
        string fields = "fields=sex,bdate,city,country,photo_50,photo_100,photo_200_orig,photo_200,photo_400_orig,photo_max,photo_max_orig,photo_id,online,online_mobile,domain,has_mobile,contacts,connections,site,education,universities,schools,can_post,can_see_all_posts,can_see_audio,can_write_private_message,status,last_seen,common_count,relation,relatives,counters,screen_name,maiden_name,timezone,occupation,activities,interests,music,movies,tv,books,games,about,quotes,personal,friends_status ";

        WebRequest req;
        WebResponse resp;

        string str_token;
        #endregion
        public MainForm()
        {
            InitializeComponent();
            init();

        }

        private void init()
        {
            guiview = new helper(guilbl);
            guiviewTime = new helperS2(gui_txt_time);
            getDT = new helperDT(Dataview);
            web = new WebClient();
            Xdoc = new XmlDocument();
            uid = name = Lname = phone = photo = uid = "";
            dt = new DataTable();

        }

        private void cmd_Auth_Click(object sender, EventArgs e)
        {
            Auth_Form frm = new Auth_Form();
            frm.ShowDialog();
        }

        private void cmd_Get_User_Click(object sender, EventArgs e)
        {
            Form_Get_UID frm = new Form_Get_UID();
            frm.ShowDialog();
        }

        private void cmd_get_method_Click(object sender, EventArgs e)
        {
            str_token = File.ReadAllText("25422596.txt");
            Test_Form Tfrm = new Test_Form();
            Tfrm.txt_resp.Text = get_API(txt_method.Text);
            Tfrm.ShowDialog();

        }
        //25422596
        /// <summary>
        /// запрос апи
        /// </summary>
        /// <param name="method">формат передачи users.get.xml?</param>
        private string get_API(string method)
        {
            url = new Uri(method + "&access_token=" + str_token);
            req = WebRequest.Create(url);
            resp = req.GetResponse();
            Stream stream = resp.GetResponseStream();
            StreamReader sr = new StreamReader(stream);
            string page_xml = sr.ReadToEnd();
            sr.Close();
            return page_xml;
        }

        private void cmd_broot_Click(object sender, EventArgs e)
        {
            cmd_broot.Enabled = false;
            dt.Columns.Add("uid");
            dt.Columns.Add("name");
            dt.Columns.Add("Lname");
            dt.Columns.Add("Phone");
            dt.Columns.Add("Photo");

            t = new Thread(broot);
            t.IsBackground = true;
            t.Start();

        }

        void Dataview(DataTable dt)
        {
            data.DataSource = dt;
        }

        private void broot()
        {
            Stopwatch sw = new Stopwatch();
            Stopwatch sw1 = new Stopwatch();
            str_token = File.ReadAllText("25422596.txt");

            try
            {

                sw.Start();
                for (int i = 0; i <= 100; i++)
                {

                    sw1.Restart();
                    //sw1.Start();
                    web.Encoding = Encoding.UTF8;
                    page_xml = web.DownloadString("https://api.vk.com/method/users.get.xml?user_ids=" + i + "&" + fields + "&access_token=" + str_token);
                    bytes = Encoding.UTF8.GetBytes(page_xml);
                    M_stream = new MemoryStream(bytes);
                    Xreader = XmlReader.Create(M_stream);


                    while (Xreader.Read())
                    {

                        if ((Xreader.NodeType == XmlNodeType.Element) && Xreader.Name == "uid")
                            uid = Xreader.ReadElementString();

                        if ((Xreader.NodeType == XmlNodeType.Element) && Xreader.Name == "first_name")
                            name = Xreader.ReadElementString();

                        if ((Xreader.NodeType == XmlNodeType.Element) && Xreader.Name == "last_name")
                            Lname = Xreader.ReadElementString();

                        if ((Xreader.NodeType == XmlNodeType.Element) && Xreader.Name == "mobile_phone")
                            phone = Xreader.ReadElementString();

                        if ((Xreader.NodeType == XmlNodeType.Element) && Xreader.Name == "photo_200_orig")
                            photo = Xreader.ReadElementString();



                    }


                    //File.AppendAllText("users.txt", str_temp + Environment.NewLine);
                    dt.Rows.Add(uid, name, Lname, phone, photo);
                    uid = name = Lname = phone = photo = uid = "";

                    sw1.Stop();


                    Invoke(guiview, i.ToString());
                    Invoke(guiviewTime, i.ToString(), sw1.Elapsed.ToString());



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sw.Stop();
            Invoke(getDT, dt);
            MessageBox.Show(sw.Elapsed.ToString());
            // File.AppendAllText("users.txt", " время затраченое на создание файла " + sw.Elapsed.ToString());

        }

        private void guilbl(string p)
        {
            cmd_broot.Text = "записано " + p + " строк ";
        }

        void gui_txt_time(string p1, string p2)
        {
            lbl_status.Text = "записано строк- " + p1 + "     потрачено времени на запись Юзера - " + p2;

        }

        //if (Xdoc.SelectSingleNode("response/user/first_name").InnerText != "DELETED")
        //{
        //    File.AppendAllText("users.txt", Xdoc.SelectSingleNode("response/user/uid").InnerText);
        //    File.AppendAllText("users.txt", " | ");
        //    File.AppendAllText("users.txt", Xdoc.SelectSingleNode("response/user/first_name").InnerText);
        //    File.AppendAllText("users.txt", " | ");
        //    File.AppendAllText("users.txt", Xdoc.SelectSingleNode("response/user/last_name").InnerText);
        //    File.AppendAllText("users.txt", " | ");
        //    File.AppendAllText("users.txt", Xdoc.SelectSingleNode("response/user/photo_200_orig").InnerText);

        //    foreach (XmlNode node in Xdoc.SelectNodes("response/user"))
        //    {
        //        if (node.SelectSingleNode("mobile_phone").InnerText.Length > 0)
        //        {
        //            File.AppendAllText("users.txt", " | ");
        //            File.AppendAllText("users.txt", Xdoc.SelectSingleNode("response/user/mobile_phone").InnerText);
        //        }

        //    }


        //    File.AppendAllText("users.txt", Environment.NewLine);
        //}

        //private XDocument get_broot(string i)
        //{

        //    //  MessageBox.Show(str_token);
        //    url = new Uri("https://api.vk.com/method/users.get.xml?user_ids=" + i + "&" + fields + "&access_token=" + str_token);
        //    req = WebRequest.Create(url);
        //    resp = req.GetResponse();
        //    return XDocument.Load(resp.GetResponseStream());
        //}

        private string get_broot(string i)
        {





            ////  MessageBox.Show(str_token);
            //url = new Uri("https://api.vk.com/method/users.get.xml?user_ids=" + i + "&" + fields + "&access_token=" + str_token);
            //req = WebRequest.Create(url);
            //resp = req.GetResponse();
            //Stream stream = resp.GetResponseStream();
            //StreamReader sr = new StreamReader(stream);
            //page_xml = sr.ReadToEnd();
            //sr.Close();

            return page_xml;

        }
    }
}