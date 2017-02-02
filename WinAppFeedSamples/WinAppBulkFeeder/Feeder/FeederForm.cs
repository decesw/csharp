using Geodi.Integration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace Feeder
{
    public partial class FeederForm : Form
    {
        public FeederForm()
        {
            InitializeComponent();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                folderTextBox.Text = folderBrowserDialog.SelectedPath;
        }

        private void okButton_Click(object sender, EventArgs e)
        {

            if(string.IsNullOrEmpty(folderTextBox.Text))
                MessageBox.Show("Please select a folder.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrEmpty(txtToken.Text))
                MessageBox.Show("Please set Token.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if(string.IsNullOrEmpty(serviceTextBox.Text))
                MessageBox.Show("Please enter a serviceURL.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                try
                {
                    var rtn = new IntegrationObject() { Contents = new List<ContentObject>() };

                    foreach (FileInfo file in new DirectoryInfo(folderTextBox.Text).GetFiles("*.*"))
                    {
                        //ContentObject.ContentURL ile içerik yerine dosya yolu iletilebilir.
                        string base64 = Convert.ToBase64String(File.ReadAllBytes(file.FullName));
                        var content = new ContentData() { 
                            Content = base64, 
                            Extension = file.Extension, 
                            ContentId =file.FullName 
                        };


                        //rtn.Contents.Add(new ContentObject() { Content = content, DisplayName = file.Name });
                        var contentItem = new ContentObject() { 
                            Content = content, 
                            DisplayName = file.FullName , 
                            ContentDate=file.LastWriteTime 
                        };
                        rtn.Contents.Add(contentItem);
                    }
                    string requestUri = serviceTextBox.Text;
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(requestUri);
                    request.Method = "POST";
                    request.Accept = "application/json,*/*; q=0.01";
                    var serializer = new JavaScriptSerializer() { MaxJsonLength = int.MaxValue };
                    string contentJson = serializer.Serialize(rtn);
                    //request.AllowWriteStreamBuffering = true;

                    


                    Stream stream = request.GetRequestStream();

                    ////fullpost
                    //byte[] allData=System.Text.Encoding.UTF8.GetBytes(contentJson);
                    //stream.Write(allData,0, allData.Length);

                    //keypost
                    request.ContentType = "application/x-www-form-urlencoded";

                    byte[] allData = System.Text.Encoding.UTF8.GetBytes(
                        string.Concat(
                        "UserSession=", System.Web.HttpUtility.UrlEncode(txtToken.Text),
                        "&content=", System.Web.HttpUtility.UrlEncode(contentJson)
                        ));
                    stream.Write(allData, 0, allData.Length);

                    stream.Flush();
                    stream.Close();

                    request.GetResponse();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            MessageBox.Show("Feed complete.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
