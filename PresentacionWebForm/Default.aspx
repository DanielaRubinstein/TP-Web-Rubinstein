<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PresentacionWebForm._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

<%--    <div class="container" style="display: block;position:relative;width:50%;font-family: lato; margin-bottom: 20%;">
        <div class="header" style="position:relative;line-height: 3.1;background-color:cornflowerblue;text-align:center;">Ingresa tu cupon</div>
               <div ID="Voucher" style="position:absolute;width:100%;">
                   <asp:TextBox ID="txtVoucher" runat="server" OnTextChanged="txtVoucher_TextChanged"></asp:TextBox>
               </div>
           <asp:Button ID="btnVoucher" runat="server" Text="Siguiente" OnClick="btnVoucher_Click" style="float:right;" />
    </div>--%>

    <div class="header" style="font-family: lato;position:relative;line-height: 3.1;background-color:cornflowerblue;text-align:center;width:21.6%;">Ingresa tu cupón</div>
    <asp:TextBox ID="txtVoucher" runat="server"></asp:TextBox>
    <asp:Button ID="btnVoucher" runat="server" Text="Siguiente" OnClick="btnVoucher_Click" />

</asp:Content>
