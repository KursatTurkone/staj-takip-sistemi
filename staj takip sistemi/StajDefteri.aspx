<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StajDefteri.aspx.cs" Inherits="staj_takip_sistemi.StajDefteri" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 257px;
        }body {
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
            <br />
            <br />
            <br />
            <br />
            <table style="width:100%;">
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td>Gün<br />
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        <br />
            Not<br />
            <asp:TextBox ID="TextBox2" runat="server" Height="165px" Width="1185px"></asp:TextBox>
                        <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Onay" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
