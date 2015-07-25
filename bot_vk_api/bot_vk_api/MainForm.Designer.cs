namespace bot_vk_api
{
    partial class MainForm
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
            this.lbl_status = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.TextBox();
            this.cmd_get = new System.Windows.Forms.Button();
            this.tm = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(13, 12);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(35, 13);
            this.lbl_status.TabIndex = 0;
            this.lbl_status.Text = "label1";
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(15, 97);
            this.txt.Multiline = true;
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(534, 245);
            this.txt.TabIndex = 1;
            // 
            // cmd_get
            // 
            this.cmd_get.Location = new System.Drawing.Point(393, 68);
            this.cmd_get.Name = "cmd_get";
            this.cmd_get.Size = new System.Drawing.Size(156, 23);
            this.cmd_get.TabIndex = 2;
            this.cmd_get.Text = "запустить\r\n";
            this.cmd_get.UseVisualStyleBackColor = true;
            this.cmd_get.Click += new System.EventHandler(this.cmd_get_Click);
            // 
            // tm
            // 
            this.tm.Interval = 4000;
            this.tm.Tick += new System.EventHandler(this.tm_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 354);
            this.Controls.Add(this.cmd_get);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.lbl_status);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Button cmd_get;
        private System.Windows.Forms.Timer tm;
    }
}

