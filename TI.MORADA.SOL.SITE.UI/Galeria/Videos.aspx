<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Videos.aspx.cs" Inherits="TI.MORADA.SOL.SITE.UI.Galeria.Videos" %>

<!DOCTYPE html>

<html>
<head>

    <meta charset="utf-8">
    <link rel="icon" type="image/png" href="img/logo3.ico" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <title>Fotos Galeria do CEAR</title>

    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
    <link href="https://fonts.googleapis.com/css?family=Droid+Sans:400,700" rel="stylesheet">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/baguettebox.js/1.8.1/baguetteBox.min.css">
    <link rel="stylesheet" href="Forms/gallery-grid.css">
    <link href="gallery-grid.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">

        <div class="container">
            <div class="container gallery-container">

                <div class="tz-gallery">

                    <div class="modal-content">
                        <h4>&nbsp;
                             <asp:HyperLink ID="hlHome" runat="server" NavigateUrl="~/Index.aspx#Portifolios">Home</asp:HyperLink>
                        </h4>
                    </div>

                    <h1>
                        <asp:Label ID="lblGaleria" runat="server" Text="Galeria de Videos"></asp:Label>
                    </h1>

                    <hr />

                    <div align="center">
                        <div class="row">
                            <div id="root">
                                <asp:PlaceHolder ID="iframeVideos" runat="server" />
                            </div>
                        </div>
                    </div>

                    <hr />

                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="#">Voltar</asp:HyperLink>
                </div>
            </div>
        </div>

        <script src="https://cdnjs.cloudflare.com/ajax/libs/baguettebox.js/1.8.1/baguetteBox.min.js"></script>
<%--        <script>
            baguetteBox.run('.tz-gallery');
    </script>--%>
    </form>
</body>
</html>
