<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="Reporte.aspx.cs" Inherits="Examen3.Reporte" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <br />
    <br />
    <asp:Label ID="Label1"  runat="server" Text="Numero de Placa"></asp:Label>
    <asp:DropDownList ID="DDLPlaca" CssClass="dropdown" DataTextField="NumPlaca" DataValueField="NumPlaca" runat="server"></asp:DropDownList>
    <br />
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" CssClass="boton" Text="Reporte" OnClick="Button1_Click" />
    <br />
    <br />
    
    <asp:GridView ID="GridView1" CssClass="mGrid"  runat="server"></asp:GridView>
</asp:Content>
