<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AGETEST.aspx.cs" Inherits="MSTest.AGETEST" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>Date of Birth</td>
                    <td>
                        <asp:TextBox ID="txtdate" runat="server" TextMode="Date"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="click" OnClick="Button1_Click" />
                        </td>
                </tr>
                <tr>
                    <td>Age</td>
                    <td>
                        <asp:TextBox ID="txtage" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </table>





        </div>
    </form>
</body>
</html>
