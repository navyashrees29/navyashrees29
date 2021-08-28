# Redirect from one page to another in asp.net

- Response.Redirect
- Server.Transfer
- Server.Exceute
- Cross page posting

# Response.Redirect
- It redirects to a new redirected URL where it is redirected in the browser.
- It maintains the history and previous page is available with the back button.
- It redirects the user to a web page hosted on the same server or a different server.
- It has an additional round trip to the server that makes it a bit slower.

Example : 

protected void Button1_Click(object sender, EventArgs e)

{

Response.Redirect("page1.aspx"); 

Response.Write("hello"); // this line won't execute unless its bool value set to false

}

# Server. Transfer

- It transfers a current page request to another .aspx page on the same server.
- It does not change the address bar.
- It preserves server resources and avoids the unnecessary roundtrips to the server.
- It cannot maintain the history.
- There is no URL changes in the address bar in this case so the back button cannot be used.

Example : 

protected void Button1_Click(object sender, EventArgs e)

{

Server.Transfer("page1.aspx"); 

}

# Server.Exceute

- When using the server.Execute method for navigation it helps to retain the execution control from the source web form.
- it retains the control from the source web page and returns to the original page after execution of the target page.
- It is very similar to the server.execute method for navigation but it retains the control from the source web page and returns to the original 
  page after execution of the target page.
- Server.Execute allows only relative URL. 
- The code present after Server.Execute will be executed. 
- In Server.Execute source and destination pages must be present in same website .


Example : 

protected void Button1_Click(object sender, EventArgs e)

{

Server.Execute("WebForm1.aspx");  

}

# Cross Page posting

In an ASP.NET web form is the default page posted on itself whenever a button is clicked.

- The Cross Page posting technique allows a web form to post on another web form on button click.
- The PostbackUrl property of the button is set to the page where you want to do cross-page posting.

Exmaple

- Code on Default.aspx

<form id="form1" runat="server">  
  
   <asp:TextBox ID="txtName" name="data" runat="server" />
  
   <asp:Button Text="ClickPostBack" runat="server" PostBackUrl="~/Display.aspx" />  
  
</form> 

- Code on Display.aspx

<form id="form1" runat="server">  
  
   <asp:Label Text="text" name="lblValue" ID="lblValue" runat="server" /> 
  
</form>  

- Display.aspx.cs

protected void Page_Load(object sender, EventArgs e)  
{  
    if (PreviousPage != null && PreviousPage.IsCrossPagePostBack)   
    {  
        TextBox txtName = (TextBox) PreviousPage.FindControl("txtName");  
        lblValue.Text = "Welcome " + txtName.Text;  
    }  
}
