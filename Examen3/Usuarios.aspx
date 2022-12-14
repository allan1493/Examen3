<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="Examen3.Usuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <br />
    <br />
    <asp:Label ID="Label1" CssClass="label" runat="server" Text="Usuario"></asp:Label>
    <asp:TextBox ID="TextUsuario" CssClass="textbox" runat="server"></asp:TextBox>
    <asp:Label ID="Label2" CssClass="label" runat="server" Text="Clave"></asp:Label>
    <asp:TextBox ID="TextClave" CssClass="textbox" runat="server" TextMode="Password"></asp:TextBox>
    <asp:Label ID="Label3" CssClass="label" runat="server" Text="Nombre"></asp:Label>
    <asp:TextBox ID="TextNombre" CssClass="textbox" runat="server"></asp:TextBox>
    <asp:Label ID="Label4" CssClass="label" runat="server" Text="Apellido"></asp:Label>
    <asp:TextBox ID="TextApellido" CssClass="textbox" runat="server"></asp:TextBox>
    <br />
    <br />
    <br />
    <asp:Button ID="agregar" CssClass="boton" runat="server" Text="Agregar" OnClick="agregar_Click" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="borrar" CssClass="boton" runat="server" Text="Borrar" OnClick="borrar_Click" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
    <br />
    <br />
    <asp:Button ID="actualizar" CssClass="boton" runat="server" Text="Actualizar" OnClick="actualizar_Click" />
    <br />
    <br />
    <asp:Label ID="Label5" CssClass="label" runat="server" Text=""></asp:Label>
</asp:Content>

