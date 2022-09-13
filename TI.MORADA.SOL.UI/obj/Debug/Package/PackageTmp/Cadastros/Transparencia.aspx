<%@ Page Title="Cadastro de Transparência" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Transparencia.aspx.cs" Inherits="TI.MORADA.SOL.UI.Cadastros.Transparencia" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <div class="form-horizontal">
        <h4>
            <asp:Label ID="lblDescricaLai" runat="server" Text="..."></asp:Label>
        </h4>
        <hr />
        <asp:ValidationSummary runat="server" CssClass="text-danger" />
        <p class="text-danger">
            <asp:Literal runat="server" ID="ErrorMessage" />
        </p>

        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="ddlAno" CssClass="col-md-2 control-label">Ano</asp:Label>
            <div class="col-md-10">
                <asp:DropDownList ID="ddlAno" CssClass="form-control" runat="server" ControlToValidate="ddlAno" Width="100%" DataTextFormatString="Data" AppendDataBoundItems="true" Height="34px">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem>2017</asp:ListItem>
                    <asp:ListItem>2018</asp:ListItem>
                    <asp:ListItem>2019</asp:ListItem>
                </asp:DropDownList>
            </div>
        </div>

        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Descricao" CssClass="col-md-2 control-label">Descrição</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Descricao" CssClass="form-control" TextMode="Search" Width="100%" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Descricao"
                    CssClass="text-danger" ErrorMessage="Campo Obrigatório." />
            </div>
        </div>

        <br />
        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button runat="server"
                    Text="Salvar" CssClass="btn btn-default" ToolTip="Salvar Dados Usuário" OnClick="Unnamed5_Click" />
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Label ID="lblResponse" runat="server" CssClass="text-danger" Text=""></asp:Label>
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Label ID="lblLogin" CssClass="btn btn-primary" runat="server" Text="OPERADOR(A): ..."></asp:Label>
            </div>
        </div>

        <div class="form-group">
            <div class="col-lg-5 ">
                <input type="button" value="« voltar pagina" onclick="goBack()" style="display: inline-block; padding: 6px 12px; margin-bottom: 0; font-size: 14px; font-weight: normal; line-height: 1.428571429 text-align: center; white-space: nowrap; vertical-align: middle; cursor: pointer; border: 1px solid transparent; border-radius: 4px; -webkit-user-select: none; -moz-user-select: none; -ms-user-select: none; -o-user-select: none; user-select: none;" />
            </div>
        </div>

    </div>

    <script>
        function goBack() {
            window.history.back()
        }
    </script>
</asp:Content>
