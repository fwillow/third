﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="fhl165033213.WebUI.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <h3 style="width:100%;text-align:center">用户登录</h3>
    <form id="form1" runat="server">
    <div>
    <table class="style1" align="center" style="border:thin solid#C0C0C0">
            <tr>
                <td align="right">用户名：</td>
                <td>
                    <asp:TextBox ID="UserName" runat="server" Width="150"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right">密码：</td>
                <td>
                    <asp:TextBox ID="PassWord" runat="server" TextMode="Password" Width="150"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="center" colspan="2">
                    <asp:Button ID="loginBtn" runat="server" Text="登 录" OnClick="loginBtn_Click"/>&nbsp;<asp:button id="resetBtn" runat="server" Text="重 置" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
