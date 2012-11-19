<%@ Page Title="Visita" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="VisitaVIEW.aspx.cs" Inherits="Visita" %>

<script runat="server">

</script>
<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">

<ul class="SubMenu" id="navigationMenu">
<li class="SubMenu"><a href="AtividadeVIEW.aspx" class="normalMenu">Atividade</a></li>
<li class="SubMenu"><a href="PedidoVIEW.aspx" class="normalMenu">Pedido</a></li>
<li class="SubMenu"><a href="VisitaVIEW.aspx" class="normalMenu">Visita</a></li>
<li class="SubMenu"><a href="AgendaVIEW.aspx" class="normalMenu">Agenda</a></li>
</ul>
    <asp:GridView ID="GridViewVisita" runat="server">
    </asp:GridView>
<br />
    

  

</asp:Content>
