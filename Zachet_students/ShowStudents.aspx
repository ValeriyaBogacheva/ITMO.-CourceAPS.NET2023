<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowStudents.aspx.cs" Inherits="students.ShowStudents" MasterPageFile="~/main.master" %>

<asp:Content ID="MainContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="students.SampleContext" EntityTypeName="" Select="new (FirstName, LastName, points, id, sumPoints)" TableName="_Students">
        </asp:LinqDataSource>
         &nbsp;
        <table style="width: 100%">
            <tr>
                <td><asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="LinqDataSource1" ForeColor="#333333" GridLines="None" Width="457px" Height="174px" HorizontalAlign="Left" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" style="margin-left: 0px" AutoGenerateSelectButton="True" ViewStateMode="Enabled" PageSize="5" >
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="id" HeaderText="ID" ReadOnly="True" SortExpression="id" />
            <asp:BoundField DataField="LastName" HeaderText="Фамилия" ReadOnly="True" SortExpression="LastName" />
            <asp:BoundField DataField="FirstName" HeaderText="Имя" ReadOnly="True" SortExpression="FirstName" />
            <asp:BoundField DataField="points" HeaderText="Баллы" ReadOnly="True" SortExpression="points" />
            <asp:BoundField DataField="sumPoints" HeaderText="Сумма" ReadOnly="True" SortExpression="sumPoints" />
        </Columns>
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerSettings PageButtonCount="1" Visible="False" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
                </td>
                <td>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="Black">Выберите студента</asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:RegularExpressionValidator runat="server" ControlToValidate="TextBox1"
            ValidationExpression="[0-9]+"
            ErrorMessage="Только цифры!" Display="Dynamic"
            ForeColor="Red">Только цифры!</asp:RegularExpressionValidator>
        

    <button type="submit">Выставить</button>
   
    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" Height="22px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="110px">
        <asp:ListItem>Обычный</asp:ListItem>
        <asp:ListItem>Лучшие</asp:ListItem>
        <asp:ListItem>Худшие</asp:ListItem>
    </asp:DropDownList>
                </td>
            </tr>
</table>
</asp:Content>

