<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="IndianWeatherReport._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 158px;
        }
        .style3
        {
            width: 158px;
            height: 130px;
            text-align: center;
        }
        .style4
        {
            height: 130px;
        }
        .style5
        {
            color: #FFFFFF;
            font-weight: bold;
        }
        .style6
        {
            width: 103px;
        }
        .style7
        {
            width: 113px;
        }
    </style>
</head>
<body style="font-family: Tahoma; font-size: small">
    <form id="form1" runat="server">
    <table class="style1">
        <tr>
            <td>
                <table class="style1">
                    <tr>
                        <td class="style6">
                            Select City Name</td>
                        <td class="style7">
                            <asp:DropDownList ID="cmbCity" runat="server">
                                <asp:ListItem>Gandhi Nagar</asp:ListItem>
                                <asp:ListItem>Ahemdabad</asp:ListItem>
                                <asp:ListItem>Surat</asp:ListItem>
                                <asp:ListItem>Vadodra</asp:ListItem>
                                <asp:ListItem>Bhopal</asp:ListItem>
                                <asp:ListItem>Itarsi</asp:ListItem>
                                <asp:ListItem>Gwalior</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:Button ID="btnShow" runat="server" Text="Show" onclick="btnShow_Click" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
    
        <table class="style1" 
            style="background-image: url('background.JPG'); background-repeat: no-repeat; height: 239px;">
            <tr>
                <td class="style3">
                    <img alt="" src="weather_icon.gif" 
                        style="width: 112px; height: 103px; border-left-style: inset; border-left-width: thin; border-right-style: outset; border-right-width: thin; border-top-style: inset; border-top-width: thin; border-bottom-style: outset; border-bottom-width: thin;" /></td>
                <td class="style4" style="vertical-align: top;">
                    <table class="style1" style="vertical-align: top; height: 153px;">
                        <tr>
                            <td>
                                <asp:Label ID="lblState" runat="server" style="font-weight: 700" Text="State :"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="lblCity" runat="server" style="font-weight: 700" Text="City : "></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="lblDesc" runat="server" style="font-weight: 700" 
                                    Text="Description : "></asp:Label>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td class="style2">
&nbsp;&nbsp; <span class="style5">Maximum Temprature</span></td>
                <td>
&nbsp;&nbsp;
                    <asp:Label ID="lblMax" runat="server" Text="0"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style2">
&nbsp;&nbsp; <span class="style5">Minimum Temprature</span></td>
                <td>
&nbsp;&nbsp;
                    <asp:Label ID="lblMin" runat="server" Text="0"></asp:Label>
                </td>
            </tr>
        </table>
    
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
