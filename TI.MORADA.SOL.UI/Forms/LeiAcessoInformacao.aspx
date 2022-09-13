<%@ Page Title="L.A.I" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LeiAcessoInformacao.aspx.cs" Inherits="TI.MORADA.SOL.UI.Forms.LeiAcessoInformacao" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="shadowBox">
        <div class="page-container">
            <div class="container">
          
                <h3>LAI - Lei de Acesso à Informação</h3>
                <hr />
                <div class="row">

                    <div class="col-lg-10 ">
                        <div class="table-responsive">
                            <asp:GridView ID="gdvTransparencia" runat="server" Width="100%" CssClass="table table-striped table-bordered table-hover" AutoGenerateColumns="False" EmptyDataText="Não há registros de dados para exibir." ShowHeader="False" EnableModelValidation="False" OnRowCommand="gdvTransparencia_RowCommand">

                                <Columns>
                                    <asp:TemplateField HeaderText="Id" Visible="False">
                                        <ItemStyle Width="90%" />
                                        <EditItemTemplate>
                                            <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("Id") %>'></asp:TextBox>
                                        </EditItemTemplate>
                                        <ItemTemplate>
                                            <asp:Label ID="Label1" runat="server" Text='<%# Bind("Id") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <%-- <asp:TemplateField HeaderText="Descrição">--%>
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:HiddenField ID="hfId" runat="server" Value='<%# Eval("Id") %>' />
                                            <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%# Eval("Id") %>' CommandName="SelecioneTranspar"><%# Eval("Descricao")%></asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                        </div>
                    </div>

                    <div class="col-lg-10 ">
                        <div class="table-responsive">
                            <asp:GridView ID="gdvLaiLog" runat="server" Width="100%" CssClass="table table-striped table-bordered table-hover" AutoGenerateColumns="False" EmptyDataText="Não há registros de dados para exibir." ShowHeader="False" EnableModelValidation="False" OnRowCommand="gdvLaiLog_RowCommand" OnRowDataBound="gdvLaiLog_RowDataBound">
                                <Columns>

                                    <asp:TemplateField>
                                        <ItemStyle Width="90%" />
                                        <ItemTemplate>
                                            <asp:HiddenField ID="hfId" runat="server" Value='<%# Eval("Id") %>' />
                                            <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%# Eval("Id") %>' CommandName="SelecioneTranspar"><%# Eval("Descricao")%></asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>

                                    <asp:TemplateField>
                                        <ItemStyle Width="5%" />
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lklDele" runat="server" CommandArgument='<%# Eval("Id") %>' CommandName="Deletar">Delete</asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>

                                    <asp:TemplateField>
                                        <ItemStyle Width="5%" />
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lklUpdate" runat="server" CommandArgument='<%# Eval("Id") %>' CommandName="Deletar">Alterar</asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>

                                </Columns>
                            </asp:GridView>
                        </div>
                    </div>

                    <%--            <div class="col-md-10">
                        <p>
                            <asp:Button ID="btnSair" runat="server" Text="Sair" Width="100px" class="btn btn-default" />
                        </p>
                    </div>--%>

                    <div class="form-group">
                        <div class="col-md-offset-2 col-md-10">
                            <asp:Label ID="lblResponse" runat="server" CssClass="text-danger" Text=""></asp:Label>
                        </div>
                    </div>

                    <div class="col-lg-10 ">
                        <b>
                            <asp:Label ID="lblLogin" CssClass="text-success" runat="server" Text="OPERADOR(A): ..."></asp:Label>
                        </b>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
