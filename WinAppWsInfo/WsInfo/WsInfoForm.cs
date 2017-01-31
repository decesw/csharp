using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net;
using System.Text;
using System.Web;
using System.Windows.Forms;

namespace WsInfo
{
    public partial class WsInfoForm : Form
    {
        string WsName { get { return wsNameTextBox.Text; } }
        string GeodiUrl { get { return geodiUrlTextBox.Text.Trim(); } }
        string Token { get { return tokenTextBox.Text; } }
        public WsInfoForm()
        {
            InitializeComponent();
        }

        void getWsInfoButton_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                var request = (HttpWebRequest)WebRequest.Create(GeodiUrl + "/WsInfoHandler?op=GetWSInfo");
                request.Method = "POST";
                request.Accept = "application/json";
                request.ContentType = "application/x-www-form-urlencoded";
                
                var allDataString = "wsName=" + HttpUtility.UrlEncode(WsName);
                allDataString += "&UserSession=" + HttpUtility.UrlEncode(Token);
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

                resultTreeView.Hide();
                try
                {
                    GetRecognizeResult(request);
                    resultTreeView.Show();
                }
                catch (Exception ex)
                {
                    ShowError(ex);
                }
            }
        }

        bool CheckInput()
        {
            if (string.IsNullOrWhiteSpace(WsName))
            {
                ShowError("Please enter workspace name");
                return false;
            }

            if (string.IsNullOrWhiteSpace(Token))
            {
                ShowError("Please set token.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(GeodiUrl))
            {
                ShowError("Please enter GEODI URL.");
                return false;
            }

            return true;
        }

        void GetRecognizeResult(WebRequest request)
        {
            using (WebResponse response = request.GetResponse())
            using (Stream responseStream = response.GetResponseStream())
            {
                string json = (new StreamReader(responseStream)).ReadToEnd();
                Json2Tree(json);
            }

        }

        void Json2Tree(string json)
        {
            TreeNode result;
            try
            {
                result = Json2Tree(JObject.Parse(json));
                result.Text = "Result";
            }
            catch (JsonReaderException)
            {
                result = Json2Tree(JObject.Parse("{\"Result\":" + json + '}')).FirstNode;
            }

            resultTreeView.Nodes.Clear();
            resultTreeView.Nodes.Add(result);
            resultTreeView.ExpandAll();
        }

        void WsInfoForm_Shown(object sender, EventArgs e)
        {
            wsNameTextBox.Focus();
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
