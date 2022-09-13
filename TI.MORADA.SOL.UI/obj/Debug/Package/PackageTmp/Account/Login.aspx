<%@ Page Title="Log in" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TI.MORADA.SOL.UI.Account.Login" Async="true" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">

    <h2><%: Title %>.</h2>

    <div class="row">
        <div class="col-md-8">
            <section id="loginForm">
                <div class="form-horizontal">

                    <h4>Use uma conta local para fazer login.</h4>
                    <hr />
                    <asp:PlaceHolder runat="server" ID="ErrorMessage" Visible="false">
                        <p class="text-danger">
                            <asp:Literal runat="server" ID="FailureText" />
                        </p>
                    </asp:PlaceHolder>
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="Email" CssClass="col-md-2 control-label">Email</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="Email" CssClass="form-control" TextMode="Email" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="Email"
                                CssClass="text-danger" ErrorMessage="The email field is required." />
                        </div>
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="Password" CssClass="col-md-2 control-label">Password</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="Password" TextMode="Password" CssClass="form-control" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="Password" CssClass="text-danger" ErrorMessage="The password field is required." />
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-md-offset-2 col-md-10">
                            <div class="checkbox">
                                <asp:CheckBox runat="server" ID="RememberMe" />
                                <asp:Label runat="server" AssociatedControlID="RememberMe">Remember me?</asp:Label>
                            </div>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-md-offset-2 col-md-10">
                            <asp:Button runat="server" OnClick="LogIn" Text="Log in" CssClass="btn btn-default" />
                        </div>
                    </div>

                    <div class="form-group">
                        <div class="col-lg-2 ">
                            <%--       <asp:LinkButton ID="LinkButton1" CssClass="hotpink" runat="server" OnClick="LinkButton1_Click">Voltar Página</asp:LinkButton>--%>
                            <input type="button" value="« voltar pagina" onclick="goBack()" style="display: inline-block; padding: 6px 12px; margin-bottom: 0; font-size: 14px; font-weight: normal; line-height: 1.428571429 text-align: center; white-space: nowrap; vertical-align: middle; cursor: pointer; border: 1px solid transparent; border-radius: 4px; -webkit-user-select: none; -moz-user-select: none; -ms-user-select: none; -o-user-select: none; user-select: none;" />
                        </div>
                    </div>

                    <div class="form-group">
                        <div class="col-md-offset-2 col-md-10">
                            <b>
                                <asp:Label ID="lblLogin" CssClass="text-success" runat="server" Text="OPERADOR(A): ..."></asp:Label>
                            </b>
                        </div>
                    </div>

                </div>

            </section>

            <script>
                function goBack() {
                    window.history.back()
                }
            </script>
        </div>
    </div>
</asp:Content>
