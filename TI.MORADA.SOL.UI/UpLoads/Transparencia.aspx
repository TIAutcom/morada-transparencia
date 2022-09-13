<%@ Page Title="Up-Load de Arquivos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Transparencia.aspx.cs" Inherits="TI.MORADA.SOL.UI.UpLoads.Transparencia" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>UpLoad de Arquivos</h2>

    <div class="form-horizontal">
        <h4>
            <asp:Label ID="lblDescricaLai" runat="server" Text="..."></asp:Label>
        </h4>

        <div class="fluploadLink">
            <asp:HiddenField ID="hfId" runat="server" />
        </div>
        <asp:ValidationSummary runat="server" CssClass="text-danger" />
        <br />
        <asp:Label ID="lblDescricao" runat="server"></asp:Label>

        <div class="form-group">
            <div class="col-md-10">
                <asp:DropDownList ID="ddlAno" CssClass="form-control" runat="server" ControlToValidate="ddlAno" Width="100%" DataTextFormatString="Data" AutoPostBack="true" AppendDataBoundItems="true" Height="34px" TabIndex="30">
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList>
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-10">
                <asp:FileUpload ID="flUpFile" runat="server" CssClass="form-control" />
                <br />
                <asp:Button ID="btnupLoad" runat="server" CssClass="btn btn-default" Text="Salvar" OnClick="btnupLoad_Click" />
                <br />
            </div>
        </div>

        <div class="table-responsive">
            <asp:GridView ID="gdvTranparencia" runat="server" Width="100%" CssClass="table table-striped table-bordered table-hover" AutoGenerateColumns="False" EmptyDataText="Não há registros de dados para exibir." ShowHeader="False" OnRowCommand="gdvTranparencia_RowCommand">
                <Columns>
                    <asp:TemplateField>
                        <ItemStyle Width="90%" />
                        <ItemTemplate>
                            <asp:LinkButton ID="LinkButton2" runat="server" CommandName="View" Text='<%# Eval("FileName").ToString() %>' ToolTip="Dowload de Documentos" CommandArgument='<%# "~/Arquivos/Transparencias/" + Eval("FileName").ToString() %>'></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <Columns>
                    <asp:TemplateField>
                        <ItemStyle Width="5%" />
                        <ItemTemplate>
                            <asp:LinkButton ID="ImageButton2" runat="server" CommandName="Downloads" CommandArgument='<%# "~/Arquivos/Transparencias/" + Eval("FileName").ToString() %>' ImageUrl="~/Content/assets/img/Icon/view-icon.png" ToolTip="Visualização de Documentos">Baixar</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>

                <Columns>
                    <asp:TemplateField>
                        <ItemStyle Width="5%" />
                        <ItemTemplate>
                            <asp:LinkButton ID="ImageButton3" runat="server" CommandName="Deletar" CommandArgument='<%# "~/Arquivos/Transparencias/" + Eval("FileName").ToString() %>' ImageUrl="~/Content/assets/img/Icon/delete-file-icon.png" ToolTip="Deletar de Documentos">Deletar</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>

        <div class="form-group">
            <div class="col-lg-5 ">
                <input type="button" value="« voltar pagina" onclick="goBack()" style="display: inline-block; padding: 6px 12px; margin-bottom: 0; font-size: 14px; font-weight: normal; line-height: 1.428571429 text-align: center; white-space: nowrap; vertical-align: middle; cursor: pointer; border: 1px solid transparent; border-radius: 4px; -webkit-user-select: none; -moz-user-select: none; -ms-user-select: none; -o-user-select: none; user-select: none;" />
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Label ID="lblResponse" runat="server" CssClass="text-danger" Text=""></asp:Label>
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-10">
                <asp:Label ID="lblLogin" CssClass="text-success" runat="server" Text="OPERADOR(A): ..."></asp:Label>
            </div>
        </div>

        <script>
            function goBack() {
                window.history.back()
            }
        </script>

    </div>

</asp:Content>
