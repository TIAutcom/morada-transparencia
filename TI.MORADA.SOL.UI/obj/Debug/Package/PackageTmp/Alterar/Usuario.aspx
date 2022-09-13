<%@ Page Title="Alterar Usuário" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Usuario.aspx.cs" Inherits="TI.MORADA.SOL.UI.Alterar.Usuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Panel ID="pnlUser" runat="server">

        <div class="container">

            <div class="form-horizontal">
                <hr />
                <h4>Alterar Dados do Usuário</h4>
                <hr />

                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="TpUsuario" CssClass="col-md-2 control-label">Tipo Usuario</asp:Label>
                    <div class="col-md-10">
                        <asp:TextBox runat="server" ID="TpUsuario" Width="100%" CssClass="form-control" TextMode="Search" />
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="TpUsuario"
                            CssClass="text-danger" ErrorMessage="Campo Obrigatório." />
                    </div>
                </div>

                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="NivelAcesso" CssClass="col-md-2 control-label">Nivel Acesso</asp:Label>
                    <div class="col-md-10">
                        <asp:TextBox runat="server" ID="NivelAcesso" Width="100%" CssClass="form-control" TextMode="Search" />
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="NivelAcesso"
                            CssClass="text-danger" ErrorMessage="Campo Obrigatório." />
                    </div>
                </div>

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
                        <asp:TextBox runat="server" Width="100%" ID="Senha" CssClass="form-control" />
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="Senha"
                            CssClass="text-danger" ErrorMessage="Campo Obrigatório." />
                    </div>
                </div>
                <hr />
                <h4>Tipos de Dados</h4>

                <hr />
                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="ddlTipoUsuario" CssClass="col-md-2 control-label">Tipo Usuário</asp:Label>
                    <div class="col-md-10">
                        <asp:DropDownList ID="ddlTipoUsuario" CssClass="form-control" runat="server" ControlToValidate="ddlTipoUsuario" ErrorMessage="Campo Obrigatório." Width="100%"></asp:DropDownList>
                    </div>
                </div>
                <br />

                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="ddlNivelAcesso" CssClass="col-md-2 control-label">Nivél de Acesso</asp:Label>
                    <div class="col-md-10">
                        <asp:DropDownList ID="ddlNivelAcesso" CssClass="form-control" runat="server" ControlToValidate="ddlNivelAcesso" ErrorMessage="Campo Obrigatório." Width="100%"></asp:DropDownList>
                    </div>
                </div>
                <br />

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
                            Text="Salvar" CssClass="btn btn-default" ToolTip="Salvar Dados Usuário" data-toggle="modal" data-target="#myModal" OnClick="Unnamed14_Click" />
                    </div>
                </div>

                <div class="form-group">
                    <div class="col-md-offset-2 col-md-10">
                        <asp:LinkButton ID="LinkButton1" CssClass="btn btn-default" runat="server" PostBackUrl="~/Forms/Views/Usuario.aspx" OnClick="LinkButton1_Click">Voltar Página</asp:LinkButton>
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
    </asp:Panel>

    <!-- Modal -->
    <div class="modal fade" id="exampleModalCenter" tabindex="-1" role="dialog" aria-labelledby="exampleModalCenterTitle" aria-hidden="true">
        <div class="modal-dialog modal-dialog-centered" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="exampleModalLongTitle">Modal title</h5>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                    ...
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                    <button type="button" class="btn btn-primary">Save changes</button>
                </div>
            </div>
        </div>
    </div>

    <div id="myModal" class="modal" tabindex="-1" role="dialog">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title">Confirmação de Alteração de Dados do Usuário</h5>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                    <p>Realmente Deseja Alterar Dados do usuário?</p>
                </div>
                <div class="modal-footer">
                    <asp:Button ID="btnSalvar" runat="server" class="btn btn-primary" Text="Salvar" OnClick="btnSalvar_Click1" />
                    <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                </div>
            </div>
        </div>
    </div>

    <%--    <button type="button" class="btn btn-primary" data-toggle="modal" data-target="#exampleModalCenter">
        Launch demo modal
    </button>--%>
</asp:Content>
