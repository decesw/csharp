namespace WsInfo
{
    partial class WsInfoForm
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
            System.Windows.Forms.Label tokenLabel;
            System.Windows.Forms.Button getWsInfoButton;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WsInfoForm));
            this.geodiUrlTextBox = new System.Windows.Forms.TextBox();
            this.tokenTextBox = new System.Windows.Forms.TextBox();
            this.wsNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resultTreeView = new System.Windows.Forms.TreeView();
            geodiUrlLabel = new System.Windows.Forms.Label();
            tokenLabel = new System.Windows.Forms.Label();
            getWsInfoButton = new System.Windows.Forms.Button();
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
            // tokenLabel
            // 
            tokenLabel.AutoSize = true;
            tokenLabel.Location = new System.Drawing.Point(13, 40);
            tokenLabel.Name = "tokenLabel";
            tokenLabel.Size = new System.Drawing.Size(38, 13);
            tokenLabel.TabIndex = 2;
            tokenLabel.Text = "Token";
            // 
            // getWsInfoButton
            // 
            getWsInfoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            getWsInfoButton.Location = new System.Drawing.Point(321, 91);
            getWsInfoButton.Name = "getWsInfoButton";
            getWsInfoButton.Size = new System.Drawing.Size(146, 23);
            getWsInfoButton.TabIndex = 4;
            getWsInfoButton.Text = "Get Workspace Information";
            getWsInfoButton.UseVisualStyleBackColor = true;
            getWsInfoButton.Click += new System.EventHandler(this.getWsInfoButton_Click);
            // 
            // geodiUrlTextBox
            // 
            this.geodiUrlTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.geodiUrlTextBox.Location = new System.Drawing.Point(115, 10);
            this.geodiUrlTextBox.Name = "geodiUrlTextBox";
            this.geodiUrlTextBox.Size = new System.Drawing.Size(352, 20);
            this.geodiUrlTextBox.TabIndex = 1;
            this.geodiUrlTextBox.Text = "http://127.0.0.1:3323";
            // 
            // tokenTextBox
            // 
            this.tokenTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tokenTextBox.Location = new System.Drawing.Point(115, 37);
            this.tokenTextBox.Name = "tokenTextBox";
            this.tokenTextBox.Size = new System.Drawing.Size(352, 20);
            this.tokenTextBox.TabIndex = 2;
            this.tokenTextBox.Text = resources.GetString("tokenTextBox.Text");
            // 
            // wsNameTextBox
            // 
            this.wsNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wsNameTextBox.Location = new System.Drawing.Point(115, 64);
            this.wsNameTextBox.Name = "wsNameTextBox";
            this.wsNameTextBox.Size = new System.Drawing.Size(352, 20);
            this.wsNameTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Workspace Name";
            // 
            // resultTreeView
            // 
            this.resultTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultTreeView.Location = new System.Drawing.Point(19, 121);
            this.resultTreeView.Name = "resultTreeView";
            this.resultTreeView.Size = new System.Drawing.Size(448, 220);
            this.resultTreeView.TabIndex = 5;
            this.resultTreeView.Visible = false;
            // 
            // WsInfoForm
            // 
            this.AcceptButton = getWsInfoButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 353);
            this.Controls.Add(this.resultTreeView);
            this.Controls.Add(getWsInfoButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wsNameTextBox);
            this.Controls.Add(this.tokenTextBox);
            this.Controls.Add(tokenLabel);
            this.Controls.Add(this.geodiUrlTextBox);
            this.Controls.Add(geodiUrlLabel);
            this.Name = "WsInfoForm";
            this.Text = "Workspace Information";
            this.Shown += new System.EventHandler(this.WsInfoForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox geodiUrlTextBox;
        private System.Windows.Forms.TextBox tokenTextBox;
        private System.Windows.Forms.TextBox wsNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView resultTreeView;
    }
}

