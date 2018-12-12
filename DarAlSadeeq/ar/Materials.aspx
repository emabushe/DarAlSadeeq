<%@ Page Title="" Language="VB" MasterPageFile="~/ar/MasterPage.master" AutoEventWireup="false" CodeFile="Materials.aspx.vb" Inherits="ar_Materials" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="block-main no-margin" onclick="prevFrame()" style="position: absolute;">
        <span>القصص</span>
    </div>
    <div class="content-inner">
        <div class="classes-container" style="height: 110px;" id="divLevels" runat="server">
              <asp:Repeater ID="RptClasses" runat="server" DataSourceID="SqlDataSourceibClasses">
                                    <ItemTemplate>
                                        <div class='<%# Eval("CSSClass")%>' onclick="appendURL('level=<%# Eval("LevelID")%>')">
                                            <span id="eBooksTab">
                                                <%# Eval("LevelTitleAR")%></span></div>
                                    </ItemTemplate>
                                </asp:Repeater>
                                <asp:SqlDataSource ID="SqlDataSourceibClasses" runat="server" ConnectionString="<%$ ConnectionStrings:Dar_AlsadiqConnectionString %>"
                                    SelectCommand="SELECT * FROM [tbl_Levels] ORDER BY [LevelID]"></asp:SqlDataSource>
        </div>
        <div style="background-image: url(../../images/arrow_down.png); width: 50px; height: 50px; margin-left: 50%; margin-top: 5px; margin-bottom: 5px;">
        </div>
        <div class="classes-container" style="height: 110px;">
            <div style="margin-right: 25%">
                <div class="block-classes blockStories" onclick="viewSubjects();return ClickServerSide(1);" style="margin-right: 10px;">
                    <span>القصص</span>
                </div>
                <div class="block-classes blockActivities" onclick="viewSubjects();return ClickServerSide(2);">
                    <span>قصص وتمارين</span>
                </div>
            </div>
        </div>
        <div style="background-image: url(../../images/arrow_down.png); width: 50px; height: 50px; margin-left: 50%; margin-top: 5px; margin-bottom: 5px;">
        </div>
        <div class="classes-container" style="background: url(../../images/Bookshelf.png); width: 85%; margin: 0% 7% 0% 7%;">
            <asp:Repeater ID="RepeateribBooks" runat="server">
                <ItemTemplate>
                    <div style="float: right; width: 180px; padding: 5px; text-align: center; padding-top: 24px;">
                        <table width="180px">
                            <tr>
                                <td style="text-align: center">
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

