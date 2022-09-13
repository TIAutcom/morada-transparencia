<%@ Page Title="Cadastro Videos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Video.aspx.cs" Inherits="TI.MORADA.SOL.UI.Cadastros.Video" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row main-low-margin text-center">
            <div class="table-responsive">
                <h2>Cadastro de Videos</h2>
                <hr />

                <div class="form-group">
                    <div class="col-md-10">
                        <asp:TextBox ID="NomeVideo" runat="server" CssClass="form-control" Width="100%" PlaceHolder="Informe Nome do Evento"></asp:TextBox>
                        <br />
                    </div>
                    <br />

                    <div class="form-group">
                        <div class="col-md-10">
                            <asp:TextBox ID="Ifrmae" runat="server" Width="100%" Rows="7" TextMode="MultiLine" PlaceHolder="Informe URL IFrame do YouTube"></asp:TextBox>
                            <br />
                        </div>
                    </div>
                    <br />

                    <div class="form-group">
                        <div class="col-md-offset-2 col-md-10">
                            <asp:Label ID="lblResponse" runat="server" CssClass="text-danger"></asp:Label>
                            <br />
                            <br />
                        </div>
                    </div>

                    <div class="form-group">
                        <div class="col-md-6 col-sm-8">
                            <asp:Button ID="btnSalvar" CssClass="form-control" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
                            <br />
                        </div>
                    </div>
                    <br />

                    <div class="form-group">
                        <div class="col-lg-5 ">
                            <input type="button" value="« voltar pagina" onclick="goBack()" style="display: inline-block; padding: 6px 12px; margin-bottom: 0; font-size: 14px; font-weight: normal; line-height: 1.428571429 text-align: center; white-space: nowrap; vertical-align: middle; cursor: pointer; border: 1px solid transparent; border-radius: 4px; -webkit-user-select: none; -moz-user-select: none; -ms-user-select: none; -o-user-select: none; user-select: none;" />
                        </div>
                    </div>

                </div>
            </div>
        </div>

        <script>
            function goBack() {
                window.history.back()
            }
        </script>

    </div>
</asp:Content>
