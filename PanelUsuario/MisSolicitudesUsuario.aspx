<%@ Page Title="" Language="C#" MasterPageFile="~/PanelUsuario/PaginaMaestraUsuario.Master" AutoEventWireup="true" CodeBehind="MisSolicitudesUsuario.aspx.cs" Inherits="reciclemos_v3.PanelUsuario.MisSolicitudesUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container text-center pt-5">
        <asp:GridView ID="GrdVSolicitudes" runat="server" CssClass="table table-hover" AutoGenerateColumns="false">
            <columns>
                <asp:TemplateField HeaderText="Seleccionar">
                    <ItemTemplate>
                        <asp:CheckBox ID="chbItem" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="idSolicitud" HeaderText="Id" />
                <asp:BoundField DataField="estado" HeaderText="Estado" />
                <asp:BoundField DataField="material" HeaderText="Material" />
                <asp:BoundField DataField="cantidad" HeaderText="Cantidad" />
                <asp:BoundField DataField="fecha" HeaderText="Fecha" />
                <asp:BoundField DataField="horario" HeaderText="Horario" />
                <asp:BoundField DataField="descripcion" HeaderText="Descripción" />
            </columns>
            <headerstyle cssclass="table-primary" forecolor="Gray" />
        </asp:GridView>
    </div>

</asp:Content>
