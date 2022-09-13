<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="TI.MORADA.SOL.SITE.UI.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Index</title>
    <link rel="icon" type="image/png" href="img/logo3.ico" />
    <link href="css/Detalhes.css" rel="stylesheet" />
    <link href="vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <link href="css/modern-business.css" rel="stylesheet" />

    <script>
        function myFunction() {
            document.getElementById("mp4_src").src = "http://gproj.com.br/Arquivos/drone.mp4";
            document.getElementById("ogg_src").src = "movie.ogg";
            document.getElementById("myVideo").load();
        }
    </script>

</head>
<body>
    <form runat="server">

        <!-- Navigation -->
        <nav class="navbar navbar-expand-lg navbar-dark bg-dark fixed-top">

            <div class="container">
                <a class="navbar-brand" href="../Index.aspx">CEAR - Centro de Eventos de Araraquara e Região</a>
                <%--   <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarResponsive" aria-controls="navbarResponsive" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>--%>
            </div>
        </nav>

        <header>
            <div id="carouselExampleIndicators" class="carousel slide" data-ride="carousel">
                <ol class="carousel-indicators">
                    <li data-target="#carouselExampleIndicators" data-slide-to="0" class="active"></li>
        <%--            <li data-target="#carouselExampleIndicators" data-slide-to="1"></li>--%>
                    <li data-target="#carouselExampleIndicators" data-slide-to="2"></li>
                    <li data-target="#carouselExampleIndicators" data-slide-to="3"></li>
                    <li data-target="#carouselExampleIndicators" data-slide-to="4"></li>
                    <li data-target="#carouselExampleIndicators" data-slide-to="5"></li>
                    <li data-target="#carouselExampleIndicators" data-slide-to="6"></li>
                    <li data-target="#carouselExampleIndicators" data-slide-to="7"></li>
                    <li data-target="#carouselExampleIndicators" data-slide-to="8"></li>
                    <%--     <li data-target="#carouselExampleIndicators" data-slide-to="8"></li>--%>
                </ol>

                <div class="carousel-inner" role="listbox">

                    <!-- Slide One - Set the background image for this slide in the line below -->
                    <%-- 1--%>
                    <div class="carousel-item active" style="background-image: url('http://transparencia.moradaturismoeventos.com.br/Arquivos/Imagem/Default/novaLogo2.jpg')">
                        <div class="carousel-caption d-none d-md-block">
                            <%-- <h3 class="lblCor">Logo</h3>--%>
                            <p class="lblCor"></p>
                        </div>
                    </div>

         

                    <%--7--%>
                    <!-- Slide Three - Set the background image for this slide in the line below -->
                    <div class="carousel-item" style="background-image: url('http://transparencia.moradaturismoeventos.com.br/Arquivos/Portifolios/selo.jpg'); background-size: contain">
                        <div class="carousel-caption d-none d-md-block">
                            <h3 class="lblCor" style="color: yellow">Selo Turismo Responsável</h3>
                        </div>
                    </div>

                    <%--2--%>
                    <!-- Slide Two - Set the background image for this slide in the line below -->
                    <div class="carousel-item" style="background-image: url('http://transparencia.moradaturismoeventos.com.br/Arquivos/Imagem/Default/1.jpeg')">
                        <div class="carousel-caption d-none d-md-block">
                            <h3 class="lblCor">Auditório</h3>
                            <p class="lblCor">Apresentações de Shows, Teatros e Orquestras.</p>
                        </div>
                    </div>

                    <%--3--%>
                    <!-- Slide Three - Set the background image for this slide in the line below -->
                    <div class="carousel-item" style="background-image: url('http://transparencia.moradaturismoeventos.com.br/Arquivos/Imagem/Default/32.jpeg')">
                        <div class="carousel-caption d-none d-md-block">
                            <h3 class="lblCor">Pavilhão Multi-Setor</h3>
                            <p class="lblCor">Grandes Shows com Área Coberta.</p>
                        </div>
                    </div>

                    <%-- 4--%>
                    <!-- Slide Three - Set the background image for this slide in the line below -->
                    <div class="carousel-item" style="background-image: url('http://transparencia.moradaturismoeventos.com.br/Arquivos/Imagem/Default/Pavilhao.jpg')">
                        <div class="carousel-caption d-none d-md-block">
                            <h3 class="lblCor">Pavilhão Multi-Setor</h3>
                            <p class="lblCor">Montagem de Ambiente para Eventos e Formaturas.</p>
                        </div>
                    </div>

                    <%--   5--%>
                    <!-- Slide Three - Set the background image for this slide in the line below -->
                    <div class="carousel-item" style="background-image: url('http://transparencia.moradaturismoeventos.com.br/Arquivos/Imagem/Default/feirao.jpeg')">
                        <div class="carousel-caption d-none d-md-block">
                            <h3 class="lblCor">Pavilhão Multi-Setor</h3>
                            <p class="lblCor">Feirão de Veículos.</p>
                        </div>
                    </div>

                    <%--6--%>
                    <!-- Slide Three - Set the background image for this slide in the line below -->
                    <div class="carousel-item" style="background-image: url('http://transparencia.moradaturismoeventos.com.br/Arquivos/Imagem/Default/arena.jpeg')">
                        <div class="carousel-caption d-none d-md-block">
                            <h3 class="lblCor">Complexo CEAR</h3>
                            <p class="lblCor">Vista Áerea.</p>
                        </div>
                    </div>



                    <%--7--%>
                    <!-- Slide Three - Set the background image for this slide in the line below -->
                    <div class="carousel-item" style="background-image: url('http://transparencia.moradaturismoeventos.com.br/Arquivos/Imagem/Default/9.jpeg')">
                        <div class="carousel-caption d-none d-md-block">
                            <h3 class="lblCor">Pavilhão Multi-Setor</h3>
                            <p class="lblCor">Montagem de Ambiente para Eventos e Formaturas.</p>
                        </div>
                    </div>

                    <%--               <div class="carousel-item" style="background-image: url('http://transparencia.moradaturismoeventos.com.br/Arquivos/Imagem/Default/cear2.jpg')">
                        <div class="carousel-caption d-none d-md-block">
                            <h3 class="lblCor">CENTRO INTERNACIONAL DE CONVENÇÃO DE ARARAQUARA</h3>
                    
                        </div>
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
        </header>

        <hr />
        <div class="container">

            <div class="row">
                <div class="col-lg-6">
                    <h3 id="ComplexoCear">Complexo do CEAR</h3>
                </div>
            </div>

            <div class="row main-low-margin text-center">

                <%-- CEAR--%>
                <div class="col-lg-3 col-md-4 col-sm-6 portfolio-item">
                    <div class="card h-100">
                        <a href="Galeria/Cear.aspx">
                            <img class="card-img-top" src="http://transparencia.moradaturismoeventos.com.br/Arquivos/Imagem/Default/cearnoite.jpg" alt="" />
                        </a>
                        <div class="card-body">
                            <h5 class="card-title">
                                <a href="Galeria/Cear.aspx">Centro de Convenção</a>
                            </h5>
                            <%--   <small class='text-muted'>&#9750; &#9733; &#9743; &#9733; &#9734;</small>--%>
                        </div>
                    </div>
                </div>

                <%--MULTI-SETOR--%>
                <div class="col-lg-3 col-md-4 col-sm-6 portfolio-item">
                    <div class="card h-100">
                        <a href="Galeria/Pavilhao.aspx">
                            <img class="card-img-top" src="http://transparencia.moradaturismoeventos.com.br/Arquivos/Imagem/Default/pavilhao2.jpg" alt="" />
                        </a>
                        <div class="card-body">
                            <h5 class="card-title">
                                <%-- <a href="Galeria/Pavilhao.aspx">CEAR</a>--%>

                                <a href="Galeria/Pavilhao.aspx">Pavilhão Multi-Setor</a>

                            </h5>
                            <%--   <small class='text-muted'>&#9750; &#9733; &#9743; &#9733; &#9734;</small>--%>
                        </div>
                    </div>
                </div>

                <%-- AREA EXTERNA--%>
                <div class="col-lg-3 col-md-4 col-sm-6 portfolio-item">
                    <div class="card h-100">
                        <a href="Galeria/AreaExterna.aspx">
                            <img class="card-img-top" src="http://transparencia.moradaturismoeventos.com.br/Arquivos/Imagem/Default/area2.jpg" alt="" />
                        </a>
                        <div class="card-body">
                            <h5 class="card-title">
                                <a href="Galeria/AreaExterna.aspx">Área Externa</a>
                            </h5>
                            <%--   <small class='text-muted'>&#9750; &#9733; &#9743; &#9733; &#9734;</small>--%>
                        </div>
                    </div>
                </div>

                <%-- ARENA--%>
                <div class="col-lg-3 col-md-4 col-sm-6 portfolio-item">
                    <div class="card h-100">
                        <a href="Galeria/Portifolio.aspx?IdTipo=8&Galeria=ARENA">
                            <img class="card-img-top" src="http://transparencia.moradaturismoeventos.com.br/Arquivos/Imagem/Default/Arena2.jpg" alt="" />
                        </a>
                        <div class="card-body">
                            <h5 class="card-title">
                                <a href="Galeria/Portifolio.aspx?IdTipo=8&Galeria=ARENA">Arena da Fonte</a>
                            </h5>
                            <%--   <small class='text-muted'>&#9750; &#9733; &#9743; &#9733; &#9734;</small>--%>
                        </div>
                    </div>
                </div>

                <a id="Portifolios"></a>

                <%-- AGENDA--%>
                <div class="col-lg-3 col-md-4 col-sm-6 portfolio-item">
                    <div class="card h-100">
                        <a href="Galeria/Agenda.aspx">
                            <img class="card-img-top" src="http://transparencia.moradaturismoeventos.com.br/Arquivos/Imagem/Default/agenda3.jpg" alt="" /></a>
                        <div class="card-body">
                            <h5 class="card-title">
                                <a href="Galeria/Agenda.aspx">Agenda de Eventos e Programações.</a>
                            </h5>
                            <p class="card-text">Divulgações de Shows e Eventos.</p>
                        </div>
                    </div>
                </div>

                <%-- OBRAS--%>
                <div class="col-lg-3 col-md-4 col-sm-6 portfolio-item">
                    <div class="card h-100">
                        <a href="Galeria/Portifolio.aspx?IdTipo=1&Galeria=Obras">
                            <img class="card-img-top" src="http://transparencia.moradaturismoeventos.com.br/Arquivos/Imagem/Default/obras2.jpg" alt="" /></a>
                        <div class="card-body">
                            <h5 class="card-title">
                                <a href="Galeria/Portifolio.aspx?IdTipo=1&Galeria=Obras">Obras</a>
                            </h5>
                            <p class="card-text">Galeria de Fotos.</p>
                        </div>
                    </div>
                </div>

                <%-- EVENTOS--%>
                <div class="col-lg-3 col-md-4 col-sm-6 portfolio-item">
                    <div class="card h-100">
                        <a href="Galeria/Portifolio.aspx?IdTipo=2&Galeria=Eventos">
                            <img class="card-img-top" src="http://transparencia.moradaturismoeventos.com.br/Arquivos/Imagem/Default/eventos2.jpg" alt="" /></a>
                        <div class="card-body">
                            <h5 class="card-title">
                                <a href="Galeria/Portifolio.aspx?IdTipo=2&Galeria=Eventos">Eventos</a>
                            </h5>
                            <p class="card-text">Galeria de Fotos realizados no CEAR.</p>
                        </div>
                    </div>
                </div>

                <%-- VIDEOS--%>
                <div class="col-lg-3 col-md-4 col-sm-6 portfolio-item">
                    <div class="card h-100">
                        <a href="Galeria/Videos.aspx">
                            <img class="card-img-top" src="http://transparencia.moradaturismoeventos.com.br/Arquivos/Imagem/Default/Videos.jpg" alt="" /></a>
                        <div class="card-body">
                            <h5 class="card-title">
                                <a href="Galeria/Videos.aspx">Videos</a>
                            </h5>
                            <p class="card-text">Postagem de Videos, Shows, Eventos, e Congressos no CEAR.</p>
                        </div>
                    </div>
                </div>


                <%-- CONTATOS--%>
                <div class="col-lg-3 col-md-4 col-sm-6 portfolio-item" id="QuemSomos">
                    <div class="card h-100">
                        <a href="#" data-toggle="modal" data-target="#myModal2">
                            <img class="card-img-top" src="http://transparencia.moradaturismoeventos.com.br/Arquivos/Imagem/Default/contato.jpg" alt="" /></a>
                        <div class="card-body">
                            <h5 class="card-title">
                                <a href="#" data-toggle="modal" data-target="#myModal2">Fale Conosco</a>
                            </h5>
                            <p class="card-text">Endereço, Telefone e Localização.</p>
                            <p class="card-text">Horario de Atendimento: 09:00 às 17:00Hs.</p>
                        </div>
                    </div>
                </div>

                <%-- FALE CONOSCO--%>
                <div class="col-lg-3 col-md-4 col-sm-6 portfolio-item">
                    <div class="card h-100">
                        <a href="#" data-toggle="modal" data-target="#myModal">
                            <img class="card-img-top" src="http://transparencia.moradaturismoeventos.com.br/Arquivos/Imagem/Default/email.jpg" alt="" /></a>
                        <div class="card-body">
                            <h5 class="card-title">
                                <a href="#" data-toggle="modal" data-target="#myModal">Caixa de Mensagem</a>
                            </h5>
                            <p class="card-text">Envie sua mensagem no formulário e entraremos em contato o mais breve possível. Para enviar uma mensagem, você não precisa estar cadastrado.</p>
                        </div>
                    </div>
                </div>

                <%-- TRANSPARENCIA--%>
                <div class="col-lg-3 col-md-4 col-sm-6 portfolio-item" id="Transparencia">
                    <div class="card h-100">
                        <a target="_blank" href="http://transparencia.moradaturismoeventos.com.br/">
                            <img class="card-img-top" src="http://transparencia.moradaturismoeventos.com.br/Arquivos/Imagem/Default/transparencia.jpg" alt="" /></a>
                        <div class="card-body">
                            <h5 class="card-title">
                                <a href="http://transparencia.moradaturismoeventos.com.br/" target="_blank">Transparência</a>
                            </h5>
                            <p class="card-text">Informações sobre Licitações, Contratos, Constituição e Órgãos Diretivos, Execução Orçamentária e Controle Financeiro, Pessoal e de Atividades.</p>
                        </div>
                    </div>
                </div>

                <%-- QUEM SOMOS--%>
                <div class="col-lg-3 col-md-4 col-sm-6 portfolio-item">
                    <div class="card h-100">
                        <a href="Galeria/QuemSomos.aspx">
                            <img class="card-img-top" src="http://transparencia.moradaturismoeventos.com.br/Arquivos/Imagem/Default/quemSomos.jpg" alt="" /></a>
                        <div class="card-body">
                            <h5 class="card-title">
                                <a href='Galeria/QuemSomos.aspx'>Quem Somos</a>
                            </h5>
                            <p class="card-text">Quem é a Empresa Morada do Sol Turismo, Eventos e Participações S/A.</p>
                        </div>
                    </div>
                </div>

                <div>
                    <a id="Diretoria"></a>
                </div>


                <%-- DIRETORIA--%>
                <div class="col-lg-3 col-md-4 col-sm-6 portfolio-item">
                    <div class="card h-100">
                        <a href="Galeria/Diretoria.aspx">
                            <img class="card-img-top" src="http://transparencia.moradaturismoeventos.com.br/Arquivos/Imagem/Default/diretores.jpg" alt="" /></a>
                        <div class="card-body">
                            <h5 class="card-title">
                                <a href="Galeria/Diretoria.aspx">Diretoria</a>
                            </h5>
                            <p class="card-text">Conheça os Integrantes da Diretoria Executiva e Conselheiros. Veja o resumo de suas experiências profissionais.</p>
                        </div>
                    </div>
                </div>


                <%-- FACE--%>
                <div class="col-lg-3 col-md-4 col-sm-6 portfolio-item">
                    <div class="card h-100">
                        <a href="https://www.facebook.com/cear.araraquara.3/" target="_blank">
                            <img class="card-img-top" src="http://transparencia.moradaturismoeventos.com.br/Arquivos/Imagem/Default/face3.jpg" alt="" /></a>
                        <div class="card-body">
                            <h5 class="card-title">
                                <a href="https://www.facebook.com/cear.araraquara.3/" target="_blank">Facebook</a>
                            </h5>
                            <p class="card-text">Entre, navegue, curta nossa pagina do Facebook.</p>
                        </div>
                    </div>
                </div>

                <%-- INSTA--%>
                <div class="col-lg-3 col-md-4 col-sm-6 portfolio-item">
                    <div class="card h-100">
                        <a href="https://www.instagram.com/cearararaquara/" target="_blank">
                            <img class="card-img-top" style="height: 185px" src="http://cearararaquara.com.br/Img/insta2.jpg" alt="" /></a>
                        <div class="card-body">
                            <h5 class="card-title">
                                <a href="https://www.instagram.com/cearararaquara/" target="_blank">Instagram</a>
                            </h5>
                            <p class="card-text">Siga nos e mantenha se informado.</p>
                        </div>
                    </div>
                </div>

                <%-- EVENTOS ARARAQUARA--%>
                <%--                <div class="col-lg-3 col-md-4 col-sm-6 portfolio-item">
                    <div class="card h-100">
                        <a href="#">
                            <img class="card-img-top" src="http://transparencia.moradaturismoeventos.com.br/Arquivos/Imagem/Default/eventos4.jpg" alt="" /></a>
                        <div class="card-body">
                            <h4 class="card-title">
                                <a href="#"></a>
                            </h4>
                            <p class="card-text">Breve!!!</p>
                            <p>Site de fotos, coberturas de eventos, agendas, baladas, bares, gastronomia, notícias e lazer de Araraquara e Região.</p>
                        </div>
                    </div>
                </div>--%>

                <%-- EVENTOS LOGO--%>
                <%--               <div class="col-lg-3 col-md-4 col-sm-6 portfolio-item">
                    <div class="card h-100">
                        <a>
                            <img class="card-img-top" src="http://transparencia.moradaturismoeventos.com.br/Arquivos/Imagem/Default/logo3.png" alt="" /></a>
                        <div class="card-body">
                            <h5 class="card-title"></h5>
                            <p>O layout traduz o resgate das raízes, a ancestralidade e a força da marca da empresa, que se iniciou na década de 20. Além disso, a marca traz a característica das multi atividades desenvolvidas atualmente no CEAR, representando as infinitas possibilidades que o equipamento permite.</p>
                        </div>
                    </div>
                </div>--%>

                <div class="col-lg-3 col-md-4 col-sm-6 portfolio-item">
                    <div class="card h-100">
                        <a href="http://transparencia.moradaturismoeventos.com.br/Arquivos/Imagem/Default/logo3.png" target="_blank">
                            <img class="card-img-top" src="http://transparencia.moradaturismoeventos.com.br/Arquivos/Imagem/Default/logo3.png" alt="" /></a>
                        <div class="card-body">
                            <h5 class="card-title"></h5>
                            <p>A Marca.</p>
                        </div>
                    </div>
                </div>

                <div class="col-lg-3 col-md-4 col-sm-6 portfolio-item">
                    <div class="card h-100">
                        <a href="https://seloresponsavel.turismo.gov.br/selo-turismo-responsavel/#/verificar-selo/43964097000165/114881" target="_blank">
                            <img class="card-img-top" src="http://transparencia.moradaturismoeventos.com.br/Arquivos/Portifolios/selo.jpg" alt="" /></a>
                        <div class="card-body">
                            <h5 class="card-title">
                                <a href="http://transparencia.moradaturismoeventos.com.br/Arquivos/Portifolios/selo.jpg" target="_blank">Selo Turismo Responsável</a>
                            </h5>
                            <%--    <p>Selo Turismo Responsável.</p>--%>
                        </div>
                    </div>
                </div>

                <div class="col-lg-3 col-md-4 col-sm-4 portfolio-item">
                    <div class="card h-100">
                        <a href="http://transparencia.moradaturismoeventos.com.br/Arquivos/Portifolios/covid.jpeg" target="_blank">
                            <img class="card-img-top" style="height: 180px;" src="http://transparencia.moradaturismoeventos.com.br/Arquivos/Portifolios/covid.jpeg" alt="" /></a>
                        <div class="card-body">
                            <%--    <h5 class="card-title">Comunicado
                            </h5>--%>
                            <p>Comunicados aos Nossos Parceiros.</p>
                        </div>
                    </div>
                </div>

                <div class="col-lg-3 col-md-4 col-sm-4 portfolio-item">
                    <div class="card h-100">
                        <a href="http://transparencia.moradaturismoeventos.com.br/Arquivos/Portifolios/cadastur.jpg" target="_blank">
                            <img class="card-img-top" src="http://transparencia.moradaturismoeventos.com.br/Arquivos/Portifolios/cadastur.jpg" alt="" /></a>
                        <div class="card-body">
                            <h5 class="card-title">
                                <a href="https://cadastur.turismo.gov.br/cadastur/#!/public/qrcode/43964097000165" target="_blank">CADASTUR</a>
                            </h5>
                            <p>O Cear de Araraquara através da CADASTUR.</p>
                        </div>
                    </div>
                </div>

                <br />

                <div class="row">
                    <div class="col-lg-6">
                        <h2>Você em nossa Rede Social</h2>
                        <div class="row mb-4">
                            <div>
                                <p>
                                    <a href="#">Entre e cadastre-se. 
                                    </a>
                                    Envie seu video ou foto(s) para a nossa página, com a palavra: "Estive no CEAR".
                               
                                </p>

                                <a class="btn btn-lg btn-dark btn-block" href="EnvieSeuVideo.aspx">Envie seu Video/Foto</a>
                            </div>

                        </div>
                        <%--     <p>Entre, navegue e curta nossa pagina do Facebook:</p>--%>
                        <%--    <ul>
                            <li>Fotos</li>
                            <li>Avaliações</li>
                            <li>Videos</li>
                            <li>Shows</li>
                            <li>
                                <b>
                                    <a href="https://pt-br.facebook.com/MoradadoSolParticipacoes/" target="_blank">facebook.com/MoradadoSolParticipacoes</a>
                                </b>
                            </li>
                        </ul>--%>
                        <%--      <p>Todas informações e anuncios.</p>--%>
                    </div>
                    <div class="col-lg-6">

                        <video id="myVideo" class="img-fluid rounded" width="700" height="450" controls autoplay>
                            <source id="mp4_src" src="http://gproj.com.br/Arquivos/Praca2.mp4" type="video/mp4" />
                            <source id="ogg_src" src="mov_bbb.ogg" type="video/ogg" />
                        </video>
                    </div>
                </div>
                <br />
                <hr />

            </div>
        </div>

        <iframe src="https://www.google.com/maps/embed?pb=!1m17!1m11!1m3!1d2131.1194717363564!2d-48.168456723873085!3d-21.771980383259347!2m2!1f0!2f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x0%3A0xf4d88a6b7c7da4fe!2sCentro+Internacional+de+Conven%C3%A7%C3%A3o+Dr.+Nelson+Barbieri!5e1!3m2!1spt-BR!2sbr!4v1548857248188" style="border: 0; width: 100%; height: 450px;" frameborder="0" allowfullscreen></iframe>
        <%--        <iframe src="https://www.google.com/maps/embed?pb=!1m17!1m11!1m3!1d2131.1194717363564!2d-48.168456723873085!3d-21.771980383259347!2m2!1f0!2f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x0%3A0xf4d88a6b7c7da4fe!2sCentro+Internacional+de+Conven%C3%A7%C3%A3o+Dr.+Nelson+Barbieri!5e1!3m2!1spt-BR!2sbr!4v1548857248188" style="border: 0; width: 100%; height: 450px;" frameborder="0" allowfullscreen></iframe>--%>
        <iframe src="https://www.google.com/maps/embed?pb=!4v1517493000766!6m8!1m7!1sPfY3x5W2utAPZRIXzdxS-A!2m2!1d-21.77277536764968!2d-48.17028167214782!3f130.99658976557862!4f-1.2081096141474745!5f0.7820865974627469" style="border: 0; width: 100%; height: 450px;" frameborder="0" allowfullscreen></iframe>

        <br />

        <footer class="py-5 bg-dark">
            <div class="container">
                <p class="m-0 text-center text-white">&copy; <%: DateTime.Now.Year %> - TI Solutions Services Applicattion Commerce - 10.80</p>

                <%--     <div align="center">
                    <a href="Login.aspx">Login Adminitrativo</a>
                </div>--%>
            </div>
        </footer>

        <%--       <footer>
            <p>&copy; <%: DateTime.Now.Year %> - TI Solutions Services Applicattion Commerce - 10.54</p>
        </footer>--%>

        <script>
            $(document).ready(function () {
                $('#slides').slidesjs({
                    width: 940,
                    height: 528,
                    play: {
                        active: true,
                        auto: true,
                        interval: 4000,
                        swap: true
                    }
                });
            });
        </script>

        <script src="vendor/jquery/jquery.min.js"></script>
        <script src="vendor/bootstrap/js/bootstrap.bundle.min.js"></script>

        <%-- MODAL FALE CONOSCO--%>
        <div class="container">

            <div id="myModal" class="modal fade" role="dialog">
                <div class="modal-dialog">
                    <!-- Modal content-->
                    <div class="modal-content">
                        <div class="modal-header">
                            <button type="button" class="close" data-dismiss="modal">&times;</button>
                            <h4 class="modal-title"></h4>
                        </div>
                        <div class="modal-body">
                            <div class="form-control" role="form" method="post" id="reused_form" runat="server">

                                <p>Envie sua mensagem no formulário abaixo e entraremos em contato o mais breve possível.</p>

                                <div class="form-group">
                                    <label for="name">Name:</label>
                                    <input type="text" class="form-control" id="name" name="name" required maxlength="50" />
                                </div>

                                <div class="form-group">
                                    <label for="email">Email:</label>
                                    <input type="email" class="form-control" id="email" name="email" required maxlength="50" />
                                </div>

                                <div class="form-group">
                                    <label for="assunto">Assunto:</label>
                                    <input type="search" class="form-control" id="assunto" name="assunto" required maxlength="50" />
                                </div>

                                <div class="form-group">
                                    <label for="name">Mensagem:</label>
                                    <textarea class="form-control" type="textarea" name="message" id="message" placeholder="Sua mensagem aqui" maxlength="2000" rows="4"></textarea>
                                </div>

                                <asp:Button ID="btnEnviar" runat="server" Text="Enviar" class="btn btn-lg btn-success btn-block" OnClick="btnEnviar_Click" />

                            </div>
                            <div id="success_message" style="width: 100%; height: 100%; display: none;">
                                <h3>Sent your message successfully!</h3>
                            </div>
                            <div id="error_message" style="width: 100%; height: 100%; display: none;">
                                <h3>Error</h3>
                                Sorry there was an error sending your form.
                           
                            </div>
                        </div>
                    </div>
                </div>
            </div>

        </div>

        <%-- MODAL QUEM SOMOS--%>
        <div class="container">

            <!-- The Modal -->
            <div class="modal fade" id="myModalQuemSomos">
                <div class="modal-dialog modal-lg">
                    <div class="modal-content">

                        <div class="col-lg-12">

                            <video id="myVideo" class="img-fluid rounded" width="700" height="450" controls autoplay>
                                <source id="mp4_src" src="http://moradaturismo.gproj.com.br/Image/drone.mp4" type="video/mp4" />
                                <source id="ogg_src" src="mov_bbb.ogg" type="video/ogg" />
                            </video>

                        </div>

                        <!-- Modal footer -->
                        <div class="modal-footer">
                            <button type="button" class="btn btn-secondary" data-dismiss="modal">Fechar</button>
                        </div>

                    </div>
                </div>
            </div>

        </div>

        <%--MODAL CONTATO--%>
        <div class="container">
            <!-- Modal -->
            <div class="modal fade" id="myModal2" role="dialog">
                <div class="modal-dialog modal-lg">
                    <div class="modal-content">
                        <div class="modal-header">
                            <%--       <button type="button" class="close" data-dismiss="modal">&times;</button>--%>
                            <h4 class="modal-title">Contatos</h4>
                        </div>
                        <div class="modal-body">

                            <div>
                                <address>
                                    &nbsp;Localização:<br />
                                    &nbsp;Rua Ivo Antônio Magnani, 430<br />
                                    &nbsp;Araraquara/SP<br />
                                    &nbsp;CEP-14802.634
                                    
                                    <br />
                                    &nbsp;Bairro: Fonte Luminosa 
                                   
                                    <br />
                                    &nbsp;Contato:
                                    (16) 3335-8526/3331-6690
                               
                                </address>

                                <address>
                                    <strong>&nbsp;Localização:</strong>
                                    <a href="https://maps.app.goo.gl/By8xF" target="_blank">Maps</a><br />
                                    <strong>&nbsp;E-Mail:</strong> <a href="mailto:contato@cearararaquara.com.br">contato@cearararaquara.com.br</a><br />
                                    <strong>&nbsp;Rede Social:</strong> <a href="https://www.facebook.com/cear.araraquara.50" target="_blank">Facebook</a>
                                </address>
                            </div>

                        </div>
                        <div class="modal-footer">
                            <button type="button" class="btn btn-info" data-dismiss="modal">Fechar</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>

    </form>
</body>
</html>
