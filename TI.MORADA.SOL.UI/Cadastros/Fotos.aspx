<%@ Page Title="Cadastro de Fotos" Language="C#" MasterPageFile="~/Site.Master" Debug="true" AutoEventWireup="true" CodeBehind="Fotos.aspx.cs" Inherits="TI.MORADA.SOL.UI.Cadastros.Fotos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Image ID="Image1" runat="server" />

    <div class="container">

        <div class="form-horizontal">
            <hr />
            <h4>Cadastro de Fotos para Galeria de Portifolio</h4>

            <hr />

            <asp:Label runat="server" AssociatedControlID="ddlGaleria" CssClass="col-md-2 control-label">Tipo Galeria</asp:Label>
            <div class="col-md-10">
                <div class="form-group">
                    <asp:DropDownList ID="ddlGaleria" runat="server" CssClass="form-control" Width="100%">
                        <asp:ListItem Value="0">Selecione Tipo de Galeria</asp:ListItem>
                        <asp:ListItem Value="1">Obras</asp:ListItem>
                        <asp:ListItem Value="2">Eventos</asp:ListItem>
                        <asp:ListItem Value="3">Sala Multi-Uso</asp:ListItem>
                        <asp:ListItem Value="4">Auditório</asp:ListItem>
                        <asp:ListItem Value="5">Foyer</asp:ListItem>
                        <asp:ListItem Value="6">Pavilhão MultiSetor</asp:ListItem>
                        <asp:ListItem Value="7">Área Externa I</asp:ListItem>
                        <asp:ListItem Value="9">Área Externa II</asp:ListItem>
                        <asp:ListItem Value="10">Área Externa III</asp:ListItem>
                        <asp:ListItem Value="11">Área Externa IV</asp:ListItem>
                        <asp:ListItem Value="12">Área Externa V</asp:ListItem>
                        <asp:ListItem Value="13">Área Externa VI</asp:ListItem>
                        <asp:ListItem Value="8">ARENA - Estádio da Fonte Luminosa</asp:ListItem>

                    </asp:DropDownList>
                </div>
            </div>

            <div class="form-group">
                <asp:Label runat="server" AssociatedControlID="Titulo" CssClass="col-md-2 control-label">Titulo</asp:Label>
                <div class="col-md-10">
                    <asp:TextBox runat="server" ID="Titulo" CssClass="form-control" Width="100%" TextMode="Search" />
                    <%--   <asp:RequiredFieldValidator runat="server" ControlToValidate="Titulo"
                    CssClass="text-danger" ErrorMessage="O campo de email é obrigatório.." />--%>
                </div>
            </div>

            <div class="form-group">
                <asp:Label runat="server" AssociatedControlID="Descricao" CssClass="col-md-2 control-label">Descrição</asp:Label>
                <div class="col-md-10">
                    <asp:TextBox runat="server" ID="Descricao" CssClass="form-control" Width="100%" TextMode="Search" MaxLength="40" />
                    <%--          <asp:RequiredFieldValidator runat="server" ControlToValidate="Descricao"
                    CssClass="text-danger" ErrorMessage="O campo de Descrição é obrigatório.." />--%>
                </div>
            </div>

            <div class="form-group">
                <div class="col-md-offset-2 col-md-10">
                    <asp:FileUpload ID="fupImagem" runat="server" Width="100%" CssClass="form-control" />
                    <br />
                </div>
            </div>

            <div class="form-group">
                <div class="col-md-offset-2 col-md-5">
                    <asp:Button runat="server" Text="Cadastrar" CssClass="btn btn-default" OnClick="Unnamed6_Click" />
                </div>

                <div class="col-lg-5 ">
                    <%--       <asp:LinkButton ID="LinkButton1" CssClass="hotpink" runat="server" OnClick="LinkButton1_Click">Voltar Página</asp:LinkButton>--%>
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
