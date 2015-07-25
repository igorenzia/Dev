namespace Api_VK
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
            this.cmd_Auth = new System.Windows.Forms.Button();
            this.cmd_Get_User = new System.Windows.Forms.Button();
            this.cmd_get_method = new System.Windows.Forms.Button();
            this.txt_method = new System.Windows.Forms.TextBox();
            this.cmd_broot = new System.Windows.Forms.Button();
            this.lbl_status = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // cmd_Auth
            // 
            this.cmd_Auth.Location = new System.Drawing.Point(12, 13);
            this.cmd_Auth.Name = "cmd_Auth";
            this.cmd_Auth.Size = new System.Drawing.Size(752, 23);
            this.cmd_Auth.TabIndex = 0;
            this.cmd_Auth.Text = "получить токен";
            this.cmd_Auth.UseVisualStyleBackColor = true;
            this.cmd_Auth.Click += new System.EventHandler(this.cmd_Auth_Click);
            // 
            // cmd_Get_User
            // 
            this.cmd_Get_User.Location = new System.Drawing.Point(12, 42);
            this.cmd_Get_User.Name = "cmd_Get_User";
            this.cmd_Get_User.Size = new System.Drawing.Size(752, 23);
            this.cmd_Get_User.TabIndex = 1;
            this.cmd_Get_User.Text = "запросить данные учетной записи";
            this.cmd_Get_User.UseVisualStyleBackColor = true;
            this.cmd_Get_User.Click += new System.EventHandler(this.cmd_Get_User_Click);
            // 
            // cmd_get_method
            // 
            this.cmd_get_method.Location = new System.Drawing.Point(12, 71);
            this.cmd_get_method.Name = "cmd_get_method";
            this.cmd_get_method.Size = new System.Drawing.Size(752, 23);
            this.cmd_get_method.TabIndex = 2;
            this.cmd_get_method.Text = "отправить";
            this.cmd_get_method.UseVisualStyleBackColor = true;
            this.cmd_get_method.Click += new System.EventHandler(this.cmd_get_method_Click);
            // 
            // txt_method
            // 
            this.txt_method.Location = new System.Drawing.Point(12, 100);
            this.txt_method.Name = "txt_method";
            this.txt_method.Size = new System.Drawing.Size(752, 20);
            this.txt_method.TabIndex = 3;
            this.txt_method.Text = "https://api.vk.com/method/users.get.xml?";
            // 
            // cmd_broot
            // 
            this.cmd_broot.Location = new System.Drawing.Point(12, 149);
            this.cmd_broot.Name = "cmd_broot";
            this.cmd_broot.Size = new System.Drawing.Size(752, 23);
            this.cmd_broot.TabIndex = 4;
            this.cmd_broot.Text = "broot";
            this.cmd_broot.UseVisualStyleBackColor = true;
            this.cmd_broot.Click += new System.EventHandler(this.cmd_broot_Click);
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(19, 184);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(16, 13);
            this.lbl_status.TabIndex = 5;
            this.lbl_status.Text = "---";
            // 
            // data
            // 
            this.data.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Location = new System.Drawing.Point(12, 200);
            this.data.Name = "data";
            this.data.RowHeadersVisible = false;
            this.data.Size = new System.Drawing.Size(752, 277);
            this.data.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 489);
            this.Controls.Add(this.data);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.cmd_broot);
            this.Controls.Add(this.txt_method);
            this.Controls.Add(this.cmd_get_method);
            this.Controls.Add(this.cmd_Get_User);
            this.Controls.Add(this.cmd_Auth);
            this.Name = "MainForm";
            this.Text = "API_VK";
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_Auth;
        private System.Windows.Forms.Button cmd_Get_User;
        private System.Windows.Forms.Button cmd_get_method;
        private System.Windows.Forms.TextBox txt_method;
        private System.Windows.Forms.Button cmd_broot;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.DataGridView data;
    }
}

