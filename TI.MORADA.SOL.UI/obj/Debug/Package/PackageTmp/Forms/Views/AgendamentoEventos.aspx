<%@ Page Title="Detalhes Agenda" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AgendamentoEventos.aspx.cs" Inherits="TI.MORADA.SOL.UI.Forms.Views.AgendamentoEventos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="shadowBox">
        <div class="page-container">
            <div class="container">
                <h2>Detalhes Agenda de Eventos</h2>

                <div class="row">

                    <div class="table-responsive">
                        <asp:GridView ID="gdvNotLog" runat="server" Width="100%" CssClass="table table-striped table-bordered table-hover" DataKeyNames="Id" AutoGenerateColumns="False">
                            <Columns>
                                <asp:TemplateField HeaderText="NOME">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("NOME") %>' Width="200px"></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("NOME") %>' Width="200px"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="LOCATÁRIO">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextBox7" runat="server" Text='<%# Bind("NomeCliente") %>' Width="220px"></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="Label7" runat="server" Text='<%# Bind("NomeCliente") %>' Width="220px"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="ID" Visible="False">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("ID") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("ID") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="LOCAL">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("LOCAL") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("LOCAL") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="ID_UDUARIO" Visible="False">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("IdUsuario") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="Label4" runat="server" Text='<%# Bind("IdUsuario") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="DATA CAD.">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextBox5" runat="server" Text='<%# Bind("DataCad") %>' Width="130px"></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="Label5" runat="server" Text='<%# Bind("DataCad") %>' Width="130px"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="TITULO">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextBox6" runat="server" Text='<%# Bind("TITULO") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="Label6" runat="server" Text='<%# Bind("TITULO") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>

                            </Columns>
                        </asp:GridView>
                    </div>
                    <div>
                        <asp:Label ID="lblQtde" runat="server" Visible="False"></asp:Label>
                    </div>

                    <br />
                    <div class="form-group">
                        <div class="col-md-offset-2 col-md-10">
                            <asp:Label ID="lblResponse" runat="server" CssClass="text-danger" Text=""></asp:Label>
                        </div>
                    </div>
                </div>

                <div class="form-group">
                    <div class="col-lg-5 ">
                        <input type="button" value="« voltar pagina" onclick="goBack()" style="display: inline-block; padding: 6px 12px; margin-bottom: 0; font-size: 14px; font-weight: normal; line-height: 1.428571429 text-align: center; white-space: nowrap; vertical-align: middle; cursor: pointer; border: 1px solid transparent; border-radius: 4px; -webkit-user-select: none; -moz-user-select: none; -ms-user-select: none; -o-user-select: none; user-select: none;" />
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
