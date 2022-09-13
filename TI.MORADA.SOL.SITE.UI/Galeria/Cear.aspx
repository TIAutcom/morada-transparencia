<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cear.aspx.cs" Inherits="TI.MORADA.SOL.SITE.UI.Galeria.Cear" %>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <meta charset="utf-8">

    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="">
    <meta name="author" content="">

    <title>Centro Internacional de Convenção Dr. Nelson Barbieri de Araraquara</title>
    <link rel="icon" type="image/png" href="Img/logo3.ico" />
    <link href="../vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <link href="../css/shop-homepage.css" rel="stylesheet" />

</head>
<body>
    <br />
    <form id="form1" runat="server">

        <!-- Navigation -->
        <nav class="navbar fixed-top navbar-expand-lg navbar-dark bg-dark fixed-top">
            <div class="container">
                <a class="navbar-brand" href="#"></a>
                <a href="../Index.aspx#ComplexoCear">
                    <asp:Image ID="Image2" runat="server" ImageUrl="http://transparencia.moradaturismoeventos.com.br/Arquivos/Imagem/Default/novaLogo.jpg" Width="100px" Height="45px" />
                </a>
            </div>
        </nav>

        <div class="container">
            <h4 class="h-4">Centro Internacional de Convenção de Araraquara Dr. Nelson Barbieri</h4>
            <div class="row">

                <div id="carouselExampleIndicators" class="carousel slide my-4" data-ride="carousel">
                    <ol class="carousel-indicators">
                        <li data-target="#carouselExampleIndicators" data-slide-to="0" class="active"></li>
                        <li data-target="#carouselExampleIndicators" data-slide-to="1"></li>
                        <li data-target="#carouselExampleIndicators" data-slide-to="2"></li>
                        <%--          <li data-target="#carouselExampleIndicators" data-slide-to="3"></li>--%>
                    </ol>

                    <div class="carousel-inner" role="listbox">
                        <div class="carousel-item active">
                            <img class="d-block img-fluid" src="http://transparencia.moradaturismoeventos.com.br/Arquivos/Imagem/Default/cear2.jpg" alt="First slide">
                        </div>
                        <div class="carousel-item">
                            <img class="d-block img-fluid" src="http://transparencia.moradaturismoeventos.com.br/Arquivos/Imagem/CEAR/15.jpg" alt="Second slide">
                        </div>
                        <div class="carousel-item">
                            <img class="d-block img-fluid" src="http://transparencia.moradaturismoeventos.com.br/Arquivos/Imagem/Default/3.jpg" alt="Third slide">
                        </div>
                        <%--   <div class="carousel-item">
                            <img class="d-block img-fluid" src="http://transparencia.moradaturismoeventos.com.br/Arquivos/Imagem/CEAR/Sala1.jpg" alt="Third slide">
                        </div>--%>
                    </div>
                    <a class="carousel-control-prev" href="#carouselExampleIndicators" role="button" data-slide="prev">
                        <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                        <span class="sr-only">Previous</span>
                    </a>
                    <a class="carousel-control-next" href="#carouselExampleIndicators" role="button" data-slide="next">
                        <span class="carousel-control-next-icon" aria-hidden="true"></span>
                        <span class="sr-only">Next</span>
                    </a>
                </div>
            </div>

            <hr />

            <div class="row">

                <div class="col-lg-4 col-md-4 mb-8">
                    <div class="card h-100">
                        <a href="Portifolio.aspx?IdTipo=5&Galeria=Foyer">
                            <img class="card-img-top" src="http://transparencia.moradaturismoeventos.com.br/Arquivos/Imagem/CEAR/foyer.jpg" alt=""></a>
                        <div class="card-body">
                            <h4 class="card-title">
                                <a href="Portifolio.aspx?IdTipo=5&Galeria=Foyer" class="btn btn-primary">Centro de Convenção -&nbsp; Foyer</a>
                            </h4>
                            <p class="card-text">Localizado no CEAR/Centro de Convenção, o Foyer conta com capacidade para 503 pessoas. Com espaço de 505 m², é ideal para recepções, coquetéis, exposições, feiras, etc.</p>
                            <%--                            <p class="card-text">Localizado no CEAR/Centro de Convenção, o Foyer conta com capacidade para 500 pessoas,<strong> Em virtude da Pandemia pela COVID-19 e atendendo ao protocolo sanitário do município, o espaço Foyer de 500 passará para 75 lugares</strong> . Com espaço de 505 m², é ideal para recepções, coquetéis, exposições, feiras, etc.</p>--%>
                        </div>
                        <div class="card-footer">
                            <a href="http://transparencia.moradaturismoeventos.com.br/Arquivos/PDFs/Plantas/CEAR-Centro-Convencao-Completo.pdf" target="_blank">Download Planta</a>
                        </div>
                    </div>
                </div>

                <div class="col-lg-4 col-md-6 mb-4">
                    <div class="card h-100">
                        <a href="Portifolio.aspx?IdTipo=4&Galeria=Auditório">
                            <%--  <img class="card-img-top" src="http://placehold.it/700x400" alt=""></a>--%>
                            <img class="card-img-top" src="http://transparencia.moradaturismoeventos.com.br/Arquivos/Imagem/CEAR/auditorio.jpg" alt=""></a>
                        <div class="card-body">
                            <h4 class="card-title">
                                <a href="Portifolio.aspx?IdTipo=4&Galeria=Auditório" class="btn btn-primary">Centro de Convenção  -&nbsp; Auditório</a>
                            </h4>
                            <%--  <h5>$24.99</h5>--%>
                            <p class="card-text">Localizado no CEAR/Centro de Convenção, o Auditório com espaço de 840 m², tem capacidade para até 970 pessoas sentadas, e é perfeito para Congressos, Formaturas, Apresentações Artisticas Culturais, Stand-Ups, etc. </p>
                            <%--                           <p class="card-text">Localizado no CEAR/Centro de Convenção, o Auditório com espaço de 840 m², tem capacidade para até 970 pessoas sentadas. <strong>Em virtude da Pandemia pela COVID-19 e atendendo ao protocolo sanitário do município, o espaço Auditório de 950 passará para 237 lugares, </strong> e é perfeito para Congressos, Formaturas, Apresentações Artisticas Culturais, Stand-Ups, etc. </p>--%>
                        </div>
                        <div class="card-footer">
                            <a href="http://transparencia.moradaturismoeventos.com.br/Arquivos/PDFs/Plantas/CEAR-Centro-Convencao-Auditorio.pdf" target="_blank">Download Planta</a>
                        </div>
                    </div>
                </div>

                <div class="col-lg-4 col-md-6 mb-4">
                    <div class="card h-110">
                        <a href="Portifolio.aspx?IdTipo=3&Galeria=Sala Multi-Uso">
                            <img class="card-img-top" src="http://transparencia.moradaturismoeventos.com.br/Arquivos/Imagem/CEAR/salas.jpg" alt=""></a>
                        <div class="card-body">
                            <h4 class="card-title">
                                <a href="Portifolio.aspx?IdTipo=3&Galeria=Sala Multi-Uso" class="btn btn-primary">Centro de Convenção  -&nbsp; Salas Multi-Uso</a>
                            </h4>
                            <div class="row">
                                <p class="card-text">Localizado no CEAR/Centro de Convenção, a Sala Multi-uso é perfeita para diversos tipos de eventos como: Seminários, Workshops, Cursos, Palestras, Eventos Corporativos, entre outros. Com espaço de 327 m² a sala tem capacidade para 300 pessoas, sentadas e conta com o recurso de paredes retráteis (Drywall) possibilitando sua sub-divisão em 3 salas de 100 lugares, distribuídas em módulos pré-definidos:</p>
                                <%--     <p class="card-text">Localizado no CEAR/Centro de Convenção, a Sala Multi-uso é perfeita para diversos tipos de eventos como: Seminários, Workshops, Cursos, Palestras, Eventos Corporativos, entre outros. Com espaço de 327 m² a sala tem capacidade para 300 pessoas. <strong>Em virtude da Pandemia pela COVID-19 e atendendo ao protocolo sanitário do município, o espaço Sala Multiuso de 300 passará para 75 lugares.</strong> sentadas e conta com o recurso de paredes retráteis (Drywall) possibilitando sua sub-divisão em 3 salas de 100 lugares, distribuídas em módulos pré-definidos:</p>--%>
                                <b class="card-text">Módulo I: </b>
                                <p>Capacidade para 100 Pessoas - 327 m².</p>
                            </div>

                            <div class="row">
                                <b class="card-text">Módulo II: </b>
                                <p>Capacidade para 100 Pessoas - 200 m².</p>
                            </div>

                            <div class="row">
                                <b class="card-text">Módulo III: </b>
                                <p>Capacidade para 100 Pessoas - 127 m².</p>
                            </div>

                            <div class="card-footer">
                                <a href="http://transparencia.moradaturismoeventos.com.br/Arquivos/Transparencias/4/28//AVCB_441960%20Centro%20de%20Conven%C3%A7%C3%B5es.pdf" target="_blank">Laudo AVCB</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>


        <br />
        <br />

        <footer class="py-5 bg-dark">
            <div class="container">
                <p class="m-0 text-center text-white">Copyright &copy; TI Solutions Commerce 2019</p>
                <p class="m-0 text-center text-white"></p>
            </div>
        </footer>

        <!-- Bootstrap core JavaScript -->

        <script src="../vendor/jquery/jquery.slim.min.js"></script>
        <script src="../vendor/bootstrap/js/bootstrap.bundle.min.js"></script>
    </form>
</body>
</html>

