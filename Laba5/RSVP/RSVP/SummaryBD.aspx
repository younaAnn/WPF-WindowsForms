<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SummaryBD.aspx.cs" Inherits="RSVP.SummaryBD" MasterPageFile="~/Site.master"%>
<asp:Content ID="MainContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Список участников<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="LinqDataSource1">
    <Columns>
        <asp:BoundField DataField="Name" HeaderText="Имя" SortExpression="Name" />
        <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
        <asp:BoundField DataField="Phone" HeaderText="Телефон" SortExpression="Phone" />
        <asp:BoundField DataField="Rdata" HeaderText="Дата регистарции" SortExpression="Rdata" DataFormatString="{0:d}" />
    </Columns>
    </asp:GridView>
    <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="RSVP.SampleContext" EntityTypeName="" Select="new (Name, Email, Phone, Rdata, Reports, WillAttend)" TableName="GuestResponses">
    </asp:LinqDataSource>
</h2>

 </asp:Content>


