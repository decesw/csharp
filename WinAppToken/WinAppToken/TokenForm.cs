using System;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Windows.Forms;

namespace WinAppToken
{
    public partial class TokenForm : Form
    {
        enum TokenTarget
        {
            Feed = 1,
            Query = 2,
            Recognize = 4,
            WsInfo = 8,
            ClientToken = 16,
            Any= 256
        }

        string GeodiUrl { get { return geodiUrlTextBox.Text.Trim(); } }
        string User { get { return usrTextBox.Text; } }
        string Pass { get { return pswTextBox.Text; } }
        bool IsQSelected { get { return qCheckBox.Checked; } }
        bool IsRecognizeSelected { get { return recognizeCheckBox.Checked; } }
        bool IsWsInfSelected { get { return wsInfCheckBox.Checked; } }
        bool IsFeedSelected { get { return feedCheckBox.Checked; } }
        bool IsClientTokenSelected { get { return chkClienToken.Checked; } }
        string WsName { get { return wsNameTextBox.Text; } }
        string EnumID { get { return enumIDTextBox.Text; } }
        string Token { set { tokenRichTextBox.Text = value; } }

        public TokenForm()
        {
            InitializeComponent();
        }

        void TokenForm_Shown(object sender, EventArgs e)
        {
            usrTextBox.Focus();
        }

        void createButton_Click(object sender, EventArgs e)
        {
            if(CheckInput())
            {
                var request = (HttpWebRequest)WebRequest.Create(GeodiUrl + "/TokenHandler?op=CreateTokenForUser");
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";

                TokenTarget tokenTarget = 0;
                if (IsQSelected) tokenTarget |= TokenTarget.Query;
                if (IsRecognizeSelected) tokenTarget |= TokenTarget.Recognize;
                if (IsWsInfSelected) tokenTarget |= TokenTarget.WsInfo;
                if (IsFeedSelected) tokenTarget |= TokenTarget.Feed;
                if (IsClientTokenSelected) tokenTarget |= TokenTarget.ClientToken;

                int tokenTargetVal = Convert.ToInt32(tokenTarget);
                string Username = HttpUtility.UrlEncode(User);
                string Password = HttpUtility.UrlEncode(Pass);
                var allDataString = string.Concat("tokenTarget=", tokenTargetVal, "&Username=", Username, "&Password=", Password);

                if (IsFeedSelected)
                {
                    string wsName = HttpUtility.UrlEncode(WsName);
                    string enumID = HttpUtility.UrlEncode(EnumID);
                    allDataString = string.Concat(allDataString, "&wsName=", wsName, "&enumeratorId=", enumID);
                }

                byte[] allData = Encoding.UTF8.GetBytes(allDataString);

                Stream stream = request.GetRequestStream();
                try
                {
                    stream.Write(allData, 0, allData.Length);
                    stream.Flush();
                }
                catch (Exception ex)
                {
                    ShowError(ex);
                    return;
                }
                finally
                {
                    stream.Close();
                }

                Token = "";
                try
                {
                    GetRecognizeResult(request);
                }
                catch (Exception ex)
                {
                    ShowError(ex);
                }
            }
        }

        void feedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            wsNameLabel.Enabled = feedCheckBox.Checked;
            wsNameTextBox.Enabled = feedCheckBox.Checked;
            enumIDLabel.Enabled = feedCheckBox.Checked;
            enumIDTextBox.Enabled = feedCheckBox.Checked;
        }

        void GetRecognizeResult(WebRequest request)
        {
            using (WebResponse response = request.GetResponse())
            using (Stream responseStream = response.GetResponseStream())
            using (var reader = new StreamReader(responseStream))
                Token = Unescape(reader.ReadToEnd());
        }

        string Unescape(string s)
        {
            int startIndex = s[0] == '"' ? 1 : 0;
            int length = s.Length - startIndex - (s[s.Length - 1] == '"' ? 1 : 0);
            return Regex.Unescape(s.Substring(startIndex, length));
        }

        bool CheckInput()
        {
            if (string.IsNullOrEmpty(GeodiUrl))
            {
                ShowError("Please enter GEODI URL.");
                return false;
            }
            if(string.IsNullOrWhiteSpace(User))
            {
                ShowError("Please enter username.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(User))
            {
                ShowError("Please enter password.");
                return false;
            }
            if(!(IsQSelected || IsRecognizeSelected || IsWsInfSelected || IsFeedSelected))
            {
                ShowError("You must select at least one option.");
                return true;
            }
            if(IsFeedSelected)
            {
                if(string.IsNullOrWhiteSpace(WsName))
                {
                    ShowError("You must enter workspace name for feed token.");
                    return false;
                }
                if(string.IsNullOrWhiteSpace(EnumID))
                {
                    ShowError("You must enter layer ID for feed token.");
                    return false;
                }
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
