<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Foto.aspx.cs" Inherits="TI.MORADA.SOL.ADMINISTRACAO.Cadastro.Foto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="shadowBox">
        <div class="page-container">

            <h2><%: Title %></h2>

            <div class="form-horizontal">
                <asp:HiddenField ID="hfId" runat="server" />

                <hr />
                <asp:ValidationSummary runat="server" CssClass="text-danger" />
                <p class="text-danger">
                    <asp:Literal runat="server" ID="ErrorMessage" />
                </p>
                <p>Selecione Até 2 Fotos por Vez para Salvar Evento.</p>

                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="flUpFile" CssClass="col-md-2 control-label">Arquivo:</asp:Label>
                    <div class="col-md-10">
                        <asp:FileUpload ID="flUpFile" runat="server" CssClass="form-control" AllowMultiple="True" Multiple="Multiple" />
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="flUpFile" CssClass="text-danger" ErrorMessage="Campo Obrigatório." />
                    </div>

                </div>

                <div class="form-group">
                    <div class="col-md-offset-2 col-md-4">
                        <asp:Button runat="server" Text="Salvar" CssClass="btn btn-default" Width="130px" ToolTip="Salvar Dados Usuário" OnClick="Unnamed4_Click" />

                        <%--                        <asp:Button runat="server" Text="Novo" CssClass="btn btn-default" Width="130px" ToolTip="Novo Dados Usuário" />--%>
                    </div>
                </div>

                <div class="form-group">
                    <div class="col-md-offset-12 col-md-10">
                        <asp:Label ID="lblResponse" runat="server" CssClass="text-danger" Text=""></asp:Label>
                    </div>
                </div>

            </div>
        </div>

        <script type="text/javascript">
            $(function () {
                $('#datetimepicker1').datetimepicker();
            });
        </script>

        <link rel="stylesheet" href="https://cdn.rawgit.com/Eonasdan/bootstrap-datetimepicker/e8bddc60e73c1ec2475f827be36e1957af72e2ea/build/css/bootstrap-datetimepicker.css" />
        <script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/moment.js/2.9.0/moment-with-locales.js"></script>
        <script type="text/javascript" src="https://cdn.rawgit.com/Eonasdan/bootstrap-datetimepicker/e8bddc60e73c1ec2475f827be36e1957af72e2ea/src/js/bootstrap-datetimepicker.js"></script>
    </div>

</asp:Content>
