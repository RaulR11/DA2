<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="pagina4.aspx.cs" Inherits="pagina4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   

     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; REGISTRO DE ALUMNOS<br />
<br />
   

     <br />
     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
     <asp:Label ID="Label4" runat="server" Text="Nombres:"></asp:Label>
     &nbsp;&nbsp;&nbsp;
       <asp:TextBox ID="TextBoxNonbre" runat="server" Width="213px" OnTextChanged="TextBoxNonbre_TextChanged"></asp:TextBox>
     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="codigo" runat="server" Text="codigo"></asp:Label>
     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="Textcodigo" runat="server" OnTextChanged="Textcodigo_TextChanged"></asp:TextBox>
     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
     <br />   
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;   
<asp:Label ID="Label6" runat="server" Text="Apellidos: "></asp:Label>
&nbsp;&nbsp;
       <asp:TextBox ID="TextBoxApellido" runat="server" Width="210px" OnTextChanged="TextBoxApellido_TextChanged"></asp:TextBox>
<br />
     <br />
     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
     <asp:Label ID="Label7" runat="server" Text="D.N.I.:"></asp:Label>
     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       <asp:TextBox ID="TextBoxDNI" runat="server" Width="210px"></asp:TextBox>
     <br />
       <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Label ID="Label13" runat="server" Text="Dirección"></asp:Label>
&nbsp;&nbsp;&nbsp;
<asp:TextBox ID="TextBoxDireccion" runat="server" Width="211px" OnTextChanged="TextBoxDireccion_TextChanged"></asp:TextBox>
<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Label ID="Label15" runat="server" Text="Telefono"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:TextBox ID="TextBoxFono" runat="server" Width="204px"></asp:TextBox>
     <asp:Label ID="lblResult" runat="server" Text="Label"></asp:Label>
<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Label ID="Label14" runat="server" Text="Fecha de nacimiento"></asp:Label>
&nbsp;
<asp:TextBox ID="TextBoxFecNac" runat="server" Width="150px"></asp:TextBox>
<br />
       <br />
     <asp:FileUpload ID="FileUploadFoto" runat="server" />
     <br />
     <br />
     <asp:Button ID="Button2" runat="server" Height="47px" OnClick="Button2_Click" Text="mostrar todos" Width="204px" />
     <br />
     <br />
     <asp:Button ID="ButtonCargar" runat="server" OnClick="ButtonCargar_Click" Text="Cargar" />
     <br />
     <br />
     <asp:HyperLink ID="HyperLink1" runat="server">HyperLink</asp:HyperLink>
     <br />
       <br />
       &nbsp;&nbsp;&nbsp;
       <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged" RepeatDirection="Horizontal">
           <asp:ListItem Value="0">Primaria</asp:ListItem>
           <asp:ListItem Value="1">Secundaria</asp:ListItem>
       </asp:RadioButtonList>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:MultiView ID="MultiView1" runat="server">
        <asp:View ID="View1" runat="server">
            <asp:Label ID="Label1" runat="server" Text="Año"></asp:Label>
            &nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged1">
            </asp:DropDownList>
            <br />
            <br />
            <br />
            <asp:Label ID="Label11" runat="server" Text="Sección"></asp:Label>
            &nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="True">
            </asp:DropDownList>
            <br />
        </asp:View>
        <asp:View ID="View2" runat="server">
            <asp:Label ID="Label8" runat="server" Text="Año"></asp:Label>
            &nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList2" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            <br />
            <asp:Label ID="Label12" runat="server" Text="Sección"></asp:Label>
            &nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList4" runat="server" AutoPostBack="True">
            </asp:DropDownList>
            <br />
        </asp:View>
    </asp:MultiView>
    <br />
       <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Aceptar" />
       <br />
       <br />
       <asp:Label ID="Label10" runat="server"></asp:Label>
       <br />
     <br />
     <asp:GridView ID="GridView1" runat="server">
     </asp:GridView>
     <br />
     <br />
     <br />
       <br />
    <br />


</asp:Content>

