<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage_admin.master" AutoEventWireup="true" CodeBehind="ManageContent.aspx.cs" Inherits="DarAlSadeeq.admin.ManageContent" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="Server">
    <script type="text/javascript">
        function activateEditTab() {
            $("#add").removeClass("active");  // this deactivates the home tab
            $("#edit").addClass("active");
        }
    </script>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="cols" class="box">
        <!-- Aside (Left Column) -->
        <div id="aside" class="box">
            <div class="padding box">
                <!-- Logo (Max. width = 200px) -->
                <p id="logo">
                    <a href="#">
                        <img src="design/Dar_Logo.PNG" alt="Our logo" title="Visit Site" /></a>
                </p>
            </div>
            <!-- /padding -->
            <ul class="box">
                <li id="submenu-active"><a href="ManageContent.aspx">إضافة محتوى</a></li>
                <li><a href="#">حذف أو تعديل محتوى</a></li>
            </ul>
        </div>
        <!-- /aside -->
        <hr class="noscreen" />
        <!-- Content (Right Column) -->
        <div id="content" class="box">
            <table width="99%" class="table" style="text-align: left">
                <tr>
                    <td colspan="3">
                        <p class=" msg info">
                            إضافة محتوى جديد
                        </p>
                    </td>
                </tr>
                <tr>
                    <td style="width: 20%;">
                        <p>
                            القسم
                        </p>
                    </td>
                    <td>
                        <asp:DropDownList ID="drpSections" runat="server" Width="25%"
                            DataSourceID="SqlDataSource3" DataTextField="SectionTitleAR"
                            DataValueField="SectionID">
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSource3" runat="server"
                            ConnectionString="<%$ ConnectionStrings:Dar_AlsadiqConnectionString %>"
                            SelectCommand="SELECT * FROM [tbl_Sections]"></asp:SqlDataSource>
                    </td>
                    <td>
                        <button type="button" title="إضافة او تعديل قسم" id="btnManageSections">
                            <i class="fa fa-cog"></i>
                        </button>
                    </td>
                </tr>
                <tr>
                    <td style="width: 20%;">
                        <p>
                            المستوى
                        </p>
                    </td>
                    <td style="width: 40%;">
                        <asp:DropDownList ID="DrpDwnLevels" runat="server" Width="25%"
                            DataSourceID="SqlDataSource1" DataTextField="LevelTitleAR"
                            DataValueField="LevelID">
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server"
                            ConnectionString="<%$ ConnectionStrings:Dar_AlsadiqConnectionString %>"
                            SelectCommand="SELECT * FROM [tbl_Levels]"></asp:SqlDataSource>
                    </td>
                    <td style="width: 40%;">
                        <button type="button" title="إضافة او تعديل مستوى" id="btnManageLevel"
                            name="New_Level">
                            <i class="fa fa-cog"></i>
                        </button>
                    </td>
                </tr>
                <tr>
                    <td style="width: 20%;">
                        <p>
                            المادة
                        </p>
                    </td>
                    <td>
                        <asp:DropDownList ID="DrpDwnCategories" runat="server" Width="25%"
                            DataSourceID="SqlDataSource2" DataTextField="CategoryTitleAR"
                            DataValueField="CategoryID">
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSource2" runat="server"
                            ConnectionString="<%$ ConnectionStrings:Dar_AlsadiqConnectionString %>"
                            SelectCommand="SELECT * FROM [tbl_Categories]"></asp:SqlDataSource>
                    </td>
                    <td>
                        <button type="button" title="إضافة او تعديل مادة" id="btnManageCategory">
                            <i class="fa fa-cog"></i>
                        </button>
                    </td>
                </tr>
                <tr>
                    <td style="width: 20%;">
                        <p>
                            الجزء
                        </p>
                    </td>
                    <td>
                        <asp:DropDownList ID="drpParts" runat="server" Width="25%"
                            DataSourceID="SqlDataSource4" DataTextField="PartTitleAR"
                            DataValueField="PartID">
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSource4" runat="server"
                            ConnectionString="<%$ ConnectionStrings:Dar_AlsadiqConnectionString %>"
                            SelectCommand="SELECT * FROM [tbl_Parts]"></asp:SqlDataSource>
                    </td>
                    <td>
                        <button type="button" title="إضافة او تعديل جزء" id="btnManageParts">
                            <i class="fa fa-cog"></i>
                        </button>
                    </td>
                </tr>

                <tr>
                    <td style="width: 20%;">
                        <p>
                            إسم المحتوى العربي
                        </p>
                    </td>
                    <td>
                        <asp:TextBox ID="txtContentTitleAR" runat="server" Width="50%"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Style="color: red"
                            ControlToValidate="txtContentTitleAR" ErrorMessage="يجب إدخال قيمة" ValidationGroup="contentValidationGroup"></asp:RequiredFieldValidator>
                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td style="width: 20%;">
                        <p>
                            إسم المحتوى الإنجليزي
                        </p>
                    </td>
                    <td>
                        <asp:TextBox ID="txtContentTitleEN" runat="server" Width="50%"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" Style="color: red"
                            ControlToValidate="txtContentTitleEN" ErrorMessage="يجب إدخال قيمة" ValidationGroup="contentValidationGroup"></asp:RequiredFieldValidator>
                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td style="width: 20%;">
                        <p>
                            نوع المحتوى
                        </p>
                    </td>
                    <td>
                        <asp:DropDownList ID="drpContentType" runat="server" Width="25%">
                            <asp:ListItem>PDF</asp:ListItem>
                            <asp:ListItem>Flash</asp:ListItem>
                            <asp:ListItem>Image</asp:ListItem>
                            <asp:ListItem>Pages</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td style="width: 20%;">
                        <p>
                            صورة الغلاف
                        </p>
                    </td>
                    <td>
                        <asp:FileUpload ID="coverFileUploader" runat="server" accept=".png,.jpg,.jpeg,.PNG,.JPG,.JPEG" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" Style="color: red"
                            ControlToValidate="coverFileUploader" ErrorMessage="يجب إختيار ملف" ValidationGroup="contentValidationGroup"></asp:RequiredFieldValidator>
                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td style="width: 20%;">
                        <p>
                            ملف المحتوى
                        </p>
                    </td>
                    <td>
                        <asp:FileUpload ID="contentFileUploader" runat="server" Multiple="Multiple" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" Style="color: red"
                            ControlToValidate="contentFileUploader" ErrorMessage="يجب إختيار ملف" ValidationGroup="contentValidationGroup"></asp:RequiredFieldValidator>
                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td style="width: 20%;">
                        <p>
                            نبذة
                        </p>
                    </td>
                    <td>
                        <asp:TextBox ID="txtDescription" runat="server" Width="50%" TextMode="MultiLine" Rows="3"></asp:TextBox>
                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Label ID="lblContentResult" runat="server" Text="تمت الإضافة بنجاح" Visible="false"></asp:Label>
                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td style="width: 111px"></td>
                    <td>
                        <asp:Button ID="btn_save" runat="server" Text="حفظ" Width="60px" OnClick="btn_save_Click" ValidationGroup="contentValidationGroup" />&nbsp;&nbsp;&nbsp;
                    </td>
                    <td></td>
                </tr>
            </table>
        </div>
        <hr class="noscreen" />
        <!-- Footer -->
        <div id="footer" class="box">
        </div>
        <!-- /footer -->
    </div>
    <div class="modal fade fill-in" id="modalManageSections" tabindex="-1" role="dialog" aria-hidden="true">
        <div class="modal-dialog">
            <asp:UpdatePanel ID="UpdatePanelSections" runat="server">
                <ContentTemplate>
                    <div class="modal-content">
                        <div class="modal-header">
                            <button type="button" class="close" data-dismiss="modal" aria-hidden="true">
                                <img src="../images/close-icon.png" width="25" height="25" />
                            </button>
                        </div>
                        <div class="modal-body">
                            <div class="row">
                                <div class="col-md-12">
                                    <p class=" msg info">
                                        إدارة أقسام الموقع
                                    </p>
                                </div>
                            </div>
                            <div class="row" style="margin-top: 10px">
                                <div class="col-lg-10">
                                    <ul class="nav nav-tabs">
                                        <li class="active"><a data-toggle="tab" href="#add">إضافة</a></li>
                                        <li><a data-toggle="tab" href="#edit">تعديل</a></li>
                                        <li><a data-toggle="tab" href="#delete">حذف</a></li>
                                    </ul>

                                    <div class="tab-content">
                                        <div id="add" class="tab-pane fade in active">
                                            <div class="row" style="margin-top: 20px;">
                                                <div class="col-md-2"></div>
                                                <div class="col-md-10 no-padding sm-m-t-10 sm-text-center">
                                                    <table class="table table-responsive">
                                                        <tr>
                                                            <td><span>اسم القسم العربي</span></td>
                                                            <td>
                                                                <asp:TextBox ID="txtSectionTitleAR" runat="server"></asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" Style="color: red"
                                                                    ControlToValidate="txtSectionTitleAR" ErrorMessage="يجب إدخال قيمة" ValidationGroup="sectionsValidationGroup"></asp:RequiredFieldValidator>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td><span>اسم القسم إنجليزي</span></td>
                                                            <td>
                                                                <asp:TextBox ID="txtSectionTitleEN" runat="server"></asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" Style="color: red"
                                                                    ControlToValidate="txtSectionTitleAR" ErrorMessage="يجب إدخال قيمة" ValidationGroup="sectionsValidationGroup"></asp:RequiredFieldValidator>

                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td colspan="2">
                                                                <asp:Button ID="btnSaveNewSection" runat="server" Text="حفظ" OnClick="btnSaveNewSection_Click" ValidationGroup="sectionsValidationGroup"></asp:Button></td>
                                                        </tr>
                                                    </table>
                                                </div>
                                            </div>
                                        </div>
                                        <div id="edit" class="tab-pane fade">
                                            <div class="row" style="margin-top: 20px;">
                                                <div class="col-md-2"></div>
                                                <div class="col-md-10 no-padding sm-m-t-10 sm-text-center">
                                                    <table class="table table-responsive">
                                                        <tr>
                                                            <td><span>اختر</span></td>
                                                            <td>
                                                                <asp:DropDownList ID="drpSectionsEdit" runat="server" AutoPostBack="true" OnSelectedIndexChanged="sectionSelected"
                                                                    DataSourceID="SqlDataSource3" DataTextField="SectionTitleAR"
                                                                    DataValueField="SectionID">
                                                                </asp:DropDownList>
                                                                <asp:SqlDataSource ID="SqlDataSource5" runat="server"
                                                                    ConnectionString="<%$ ConnectionStrings:Dar_AlsadiqConnectionString %>"
                                                                    SelectCommand="SELECT * FROM [tbl_Sections]"></asp:SqlDataSource>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td><span>اسم القسم العربي</span></td>
                                                            <td>
                                                                <asp:TextBox ID="txtSectionTitleAREdit" runat="server"></asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" Style="color: red"
                                                                    ControlToValidate="txtSectionTitleAREdit" ErrorMessage="يجب إدخال قيمة" ValidationGroup="sectionsEditValidationGroup"></asp:RequiredFieldValidator>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td><span>اسم القسم إنجليزي</span></td>
                                                            <td>
                                                                <asp:TextBox ID="txtSectionTitleENEdit" runat="server"></asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" Style="color: red"
                                                                    ControlToValidate="txtSectionTitleENEdit" ErrorMessage="يجب إدخال قيمة" ValidationGroup="sectionsEditValidationGroup"></asp:RequiredFieldValidator>

                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td colspan="2">
                                                                <asp:Button ID="btnEditSection" runat="server" Text="حفظ" OnClick="btnEditSection_Click" ValidationGroup="sectionsEditValidationGroup"></asp:Button></td>
                                                        </tr>
                                                    </table>
                                                </div>
                                            </div>
                                        </div>
                                        <div id="delete" class="tab-pane fade">
                                            <div class="row" style="margin-top: 20px;">
                                                <div class="col-md-2"></div>
                                                <div class="col-md-10 no-padding sm-m-t-10 sm-text-center">
                                                    <table class="table table-responsive">
                                                        <tr>
                                                            <td><span>اختر</span></td>
                                                            <td>
                                                                <asp:DropDownList ID="drpSectionsDelete" runat="server"
                                                                    DataSourceID="SqlDataSource6" DataTextField="SectionTitleAR"
                                                                    DataValueField="SectionID">
                                                                </asp:DropDownList>
                                                                <asp:SqlDataSource ID="SqlDataSource6" runat="server"
                                                                    ConnectionString="<%$ ConnectionStrings:Dar_AlsadiqConnectionString %>"
                                                                    SelectCommand="SELECT * FROM [tbl_Sections]"></asp:SqlDataSource>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td colspan="2">
                                                                <asp:Button ID="btnDeleteSection" runat="server" Text="حذف" OnClick="btnDeleteSection_Click" ValidationGroup="sectionsDeleteValidationGroup"></asp:Button></td>
                                                        </tr>
                                                    </table>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="modal-footer">
                            <asp:Label ID="lblSectionsResults" runat="server" Text=""></asp:Label>
                        </div>
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
            <!-- /.modal-content -->
        </div>
        <!-- /.modal-dialog -->
    </div>
    <div class="modal fade fill-in" id="modalManageLevels" tabindex="-1" role="dialog" aria-hidden="true">
        <div class="modal-dialog">
            <asp:UpdatePanel ID="UpdatePanelLevels" runat="server">
                <ContentTemplate>
                    <div class="modal-content">
                        <div class="modal-header">
                            <button type="button" class="close" data-dismiss="modal" aria-hidden="true">
                                <img src="../images/close-icon.png" width="25" height="25" />
                            </button>
                        </div>
                        <div class="modal-body">
                            <div class="row">
                                <div class="col-md-12">
                                    <p class=" msg info">
                                        إدارة المستويات 
                                    </p>
                                </div>
                            </div>
                            <div class="row" style="margin-top: 10px">
                                <div class="col-lg-10">
                                    <ul class="nav nav-tabs">
                                        <li class="active"><a data-toggle="tab" href="#addLevel">إضافة</a></li>
                                        <li><a data-toggle="tab" href="#editLevel">تعديل</a></li>
                                        <li><a data-toggle="tab" href="#deleteLevel">حذف</a></li>
                                    </ul>

                                    <div class="tab-content">
                                        <div id="addLevel" class="tab-pane fade in active">
                                            <div class="row" style="margin-top: 20px;">
                                                <div class="col-md-2"></div>
                                                <div class="col-md-10 no-padding sm-m-t-10 sm-text-center">
                                                    <table class="table table-responsive">
                                                        <tr>
                                                            <td><span>اسم المستوى العربي</span></td>
                                                            <td>
                                                                <asp:TextBox ID="txtLevelARAdd" runat="server"></asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" Style="color: red"
                                                                    ControlToValidate="txtLevelARAdd" ErrorMessage="يجب إدخال قيمة" ValidationGroup="levelsValidationGroup"></asp:RequiredFieldValidator>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td><span>اسم القسم إنجليزي</span></td>
                                                            <td>
                                                                <asp:TextBox ID="txtLevelENAdd" runat="server"></asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" Style="color: red"
                                                                    ControlToValidate="txtLevelENAdd" ErrorMessage="يجب إدخال قيمة" ValidationGroup="levelsValidationGroup"></asp:RequiredFieldValidator>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td colspan="2">
                                                                <asp:Button ID="btnSaveNewLevel" runat="server" Text="حفظ" OnClick="btnSaveNewLevel_Click" ValidationGroup="levelsValidationGroup"></asp:Button></td>
                                                        </tr>
                                                    </table>
                                                </div>
                                            </div>
                                        </div>
                                        <div id="editLevel" class="tab-pane fade">
                                            <div class="row" style="margin-top: 20px;">
                                                <div class="col-md-2"></div>
                                                <div class="col-md-10 no-padding sm-m-t-10 sm-text-center">
                                                    <table class="table table-responsive">
                                                        <tr>
                                                            <td><span>اختر</span></td>
                                                            <td>
                                                                <asp:DropDownList ID="drpLevelsEdit" runat="server" AutoPostBack="true" OnSelectedIndexChanged="levelSelected"
                                                                    DataSourceID="SqlDataSource7" DataTextField="LevelTitleAR"
                                                                    DataValueField="LevelID">
                                                                </asp:DropDownList>
                                                                <asp:SqlDataSource ID="SqlDataSource7" runat="server"
                                                                    ConnectionString="<%$ ConnectionStrings:Dar_AlsadiqConnectionString %>"
                                                                    SelectCommand="SELECT * FROM [tbl_Levels]"></asp:SqlDataSource>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td><span>اسم القسم العربي</span></td>
                                                            <td>
                                                                <asp:TextBox ID="txtLevelTitleAREdit" runat="server"></asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" Style="color: red"
                                                                    ControlToValidate="txtLevelTitleAREdit" ErrorMessage="يجب إدخال قيمة" ValidationGroup="levelsEditValidationGroup"></asp:RequiredFieldValidator>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td><span>اسم القسم إنجليزي</span></td>
                                                            <td>
                                                                <asp:TextBox ID="txtLevelTitleENEdit" runat="server"></asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" Style="color: red"
                                                                    ControlToValidate="txtLevelTitleENEdit" ErrorMessage="يجب إدخال قيمة" ValidationGroup="levelsEditValidationGroup"></asp:RequiredFieldValidator>

                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td colspan="2">
                                                                <asp:Button ID="btnEditLevel" runat="server" Text="حفظ" OnClick="btnEditLevel_Click" ValidationGroup="levelsEditValidationGroup"></asp:Button></td>
                                                        </tr>
                                                    </table>
                                                </div>
                                            </div>
                                        </div>
                                        <div id="deleteLevel" class="tab-pane fade">
                                            <div class="row" style="margin-top: 20px;">
                                                <div class="col-md-2"></div>
                                                <div class="col-md-10 no-padding sm-m-t-10 sm-text-center">
                                                    <table class="table table-responsive">
                                                        <tr>
                                                            <td><span>اختر</span></td>
                                                            <td>
                                                                <asp:DropDownList ID="drpLevelsDelete" runat="server"
                                                                    DataSourceID="SqlDataSource8" DataTextField="LevelTitleAR"
                                                                    DataValueField="LevelID">
                                                                </asp:DropDownList>
                                                                <asp:SqlDataSource ID="SqlDataSource8" runat="server"
                                                                    ConnectionString="<%$ ConnectionStrings:Dar_AlsadiqConnectionString %>"
                                                                    SelectCommand="SELECT * FROM [tbl_Levels]"></asp:SqlDataSource>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td colspan="2">
                                                                <asp:Button ID="btnDeleteEdit" runat="server" Text="حذف" OnClick="btnDeleteEdit_Click" ValidationGroup="levelsDeleteValidationGroup"></asp:Button></td>
                                                        </tr>
                                                    </table>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="modal-footer">
                            <asp:Label ID="lblLevelsResult" runat="server" Text=""></asp:Label>
                        </div>
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
            <!-- /.modal-content -->
        </div>
        <!-- /.modal-dialog -->
    </div>
    <div class="modal fade fill-in" id="modalManageCategories" tabindex="-1" role="dialog" aria-hidden="true">
        <div class="modal-dialog">
            <asp:UpdatePanel ID="UpdatePanelCategories" runat="server">
                <ContentTemplate>
                    <div class="modal-content">
                        <div class="modal-header">
                            <button type="button" class="close" data-dismiss="modal" aria-hidden="true">
                                <img src="../images/close-icon.png" width="25" height="25" />
                            </button>
                        </div>
                        <div class="modal-body">
                            <div class="row">
                                <div class="col-md-12">
                                    <p class=" msg info">
                                        إدارة المواد 
                                    </p>
                                </div>
                            </div>
                            <div class="row" style="margin-top: 10px">
                                <div class="col-lg-10">
                                    <ul class="nav nav-tabs">
                                        <li class="active"><a data-toggle="tab" href="#addCategory">إضافة</a></li>
                                        <li><a data-toggle="tab" href="#editCategory">تعديل</a></li>
                                        <li><a data-toggle="tab" href="#deleteCategory">حذف</a></li>
                                    </ul>

                                    <div class="tab-content">
                                        <div id="addCategory" class="tab-pane fade in active">
                                            <div class="row" style="margin-top: 20px;">
                                                <div class="col-md-2"></div>
                                                <div class="col-md-10 no-padding sm-m-t-10 sm-text-center">
                                                    <table class="table table-responsive">
                                                        <tr>
                                                            <td><span>اسم المادة العربي</span></td>
                                                            <td>
                                                                <asp:TextBox ID="txtCategoryARAdd" runat="server"></asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" Style="color: red"
                                                                    ControlToValidate="txtCategoryARAdd" ErrorMessage="يجب إدخال قيمة" ValidationGroup="CategoriesValidationGroup"></asp:RequiredFieldValidator>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td><span>اسم المادة إنجليزي</span></td>
                                                            <td>
                                                                <asp:TextBox ID="txtCategoryENAdd" runat="server"></asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" Style="color: red"
                                                                    ControlToValidate="txtCategoryENAdd" ErrorMessage="يجب إدخال قيمة" ValidationGroup="CategoriesValidationGroup"></asp:RequiredFieldValidator>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td colspan="2">
                                                                <asp:Button ID="btnSaveNewCategory" runat="server" Text="حفظ" OnClick="btnSaveNewCategory_Click" ValidationGroup="CategoriesValidationGroup"></asp:Button></td>
                                                        </tr>
                                                    </table>
                                                </div>
                                            </div>
                                        </div>
                                        <div id="editCategory" class="tab-pane fade">
                                            <div class="row" style="margin-top: 20px;">
                                                <div class="col-md-2"></div>
                                                <div class="col-md-10 no-padding sm-m-t-10 sm-text-center">
                                                    <table class="table table-responsive">
                                                        <tr>
                                                            <td><span>اختر</span></td>
                                                            <td>
                                                                <asp:DropDownList ID="drpCategoriesEdit" runat="server" AutoPostBack="true" OnSelectedIndexChanged="Categorieselected"
                                                                    DataSourceID="SqlDataSource9" DataTextField="CategoryTitleAR"
                                                                    DataValueField="CategoryID">
                                                                </asp:DropDownList>
                                                                <asp:SqlDataSource ID="SqlDataSource9" runat="server"
                                                                    ConnectionString="<%$ ConnectionStrings:Dar_AlsadiqConnectionString %>"
                                                                    SelectCommand="SELECT * FROM [tbl_Categories]"></asp:SqlDataSource>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td><span>اسم المادة العربي</span></td>
                                                            <td>
                                                                <asp:TextBox ID="txtCategoryTitleAREdit" runat="server"></asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" Style="color: red"
                                                                    ControlToValidate="txtCategoryTitleAREdit" ErrorMessage="يجب إدخال قيمة" ValidationGroup="CategoriesEditValidationGroup"></asp:RequiredFieldValidator>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td><span>اسم القسم إنجليزي</span></td>
                                                            <td>
                                                                <asp:TextBox ID="txtCategoryTitleENEdit" runat="server"></asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator16" runat="server" Style="color: red"
                                                                    ControlToValidate="txtCategoryTitleENEdit" ErrorMessage="يجب إدخال قيمة" ValidationGroup="CategoriesEditValidationGroup"></asp:RequiredFieldValidator>

                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td colspan="2">
                                                                <asp:Button ID="btnEditCategory" runat="server" Text="حفظ" OnClick="btnEditCategory_Click" ValidationGroup="CategoriesEditValidationGroup"></asp:Button></td>
                                                        </tr>
                                                    </table>
                                                </div>
                                            </div>
                                        </div>
                                        <div id="deleteCategory" class="tab-pane fade">
                                            <div class="row" style="margin-top: 20px;">
                                                <div class="col-md-2"></div>
                                                <div class="col-md-10 no-padding sm-m-t-10 sm-text-center">
                                                    <table class="table table-responsive">
                                                        <tr>
                                                            <td><span>اختر</span></td>
                                                            <td>
                                                                <asp:DropDownList ID="drpCategoriesDelete" runat="server"
                                                                    DataSourceID="SqlDataSource10" DataTextField="CategoryTitleAR"
                                                                    DataValueField="CategoryID">
                                                                </asp:DropDownList>
                                                                <asp:SqlDataSource ID="SqlDataSource10" runat="server"
                                                                    ConnectionString="<%$ ConnectionStrings:Dar_AlsadiqConnectionString %>"
                                                                    SelectCommand="SELECT * FROM [tbl_Categories]"></asp:SqlDataSource>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td colspan="2">
                                                                <asp:Button ID="btnDeleteCategory" runat="server" Text="حذف" OnClick="btnDeleteCategory_Click" ValidationGroup="CategoriesDeleteValidationGroup"></asp:Button></td>
                                                        </tr>
                                                    </table>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="modal-footer">
                            <asp:Label ID="lblCategoriesResult" runat="server" Text=""></asp:Label>
                        </div>
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
            <!-- /.modal-content -->
        </div>
        <!-- /.modal-dialog -->
    </div>
</asp:Content>
