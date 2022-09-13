<%@ Page Title="Fotos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Foto.aspx.cs" Inherits="TI.MORADA.SOL.ADMINISTRACAO.Views.Foto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <div class="container">

        <div class="row">
            <h3>Fotos dos Eventos</h3>
            <p>
                <asp:Literal ID="subTitutlo" runat="server"></asp:Literal>
            </p>
        </div>

        <div class="row">
            <div class="col-md-12">

                <section>
                    <asp:PlaceHolder ID="iframeObras" runat="server" />
                </section>

            </div>
        </div>

    </div>

    <script src="../Scripts/JS/dist/js/lightbox-plus-jquery.js"></script>
    <script src="../Scripts/JS/dist/js/lightbox-plus-jquery.min.js"></script>
    <script src="../Scripts/JS/dist/js/lightbox.js"></script>
    <script src="../Scripts/JS/dist/js/lightbox.min.js"></script>
    <link href="../Scripts/JS/dist/css/lightbox.css" rel="stylesheet" />
    <link href="../Scripts/JS/dist/css/lightbox.min.css" rel="stylesheet" />

</asp:Content>
