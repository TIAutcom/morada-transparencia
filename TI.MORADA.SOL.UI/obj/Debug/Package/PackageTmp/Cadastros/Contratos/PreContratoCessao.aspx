<%@ Page Title="Pré-Contrato" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PreContratoCessao.aspx.cs" Inherits="TI.MORADA.SOL.UI.Cadastros.PreAgenda" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <div class="container">

        <div class="container">

            <h2>Relatório Pré-Contrato de Cessão</h2>

            <h3>Dados</h3>

            <div class="form-group">
                <div class="form-group">
                    <div class="col-lg-12 col-md-4 col-sm-6 portfolio-item">
                        <label for="txtContato">Tipo de Evento</label>
                        <asp:DropDownList ID="DropDownList1" runat="server" class="form-control" Width="100%"></asp:DropDownList>
                    </div>
                </div>
            </div>

            <div class="form-group">
                <div class="form-group">
                    <div class="col-lg-12 col-md-4 col-sm-6 portfolio-item">
                        <label for="txtContato">Solicitante</label>
                        <asp:TextBox ID="txtSolicitante" runat="server" class="form-control" TextMode="Search" Width="100%"></asp:TextBox>
                    </div>
                </div>
            </div>

            <div class="form-group">
                <div class="col-lg-4 col-md-4 col-sm-8 portfolio-item">
                    <div class="form-group">
                        <label for="txtContato">Telefone</label>
                        <asp:TextBox ID="txtTelefone" runat="server" class="form-control" Width="100%" TextMode="Phone" placeholder="(00)0000-0000"></asp:TextBox>
                    </div>
                </div>
            </div>

            <div class="form-group">
                <div class="col-lg-4 col-md-4 col-sm-8 portfolio-item">
                    <div class="form-group">
                        <label for="txtContato">Celular</label>
                        <asp:TextBox ID="txtCelular" runat="server" class="form-control" TextMode="Phone" Width="100%" placeholder="(00)0000-0000"></asp:TextBox>
                    </div>
                </div>
            </div>

            <div class="form-group">
                <div class="col-lg-4 col-md-4 col-sm-8 portfolio-item">
                    <div class="form-group">
                        <label for="txtContato">E-mail</label>
                        <asp:TextBox ID="txtEmail" runat="server" class="form-control" Width="100%" TextMode="Email" placeholder="Ex: @hotmail.com"></asp:TextBox>
                    </div>
                </div>
            </div>

            <hr />
            <h3>Espaços</h3>

            <div class="col-lg-4">
                <div class="container">

                    <div class="row">
                        <h4>
                            <b>
                                <input class="form-check-input" type="checkbox" id="cbxAuditorio" value="opcao1">
                                <label class="form-check-label" for="inlineCheckbox1">Auditório: </label>
                            </b>
                        </h4>
                    </div>

                    <div class="row">
                        <div class="form-group">
                            <div class="col-lg-12 col-md-4 col-sm-8 portfolio-item">
                                <div class="form-check form-check-inline">
                                    <input class="form-check-input" type="checkbox" id="cbxPacoMesa" value="opcao1">
                                    <label class="form-check-label" for="inlineCheckbox1">Palco-Mesa......:</label>
                                    <asp:TextBox ID="TextBox4" CssClass="form-check-label" placeholder="0" runat="server" Width="50%"></asp:TextBox>
                                </div>
                            </div>
                        </div>

                        <br />
                        <div class="form-group">
                            <div class="col-lg-12 col-md-4 col-sm-8 portfolio-item">
                                <div class="form-check form-check-inline">
                                    <input class="form-check-input" type="checkbox" id="cbxCadeiraAuditorio" value="opcao1">
                                    <label class="form-check-label" for="inlineCheckbox1">Cadeiras...........:</label>
                                    <asp:TextBox ID="TextBox5" CssClass="form-check-label" placeholder="0" runat="server" Width="50%"></asp:TextBox>
                                </div>
                            </div>
                        </div>

                        <br />
                        <div class="form-group">
                            <div class="col-lg-12 col-md-4 col-sm-8 portfolio-item">
                                <div class="form-check form-check-inline">
                                    <input class="form-check-input" type="checkbox" id="cbxPulpito" value="opcao1">
                                    <label class="form-check-label" for="inlineCheckbox1">Púlpito..............:</label>
                                    <asp:TextBox ID="TextBox6" CssClass="form-check-label" placeholder="0" runat="server" Width="50%"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <br />
                        <div class="form-group">
                            <div class="col-lg-12 col-md-4 col-sm-8 portfolio-item">
                                <div class="form-check form-check-inline">
                                    <input class="form-check-input" type="checkbox" id="cbxPortaBandeira" value="opcao1">
                                    <label class="form-check-label" for="inlineCheckbox1">Porta Bandeira.:</label>
                                    <asp:TextBox ID="TextBox7" CssClass="form-check-label" placeholder="0" runat="server" Width="50%"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <br />
                        <div class="form-group">
                            <div class="col-lg-12 col-md-4 col-sm-8 portfolio-item">
                                <div class="form-check form-check-inline">
                                    <input class="form-check-input" type="checkbox" id="cbxMultimidiaAud" value="opcao1">
                                    <label class="form-check-label" for="inlineCheckbox1">Multimidia.........:</label>
                                    <asp:TextBox ID="TextBox8" CssClass="form-check-label" placeholder="0" runat="server" Width="50%"></asp:TextBox>
                                </div>
                            </div>
                        </div>

                    </div>

                </div>
            </div>

            <div class="col-lg-4">
                <div class="container">

                    <div class="row">
                        <h4>
                            <b>
                                <input class="form-check-input" type="checkbox" id="cbxMultiusoFoyer" value="opcao1">
                                <label class="form-check-label" for="inlineCheckbox1">Multiuso: </label>
                            </b>
                        </h4>
                    </div>

                    <div class="row">
                        <div class="form-group">
                            <div class="col-lg-12 col-md-4 col-sm-8 portfolio-item">
                                <div class="form-check form-check-inline">
                                    <input class="form-check-input" type="checkbox" id="cbxMesUF" value="opcao1">
                                    <label class="form-check-label" for="inlineCheckbox1">Mesa.........:</label>
                                    <asp:TextBox ID="txtQtdeSova" CssClass="form-check-label" placeholder="0" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>

                        <br />
                        <div class="form-group">
                            <div class="col-lg-12 col-md-4 col-sm-8 portfolio-item">
                                <div class="form-check form-check-inline">
                                    <input class="form-check-input" type="checkbox" id="cbxMesaUF" value="opcao1">
                                    <label class="form-check-label" for="inlineCheckbox1">Cadeiras...:</label>
                                    <asp:TextBox ID="txtQtdeMesa" CssClass="form-check-label" placeholder="0" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>

                        <br />
                        <div class="form-group">
                            <div class="col-lg-12 col-md-4 col-sm-8 portfolio-item">
                                <div class="form-check form-check-inline">
                                    <input class="form-check-input" type="checkbox" id="cbxMesMU" value="opcao1">
                                    <label class="form-check-label" for="inlineCheckbox1">Água.........:</label>
                                    <asp:TextBox ID="txtQtdeAgua" CssClass="form-check-label" placeholder="0" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <br />
                        <div class="form-group">
                            <div class="col-lg-12 col-md-4 col-sm-8 portfolio-item">
                                <div class="form-check form-check-inline">
                                    <input class="form-check-input" type="checkbox" id="cbxCopoMU" value="opcao1">
                                    <label class="form-check-label" for="inlineCheckbox1">Copos.......:</label>
                                    <asp:TextBox ID="txtQtdeCopos" CssClass="form-check-label" placeholder="0" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <br />
                        <div class="form-group">
                            <div class="col-lg-12 col-md-4 col-sm-8 portfolio-item">
                                <div class="form-check form-check-inline">
                                    <input class="form-check-input" type="checkbox" id="cbxMultimidiaMU" value="opcao1">
                                    <label class="form-check-label" for="inlineCheckbox1">Multimidia.:</label>
                                    <asp:TextBox ID="txtQtdeMultimidia" CssClass="form-check-label" placeholder="0" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>

                    </div>

                </div>
            </div>

            <div class="col-lg-4">
                <div class="container">

                    <div class="row">
                        <h4>
                            <b>
                                <input class="form-check-input" type="checkbox" id="cbxFoyer" value="opcao1">
                                <label class="form-check-label" for="inlineCheckbox1">Foyer: </label>
                            </b>
                        </h4>
                    </div>

                    <div class="row">
                        <div class="form-group">
                            <div class="col-lg-12 col-md-4 col-sm-8 portfolio-item">
                                <div class="form-check form-check-inline">
                                    <input class="form-check-input" type="checkbox" id="cbxCadaeirasFoyer" value="opcao1">
                                    <label class="form-check-label" for="inlineCheckbox1">Sofas..........:</label>
                                    <asp:TextBox ID="TextBox9" CssClass="form-check-label" placeholder="0" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                    </div>

                </div>
            </div>

        </div>

        <hr />
        <div class="container">

            <div class="row">
                <h4>
                    <b>
                        <div class="form-group">
                            <div class="col-lg-4 col-md-4 col-sm-8 portfolio-item">
                                <input class="form-check-input" type="checkbox" id="cbPavilhao" value="opcao1">
                                <label class="form-check-label" for="inlineCheckbox1">Pavilhão</label>

                            </div>

                            <div class="col-lg-4 col-md-4 col-sm-8 portfolio-item">

                                <input class="form-check-input" type="checkbox" id="cbxAreaExterna" value="opcao1">
                                <label class="form-check-label" for="inlineCheckbox1">Área Externa</label>

                            </div>

                        </div>
                    </b>
                </h4>
            </div>

        </div>

        <hr />
        <h3>Datas do Eventos</h3>

        <div class="form-group">
            <div class="form-group">
                <div class="col-lg-4 col-md-4 col-sm-6 portfolio-item">
                    <label for="txtContato">Data Evento</label>
                    <asp:TextBox ID="txtDataEvento" runat="server" class="form-control" TextMode="Date" Width="100%"></asp:TextBox>
                </div>
            </div>
        </div>

        <div class="form-group">
            <div class="form-group">
                <div class="col-lg-4 col-md-4 col-sm-6 portfolio-item">
                    <label for="txtContato">Hora Inicio</label>
                    <asp:TextBox ID="TextBox11" runat="server" class="form-control" TextMode="Time" Width="100%"></asp:TextBox>
                </div>
            </div>
        </div>

        <div class="form-group">
            <div class="form-group">
                <div class="col-lg-4 col-md-4 col-sm-6 portfolio-item">
                    <label for="txtContato">Hora Fim</label>
                    <asp:TextBox ID="TextBox10" runat="server" class="form-control" TextMode="Time" Width="100%"></asp:TextBox>
                </div>
            </div>
        </div>

        <div class="form-group">
            <div class="form-group">
                <div class="col-lg-4 col-md-4 col-sm-6 portfolio-item">
                    <label for="txtContato">Data Montagem</label>
                    <asp:TextBox ID="txtDataMontagem" runat="server" class="form-control" TextMode="Date" Width="100%"></asp:TextBox>
                </div>
            </div>
        </div>

        <div class="form-group">
            <div class="form-group">
                <div class="col-lg-4 col-md-4 col-sm-6 portfolio-item">
                    <label for="txtContato">Hora Inicio</label>
                    <asp:TextBox ID="txtHoraIniMontagem" runat="server" class="form-control" TextMode="Time" Width="100%"></asp:TextBox>
                </div>
            </div>
        </div>

        <div class="form-group">
            <div class="form-group">
                <div class="col-lg-4 col-md-4 col-sm-6 portfolio-item">
                    <label for="txtContato">Hora Fim</label>
                    <asp:TextBox ID="txtDataFimMontagem" runat="server" class="form-control" TextMode="Time" Width="100%"></asp:TextBox>
                </div>
            </div>
        </div>

        <hr />

        <div class="form-group">
            <div class="col-lg-12 col-md-4 col-sm-6 portfolio-item">
                <label for="txtContato">Observações</label>
                <asp:TextBox ID="txtObs" runat="server" class="form-control" TextMode="MultiLine" Rows="5" Width="100%"></asp:TextBox>
            </div>

        </div>

        <div id="actions" class="row">
            <div class="col-md-12">
                <asp:Button ID="Sair" class="btn btn-danger" runat="server" Text="Sair" PostBackUrl="~/Index.aspx" />
                <asp:Button ID="Salvar" class="btn btn-success" runat="server" Text="Salvar" />
                <asp:Button ID="Novo" runat="server" Text="Novo" class="btn btn-warning" />
                <asp:Button ID="Button1" runat="server" Text="Lista" class="btn btn-info" data-toggle="modal" />
            </div>
        </div>

    </div>

</asp:Content>
