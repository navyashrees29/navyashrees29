<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="StudentInfoWebApplication.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 588px;
            text-align: right;
        }
        .auto-style3 {
            text-align: center;
        }
        .auto-style7 {
            width: 588px;
            text-align: right;
            height: 23px;
        }
        .auto-style8 {
            text-align: left;
            height: 23px;
        }
        .auto-style9 {
            text-align: left;
        }
    </style>
</head>
<body>
    <h1 class="auto-style3"><em>Student Information Web Application</em></h1>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label1" runat="server" Text="User Name"></asp:Label>
                    </td>
                    <td class="auto-style9">
                        <asp:TextBox ID="TextBoxUserName" runat="server"></asp:TextBox>
                    &nbsp;&nbsp;
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
                    </td>
                    <td class="auto-style9">
                        <asp:TextBox ID="TextBoxPassword"  runat="server" TextMode="Password"></asp:TextBox>
                    &nbsp;&nbsp;
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style9">
                        <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7"></td>
                    <td class="auto-style8"></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
