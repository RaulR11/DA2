<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="cursos.aspx.cs" Inherits="cursos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    </p>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <p>
                CONTROL DE CURSOS</p>
            <p>
                Ingrese el codigo del alumno
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </p>
            <p style="margin-left: 40px">
                SELECCIONE&nbsp; NOMBRE DEL CURSO<asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem>MATEMATICA</asp:ListItem>
                    <asp:ListItem>COMUNICACION</asp:ListItem>
                    <asp:ListItem>INGLES</asp:ListItem>
                    <asp:ListItem>CTA</asp:ListItem>
                    <asp:ListItem>RELIGION</asp:ListItem>
                    <asp:ListItem>EDUCACION FISICA</asp:ListItem>
                    <asp:ListItem>PFRH</asp:ListItem>
                    <asp:ListItem>CIVICA</asp:ListItem>
                    <asp:ListItem>TALLER</asp:ListItem>
                    <asp:ListItem>FRANCES</asp:ListItem>
                    <asp:ListItem>ITALIANO</asp:ListItem>
                    <asp:ListItem>ALGEBRA</asp:ListItem>
                </asp:DropDownList>
            </p>
            <p>
                NOTA 1<asp:TextBox ID="TextBox3" runat="server" Height="22px" Width="133px"></asp:TextBox>
            </p>
            <p>
                NOTA 2<asp:TextBox ID="TextBox4" runat="server" Height="22px" Width="133px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button1" runat="server" Height="44px" Text="INGRESAR" Width="106px" OnClick="Button1_Click" />
                PROMEDIO --&gt;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label16" runat="server" Text="Label"></asp:Label>
            </p>
            <p>
                NOTA 3<asp:TextBox ID="TextBox5" runat="server" Height="22px" Width="133px"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="lblResult" runat="server" Text="Label"></asp:Label>
            </p>
        </ContentTemplate>
    </asp:UpdatePanel>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </p>
<p>
</p>
</asp:Content>

