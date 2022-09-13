<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Calendario.aspx.cs" Inherits="TI.MORADA.SOL.UI.Forms.Views.Calendario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row main-low-margin text-center">
            <br />
            <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="Black" DayNameFormat="Shortest" Font-Names="Times New Roman" Font-Size="30pt" ForeColor="Black" Height="500px" NextPrevFormat="FullMonth" TitleFormat="MonthYear" Width="100%" OnSelectionChanged="Calendar1_SelectionChanged" OnDayRender="Calendar1_DayRender">
                <DayHeaderStyle BackColor="Azure" Font-Bold="True" Font-Size="20pt" ForeColor="#333333" Height="20pt" />
                <DayStyle Width="10%" />
                <NextPrevStyle Font-Size="12pt" ForeColor="White" />
                <OtherMonthDayStyle ForeColor="#999999" />
                <SelectedDayStyle BackColor="#CC3333" ForeColor="White" />
                <SelectorStyle BackColor="#CCCCCC" Font-Bold="True" Font-Names="Verdana" Font-Size="10pt" ForeColor="#333333" Width="1%" />
                <TitleStyle BackColor="Black" Font-Bold="True" Font-Size="13pt" ForeColor="White" Height="14pt" />
                <TodayDayStyle BackColor="#CCCC99" />
            </asp:Calendar>
        </div>


        <div class="form-group">
            <asp:LinkButton CssClass="btn-group" runat="server" PostBackUrl="~/Forms/LeiAcessoInformacao.aspx">Voltar</asp:LinkButton>
            &nbsp;<asp:LinkButton ID="lbAdd" runat="server" data-toggle="modal" data-target="#myModal">Agendar</asp:LinkButton>
            &nbsp;<asp:LinkButton ID="lblLista" runat="server" PostBackUrl="~/Forms/Views/Agenda.aspx">Lista</asp:LinkButton>
            &nbsp;<asp:LinkButton ID="lbPesquisar" runat="server" data-toggle="modal" data-target="#modalExemplo2">Pesquisar Data</asp:LinkButton>
        </div>

        <div class="container">

            <div id="myModal" class="modal fade" role="dialog">
                <div class="modal-dialog">
                    <!-- Modal content-->
                    <div class="modal-content">
                        <div class="modal-header">
                            <button type="button" class="close" data-dismiss="modal">&times;</button>
                            <h3 class="modal-title">Agendar Aventos</h3>
                            <h4>
                                <b>
                                    <asp:Label ID="lblData" runat="server"></asp:Label>
                                </b>
                            </h4>
                        </div>
                        <div class="modal-body">
                            <div class="form-group">
                                <label for="name">Local</label>
                                <asp:DropDownList ID="ddlLocalEvento" runat="server" class="form-control" Width="100%"></asp:DropDownList>
                            </div>

                            <div class="form-group">
                                <label for="email">Contato</label>
                                <asp:TextBox ID="txtContato" runat="server" class="form-control" Width="100%"></asp:TextBox>
                            </div>

                            <div class="form-group">
                                <label for="email">Hora</label>
                                <asp:TextBox ID="txtHora" runat="server" class="form-control" Width="100%"></asp:TextBox>
                            </div>

                            <div class="form-group">
                                <label for="name">Descrição</label>
                                <asp:TextBox ID="txtDescricao" runat="server" class="form-control" Width="100%" TextMode="MultiLine" MaxLength="7"></asp:TextBox>
                            </div>

                            <asp:Button ID="btnEnviar" runat="server" Text="Salvar" class="btn btn-lg btn-success btn-block" />

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

        </div>

        <div class="form-group">
            <div class="col-lg-5 ">
                <input type="button" value="« voltar pagina" onclick="goBack()" style="display: inline-block; padding: 6px 12px; margin-bottom: 0; font-size: 14px; font-weight: normal; line-height: 1.428571429 text-align: center; white-space: nowrap; vertical-align: middle; cursor: pointer; border: 1px solid transparent; border-radius: 4px; -webkit-user-select: none; -moz-user-select: none; -ms-user-select: none; -o-user-select: none; user-select: none;" />
            </div>
        </div>

        <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
        <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>

        <script>
            function goBack() {
                window.history.back()
            }
        </script>

    </div>
</asp:Content>
