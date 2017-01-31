namespace Query
{
    partial class QueryForm
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
            System.Windows.Forms.Label wsNameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QueryForm));
            System.Windows.Forms.Label tokenLabel;
            System.Windows.Forms.Label geodiUrlLabel;
            System.Windows.Forms.Button summaryButton;
            System.Windows.Forms.Button kwButton;
            System.Windows.Forms.Button qButton;
            System.Windows.Forms.Button facetButton;
            System.Windows.Forms.Panel btnPanel;
            this.wsNameTextBox = new System.Windows.Forms.TextBox();
            this.tokenTextBox = new System.Windows.Forms.TextBox();
            this.geodiUrlTextBox = new System.Windows.Forms.TextBox();
            this.qTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resultTreeView = new System.Windows.Forms.TreeView();
            wsNameLabel = new System.Windows.Forms.Label();
            tokenLabel = new System.Windows.Forms.Label();
            geodiUrlLabel = new System.Windows.Forms.Label();
            summaryButton = new System.Windows.Forms.Button();
            kwButton = new System.Windows.Forms.Button();
            qButton = new System.Windows.Forms.Button();
            facetButton = new System.Windows.Forms.Button();
            btnPanel = new System.Windows.Forms.Panel();
            btnPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // wsNameLabel
            // 
            wsNameLabel.AutoSize = true;
            wsNameLabel.Location = new System.Drawing.Point(13, 13);
            wsNameLabel.Name = "wsNameLabel";
            wsNameLabel.Size = new System.Drawing.Size(93, 13);
            wsNameLabel.TabIndex = 0;
            wsNameLabel.Text = "Workspace Name";
            // 
            // wsNameTextBox
            // 
            this.wsNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wsNameTextBox.Location = new System.Drawing.Point(112, 10);
            this.wsNameTextBox.Name = "wsNameTextBox";
            this.wsNameTextBox.Size = new System.Drawing.Size(349, 20);
            this.wsNameTextBox.TabIndex = 1;
            // 
            // tokenTextBox
            // 
            this.tokenTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tokenTextBox.Location = new System.Drawing.Point(112, 37);
            this.tokenTextBox.Name = "tokenTextBox";
            this.tokenTextBox.Size = new System.Drawing.Size(349, 20);
            this.tokenTextBox.TabIndex = 2;
            this.tokenTextBox.Text = resources.GetString("tokenTextBox.Text");
            // 
            // tokenLabel
            // 
            tokenLabel.AutoSize = true;
            tokenLabel.Location = new System.Drawing.Point(13, 40);
            tokenLabel.Name = "tokenLabel";
            tokenLabel.Size = new System.Drawing.Size(38, 13);
            tokenLabel.TabIndex = 3;
            tokenLabel.Text = "Token";
            // 
            // geodiUrlTextBox
            // 
            this.geodiUrlTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.geodiUrlTextBox.Location = new System.Drawing.Point(112, 64);
            this.geodiUrlTextBox.Name = "geodiUrlTextBox";
            this.geodiUrlTextBox.Size = new System.Drawing.Size(349, 20);
            this.geodiUrlTextBox.TabIndex = 3;
            this.geodiUrlTextBox.Text = "http://127.0.0.1:3323";
            // 
            // geodiUrlLabel
            // 
            geodiUrlLabel.AutoSize = true;
            geodiUrlLabel.Location = new System.Drawing.Point(16, 67);
            geodiUrlLabel.Name = "geodiUrlLabel";
            geodiUrlLabel.Size = new System.Drawing.Size(66, 13);
            geodiUrlLabel.TabIndex = 5;
            geodiUrlLabel.Text = "GEODI URL";
            // 
            // qTextBox
            // 
            this.qTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.qTextBox.Location = new System.Drawing.Point(112, 91);
            this.qTextBox.Name = "qTextBox";
            this.qTextBox.Size = new System.Drawing.Size(349, 20);
            this.qTextBox.TabIndex = 4;
            // 
            // summaryButton
            // 
            summaryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            summaryButton.Location = new System.Drawing.Point(176, 3);
            summaryButton.Name = "summaryButton";
            summaryButton.Size = new System.Drawing.Size(89, 22);
            summaryButton.TabIndex = 7;
            summaryButton.Text = "Get Summaries";
            summaryButton.UseVisualStyleBackColor = true;
            summaryButton.Click += new System.EventHandler(this.summaryButton_Click);
            // 
            // kwButton
            // 
            kwButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            kwButton.Location = new System.Drawing.Point(86, 3);
            kwButton.Name = "kwButton";
            kwButton.Size = new System.Drawing.Size(84, 22);
            kwButton.TabIndex = 6;
            kwButton.Text = "Get Keywords";
            kwButton.UseVisualStyleBackColor = true;
            kwButton.Click += new System.EventHandler(this.kwButton_Click);
            // 
            // qButton
            // 
            qButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            qButton.Location = new System.Drawing.Point(5, 3);
            qButton.Name = "qButton";
            qButton.Size = new System.Drawing.Size(75, 22);
            qButton.TabIndex = 5;
            qButton.Text = "Query";
            qButton.UseVisualStyleBackColor = true;
            qButton.Click += new System.EventHandler(this.qButton_Click);
            // 
            // facetButton
            // 
            facetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            facetButton.Location = new System.Drawing.Point(271, 3);
            facetButton.Name = "facetButton";
            facetButton.Size = new System.Drawing.Size(75, 22);
            facetButton.TabIndex = 8;
            facetButton.Text = "Get Facet";
            facetButton.UseVisualStyleBackColor = true;
            facetButton.Click += new System.EventHandler(this.facetButton_Click);
            // 
            // btnPanel
            // 
            btnPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            btnPanel.Controls.Add(facetButton);
            btnPanel.Controls.Add(summaryButton);
            btnPanel.Controls.Add(qButton);
            btnPanel.Controls.Add(kwButton);
            btnPanel.Location = new System.Drawing.Point(112, 118);
            btnPanel.Name = "btnPanel";
            btnPanel.Size = new System.Drawing.Size(349, 28);
            btnPanel.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Query";
            // 
            // resultTreeView
            // 
            this.resultTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultTreeView.Location = new System.Drawing.Point(19, 153);
            this.resultTreeView.Name = "resultTreeView";
            this.resultTreeView.Size = new System.Drawing.Size(442, 223);
            this.resultTreeView.TabIndex = 9;
            this.resultTreeView.Visible = false;
            // 
            // QueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 388);
            this.Controls.Add(this.resultTreeView);
            this.Controls.Add(this.label1);
            this.Controls.Add(btnPanel);
            this.Controls.Add(this.qTextBox);
            this.Controls.Add(geodiUrlLabel);
            this.Controls.Add(this.geodiUrlTextBox);
            this.Controls.Add(tokenLabel);
            this.Controls.Add(this.tokenTextBox);
            this.Controls.Add(this.wsNameTextBox);
            this.Controls.Add(wsNameLabel);
            this.Name = "QueryForm";
            this.Text = "Query";
            btnPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox wsNameTextBox;
        private System.Windows.Forms.TextBox tokenTextBox;
        private System.Windows.Forms.TextBox geodiUrlTextBox;
        private System.Windows.Forms.TextBox qTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView resultTreeView;
    }
}

