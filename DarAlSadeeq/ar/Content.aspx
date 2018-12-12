<%@ Page Title="" Language="C#" MasterPageFile="~/ar/MasterPage.master" AutoEventWireup="true" CodeBehind="Content.aspx.cs" Inherits="DarAlSadeeq.ar.Content" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="divTitle" runat="server" class="block-main no-margin" onclick="prevFrame()" style="position: absolute;">
        <asp:Label id="lblSectionTitle" runat="server">دار الصديق</asp:Label>
    </div>
    <div class="content-inner">
        <div class="classes-container" style="height: 110px;" id="divLevels" runat="server">
            <asp:Repeater ID="rptLevels" runat="server">
                <ItemTemplate>
                    <div class='<%# Eval("CSSClass")%>' onclick="appendURL('level=<%# Eval("LevelID")%>')">
                        <span id="eBooksTab">
                            <%# Eval("LevelTitleAR")%></span>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
        <div id="divArrow1" runat="server" style="background-image: url(../../images/arrow_down.png); width: 50px; height: 50px; margin-left: 50%; margin-top: 5px; margin-bottom: 5px;">
        </div>
        <div class="classes-container" id="divCategories" runat="server" style="height: 110px;">
            <div style="margin-right: 25%">
                <div class="block-classes blockStories" onclick="viewSubjects();return ClickServerSide(1);" style="margin-right: 10px;">
                    <span>القصص</span>
                </div>
                <div class="block-classes blockActivities" onclick="viewSubjects();return ClickServerSide(2);">
                    <span>قصص وتمارين</span>
                </div>
            </div>
        </div>
        <div id="divArrow2" runat="server" style="background-image: url(../../images/arrow_down.png); width: 50px; height: 50px; margin-left: 50%; margin-top: 5px; margin-bottom: 5px;">
        </div>
        <div class="classes-container" id="divContentList" runat="server" style="background: url(../../images/Bookshelf.png); width: 85%; margin: 0% 7% 0% 7%;">
            <asp:Repeater ID="rptContent" runat="server">
                <ItemTemplate>
                    <div style="float: right; width: 180px; padding: 5px; text-align: center; padding-top: 24px;">
                        <span class="tooltip tooltip-turnright"><span class="tooltip-item">
                            <table width="180px">
                                <tr>
                                    <td style="text-align: center">
                                        <asp:Image ID="imgCover" runat="server" ImageUrl='<%#Eval("CoverPic")%>' Style="width: 85%; height: 25%;" />
                                    </td>
                                </tr>
                                <tr>
                                    <td style="padding: 5px; text-align: center">
                                        <label style="font-size: large; color: rgb(196, 218, 172);"><%# Eval("ContentTitleAR")%></label>
                                    </td>
                                </tr>
                            </table>
                        </span>
                            <span class="tooltip-content"><%# Eval("Description")%></span>
                        </span>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
</asp:Content>
