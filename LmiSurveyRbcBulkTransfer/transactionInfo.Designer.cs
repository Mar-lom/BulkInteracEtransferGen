namespace LmiSurveyRbcBulkTransfer
{
    partial class transactionInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(transactionInfo));
            this.createFile = new System.Windows.Forms.Button();
            this.accountNumberTextBox = new System.Windows.Forms.MaskedTextBox();
            this.accountIdLabel = new System.Windows.Forms.Label();
            this.accountIdTextBox = new System.Windows.Forms.MaskedTextBox();
            this.accountIdNumberLabel = new System.Windows.Forms.Label();
            this.questionLabel = new System.Windows.Forms.Label();
            this.Answer = new System.Windows.Forms.Label();
            this.questionTextBox = new System.Windows.Forms.TextBox();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.moneyTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // createFile
            // 
            this.createFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(168)))));
            this.createFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createFile.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.createFile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.createFile.Location = new System.Drawing.Point(75, 338);
            this.createFile.Margin = new System.Windows.Forms.Padding(2);
            this.createFile.Name = "createFile";
            this.createFile.Size = new System.Drawing.Size(94, 35);
            this.createFile.TabIndex = 0;
            this.createFile.Text = "Save File";
            this.createFile.UseVisualStyleBackColor = false;
            this.createFile.Click += new System.EventHandler(this.createFile_Click);
            // 
            // accountNumberTextBox
            // 
            this.accountNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.accountNumberTextBox.Location = new System.Drawing.Point(69, 117);
            this.accountNumberTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.accountNumberTextBox.Mask = "000-00000-0000000";
            this.accountNumberTextBox.Name = "accountNumberTextBox";
            this.accountNumberTextBox.Size = new System.Drawing.Size(143, 26);
            this.accountNumberTextBox.TabIndex = 1;
            // 
            // accountIdLabel
            // 
            this.accountIdLabel.AutoSize = true;
            this.accountIdLabel.BackColor = System.Drawing.Color.White;
            this.accountIdLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.accountIdLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.accountIdLabel.Location = new System.Drawing.Point(68, 91);
            this.accountIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.accountIdLabel.Name = "accountIdLabel";
            this.accountIdLabel.Size = new System.Drawing.Size(95, 21);
            this.accountIdLabel.TabIndex = 2;
            this.accountIdLabel.Text = "Account #*";
            // 
            // accountIdTextBox
            // 
            this.accountIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.accountIdTextBox.Location = new System.Drawing.Point(233, 117);
            this.accountIdTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.accountIdTextBox.Mask = "000000000";
            this.accountIdTextBox.Name = "accountIdTextBox";
            this.accountIdTextBox.Size = new System.Drawing.Size(143, 26);
            this.accountIdTextBox.TabIndex = 3;
            // 
            // accountIdNumberLabel
            // 
            this.accountIdNumberLabel.AutoSize = true;
            this.accountIdNumberLabel.BackColor = System.Drawing.Color.White;
            this.accountIdNumberLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.accountIdNumberLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.accountIdNumberLabel.Location = new System.Drawing.Point(231, 90);
            this.accountIdNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.accountIdNumberLabel.Name = "accountIdNumberLabel";
            this.accountIdNumberLabel.Size = new System.Drawing.Size(117, 21);
            this.accountIdNumberLabel.TabIndex = 4;
            this.accountIdNumberLabel.Text = "Account ID #*";
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.BackColor = System.Drawing.Color.White;
            this.questionLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.questionLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.questionLabel.Location = new System.Drawing.Point(72, 209);
            this.questionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(86, 21);
            this.questionLabel.TabIndex = 5;
            this.questionLabel.Text = "Question*";
            // 
            // Answer
            // 
            this.Answer.AutoSize = true;
            this.Answer.BackColor = System.Drawing.Color.White;
            this.Answer.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.Answer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Answer.Location = new System.Drawing.Point(71, 268);
            this.Answer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(73, 21);
            this.Answer.TabIndex = 6;
            this.Answer.Text = "Answer*";
            // 
            // questionTextBox
            // 
            this.questionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.questionTextBox.Location = new System.Drawing.Point(74, 235);
            this.questionTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.Size = new System.Drawing.Size(305, 26);
            this.questionTextBox.TabIndex = 7;
            // 
            // answerTextBox
            // 
            this.answerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.answerTextBox.Location = new System.Drawing.Point(75, 294);
            this.answerTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(304, 26);
            this.answerTextBox.TabIndex = 8;
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.BackColor = System.Drawing.Color.White;
            this.moneyLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.moneyLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.moneyLabel.Location = new System.Drawing.Point(403, 90);
            this.moneyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(146, 21);
            this.moneyLabel.TabIndex = 9;
            this.moneyLabel.Text = "Transfer Amount*";
            // 
            // moneyTextBox
            // 
            this.moneyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.moneyTextBox.Location = new System.Drawing.Point(406, 117);
            this.moneyTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.moneyTextBox.Name = "moneyTextBox";
            this.moneyTextBox.Size = new System.Drawing.Size(143, 26);
            this.moneyTextBox.TabIndex = 10;
            this.moneyTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.moneyTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(68, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 26);
            this.label1.TabIndex = 30;
            this.label1.Text = "ACCOUNT INFORMATION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(67, 173);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 26);
            this.label2.TabIndex = 31;
            this.label2.Text = "SECURITY INFORMATION";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(385, 119);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 22);
            this.label6.TabIndex = 33;
            this.label6.Text = "$";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.Color.White;
            this.lbl2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(388, 354);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(161, 19);
            this.lbl2.TabIndex = 105;
            this.lbl2.Text = "XML Bank File Transfer";
            this.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(38, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(535, 382);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // transactionInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(178)))));
            this.ClientSize = new System.Drawing.Size(605, 434);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.moneyTextBox);
            this.Controls.Add(this.moneyLabel);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.questionTextBox);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.accountIdNumberLabel);
            this.Controls.Add(this.accountIdTextBox);
            this.Controls.Add(this.accountIdLabel);
            this.Controls.Add(this.accountNumberTextBox);
            this.Controls.Add(this.createFile);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "transactionInfo";
            this.Text = "XML Bank File Transfer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.transactionInfo_FormClosing);
            this.Load += new System.EventHandler(this.transactionInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createFile;
        private System.Windows.Forms.MaskedTextBox accountNumberTextBox;
        private System.Windows.Forms.Label accountIdLabel;
        private System.Windows.Forms.MaskedTextBox accountIdTextBox;
        private System.Windows.Forms.Label accountIdNumberLabel;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Label Answer;
        private System.Windows.Forms.TextBox questionTextBox;
        private System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.MaskedTextBox moneyTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl2;
    }
}