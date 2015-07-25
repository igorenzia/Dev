using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace bot_vk_api
{
    public partial class MainForm : Form
    {
        public string token;
        WebClient web = new WebClient();
        Uri url;
        MemoryStream M_stream;
        XDocument Xdoc;
        DateTime dt;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dt = new DateTime(1970, 1, 1);
            Xdoc = new XDocument();
            web.Encoding = Encoding.UTF8;
            auth_form frm = new auth_form();
            frm.ShowDialog();
            token = frm.token;
            getApiVk("messages.getDialogs.xml?count=1");
        }

        private void getApiVk(string query)
        {
            try
            {
                File.WriteAllText("messin.xml", web.DownloadString("https://api.vk.com/method/" + query + "&access_token=" + token));

                url = new Uri("https://api.vk.com/method/" + query + "&access_token=" + token);

                M_stream = new MemoryStream(web.DownloadData(url));
                Xdoc = XDocument.Load(M_stream);

                var messs = from ms in Xdoc.Descendants("message")
                            select new
                            {
                                mid = ms.Element("mid").Value,
                                date = ms.Element("date").Value,

                                // outM = ms.Element("outM").Value,
                                uid = ms.Element("uid").Value,
                                //  read_state = ms.Element("read_state").Value,
                                // title = ms.Element("title").Value,
                                body = ms.Element("body").Value
                            };

                foreach (var ms in messs)
                {
                    txt.Text += ms.mid + " - " + ms.uid + " - " + dt.AddSeconds(Convert.ToInt32(ms.date)) + " - " + ms.body + Environment.NewLine;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


            //reader = XmlReader.Create(M_stream);

        }


    }
}
