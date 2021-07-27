<%@ Page Title="" Language="C#" MasterPageFile="~/PanelUsuario/PaginaMaestraUsuario.Master" AutoEventWireup="true" CodeBehind="MiCuentaUsuario.aspx.cs" Inherits="reciclemos_v3.PanelUsuario.MiCuentaUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .bor {
            border: none;
            text-align: start;
            padding-top: 1px;
        }
    </style>
    <div class="container pt-5 ">
        <h4>Mi Cuenta</h4>

        <div class="row">
            <div class="col-4 form-control bor">
                <asp:Label ID="LblRut" runat="server" Text="Rut" CssClass="bor"></asp:Label>
            </div>
            <div class="col-sm-5 py-1">
                <asp:TextBox ID="TxtRut" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
            </div>
            <div class="col-4 form-control bor">
                <asp:Label ID="LblNombre" runat="server" Text="Nombre"></asp:Label>
            </div>
            <div class="col-sm-5 py-1">
                <asp:TextBox ID="TxtNombre" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
            </div>
            <div class="col-4 form-control bor">
                <asp:Label ID="LblApellido" runat="server" Text="Apellido"></asp:Label>
            </div>
            <div class="col-sm-5 py-1">
                <asp:TextBox ID="TxtApellido" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
            </div>
            <div class="col-4 form-control bor">
                <asp:Label ID="LblCorreo" runat="server" Text="Correo"></asp:Label>
            </div>
            <div class="col-sm-5 py-1">
                <asp:TextBox ID="TxtCorreo" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
            </div>
            <div class="col-4 form-control bor">
                <asp:Label ID="LblTelefono" runat="server" Text="Teléfono"></asp:Label>
            </div>
            <div class="col-sm-5 py-1">
                <asp:TextBox ID="TxtTelefono" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
            </div>
            <div class="col-4 form-control bor">
                <asp:Label ID="LblDireccion" runat="server" Text="Dirección"></asp:Label>
            </div>
            <div class="col-sm-5 py-1">
                <asp:TextBox ID="TxtDireccion" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
            </div>
            <div class="col-4 form-control bor">
                <asp:Label ID="LblComuna" runat="server" Text="Comuna"></asp:Label>
            </div>
            <div class="col-sm-5 py-1">
                <asp:DropDownList ID="DdlComunas" runat="server" CssClass="form-control" Enabled="False">
                    <asp:ListItem Value="888">Seleccione Comuna</asp:ListItem>
                    <asp:ListItem Value="126">San Ramon</asp:ListItem>
                </asp:DropDownList>
            </div>
            <asp:LinkButton ID="LnkBContrasena" runat="server" OnClick="LnkBContrasena_Click">Modificar Contraseña</asp:LinkButton>

            <div class="col-sm-5 py-1">
                <asp:TextBox ID="TxtContrasena" runat="server" CssClass="form-control" Visible="false" placeholder="Ingrese su contrasena actual"></asp:TextBox>
            </div>
            <div class="col-4 form-control bor">
                <asp:Label ID="LblNuevaContrasena" runat="server" Text="Nueva Contraseña" Visible="false"></asp:Label>
            </div>
            <div class="col-sm-5 py-1">
                <asp:TextBox ID="TxtConfirma" runat="server" CssClass="form-control" Visible="false" placeholder="Ingrese su nueva contraseña"></asp:TextBox>
            </div>
            <div class="col-4 form-control bor">
                <asp:Label ID="LblConfCont" runat="server" Text="Confirme Nueva Constraseña" Visible="false"></asp:Label>
            </div>
            <div class="col-sm-5 py-1">
                <asp:TextBox ID="TxtVerifica" runat="server" CssClass="form-control" Visible="false" placeholder="Ingrese otra vez su nueva contraseña"></asp:TextBox>
            </div>
            <div class="col-12 form-control pt-3 bor text-center">
                <asp:Label ID="LblMensaje" runat="server" Text=""></asp:Label>
            </div>
            <!--Boton-->
            <div class="col-sm-5 py-1 text-center">
                <div class="flex-wrap px-4">
                    <asp:Button ID="BtnModificar" runat="server" Text="Modificar" CssClass="btn btn-success" Width="190px" OnClick="BtnModificar_Click" />
                </div>
            </div>
        </div>

    </div>
</asp:Content>
