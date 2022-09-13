<%@ Page Title="Dados da Agenda" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DadosAgenda.aspx.cs" Inherits="TI.MORADA.SOL.UI.Forms.Views.DadosAgendaaspx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">

        <h2>Dados da Agenda</h2>
        <h4>
            <asp:Label ID="lblEvento" runat="server" Text="..."></asp:Label>
        </h4>
        <hr />

        <div class="row">
            <div class="form-group">

                <div class="col-lg-3 col-md-4 col-sm-6 portfolio-item">
                    <asp:Label runat="server" AssociatedControlID="PublicoPresente" CssClass="col-md-2 control-label">Púb.Presente</asp:Label>
                    <asp:TextBox ID="PublicoPresente" runat="server" Width="100%" CssClass="form-control" Text="0"></asp:TextBox>
                </div>

                <div class="col-lg-3 col-md-4 col-sm-6 portfolio-item">
                    <asp:Label runat="server" AssociatedControlID="PublicoEstimado" CssClass="col-md-2 control-label">Púb.Estimado</asp:Label>
                    <asp:TextBox ID="PublicoEstimado" runat="server" Width="100%" CssClass="form-control" Text="0"></asp:TextBox>
                </div>

                <div class="col-lg-3 col-md-4 col-sm-6 portfolio-item">
                    <asp:Label runat="server" AssociatedControlID="Data" CssClass="col-md-2 control-label">Data</asp:Label>
                    <asp:TextBox ID="Data" runat="server" Width="100%" CssClass="form-control"></asp:TextBox>
                </div>

                <div class="col-lg-3 col-md-4 col-sm-6 portfolio-item">
                    <asp:Label runat="server" AssociatedControlID="Sessao" CssClass="col-md-2 control-label">Sessão</asp:Label>
                    <asp:TextBox ID="Sessao" runat="server" Width="100%" CssClass="form-control"></asp:TextBox>
                </div>

            </div>
        </div>

        <br />

        <div class="row">
            <div class="form-group">
                <div class="col-md-12">
                    <asp:Label runat="server" AssociatedControlID="Evento" CssClass="col-md-2 control-label">Evento</asp:Label>
                    <asp:TextBox ID="Evento" runat="server" Width="100%" CssClass="form-control" TextMode="Search"></asp:TextBox>
                </div>
            </div>
        </div>

        <div class="row">
            <div class="form-group">
                <div class="col-md-12">
                    <asp:Label runat="server" AssociatedControlID="Local" CssClass="col-md-2 control-label">Local</asp:Label>
                    <asp:TextBox ID="Local" runat="server" Width="100%" CssClass="form-control" TextMode="Search"></asp:TextBox>
                </div>
            </div>
        </div>

        <div class="row">
            <div class="form-group">
                <div class="col-md-12">
                    <asp:Label runat="server" AssociatedControlID="Site" CssClass="col-md-2 control-label">Site</asp:Label>
                    <asp:TextBox ID="Site" runat="server" Width="100%" CssClass="form-control" TextMode="Search"></asp:TextBox>
                </div>
            </div>
        </div>

        <div class="row">
            <div class="form-group">
                <div class="col-md-12">
                    <asp:Label runat="server" AssociatedControlID="Descricao" CssClass="col-xs-12 .col-sm-6 .col-md-8">Descrição</asp:Label>
                    <asp:TextBox ID="Descricao" runat="server" Width="100%" CssClass="form-control" TextMode="MultiLine" Rows="5"></asp:TextBox>
                </div>
            </div>
        </div>

        <div class="row">
            <div class="form-group">
                <div class="col-md-12">
                    <asp:Label runat="server" AssociatedControlID="Observacao" CssClass="col-xs-12 .col-sm-6 .col-md-8">Observação</asp:Label>
                    <asp:TextBox ID="Observacao" runat="server" Width="100%" CssClass="form-control" TextMode="MultiLine" Rows="5"></asp:TextBox>
                </div>
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-4">
                <asp:Button runat="server"
                    Text="Salvar" CssClass="btn btn-primary" data-toggle="modal" data-target="#modalExemplo" OnClick="Unnamed10_Click" />
            </div>

            <div class="col-md-2">
                <asp:Button runat="server"
                    Text="Deletar" CssClass="btn btn-danger" data-toggle="modal" data-target="#modalDel" OnClick="Unnamed11_Click" />
            </div>
        </div>

        <div class="form-group">
            <div class="col-lg-5 ">
                <input type="button" value="« voltar pagina" onclick="goBack()" style="display: inline-block; padding: 6px 12px; margin-bottom: 0; font-size: 14px; font-weight: normal; line-height: 1.428571429 text-align: center; white-space: nowrap; vertical-align: middle; cursor: pointer; border: 1px solid transparent; border-radius: 4px; -webkit-user-select: none; -moz-user-select: none; -ms-user-select: none; -o-user-select: none; user-select: none;" />
            </div>
        </div>

    </div>

    <hr />

    <div class="form-group">
        <div class="col-md-offset-0 col-md-10">
            <b>
                <asp:Label ID="lblLogin" CssClass="text-success" runat="server" Text="OP: ..."></asp:Label>
            </b>
        </div>
    </div>



    <!-- Modal -->
    <div class="modal fade" id="modalExemplo" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="exampleModalLabel">Alterar Dados Agenda</h5>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Fechar">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                    Realmente Deseja Alterar Dados da Agenda Selecionada?
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-dismiss="modal">Fechar</button>
                    <asp:Button ID="btnSalvar" runat="server" Text="Alterar" CssClass="btn btn-primary" OnClick="btnSalvar_Click" Width="30%" />
                </div>
            </div>
        </div>
    </div>

    <!-- Modal -->
    <div class="modal fade" id="modalDel" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="exampleModalLabel">Deletar Dados Agenda</h5>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Fechar">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                    Realmente Deseja Deletar Dados da Agenda Selecionada?
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-dismiss="modal">Fechar</button>
                    <asp:Button ID="btnDel" runat="server" Text="Deletar" CssClass="btn btn-primary" OnClick="btnDel_Click" Width="30%" />
                </div>
            </div>
        </div>
    </div>

    <div class="form-group">
        <div class="col-lg-5 ">
            <input type="button" value="« voltar pagina" onclick="goBack()" style="display: inline-block; padding: 6px 12px; margin-bottom: 0; font-size: 14px; font-weight: normal; line-height: 1.428571429 text-align: center; white-space: nowrap; vertical-align: middle; cursor: pointer; border: 1px solid transparent; border-radius: 4px; -webkit-user-select: none; -moz-user-select: none; -ms-user-select: none; -o-user-select: none; user-select: none;" />
        </div>
    </div>

    <script>
        function goBack() {
            window.history.back()
        }
    </script>

</asp:Content>
