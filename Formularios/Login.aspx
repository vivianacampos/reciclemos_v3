<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="reciclemos_v3.Formularios.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Login</title>
    <link href="../Resources/Font-awesome/css/all.min.css" rel="stylesheet" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous" />
</head>
<body>
    <!--Estilos-->
    <style>
        .padd {
            padding-top: 1rem;
            padding-bottom: 0.2rem;
            border: none;
        }

        .colorNav {
            background-color: #4b778d;
        }

        .colorFooter {
            background-color: #8fd9a8;
        }

        .alignParr {
            align-items: center;
            font-weight: bold;
            letter-spacing: 4px;
        }
    </style>
    <!--Navbar-->
    <nav class="navbar navbar-expand-lg navbar-dark bg-dark">
        <div class="d-flex justify-content-start px-3">
            <a class="navbar-brand" href="index.html">
                <img src="../Resources/Imagenes/reciclemos_sin_bordes.png" width="180" height="41" /></a>
        </div>
        <div class="navbar-collapse d-flex justify-content-start px-5">
            <ul class="navbar-nav ">
                <li class="nav-item">
                    <a class="nav-link active" href="#">Inicio</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link active" href="#">Nosotros</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link active" href="#">Enlaces</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link active" href="#">Materiales</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link active" href="#">Talleres</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link active" href="Contacto.aspx">Contacto</a>
                </li>
            </ul>
        </div>
        <div class="navbar-collapse d-flex justify-content-end px-5">
            <ul class="navbar-nav">
                <li class="nav-item">
                    <a class="nav-link active" href="Login.aspx"><i class="fas fa-user"></i></a>
                </li>
                <li class="nav-item ">
                    <a class="nav-link active" href="Login.aspx">Ingresar</a>
                </li>
            </ul>
        </div>
    </nav>
    <div class="container pt-5">
        <div class="row">
            <div class="col-xs-6 pt-5">
                <h2>Inicio de Sesión</h2>
            </div>
        </div>
        <form id="form1" runat="server" class="form-horizontal">
            <div class="row pt-5">
                <div class="col-5">
                    <%--Cuenta--%>
                    <div class="form-floating padd">
                        <asp:Label ID="LblCorreo" runat="server" Text="Correo: " CssClass="control-label col-sm-2"></asp:Label>
                        <div class="col-sm-12">
                            <asp:TextBox ID="TxtCorreo" runat="server" CssClass="form-control" placeholder="correo@dominio.cl"></asp:TextBox>
                        </div>
                    </div>
                    <%--Contraseña--%>
                    <div class="form-floating padd">
                        <asp:Label ID="LblContrasena" runat="server" Text="Contraseña: " CssClass="control-label col-sm-2"></asp:Label>
                        <div class="col-sm-12">
                            <asp:TextBox ID="TxtContrasena" runat="server" CssClass="form-control" type="password" placeholder="**********"></asp:TextBox>
                        </div>
                    </div>
                    <div class="text-center">
                        <asp:Label ID="LblMensaje" runat="server" ForeColor="Red" CssClass="fs-1"></asp:Label>
                    </div>
                    <%--Boton--%>
                    <div class="form-floating padd">
                        <div class="col padd largo text-center" style="text-align: left">
                            <asp:Button ID="BtnIngresar" runat="server" Text="Ingresar" CssClass="form-control btn btn-primary" Style="margin-left: 42" Width="242px" OnClick="BtnIngresar_Click" />
                        </div>
                    </div>
                    <div class="text-center">
                        <asp:HyperLink ID="HlRegistrar" runat="server" href="RegistroUsuario.aspx">Registrarse</asp:HyperLink>
                    </div>
                </div>
            </div>
        </form>
    </div>
</body>
</html>
