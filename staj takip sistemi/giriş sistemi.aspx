1<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="giriş sistemi.aspx.cs" Inherits="staj_takip_sistemi.giriş_sistemi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 677px;
        } body {
    background-image: url("https://i.hizliresim.com/GyVbVv.png");
      background-repeat: no-repeat;
    background-attachment: fixed;
    background-position: center;
    background-size :cover;
}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td>
            <asp:Label ID="Label5" runat="server"></asp:Label>
                        <br />
            <asp:Label ID="Label1" runat="server" Text="Kullanıcı Adı"></asp:Label>
                        <br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        <br />
            <asp:Label ID="Label2" runat="server" Text="Şifre"></asp:Label>
                        <br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                        <br />
            <asp:Label ID="Label3" runat="server"></asp:Label>
                        <br />
            <asp:Label ID="Label4" runat="server" Text="Kutu içerisindeki rakamları giriniz"></asp:Label>
                        <br />
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                        <br />
            <asp:Button ID="Button1" runat="server" Height="27px" Text="Giriş" OnClick="Button1_Click" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </div>
    </form>
</body>
</html>
