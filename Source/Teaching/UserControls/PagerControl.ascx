<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PagerControl.ascx.cs"
    Inherits="Hrbu.Teaching.WebUI.UserControls.PagerControl" %>
<asp:LinkButton ID="lbtnFirstPage" runat="server" Text="第一页" OnClick="lbtnFirstPage_Click" />
<asp:LinkButton runat="server" ID="lbtnPreviousPage" Enabled="false" Text="上一页" OnClick="lbtnPreviousPage_Click" />
<asp:LinkButton ID="lbtnNextPage" runat="server" Text="下一页" OnClick="lbtnNextPage_Click" />
<asp:LinkButton ID="lbtnLastPage" runat="server" Text="最后一页" OnClick="lbtnLastPage_Click" />
<span class="search_area">
    <asp:TextBox ID="txtInputPage" runat="server" Text="1"></asp:TextBox>
</span>
<asp:LinkButton ID="lbtnGoto" runat="server" Text="跳转" OnClick="lbtnGoto_Click" />
<span class="currentPage">
    <asp:Label ID="lblCurrentPage" CssClass="page_index" runat="server" Text="0"></asp:Label>
    /
    <asp:Label ID="lblAllPages" runat="server" Text="0"></asp:Label>
</span>