﻿namespace bot_vk_api
{
    partial class auth_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.web = new System.Windows.Forms.WebBrowser();
            this.cmd_parse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // web
            // 
            this.web.Dock = System.Windows.Forms.DockStyle.Fill;
            this.web.Location = new System.Drawing.Point(0, 0);
            this.web.MinimumSize = new System.Drawing.Size(20, 20);
            this.web.Name = "web";
            this.web.Size = new System.Drawing.Size(606, 413);
            this.web.TabIndex = 0;
            // 
            // cmd_parse
            // 
            this.cmd_parse.Location = new System.Drawing.Point(508, 382);
            this.cmd_parse.Name = "cmd_parse";
            this.cmd_parse.Size = new System.Drawing.Size(75, 23);
            this.cmd_parse.TabIndex = 1;
            this.cmd_parse.Text = "parse";
            this.cmd_parse.UseVisualStyleBackColor = true;
            this.cmd_parse.Visible = false;
            this.cmd_parse.Click += new System.EventHandler(this.cmd_parse_Click);
            // 
            // auth_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 413);
            this.Controls.Add(this.cmd_parse);
            this.Controls.Add(this.web);
            this.Name = "auth_form";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.auth_form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser web;
        private System.Windows.Forms.Button cmd_parse;
    }
}