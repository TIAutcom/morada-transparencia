<%@ Page Title="Agenda de Eventos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Agenda.aspx.cs" Inherits="TI.MORADA.SOL.UI.Forms.Views.Agenda" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <hr />
        <h4>Dados da Agenda</h4>
        <hr />

        <div class="row">
            <div class="col-lg-3 col-md-4 col-sm-6 portfolio-item">
                <asp:Label runat="server" AssociatedControlID="ddlAno" CssClass="col-md-2 control-label">Ano</asp:Label>
                <asp:DropDownList ID="ddlAno" runat="server" Width="100%" CssClass="form-control" AutoPostBack="true" OnSelectedIndexChanged="ddlAno_SelectedIndexChanged">
                    <asp:ListItem>2022</asp:ListItem>
                    <asp:ListItem>2021</asp:ListItem>
                    <asp:ListItem>2020</asp:ListItem>
                    <asp:ListItem>2019</asp:ListItem>
                    <asp:ListItem>2018</asp:ListItem>

                </asp:DropDownList>
            </div>

            <div class="col-lg-3 col-md-4 col-sm-6 portfolio-item">
                <asp:Label runat="server" AssociatedControlID="ddlMes" CssClass="col-md-2 control-label">Mês</asp:Label>
                <asp:DropDownList ID="ddlMes" runat="server" Width="100%" CssClass="form-control" AutoPostBack="true" OnSelectedIndexChanged="ddlMes_SelectedIndexChanged">
                </asp:DropDownList>
            </div>
        </div>

        <br />
        <div class="row">

            <div class="table-responsive">
                <asp:GridView ID="gdvAgenda" runat="server" Width="100%" CssClass="table table-striped table-bordered table-hover" DataKeyNames="Id" EmptyDataText="Não há registros de dados para exibir." PageSize="100" AutoGenerateColumns="False" OnRowCommand="gdvAgenda_RowCommand">
                    <Columns>
                        <asp:BoundField DataField="Id" HeaderText="ID" Visible="False" />
                        <asp:TemplateField HeaderText="Eventos">
                            <ItemTemplate>
                                <asp:HiddenField ID="hfId" runat="server" Value='<%# Eval("Id") %>' />
                                <asp:LinkButton ID="lblIdEvento" runat="server" CommandArgument='<%# Eval("Id") %>' CommandName="SelecioneEvento"><%# Eval("Descricao")%></asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <%-- <asp:TemplateField HeaderText="Tipo de Evento">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("TipoEvento") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label1" runat="server" Text='<%# Bind("TipoEvento") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>--%>
                        <asp:BoundField DataField="Local" HeaderText="Local" />
                        <asp:BoundField DataField="DataDescricao" HeaderText="Data" />
                        <asp:BoundField DataField="Contato" HeaderText="Descrição" />
                        <asp:BoundField DataField="PublicoPresente" HeaderText="P.Presente" DataFormatString="{0:d}" />
                        <asp:BoundField DataField="PublicoEstimado" HeaderText="P.Estimado" />
                    </Columns>
                </asp:GridView>
            </div>

        </div>

        <hr />

        <div class="form-group">
            <div class="col-lg-5 ">
                <input type="button" value="« voltar pagina" onclick="goBack()" style="display: inline-block; padding: 6px 12px; margin-bottom: 0; font-size: 14px; font-weight: normal; line-height: 1.428571429 text-align: center; white-space: nowrap; vertical-align: middle; cursor: pointer; border: 1px solid transparent; border-radius: 4px; -webkit-user-select: none; -moz-user-select: none; -ms-user-select: none; -o-user-select: none; user-select: none;" />
            </div>
        </div>

        <div>
            <b>
                <asp:Label ID="lblLogin" CssClass="text-success" runat="server" Text="OPERADOR(A): ..."></asp:Label>
            </b>
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
