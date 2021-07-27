<%@ Page Title="" Language="C#" MasterPageFile="~/PanelUsuario/PaginaMaestraUsuario.Master" AutoEventWireup="true" CodeBehind="MensajesUsuario.aspx.cs" Inherits="reciclemos_v3.PanelUsuario.MensajesUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="https://maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css" rel="stylesheet">
    <link href="../Resources/estilos.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h4 class="text-center fs-4 py-5">Mensajes</h4>
    <div class="container bg-light">


        <div class="container">

            <!-- Page header start -->
            <div class="page-title">
                <div class="row gutters">
                    <div class="col-xl-6 col-lg-6 col-md-6 col-sm-12 col-12">
                        <h5 class="title">Chat</h5>
                    </div>
                    <div class="col-xl-6 col-lg-6 col-md-6 col-sm-12 col-12"></div>
                </div>
            </div>
            <!-- Page header end -->

            <!-- Content wrapper start -->
            <div class="content-wrapper">

                <!-- Row start -->
                <div class="row gutters">

                    <div class="col-xl-12 col-lg-12 col-md-12 col-sm-12 col-12">

                        <div class="card m-0">

                            <!-- Row start -->
                            <div class="row no-gutters">

                                <div class="col-xl-8 col-lg-8 col-md-8 col-sm-9 col-9">
                                    <div class="selected-user">
                                        <span>Para:
                                            <asp:Label ID="LblUsuario" runat="server" Text="" CssClass="name"></asp:Label></span>
                                    </div>
                                    <div class="chat-container">
                                        <ul class="chat-box chatContainerScroll">
                                            <li class="chat-left">
                                                <div class="chat-avatar">
                                                    <img src="https://www.bootdey.com/img/Content/avatar/avatar3.png" alt="Retail Admin">
                                                    <div class="chat-name">
                                                        <asp:Label ID="LblUser" runat="server" Text=""></asp:Label>
                                                    </div>
                                                </div>
                                                <div class="chat-text">
                                                    <asp:Label ID="LblMensajeUsu" runat="server" Text=""></asp:Label>
                                                </div>
                                                <div class="chat-hour">
                                                    <asp:Label ID="LblHr1" runat="server" Text=""></asp:Label><span class="fa fa-check-circle"></span></div>
                                            </li>
                                            <li class="chat-right">
                                                <div class="chat-hour"><asp:Label ID="Lblhr2" runat="server" Text=""></asp:Label><span class="fa fa-check-circle"></span></div>
                                                <div class="chat-text">
                                                    <asp:Label ID="LblMensajeEmp" runat="server" Text=""></asp:Label>
                                                </div>
                                                <div class="chat-avatar">
                                                    <img src="../Resources/Imagenes/RE2.png" alt="Retail Admin">
                                                    <div class="chat-name">Re-Ciclemos</div>
                                                </div>
                                            </li>
                                        </ul>
                                        <div class="form-group mt-3 mb-0 pb-3">
                                            <asp:TextBox ID="TxtMensaje" runat="server" TextMode="MultiLine" CssClass="form-control" rows="4" placeholder="Ingrese su mensaje aquí..."></asp:TextBox>
                                        </div>
                                        <div class="">
                                            <asp:Button ID="BtnEnviar" runat="server" Text="Enviar Mensaje" CssClass="btn btn-primary" OnClick="BtnEnviar_Click"/>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
