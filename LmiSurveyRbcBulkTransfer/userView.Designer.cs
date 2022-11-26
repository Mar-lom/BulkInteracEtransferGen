namespace LmiSurveyRbcBulkTransfer
{
    partial class userViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userViewForm));
            this.viewUserListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // viewUserListBox
            // 
            this.viewUserListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewUserListBox.FormattingEnabled = true;
            this.viewUserListBox.ItemHeight = 20;
            this.viewUserListBox.Location = new System.Drawing.Point(12, 12);
            this.viewUserListBox.Name = "viewUserListBox";
            this.viewUserListBox.Size = new System.Drawing.Size(495, 284);
            this.viewUserListBox.TabIndex = 0;
            this.viewUserListBox.SelectedIndexChanged += new System.EventHandler(this.viewUserListBox_SelectedIndexChanged);
            // 
            // userViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(178)))));
            this.ClientSize = new System.Drawing.Size(522, 314);
            this.Controls.Add(this.viewUserListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "userViewForm";
            this.Text = "XML Bank File Transfer";
            this.Load += new System.EventHandler(this.userViewForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox viewUserListBox;
    }
}