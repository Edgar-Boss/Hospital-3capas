<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Doctores.aspx.cs" Inherits="Hosp.Catalogos.Doctores.Doctores" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <div class="row">
            <asp:Label ID="titulo" runat="server" CssClass="text-center modal-tittle" Text=""></asp:Label>
            <asp:Label ID="Subtitulo" runat="server" CssClass="text-center modal-tittle" Text=""></asp:Label>

        </div>
        <div class="row">
            <div class="col-md-12">
                <div class="form-grup">
                    <asp:Label ID="lblnombre" runat="server" Text="">Nombre</asp:Label>
                    <asp:TextBox ID="txtnombre" runat="server" CssClass="form-control"></asp:TextBox>

                    <asp:Label ID="lblapaterno" runat="server" Text="">Apellido paterno</asp:Label>
                    <asp:TextBox ID="txtapaterno" runat="server" CssClass="form-control"></asp:TextBox>

                    <asp:Label ID="lblamaterno" runat="server" Text="">Apellido Materno</asp:Label>
                    <asp:TextBox ID="txtamaterno" runat="server" CssClass="form-control"></asp:TextBox>

                    <asp:Label ID="lbledad" runat="server" Text="">Edad</asp:Label>
                    <asp:TextBox ID="txtedad" runat="server" CssClass="form-control"></asp:TextBox>

                    <asp:Label ID="lbltelefono" runat="server" Text="">TElefono</asp:Label>
                    <asp:TextBox ID="txttelefono" runat="server" CssClass="form-control"></asp:TextBox>

                    <asp:Label ID="lblurlfoto" runat="server" Text="">URL Foto</asp:Label>
                    <asp:TextBox ID="txturlfoto" runat="server" CssClass="form-control"></asp:TextBox>

                    <asp:Label ID="lblconsultorioid" runat="server" Text="">Id Consultorio</asp:Label>
                    <asp:TextBox ID="txtconsultorioid" runat ="server" CssClass="form-control"></asp:TextBox>

                   <asp:Button ID="btnguardar" CssClass="btn btn-primary" runat="server" Text="Guardar" OnClick="btnguardar_Click"></asp:Button>
                    

                </div>
            </div>

        </div>
    </div>

</asp:Content>
