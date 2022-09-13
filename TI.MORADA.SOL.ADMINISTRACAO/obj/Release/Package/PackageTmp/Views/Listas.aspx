<%@ Page Title="Lista de Eventos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Listas.aspx.cs" Inherits="TI.MORADA.SOL.ADMINISTRACAO.Views.Listas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <div class="container">

        <h4>Lista de Eventos</h4>
        <div class="row">

            <div class="table-responsive">
                <asp:GridView ID="gdvAgenda" runat="server" Width="100%" CssClass="table table-striped table-bordered table-hover" DataKeyNames="Id, Descricao" EmptyDataText="Não há registros de dados para exibir." PageSize="100" AutoGenerateColumns="False" OnRowCommand="gdvAgenda_RowCommand">
                    <Columns>
                        <%--          <asp:BoundField DataField="Local" HeaderText="Local" />
                        <asp:BoundField DataField="DataDescricao" HeaderText="Data" />
                        <asp:BoundField DataField="Contato" HeaderText="Descrição" />--%>
                        <%--      <asp:BoundField DataField="PublicoPresente" HeaderText="P.Presente" DataFormatString="{0:d}" />
                        <asp:BoundField DataField="PublicoEstimado" HeaderText="P.Estimado" />--%>


                        <asp:TemplateField HeaderText="Descrição do Eventos">

                            <ItemTemplate>
                                <asp:HiddenField ID="hfId" runat="server" Value='<%# Eval("Id") %>' />
                                <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%# Container.DataItemIndex%>' CommandName="SelecioneEvento"><%# Eval("Descricao")%></asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>


                        <asp:BoundField DataField="Local" HeaderText="Local do Evento" />
                        <asp:BoundField DataField="DataEvento" HeaderText="Data Evento" DataFormatString="{0:d}" />
                        <asp:BoundField DataField="HoraEvento" HeaderText="Hora Evento" />
                        <asp:BoundField DataField="PublicoEstimado" HeaderText="P.Estimado" />
                        <asp:BoundField DataField="PublicoPresente" HeaderText="P.Presente" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Label ID="lblResponse" runat="server" CssClass="text-danger" Text="..."></asp:Label>
            </div>
        </div>

    </div>

</asp:Content>
