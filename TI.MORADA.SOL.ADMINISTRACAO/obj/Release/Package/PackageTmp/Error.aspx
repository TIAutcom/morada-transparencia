<%@ Page Title="Retorno Site" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="TI.MORADA.SOL.ADMINISTRACAO.Error" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />

    <div class="page-container">
        <div class="container">

            <div class="col-lg-12">
                <div class="table-responsive">


                    <link href="//maxcdn.bootstrapcdn.com/bootstrap/3.3.0/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
                    <script src="//maxcdn.bootstrapcdn.com/bootstrap/3.3.0/js/bootstrap.min.js"></script>
                    <script src="//code.jquery.com/jquery-1.11.1.min.js"></script>
                    <!------ Include the above in your HEAD tag ---------->

                    <div class="container">


                        <div class="row">
                            <div class="col-md-2"></div>
                            <div class="col-md-8">
                                <div class="panel panel-danger">
                                    <div class="panel-heading">
                                        <h3 class="text-center">
                                            <span class="glyphicon glyphicon-exclamation-sign" aria-hidden="true"></span>Oops:
         
                            <small>Página não encontrada - <b>Erro 404</b></small>
                                        </h3>
                                    </div>
                                    <div class="panel-body">
                                        <p>A página que você está procurando pode ter sido removida, mudado de nome, ou está temporariamente indisponível. Tente o seguinte:</p>

                                        <ul class="list-group">
                                            <li class="list-group-item">Certifique-se de que o endereço do site exibido na barra de endereços do seu navegador está escrito e formatado corretamente.</li>
                                            <li class="list-group-item">Se você chegou a esta página clicando em um link, ou conexão com a Internet
               
                                <a href="#"><b>contate-nos</b></a> , caso problema Persistir entre em Contato com Adminitrador.</li>
                                            <li class="list-group-item">Esqueça que isso aconteceu, e vá para <a href="Default.aspx">sua <b>Página Inicial</b></a> :)</li>
                                            <li class="list-group-item"><b>Error:</b>
                                                <asp:Label ID="lblError" runat="server"></asp:Label></li>
                                        </ul>
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-2">
                            </div>
                        </div>
                        <%--    <p><a href="https://www.facebook.com/SysSolut"target="_blank">SysSolutions.</a></p>
                        --%>
                    </div>

                </div>
            </div>
        </div>
    </div>

</asp:Content>
