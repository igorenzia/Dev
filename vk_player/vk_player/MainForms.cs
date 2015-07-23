using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace vk_player
{
    public partial class MainForms : Form
    {
        XDocument doc;
        WebClient web = new WebClient();
        Uri urldown;
        string url, name;


        List<audios> audiolist = new List<audios>();


        IWavePlayer waveOutDevice;
        AudioFileReader audioFileReader;

        string fields = "fields=sex,bdate,city,country,photo_50,photo_100,photo_200_orig,photo_200,photo_400_orig,photo_max,photo_max_orig,photo_id,online,online_mobile,domain,has_mobile,contacts,connections,site,education,universities,schools,can_post,can_see_all_posts,can_see_audio,can_write_private_message,status,last_seen,common_count,relation,relatives,counters,screen_name,maiden_name,timezone,occupation,activities,interests,music,movies,tv,books,games,about,quotes,personal,friends_status ";

        public MainForms()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            waveOutDevice = new WaveOut();
            web.DownloadFileCompleted += web_DownloadFileCompleted;
            web.DownloadProgressChanged += web_DownloadProgressChanged;



            if (!File.Exists("token.tok"))
            {

                if (auth_fnc())
                {
                    File.WriteAllText("token.tok", VK_API.token);
                }
                else
                {
                    Environment.Exit(0);
                }

            }

            VK_API.token = File.ReadAllText("token.tok");

            getinfo();
           // File.WriteAllText("userget.txt", vk_player.VK_API.SGet("audio.search.xml?count=1000&auto_complete=1&q=" + txt_search_Audio.Text));
            File.WriteAllText("user.txt",VK_API.SGet("users.get.xml?" + fields));
        }


        Boolean auth_fnc()
        {
            if (!VK_API.connect()) return false;
            return true;
        }


        void web_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        void web_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("скачивание успешно завершено");
        }

        void getinfo()
        {

            try
            {
                doc = VK_API.XDGet("users.get.xml?" + fields);



                var userinfo = from user in doc.Descendants("user")
                               select new //userinfo
                               {
                                   uid = user.Element("uid").Value,
                                   firstName = user.Element("first_name").Value,
                                   secondNsme = user.Element("last_name").Value,
                                   photo = user.Element("photo_max_orig").Value
                               };

                foreach (var item in userinfo)
                {
                    lbl_firstName.Text = item.firstName;
                    LastName.Text = item.secondNsme;
                    lbl_info.Text = " ваш ID " + item.uid;
                    pb_avatar.ImageLocation = item.photo;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void cmd_search_audio_Click(object sender, EventArgs e)
        {

            doc = VK_API.XDGet("audio.search.xml?count=300&auto_complete=1&q=" + txt_search_Audio.Text);


            var audioarr = from ad in doc.Descendants("audio")
                           select new audios
                           {

                               //   aid = ad.Element("aid").Value,
                               owner_id = ad.Element("owner_id").Value,
                               title = ad.Element("title").Value,
                               duration = ad.Element("duration").Value,
                               artist = ad.Element("artist").Value,
                               // genre = ad.Element("genre").Value,
                               url = ad.Element("url").Value

                           };
            audios Aud_temp;
            int count = 0;
            list_Audio.Items.Clear();
            audiolist.Clear();
            foreach (var item in audioarr)
            {
                Aud_temp = new audios();
                list_Audio.Items.Add("-" + count + "-" + item.title);
                Aud_temp.title = item.title;
                Aud_temp.owner_id = item.owner_id;
                Aud_temp.duration = item.duration;
                //  Aud_temp.genre = item.genre;
                Aud_temp.artist = item.artist;
                //  Aud_temp.aid = item.aid;
                Aud_temp.url = item.url;
                audiolist.Add(Aud_temp);
                count++;
                Aud_temp = null;
            }

        }
        int i;


        private void list_Audio_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd_download.Enabled = true;
            i = 0;
            url = "";

            //MessageBox.Show(list_Audio.SelectedIndex.ToString());
            i = list_Audio.SelectedIndex;
            //  MessageBox.Show(i.ToString());

            lbl_artist.Text = audiolist[i].artist.ToString();
            lbl_duration.Text = audiolist[i].duration.ToString();
            lbl_title.Text = audiolist[i].title.ToString();
            url = audiolist[i].url;


            // MessageBox.Show(url);
            name = list_Audio.SelectedItem.ToString();
            //MessageBox.Show(audiolist[i].url);
        }

        private void cmd_download_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists("audios/")) {Directory.CreateDirectory("audios/");};
            try
            {
                cmd_download.Enabled = false;
                urldown = new Uri(url);
                web.DownloadFileAsync(urldown, "audios/" + name + ".mp3");
                url = "";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void cmd_play_Click(object sender, EventArgs e)
        {
            if (waveOutDevice.PlaybackState == PlaybackState.Playing)
            {
                tm.Enabled = false;
                waveOutDevice.Stop();
                audioFileReader = null;
                return;
            }
            //   MessageBox.Show(url);
            audioFileReader = new AudioFileReader(url);
            waveOutDevice.Init(audioFileReader);
            waveOutDevice.Play();
            pb_audio.Maximum = (int)audioFileReader.Length;
            tm.Enabled = true;
        }

        private void tm_Tick(object sender, EventArgs e)
        {
            pb_audio.Value = (int)audioFileReader.Position;
        }
    }
}
