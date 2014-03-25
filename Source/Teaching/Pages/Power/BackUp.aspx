<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BackUp.aspx.cs" Inherits="Teaching.Pages.Power.BackUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div>
            <span>
                <asp:TextBox runat="server" ID="tbxBakLoad"></asp:TextBox><asp:Button runat="server" Text="备份" OnClick="btnBak_Click"/>
            </span>
            <span>
                <asp:TextBox runat="server" ID="tbxReductLoad"></asp:TextBox><asp:Button runat="server" Text="还原" OnClick="btnReduct_Click" />
            </span>
        </div>
    </div>
    </form>
</body>
</html>
