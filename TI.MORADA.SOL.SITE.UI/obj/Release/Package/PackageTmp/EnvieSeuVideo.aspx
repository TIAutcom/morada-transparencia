<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EnvieSeuVideo.aspx.cs" Inherits="TI.MORADA.SOL.SITE.UI.EnvieSeuVideo" %>

<!DOCTYPE html>
<html>

<head runat="server">
    <meta charset="utf-8">
    <link rel="icon" type="image/png" href="img/logo3.ico" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="">
    <meta name="author" content="">

    <title>Página Envie seu Video</title>

    <!-- Bootstrap core CSS -->
    <link href="../vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet">

    <!-- Custom styles for this template -->
    <link href="../css/portfolio-item.css" rel="stylesheet">
</head>
<body>
    <form id="form1" runat="server">


        <!-- Navigation -->
        <nav class="navbar navbar-expand-lg navbar-dark bg-dark fixed-top">
            <div class="container">
                <a class="navbar-brand" href="Index.aspx">Morada do Sol Turismo Eventos e Participações S/A</a>
                <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarResponsive" aria-controls="navbarResponsive" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>
                <div class="collapse navbar-collapse" id="navbarResponsive">
                    <ul class="navbar-nav ml-auto">
                        <li class="nav-item active"></li>
                    </ul>
                </div>
            </div>
        </nav>

        <div class="container">

            <div align="center">
                <h2>Página em Construção</h2>
                <asp:Image ID="Image1" runat="server" Height="200px" Width="200px" BorderStyle="Dotted" EnableTheming="False" EnableViewState="False" ImageUrl="~/Img/logo.png" />
                <h3>Breve estará no site</h3>
                <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Index.aspx">Voltar</asp:LinkButton>
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
            </div>

        </div>

        <footer class="py-5 bg-dark">
            <div class="container">
                <p class="m-0 text-center text-white">Copyright &copy; TI Solutions Commerce 2018</p>
            </div>

        </footer>

        <!-- Bootstrap core JavaScript -->
        <script src="../vendor/jquery/jquery.min.js"></script>
        <script src="../vendor/bootstrap/js/bootstrap.bundle.min.js"></script>
    </form>
</body>
</html>
