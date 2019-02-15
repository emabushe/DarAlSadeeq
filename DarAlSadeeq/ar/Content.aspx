<%@ Page Title="" Language="C#" MasterPageFile="~/ar/MasterPage.master" AutoEventWireup="true" CodeBehind="Content.aspx.cs" Inherits="DarAlSadeeq.ar.Content" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="divTitle" runat="server" class="block-main no-margin" onclick="prevFrame()" style="position: absolute;">
        <asp:Label ID="lblSectionTitle" runat="server">دار الصديق</asp:Label>
    </div>
    <div class="content-inner">
        <div class="classes-container" style="height: auto; overflow: hidden;" id="divSubSections" runat="server">
            <asp:Repeater ID="rptSubSections" runat="server">
                <ItemTemplate>
                    <div class="block-classes blockDar" onclick="appendURL('subsection=<%# Eval("SubSectionID")%>')">
                        <span id="eBooksTab">
                            <%# Eval("SubSectionTitleAR")%></span>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
        <div class="classes-container" style="height: auto; overflow: hidden; margin-top: 10px; margin-right: 10px;" id="divLevels" runat="server">
            <asp:Repeater ID="rptLevels" runat="server">
                <ItemTemplate>
                    <div class='<%# Eval("CSSClass")%> block-small' onclick="appendURL('level=<%# Eval("LevelID")%>')">
                        <span id="eBooksTab">
                            <%# Eval("LevelTitleAR")%></span>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
        <div id="divCategories" runat="server" class="row" style="padding: 15px;">
            <div class="col-md-2" style="float: right; background-image: url(../../images/arrow.png); background-repeat: no-repeat; height: 50px; margin: -10px;">
            </div>
            <div class="classes-container col-md-10" style="height: auto; overflow: hidden;">
                <div>
                    <asp:Repeater ID="rptCategories" runat="server">
                        <ItemTemplate>
                            <div class='<%# Eval("CSSClass")%>' onclick="appendURL('category=<%# Eval("CategoryID")%>')">
                                <span>
                                    <%# Eval("CategoryTitleAR")%></span>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>
        </div>
        <div id="divSubCategories" runat="server" class="row" style="padding: 15px;">
            <div class="col-md-3" style="float: right; background-image: url(../../images/arrow.png); background-repeat: no-repeat; height: 50px; margin: -10px;">
            </div>
            <div class="classes-container col-md-9" style="height: auto; overflow: hidden;">
                <div>
                    <asp:Repeater ID="rptSubCategories" runat="server">
                        <ItemTemplate>
                            <div class="block-classes block-small" onclick="appendURL('subcategory=<%# Eval("SubCategoryID")%>')">
                                <span>
                                    <%# Eval("SubCategoryTitleAR")%></span>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>
        </div>
        <div id="divParts" runat="server" class="row" style="padding: 15px;">
            <div class="col-md-3" style="float: right; background-image: url(../../images/arrow.png); background-repeat: no-repeat; height: 50px; margin: -10px;">
            </div>
            <div class="classes-container col-md-9" style="height: auto; overflow: hidden;">
                <div>
                    <asp:Repeater ID="rptParts" runat="server">
                        <ItemTemplate>
                            <div class="block-classes block-small" onclick="appendURL('part=<%# Eval("PartID")%>')">
                                <span>
                                    <%# Eval("PartTitleAR")%></span>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>
        </div>
        <div class="classes-container" id="divContentList" runat="server" style="width: 81%; margin-top: 10px; height: auto; 
            overflow: hidden; background: url(../../images/Bookshelf.png);">
            <table>
                <asp:Repeater ID="rptContent" runat="server">
                    <ItemTemplate>
                        <%# (Container.ItemIndex + 4) % 4 == 0 ? "<tr>" : string.Empty %>
                        <td>
                            <div style="margin-top: 10px;float: right; width: 180px; text-align: center; cursor: pointer; height: 300px;position: relative;"    
                                onclick="location.href='ContentViewer.aspx?content=<%# Eval("ContentID")%>'">
                                <div class="row">
                                    <asp:Image ID="imgCover" runat="server" ImageUrl='<%#Eval("CoverPic")%>' Style="width: 150px; height: 200px;" />
                                </div>
                                <div class="row" style="position: absolute;bottom: 20px;text-align: center;left: 50%;">
                                    <label style="font-size: large; color: rgb(196, 218, 172);"><%# Eval("ContentTitleAR")%></label>
                                </div>
                            </div>
                        </td>
                        <%# (Container.ItemIndex + 4) % 4 == 3 ? "</tr>" : string.Empty %>
                    </ItemTemplate>
                </asp:Repeater>
            </table>
        </div>
        <div id="divLessons" runat="server" class="row" style="padding: 15px;">
            <div class="classes-container col-md-12" style="height: auto; overflow: hidden;">
                <div>
                    <asp:Repeater ID="rptLessons" runat="server">
                        <ItemTemplate>
                            <li><a href='<%# "ContentViewer.aspx?content=" + Eval("ContentID")%>'>
                                <%# Eval("ContentTitleAR")%></a></li>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
