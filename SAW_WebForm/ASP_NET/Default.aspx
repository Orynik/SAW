<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SAW_WebForm.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <link href="../Content/Main.css" rel="stylesheet" />
    <title>Главная страница</title>
</head>
<body>
    <form class ="main" runat="server">
       <section class = "AboutSAW">
           <h1>Автоматизация рабочего места сотрудников компании</h1>
           <p>Выполнена студентом Ангарского Политехнического техникума специальности 
               09.02.04 "Информационные системы"</p>
           <asp:Button runat="server" CssClass ="SAWButton btn btn-primary" Text="Справочная информация по расчетам »" PostBackUrl="~/ASP_NET/SPRForm.aspx" />
       </section>
       <div class = "d-flex justify-content-center">
           <section class = "otherSection CalcSection">
                <h1>Расчеты на калькуляторе онлайн</h1>
                <p>Онлайн калькулятор расчитан на выполнения 
                    вычисления несколькими сотрудниками</p>
               <asp:Button runat="server" CssClass ="OtherButton btn" Text="Справочная информация по расчетам »" PostBackUrl="~/ASP_NET/CALForm.aspx" />
           </section>
           <section class = "otherSection CalcSSection">
                <h1>Расчет площади конуса и цилиндра</h1>
                <p>Онлайн калькулятор площади конуса и цилиндра расчитан на выполнения 
                    вычисления несколькими сотрудниками</p>
                <asp:Button runat="server" CssClass ="OtherButton btn" Text="Расчет площади »" PostBackUrl="~/ASP_NET/PLForm.aspx" />
           </section>
           <section class = "otherSection CalcVSection">
               <h1>Расчет объема конуса и цилиндра</h1>
               <p>Онлайн калькулятор площади конуса и цилиндра расчитан на выполнения 
                   вычисления несколькими сотрудниками</p>
                <asp:Button runat="server" CssClass ="OtherButton btn" Text="Расчет объема »" PostBackUrl="~/ASP_NET/OBForm.aspx" />
           </section>
       </div>
    </form>
</body>
</html>
