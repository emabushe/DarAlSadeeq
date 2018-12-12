﻿<%@ Page Title="" Language="VB" MasterPageFile="~/ar/MasterPage.master" AutoEventWireup="false" CodeFile="OurProducts.aspx.vb" Inherits="ar_OurProducts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="block-main no-margin" onclick="prevFrame()" style="position: absolute;">
        <span>إنتجاتنا</span>
    </div>
    <div class="content-inner">
        <div class="classes-container" style="height: 110px;">
            <%--  <asp:Repeater ID="RptClasses" runat="server" DataSourceID="SqlDataSourceibClasses">
                                    <ItemTemplate>
                                        <div class='<%# Eval("ibClassStyle")%>' onclick="location.href='BooksShelf.aspx?ibClassID=<%# Eval("ibClassID")%>'">
                                            <span id="eBooksTab">
                                                <%# Eval("ibClassNameAr")%></span></div>
                                    </ItemTemplate>
                                </asp:Repeater>
                                <asp:SqlDataSource ID="SqlDataSourceibClasses" runat="server" ConnectionString="<%$ ConnectionStrings:Dar_AlsadiqConnectionString %>"
                                    SelectCommand="SELECT * FROM [ibClasses] ORDER BY [ibClassSeq]"></asp:SqlDataSource>--%>
        </div>
        <div class="classes-container" style="background: url(../../images/Bookshelf.png);">
            <asp:Repeater ID="RepeateribBooks" runat="server">
                <ItemTemplate>
                    <div style="float: right; width: 180px; padding: 5px; text-align: center; padding-top: 24px;">
                        <table width="180px">
                            <tr>
                                <td style="text-align:center">
                                    <asp:Image ID="ImgibBook" runat="server" ImageUrl='<%#Eval("ibBookIcon")%>' />
                                </td>
                            </tr>
                            <tr>
                                <td style="padding: 5px; text-align: center">
                                    <label style="font-size: large; color: rgb(196, 218, 172);"><%# Eval("ibBookNameAR")%></label>
                                </td>
                            </tr>
                        </table>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
</asp:Content>

