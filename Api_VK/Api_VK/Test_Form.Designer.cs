namespace Api_VK
{
    partial class Test_Form
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
            this.txt_resp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_resp
            // 
            this.txt_resp.Location = new System.Drawing.Point(12, 12);
            this.txt_resp.Multiline = true;
            this.txt_resp.Name = "txt_resp";
            this.txt_resp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_resp.Size = new System.Drawing.Size(674, 440);
            this.txt_resp.TabIndex = 5;
            // 
            // Test_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 473);
            this.Controls.Add(this.txt_resp);
            this.Name = "Test_Form";
            this.Text = "Test_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txt_resp;

    }
}