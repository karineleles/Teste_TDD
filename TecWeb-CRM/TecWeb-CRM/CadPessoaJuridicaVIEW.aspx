<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="CadPessoaJuridicaVIEW.aspx.cs" Inherits="TecWeb_CRM.PessoaFísica" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BannerContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <asp:FormView ID="FormView2" runat="server" DataKeyNames="CodPessoaj" 
        DataSourceID="DSJuridica" DefaultMode="Insert">
        <EditItemTemplate>
            CodPessoaj:
            <asp:Label ID="CodPessoajLabel1" runat="server" 
                Text='<%# Eval("CodPessoaj") %>' />
            <br />
            CodPessoa:
            <asp:TextBox ID="CodPessoaTextBox" runat="server" 
                Text='<%# Bind("CodPessoa") %>' />
            <br />
            Cnpj:
            <asp:TextBox ID="CnpjTextBox" runat="server" Text='<%# Bind("Cnpj") %>' />
            <br />
            RazaoSocial:
            <asp:TextBox ID="RazaoSocialTextBox" runat="server" 
                Text='<%# Bind("RazaoSocial") %>' />
            <br />
            <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" 
                CommandName="Update" Text="Update" />
            &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" 
                CausesValidation="False" CommandName="Cancel" Text="Cancel" />
        </EditItemTemplate>
        <InsertItemTemplate>
            CodPessoa:
            <asp:TextBox ID="CodPessoaTextBox" runat="server" 
                Text='<%# Bind("CodPessoa") %>' />
            <br />
            Cnpj:
            <asp:TextBox ID="CnpjTextBox" runat="server" Text='<%# Bind("Cnpj") %>' />
            <br />
            RazaoSocial:
            <asp:TextBox ID="RazaoSocialTextBox" runat="server" 
                Text='<%# Bind("RazaoSocial") %>' />
            <br />
            <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" 
                CommandName="Insert" Text="Insert" />
            &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" 
                CausesValidation="False" CommandName="Cancel" Text="Cancel" />
        </InsertItemTemplate>
        <ItemTemplate>
            CodPessoaj:
            <asp:Label ID="CodPessoajLabel" runat="server" 
                Text='<%# Eval("CodPessoaj") %>' />
            <br />
            CodPessoa:
            <asp:Label ID="CodPessoaLabel" runat="server" Text='<%# Bind("CodPessoa") %>' />
            <br />
            Cnpj:
            <asp:Label ID="CnpjLabel" runat="server" Text='<%# Bind("Cnpj") %>' />
            <br />
            RazaoSocial:
            <asp:Label ID="RazaoSocialLabel" runat="server" 
                Text='<%# Bind("RazaoSocial") %>' />
            <br />
            <asp:LinkButton ID="EditButton" runat="server" CausesValidation="False" 
                CommandName="Edit" Text="Edit" />
            &nbsp;<asp:LinkButton ID="DeleteButton" runat="server" CausesValidation="False" 
                CommandName="Delete" Text="Delete" />
            &nbsp;<asp:LinkButton ID="NewButton" runat="server" CausesValidation="False" 
                CommandName="New" Text="New" />
        </ItemTemplate>
    </asp:FormView>
    <asp:SqlDataSource ID="DSJuridica" runat="server" 
        ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
        DeleteCommand="DELETE FROM [Pessoa_Juridica] WHERE [CodPessoaj] = @CodPessoaj" 
        InsertCommand="INSERT INTO [Pessoa_Juridica] ([CodPessoa], [Cnpj], [RazaoSocial]) VALUES (@CodPessoa, @Cnpj, @RazaoSocial)" 
        SelectCommand="SELECT * FROM [Pessoa_Juridica]" 
        UpdateCommand="UPDATE [Pessoa_Juridica] SET [CodPessoa] = @CodPessoa, [Cnpj] = @Cnpj, [RazaoSocial] = @RazaoSocial WHERE [CodPessoaj] = @CodPessoaj">
        <DeleteParameters>
            <asp:Parameter Name="CodPessoaj" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="CodPessoa" Type="Int32" />
            <asp:Parameter Name="Cnpj" Type="String" />
            <asp:Parameter Name="RazaoSocial" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="CodPessoa" Type="Int32" />
            <asp:Parameter Name="Cnpj" Type="String" />
            <asp:Parameter Name="RazaoSocial" Type="String" />
            <asp:Parameter Name="CodPessoaj" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
    <br />
    <br />
    <asp:FormView ID="FormView1" runat="server" DataKeyNames="CodPessoa" 
        DataSourceID="DSPessoa" DefaultMode="Insert">
        <EditItemTemplate>
            CodPessoa:
            <asp:Label ID="CodPessoaLabel1" runat="server" 
                Text='<%# Eval("CodPessoa") %>' />
            <br />
            Endereco:
            <asp:TextBox ID="EnderecoTextBox" runat="server" 
                Text='<%# Bind("Endereco") %>' />
            <br />
            Cidade:
            <asp:TextBox ID="CidadeTextBox" runat="server" Text='<%# Bind("Cidade") %>' />
            <br />
            Estado:
            <asp:TextBox ID="EstadoTextBox" runat="server" Text='<%# Bind("Estado") %>' />
            <br />
            Pais:
            <asp:TextBox ID="PaisTextBox" runat="server" Text='<%# Bind("Pais") %>' />
            <br />
            Cep:
            <asp:TextBox ID="CepTextBox" runat="server" Text='<%# Bind("Cep") %>' />
            <br />
            Telefone1:
            <asp:TextBox ID="Telefone1TextBox" runat="server" 
                Text='<%# Bind("Telefone1") %>' />
            <br />
            Telefone2:
            <asp:TextBox ID="Telefone2TextBox" runat="server" 
                Text='<%# Bind("Telefone2") %>' />
            <br />
            Email:
            <asp:TextBox ID="EmailTextBox" runat="server" Text='<%# Bind("Email") %>' />
            <br />
            Comentarios:
            <asp:TextBox ID="ComentariosTextBox" runat="server" 
                Text='<%# Bind("Comentarios") %>' />
            <br />
            <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" 
                CommandName="Update" Text="Update" />
            &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" 
                CausesValidation="False" CommandName="Cancel" Text="Cancel" />
        </EditItemTemplate>
        <InsertItemTemplate>
            Endereco:
            <asp:TextBox ID="EnderecoTextBox" runat="server" 
                Text='<%# Bind("Endereco") %>' />
            <br />
            Cidade:
            <asp:TextBox ID="CidadeTextBox" runat="server" Text='<%# Bind("Cidade") %>' />
            <br />
            Estado:
            <asp:TextBox ID="EstadoTextBox" runat="server" Text='<%# Bind("Estado") %>' />
            <br />
            Pais:
            <asp:TextBox ID="PaisTextBox" runat="server" Text='<%# Bind("Pais") %>' />
            <br />
            Cep:
            <asp:TextBox ID="CepTextBox" runat="server" Text='<%# Bind("Cep") %>' />
            <br />
            Telefone1:
            <asp:TextBox ID="Telefone1TextBox" runat="server" 
                Text='<%# Bind("Telefone1") %>' />
            <br />
            Telefone2:
            <asp:TextBox ID="Telefone2TextBox" runat="server" 
                Text='<%# Bind("Telefone2") %>' />
            <br />
            Email:
            <asp:TextBox ID="EmailTextBox" runat="server" Text='<%# Bind("Email") %>' />
            <br />
            Comentarios:
            <asp:TextBox ID="ComentariosTextBox" runat="server" 
                Text='<%# Bind("Comentarios") %>' />
            <br />
            <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" 
                CommandName="Insert" Text="Insert" />
            &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" 
                CausesValidation="False" CommandName="Cancel" Text="Cancel" />
        </InsertItemTemplate>
        <ItemTemplate>
            CodPessoa:
            <asp:Label ID="CodPessoaLabel" runat="server" Text='<%# Eval("CodPessoa") %>' />
            <br />
            Endereco:
            <asp:Label ID="EnderecoLabel" runat="server" Text='<%# Bind("Endereco") %>' />
            <br />
            Cidade:
            <asp:Label ID="CidadeLabel" runat="server" Text='<%# Bind("Cidade") %>' />
            <br />
            Estado:
            <asp:Label ID="EstadoLabel" runat="server" Text='<%# Bind("Estado") %>' />
            <br />
            Pais:
            <asp:Label ID="PaisLabel" runat="server" Text='<%# Bind("Pais") %>' />
            <br />
            Cep:
            <asp:Label ID="CepLabel" runat="server" Text='<%# Bind("Cep") %>' />
            <br />
            Telefone1:
            <asp:Label ID="Telefone1Label" runat="server" Text='<%# Bind("Telefone1") %>' />
            <br />
            Telefone2:
            <asp:Label ID="Telefone2Label" runat="server" Text='<%# Bind("Telefone2") %>' />
            <br />
            Email:
            <asp:Label ID="EmailLabel" runat="server" Text='<%# Bind("Email") %>' />
            <br />
            Comentarios:
            <asp:Label ID="ComentariosLabel" runat="server" 
                Text='<%# Bind("Comentarios") %>' />
            <br />
            <asp:LinkButton ID="EditButton" runat="server" CausesValidation="False" 
                CommandName="Edit" Text="Edit" />
            &nbsp;<asp:LinkButton ID="DeleteButton" runat="server" CausesValidation="False" 
                CommandName="Delete" Text="Delete" />
            &nbsp;<asp:LinkButton ID="NewButton" runat="server" CausesValidation="False" 
                CommandName="New" Text="New" />
        </ItemTemplate>
    </asp:FormView>
    <asp:SqlDataSource ID="DSPessoa" runat="server" 
        ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
        DeleteCommand="DELETE FROM [Pessoa] WHERE [CodPessoa] = @CodPessoa" 
        InsertCommand="INSERT INTO [Pessoa] ([Endereco], [Cidade], [Estado], [Pais], [Cep], [Telefone1], [Telefone2], [Email], [Comentarios]) VALUES (@Endereco, @Cidade, @Estado, @Pais, @Cep, @Telefone1, @Telefone2, @Email, @Comentarios)" 
        SelectCommand="SELECT * FROM [Pessoa]" 
        UpdateCommand="UPDATE [Pessoa] SET [Endereco] = @Endereco, [Cidade] = @Cidade, [Estado] = @Estado, [Pais] = @Pais, [Cep] = @Cep, [Telefone1] = @Telefone1, [Telefone2] = @Telefone2, [Email] = @Email, [Comentarios] = @Comentarios WHERE [CodPessoa] = @CodPessoa">
        <DeleteParameters>
            <asp:Parameter Name="CodPessoa" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="Endereco" Type="String" />
            <asp:Parameter Name="Cidade" Type="String" />
            <asp:Parameter Name="Estado" Type="String" />
            <asp:Parameter Name="Pais" Type="String" />
            <asp:Parameter Name="Cep" Type="String" />
            <asp:Parameter Name="Telefone1" Type="String" />
            <asp:Parameter Name="Telefone2" Type="String" />
            <asp:Parameter Name="Email" Type="String" />
            <asp:Parameter Name="Comentarios" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="Endereco" Type="String" />
            <asp:Parameter Name="Cidade" Type="String" />
            <asp:Parameter Name="Estado" Type="String" />
            <asp:Parameter Name="Pais" Type="String" />
            <asp:Parameter Name="Cep" Type="String" />
            <asp:Parameter Name="Telefone1" Type="String" />
            <asp:Parameter Name="Telefone2" Type="String" />
            <asp:Parameter Name="Email" Type="String" />
            <asp:Parameter Name="Comentarios" Type="String" />
            <asp:Parameter Name="CodPessoa" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="FootContent" runat="server">
</asp:Content>
