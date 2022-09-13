<%@ Page Language="C#" Title="Agenda de Eventos" AutoEventWireup="true" CodeBehind="Calendario.aspx.cs" Inherits="TI.MORDA.SOL.CALENDARIO.Calendario" %>

<html lang="en">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title><%: Page.Title %> - Morada Transparência</title>

    <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />

    <style>
        .modalDialog {
            position: fixed;
            font-family: Arial, Helvetica, sans-serif;
            top: -40px;
            right: 0;
            bottom: 0;
            left: 0;
            background: rgba(0,0,0,0.8);
            z-index: 99999;
            opacity: 0;
            -webkit-transition: opacity 400ms ease-in;
            -moz-transition: opacity 400ms ease-in;
            transition: opacity 400ms ease-in;
            pointer-events: none;
        }

            .modalDialog:target {
                opacity: 1;
                pointer-events: auto;
            }

            .modalDialog > div {
                width: auto;
                position: relative;
                margin: 10% auto;
                padding: 5px 20px 13px 20px;
                border-radius: 10px;
                background: #fff;
                background: -moz-linear-gradient(#fff, #999);
                background: -webkit-linear-gradient(#fff, #999);
                background: #fff;
                top: 0px;
                left: 0px;
            }

        .close {
            background: #606061;
            color: #FFFFFF;
            line-height: 25px;
            position: absolute;
            right: 15px;
            text-align: center;
            top: 10px;
            width: 24px;
            text-decoration: none;
            font-weight: bold;
            -webkit-border-radius: 12px;
            -moz-border-radius: 12px;
            border-radius: 12px;
            -moz-box-shadow: 1px 1px 3px #000;
            -webkit-box-shadow: 1px 1px 3px #000;
            box-shadow: 1px 1px 3px #000;
        }

            .close:hover {
                background: #ff0000;
            }
    </style>

</head>

<body>
    <form id="form1" runat="server">
        <div class="modalDialog"></div>
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

            <hr />
        </div>

        <a href="#openModal" class="btn-info" onclick="btnPesquisar">Pesquisar</a>

        <div id="openModal" class="modalDialog">
            <div>
                <a href="#close" title="Close" class="close">X</a>
                <h2>Dados Agenda</h2>
                <hr />
                <h5>
                    <asp:Label ID="lblData" runat="server"></asp:Label>
                </h5>
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

                        <hr />
                    </div>
                </div>

            </div>

        </div>
    </form>

</body>
</html>
