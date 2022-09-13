<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="TI.MORADA.SOL.SITE.UI.Error" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <link href="//maxcdn.bootstrapcdn.com/bootstrap/3.3.0/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
        <script src="//maxcdn.bootstrapcdn.com/bootstrap/3.3.0/js/bootstrap.min.js"></script>
        <script src="//code.jquery.com/jquery-1.11.1.min.js"></script>
        <!------ Include the above in your HEAD tag ---------->

        <div class="container">
            <br>
            <br>
            <br>
            <br>
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
                                <li class="list-group-item">Se você chegou a esta página clicando em um link,
               
                                <a href="http://fb.me/msg/SysSolut"><b>contate-nos</b></a> caso problema Persistir.</li>
                                <li class="list-group-item">Esqueça que isso aconteceu, e vá para <a href="Index.aspx">sua <b>Página Inicial</b></a> :)</li>
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
    </form>
</body>
</html>
