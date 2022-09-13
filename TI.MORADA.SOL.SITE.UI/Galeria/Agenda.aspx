<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Agenda.aspx.cs" Inherits="TI.MORADA.SOL.SITE.UI.Galeria.Agenda" %>

<!DOCTYPE html>

<html lang="en">
<head runat="server">

    <meta charset="utf-8">
    <link rel="icon" type="image/png" href="img/logo3.ico" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="">
    <meta name="author" content="">

    <title>Agenda de Eventos e Programação</title>

    <link rel="stylesheet" href="http://code.jquery.com/ui/1.10.3/themes/smoothness/jquery-ui.css" />
    <script src="http://code.jquery.com/jquery-1.8.2.js"></script>
    <script src="http://code.jquery.com/ui/1.10.3/jquery-ui.js"></script>

    <!-- Bootstrap core CSS -->
    <link href="../vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <!-- Custom styles for this template -->

    <link href="../vendor/bootstrap/css/4-col-portfolio.css" rel="stylesheet" />

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
    <form id="form1" runat="server">

        <!-- Navigation -->
        <nav class="navbar navbar-expand-lg navbar-dark bg-dark fixed-top">
            <div class="container">
                <a class="navbar-brand" href="#"></a>
                <a href="../Index.aspx#Portifolios">
                    <asp:Image ID="Image2" runat="server" ImageUrl="http://transparencia.moradaturismoeventos.com.br/Arquivos/Imagem/Default/novaLogo.jpg" Width="100px" Height="45px" />
                </a>
            </div>
        </nav>

        <!-- Page Content -->
        <div class="container">

            <!-- Page Heading -->
            <h4 class="my-4">Agenda de Eventos e Programações<small></small></h4>
            <hr />
            <div class="row">

                <div class="col-lg-4 col-md-4 col-sm-6 portfolio-item">
                    <asp:DropDownList ID="ddlAno" runat="server" Width="100%" CssClass="form-control" AutoPostBack="true" OnSelectedIndexChanged="ddlAno_SelectedIndexChanged">
                        <asp:ListItem>2022</asp:ListItem>
                        <asp:ListItem>2021</asp:ListItem>
                        <asp:ListItem>2020</asp:ListItem>
                        <asp:ListItem>2019</asp:ListItem>
                        <asp:ListItem>2018</asp:ListItem>
                    </asp:DropDownList>
                </div>

                <div class="col-lg-4 col-md-4 col-sm-6 portfolio-item">
                    <asp:DropDownList ID="ddlMes" runat="server" Width="100%" CssClass="form-control" AutoPostBack="true" OnSelectedIndexChanged="ddlMes_SelectedIndexChanged">
                    </asp:DropDownList>
                </div>
            </div>

            <div class="row">
                <asp:PlaceHolder ID="iframeAgenda" runat="server" />
            </div>

            <div class="row">
                <asp:PlaceHolder ID="iframeModal" runat="server" />
            </div>

            <hr />

            <div align="center">
                <div id="root">
                    <p>
                        <asp:Label ID="lblQtdeRegistro" runat="server" Text="..."></asp:Label>
                    </p>

                </div>
                <div class="row">
                    <span id='topo'></span>
                    <a href="#">Voltar Incio da Página</a>
                </div>
            </div>
        </div>
        <!-- /.container -->

        <!-- Footer -->
        <footer class="py-5 bg-dark">
            <div class="container">
                <p class="m-0 text-center text-white">Copyright &copy; TI Solutions Commerce 2019</p>
            </div>
            <!-- /.container -->
        </footer>

        <!-- Bootstrap core JavaScript -->

        <script src="../vendor/jquery/jquery.slim.min.js"></script>
        <script src="../vendor/bootstrap/js/bootstrap.bundle.min.js"></script>

        <%-- MODAL AGENDA--%>
        <div class="container">

            <!-- The Modal -->
            <div class="modal fade" id="myModalAgenda">
                <div class="modal-dialog modal-lg">
                    <div class="modal-content">

                        <!-- Modal Header -->
                        <div class="modal-header">
                            <h4 class="modal-title">Quem Somos:</h4>
                            <button type="button" class="close" data-dismiss="modal">&times;</button>
                        </div>

                        <!-- Modal body -->
                        <div class="modal-body">
                            <div class="row">

                                <div class="col-lg-4 col-md-4 mb-8">
                                    <div class="card h-140">
                                        <a href="#">
                                            <img class="card-img-top" src="http://placehold.it/700x400" alt=""></a>
                                        <div class="card-body">
                                            <h4 class="card-title">
                                                <a href="#">Item One</a>
                                            </h4>
                                            <h5>$24.99</h5>
                                            <p class="card-text">Lorem ipsum dolor sit amet, consectetur adipisicing elit. Amet numquam aspernatur!</p>
                                        </div>
                                        <div class="card-footer">
                                            <small class="text-muted">&#9733; &#9733; &#9733; &#9733; &#9734;</small>
                                        </div>
                                    </div>
                                </div>

                            </div>
                        </div>

                        <!-- Modal footer -->
                        <div class="modal-footer">
                            <button type="button" class="btn btn-secondary" data-dismiss="modal">Fechar</button>
                        </div>

                    </div>
                </div>
            </div>

        </div>

        <div class="container">

            <div class="row">

                <div class="col-lg-9">
                    <div id="carouselExampleIndicators" class="carousel slide my-4" data-ride="carousel">
                    </div>
                    <div class="container">
                        <div class="row">
                            <asp:PlaceHolder ID="iframe" runat="server" />
                        </div>
                    </div>

                    <br>
                </div>
            </div>

        </div>

    </form>
</body>
</html>
