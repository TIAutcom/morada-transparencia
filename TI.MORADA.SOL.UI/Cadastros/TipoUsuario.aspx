<%@ Page Title="Cadastro Tipo de Usuário" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TipoUsuario.aspx.cs" Inherits="TI.MORADA.SOL.UI.Cadastros.TipoUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="form-horizontal">
            <hr />
            <h4>Cadastro Tipo de Usuários</h4>
            <hr />
            <p class="text-danger">
                <asp:Literal runat="server" ID="ErrorMessage" />
            </p>
            <div class="form-group">
                <asp:Label runat="server" AssociatedControlID="TipoUser" CssClass="col-md-2 control-label">Descrição</asp:Label>
                <div class="col-md-10">
                    <asp:TextBox runat="server" ID="TipoUser" CssClass="form-control" TextMode="Search" Width="100%" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="TipoUser"
                        CssClass="text-danger" ErrorMessage="Campo Obrigatório." />
                </div>
            </div>
            <div class="form-group">
                <div class="col-md-offset-2 col-md-10">
                    <asp:Button runat="server"
                        Text="Salvar" CssClass="btn btn-default" OnClick="Unnamed3_Click" />
                </div>
            </div>

            <div class="form-group">
                <div class="col-lg-2 ">
                    <%--       <asp:LinkButton ID="LinkButton1" CssClass="hotpink" runat="server" OnClick="LinkButton1_Click">Voltar Página</asp:LinkButton>--%>
                    <input type="button" value="« voltar pagina" onclick="goBack()" style="display: inline-block; padding: 6px 12px; margin-bottom: 0; font-size: 14px; font-weight: normal; line-height: 1.428571429 text-align: center; white-space: nowrap; vertical-align: middle; cursor: pointer; border: 1px solid transparent; border-radius: 4px; -webkit-user-select: none; -moz-user-select: none; -ms-user-select: none; -o-user-select: none; user-select: none;" />
                </div>
            </div>

            <div class="form-group">
                <div class="col-md-offset-2 col-md-10">
                    <asp:Label ID="lblResponse" runat="server" CssClass="text-danger" Text=""></asp:Label>
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
