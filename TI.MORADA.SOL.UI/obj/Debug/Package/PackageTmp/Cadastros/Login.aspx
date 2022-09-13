<%@ Page Title="Cadastro de Usuário" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TI.MORADA.SOL.UI.Cadastros.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <div class="form-horizontal">
            <hr />
            <h4>Cadastro de Usuário</h4>
            <hr />
            <p class="text-danger">
                <asp:Literal runat="server" ID="ErrorMessage" />
            </p>

            <div class="form-group">
                <asp:Label runat="server" AssociatedControlID="ddlTipoUsuario" CssClass="col-md-2 control-label">Tipo Usuário</asp:Label>
                <div class="col-md-10">
                    <asp:DropDownList ID="ddlTipoUsuario" CssClass="form-control" runat="server" ControlToValidate="ddlTipoUsuario" ErrorMessage="Campo Obrigatório." Width="100%"></asp:DropDownList>
                </div>
            </div>
            <br />

            <div class="form-group">
                <asp:Label runat="server" AssociatedControlID="ddlNivelAcesso" CssClass="col-md-2 control-label">Nivél Acesso</asp:Label>
                <div class="col-md-10">
                    <asp:DropDownList ID="ddlNivelAcesso" CssClass="form-control" runat="server" ControlToValidate="ddlNivelAcesso" ErrorMessage="Campo Obrigatório." Width="100%"></asp:DropDownList>
                </div>
            </div>
            <br />

            <div class="form-group">
                <asp:Label runat="server" AssociatedControlID="Nome" CssClass="col-md-2 control-label">Nome</asp:Label>
                <div class="col-md-10">
                    <asp:TextBox runat="server" ID="Nome" Width="100%" CssClass="form-control" TextMode="Search" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="Nome"
                        CssClass="text-danger" ErrorMessage="Campo Obrigatório." />
                </div>
            </div>
            <div class="form-group">
                <asp:Label runat="server" AssociatedControlID="Email" CssClass="col-md-2 control-label">E-Mail</asp:Label>
                <div class="col-md-10">
                    <asp:TextBox runat="server" Width="100%" ID="Email" CssClass="form-control" TextMode="Email" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="Email"
                        CssClass="text-danger" ErrorMessage="Campo Obrigatório." />
                </div>
            </div>
            <div class="form-group">
                <asp:Label runat="server" AssociatedControlID="Senha" CssClass="col-md-2 control-label">Senha</asp:Label>
                <div class="col-md-10">
                    <asp:TextBox runat="server" Width="100%" ID="Senha" CssClass="form-control" TextMode="Password" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="Senha"
                        CssClass="text-danger" ErrorMessage="Campo Obrigatório." />
                </div>
            </div>

            <div class="form-group">
                <asp:Label runat="server" AssociatedControlID="ddtAtivo" CssClass="col-md-2 control-label">Ativação</asp:Label>
                <div class="col-md-10">
                    <asp:DropDownList ID="ddtAtivo" CssClass="form-control" runat="server" Width="100%" ControlToValidate="ddtAtivo" ErrorMessage="Campo Obrigatório.">
                        <asp:ListItem Value="true">Ativo</asp:ListItem>
                        <asp:ListItem Value="false">Inativo</asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>

            <div class="form-group">
                <div class="col-md-offset-2 col-md-10">
                    <asp:Label ID="lblResponse" runat="server" CssClass="text-danger" Text=""></asp:Label>
                </div>
            </div>

            <div class="form-group">
                <div class="col-md-offset-2 col-md-10">
                    <asp:Button runat="server"
                        Text="Salvar" CssClass="btn btn-default" ToolTip="Salvar Dados Usuário" OnClick="Unnamed9_Click" />
                </div>
            </div>

            <div class="form-group">
                <div class="col-lg-5 ">
                    <input type="button" value="« voltar pagina" onclick="goBack()" style="display: inline-block; padding: 6px 12px; margin-bottom: 0; font-size: 14px; font-weight: normal; line-height: 1.428571429 text-align: center; white-space: nowrap; vertical-align: middle; cursor: pointer; border: 1px solid transparent; border-radius: 4px; -webkit-user-select: none; -moz-user-select: none; -ms-user-select: none; -o-user-select: none; user-select: none;" />
                </div>
            </div>

            <div class="form-group">
                <div class="col-md-offset-2 col-md-10">
                    <b>
                        <asp:Label ID="lblLogin" CssClass="text-success" runat="server" Text="OPERADOR(A): ..."></asp:Label>
                    </b>
                </div>
            </div>


        </div>
    </div>

    <script>
        function goBack() {
            window.history.back()
        }
    </script>

</asp:Content>
