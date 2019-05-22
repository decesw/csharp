<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>GEODI Token Servisi Kullanımı -  Örnek Uygulama</title>
    <style type="text/css">
        body {
            padding: 10px;
            font-family: Tahoma;
            line-height: 1.5em;
            max-width: 800px;
        }

        p, h1, h2, h3 {
            margin-top: 5px;
            margin-bottom: 5px;
            font-weight: normal;
            text-indent: 30px;
        }


        a, a:visited {
            text-decoration: none;
            color: #3F51B5;
        }

            a:hover {
                text-decoration: underline;
            }

        code {
            white-space: pre;
            padding: 10px;
            border: 1px solid #999;
            display: block;
            border-radius: 10px;
            margin-right: 60px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <br />
        <div>
            <h3><a href="https://decesw.atlassian.net/wiki/spaces/PAR/pages/1039302662/Geodi+Token+API+-+G+venilen+istemciler+i+in+SSO" target="_blank">SSO Kullanıcı paylaşımı</a></h3>
            <p>
                Aşağıdaki işlemler yapılıp GetAutoLoginLink servisi kullanılarak GEODI'ye giriş yapmış kullanıcı URL'i elde edilebilir.<br>
				Servis kullanımı için gereken Token sistem yöneticisinden veya [your_geodi_url]/api adreisndeki Token linkinden elde edilebilir.
            </p>
            <ul>
                <li>GEODI/Settings/TokenClient altına aşağıdaki içerik "<i>.jSettings</i>" uzantılı bir dosya olarak atılmalıdır.
                    <br />
                    <br />
      <code>    {
        ClientID:"<asp:Label runat="server" ID="lblClientID"></asp:Label>",
        ValidateURL: "<asp:Label runat="server" ID="lblValidateUrl"></asp:Label>",
        GEODIRequestHeader:"GEODI_Request"
    }</code>

                </li>
            
            <li> Test Formu
                <div>
                     <asp:TextBox runat="server" ID="txtUserFor" Text="My Application Test User"></asp:TextBox><br />
                        <asp:Button runat="server" ID="btnUserLoginUrl" Text="Kullanıcı için GEODI URL Getir" OnClick="btnUserLoginUrl_Click" />

                        <br />
                        <asp:HyperLink ID="lnkGEODIForUser" runat="server" Visible="False">...</asp:HyperLink>
                </div>
                

            </li>
                
            </ul>

           
        </div>

    </form>
</body>
</html>
