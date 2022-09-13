<%@ Page Title="Transparências" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Transparencias.aspx.cs" Inherits="TI.MORADA.SOL.UI.Forms.Views.Transparencias" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="shadowBox">
        <div class="page-container">
            <div class="container">
                <h2>Transparências</h2>
                <h3>
                    <asp:Label ID="lblTitulo" runat="server" Text="..."></asp:Label>
                </h3>

                <div class="row">

                    <div class="table-responsive">

                        <asp:GridView ID="gdvTranparencia" runat="server" Width="100%" CssClass="table table-striped table-bordered table-hover" AutoGenerateColumns="False" DataKeyNames="Id" PageSize="100" ShowHeader="False" OnRowCommand="gdvTranparencia_RowCommand">
                            <Columns>
                                <asp:BoundField DataField="Id" HeaderText="Id" Visible="False" />
                                <asp:TemplateField>
                                    <ItemStyle Width="3%" />
                                    <ItemTemplate>
                                        <asp:ImageButton ImageUrl="~/Arquivos/Imagem/Default/upload-icon.png" ID="imgbtn" runat="server" ToolTip="UpLoad da Transparência" CommandName="UpLoad" CommandArgument='<%# Eval("Id") %>' /><br />
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                            <Columns>
                                <asp:TemplateField>
                                    <ItemStyle Width="85%" />
                                    <ItemTemplate>
                                        <%--<asp:LinkButton ID="Nome" DataKeyNames="Descricao" DataField="Nome" runat="server" CommandName="Views" ToolTip="Lista de Transparências" Text='<%# Eval("Descricao") %>' CommandArgument='<%# Eval("Id") %>' OnClientClick="window.document.forms[0].target='_blank';"></asp:LinkButton>--%>
                                        <asp:LinkButton ID="Nome" DataKeyNames="Descricao" DataField="Nome" runat="server" CommandName="Views" ToolTip="Lista de Transparências" Text='<%# Eval("Descricao") %>' CommandArgument='<%# Eval("Id") %>'></asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>

                            <Columns>
                                <asp:TemplateField>
                                    <ItemStyle Width="5%" />
                                    <ItemTemplate>
                                        <asp:LinkButton ID="PDF" DataKeyNames="pdf" DataField="PDF" runat="server" ToolTip="Upload de PDF Receitas e Despesas" CommandName="UploadPDF" CommandArgument='<%# Eval("Id") %>'>PDF</asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>

                            <Columns>
                                <asp:TemplateField>
                                    <ItemStyle Width="5%" />
                                    <ItemTemplate>
                                        <asp:HyperLink ID="Delete" DataKeyNames="Delete" DataField="Delete" runat="server" NavigateUrl="~/Views/Transparencias.aspx" ToolTip="Deletar de Transparências">Delete</asp:HyperLink>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>

                            <Columns>
                                <asp:TemplateField>
                                    <ItemStyle Width="5%" />
                                    <ItemTemplate>
                                        <asp:HyperLink ID="update" DataKeyNames="update" DataField="update" runat="server" NavigateUrl="~/Views/Transparencias.aspx" ToolTip="Deletar de Transparências">Alterar</asp:HyperLink>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                    </div>

                    <div class="table-responsive">
                        <asp:GridView ID="gdvNotLog" runat="server" Width="100%" CssClass="table table-striped table-bordered table-hover" AutoGenerateColumns="False" DataKeyNames="Id" ShowHeader="False" OnRowCommand="gdvNotLog_RowCommand">
                            <Columns>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:LinkButton ID="Nomes" DataKeyNames="Descricao" CommandName="ViewTransparencias" CommandArgument='<%# Eval("Id") %>' DataField="Nomes" runat="server" Text='<%# Eval("Descricao") %>'></asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                    </div>
                    <div>
                        <asp:Label ID="lblQtde" runat="server" Visible="False"></asp:Label>
                    </div>
                    <div class="form-group">
                        <asp:Button ID="btnNovo" runat="server" Text="Nova Transparência" CssClass="btn btn-default" ToolTip="Salvar Nova Transparência" OnClick="btnNovo_Click" Visible="False" />
                    </div>

                    <div class="form-group">
                        <div class="col-lg-10 ">
                            <%--       <asp:LinkButton ID="LinkButton1" CssClass="hotpink" runat="server" OnClick="LinkButton1_Click">Voltar Página</asp:LinkButton>--%>
                            <input type="button" value="« voltar pagina" onclick="goBack()" style="display: inline-block; padding: 6px 12px; margin-bottom: 0; font-size: 14px; font-weight: normal; line-height: 1.428571429 text-align: center; white-space: nowrap; vertical-align: middle; cursor: pointer; border: 1px solid transparent; border-radius: 4px; -webkit-user-select: none; -moz-user-select: none; -ms-user-select: none; -o-user-select: none; user-select: none;" />
                        </div>
                    </div>

                    <br />
                    <div class="form-group">
                        <div class="col-md-offset-2 col-md-10">
                            <asp:Label ID="lblResponse" runat="server" CssClass="text-danger" Text=""></asp:Label>
                        </div>
                    </div>
                </div>

            </div>
        </div>

        <div class="form-group">
            <div class="col-md-10">
                <b>
                    <asp:Label ID="lblLogin" CssClass="text-success" runat="server" Text="OPERADOR(A): ..."></asp:Label>
                </b>
            </div>
        </div>

    </div>

    <script>
        function goBack() {
            window.history.back()
        }
    </script>

</asp:Content>
