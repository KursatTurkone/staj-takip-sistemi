<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Yeni.aspx.cs" Inherits="staj_takip_sistemi.Yeni" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 573px;
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
        </div>
        <table style="width:100%;">
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style1">&nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Çıkış yap" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button2" runat="server" Text="Kabul edilenler" OnClick="Button2_Click" />
                    <br />
                    <br />
                    <asp:Button ID="Button4" runat="server" Text="Staj formu sayfası" OnClick="Button4_Click" />
                    <br />
                    <br />
                    <asp:Button ID="Button5" runat="server" Text="Staj Defteri sayfası" OnClick="Button5_Click" />
                    <br />
                </td>
                <td class="auto-style1">
                    <br />
                    <asp:GridView ID="GridView1" runat="server">
                        <Columns>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:CheckBox ID="CheckBox2" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                        <EmptyDataTemplate>
                            <asp:CheckBox ID="CheckBox1" runat="server" />
                        </EmptyDataTemplate>
                    </asp:GridView>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Seç" />
                    <br />
                    <br />
                    <asp:GridView ID="GridView2" runat="server">
                        <Columns>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    kabul<asp:CheckBox ID="CheckBox3" runat="server" />
                                    red<asp:CheckBox ID="CheckBox4" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                        <EmptyDataTemplate>
                            <asp:CheckBox ID="CheckBox1" runat="server" />
                        </EmptyDataTemplate>
                    </asp:GridView>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button6" runat="server" Text="Seç" OnClick="Button6_Click" />
                    <br />
                    <asp:Button ID="Button7" runat="server" Text="Staj Formları" OnClick="Button7_Click" />
                    <asp:Button ID="Button8" runat="server" Text="Staj Defterleri" OnClick="Button8_Click" />
                    <br />
                    <br />
                    <br />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
