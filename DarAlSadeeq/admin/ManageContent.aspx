<%@ Page Title="" Language="C#" MasterPageFile="~/admin/AdminMaster.master" AutoEventWireup="true" CodeBehind="ManageContent.aspx.cs" Inherits="DarAlSadeeq.admin.ManageContent" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="Server">
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
                <li class="submenu-active"><a href="#" onclick="showTableAdd();">إضافة محتوى</a></li>
                <li><a href="#" onclick="showTableEditDelete();">حذف أو تعديل محتوى</a></li>
            </ul>
        </div>
        <!-- /aside -->
        <hr class="noscreen" />
        <!-- Content (Right Column) -->
        <div id="content" class="box">
            <table id="tblAdd" class="table col-md-11" style="text-align: left">
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
                        <asp:DropDownList ID="drpSections" runat="server" Width="25%">
                        </asp:DropDownList>
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
                               القسم الفرعي - إنتجاتنا

                        </p>
                    </td>
                    <td>
                        <asp:DropDownList ID="DrpSubSections" runat="server" Width="25%">
                        </asp:DropDownList>
                    </td>
                    <td>
                        <button type="button" title="إضافة او تعديل قسم" id="btnManageSubSections">
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
                        <asp:DropDownList ID="DrpLevels" runat="server" Width="25%">
                        </asp:DropDownList>
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
                            المستوى الفرعي
                        </p>
                    </td>
                    <td>
                        <asp:DropDownList ID="drpSubCategories" runat="server" Width="25%">
                        </asp:DropDownList>
                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td style="width: 20%;">
                        <p>
                            المادة
                        </p>
                    </td>
                    <td>
                        <asp:DropDownList ID="DrpDwnCategories" runat="server" Width="25%">
                        </asp:DropDownList>
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
                        <asp:DropDownList ID="drpParts" runat="server" Width="25%">
                        </asp:DropDownList>
                    </td>
                    <td></td>
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
                            <asp:ListItem>Pages</asp:ListItem>
                            <asp:ListItem>Image</asp:ListItem>
                            <asp:ListItem>HTML Page</asp:ListItem>
                            <asp:ListItem>Flash</asp:ListItem>
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
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <table id="tblEditDelete" class="table col-md-11" style="text-align: left">
                        <tr>
                            <td colspan="3">
                                <p class=" msg info">
                                    حذف أو تعديل محتوى
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
                                <asp:DropDownList ID="drpEditSections" runat="server" Width="25%">
                                </asp:DropDownList>
                            </td>
                            <td></td>
                        </tr>
                         <tr>
                            <td style="width: 20%;">
                                <p>
                                    القسم الفرعي - إنتجاتنا
                                </p>
                            </td>
                            <td>
                                <asp:DropDownList ID="DrpSubSectionsEdit" runat="server" Width="25%">
                                </asp:DropDownList>
                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td style="width: 20%;">
                                <p>
                                    المستوى
                                </p>
                            </td>
                            <td style="width: 40%;">
                                <asp:DropDownList ID="drpEditLevels" runat="server" Width="25%">
                                </asp:DropDownList>
                            </td>
                            <td style="width: 40%;"></td>
                        </tr>
                        <tr>
                            <td style="width: 20%;">
                                <p>
                                    المستوى الفرعي
                                </p>
                            </td>
                            <td>
                                <asp:DropDownList ID="drpEditSubCategories" runat="server" Width="25%">
                                </asp:DropDownList>

                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td style="width: 20%;">
                                <p>
                                    المادة
                                </p>
                            </td>
                            <td>
                                <asp:DropDownList ID="drpEditCategories" runat="server" Width="25%">
                                </asp:DropDownList>
                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td style="width: 20%;">
                                <p>
                                    الجزء
                                </p>
                            </td>
                            <td>
                                <asp:DropDownList ID="drpEditParts" runat="server" Width="25%">
                                </asp:DropDownList>
                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td style="width: 20%;"></td>
                            <td style="width: 111px">
                                <asp:Button ID="BtnGetContent" runat="server" Text="بحث" Width="100px" OnClick="BtnGetContent_Click" />
                           </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td style="width: 20%;">
                                <p>
                                    إسم المحتوى
                                </p>
                            </td>
                            <td>
                                <asp:DropDownList ID="drpContent" runat="server" Width="25%" AutoPostBack="True"
                                    OnSelectedIndexChanged="drpContent_SelectedIndexChanged">
                                </asp:DropDownList>
                            </td>
                            <td><asp:Label ID="lblContent" runat="server"></asp:Label></td>
                        </tr>
                        <tr>
                            <td style="width: 20%;">
                                <p>
                                    إسم المحتوى العربي
                                </p>
                            </td>
                            <td>
                                <asp:TextBox ID="txtEditContentTitleAR" runat="server" Width="50%"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator17" runat="server" Style="color: red"
                                    ControlToValidate="txtEditContentTitleAR" ErrorMessage="يجب إدخال قيمة" ValidationGroup="contentEditValidationGroup"></asp:RequiredFieldValidator>
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
                                <asp:TextBox ID="txtEditContentTitleEN" runat="server" Width="50%"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator18" runat="server" Style="color: red"
                                    ControlToValidate="txtEditContentTitleEN" ErrorMessage="يجب إدخال قيمة" ValidationGroup="contentEditValidationGroup"></asp:RequiredFieldValidator>
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
                                <asp:TextBox ID="txtEditDescription" runat="server" Width="50%" TextMode="MultiLine" Rows="3"></asp:TextBox>
                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td></td>
                            <td>
                                <asp:Label ID="lblEditResult" runat="server" Text="تمت الإضافة بنجاح" Visible="false"></asp:Label>
                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td style="width: 111px"></td>
                            <td>
                                <asp:Button ID="BtnEdit" runat="server" Text="تعديل" Width="60px" OnClick="Btn_Update_Click" ValidationGroup="contentEditValidationGroup" />
                                <asp:Button ID="BtnDelete" runat="server" Text="حذف" Width="60px" OnClick="Btn_Delete_Click" ValidationGroup="contentDeleteValidationGroup" />
                            </td>
                            <td></td>
                            <td></td>
                        </tr>
                    </table>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
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
                                                                <asp:DropDownList ID="drpSectionsEdit" runat="server" Style="float: left;"
                                                                    AutoPostBack="true" OnSelectedIndexChanged="sectionSelected">
                                                                </asp:DropDownList>
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
    <div class="modal fade fill-in" id="modalManageSubSections" tabindex="-1" role="dialog" aria-hidden="true">
        <div class="modal-dialog">
            <asp:UpdatePanel ID="UpdatePanel2" runat="server">
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
                                        إدارة الأقسام الفرعية 
                                    </p>
                                </div>
                            </div>
                            <div class="row" style="margin-top: 10px">
                                <div class="col-lg-10">
                                    <ul class="nav nav-tabs">
                                        <li class="active"><a data-toggle="tab" href="#addSubSection">إضافة</a></li>
                                        <li><a data-toggle="tab" href="#editSubSection">تعديل</a></li>
                                        <li><a data-toggle="tab" href="#deleteSubSection">حذف</a></li>
                                    </ul>
                                    <div class="tab-content">
                                        <div id="addSubSection" class="tab-pane fade in active">
                                            <div class="row" style="margin-top: 20px;">
                                                <div class="col-md-2"></div>
                                                <div class="col-md-10 no-padding sm-m-t-10 sm-text-center">
                                                    <table class="table table-responsive">
                                                        <tr>
                                                            <td><span>اسم القسم العربي</span></td>
                                                            <td>
                                                                <asp:TextBox ID="txtSubSectionAR" runat="server"></asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator19" runat="server" Style="color: red"
                                                                    ControlToValidate="txtSubSectionAR" ErrorMessage="يجب إدخال قيمة" ValidationGroup="SubSectionsValidationGroup"></asp:RequiredFieldValidator>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td><span>اسم القسم إنجليزي</span></td>
                                                            <td>
                                                                <asp:TextBox ID="txtSubSectionEN" runat="server"></asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator20" runat="server" Style="color: red"
                                                                    ControlToValidate="txtSubSectionEN" ErrorMessage="يجب إدخال قيمة" ValidationGroup="SubSectionsValidationGroup"></asp:RequiredFieldValidator>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td colspan="2">
                                                                <asp:Button ID="btnSaveNewSubSection" runat="server" Text="حفظ" OnClick="btnSaveNewSubSection_Click" ValidationGroup="SubSectionsValidationGroup"></asp:Button></td>
                                                        </tr>
                                                    </table>
                                                </div>
                                            </div>
                                        </div>
                                        <div id="editSubSection" class="tab-pane fade">
                                            <div class="row" style="margin-top: 20px;">
                                                <div class="col-md-2"></div>
                                                <div class="col-md-10 no-padding sm-m-t-10 sm-text-center">
                                                    <table class="table table-responsive">
                                                        <tr>
                                                            <td><span>اختر</span></td>
                                                            <td>
                                                                <asp:DropDownList ID="DrpEditSubSections" runat="server" Style="float: left;"
                                                                    AutoPostBack="true" OnSelectedIndexChanged="SubSectionSelected">
                                                                </asp:DropDownList>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td><span>اسم القسم العربي</span></td>
                                                            <td>
                                                                <asp:TextBox ID="txtSubSectionTitleAR" runat="server"></asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator21" runat="server" Style="color: red"
                                                                    ControlToValidate="txtSubSectionTitleAR" ErrorMessage="يجب إدخال قيمة" ValidationGroup="SubSectionsEditValidationGroup"></asp:RequiredFieldValidator>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td><span>اسم القسم إنجليزي</span></td>
                                                            <td>
                                                                <asp:TextBox ID="txtSubSectionTitleEN" runat="server"></asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator22" runat="server" Style="color: red"
                                                                    ControlToValidate="txtSubSectionTitleEN" ErrorMessage="يجب إدخال قيمة" ValidationGroup="SubSectionsEditValidationGroup"></asp:RequiredFieldValidator>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td><span>الترتيب</span></td>
                                                            <td>
                                                                <asp:DropDownList ID="DrpSortOrder" runat="server" Style="float: left;">
                                                                    <asp:ListItem Value="1">1</asp:ListItem>
                                                                    <asp:ListItem Value="2">2</asp:ListItem>
                                                                    <asp:ListItem Value="3">3</asp:ListItem>
                                                                    <asp:ListItem Value="4">4</asp:ListItem>
                                                                    <asp:ListItem Value="5">5</asp:ListItem>
                                                                    <asp:ListItem Value="6">6</asp:ListItem>
                                                                    <asp:ListItem Value="7">7</asp:ListItem>
                                                                    <asp:ListItem Value="8">8</asp:ListItem>
                                                                    <asp:ListItem Value="9">9</asp:ListItem>
                                                                </asp:DropDownList>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td colspan="2">
                                                                <asp:Button ID="BtnEditSubSection" runat="server" Text="حفظ" OnClick="BtnEditSubSection_Click" ValidationGroup="SubSectionsEditValidationGroup"></asp:Button></td>
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
                            <asp:Label ID="lblManageSubSections" runat="server" Text=""></asp:Label>
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
                                                                <asp:TextBox ID="txtLevelTitleARAdd" runat="server"></asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" Style="color: red"
                                                                    ControlToValidate="txtLevelTitleARAdd" ErrorMessage="يجب إدخال قيمة" ValidationGroup="levelsValidationGroup"></asp:RequiredFieldValidator>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td><span>اسم القسم إنجليزي</span></td>
                                                            <td>
                                                                <asp:TextBox ID="txtLevelTitleENAdd" runat="server"></asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" Style="color: red"
                                                                    ControlToValidate="txtLevelTitleENAdd" ErrorMessage="يجب إدخال قيمة" ValidationGroup="levelsValidationGroup"></asp:RequiredFieldValidator>
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
                                                                <asp:DropDownList ID="drpLevelsEdit" runat="server" Style="float: left;"
                                                                    AutoPostBack="true" OnSelectedIndexChanged="LevelSelected">
                                                                </asp:DropDownList>
                                                               
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
                                                                <asp:DropDownList ID="drpLevelsDelete" runat="server">
                                                                </asp:DropDownList>
                                                                
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td colspan="2">
                                                                <asp:Button ID="btnDeleteLevel" runat="server" Text="حذف" OnClick="btnDeleteLevel_Click" ValidationGroup="levelsDeleteValidationGroup"></asp:Button></td>
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
                            <asp:Label ID="lblLevelsResults" runat="server" Text=""></asp:Label>
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
                                                                <asp:TextBox ID="txtCategoryTitleARAdd" runat="server"></asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" Style="color: red"
                                                                    ControlToValidate="txtCategoryTitleARAdd" ErrorMessage="يجب إدخال قيمة" ValidationGroup="CategoriesValidationGroup"></asp:RequiredFieldValidator>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td><span>اسم المادة إنجليزي</span></td>
                                                            <td>
                                                                <asp:TextBox ID="txtCategoryTitleENAdd" runat="server"></asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" Style="color: red"
                                                                    ControlToValidate="txtCategoryTitleENAdd" ErrorMessage="يجب إدخال قيمة" ValidationGroup="CategoriesValidationGroup"></asp:RequiredFieldValidator>
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
                                                                <asp:DropDownList ID="drpCategoriesEdit" runat="server" 
                                                                    AutoPostBack="true" OnSelectedIndexChanged="Categorieselected">
                                                                </asp:DropDownList>
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
                                                                <asp:DropDownList ID="drpCategoriesDelete" runat="server">
                                                                </asp:DropDownList>
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
                            <asp:Label ID="lblCategoriesResults" runat="server" Text=""></asp:Label>
                        </div>
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
            <!-- /.modal-content -->
        </div>
        <!-- /.modal-dialog -->
    </div>
    <script>
        $(document).ready(function () {

            $('#tblEditDelete').hide();
        });
        function showTableAdd() {
            $('#tblAdd').show();
            $('#tblEditDelete').hide();
        }
        function showTableEditDelete() {
            $('#tblAdd').hide();
            $('#tblEditDelete').show();
        }
    </script>
</asp:Content>
