using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bot_vk_api
{
    public partial class auth_form : Form
    {
        public string token;
        public auth_form()
        {
            InitializeComponent();
        }

        private void auth_form_Load(object sender, EventArgs e)
        {
            web.DocumentCompleted += web_DocumentCompleted;
            web.ScriptErrorsSuppressed = true;

            // web.Navigate("https://oauth.vk.com/authorize?client_id=4918290&scope=notify,friends,photos,audio,video,status,wall,groups,messages,stats&API_VERSION=5.34&redirect_uri=http://oauth.vk.com/blank.html&display=touch&response_type=token");
            web.Navigate("https://oauth.vk.com/authorize?client_id=4918290&scope=notify,friends,photos,audio,video,status,wall,groups,messages,stats&redirect_uri=http://oauth.vk.com/blank.html&display=touch&v=5.14&response_type=token ");
        }
        int count = 0;
        void web_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

            //  MessageBox.Show(count.ToString());
            if (count == 1)
                cmd_parse.Visible = true;

            if (count == 2)
                func_parse();
         
            count++;
        }

        private void func_parse()
        {

            char[] symbol = { '=', '&' };
            string[] str = web.Url.ToString().Split(symbol);
            token = str[1];

            this.Close();
        }

        private void cmd_parse_Click(object sender, EventArgs e)
        {
            func_parse();
        }


    }
}
