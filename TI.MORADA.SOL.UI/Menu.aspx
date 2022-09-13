﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="TI.MORADA.SOL.UI.Menu" %>

<!DOCTYPE html>
<%--15--%>
<html lang="en">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title><%: Page.Title %> - Morada Transparência</title>
    

</head>
<body>
    <link href="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
    <script src="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js"></script>
    <script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
  
 

    <div class="navbar navbar-expand-md navbar-dark bg-dark mb-4" role="navigation">
        <a class="navbar-brand" href="#">Bootstrap 4 NavBar</a>
        <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarCollapse" aria-controls="navbarCollapse" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
        </button>
        <div class="collapse navbar-collapse" id="navbarCollapse">
            <ul class="navbar-nav mr-auto">
                <li class="nav-item active">
                    <a class="nav-link" href="#">Home <span class="sr-only">(current)</span></a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="http://fontenele.github.io/bootstrap-navbar-dropdowns/" target="_blank">Github</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link disabled" href="#">Disabled</a>
                </li>
                <li class="nav-item dropdown">
                    <a class="nav-link dropdown-toggle" id="dropdown1" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">Dropdown1</a>
                    <ul class="dropdown-menu" aria-labelledby="dropdown1">
                        <li class="dropdown-item" href="#"><a>Action 1</a></li>
                        <li class="dropdown-item dropdown">
                            <a class="dropdown-toggle" id="dropdown1-1" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">Dropdown1.1</a>
                            <ul class="dropdown-menu" aria-labelledby="dropdown1-1">
                                <li class="dropdown-item" href="#"><a>Action 1.1</a></li>
                                <li class="dropdown-item dropdown">
                                    <a class="dropdown-toggle" id="dropdown1-1-1" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">Dropdown1.1.1</a>
                                    <ul class="dropdown-menu" aria-labelledby="dropdown1-1-1">
                                        <li class="dropdown-item" href="#"><a>Action 1.1.1</a></li>
                                    </ul>
                                </li>
                            </ul>
                        </li>
                    </ul>
                </li>
                <li class="nav-item dropdown">
                    <a class="nav-link dropdown-toggle" id="dropdown2" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">Dropdown2</a>
                    <ul class="dropdown-menu" aria-labelledby="dropdown2">
                        <li class="dropdown-item" href="#"><a>Action 2 A</a></li>
                        <li class="dropdown-item" href="#"><a>Action 2 B</a></li>
                        <li class="dropdown-item" href="#"><a>Action 2 C</a></li>
                        <li class="dropdown-item dropdown">
                            <a class="dropdown-toggle" id="dropdown2-1" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">Dropdown2.1</a>
                            <ul class="dropdown-menu" aria-labelledby="dropdown2-1">
                                <li class="dropdown-item" href="#"><a>Action 2.1 A</a></li>
                                <li class="dropdown-item" href="#"><a>Action 2.1 B</a></li>
                                <li class="dropdown-item" href="#"><a>Action 2.1 C</a></li>
                                <li class="dropdown-item dropdown">
                                    <a class="dropdown-toggle" id="dropdown2-1-1" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">Dropdown2.1.1</a>
                                    <ul class="dropdown-menu" aria-labelledby="dropdown2-1-1">
                                        <li class="dropdown-item" href="#"><a>Action 2.1.1 A</a></li>
                                        <li class="dropdown-item" href="#"><a>Action 2.1.1 B</a></li>
                                        <li class="dropdown-item" href="#"><a>Action 2.1.1 C</a></li>
                                    </ul>
                                </li>
                                <li class="dropdown-item dropdown">
                                    <a class="dropdown-toggle" id="dropdown2-1-2" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">Dropdown2.1.2</a>
                                    <ul class="dropdown-menu" aria-labelledby="dropdown2-1-2">
                                        <li class="dropdown-item" href="#"><a>Action 2.1.2 A</a></li>
                                        <li class="dropdown-item" href="#"><a>Action 2.1.2 B</a></li>
                                        <li class="dropdown-item" href="#"><a>Action 2.1.2 C</a></li>
                                    </ul>
                                </li>
                            </ul>
                        </li>
                    </ul>
                </li>
            </ul>
            <form class="form-inline mt-2 mt-md-0">
                <input class="form-control mr-sm-2" type="text" placeholder="Search" aria-label="Search">
                <button class="btn btn-outline-success my-2 my-sm-0" type="submit">Search</button>
            </form>
        </div>
    </div>

    <main role="main" class="container">
        <div class="jumbotron text-center">
            <h1>Bootstrap 4 NavBar</h1>
            <p class="lead text-info">NavBar with too many childs.</p>
        </div>
    </main>


</body>
     <script>
        $(document).ready(function () {

            $('.navbar .dropdown-item').on('click', function (e) {
                var $el = $(this).children('.dropdown-toggle');
                var $parent = $el.offsetParent(".dropdown-menu");
                $(this).parent("li").toggleClass('open');

                if (!$parent.parent().hasClass('navbar-nav')) {
                    if ($parent.hasClass('show')) {
                        $parent.removeClass('show');
                        $el.next().removeClass('show');
                        $el.next().css({ "top": -999, "left": -999 });
                    } else {
                        $parent.parent().find('.show').removeClass('show');
                        $parent.addClass('show');
                        $el.next().addClass('show');
                        $el.next().css({ "top": $el[0].offsetTop, "left": $parent.outerWidth() - 4 });
                    }
                    e.preventDefault();
                    e.stopPropagation();
                }
            });

            $('.navbar .dropdown').on('hidden.bs.dropdown', function () {
                $(this).find('li.dropdown').removeClass('show open');
                $(this).find('ul.dropdown-menu').removeClass('show open');
            });

        });

    </script>
</html>