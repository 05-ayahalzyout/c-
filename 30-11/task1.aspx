<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="task1.aspx.cs" Inherits="_30_11.task1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="x" runat="server" OnTextChanged="x_TextChanged"></asp:TextBox>
             <asp:TextBox ID="y" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Combination" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="Subtraction" OnClick="Button2_Click" />
            <asp:Button ID="Button3" runat="server" Text="flailing" OnClick="Button3_Click"/>
            <asp:Button ID="Button4" runat="server" Text="Division" OnClick="Button4_Click" />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Resalt"></asp:Label>

            <asp:Label ID="Label1" runat="server" Text=" "></asp:Label>
        </div>
    </form>
</body>
</html>
