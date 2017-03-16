<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DisplayStock.aspx.cs" Inherits="StockQuoteConsume.DisplayStock" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Stock symble"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtSymbol" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Get Quote" />
    </div>
    <div>
        <asp:Label ID="lblQuote" runat="server"></asp:Label>
    </div>  
    </form>
</body>
</html>
