## Validation Controls in ASP.Net

ASP.Net provides various validation controls that validate the user data to ensure that the data entered by the user are satisfied with the condition.

There are six types of validation controls in ASP.NET

#### 1. RequiredFieldValidator

​	This is an elementary validation control. Almost all the forms have some fields that are mandatory to be filled up by the user before proceeding forward. The Required Field Validator ensures that such fields are not left empty.

```
<asp:TextBox ID="txtName" runat="server"> </asp:TextBox>
<asp:RequiredFieldValidator ID="rfvName" runat="server" ErrorMessage="Please enter Name" ControlToValidate="txtName"> </asp:RequiredFieldValidator>
```



#### 2. CompareValidator

  Compares the value of one input control to the value of another input control or to a fixed value

```
Password <asp:TextBox ID="txtPass" runat="server"> </asp:TextBox>
Confirm <asp:TextBox ID="txtPassRe" runat="server"> </asp:TextBox>
<asp:CompareValidator ID="cvPass" runat="server" ErrorMessage="Password should match" ControlToValidate="txtPass" ControlToCompare="txtPassRe" Operator="Equal">   
</asp:CompareValidator>
```

#### 3. RangeValidator

The RangeValidator Server Control is another validator control, which checks to see if a control value is within a valid range.

```
<asp:TextBox ID="txtAge" runat="server"> </asp:TextBox>
<asp:RangeValidator ID="rvAge" runat="server" ErrorMessage="Age should be 18 to 30" ControlToValidate="txtAge"
type="Integer" MinimumValue="18" MaximumValue="30"></asp:RangeValidator>
```



#### 4. RegularExpressionValidator

Ensures that the value of an input control matches a specified pattern. It is used to validate complex expressions. These expressions can be phone number, email address, zip code and many more.

```
<asp:TextBox ID="txtEmail" runat="server"> </asp:TextBox>
<asp:RegularExpressionValidator ID="revEmail" runat="server" ErrorMessage="Invalid Email" ControlToValidate="txtEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"> </asp:RegularExpressionValidator>
```

#### 5. CustomValidator

 Allows you to write a method to handle the validation of the value entered. The CustomValidator Control can be used on client side and server side. JavaScript is used to do client validation and you can use any .NET language to do server side validation.

```
<asp:TextBox ID="txtCustom" runat="server" ></asp:TextBox>
<asp:CustomValidator ID="cv" runat="server" ControlToValidate="txtCustom"
ErrorMessage="Custom Validator Error" OnServerValidate="cv_ServerValidate"> </asp:CustomValidator>
```

//here is the server side method

```
protected void cv_ServerValidate(object source, ServerValidateEventArgs args)
{
if (args.Value == "webtrainingroom")
    args.IsValid = true;
else
    args.IsValid = false;
}
```

#### 6. ValidationSummary

 The ValidationSummary control is reporting control, which is used by the other validation controls on a page. You can use this validation control to consolidate errors reporting for all the validation errors that occur on a page instead of leaving this up to each and every individual validation control.

```
<asp:ValidationSummary ID="vsForm" runat="server" 
DisplayMode = "BulletList" ShowSummary = "true" />
```

 



## User Controls

User controls behaves like miniature ASP.NET pages or web forms, which could be used by many other pages. These are derived from the System.Web.UI.UserControl class. These controls have the following characteristics:

- They have an .ascx extension.
- They may not contain any <html>, <body>, or <form> tags.
- They have a Control directive instead of a Page directive.

