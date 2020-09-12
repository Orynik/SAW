<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CALForm.aspx.cs" Inherits="SAW_WebForm.CALForm"%>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <link href="../Content/Main.css" rel="stylesheet" />
    <title>Онлайн калькулятор</title>
</head>
<body class ="CalcSection">
    <form id="form1" runat="server">
        <fieldset>
            <h1>Калькулятор</h1>
            <div class ="d-flex">
                <div>
                    <asp:Label ID="LabelA" runat="server" Text="Ввод А числа"></asp:Label>
                    <asp:TextBox ID="A" runat="server"></asp:TextBox>
                </div>
                <br />
                <div>
                    <asp:Label ID="LabelB" runat="server" Text="Ввод B числа"></asp:Label>
                    <asp:TextBox ID="B" runat="server"></asp:TextBox>
                </div>
                <div>
                    <asp:Label ID="Labelresult" runat="server" Text="Результат" Visible="false"></asp:Label>
                    <asp:TextBox ID="result" runat="server" Visible="false" Enabled="false"></asp:TextBox>
                </div>
            </div>
        </fieldset>
        <fieldset>
            <legend>Действия:</legend>
            <div class ="d-flex">
                <asp:Button ID="Sum_Btn" Text="+" runat="server" OnClick="Sum_Btn_Click" />
                <asp:Button ID="Mul_Btn" Text="*" runat="server" OnClick="Mul_Btn_Click" />
                <asp:Button ID="Sub_Btn" Text="-" runat="server" OnClick="Sub_Btn_Click" />
                <asp:Button ID="Div_Btn" Text="/" runat="server" OnClick="Div_Btn_Click" />
                <asp:Button ID="Sqr_Btn" Text="√" runat="server" OnClick="Sqrt_Btn_Click" />
                <asp:Button ID="Pow2_Btn" Text="^2" runat="server" OnClick="Pow2_Btn_Click" />
                <asp:Button ID="Pow_btn" Text="^x" runat="server" OnClick="Pow_Btn_Click" />
                <asp:Button ID="Mod_btn" Text="%x" runat="server" OnClick="Mod_Btn_Click" />
            </div>
        </fieldset>
        <asp:LinkButton CssClass ="mt-3 OtherButton btn" runat="server" PostBackUrl ="../ASP_NET/Default.aspx" Text ="Вернуться на главную."/>
    </form>
</body>
</html>
