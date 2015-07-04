<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="pagina2.aspx.cs" Inherits="pagina2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p style="margin-bottom: 19px">
    REGISTRO DE NOTAS</p>
<p>
    &nbsp;</p>
<p>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" DataKeyNames="codigo">
        <Columns>
            <asp:BoundField DataField="codigo" HeaderText="codigo" SortExpression="codigo" ReadOnly="True" />
            <asp:BoundField DataField="nombre" HeaderText="nombre" SortExpression="nombre" />
            <asp:BoundField DataField="apellido" HeaderText="apellido" SortExpression="apellido" />
            <asp:BoundField DataField="DNI" HeaderText="DNI" SortExpression="DNI" />
            <asp:BoundField DataField="direccion" HeaderText="direccion" SortExpression="direccion" />
            <asp:BoundField DataField="telefono" HeaderText="telefono" SortExpression="telefono" />
            <asp:BoundField DataField="grado" HeaderText="grado" SortExpression="grado" />
            <asp:BoundField DataField="seccion" HeaderText="seccion" SortExpression="seccion" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [codigo], [nombre], [apellido], [DNI], [direccion], [telefono], [grado], [seccion] FROM [alumnos] ORDER BY [apellido]"></asp:SqlDataSource>
</p>
<p>
    &nbsp;</p>
</asp:Content>

