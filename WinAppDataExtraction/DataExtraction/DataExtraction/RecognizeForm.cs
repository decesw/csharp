using Geodi.Integration;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace DataExtraction
{
    public partial class RecognizeForm : Form
    {
        string WsName
        {
            get { return wsNameTextBox.Text; }
        }

        string Token
        {
            get { return tokenTextBox.Text; }
        }

        string GeodiUrl
        {
            get { return geodiUrlTextBox.Text.Trim(); }
        }

        string LFile
        {
            get { return fileNameTextBox.Text.Trim('"').Trim(); }
            set { fileNameTextBox.Text = value.Trim('"').Trim(); }
        }
        
        string ContentUrl
        {
            get { return contentUrlTextBox.Text.Trim('"').Trim(); }
        }

        string DisplayName
        {
            get { return displayNameTextBox.Text; }
        }

        string RecognizeText
        {
            get { return recognizeTextBox.Text.Trim(); }
        }

        public RecognizeForm()
        {
            InitializeComponent();
        }

        void recognizeLocalContentButton_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                if (string.IsNullOrEmpty(LFile))
                {
                    MessageBox.Show("Please select a file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var client = new WebClient() { BaseAddress = GeodiUrl };
                FillMethodParam("RecognizeContent", client.QueryString);
                client.QueryString["op"] = "RecognizeContent";
                client.QueryString["fileName"] = HttpUtility.UrlEncode(Path.GetFileName(LFile));

                localContentResultTreeView.Hide();
                try
                {
                    byte[] result = client.UploadFile("DataExtractionHandler", LFile);
                    Json2Tree(localContentResultTreeView, Encoding.UTF8.GetString(result));
                    localContentResultTreeView.Show();
                }
                catch (Exception ex)
                {
                    ShowError(ex);
                }
            }
        }

        void browseButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                LFile = openFileDialog.FileName;
        }

        void recognizeContentButton_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                if (string.IsNullOrWhiteSpace(ContentUrl))
                {
                    ShowError("Please enter content URL.");
                    return;
                }

                var content = new ContentObject()
                {
                    ContentURL = contentUrlTextBox.Text,
                    DisplayName = displayNameTextBox.Text
                };
                string contentJson = HttpUtility.UrlEncode((new JavaScriptSerializer()).Serialize(content));

                Recognize("RecognizeContent", contentResultTreeView, new NameValueCollection() { { "content", contentJson } });
            }
        }

        void recognizeTextButton_Click(object sender, EventArgs e)
        {
            Recognize("Recognize", textResultTreeView, new NameValueCollection() { { "Text", RecognizeText } });
        }

        void Recognize(string method, TreeView resultTreeView, NameValueCollection parameters)
        {
            FillMethodParam(method, parameters);

            string dataString = string.Join("&", parameters.AllKeys.Select(k => k + '=' + parameters[k]));
            byte[] allData = Encoding.UTF8.GetBytes(dataString);

            var request = (HttpWebRequest)WebRequest.Create(GeodiUrl + "/DataExtractionHandler?op=" + method);
            request.Method = "POST";
            request.Accept = "application/json";
            request.ContentType = "application/x-www-form-urlencoded";

            Stream stream = request.GetRequestStream();
            stream.Write(allData, 0, allData.Length);
            stream.Flush();
            stream.Close();

            resultTreeView.Hide();
            try
            {
                GetRecognizeResult(resultTreeView, request);
                resultTreeView.Show();
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        bool CheckInput()
        {
            if (string.IsNullOrWhiteSpace(WsName))
            {
                ShowError("Please enter workspace name.");
                return false;
            }
            if (string.IsNullOrEmpty(GeodiUrl))
            {
                ShowError("Please enter GEODI URL.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(Token))
            {
                ShowError("Please set token");
                return false;
            }
            return true;
        }

        void FillMethodParam(string method, NameValueCollection parameters)
        {
            parameters["wsName"] = HttpUtility.UrlEncode(WsName);
            parameters["UserSession"] = HttpUtility.UrlEncode(Token);
        }

        static void ShowError(Exception ex)
        {
            ShowError(ex.Message + Environment.NewLine + Environment.NewLine + ex.StackTrace);
        }

        static void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        static void GetRecognizeResult(TreeView tree, WebRequest request)
        {
            using (WebResponse response = request.GetResponse())
            using (Stream responseStream = response.GetResponseStream())
                Json2Tree(tree, (new StreamReader(responseStream)).ReadToEnd());
        }

        static void Json2Tree(TreeView tree, string json)
        {
            JObject obj = JObject.Parse(json);
            tree.Nodes.Clear();
            TreeNode parent = Json2Tree(obj);
            parent.Text = "Result";
            tree.Nodes.Add(parent);
            tree.ExpandAll();
        }

        static TreeNode Json2Tree(JObject obj)
        {
            //create the parent node
            TreeNode parent = new TreeNode();
            //loop through the obj. all token should be pair<key, value>
            foreach (var token in obj)
            {
                //create the child node
                TreeNode child;
                //check if the value is of type obj recall the method
                if (token.Value.Type.ToString() == "Object")
                {
                    // child.Text = token.Key.ToString();
                    //create a new JObject using the the Token.value
                    JObject o = (JObject)token.Value;
                    //recall the method
                    child = Json2Tree(o);
                    child.Text = token.Key;
                    //add the child to the parentNode
                    parent.Nodes.Add(child);
                    continue;
                }

                child = new TreeNode();
                child.Text = token.Key;
                //if type is of array
                if (token.Value.Type.ToString() == "Array")
                {
                    int ix = -1;
                    //  child.Text = token.Key.ToString();
                    //loop though the array
                    foreach (var itm in token.Value)
                    {
                        //check if value is an Array of objects
                        if (itm.Type.ToString() == "Object")
                        {
                            TreeNode objTN = new TreeNode();
                            //child.Text = token.Key.ToString();
                            //call back the method
                            ix++;

                            JObject o = (JObject)itm;
                            objTN = Json2Tree(o);
                            objTN.Text = token.Key.ToString() + "[" + ix + "]";
                            child.Nodes.Add(objTN);
                            //parent.Nodes.Add(child);
                        }
                        //regular array string, int, etc
                        else if (itm.Type.ToString() == "Array")
                        {
                            ix++;
                            TreeNode dataArray = new TreeNode();
                            foreach (var data in itm)
                            {
                                dataArray.Text = token.Key.ToString() + "[" + ix + "]";
                                dataArray.Nodes.Add(data.ToString());
                            }
                            child.Nodes.Add(dataArray);
                        }
                        else
                        {
                            child.Nodes.Add(itm.ToString());
                        }
                    }
                }
                else
                {
                    //if token.Value is not nested
                    // child.Text = token.Key.ToString();
                    //change the value into N/A if value == null or an empty string 
                    if (token.Value.ToString() == "")
                        child.Nodes.Add("N/A");
                    else
                        child.Nodes.Add(token.Value.ToString());
                }
                parent.Nodes.Add(child);
            }
            return parent;
        }
    }
}
