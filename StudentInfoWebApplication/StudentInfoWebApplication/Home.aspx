<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="StudentInfoWebApplication.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style3 {
            width: 297px;
        }
        .auto-style5 {
            width: 297px;
            height: 28px;
            text-align: left;
        }
        .auto-style7 {
            width: 297px;
            height: 26px;
            text-align: left;
        }
        .auto-style8 {
            font-weight: bold;
        }
        .auto-style10 {
            text-align: left;
        }
        .auto-style14 {
            width: 297px;
            text-align: left;
        }
        .auto-style15 {
            width: 46px;
            text-align: left;
        }
        .auto-style16 {
            width: 46px;
            height: 28px;
            text-align: left;
        }
        .auto-style17 {
            width: 46px;
            height: 26px;
            text-align: left;
        }
        .auto-style18 {
            width: 46px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <h1 class="auto-style10"><em>Home Page&nbsp;&nbsp;</em>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>
        <asp:Button ID="Button6" runat="server" OnClick="BtnLogout" Text="Logout" CssClass="auto-style8" />
        </strong>&nbsp;&nbsp;&nbsp;&nbsp; </h1>
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style15">
                        <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
                    </td>
                    <td class="auto-style14">
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style16">
                        <asp:Label ID="Label3" runat="server" Text="Class"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txtClass" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style15">
                        <asp:Label ID="Label4" runat="server" Text="Gender"></asp:Label>
                    </td>
                    <td class="auto-style14">
                        <asp:RadioButtonList ID="rdbnGender" runat="server" Height="16px" RepeatDirection="Horizontal" Width="202px">
                            <asp:ListItem>Male</asp:ListItem>
                            <asp:ListItem>Female</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style15">
                        <asp:Label ID="Label7" runat="server" Text="DOB"></asp:Label>
                    </td>
                    <td class="auto-style14">
                        <asp:TextBox ID="txtDOB" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style15">
                        <asp:Label ID="Label5" runat="server" Text="Email"></asp:Label>
                    </td>
                    <td class="auto-style14">
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style15">
                        <asp:Label ID="Label6" runat="server" Text="Contact Number"></asp:Label>
                    </td>
                    <td class="auto-style14">
                        <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style17">
                        <asp:Label runat="server" Text="Address"></asp:Label>
                    </td>
                    <td class="auto-style7">
                        <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style15">&nbsp;</td>
                    <td class="auto-style14">&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="2" class="auto-style10">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                        <asp:Button ID="btnInsert" runat="server" OnClick="BtnCreateUser" Text="Insert" CssClass="auto-style8" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Button4" runat="server" OnClick="BtnClearUser" Text="Clear" CssClass="auto-style8" />
                        </strong>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style18">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="2" class="auto-style10">
                        <asp:GridView ID="gvStudent" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="gvStudent_SelectedIndexChanged" CellPadding="4" ForeColor="#333333" GridLines="None" >
                            <AlternatingRowStyle BackColor="White" />
                            <Columns>
                               
                                <asp:BoundField DataField="name" HeaderText="Name" />
                                <asp:BoundField DataField="class" HeaderText="Class" />
                                <asp:BoundField DataField="gender" HeaderText="Gender" />
                                <asp:BoundField DataField="dob" HeaderText="DOB" />
                                <asp:BoundField DataField="email" HeaderText="Email" />
                                <asp:BoundField DataField="phone" HeaderText="Phone" />
                                <asp:BoundField DataField="address" HeaderText="Address" />
                                <asp:BoundField DataField="DateTime" HeaderText="Date Time" />
                  <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="linkView" runat="server" CommandArgument='<%# Eval("Id") %>' OnClick="BtnSelectUser">View</asp:LinkButton>
                    </ItemTemplate>
                 </asp:TemplateField>
                 <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="linkUpdate" runat="server" CommandArgument='<%# Eval("Id") %>' OnClick="BtnUpdateUser">Update</asp:LinkButton>
                    </ItemTemplate>
                 </asp:TemplateField>
                 <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="linkdelete" runat="server" CommandArgument='<%# Eval("Id") %>' OnClientClick="return confirm('Are you sure,you want to delete this record ?');" OnClick="BtnDeleteUser">Delete</asp:LinkButton>
                    </ItemTemplate>
                 </asp:TemplateField>
                               
                            </Columns>
                            <EditRowStyle BackColor="#2461BF" />
                            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle BackColor="#EFF3FB" />
                            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                            <SortedAscendingCellStyle BackColor="#F5F7FB" />
                            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                            <SortedDescendingCellStyle BackColor="#E9EBEF" />
                            <SortedDescendingHeaderStyle BackColor="#4870BE" />
                        </asp:GridView>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" class="auto-style10">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td colspan="2" class="auto-style10">
                        <asp:GridView ID="gvRegisteredUser" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="gvRegisteredUser_SelectedIndexChanged" CellPadding="4" ForeColor="#333333" GridLines="None">
                             <AlternatingRowStyle BackColor="White" />
                             <Columns>
                                <asp:BoundField DataField="Name" HeaderText="Name" />
                                <asp:BoundField DataField="Email" HeaderText="Email" />
                                <asp:BoundField DataField="Phone" HeaderText="Phone" />
                                <asp:BoundField DataField="UserName" HeaderText="User Name" />
                                <asp:BoundField DataField="Password" HeaderText="Password" />
                              </Columns>
                             <EditRowStyle BackColor="#2461BF" />
                             <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                             <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                             <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                             <RowStyle BackColor="#EFF3FB" />
                             <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                             <SortedAscendingCellStyle BackColor="#F5F7FB" />
                             <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                             <SortedDescendingCellStyle BackColor="#E9EBEF" />
                             <SortedDescendingHeaderStyle BackColor="#4870BE" />
                        </asp:GridView>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
