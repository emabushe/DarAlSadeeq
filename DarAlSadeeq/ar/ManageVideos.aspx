<%@ Page Title="" Language="C#" MasterPageFile="~/admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="ManageVideos.aspx.cs" Inherits="DarAlSadeeq.ar.ManageVideos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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
                <li class="submenu-active"><a href="#" onclick="showTableAdd();">إضافة فيديو</a></li>
                <li><a href="#" onclick="showTableEditDelete();">حذف أو تعديل فيديو</a></li>
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
                            إضافة فيديو جديد
                        </p>
                    </td>
                </tr>
                <tr>
                    <td style="width: 20%;">
                        <p>
                            إسم الفيديو العربي
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
                            رابط يوتيوب
                        </p>
                    </td>
                    <td>
                        <asp:TextBox ID="txtYoutube" runat="server" Width="50%" TextMode="MultiLine" Rows="3"></asp:TextBox>
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
            <table id="tblEditDelete" class="table col-md-11" style="text-align: left">
                <tr>
                    <td colspan="3">
                        <p class=" msg info">
                            حذف فيديو 
                        </p>
                    </td>
                </tr>
                <tr>
                    <td style="width: 20%;">
                        <p>
                            إسم الفيديو 
                        </p>
                    </td>
                    <td>
                        <asp:DropDownList ID="drpVideos" runat="server" Width="50%" DataSourceID="SqlDataSource1" DataTextField="Title" DataValueField="SongID"></asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Dar_AlsadiqConnectionString %>"
        SelectCommand="SELECT * FROM [Songs]"></asp:SqlDataSource>
                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Label ID="lblDeleteResult" runat="server" Text="تم الحذف بنجاح" Visible="false"></asp:Label>
                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td style="width: 111px"></td>
                    <td>
                        <asp:Button ID="BtnDelete" runat="server" Text="حفظ" Width="60px" OnClick="BtnDelete_Click" />&nbsp;&nbsp;&nbsp;
                    </td>
                    <td></td>
                </tr>
            </table>
        </div>
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
