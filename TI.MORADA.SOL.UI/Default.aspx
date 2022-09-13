<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TI.MORADA.SOL.UI._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="shadowBox">
        <div class="page-container">

            <div class="row">
                <div class="col-md-12">
                    <h3>A Empresa Morada do Sol Turismo, Eventos e Participações S/A</h3>
                    <h4>
                        <p>
                            A Empresa Morada do Sol Turismo, Eventos e Participações S/A é uma empresa Sociedade Anonima de Economia Mista, empresa publica de direito privado. Somos regidos pela Lei das Sociedades por Ações (Lei nº 6.404/1976) e pelo nosso Estatuto Social, onde estão descritas as atribuições da nossa Diretoria.<br />
                            A Prefeitura do município de Araraquara é detentora de 50,72% das ações sendo que as demais 49,28% das ações sao distribuídas entre diversos outros acionistas privados.
                       
                        </p>
                        <p>
                            Leis das Sociedades Anônimas:<a target="_blank" href="http://transparencia.moradaturismoeventos.com.br/Arquivos/PDFs/Lei/6404.pdf"> LEI Nº 6.404/76</a>, <a target="_blank" href="http://transparencia.moradaturismoeventos.com.br/Arquivos/PDFs/Lei/13303.pdf">LEI Nº 13.303/16</a>, <a target="_blank" href="http://transparencia.moradaturismoeventos.com.br/Arquivos/PDFs/Lei/1319.pdf">LEI: 1.319/64</a>.
                       
                        </p>
                        <p>
                            Decreto Nº 62.349/16<a target="_blank" href="http://transparencia.moradaturismoeventos.com.br/Arquivos/PDFs/Lei/62349.pdf"></a>
                        </p>
                    </h4>
                </div>

                <div class="col-md-6">
                    <h4>CEAR - Centro de Eventos de Araraquara e Região</h4>
                    <asp:Image ID="Image1" runat="server" Width="100%" src="http://transparencia.moradaturismoeventos.com.br/Arquivos/Imagem/Default/centro_internacional.jpg" alt="Responsive image" /><br />
                </div>

                <div class="col-md-4">
                    <h4>Contatos</h4>
                    <p>
                        Morada do Sol eventos e Participações S/A
               
                        <br />
                        Rua Ivo Antônio Magnani, 430
               
                        <br />
                        Araraquara-SP CEP-14802-634
               
                        <br />
                        Bairro: Fonte Luminosa
               
                        <br />
                        F: (16) 3335-8526
               
                        <br />
                        Atendimento: 09:00 as 17:00 Hs.<br />

                        <strong>E-Mail:</strong>
                        <a href="mailto:contato@cearararaquara.com.br">contato@cearararaquara.com.br</a><br />
                    </p>
                </div>

                <div class="col-md-2" style="cursor: pointer">
                    <h4>QR Code</h4>

                    <p>Site CEAR, Para ler esse código, você pode usar leitor QR ou alguns Apps da câmera do seu celular.</p>

                    <a href="http://cearararaquara.com.br/" target="_blank">
                        <asp:Image ID="Image2" runat="server" Width="100%" src="http://transparencia.moradaturismoeventos.com.br/Arquivos/Portifolios/QRCodeCear.jpg" alt="Responsive image" /><br />
                    </a>
                </div>
            </div>

            <hr />

            <div class="col-lg-10 ">
                <b>
                    <asp:Label ID="lblLogin" CssClass="text-success" runat="server" Text="OPERADOR(A): ..."></asp:Label>
                </b>
            </div>
        </div>
    </div>

</asp:Content>
