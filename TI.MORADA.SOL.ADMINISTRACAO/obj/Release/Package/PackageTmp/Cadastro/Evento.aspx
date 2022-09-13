<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Evento.aspx.cs" Inherits="TI.MORADA.SOL.ADMINISTRACAO.Cadastro.Evento" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">



    <div class="container">

        <h4>Agenda de Eventos</h4>

        <div class="row main-low-margin text-center">

            <div class="col-md-10">

                <div class="form-group">
                    <div class="form-group">
                        <div class="col-md-10">
                            <asp:DropDownList ID="ddlLocalEvento" CssClass="form-control" runat="server" Width="100%" AppendDataBoundItems="true" Height="34px" TabIndex="30">
                                <asp:ListItem Value="0">Informe Local do Evento</asp:ListItem>
                            </asp:DropDownList>
                            <br />
                        </div>
                    </div>

                    <div class="form-group">
                        <div class="col-md-10">
                            <asp:DropDownList ID="ddlTipoEvento" CssClass="form-control" runat="server" ControlToValidate="ddlTipoEvento" Width="100%" AppendDataBoundItems="true" Height="34px" TabIndex="30">
                                <asp:ListItem Value="0">Informe Tipo do Evento</asp:ListItem>
                            </asp:DropDownList>
                            <br />
                        </div>
                    </div>

                    <div class="form-group">

                        <div class="col-md-5">
                            <asp:TextBox ID="Data" runat="server" class="form-control" placeHolder="Data" TextMode="Date" ToolTip="Data do Evento" Width="100%"></asp:TextBox>
                            <br />
                        </div>

                    </div>

                    <div class="form-group">

                        <div class="col-md-5">
                            <asp:TextBox ID="Hora" runat="server" class="form-control" placeHolder="Hora" TextMode="Time" ToolTip="Hora do Evento" Width="100%"></asp:TextBox>
                            <br />
                        </div>

                    </div>


                    <div class="col-md-10">
                        <asp:TextBox ID="Descricao" runat="server" CssClass="form-control" Width="100%" PlaceHolder="Descrição do Evento" TextMode="Search"></asp:TextBox>
                        <br />
                    </div>
                    <br />


                    <div class="form-group">

                        <div class="col-md-6">
                            <asp:TextBox ID="PubEstimado" runat="server" CssClass="form-control" Width="100%" PlaceHolder="Publico Estimado"></asp:TextBox>
                        </div>
                        <br />
                        <div class="col-md-6">
                            <asp:TextBox ID="PubPresente" runat="server" CssClass="form-control" Width="100%" PlaceHolder="Publico Presente"></asp:TextBox>
                            <br />
                        </div>
                    </div>

                    <div class="form-group">
                        <div class="col-md-3">
                            <asp:TextBox ID="PercFamilia" runat="server" CssClass="form-control" Width="100%" PlaceHolder="% Publico Familia"></asp:TextBox>
                            <br />
                        </div>

                        <div class="col-md-3">
                            <asp:TextBox ID="PercCasal" runat="server" CssClass="form-control" Width="100%" PlaceHolder="% Publico Casal"></asp:TextBox>
                            <br />
                        </div>

                        <div class="col-md-3">
                            <asp:TextBox ID="PercJovem" runat="server" CssClass="form-control" Width="100%" PlaceHolder="% Publico Jovem"></asp:TextBox>
                            <br />
                        </div>

                    </div>
                    <div class="col-md-5">
                        <asp:TextBox ID="PublicoCidade" runat="server" CssClass="form-control" Width="100%" PlaceHolder="Publico Araraquara"></asp:TextBox>
                    </div>
                    <br />
                    <div class="col-md-5">
                        <asp:TextBox ID="PublicoRegiao" runat="server" CssClass="form-control" Width="100%" PlaceHolder="Publico Região"></asp:TextBox>
                        <br />
                    </div>

                    <div class="col-md-10">
                        <asp:TextBox ID="Observacao" runat="server" CssClass="form-control" Width="100%" PlaceHolder="Observação" Rows="3" TextMode="MultiLine"></asp:TextBox>
                        <br />
                    </div>

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

                    </div>
                </div>

            </div>

        </div>
        <hr />
    </div>


</asp:Content>
