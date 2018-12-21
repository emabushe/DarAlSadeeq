<%@ Page Title="" Language="C#" MasterPageFile="~/ar/MasterPage.master" AutoEventWireup="true" CodeBehind="Videos.aspx.cs" Inherits="DarAlSadeeq.ar.Videos" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="divTitle" runat="server" class="block-main block8 no-margin" onclick="prevFrame()" style="position: absolute;">
        <asp:Label ID="lblSectionTitle" runat="server">فيديوهات</asp:Label>
    </div>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="content-inner">
                <div id="subjectsContainer" class="subjectsContainer SongStories" style="display: block;">
                    <asp:Repeater ID="RepeaterItems" runat="server" DataSourceID="SqlDataSource1">
                        <ItemTemplate>
                            <div style="float: right; width: 180px; padding: 5px; text-align: center; padding-bottom: 25px;">
                                <table width="180px">
                                    <tr>
                                        <td align="center">
                                            <asp:ImageButton ID="ImgItem" runat="server" ImageUrl='<%#Eval("Pic")%>' Width="129"
                                                Height="79" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="padding: 5px; text-align: center">
                                            <asp:Label ID="lblTitle" runat="server" Text='<%#Eval("Title")%>' CssClass="songTitle"></asp:Label>
                                        </td>
                                    </tr>
                                </table>
                                <cc1:modalpopupextender id="ModalPopupExtender13" runat="server" targetcontrolid='ImgItem'
                                    popupcontrolid="Panel12" okcontrolid="" cancelcontrolid="ImgClose" backgroundcssclass="modalBackground"
                                    dynamicservicepath="" enabled="True" drag="True" />
                                <asp:Panel ID="Panel12" runat="server" Style="display: none; width: auto; background-color: White; border-width: 2px; border-color: Black; border-style: solid; padding: 5px; z-index: 10001; left: 457.5px; top: 143.5px;">
                                    <div style="text-align: right;">
                                        <asp:ImageButton ID="ImgClose" Text="Cancel" runat="server" ImageUrl="~/images/close.JPG" />
                                    </div>
                                    <div>
                                        <%# Eval("Src")%>
                                    </div>
                                </asp:Panel>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                     <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Dar_AlsadiqConnectionString %>"
        SelectCommand="SELECT * FROM [Songs]"></asp:SqlDataSource>
                </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
