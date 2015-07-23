using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Api_VK
{
    public partial class Auth_Form : Form
    {
        public Auth_Form()
        {
            InitializeComponent();
        }

        private void Auth_Form_Load(object sender, EventArgs e)
        {
            web.DocumentCompleted += web_DocumentCompleted;
            web.ScriptErrorsSuppressed = true;
            web.Navigate("https://oauth.vk.com/authorize?client_id=4918290&scope=notify,friends,photos,audio,video,status,wall,groups,messages,stats&redirect_uri=http://oauth.vk.com/blank.html&display=touch&response_type=token");
        }
        int count = 0;
        void web_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            count++;
            if (count == 2)
            {
                cmd_parse.Visible = true;
            }
            if (count == 3)
            {
                get_token();
            }

        }

        private void get_token()
        {
            char[] symb = { '=', '&' };
            string[] str = web.Url.ToString().Split(symb);
            MessageBox.Show(str[1]);
            File.WriteAllText(str[5]+".txt",str[1]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            get_token();
        }
    }
}
