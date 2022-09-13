<%@ Page Title="Lista de Usuário" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TipoUsuario.aspx.cs" Inherits="TI.MORADA.SOL.UI.Forms.Views.TipoUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <hr />
        <h4>Lista Tipo de Usuários</h4>
        <hr />
        <div class="row">
            <div class="col-lg-10 ">
                <div>
                    <asp:TextBox ID="Pesquisar" runat="server" placeholder="Pesquisa" Style="height: 34px; padding: 6px 12px; font-size: 14px; line-height: 1.428571429; color: #555555; vertical-align: middle; background-color: #ffffff; background-image: none; border: 1px solid #cccccc; border-radius: 4px; -webkit-box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075); box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075); -webkit-transition: border-color ease-in-out 0.15s, box-shadow ease-in-out 0.15s; transition: border-color ease-in-out 0.15s, box-shadow ease-in-out 0.15s; margin-right: 0px;" Width="275px"></asp:TextBox>
                    <asp:Button ID="Button1" runat="server" Text="Enter" class="btn btn-primary" />
                </div>
                <br />

                <div class="table-responsive">
                    <asp:GridView ID="gdvTipos" runat="server" Width="100%" CssClass="table table-striped table-bordered table-hover" AutoGenerateColumns="False" DataKeyNames="Id" EmptyDataText="Não há registros de dados para exibir." PageSize="100" ShowHeader="False">

                        <Columns>
                            <asp:BoundField DataField="Id" HeaderText="Id" Visible="False" />

                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:HyperLink ID="Descricao" DataKeyNames="Descricao" DataField="Descricao" runat="server" NavigateUrl="#" Text='<%# Eval("Descricao") %>'></asp:HyperLink>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:HyperLinkField DataTextField="IdUsuario" Text="IdUsuario" Visible="False" />
                            <asp:BoundField DataField="Data" HeaderText="Data" Visible="False" />

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


        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Label ID="lblResponse" runat="server" CssClass="text-danger" Text="..."></asp:Label>
            </div>
        </div>

    </div>

    <script>
        function goBack() {
            window.history.back()
        }
    </script>

</asp:Content>
