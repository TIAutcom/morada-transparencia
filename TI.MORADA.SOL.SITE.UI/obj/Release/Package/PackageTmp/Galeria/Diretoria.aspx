<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Diretoria.aspx.cs" Inherits="TI.MORADA.SOL.SITE.UI.Galeria.Diretoria" %>

<html lang="en">
<head runat="server">

    <meta charset="utf-8">
    <link rel="icon" type="image/png" href="img/logo3.ico" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="">
    <meta name="author" content="">

    <title>Quadro de Diretores</title>

    <style>
        .modalDialog {
            position: fixed;
            font-family: Arial, Helvetica, sans-serif;
            top: -30px;
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

    <link href="../vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <link href="../css/modern-business.css" rel="stylesheet" />

</head>
<body>

    <form id="form1" runat="server">

        <nav class="navbar fixed-top navbar-expand-lg navbar-dark bg-dark fixed-top">
            <div class="container">
                <a class="navbar-brand" href="#"></a>
                <a href="../Index.aspx#Diretoria">
                    <asp:Image ID="Image2" runat="server" ImageUrl="http://transparencia.moradaturismoeventos.com.br/Arquivos/Imagem/Default/novaLogo.jpg" Width="100px" Height="45px" />
                </a>
            </div>
        </nav>

        <!-- Page Content -->
        <div class="container">

            <!-- Page Heading -->
            <h4 class="my-4">Nossos de Diretores<small></small></h4>
            <hr />

            <div class="row">
                <asp:PlaceHolder ID="iframe" runat="server" />
            </div>
            <!-- /.row -->


        </div>
        <!-- /.container -->

        <!-- Footer -->

        <footer class="py-5 bg-dark">
            <div class="container">
                <p class="m-0 text-center text-white">Copyright &copy; TI Solutions Commerce 2018</p>
                <p class="m-0 text-center text-white"></p>
            </div>
        </footer>

        <!-- Bootstrap core JavaScript -->

        <script src="../vendor/jquery/jquery.slim.min.js"></script>
        <script src="../vendor/bootstrap/js/bootstrap.bundle.min.js"></script>
    </form>
</body>
</html>
