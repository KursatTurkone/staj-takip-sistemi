<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Kabul.aspx.cs" Inherits="staj_takip_sistemi.Kabul" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 553px;
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
            <table style="width:100%;">
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td>KABUL EDİLEN İŞLEMLER</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td>Firma<asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
                        <br />
                        <br />
                        StajFormu<asp:GridView ID="GridView3" runat="server">
            </asp:GridView>
                        <br />
                        StajDefteri<asp:GridView ID="GridView4" runat="server">
            </asp:GridView>
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
