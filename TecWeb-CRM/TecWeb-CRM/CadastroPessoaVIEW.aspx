<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="CadastroPessoaVIEW.aspx.cs" Inherits="TecWeb_CRM.CadastroPessoa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BannerContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">

    <div id="CadForm">

<h3>Formulário</h3>


        <br />
        <br />
        <br />
        Login&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TXLogin" 
            runat="server"></asp:TextBox>
    <br />
    <br />

   Senha&nbsp;&nbsp;&nbsp;&nbsp; 
    <asp:TextBox ID="TXSenha"
        runat="server" TextMode="Password"></asp:TextBox>
    <br />
    <br />
    Nome&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TXNome" runat="server"></asp:TextBox>
    <br />
    <br />
    Email&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox
            ID="TXEmail" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
&nbsp;<asp:Button ID="BTNenviar" runat="server" Text="Enviar" 
            onclick="BTNenviar_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="BTNcancelar" runat="server" Text="Cancelar" />
<br />

</div>


    </asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="FootContent" runat="server">
</asp:Content>
