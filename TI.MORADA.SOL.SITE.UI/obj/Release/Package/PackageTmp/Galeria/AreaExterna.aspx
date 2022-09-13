<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AreaExterna.aspx.cs" Inherits="TI.MORADA.SOL.SITE.UI.Galeria.AreaExterna" %>

<html lang="en">
<head runat="server">

    <meta charset="utf-8">
    <link rel="icon" type="image/png" href="img/logo3.ico" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="">
    <meta name="author" content="">

    <title>Centro Internacional de Convenção</title>

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
            <h4 class="h-4">CEAR / Área Externa</h4>
            <div class="row">

                <div id="carouselExampleIndicators" class="carousel slide my-4" data-ride="carousel">
                    <ol class="carousel-indicators">
                        <li data-target="#carouselExampleIndicators" data-slide-to="0" class="active"></li>
                        <li data-target="#carouselExampleIndicators" data-slide-to="1"></li>
                        <li data-target="#carouselExampleIndicators" data-slide-to="2"></li>
                        <%--     <li data-target="#carouselExampleIndicators" data-slide-to="3"></li>--%>
                    </ol>

                    <div class="carousel-inner" role="listbox">
                        <div class="carousel-item active">
                            <img class="d-block img-fluid" src="http://transparencia.moradaturismoeventos.com.br/Arquivos/Imagem/Area/1.jpg" alt="First slide">
                        </div>
                        <div class="carousel-item">
                            <img class="d-block img-fluid" src="http://transparencia.moradaturismoeventos.com.br/Arquivos/Imagem/Area/13.jpg" alt="Second slide">
                        </div>
                        <div class="carousel-item">
                            <img class="d-block img-fluid" src="http://transparencia.moradaturismoeventos.com.br/Arquivos/Imagem/Area/17.jpg" alt="Third slide">
                        </div>
                        <%--                        <div class="carousel-item">
                            <img class="d-block img-fluid" src="http://transparencia.moradaturismoeventos.com.br/Arquivos/Imagem/Area/2.jpg" alt="Third slide">
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

            <h1 class="col-form-label-sm">O CEAR - Centro de Eventos de Araraquara e Região, conta com amplos estacionamentos na área externa. O primeiro com acesso pela avenida Bento de Abreu é considerado como a principal entrada para o Complexo, com aproximadamente 15.000 m² para estacionamento, conta com uma área pavimentada em piso de manta asfáltica e brita, acomadando assim até 500 veículos. O segundo acesso pela avenida Maria Antônia Camargo de Oliveira (Via Expressa) possui como infraestrutura, cobertura vegetal parcial e brita, com área de aproximadamente 25.000 m² para estacionamento acomoda até 900 veículos.
            </h1>

            <div class="row">

                <div class="col-lg-4 col-md-4 mb-8">
                    <div class="card h-100">
                        <a href="Portifolio.aspx?IdTipo=7&Galeria=AreaExternaI">
                            <img class="card-img-top" src="http://transparencia.moradaturismoeventos.com.br/Arquivos/Imagem/Area/AreaUM.JPG" alt=""></a>
                        <div class="card-body">
                            <h4 class="card-title">
                                <a href="Portifolio.aspx?IdTipo=7&Galeria=AreaExterna" class="btn btn-primary">CEAR - Área Externa I</a>
                            </h4>
                            <%--  <h5>$24.99</h5>--%>
                            <p class="card-text">Localizado na parte frontal do Pavilhão Principal, a Área Externa I, de aproximadamente 6.000 m², é considerado um espaço ideal para a realização de eventos em local aberto, também utilizado como apoio de estacionamento para atividades que acontecem em outros equipamentos.</p>
                        </div>
                        <div class="card-footer">
                            <a href="http://transparencia.moradaturismoeventos.com.br/Arquivos/PDFs/Plantas/CEAR-AreaExterna01.pdf" target="_blank">Download Planta</a>
                        </div>
                    </div>
                </div>

                <div class="col-lg-4 col-md-6 mb-4">
                    <div class="card h-100">
                        <a href="Portifolio.aspx?IdTipo=9&Galeria=AreaExterna">
                            <%--  <img class="card-img-top" src="http://placehold.it/700x400" alt=""></a>--%>
                            <img class="card-img-top" src="http://transparencia.moradaturismoeventos.com.br/Arquivos/Imagem/Area/AreaDois.JPG" alt=""></a>
                        <div class="card-body">
                            <h4 class="card-title">
                                <a href="Portifolio.aspx?IdTipo=97&Galeria=AreaExterna" class="btn btn-primary">CEAR - Área Externa II</a>
                            </h4>
                            <%--  <h5>$24.99</h5>--%>
                            <p class="card-text">Próximo ao Centro de Convenção, a Área Externa II, de aproximadamente de 4.200 m², é considerada também como segunda opção para realização de eventos em espaço aberto.</p>
                        </div>
                        <div class="card-footer">
                            <a href="http://transparencia.moradaturismoeventos.com.br/Arquivos/PDFs/Plantas/CEAR-AreaExterna02.pdf" target="_blank">Download Planta</a>
                        </div>
                    </div>
                </div>

                <div class="col-lg-4 col-md-6 mb-4">
                    <div class="card h-100">
                        <a href="Portifolio.aspx?IdTipo=10&Galeria=AreaExterna">
                            <img class="card-img-top" src="http://transparencia.moradaturismoeventos.com.br/Arquivos/Imagem/Area/areaTRES.JPG" alt=""></a>
                        <div class="card-body">
                            <h4 class="card-title">
                                <a href="Portifolio.aspx?IdTipo=10&Galeria=AreaExterna" class="btn btn-primary">CEAR - Área Externa III</a>
                            </h4>

                            <div class="row">
                                <p>Localizado ao lado do Centro de Convenção, a Área Externa III, com aproximadamente 7.500 m², acomoda até 250 veículos e apresenta-se como opção para a realização de eventos em espaço aberto, que utiliza estrutura reduzida.</p>
                            </div>

                        </div>

                        <div class="card-footer">
                            <a href="#">Download Planta</a>
                        </div>

                    </div>
                </div>

                <div class="col-lg-4 col-md-6 mb-4">
                    <div class="card h-100">
                        <a href="Portifolio.aspx?IdTipo=11&Galeria=AreaExterna">
                            <img class="card-img-top" src="http://transparencia.moradaturismoeventos.com.br/Arquivos/Imagem/Area/areaQUATRO.JPG" alt=""></a>
                        <div class="card-body">
                            <h4 class="card-title">
                                <a href="Portifolio.aspx?IdTipo=11&Galeria=AreaExterna" class="btn btn-primary">CEAR - Área Externa IV</a>
                            </h4>

                            <div class="row">
                                <p>Localizado ao lado direito do Pavilhão Principal, a Área Externa IV, com aproximadamente 6.100 m², acomoda até 200 veículos.</p>
                            </div>

                        </div>
                        <div class="card-footer">
                            <a href="#">Download Planta</a>
                        </div>
                    </div>
                </div>

                <div class="col-lg-4 col-md-6 mb-4">
                    <div class="card h-100">
                        <a href="Portifolio.aspx?IdTipo=12&Galeria=AreaExterna">
                            <img class="card-img-top" src="http://transparencia.moradaturismoeventos.com.br/Arquivos/Imagem/Area/areaCINCO.JPG" alt=""></a>
                        <div class="card-body">
                            <h4 class="card-title">
                                <a href="Portifolio.aspx?IdTipo=12&Galeria=AreaExterna" class="btn btn-primary">CEAR - Área Externa V</a>
                            </h4>

                            <div class="row">
                                <p>Localizado próximo ao Pavilhão Principal, a Área Externa V, com aproximadamente 8.000 m², acomoda até 260 veículos.</p>
                            </div>

                        </div>

                        <div class="card-footer">
                            <a href="#">Download Planta</a>
                        </div>
                    </div>
                </div>

                <div class="col-lg-4 col-md-6 mb-4">
                    <div class="card h-100">
                        <a href="Portifolio.aspx?IdTipo=13&Galeria=AreaExterna">
                            <img class="card-img-top" src="http://transparencia.moradaturismoeventos.com.br/Arquivos/Imagem/Area/areaSEIS.JPG" alt=""></a>
                        <div class="card-body">
                            <h4 class="card-title">
                                <a href="Portifolio.aspx?IdTipo=13&Galeria=AreaExterna" class="btn btn-primary">CEAR - Área Externa VI</a>
                            </h4>

                            <div class="row">
                                <p>A Área Externa VI através do acesso da avenida Maria Antônia Camargo de Oliveira (Via Expressa), possui aproximadamente 6.000 m² e acomoda até 150 veículos.</p>
                            </div>

                        </div>

                        <div class="card-footer">
                            <a href="#">Download Planta</a>
                        </div>

                    </div>
                </div>

            </div>
        </div>

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
