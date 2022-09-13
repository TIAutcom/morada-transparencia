<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Detalhes.aspx.cs" Inherits="TI.MORADA.SOL.SITE.UI.Galeria.Detalhes" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8">
    <link rel="icon" type="image/png" href="img/logo3.ico" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="">
    <meta name="author" content="">
    <title>Detalhes da Agenda</title>
    <!-- Bootstrap core CSS -->
    <link href="../vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet">
    <!-- Custom styles for this template -->
    <%--  <link href="../css/shop-homepage.css" rel="stylesheet">--%>
    <link href="../css/Detalhes.css" rel="stylesheet" />
    <link rel="stylesheet" href="http://code.jquery.com/ui/1.10.3/themes/smoothness/jquery-ui.css" />
    <script src="http://code.jquery.com/jquery-1.8.2.js"></script>
    <script src="http://code.jquery.com/ui/1.10.3/jquery-ui.js"></script>
</head>
<body>

    <!-- Navigation -->
    <nav class="navbar navbar-expand-lg navbar-dark bg-dark fixed-top">
        <div class="container">
            <a class="navbar-brand" href="#"></a>
            <a href="../Index.aspx">
                <asp:Image ID="Image2" runat="server" ImageUrl="http://transparencia.moradaturismoeventos.com.br/Arquivos/Imagem/Default/novaLogo.jpg" Width="100px" Height="45px" />
            </a>
        </div>
    </nav>
    <asp:Image ID="Image1" runat="server" />

    <div class="container1">
        <div class="body1">
            <br />
            <asp:PlaceHolder ID="iframe" runat="server" />
        </div>
    </div>

    <footer class="py-5 bg-dark">
        <div class="alert-dismissible">
            <p class="m-0 text-center text-white">Copyright &copy; TI Solutions Commerce 2018</p>
            <p class="m-0 text-center text-white"></p>
        </div>
    </footer>

    <!-- Bootstrap core JavaScript -->
    <script src="../vendor/jquery/jquery.min.js"></script>
    <script src="../vendor/bootstrap/js/bootstrap.bundle.min.js"></script>
</body>
</html>


