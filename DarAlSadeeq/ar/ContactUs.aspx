<%@ Page Title="" Language="C#" MasterPageFile="~/ar/MasterPage.master" AutoEventWireup="true" CodeBehind="ContactUs.aspx.cs" Inherits="DarAlSadeeq.ar.ContactUs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="divTitle" runat="server" class="block-main generalTab no-margin" onclick="prevFrame()" style="position: absolute;">
        <asp:Label ID="lblSectionTitle" runat="server">إتصل بنا</asp:Label>
    </div>
    <div class="content-inner">
        <div id="subjectsContainer" class="subjectsContainer SongStories" style="display: block;">
            <table>
                <tr>
                    <td style="padding-left: 15px;">
                        <iframe width="250" height="250" frameborder="0" scrolling="no" marginheight="0"
                            marginwidth="0" src="http://maps.google.com/maps?q=31.978597,35.902011&amp;num=1&amp;t=h&amp;vpsrc=6&amp;doflg=ptk&amp;ie=UTF8&amp;ll=31.978522,35.902162&amp;spn=0.010921,0.012875&amp;z=15&amp;output=embed"></iframe>
                        <br />
                        <small><a href="http://maps.google.com/maps?q=31.978597,35.902011&amp;num=1&amp;t=h&amp;vpsrc=6&amp;doflg=ptk&amp;ie=UTF8&amp;ll=31.978522,35.902162&amp;spn=0.010921,0.012875&amp;z=15&amp;source=embed"
                            style="color: #0000FF; text-align: left"></a></small>
                    </td>
                    <td>
                        <div class="contactForm">
                            <table width="100%">
                                <tr class="spaceUnder">
                                    <td>الإسم:
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtName" runat="server" Width="250"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="ReqField1" runat="server" ControlToValidate="txtName" 
                                            ForeColor="Red" Text="الرجاء تعبئة جميع الحقول"></asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr class="spaceUnder">
                                    <td>الإيميل:
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtEmail" runat="server" Width="250"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="ReqField2" runat="server" ControlToValidate="txtEmail" 
                                            ForeColor="Red" Text="الرجاء تعبئة جميع الحقول"></asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr class="spaceUnder">
                                    <td>الموضوع:
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtSubject" runat="server" Width="250"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="ReqField3" runat="server" ControlToValidate="txtSubject" 
                                            ForeColor="Red" Text="الرجاء تعبئة جميع الحقول"></asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr class="spaceUnder">
                                    <td>الرسالة:
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtBody" runat="server" Width="250" TextMode="MultiLine" Height="200"></asp:TextBox>
                                          <asp:RequiredFieldValidator ID="ReqField4" runat="server" ControlToValidate="txtBody" 
                                            ForeColor="Red" Text="الرجاء تعبئة جميع الحقول"></asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr class="spaceUnder">
                                    <td></td>
                                    <td style="text-align: center;">
                                        <asp:Button ID="BtnSend" runat="server" Text="إرسال" Width="70" OnClick="BtnSend_Click" />
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="2">
                                        <asp:Label ID="lblResult" runat="server" Visible="False"></asp:Label>
                                    </td>
                                </tr>
                            </table>
                        </div>
                        <span class="contactInfo" style="direction: rtl;">تلفون: +962 6 5656404/5</br> فاكس: +962 6 5656402</br> ص .ب
                                                641 عمان 11941 الأردن</br> info@daralsadeeq.com</br></span>
                    </td>
                </tr>
            </table>
        </div>
    </div>
</asp:Content>
