<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="AgendaVIEW.aspx.cs" Inherits="TecWeb_CRM.AgendaVIEW" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BannerContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    
     
       <center>
     
            Dia do Lembrete<br />
           <br />
             <asp:Calendar ID="CDagendaLembrete" runat="server"> 
            </asp:Calendar>

            Hora do Lembrete
           <br />
           <br />
           <asp:TextBox ID="TXHoraLembrete" runat="server" Width="70px" MaxLength="5"></asp:TextBox>


&nbsp;


           <br />
           <br />
           <asp:DropDownList ID="DropDAgenda" runat="server">
               <asp:ListItem Value="0">Segunda a Segunda</asp:ListItem>
               <asp:ListItem Value="1">Dia específico</asp:ListItem>
               <asp:ListItem Value="2">Segunda a Sexta</asp:ListItem>
           </asp:DropDownList>


<br />
           <br />
 Comentários
 
 <br />
           <br />
&nbsp;<asp:TextBox ID="TXAgenda" runat="server" TextMode="MultiLine"></asp:TextBox>
&nbsp;<br />
   
    <asp:Button ID="BTenviar" runat="server" Text="Enviar" 
        onclick="BTenviar_Click" />&nbsp &nbsp &nbsp &nbsp
        <asp:Button ID="BTcancelar" runat="server" Text="Cancelar" />

        </center>
   

</asp:Content>

<asp:Content ID="Content5" ContentPlaceHolderID="MainEsquerdaContent" runat="server">

    Agenda<br />
&nbsp;
<asp:GridView ID="MostraAgenda" runat="server">
            
            </asp:GridView>
        

</asp:Content>



<asp:Content ID="Content4" ContentPlaceHolderID="FootContent" runat="server">
</asp:Content>
