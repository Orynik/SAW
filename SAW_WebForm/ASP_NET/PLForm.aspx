<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PLForm.aspx.cs" Inherits="SAW_WebForm.Pages.PLForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <link href="../Content/Main.css" rel="stylesheet" />
    <title>Калькулятор площади конуса и цилиндра</title>
</head>
<body class ="CalcSSection">
    <form id="form2" runat="server">
        <fieldset>
            <h1>Калькулятор площади</h1>
            <div class ="d-flex flex-column">
                <div>
                    <asp:Label ID="LabelA" runat="server" Text="Ввод R"></asp:Label>
                    <asp:TextBox ID="R" runat="server"></asp:TextBox>
                </div>
                <br />
                <div>
                    <asp:Label ID="LabelB" runat="server" Text="Ввод h"></asp:Label>
                    <asp:TextBox ID="h" runat="server"></asp:TextBox>
                </div>
                <div>
                    <asp:Label ID="Labelresult" runat="server" Text="Результат" Visible="true"></asp:Label>
                    <asp:TextBox ID="result" runat="server" Enabled="false" Visible="true"></asp:TextBox>
                </div>
                <div>
                    <asp:Button Text="Площадь конуса" runat="server" OnClick="Result_Сone_Btn_Click" />
                    <asp:Button Text="Площадь цилиндра" runat="server" OnClick="Result_Cyl_Btn_Click" />
                </div>
            </div>
        </fieldset>
        <asp:LinkButton CssClass ="mt-3 OtherButton btn" runat="server" PostBackUrl ="../ASP_NET/Default.aspx" Text ="Вернуться на главную."/>
    </form>
</body>
</html>
