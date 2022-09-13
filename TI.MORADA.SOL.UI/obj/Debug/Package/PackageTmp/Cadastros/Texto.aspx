<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Texto.aspx.cs" Inherits="TI.MORADA.SOL.UI.Cadastros.Texto" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<link href="../Content/bootstrap.css" rel="stylesheet" />
<link href="../Content/bootstrap.min.css" rel="stylesheet" />
<html lang="en">

<div class="container">
    <head runat="server">
        <script language="Javascript">

            function teste() {

                var descricao = editor.document.body.innerHTML;
                alert(descricao);
                txt1.value = descricao;
            }
        </script>

        <script language="JavaScript">

            function Iniciar() {

                editor.document.designMode = 'On';

            }

            function recortar() {

                editor.document.execCommand('cut', false, null);

            }

            function copiar() {

                editor.document.execCommand('copy', false, null);

            }

            function colar() {

                editor.document.execCommand('paste', false, null);

            }

            function desfazer() {

                editor.document.execCommand('undo', false, null);

            }

            function refazer() {

                editor.document.execCommand('redo', false, null);

            }

            function negrito() {

                editor.document.execCommand('bold', false, null);

            }

            function italico() {

                editor.document.execCommand('italic', false, null);

            }

            function sublinhado() {

                editor.document.execCommand('underline', false, null);

            }

            function alinharEsquerda() {

                editor.document.execCommand('justifyleft', false, null);

            }

            function centralizado() {

                editor.document.execCommand('justifycenter', false, null);

            }

            function alinharDireita() {

                editor.document.execCommand('justifyright', false, null);

            }

            function numeracao() {

                editor.document.execCommand('insertorderedlist', false, null);

            }

            function marcadores() {

                editor.document.execCommand('insertunorderedlist', false, null);

            }

            function fonte(fonte) {

                if (fonte != '')

                    editor.document.execCommand('fontname', false, fonte);

            }

            function tamanho(tamanho) {

                if (tamanho != '')

                    editor.document.execCommand('fontsize', false, tamanho);

            }

        </script>

    </head>

    <body onload="Iniciar()" bgcolor="#EFEDE1" style="text-align: center">

        <form id="form1" runat="server">
            &nbsp;<table align="center" width="600px" height="30px" border="0" cellspacing="0" cellpadding="0">

                <tr>

                    <td align="center">

                        <select name="fonte" onchange="fonte(this.options[this.selectedIndex].value)">

                            <option value=""></option>

                            <option value="Arial">Arial</option>

                            <option value="Courier">Courier</option>

                            <option value="Sans Serif">Sans Serif</option>

                            <option value="Tahoma">Tahoma</option>

                            <option value="Times New Roman">Times New Roman</option>

                            <option value="Verdana">Verdana</option>

                        </select>

                        &nbsp;

                    <select name="tamanho" onchange="tamanho(this.options[this.selectedIndex].value)">

                        <option value=""></option>

                        <option value="1">1</option>

                        <option value="2">2</option>

                        <option value="3">3</option>

                        <option value="4">4</option>

                        <option value="5">5</option>

                        <option value="6">6</option>

                    </select>

                    </td>

                    <td align="center">

                        <!-- Recortar -->

                        <img src="../imagens/recortar.gif" onclick="recortar()" style="cursor: hand" width="27" height="25">

                        <!-- Copiar -->

                        <img src="../imagens/copiar.gif" onclick="copiar()" style="cursor: hand" width="25" height="25">

                        <!-- Colar -->

                        <img src="../imagens/colar.gif" onclick="colar()" style="cursor: hand" width="25" height="25">

                        <!-- Desfazer -->

                        <img src="../imagens/desfazer.gif" onclick="desfazer()" style="cursor: hand" width="24" height="25">

                        <!-- Refazer -->

                        <img src="../imagens/refazer.gif" onclick="refazer()" style="cursor: hand" width="26" height="25">

                        <!-- Negrito -->

                        <img src="../imagens/negrito.gif" onclick="negrito()" style="cursor: hand" width="23" height="25">

                        <!-- Itálico -->

                        <img src="../imagens/italico.gif" onclick="italico()" style="cursor: hand" width="23" height="25">

                        <!-- Sublinhado -->

                        <img src="../imagens/sublinhado.gif" onclick="sublinhado()" style="cursor: hand" width="25" height="25">

                        <!-- Alinhar à Esquerda -->

                        <img src="../imagens/alinhamentoesquerda.gif" onclick="alinharEsquerda();" style="cursor: hand" width="24" height="25">

                        <!-- Alinhar ao Centro -->

                        <img src="../imagens/centralizado.gif" onclick="centralizado()" style="cursor: hand" width="24" height="25">

                        <!-- Alinha à Direita -->

                        <img src="../imagens/alinhamentodireita.gif" onclick="alinharDireita()" style="cursor: hand" width="26" height="25">

                        <!-- Numeração -->

                        <img src="../imagens/numeracao.gif" onclick="numeracao()" style="cursor: hand" width="26" height="25">

                        <!-- Marcadores -->

                        <img src="../imagens/marcador.gif" onclick="marcadores()" style="cursor: hand" width="24" height="25">
                    </td>

                </tr>

            </table>



            <iframe id="editor" frameborder="0"
                style="border: 1px solid; width: 582px; height: 350px" name="editor" runat="server"></iframe>

            <br>
            <br>

            <asp:Button ID="Button1" runat="server" Text="Button" OnClientClick="return teste()" /><br />

            &nbsp;

        <input id="txt1" name="txt1" type="text" runat="server" />

        </form>

    </body>

</div>

</html>

