namespace vk_player
{
    partial class MainForms
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_firstName = new System.Windows.Forms.Label();
            this.list_Audio = new System.Windows.Forms.ListBox();
            this.cmd_search_audio = new System.Windows.Forms.Button();
            this.pb_avatar = new System.Windows.Forms.PictureBox();
            this.LastName = new System.Windows.Forms.Label();
            this.lbl_info = new System.Windows.Forms.Label();
            this.txt_search_Audio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_info_Song = new System.Windows.Forms.Label();
            this.cmd_download = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.cmd_play = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_status_download = new System.Windows.Forms.Label();
            this.pb_audio = new System.Windows.Forms.ProgressBar();
            this.tm = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_duration = new System.Windows.Forms.Label();
            this.lbl_artist = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_avatar)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_firstName
            // 
            this.lbl_firstName.AutoSize = true;
            this.lbl_firstName.Location = new System.Drawing.Point(12, 157);
            this.lbl_firstName.Name = "lbl_firstName";
            this.lbl_firstName.Size = new System.Drawing.Size(35, 13);
            this.lbl_firstName.TabIndex = 0;
            this.lbl_firstName.Text = "label1";
            // 
            // list_Audio
            // 
            this.list_Audio.FormattingEnabled = true;
            this.list_Audio.Location = new System.Drawing.Point(479, 32);
            this.list_Audio.Name = "list_Audio";
            this.list_Audio.Size = new System.Drawing.Size(308, 277);
            this.list_Audio.TabIndex = 1;
            this.list_Audio.SelectedIndexChanged += new System.EventHandler(this.list_Audio_SelectedIndexChanged);
            // 
            // cmd_search_audio
            // 
            this.cmd_search_audio.Location = new System.Drawing.Point(753, 9);
            this.cmd_search_audio.Name = "cmd_search_audio";
            this.cmd_search_audio.Size = new System.Drawing.Size(34, 23);
            this.cmd_search_audio.TabIndex = 2;
            this.cmd_search_audio.Text = "go";
            this.cmd_search_audio.UseVisualStyleBackColor = true;
            this.cmd_search_audio.Click += new System.EventHandler(this.cmd_search_audio_Click);
            // 
            // pb_avatar
            // 
            this.pb_avatar.Location = new System.Drawing.Point(12, 12);
            this.pb_avatar.Name = "pb_avatar";
            this.pb_avatar.Size = new System.Drawing.Size(195, 142);
            this.pb_avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_avatar.TabIndex = 3;
            this.pb_avatar.TabStop = false;
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(109, 157);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(35, 13);
            this.LastName.TabIndex = 4;
            this.LastName.Text = "label2";
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Location = new System.Drawing.Point(12, 193);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(35, 13);
            this.lbl_info.TabIndex = 5;
            this.lbl_info.Text = "label3";
            // 
            // txt_search_Audio
            // 
            this.txt_search_Audio.Location = new System.Drawing.Point(479, 9);
            this.txt_search_Audio.Name = "txt_search_Audio";
            this.txt_search_Audio.Size = new System.Drawing.Size(268, 20);
            this.txt_search_Audio.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "информация о записи";
            // 
            // lbl_info_Song
            // 
            this.lbl_info_Song.AutoSize = true;
            this.lbl_info_Song.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_info_Song.Location = new System.Drawing.Point(3, 34);
            this.lbl_info_Song.Name = "lbl_info_Song";
            this.lbl_info_Song.Size = new System.Drawing.Size(254, 18);
            this.lbl_info_Song.TabIndex = 10;
            this.lbl_info_Song.Text = "---";
            this.lbl_info_Song.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmd_download
            // 
            this.cmd_download.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmd_download.Enabled = false;
            this.cmd_download.Location = new System.Drawing.Point(3, 88);
            this.cmd_download.Name = "cmd_download";
            this.cmd_download.Size = new System.Drawing.Size(254, 26);
            this.cmd_download.TabIndex = 11;
            this.cmd_download.Text = "скачать";
            this.cmd_download.UseVisualStyleBackColor = true;
            this.cmd_download.Click += new System.EventHandler(this.cmd_download_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(3, 120);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(254, 14);
            this.progressBar1.TabIndex = 12;
            // 
            // cmd_play
            // 
            this.cmd_play.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmd_play.Location = new System.Drawing.Point(3, 55);
            this.cmd_play.Name = "cmd_play";
            this.cmd_play.Size = new System.Drawing.Size(254, 27);
            this.cmd_play.TabIndex = 13;
            this.cmd_play.Text = "play/stop";
            this.cmd_play.UseVisualStyleBackColor = true;
            this.cmd_play.Click += new System.EventHandler(this.cmd_play_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_status_download, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.progressBar1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cmd_play, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmd_download, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_info_Song, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pb_audio, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(213, 162);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(260, 161);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // lbl_status_download
            // 
            this.lbl_status_download.AutoSize = true;
            this.lbl_status_download.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_status_download.Location = new System.Drawing.Point(3, 137);
            this.lbl_status_download.Name = "lbl_status_download";
            this.lbl_status_download.Size = new System.Drawing.Size(254, 27);
            this.lbl_status_download.TabIndex = 15;
            this.lbl_status_download.Text = "--";
            this.lbl_status_download.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb_audio
            // 
            this.pb_audio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_audio.Location = new System.Drawing.Point(3, 3);
            this.pb_audio.Name = "pb_audio";
            this.pb_audio.Size = new System.Drawing.Size(254, 28);
            this.pb_audio.TabIndex = 16;
            // 
            // tm
            // 
            this.tm.Interval = 500;
            this.tm.Tick += new System.EventHandler(this.tm_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "название - ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "артист -";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "продолжительность";
            // 
            // lbl_duration
            // 
            this.lbl_duration.AutoSize = true;
            this.lbl_duration.Location = new System.Drawing.Point(331, 141);
            this.lbl_duration.Name = "lbl_duration";
            this.lbl_duration.Size = new System.Drawing.Size(16, 13);
            this.lbl_duration.TabIndex = 21;
            this.lbl_duration.Text = "---";
            // 
            // lbl_artist
            // 
            this.lbl_artist.Location = new System.Drawing.Point(285, 87);
            this.lbl_artist.Name = "lbl_artist";
            this.lbl_artist.Size = new System.Drawing.Size(185, 54);
            this.lbl_artist.TabIndex = 20;
            this.lbl_artist.Text = "---";
            // 
            // lbl_title
            // 
            this.lbl_title.Location = new System.Drawing.Point(285, 32);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(188, 55);
            this.lbl_title.TabIndex = 19;
            this.lbl_title.Text = "---";
            // 
            // MainForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 349);
            this.Controls.Add(this.lbl_duration);
            this.Controls.Add(this.lbl_artist);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_search_Audio);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.pb_avatar);
            this.Controls.Add(this.cmd_search_audio);
            this.Controls.Add(this.list_Audio);
            this.Controls.Add(this.lbl_firstName);
            this.Name = "MainForms";
            this.Text = "Вк проигрыватель";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_avatar)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_firstName;
        private System.Windows.Forms.ListBox list_Audio;
        private System.Windows.Forms.Button cmd_search_audio;
        private System.Windows.Forms.PictureBox pb_avatar;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.TextBox txt_search_Audio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_info_Song;
        private System.Windows.Forms.Button cmd_download;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button cmd_play;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_status_download;
        private System.Windows.Forms.Timer tm;
        private System.Windows.Forms.ProgressBar pb_audio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_duration;
        private System.Windows.Forms.Label lbl_artist;
        private System.Windows.Forms.Label lbl_title;
    }
}

