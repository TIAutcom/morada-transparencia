<%@ Page Title="Cadastro de Leis" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Lei.aspx.cs" Inherits="TI.MORADA.SOL.UI.Cadastros.Lei" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <div class="form-horizontal">
            <hr />
            <h4>Cadastro Lei de Acesso a Informação</h4>
            <hr />

            <div class="form-group">
                <asp:Label runat="server" AssociatedControlID="Descricao" CssClass="col-md-2 control-label">Descrição</asp:Label>
                <div class="col-md-10">
                    <asp:TextBox runat="server" ID="Descricao" CssClass="form-control" Width="100%" TextMode="Search" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="Descricao"
                        CssClass="text-danger" ErrorMessage="O campo de email é obrigatório.." />
                </div>
            </div>

            <div class="form-group">
                <div class="col-md-offset-2 col-md-10">
                    <asp:Button runat="server" Text="Cadastrar" CssClass="btn btn-default" OnClick="Unnamed3_Click" />
                </div>

        </div>

        <div class="form-group">
                <div class="col-md-offset-2 col-md-10">
                    <%--       <asp:LinkButton ID="LinkButton1" CssClass="hotpink" runat="server" OnClick="LinkButton1_Click">Voltar Página</asp:LinkButton>--%>
                    <input type="button" value="« voltar pagina" onclick="goBack()" style="display: inline-block; padding: 6px 12px; margin-bottom: 0; font-size: 14px; font-weight: normal; line-height: 1.428571429 text-align: center; white-space: nowrap; vertical-align: middle; cursor: pointer; border: 1px solid transparent; border-radius: 4px; -webkit-user-select: none; -moz-user-select: none; -ms-user-select: none; -o-user-select: none; user-select: none;" />
                </div>
            </div>

            <div class="form-group">


                <div class="col-md-offset-2 col-md-10">
                    <p class="text-danger">
                        <asp:Literal runat="server" ID="lblResponse" />
                    </p>
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
