<%@ Page Language="C#" Title="Login" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="TI.MORADA.SOL.ADMINISTRACAO.Login" %>

<!DOCTYPE html>

<meta http-equiv="Content-Language" content="pt-br">

<head>

    <title>Login Agenda</title>

    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <link rel="icon" type="image/png" href="Arquivos/Imagem/Logo/novaLogo.jpg" />
    <link href="vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <link href="vendor/bootstrap/css/bootstrap.css" rel="stylesheet" />
    <link href="vendor/bootstrap/css/bootstrap-grid.min.css" rel="stylesheet" />
    <link href="vendor/bootstrap/css/main.css" rel="stylesheet" />
    <link href="vendor/bootstrap/css/navautil.css" rel="stylesheet" />
    <link href="vendor/bootstrap/css/novamain.css" rel="stylesheet" />
    <link href="vendor/bootstrap/css/util.css" rel="stylesheet" />

</head>
<body>

    <div class="limiter">
        <div class="container-login100" style="background-image: url('images/img-01.jpeg');">
            <div class="wrap-login100 p-t-190 p-b-30">
                <form class="login100-form validate-form" runat="server">
                    <div class="login100-form-avatar">
                        <img src="Arquivos/Imagem/Logo/novaLogo.jpg" alt="AVATAR">
                    </div>

                    <span class="login100-form-title p-t-20 p-b-45">CEAR - Controle de Acesso</span>

                    <div class="wrap-input100 validate-input m-b-10" data-validate="Username is required">

                        <asp:TextBox ID="txtLogin" CssClass="input100" runat="server" placeholder="Username" TextMode="Email"></asp:TextBox>
                        <span class="focus-input100"></span>
                        <span class="symbol-input100">
                            <i class="fa fa-user"></i>
                        </span>
                    </div>

                    <div class="wrap-input100 validate-input m-b-10" data-validate="Password is required">
                        <asp:TextBox ID="txtSenha" CssClass="input100" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>

                        <span class="focus-input100"></span>
                        <span class="symbol-input100">
                            <i class="fa fa-lock"></i>
                        </span>
                    </div>

                    <div class="container-login100-form-btn p-t-10">
                        <asp:Button ID="btnLogin" runat="server" Text="Login" CssClass="auto-style1" OnClick="btnLogin_Click" />
                    </div>

                    <div class="text-center w-full p-t-25 p-b-230">
                        <a href="#" class="txt1">Forgot Username / Password?
                        </a>
                    </div>

                    <div class="text-center w-full">
                        <a class="txt2">Versão - 01.2019
                        </a>
                    </div>
                </form>
            </div>
        </div>
    </div>

    <script src="vendor/jquery/jquery-3.2.1.min.js"></script>
    <script src="vendor/bootstrap/js/popper.js"></script>
    <script src="vendor/bootstrap/js/bootstrap.min.js"></script>
    <script src="vendor/select2/select2.min.js"></script>
    <script src="js/main.js"></script>



    <style>
        .w-full {
            width: 100%;
            padding: 10px;
        }

        .wrap-login100 {
            padding-top: 10px;
            padding-left: 15px;
            padding-right: 15px;
        }

        .txt1 {
            color: #cccccc;
            font-size: 10px;
        }

        a:not([href]):not([tabindex]) {
            color: #cccccc;
            text-decoration: none;
        }
        .auto-style1 {
            font-family: Montserrat-Bold;
            font-size: 15px;
            line-height: 1.5;
            color: #e0e0e0;
            width: 100%;
            height: 50px;
            border-radius: 25px;
            display: flex;
            justify-content: center;
            align-items: center;
            -webkit-transition: all 0.4s;
            -o-transition: all 0.4s;
            -moz-transition: all 0.4s;
            transition: all 0.4s;
            position: relative;
            z-index: 1;
            left: 0px;
            top: 0px;
            padding: 0 25px;
            background: #333333;
        }
    </style>

</body>
