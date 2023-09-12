<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Singup.aspx.cs" Inherits="PromptPanWeb.Singup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblcst" runat="server" Text="Customer:-"></asp:Label>
        <asp:TextBox ID="txtCustNew" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblPass" runat="server" Text="Password:-"></asp:Label>
            <asp:TextBox ID="txtPassNew" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblwar" runat="server"></asp:Label>
        </p>
        <asp:Button ID="btnsubmit" runat="server" OnClick="btnsubmit_Click" Text="submit" />
    </form>
</body>
</html>
