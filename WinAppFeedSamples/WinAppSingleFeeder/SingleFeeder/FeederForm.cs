using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Windows.Forms;

namespace SingleFeeder
{
    public partial class FeederForm : Form
    {
        string Token
        {
            get { return tokenTextBox.Text; }
        }

        string GeodiUrl
        {
            get { return geodiUrlTextBox.Text.Trim(); }
        }

        string FileName
        {
            get { return fileTextBox.Text.Trim('"').Trim(); }
            set { fileTextBox.Text = value.Trim('"').Trim(); }
        }

        public FeederForm()
        {
            InitializeComponent();
        }

        void browseButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                FileName = openFileDialog.FileName;
        }

        void okButon_Click(object sender, EventArgs e)
        {
            if(CheckInput())
            {
                var client = new WebClient() { BaseAddress = GeodiUrl };
                client.QueryString["op"] = "Feed";
                client.QueryString["fileName"] = HttpUtility.UrlEncode(Path.GetFileName(FileName));
                client.QueryString["UserSession"] = HttpUtility.UrlEncode(Token);

                try
                {
                    client.UploadData("FeedHandler", File.ReadAllBytes(FileName));
                }
                catch (Exception ex)
                {
                    ShowError(ex);
                    return;
                }
                MessageBox.Show("Feed complete.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        bool CheckInput()
        {
            if (string.IsNullOrEmpty(GeodiUrl))
            {
                ShowError("Please enter GEODI URL.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(Token))
            {
                ShowError("Please set token.");
                return false;
            }
            if(string.IsNullOrEmpty(FileName))
            {
                ShowError("Please select a file.");
            }
            return true;
        }

        static void ShowError(Exception ex)
        {
            ShowError(ex.Message + Environment.NewLine + Environment.NewLine + ex.StackTrace);
        }

        static void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
