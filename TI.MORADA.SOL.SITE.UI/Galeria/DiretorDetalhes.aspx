<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DiretorDetalhes.aspx.cs" Inherits="TI.MORADA.SOL.SITE.UI.Galeria.DiretorDetalhes" %>

<!DOCTYPE html>
<html lang="en">

<head>

    <meta charset="utf-8">
    <link rel="icon" type="image/png" href="img/logo3.ico" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="">
    <meta name="author" content="">

    <title>Informação Pessoal Diretoria</title>

    <!-- Bootstrap core CSS -->
    <link href="../vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet">
    <link href="../css/Detalhes.css" rel="stylesheet" />
    <!-- Custom styles for this template -->
    <link href="../css/portfolio-item.css" rel="stylesheet">

    <link href="../vendor/bootstrap/css/4-col-portfolio.css" rel="stylesheet" />

    <style>
        .modalDialog {
            position: fixed;
            font-family: Arial, Helvetica, sans-serif;
            top: -75px;
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
                width: 500px;
                position: relative;
                margin: 10% auto;
                padding: 5px 20px 13px 20px;
                border-radius: 10px;
                background: #fff;
                background: -moz-linear-gradient(#fff, #999);
                background: -webkit-linear-gradient(#fff, #999);
                background: -o-linear-gradient(#fff, #999);
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

    <nav class="navbar fixed-top navbar-expand-lg navbar-dark bg-dark fixed-top">
        <div class="container">
            <a class="navbar-brand" href="#"></a>
            <a href="Diretoria.aspx">
                <asp:Image ID="Image2" runat="server" ImageUrl="http://transparencia.moradaturismoeventos.com.br/Arquivos/Imagem/Default/novaLogo.jpg" Width="100px" Height="45px" />
            </a>
        </div>
    </nav>

    <!-- Page Content -->
    <div class="container">
        <hr />
        <h2 class="h-100">Informação Pessoal</h2>

        <hr />
        <div class="row">
            <asp:PlaceHolder ID="iframe" runat="server" />
        </div>
    </div>
    <hr />
    <br />
    <footer class="py-5 bg-dark">
        <div class="container">
            <p class="m-0 text-center text-white">Copyright &copy; TI Solutions Commerce 2018</p>
        </div>
        <!-- /.container -->
    </footer>

    <!-- Bootstrap core JavaScript -->
    <script src="../vendor/jquery/jquery.min.js"></script>
    <script src="../vendor/bootstrap/js/bootstrap.bundle.min.js"></script>

</body>

</html>

