using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DarAlSadeeq.ar
{
    public partial class ContactUs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void BtnSend_Click(object sender, EventArgs e)
        {
            string From = txtEmail.Text;
            string body = "Name: " + txtName.Text + "<br/>" + "Subject: " + txtSubject.Text + "<br/>" + txtBody.Text;
            string Receipient = "info@daralsadeeq.com";
            string Subject = txtSubject.Text;
            if (DA.Mail.SendEmail(From, Receipient, Subject, body))
            {
                lblResult.Visible = true;
                lblResult.Text = "تم الإرسال بنجاح";
            }
            else
            {
                lblResult.Visible = true;
                lblResult.Text = "حاول مرة أخرى";
            }

        }
    }
}