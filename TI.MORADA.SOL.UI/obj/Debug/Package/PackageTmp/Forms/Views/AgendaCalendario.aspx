<%@ Page Title="Calendário" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AgendaCalendario.aspx.cs" Inherits="TI.MORADA.SOL.UI.Forms.Views.AgendaCalendario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <br />
        <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="Black" DayNameFormat="Shortest" Font-Names="Times New Roman" Font-Size="30pt" ForeColor="Black" Height="500px" NextPrevFormat="FullMonth" TitleFormat="MonthYear" Width="100%" OnDayRender="Calendar1_DayRender" OnSelectionChanged="Calendar1_SelectionChanged">
            <DayHeaderStyle BackColor="Azure" Font-Bold="True" Font-Size="20pt" ForeColor="#333333" Height="20pt" />
            <DayStyle Width="10%" />
            <NextPrevStyle Font-Size="12pt" ForeColor="White" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <SelectedDayStyle BackColor="#CC3333" ForeColor="White" />
            <SelectorStyle BackColor="#CCCCCC" Font-Bold="True" Font-Names="Verdana" Font-Size="10pt" ForeColor="#333333" Width="1%" />
            <TitleStyle BackColor="Black" Font-Bold="True" Font-Size="13pt" ForeColor="White" Height="14pt" />
            <TodayDayStyle BackColor="#CCCC99" />
        </asp:Calendar>

        <asp:Button ID="btnSalvar" CssClass="btn-default" runat="server" Text="Pesquisar" data-toggle="modal" data-target="#modalExemplo2" />
        &nbsp;<asp:Button ID="btnPesquisar" CssClass="btn-info" runat="server" Text="Salvar" data-toggle="modal" data-target="#myModal" OnClick="btnPesquisar_Click" />

        <br />

    </div>

    <div class="table table-responsive">

        <%--MODAL CADASTRO DE EVENTO--%>
        <div id="myModal" class="modal fade" role="dialog">
            <div class="modal-dialog">
                <!-- Modal content-->
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal">&times;</button>
                        <h3 class="modal-title">Pré-Agenda do Aventos</h3>
                        <h4>
                            <b>
                                <asp:Label ID="lblData" runat="server"></asp:Label>
                            </b>
                        </h4>
                    </div>
                    <div class="modal-body">

                        <div class="form-group">
                            <label for="ddlLocalEventos">Local</label>
                            <asp:DropDownList ID="ddlLocalEventos" runat="server" class="form-control" Width="100%" AutoPostBack="false"></asp:DropDownList>
                        </div>

                        <div class="form-group">
                            <label for="txtContato">Contato</label>
                            <asp:TextBox ID="txtContato" runat="server" class="form-control" Width="100%"></asp:TextBox>
                        </div>

                        <div class="form-group">
                            <label for="email">Hora Inicio</label>
                            <asp:TextBox ID="txtHora" runat="server" class="form-control" Width="100%" TextMode="Time"></asp:TextBox>
                        </div>

                        <div class="form-group">
                            <label for="HoraFim">Hora Fim</label>
                            <asp:TextBox ID="HoraFim" runat="server" class="form-control" Width="100%" TextMode="Time"></asp:TextBox>
                        </div>

                        <div class="form-group">
                            <label for="name">Descrição</label>
                            <asp:TextBox ID="txtDescricao" runat="server" class="form-control" Width="100%" TextMode="MultiLine" MaxLength="7"></asp:TextBox>
                        </div>

                        <asp:Button ID="btnEnviar" runat="server" Text="Salvar" class="btn btn-lg btn-success btn-block" OnClick="btnEnviar_Click" />

                        <div id="success_message" style="width: 100%; height: 100%; display: none;">
                            <h3>Sent your message successfully!</h3>
                        </div>
                        <div id="error_message" style="width: 100%; height: 100%; display: none;">
                            <h3>Error</h3>
                            Sorry there was an error sending your form.
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <%--MODAL PESQUISAS--%>
        <div class="modal fade" id="modalExemplo2" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
            <div class="modal-dialog" role="document">
                <div class="modal-content">
                    <div class="modal-header">
                        <h5 class="modal-title" id="exampleModalLabel">Dados de Agendamento</h5>
                        <button type="button" class="close" data-dismiss="modal" aria-label="Fechar">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>
                    <div class="modal-body">
                        <div class="table-responsive">
                            <asp:GridView runat="server" CssClass="table table-striped" ID="gdvEventos" EmptyDataText="Não há registros de Agenda de Programação para exibir." AutoGenerateColumns="False" DataKeyNames="ImageId" CellPadding="3" HeaderStyle-BackColor="Tomato" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" GridLines="Horizontal" Width="100%" ShowHeader="False" ClientIDMode="Static" HorizontalAlign="Justify">
                                <AlternatingRowStyle BackColor="#F7F7F7" />

                                <Columns>
                                    <asp:BoundField HeaderText="IdAgenda" DataField="Id" Visible="False" />
                                    <asp:BoundField DataField="Descricao" HeaderText="Descricao" />
                                    <asp:BoundField DataField="Local" HeaderText="Local" />
                                    <asp:BoundField DataField="DataCad" HeaderText="DataCad" Visible="False" />
                                    <asp:BoundField DataField="IdUsuario" HeaderText="IdUsuario" Visible="False" />
                                    <asp:BoundField DataField="IdTipoImovel" HeaderText="IdTipoImovel" Visible="False" />
                                    <asp:BoundField DataField="DataDescricao" HeaderText="DataDescricao" />
                                    <asp:BoundField DataField="Postagem" HeaderText="Postagem" Visible="False" />
                                    <asp:BoundField DataField="Contato" HeaderText="Contato" />
                                    <asp:BoundField DataField="DataIni" HeaderText="DataIni" Visible="False" />
                                </Columns>

                                <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />

                                <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7"></HeaderStyle>
                                <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                                <RowStyle Wrap="True" BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                                <SortedAscendingCellStyle BackColor="#F4F4FD" />
                                <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
                                <SortedDescendingCellStyle BackColor="#D8D8F0" />
                                <SortedDescendingHeaderStyle BackColor="#3E3277" />
                            </asp:GridView>
                            <br />
                            <br />
                        </div>
                    </div>

                    <div class="modal-footer">
                        <button type="button" class="btn btn-secondary" data-dismiss="modal">Fechar</button>
                    </div>
                    <div class="form-group">
                        <div class="col-lg-5 ">
                            <input type="button" value="« voltar pagina" onclick="goBack()" style="display: inline-block; padding: 6px 12px; margin-bottom: 0; font-size: 14px; font-weight: normal; line-height: 1.428571429 text-align: center; white-space: nowrap; vertical-align: middle; cursor: pointer; border: 1px solid transparent; border-radius: 4px; -webkit-user-select: none; -moz-user-select: none; -ms-user-select: none; -o-user-select: none; user-select: none;" />
                        </div>
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

</asp:Content>
