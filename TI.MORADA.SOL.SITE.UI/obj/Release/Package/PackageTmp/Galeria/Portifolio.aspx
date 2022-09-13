<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Portifolio.aspx.cs" Inherits="TI.MORADA.SOL.SITE.UI.Galeria.Portifolio" %>

<!DOCTYPE html>
<html>
<head>
    <%-- 30--%>
    <meta charset="utf-8">
    <link rel="icon" type="image/png" href="img/logo3.ico" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <title>Fotos Galeria do CEAR</title>

    <link rel="stylesheet" href="/bootstrap-3.3.7-dist/css/bootstrap.min.css">
    <link href="https://fonts.googleapis.com/css?family=Droid+Sans:400,700" rel="stylesheet">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/baguettebox.js/1.8.1/baguetteBox.min.css">
    <link rel="stylesheet" href="Forms/gallery-grid.css">
    <link href="gallery-grid.css" rel="stylesheet" />

</head>
<body>

    <div class="container">

        <div class="container gallery-container">
            <div class="card text-center">
                <div class="card-header">
                    <ul class="nav nav-pills card-header-pills">
                        <li class="nav-item">


                            <a class="nav-link active" href="javascript:window.history.go(-1)">Home</a>
                        </li>
                        <%--      <li class="nav-item">
                            <a class="nav-link" href="../Galeria/Portifolio.aspx?IdTipo=1&Galeria=Obras">Obras</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link disabled" href="../Galeria/Portifolio.aspx?IdTipo=2&Galeria=Eventos">Eventos</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link disabled" href="Agenda.aspx">Agenda</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link disabled" href="Diretoria.aspx">Diretoria</a>
                        </li>--%>
                    </ul>

                    <div class="tz-gallery">

                        <%-- <h2>Galeria de Fotos</h2>--%>
                        <h2>
                            <asp:Label ID="lblGaleria" runat="server"></asp:Label>
                        </h2>

                        <div class="row">
                            <div id="root">
                                <asp:PlaceHolder ID="iframeObras" runat="server" />
                            </div>
                        </div>

                        <hr />

                        <div class="row">
                            <div id="root">
                                <p>
                                    <asp:Label ID="lblQtdeRegistro" runat="server" Text="..."></asp:Label>
                                </p>
                            </div>
                        </div>

                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="#">Voltar ao Inicio da Pagina</asp:HyperLink>
                    </div>
                </div>

            </div>
        </div>
    </div>

    <script src="https://cdnjs.cloudflare.com/ajax/libs/baguettebox.js/1.8.1/baguetteBox.min.js"></script>
    <script>
        baguetteBox.run('.tz-gallery');
    </script>
</body>
</html>

