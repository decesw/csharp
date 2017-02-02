namespace SingleFeeder
{
    partial class FeederForm
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
            System.Windows.Forms.Button browseButton;
            System.Windows.Forms.Label fileLabel;
            System.Windows.Forms.Label tokenLabel;
            System.Windows.Forms.Button okButon;
            this.fileTextBox = new System.Windows.Forms.TextBox();
            this.tokenTextBox = new System.Windows.Forms.TextBox();
            this.geodiUrlLabel = new System.Windows.Forms.Label();
            this.geodiUrlTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            browseButton = new System.Windows.Forms.Button();
            fileLabel = new System.Windows.Forms.Label();
            tokenLabel = new System.Windows.Forms.Label();
            okButon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fileTextBox
            // 
            this.fileTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileTextBox.Location = new System.Drawing.Point(84, 12);
            this.fileTextBox.Name = "fileTextBox";
            this.fileTextBox.Size = new System.Drawing.Size(334, 20);
            this.fileTextBox.TabIndex = 0;
            // 
            // browseButton
            // 
            browseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            browseButton.Location = new System.Drawing.Point(424, 10);
            browseButton.Name = "browseButton";
            browseButton.Size = new System.Drawing.Size(75, 23);
            browseButton.TabIndex = 1;
            browseButton.Text = "Browse";
            browseButton.UseVisualStyleBackColor = true;
            browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // fileLabel
            // 
            fileLabel.AutoSize = true;
            fileLabel.Location = new System.Drawing.Point(12, 17);
            fileLabel.Name = "fileLabel";
            fileLabel.Size = new System.Drawing.Size(23, 13);
            fileLabel.TabIndex = 2;
            fileLabel.Text = "File";
            // 
            // tokenLabel
            // 
            tokenLabel.AutoSize = true;
            tokenLabel.Location = new System.Drawing.Point(12, 43);
            tokenLabel.Name = "tokenLabel";
            tokenLabel.Size = new System.Drawing.Size(38, 13);
            tokenLabel.TabIndex = 3;
            tokenLabel.Text = "Token";
            // 
            // tokenTextBox
            // 
            this.tokenTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tokenTextBox.Location = new System.Drawing.Point(84, 40);
            this.tokenTextBox.Name = "tokenTextBox";
            this.tokenTextBox.Size = new System.Drawing.Size(415, 20);
            this.tokenTextBox.TabIndex = 2;
            // 
            // geodiUrlLabel
            // 
            this.geodiUrlLabel.AutoSize = true;
            this.geodiUrlLabel.Location = new System.Drawing.Point(12, 72);
            this.geodiUrlLabel.Name = "geodiUrlLabel";
            this.geodiUrlLabel.Size = new System.Drawing.Size(66, 13);
            this.geodiUrlLabel.TabIndex = 5;
            this.geodiUrlLabel.Text = "GEODI URL";
            // 
            // geodiUrlTextBox
            // 
            this.geodiUrlTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.geodiUrlTextBox.Location = new System.Drawing.Point(84, 67);
            this.geodiUrlTextBox.Name = "geodiUrlTextBox";
            this.geodiUrlTextBox.Size = new System.Drawing.Size(415, 20);
            this.geodiUrlTextBox.TabIndex = 3;
            this.geodiUrlTextBox.Text = "http://127.0.0.1:3323";
            // 
            // okButon
            // 
            okButon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            okButon.Location = new System.Drawing.Point(424, 93);
            okButon.Name = "okButon";
            okButon.Size = new System.Drawing.Size(75, 23);
            okButon.TabIndex = 4;
            okButon.Text = "OK";
            okButon.UseVisualStyleBackColor = true;
            okButon.Click += new System.EventHandler(this.okButon_Click);
            // 
            // FeederForm
            // 
            this.AcceptButton = okButon;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 124);
            this.Controls.Add(okButon);
            this.Controls.Add(this.geodiUrlTextBox);
            this.Controls.Add(this.geodiUrlLabel);
            this.Controls.Add(this.tokenTextBox);
            this.Controls.Add(tokenLabel);
            this.Controls.Add(fileLabel);
            this.Controls.Add(browseButton);
            this.Controls.Add(this.fileTextBox);
            this.Name = "FeederForm";
            this.Text = "Feeder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fileTextBox;
        private System.Windows.Forms.TextBox tokenTextBox;
        private System.Windows.Forms.Label geodiUrlLabel;
        private System.Windows.Forms.TextBox geodiUrlTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

