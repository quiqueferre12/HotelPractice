<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Log.aspx.cs" Inherits="WebApplication1.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
            </div>
        </div>
        <div>
            <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
            <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
            
            <asp:Button ID="btnLog" runat="server" Text="Enter" OnClick="Button1_Click" Width="63px" />
            
        </div>
    </form>
</body>
</html>
