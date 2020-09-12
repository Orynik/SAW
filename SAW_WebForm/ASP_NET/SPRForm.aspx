<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SPRForm.aspx.cs" Inherits="SAW_WebForm.SPRForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <link href="../Content/Main.css" rel="stylesheet" />
    <title>О приложении</title>
</head>
<body runat="server" style="height: 519px" class ="AboutSAW">
    <div>
        <h1>
            <asp:Label ID="AboutTitle" runat="server"/><br />
        </h1>
        <p>
            <asp:Label ID="AboutApp" runat="server"/>
        </p>
    </div>
    <div>
        <h3>
             <asp:Label ID="AboutCalcTitle" runat="server"></asp:Label><br />
        </h3>
        <p>
            <asp:Label ID="AboutCalcText" runat="server"></asp:Label>
        </p>
    </div>
    <div>
        <h3>
            <asp:Label ID="AboutCalcAreaTitle" runat="server" Text="Label"/>
        </h3>
        <p>
            <asp:Label ID="AboutCalcAreaText" runat="server" />
        </p>
    </div>
    <div>
        <h3>
            <asp:Label ID="AboutCalcVolumeTitle" runat="server"/>
        </h3>
        <p>
            <asp:Label ID="AboutCalcVolumeText" runat="server" />
        </p>
    </div>
    <form runat="server">
        <asp:LinkButton CssClass ="SAWButton btn btn-primary" runat="server" PostBackUrl ="../ASP_NET/Default.aspx" Text ="Вернуться на главную."/>
    </form>    
</body>
</html>
