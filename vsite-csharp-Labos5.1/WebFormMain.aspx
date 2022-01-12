<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormMain.aspx.cs" Inherits="vsite_csharp_Labos5._1.WebFormMain" %>

<%@ Register src="LogIn.ascx" tagname="LogIn" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <uc1:LogIn ID="LogIn1" runat="server" />
    </form>
</body>
</html>
