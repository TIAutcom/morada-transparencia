<%@ Page Title="Lista de Usuário" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Usuario.aspx.cs" Inherits="TI.MORADA.SOL.UI.Forms.Views.Usuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <hr />
        <h4>Lista de Usuários</h4>
        <hr />
        <div class="row">
            <div>
                <asp:TextBox ID="Pesquisar" runat="server" placeholder="Pesquisar" Style="height: 34px; padding: 6px 12px; font-size: 14px; line-height: 1.428571429; color: #555555; vertical-align: middle; background-color: #ffffff; background-image: none; border: 1px solid #cccccc; border-radius: 4px; -webkit-box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075); box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075); -webkit-transition: border-color ease-in-out 0.15s, box-shadow ease-in-out 0.15s; transition: border-color ease-in-out 0.15s, box-shadow ease-in-out 0.15s; margin-right: 0px;" Width="100%"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" Text="Enter" class="btn btn-primary" />
            </div>
            <br />

            <div class="table-responsive">
                <asp:GridView ID="gdvUsuario" runat="server" Width="100%" CssClass="table table-striped table-bordered table-hover" AutoGenerateColumns="False" DataKeyNames="Id" EmptyDataText="Não há registros de dados para exibir." ShowHeader="False" OnRowCommand="gdvUsuario_RowCommand" OnRowUpdating="gdvUsuario_RowUpdating" OnRowDeleting="gdvUsuario_RowDeleting" OnRowDataBound="gdvUsuario_RowDataBound">

                    <Columns>
                        <asp:BoundField DataField="Id" HeaderText="Id" Visible="False" />

                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:LinkButton CommandName="update" DataKeyNames="Descricao" DataField="Nome" runat="server" CommandArgument='<%# Eval("ID") %>' Text='<%# Eval("Nome") %>'></asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="Email" HeaderText="E-mail" SortExpression="Email" HeaderStyle-CssClass="visible-lg" ItemStyle-CssClass="visible-lg">
                            <HeaderStyle CssClass="visible-lg"></HeaderStyle>

                            <ItemStyle CssClass="visible-lg"></ItemStyle>
                        </asp:BoundField>
                        <asp:BoundField DataField="Data" HeaderText="Data" SortExpression="Data" HeaderStyle-CssClass="visible-lg" ItemStyle-CssClass="visible-lg" Visible="false">
                            <HeaderStyle CssClass="visible-lg"></HeaderStyle>

                            <ItemStyle CssClass="visible-lg"></ItemStyle>
                        </asp:BoundField>
                        <asp:BoundField DataField="DescNivel" HeaderText="DescNivel" SortExpression="Nivel de Acesso" HeaderStyle-CssClass="visible-lg" ItemStyle-CssClass="visible-lg" Visible="true">
                            <HeaderStyle CssClass="visible-lg"></HeaderStyle>

                            <ItemStyle CssClass="visible-lg"></ItemStyle>
                        </asp:BoundField>

                    </Columns>
                    <Columns>
                        <asp:TemplateField>
                            <ItemStyle Width="5%" />
                            <ItemTemplate>
                                <asp:LinkButton ID="lkDelete" CommandName="Delete" DataKeyNames="Delete" DataField="Delete" runat="server" ToolTip="Deletar de Usuário" CommandArgument='<%# Eval("ID") %>'>Deletar</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>

    <div>
        <b>
            <asp:Label ID="lblLogin" CssClass="text-success" runat="server" Text="OPERADOR(A): ..."></asp:Label>
        </b>
    </div>

    <div class="form-group">
        <div class="col-lg-5 ">
            <input type="button" value="« voltar pagina" onclick="goBack()" style="display: inline-block; padding: 6px 12px; margin-bottom: 0; font-size: 14px; font-weight: normal; line-height: 1.428571429 text-align: center; white-space: nowrap; vertical-align: middle; cursor: pointer; border: 1px solid transparent; border-radius: 4px; -webkit-user-select: none; -moz-user-select: none; -ms-user-select: none; -o-user-select: none; user-select: none;" />
        </div>
    </div>

    <br />
    <div class="form-group">
        <div class="col-md-offset-2 col-md-10">
            <asp:Label ID="lblResponse" runat="server" CssClass="text-danger" Text=""></asp:Label>
        </div>
    </div>

    <script>
        function goBack() {
            window.history.back()
        }
    </script>

</asp:Content>
