<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="Vehiculos.aspx.cs" Inherits="Examen3.Vehiculos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <br />
    <asp:Label ID="Label1" CssClass="label" runat="server" Text="Numero de Placa "></asp:Label>
    <asp:TextBox ID="TextPlaca" CssClass="textbox" runat="server"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label5" CssClass="label" runat="server" Text="Nueva Placa: "></asp:Label>
    <asp:TextBox ID="TextNuevo" CssClass="textbox"  runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label2" CssClass="label" runat="server" Text="idUsuario"></asp:Label>
    <asp:DropDownList ID="DDLUser" CssClass="dropdown" DataTextField="Usuario" DataValueField="idUsuario" runat="server"></asp:DropDownList>
    <br />
    <asp:Label ID="Label3" CssClass="label" runat="server" Text="Monto"></asp:Label>
    <asp:TextBox ID="TextMonto" CssClass="textbox" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="agregar" CssClass="boton" runat="server" Text="Agregar" OnClick="agregar_Click" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="borrar" CssClass="boton" runat="server" Text="Borrar" OnClick="borrar_Click" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="actualizar" CssClass="boton" runat="server" Text="Actualizar" OnClick="actualizar_Click" />
    <br />
    <asp:Label ID="Label4" CssClass="label" runat="server" Text=""></asp:Label>
</asp:Content>
