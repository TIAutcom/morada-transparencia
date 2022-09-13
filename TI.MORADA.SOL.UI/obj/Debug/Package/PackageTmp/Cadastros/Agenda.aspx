<%@ Page Title="Cadastro de Agenda de Eventos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Agenda.aspx.cs" Inherits="TI.MORADA.SOL.UI.Cadastros.Agenda" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h4>Cadastro Agenda de Eventos</h4>
    <hr />
    <div class="container">

        <div class="row main-low-margin text-center">

            <div class="form-group">
                <div class="form-group">
                    <div class="col-md-10">
                        <asp:DropDownList ID="ddlLocalEvento" CssClass="form-control" runat="server" ControlToValidate="ddlLocalEvento" Width="100%" AppendDataBoundItems="true" Height="34px" TabIndex="30">
                            <asp:ListItem Value="0">Informe Local do Evento</asp:ListItem>
                        </asp:DropDownList>
                        <br />
                    </div>
                </div>

                <div class="form-group">
                    <div class="col-md-10">
                        <asp:TextBox ID="DataIni" runat="server" class="form-control" placeHolder="Data de Inicio" ReadOnly="True" Visible="false" ToolTip="Data de Inicio do Evento"></asp:TextBox>
                        <br />
                    </div>

                    <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="Black" Font-Names="Times New Roman" Font-Size="10pt" ForeColor="Black" Height="300px" NextPrevFormat="FullMonth" Width="82%" DayNameFormat="Shortest" OnDayRender="Calendar1_DayRender" OnSelectionChanged="Calendar1_SelectionChanged">
                        <DayHeaderStyle Font-Bold="True" Font-Size="8pt" BackColor="#CCCCCC" ForeColor="#333333" Height="10pt" />
                        <DayStyle />
                        <NextPrevStyle Font-Size="8pt" ForeColor="White" />
                        <OtherMonthDayStyle ForeColor="#999999" />
                        <SelectedDayStyle BackColor="#CC3333" ForeColor="White" />
                        <SelectorStyle BackColor="#CCCCCC" Font-Bold="True" Font-Names="Verdana" Font-Size="8pt" ForeColor="#333333" Width="1%" />
                        <TitleStyle BackColor="Black" Font-Bold="True" Font-Size="13pt" ForeColor="White" Height="14pt" />
                        <TodayDayStyle BackColor="#CCCC99" />
                    </asp:Calendar>
                    <br />
                </div>
                <div class="col-md-10">
                    <asp:TextBox ID="Dias" runat="server" CssClass="form-control" Width="100%" PlaceHolder="Descrição do(s) Dia(s)" TextMode="Search"></asp:TextBox>
                    <br />
                </div>
                <br />
                <div class="col-md-10">
                    <asp:TextBox ID="Eventos" runat="server" CssClass="form-control" Width="100%" PlaceHolder="Informe Nome do Evento" TextMode="Search"></asp:TextBox>
                    <br />
                </div>
                <br />
                <div class="form-group">
                    <div class="col-md-10">
                        <asp:DropDownList ID="DropDownList1" CssClass="form-control" runat="server" ControlToValidate="ddlLocal" Width="100%" AppendDataBoundItems="true" Height="34px" TabIndex="30">
                            <asp:ListItem Value="0">Autorização para Postagem no Site</asp:ListItem>
                            <asp:ListItem Value="1">Autorizado</asp:ListItem>
                            <asp:ListItem Value="2">Não Autorizado</asp:ListItem>
                        </asp:DropDownList>
                        <br />
                    </div>
                </div>
                <br />

                <div class="col-md-10">
                    <asp:FileUpload ID="fupImagem" runat="server" AllowMultiple="true" />
                    <br />
                </div>
                <br />

                <div class="col-md-10">
                    <asp:TextBox ID="Contato" runat="server" CssClass="form-control" Width="100%" PlaceHolder="Descrição Contato do Evento" TextMode="MultiLine" Rows="3"></asp:TextBox>
                    <br />
                </div>

                <div class="col-md-10">
                    <asp:TextBox ID="SiteContato" runat="server" CssClass="form-control" Width="100%" PlaceHolder="Site de Contato" TextMode="Search"></asp:TextBox>
                    <br />
                </div>

                <div class="col-md-10">
                    <asp:TextBox ID="PubEstimado" runat="server" CssClass="form-control" Width="100%" PlaceHolder="Publico Estimado"></asp:TextBox>
                    <br />
                </div>
                <br />
                <div class="col-md-10">
                    <asp:TextBox ID="PubPresente" runat="server" CssClass="form-control" Width="100%" PlaceHolder="Publico Presente"></asp:TextBox>
                    <br />
                </div>

                <div class="col-md-10">
                    <asp:TextBox ID="Observacao" runat="server" CssClass="form-control" Width="100%" PlaceHolder="Observação" Rows="3" TextMode="MultiLine"></asp:TextBox>
                    <br />
                </div>
                <br />


                <div class="form-group">
                    <div class="col-md-offset-2 col-md-10">
                        <asp:Label ID="lblResponse" runat="server" CssClass="text-danger"></asp:Label>
                    </div>
                </div>

                <div class="form-group">

                    <div class="col-md-3 col-sm-8">
                        <asp:Button ID="btnSalvar" CssClass="form-control" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
                        <br />
                    </div>

                    <div class="col-md-3 col-sm-8">
                        <asp:Button ID="Limpar" CssClass="form-control" runat="server" Text="Limpar" />
                        <br />
                    </div>


                </div>

                <div class="form-group">
                    <div class="col-lg-2 ">
                        <%--       <asp:LinkButton ID="LinkButton1" CssClass="hotpink" runat="server" OnClick="LinkButton1_Click">Voltar Página</asp:LinkButton>--%>
                        <input type="button" value="« voltar pagina" onclick="goBack()" style="display: inline-block; padding: 6px 12px; margin-bottom: 0; font-size: 14px; font-weight: normal; line-height: 1.428571429 text-align: center; white-space: nowrap; vertical-align: middle; cursor: pointer; border: 1px solid transparent; border-radius: 4px; -webkit-user-select: none; -moz-user-select: none; -ms-user-select: none; -o-user-select: none; user-select: none;" />
                    </div>
                </div>

            </div>
        </div>
        <hr />
        <div class="form-group">
            <div class="col-md-offset-0 col-md-4">
                <b>
                    <asp:Label ID="lblLogin" CssClass="text-success" runat="server" Text="OP: ..."></asp:Label>
                </b>
            </div>
        </div>



        <div class="space-bottom"></div>
    </div>

    <script>
        function goBack() {
            window.history.back()
        }
    </script>

</asp:Content>
