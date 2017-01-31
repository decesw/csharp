namespace DataExtraction
{
    partial class RecognizeForm
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
            System.Windows.Forms.TabControl tabControl;
            System.Windows.Forms.TabPage lContentPage;
            System.Windows.Forms.Button recognizeLocalContentButton;
            System.Windows.Forms.Button browseButton;
            System.Windows.Forms.Label fileLabel;
            System.Windows.Forms.TabPage contentPage;
            System.Windows.Forms.Button recognizeContentButton;
            System.Windows.Forms.Label displayNameLabel;
            System.Windows.Forms.Label contentUrlLabel;
            System.Windows.Forms.TabPage textPage;
            System.Windows.Forms.Button recognizeTextButton;
            System.Windows.Forms.Label recognizeTextLabel;
            System.Windows.Forms.Label wsNameLabel;
            System.Windows.Forms.Label tokenLabel;
            System.Windows.Forms.Label urlLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecognizeForm));
            this.localContentResultTreeView = new System.Windows.Forms.TreeView();
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.contentResultTreeView = new System.Windows.Forms.TreeView();
            this.displayNameTextBox = new System.Windows.Forms.TextBox();
            this.contentUrlTextBox = new System.Windows.Forms.TextBox();
            this.textResultTreeView = new System.Windows.Forms.TreeView();
            this.recognizeTextBox = new System.Windows.Forms.TextBox();
            this.wsNameTextBox = new System.Windows.Forms.TextBox();
            this.tokenTextBox = new System.Windows.Forms.TextBox();
            this.geodiUrlTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            tabControl = new System.Windows.Forms.TabControl();
            lContentPage = new System.Windows.Forms.TabPage();
            recognizeLocalContentButton = new System.Windows.Forms.Button();
            browseButton = new System.Windows.Forms.Button();
            fileLabel = new System.Windows.Forms.Label();
            contentPage = new System.Windows.Forms.TabPage();
            recognizeContentButton = new System.Windows.Forms.Button();
            displayNameLabel = new System.Windows.Forms.Label();
            contentUrlLabel = new System.Windows.Forms.Label();
            textPage = new System.Windows.Forms.TabPage();
            recognizeTextButton = new System.Windows.Forms.Button();
            recognizeTextLabel = new System.Windows.Forms.Label();
            wsNameLabel = new System.Windows.Forms.Label();
            tokenLabel = new System.Windows.Forms.Label();
            urlLabel = new System.Windows.Forms.Label();
            tabControl.SuspendLayout();
            lContentPage.SuspendLayout();
            contentPage.SuspendLayout();
            textPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            tabControl.Controls.Add(lContentPage);
            tabControl.Controls.Add(contentPage);
            tabControl.Controls.Add(textPage);
            tabControl.Location = new System.Drawing.Point(12, 86);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new System.Drawing.Size(446, 346);
            tabControl.TabIndex = 0;
            tabControl.TabStop = false;
            // 
            // lContentPage
            // 
            lContentPage.Controls.Add(this.localContentResultTreeView);
            lContentPage.Controls.Add(recognizeLocalContentButton);
            lContentPage.Controls.Add(browseButton);
            lContentPage.Controls.Add(this.fileNameTextBox);
            lContentPage.Controls.Add(fileLabel);
            lContentPage.Location = new System.Drawing.Point(4, 22);
            lContentPage.Name = "lContentPage";
            lContentPage.Padding = new System.Windows.Forms.Padding(3);
            lContentPage.Size = new System.Drawing.Size(438, 320);
            lContentPage.TabIndex = 0;
            lContentPage.Text = "Recognize Local Content";
            lContentPage.UseVisualStyleBackColor = true;
            // 
            // localContentResultTreeView
            // 
            this.localContentResultTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.localContentResultTreeView.Location = new System.Drawing.Point(6, 64);
            this.localContentResultTreeView.Name = "localContentResultTreeView";
            this.localContentResultTreeView.Size = new System.Drawing.Size(426, 250);
            this.localContentResultTreeView.TabIndex = 7;
            this.localContentResultTreeView.Visible = false;
            // 
            // recognizeLocalContentButton
            // 
            recognizeLocalContentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            recognizeLocalContentButton.Location = new System.Drawing.Point(324, 35);
            recognizeLocalContentButton.Name = "recognizeLocalContentButton";
            recognizeLocalContentButton.Size = new System.Drawing.Size(108, 23);
            recognizeLocalContentButton.TabIndex = 6;
            recognizeLocalContentButton.Text = "Recognize Content";
            recognizeLocalContentButton.UseVisualStyleBackColor = true;
            recognizeLocalContentButton.Click += new System.EventHandler(this.recognizeLocalContentButton_Click);
            // 
            // browseButton
            // 
            browseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            browseButton.Location = new System.Drawing.Point(324, 6);
            browseButton.Name = "browseButton";
            browseButton.Size = new System.Drawing.Size(108, 23);
            browseButton.TabIndex = 5;
            browseButton.Text = "Browse";
            browseButton.UseVisualStyleBackColor = true;
            browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileNameTextBox.Location = new System.Drawing.Point(35, 8);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(283, 20);
            this.fileNameTextBox.TabIndex = 4;
            // 
            // fileLabel
            // 
            fileLabel.AutoSize = true;
            fileLabel.Location = new System.Drawing.Point(6, 11);
            fileLabel.Name = "fileLabel";
            fileLabel.Size = new System.Drawing.Size(23, 13);
            fileLabel.TabIndex = 0;
            fileLabel.Text = "File";
            // 
            // contentPage
            // 
            contentPage.Controls.Add(this.contentResultTreeView);
            contentPage.Controls.Add(recognizeContentButton);
            contentPage.Controls.Add(displayNameLabel);
            contentPage.Controls.Add(this.displayNameTextBox);
            contentPage.Controls.Add(this.contentUrlTextBox);
            contentPage.Controls.Add(contentUrlLabel);
            contentPage.Location = new System.Drawing.Point(4, 22);
            contentPage.Name = "contentPage";
            contentPage.Padding = new System.Windows.Forms.Padding(3);
            contentPage.Size = new System.Drawing.Size(438, 320);
            contentPage.TabIndex = 1;
            contentPage.Text = "Recognize Content";
            contentPage.UseVisualStyleBackColor = true;
            // 
            // contentResultTreeView
            // 
            this.contentResultTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contentResultTreeView.Location = new System.Drawing.Point(6, 89);
            this.contentResultTreeView.Name = "contentResultTreeView";
            this.contentResultTreeView.Size = new System.Drawing.Size(426, 225);
            this.contentResultTreeView.TabIndex = 11;
            // 
            // recognizeContentButton
            // 
            recognizeContentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            recognizeContentButton.Location = new System.Drawing.Point(321, 60);
            recognizeContentButton.Name = "recognizeContentButton";
            recognizeContentButton.Size = new System.Drawing.Size(111, 23);
            recognizeContentButton.TabIndex = 10;
            recognizeContentButton.Text = "Recognize Content";
            recognizeContentButton.UseVisualStyleBackColor = true;
            recognizeContentButton.Click += new System.EventHandler(this.recognizeContentButton_Click);
            // 
            // displayNameLabel
            // 
            displayNameLabel.AutoSize = true;
            displayNameLabel.Location = new System.Drawing.Point(8, 37);
            displayNameLabel.Name = "displayNameLabel";
            displayNameLabel.Size = new System.Drawing.Size(72, 13);
            displayNameLabel.TabIndex = 3;
            displayNameLabel.Text = "Display Name";
            // 
            // displayNameTextBox
            // 
            this.displayNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displayNameTextBox.Location = new System.Drawing.Point(83, 34);
            this.displayNameTextBox.Name = "displayNameTextBox";
            this.displayNameTextBox.Size = new System.Drawing.Size(349, 20);
            this.displayNameTextBox.TabIndex = 9;
            // 
            // contentUrlTextBox
            // 
            this.contentUrlTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contentUrlTextBox.Location = new System.Drawing.Point(83, 7);
            this.contentUrlTextBox.Name = "contentUrlTextBox";
            this.contentUrlTextBox.Size = new System.Drawing.Size(349, 20);
            this.contentUrlTextBox.TabIndex = 8;
            // 
            // contentUrlLabel
            // 
            contentUrlLabel.AutoSize = true;
            contentUrlLabel.Location = new System.Drawing.Point(8, 10);
            contentUrlLabel.Name = "contentUrlLabel";
            contentUrlLabel.Size = new System.Drawing.Size(69, 13);
            contentUrlLabel.TabIndex = 0;
            contentUrlLabel.Text = "Content URL";
            // 
            // textPage
            // 
            textPage.Controls.Add(this.textResultTreeView);
            textPage.Controls.Add(recognizeTextButton);
            textPage.Controls.Add(this.recognizeTextBox);
            textPage.Controls.Add(recognizeTextLabel);
            textPage.Location = new System.Drawing.Point(4, 22);
            textPage.Name = "textPage";
            textPage.Padding = new System.Windows.Forms.Padding(3);
            textPage.Size = new System.Drawing.Size(438, 320);
            textPage.TabIndex = 2;
            textPage.Text = "Recognize Text";
            textPage.UseVisualStyleBackColor = true;
            // 
            // textResultTreeView
            // 
            this.textResultTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textResultTreeView.Location = new System.Drawing.Point(6, 94);
            this.textResultTreeView.Name = "textResultTreeView";
            this.textResultTreeView.Size = new System.Drawing.Size(426, 220);
            this.textResultTreeView.TabIndex = 14;
            this.textResultTreeView.Visible = false;
            // 
            // recognizeTextButton
            // 
            recognizeTextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            recognizeTextButton.Location = new System.Drawing.Point(332, 65);
            recognizeTextButton.Name = "recognizeTextButton";
            recognizeTextButton.Size = new System.Drawing.Size(100, 23);
            recognizeTextButton.TabIndex = 13;
            recognizeTextButton.Text = "Recognize Text";
            recognizeTextButton.UseVisualStyleBackColor = true;
            recognizeTextButton.Click += new System.EventHandler(this.recognizeTextButton_Click);
            // 
            // recognizeTextBox
            // 
            this.recognizeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.recognizeTextBox.Location = new System.Drawing.Point(41, 7);
            this.recognizeTextBox.Multiline = true;
            this.recognizeTextBox.Name = "recognizeTextBox";
            this.recognizeTextBox.Size = new System.Drawing.Size(391, 52);
            this.recognizeTextBox.TabIndex = 12;
            // 
            // recognizeTextLabel
            // 
            recognizeTextLabel.AutoSize = true;
            recognizeTextLabel.Location = new System.Drawing.Point(6, 10);
            recognizeTextLabel.Name = "recognizeTextLabel";
            recognizeTextLabel.Size = new System.Drawing.Size(28, 13);
            recognizeTextLabel.TabIndex = 0;
            recognizeTextLabel.Text = "Text";
            // 
            // wsNameLabel
            // 
            wsNameLabel.AutoSize = true;
            wsNameLabel.Location = new System.Drawing.Point(12, 9);
            wsNameLabel.Name = "wsNameLabel";
            wsNameLabel.Size = new System.Drawing.Size(93, 13);
            wsNameLabel.TabIndex = 1;
            wsNameLabel.Text = "Workspace Name";
            // 
            // tokenLabel
            // 
            tokenLabel.AutoSize = true;
            tokenLabel.Location = new System.Drawing.Point(13, 36);
            tokenLabel.Name = "tokenLabel";
            tokenLabel.Size = new System.Drawing.Size(38, 13);
            tokenLabel.TabIndex = 3;
            tokenLabel.Text = "Token";
            // 
            // urlLabel
            // 
            urlLabel.AutoSize = true;
            urlLabel.Location = new System.Drawing.Point(12, 63);
            urlLabel.Name = "urlLabel";
            urlLabel.Size = new System.Drawing.Size(60, 13);
            urlLabel.TabIndex = 5;
            urlLabel.Text = "Geodi URL";
            // 
            // wsNameTextBox
            // 
            this.wsNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wsNameTextBox.Location = new System.Drawing.Point(111, 6);
            this.wsNameTextBox.Name = "wsNameTextBox";
            this.wsNameTextBox.Size = new System.Drawing.Size(343, 20);
            this.wsNameTextBox.TabIndex = 1;
            // 
            // tokenTextBox
            // 
            this.tokenTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tokenTextBox.Location = new System.Drawing.Point(111, 33);
            this.tokenTextBox.Name = "tokenTextBox";
            this.tokenTextBox.Size = new System.Drawing.Size(343, 20);
            this.tokenTextBox.TabIndex = 2;
            this.tokenTextBox.Text = resources.GetString("tokenTextBox.Text");
            // 
            // geodiUrlTextBox
            // 
            this.geodiUrlTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.geodiUrlTextBox.Location = new System.Drawing.Point(111, 60);
            this.geodiUrlTextBox.Name = "geodiUrlTextBox";
            this.geodiUrlTextBox.Size = new System.Drawing.Size(343, 20);
            this.geodiUrlTextBox.TabIndex = 3;
            this.geodiUrlTextBox.Text = "http://127.0.0.1:3323";
            // 
            // RecognizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 444);
            this.Controls.Add(this.geodiUrlTextBox);
            this.Controls.Add(urlLabel);
            this.Controls.Add(this.tokenTextBox);
            this.Controls.Add(tokenLabel);
            this.Controls.Add(this.wsNameTextBox);
            this.Controls.Add(wsNameLabel);
            this.Controls.Add(tabControl);
            this.Name = "RecognizeForm";
            this.Text = "Data Extraction";
            tabControl.ResumeLayout(false);
            lContentPage.ResumeLayout(false);
            lContentPage.PerformLayout();
            contentPage.ResumeLayout(false);
            contentPage.PerformLayout();
            textPage.ResumeLayout(false);
            textPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox wsNameTextBox;
        private System.Windows.Forms.TextBox tokenTextBox;
        private System.Windows.Forms.TextBox geodiUrlTextBox;
        private System.Windows.Forms.TextBox fileNameTextBox;
        private System.Windows.Forms.TextBox displayNameTextBox;
        private System.Windows.Forms.TextBox contentUrlTextBox;
        private System.Windows.Forms.TextBox recognizeTextBox;
        private System.Windows.Forms.TreeView localContentResultTreeView;
        private System.Windows.Forms.TreeView contentResultTreeView;
        private System.Windows.Forms.TreeView textResultTreeView;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

