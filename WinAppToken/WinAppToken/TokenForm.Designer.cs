namespace WinAppToken
{
    partial class TokenForm
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
            System.Windows.Forms.Label geodiUrlLabel;
            System.Windows.Forms.Label usrLabel;
            System.Windows.Forms.Label pswLabel;
            System.Windows.Forms.Button createButton;
            System.Windows.Forms.Label tokenLabel;
            this.geodiUrlTextBox = new System.Windows.Forms.TextBox();
            this.usrTextBox = new System.Windows.Forms.TextBox();
            this.pswTextBox = new System.Windows.Forms.TextBox();
            this.qCheckBox = new System.Windows.Forms.CheckBox();
            this.recognizeCheckBox = new System.Windows.Forms.CheckBox();
            this.wsInfCheckBox = new System.Windows.Forms.CheckBox();
            this.feedCheckBox = new System.Windows.Forms.CheckBox();
            this.wsNameLabel = new System.Windows.Forms.Label();
            this.wsNameTextBox = new System.Windows.Forms.TextBox();
            this.enumIDLabel = new System.Windows.Forms.Label();
            this.enumIDTextBox = new System.Windows.Forms.TextBox();
            this.tokenRichTextBox = new System.Windows.Forms.RichTextBox();
            geodiUrlLabel = new System.Windows.Forms.Label();
            usrLabel = new System.Windows.Forms.Label();
            pswLabel = new System.Windows.Forms.Label();
            createButton = new System.Windows.Forms.Button();
            tokenLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // geodiUrlLabel
            // 
            geodiUrlLabel.AutoSize = true;
            geodiUrlLabel.Location = new System.Drawing.Point(13, 13);
            geodiUrlLabel.Name = "geodiUrlLabel";
            geodiUrlLabel.Size = new System.Drawing.Size(66, 13);
            geodiUrlLabel.TabIndex = 0;
            geodiUrlLabel.Text = "GEODI URL";
            // 
            // usrLabel
            // 
            usrLabel.AutoSize = true;
            usrLabel.Location = new System.Drawing.Point(13, 40);
            usrLabel.Name = "usrLabel";
            usrLabel.Size = new System.Drawing.Size(55, 13);
            usrLabel.TabIndex = 2;
            usrLabel.Text = "Username";
            // 
            // pswLabel
            // 
            pswLabel.AutoSize = true;
            pswLabel.Location = new System.Drawing.Point(13, 67);
            pswLabel.Name = "pswLabel";
            pswLabel.Size = new System.Drawing.Size(53, 13);
            pswLabel.TabIndex = 3;
            pswLabel.Text = "Password";
            // 
            // createButton
            // 
            createButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            createButton.Location = new System.Drawing.Point(314, 237);
            createButton.Name = "createButton";
            createButton.Size = new System.Drawing.Size(75, 23);
            createButton.TabIndex = 9;
            createButton.Text = "Create";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // tokenLabel
            // 
            tokenLabel.AutoSize = true;
            tokenLabel.Location = new System.Drawing.Point(13, 270);
            tokenLabel.Name = "tokenLabel";
            tokenLabel.Size = new System.Drawing.Size(38, 13);
            tokenLabel.TabIndex = 11;
            tokenLabel.Text = "Token";
            // 
            // geodiUrlTextBox
            // 
            this.geodiUrlTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.geodiUrlTextBox.Location = new System.Drawing.Point(85, 10);
            this.geodiUrlTextBox.Name = "geodiUrlTextBox";
            this.geodiUrlTextBox.Size = new System.Drawing.Size(305, 20);
            this.geodiUrlTextBox.TabIndex = 0;
            this.geodiUrlTextBox.Text = "http://127.0.0.1:3323";
            // 
            // usrTextBox
            // 
            this.usrTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usrTextBox.Location = new System.Drawing.Point(85, 37);
            this.usrTextBox.Name = "usrTextBox";
            this.usrTextBox.Size = new System.Drawing.Size(305, 20);
            this.usrTextBox.TabIndex = 1;
            // 
            // pswTextBox
            // 
            this.pswTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pswTextBox.Location = new System.Drawing.Point(85, 64);
            this.pswTextBox.Name = "pswTextBox";
            this.pswTextBox.Size = new System.Drawing.Size(305, 20);
            this.pswTextBox.TabIndex = 2;
            this.pswTextBox.UseSystemPasswordChar = true;
            // 
            // qCheckBox
            // 
            this.qCheckBox.AutoSize = true;
            this.qCheckBox.Checked = true;
            this.qCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.qCheckBox.Location = new System.Drawing.Point(85, 91);
            this.qCheckBox.Name = "qCheckBox";
            this.qCheckBox.Size = new System.Drawing.Size(54, 17);
            this.qCheckBox.TabIndex = 3;
            this.qCheckBox.Text = "Query";
            this.qCheckBox.UseVisualStyleBackColor = true;
            // 
            // recognizeCheckBox
            // 
            this.recognizeCheckBox.AutoSize = true;
            this.recognizeCheckBox.Checked = true;
            this.recognizeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.recognizeCheckBox.Location = new System.Drawing.Point(85, 115);
            this.recognizeCheckBox.Name = "recognizeCheckBox";
            this.recognizeCheckBox.Size = new System.Drawing.Size(77, 17);
            this.recognizeCheckBox.TabIndex = 4;
            this.recognizeCheckBox.Text = "Recognize";
            this.recognizeCheckBox.UseVisualStyleBackColor = true;
            // 
            // wsInfCheckBox
            // 
            this.wsInfCheckBox.AutoSize = true;
            this.wsInfCheckBox.Checked = true;
            this.wsInfCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.wsInfCheckBox.Location = new System.Drawing.Point(85, 139);
            this.wsInfCheckBox.Name = "wsInfCheckBox";
            this.wsInfCheckBox.Size = new System.Drawing.Size(99, 17);
            this.wsInfCheckBox.TabIndex = 5;
            this.wsInfCheckBox.Text = "WorkspaceInfo";
            this.wsInfCheckBox.UseVisualStyleBackColor = true;
            // 
            // feedCheckBox
            // 
            this.feedCheckBox.AutoSize = true;
            this.feedCheckBox.Location = new System.Drawing.Point(85, 163);
            this.feedCheckBox.Name = "feedCheckBox";
            this.feedCheckBox.Size = new System.Drawing.Size(50, 17);
            this.feedCheckBox.TabIndex = 6;
            this.feedCheckBox.Text = "Feed";
            this.feedCheckBox.UseVisualStyleBackColor = true;
            this.feedCheckBox.CheckedChanged += new System.EventHandler(this.feedCheckBox_CheckedChanged);
            // 
            // wsNameLabel
            // 
            this.wsNameLabel.AutoSize = true;
            this.wsNameLabel.Enabled = false;
            this.wsNameLabel.Location = new System.Drawing.Point(82, 187);
            this.wsNameLabel.Name = "wsNameLabel";
            this.wsNameLabel.Size = new System.Drawing.Size(93, 13);
            this.wsNameLabel.TabIndex = 7;
            this.wsNameLabel.Text = "Workspace Name";
            // 
            // wsNameTextBox
            // 
            this.wsNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wsNameTextBox.Enabled = false;
            this.wsNameTextBox.Location = new System.Drawing.Point(184, 184);
            this.wsNameTextBox.Name = "wsNameTextBox";
            this.wsNameTextBox.Size = new System.Drawing.Size(206, 20);
            this.wsNameTextBox.TabIndex = 7;
            // 
            // enumIDLabel
            // 
            this.enumIDLabel.AutoSize = true;
            this.enumIDLabel.Enabled = false;
            this.enumIDLabel.Location = new System.Drawing.Point(82, 213);
            this.enumIDLabel.Name = "enumIDLabel";
            this.enumIDLabel.Size = new System.Drawing.Size(75, 13);
            this.enumIDLabel.TabIndex = 8;
            this.enumIDLabel.Text = "Enumerator ID";
            // 
            // enumIDTextBox
            // 
            this.enumIDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.enumIDTextBox.Enabled = false;
            this.enumIDTextBox.Location = new System.Drawing.Point(184, 210);
            this.enumIDTextBox.Name = "enumIDTextBox";
            this.enumIDTextBox.Size = new System.Drawing.Size(206, 20);
            this.enumIDTextBox.TabIndex = 8;
            // 
            // tokenRichTextBox
            // 
            this.tokenRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tokenRichTextBox.Location = new System.Drawing.Point(57, 267);
            this.tokenRichTextBox.Name = "tokenRichTextBox";
            this.tokenRichTextBox.Size = new System.Drawing.Size(332, 59);
            this.tokenRichTextBox.TabIndex = 10;
            this.tokenRichTextBox.Text = "";
            // 
            // TokenForm
            // 
            this.AcceptButton = createButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 338);
            this.Controls.Add(this.tokenRichTextBox);
            this.Controls.Add(tokenLabel);
            this.Controls.Add(createButton);
            this.Controls.Add(this.enumIDTextBox);
            this.Controls.Add(this.enumIDLabel);
            this.Controls.Add(this.wsNameTextBox);
            this.Controls.Add(this.wsNameLabel);
            this.Controls.Add(this.feedCheckBox);
            this.Controls.Add(this.wsInfCheckBox);
            this.Controls.Add(this.recognizeCheckBox);
            this.Controls.Add(this.qCheckBox);
            this.Controls.Add(pswLabel);
            this.Controls.Add(this.pswTextBox);
            this.Controls.Add(usrLabel);
            this.Controls.Add(this.usrTextBox);
            this.Controls.Add(this.geodiUrlTextBox);
            this.Controls.Add(geodiUrlLabel);
            this.Name = "TokenForm";
            this.Text = "Token API";
            this.Shown += new System.EventHandler(this.TokenForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox geodiUrlTextBox;
        private System.Windows.Forms.TextBox usrTextBox;
        private System.Windows.Forms.TextBox pswTextBox;
        private System.Windows.Forms.CheckBox qCheckBox;
        private System.Windows.Forms.CheckBox recognizeCheckBox;
        private System.Windows.Forms.CheckBox wsInfCheckBox;
        private System.Windows.Forms.CheckBox feedCheckBox;
        private System.Windows.Forms.Label wsNameLabel;
        private System.Windows.Forms.TextBox wsNameTextBox;
        private System.Windows.Forms.Label enumIDLabel;
        private System.Windows.Forms.TextBox enumIDTextBox;
        private System.Windows.Forms.RichTextBox tokenRichTextBox;
    }
}

