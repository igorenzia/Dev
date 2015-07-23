using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vk_player
{
    public partial class auth_Forms : Form
    {
        int count = 0;
        public auth_Forms()
        {
            InitializeComponent();
        }

        private void main_Form_Load(object sender, EventArgs e)
        {
            web.DocumentCompleted += web_DocumentCompleted;
            web.ScriptErrorsSuppressed = true;
            web.Navigate("https://oauth.vk.com/authorize?client_id=4918290&scope=notify,friends,photos,audio,video,status,wall,groups,messages,stats&redirect_uri=http://oauth.vk.com/blank.html&display=touch&response_type=token");
        }

        void web_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            count++;
            if (count == 2)
            {
                cmd_close.Visible = true;
                char[] simbol = { '=', '&' };
                string[] restring =   web.Url.ToString().Split(simbol);


                VK_API.token = restring[1];

                this.Close();
             

            }
        }

        private void cmd_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
