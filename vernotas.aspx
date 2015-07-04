<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="vernotas.aspx.cs" Inherits="Account_vernotas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    </p>
    <p>
        <br />
    </p>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="Horizontal">
                <Columns>
                    <asp:BoundField DataField="NombreCurso" HeaderText="NombreCurso" SortExpression="NombreCurso" />
                    <asp:BoundField DataField="cod_alumno" HeaderText="cod_alumno" SortExpression="cod_alumno" />
                    <asp:BoundField DataField="Nota1" HeaderText="Nota1" SortExpression="Nota1" />
                    <asp:BoundField DataField="Nota2" HeaderText="Nota2" SortExpression="Nota2" />
                    <asp:BoundField DataField="Nota3" HeaderText="Nota3" SortExpression="Nota3" />
                    <asp:BoundField DataField="promedio" HeaderText="promedio" SortExpression="promedio" />
                </Columns>
                <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F7F7F7" />
                <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                <SortedDescendingCellStyle BackColor="#E5E5E5" />
                <SortedDescendingHeaderStyle BackColor="#242121" />
            </asp:GridView>
        </ContentTemplate>
    </asp:UpdatePanel>
    <p>
        ingrese el codigo del alumno del cual desea ver sus notas</p>
    <p>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    </p>
    <p>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [NombreCurso], [cod_alumno], [Nota1], [Nota2], [Nota3], [promedio] FROM [Curss] WHERE ([cod_alumno] = @cod_alumno)">
            <SelectParameters>
                <asp:ControlParameter ControlID="TextBox1" Name="cod_alumno" PropertyName="Text" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
    </p>
    <p>
        &nbsp;</p>
    <p>
    </p>
</asp:Content>

