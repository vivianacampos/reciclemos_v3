<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistroUsuario.aspx.cs" Inherits="reciclemos_v3.Formularios.RegistroUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Registro de Usuarios</title>
    <link href="../Resources/Font-awesome/css/all.min.css" rel="stylesheet" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous" />
</head>
<body>
    <!--Estilos-->
    <style>
        .padd {
            padding-top: 0.8rem;
            padding-bottom: 0.2rem;
            padding-left: 8rem;
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
    <div class="container pb-5">
        <div class="text-center">
            <h3 class="text-center pt-5">Formulario de Registro</h3>
        </div>
        <form id="form1" runat="server">
            <asp:Label ID="LblMensaje" runat="server" ForeColor="Red"></asp:Label>

            <div class="row justify-content-center">
                <div class="col-10 padd">
                    <asp:Label ID="LblRut" runat="server" Text="Rut" CssClass="col-sm-6"></asp:Label>
                </div>
                <div class="col-sm-8">
                    <asp:TextBox ID="TxtRut" runat="server" CssClass="form-control" placeholder="12345678-9"></asp:TextBox>
                    <div class="col-3">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Rut Obligatorio" ControlToValidate="TxtRut" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Formato de rut inválido" Display="Dynamic" ForeColor="Red" ControlToValidate="TxtRut" ValidationExpression="^\d{1,2}\d{3}\d{3}[-][0-9kK]{1}$"></asp:RegularExpressionValidator>
                    </div>
                </div>

                <div class="col-10 padd">
                    <asp:Label ID="LblNombre" runat="server" Text="Nombre" CssClass="col-sm-6"></asp:Label>
                </div>
                <div class="col-sm-8">
                    <asp:TextBox ID="TxtNombre" runat="server" CssClass="form-control" TextMode="SingleLine" placeholder="Maria"></asp:TextBox>
                    <div class="col-3">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TxtNombre" ErrorMessage="Nombre Obligatorio" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="col-10 padd">
                    <asp:Label ID="LblApellido" runat="server" Text="Apellido" CssClass="col-sm-6"></asp:Label>
                </div>
                <div class="col-sm-8">
                    <asp:TextBox ID="TxtApellido" runat="server" CssClass="form-control" TextMode="SingleLine" placeholder="Posada"></asp:TextBox>
                    <div class="col-3">
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TxtApellido" Display="Dynamic" ErrorMessage="Apellido Obligatorio" ForeColor="Red"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="col-10 padd">
                    <asp:Label ID="LblCorreo" runat="server" Text="Correo" CssClass="col-sm-6"></asp:Label>
                </div>
                <div class="col-sm-8">
                    <asp:TextBox ID="TxtCorreo" runat="server" CssClass="form-control" placeholder="correo@dominio.cl" TextMode="Email"></asp:TextBox>
                    <div class="col-3">
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TxtCorreo" ErrorMessage="Correo Obligatorio" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator10" runat="server" ControlToValidate="TxtCorreo" ErrorMessage="Formato de correo inválido" ForeColor="Red" Display="Dynamic" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="col-10 padd">
                    <asp:Label ID="LblTelefono" runat="server" Text="Teléfono" CssClass="col-sm-6"></asp:Label>
                </div>
                <div class="col-sm-8">
                    <asp:TextBox ID="TxtTelefono" runat="server" CssClass="form-control" placeholder="912345678" TextMode="Phone"></asp:TextBox>
                    <div class="col-3">
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TxtTelefono" Display="Dynamic" ErrorMessage="Teléfono Obligatorio" ForeColor="Red"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="col-10 padd">
                    <asp:Label ID="LblDireccion" runat="server" Text="Dirección" CssClass="col-sm-6"></asp:Label>
                </div>
                <div class="col-sm-8">
                    <asp:TextBox ID="TxtDireccion" runat="server" CssClass="form-control" placeholder="Av. Los Plátanos 555"></asp:TextBox>
                    <div class="col-3">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" Display="Dynamic" ControlToValidate="TxtDireccion" ErrorMessage="Dirección Obligatoria" ForeColor="Red"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="col-10 padd">
                    <asp:Label ID="LblComuna" runat="server" Text="Comuna" CssClass="col-sm-6"></asp:Label>
                </div>
                <div class="col-sm-8">
                    <asp:DropDownList ID="DdlComunas" runat="server" CssClass="form-control">
                        <asp:ListItem Selected="True" Value="888">Seleccione Comuna</asp:ListItem>
                        <asp:ListItem Value="126">San Ramon</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="col-10 padd">
                    <asp:Label ID="LblContrasena" runat="server" Text="Contraseña" CssClass="col-sm-6"></asp:Label>
                </div>
                <div class="col-sm-8">
                    <asp:TextBox ID="TxtContrasena" runat="server" CssClass="form-control" placeholder="Letras ° Números ° mínimo 8 caracteres" TextMode="Password"></asp:TextBox>
                    <div class="col-3">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" Display="Dynamic" ControlToValidate="TxtContrasena" ErrorMessage="Contraseña Obligatoria" ForeColor="Red"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="TxtContrasena" ErrorMessage="La contraseña debe tener entre 8 y 16 caracteres, al menos un dígito, al menos una minúscula y al menos una mayúscula." Display="Dynamic" ValidationExpression="^(?=\w*\d)(?=\w*[A-Z])(?=\w*[a-z])\S{8,16}$" ForeColor="Red"></asp:RegularExpressionValidator>
                            <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToValidate="TxtContrasena" ErrorMessage="Contraseñas no coinciden" Display="Dynamic" ControlToCompare="TxtConfirma" ForeColor="Red"></asp:CompareValidator>
                    </div>
                </div>
                <div class="col-10 padd">
                    <asp:Label ID="LblConfirma" runat="server" Text="Confirme contraseña" CssClass="col-sm-6"></asp:Label>
                </div>
                <div class="col-sm-8">
                    <asp:TextBox ID="TxtConfirma" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                </div>
                <div class="col-sm-8">
                    <div class="row">
                        <div class="col-9">
                            <asp:CheckBox ID="ChbCondiciones" runat="server" CausesValidation="True" />
                            <asp:HyperLink ID="HlCondiciones" runat="server" href="../Vista/Condiciones.html" Target="_blank">Aceptar términos y condiciones</asp:HyperLink>
                        </div>
                        <div class="col-9">
                            <asp:Label ID="LblCondiciones" runat="server" ForeColor="Red"></asp:Label>
                        </div>
                    </div>
                </div>
                <div class="col-sm-8 text-center pt-3">
                    <asp:Button ID="BtnRegistrar" runat="server" Text="Registrar" CssClass="btn btn-success" Width="300" OnClick="BtnRegistrar_Click" />
                </div>

            </div>
        </form>
    </div>

    <footer class="colorFooter p-2">
        <p class="text-center alignParr">
            <img src="../Resources/Imagenes/RE2.png" width="50" height="50" />
            Re-Ciclemos  &copy;
        </p>
    </footer>
</body>
</html>
