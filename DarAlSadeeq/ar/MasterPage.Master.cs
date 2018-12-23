using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DarAlSadeeq.ar
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Session["User"] == null)
                {
                    ibooksLocked.Attributes.Add("class", "locked");
                    level1Locked.Attributes.Add("class", "locked");
                    booksLocked.Attributes.Add("class", "locked");
                    storiesLocked.Attributes.Add("class", "locked");
                    worksheetsLocked.Attributes.Add("class", "locked");
                    teacherLocked.Attributes.Add("class", "locked");
                    controlPanel.Visible = false;
                    BtnLogOut.Visible = false;
                    lblFullName.Visible = false;
                    btnLogin.Visible = true;
                    hdnUserType.Value = "";
                }
                else
                {
                    BtnLogOut.Visible = true;
                    lblFullName.Visible = true;
                    loginBtn.Visible = false;
                    DA.Users.User oUser = Session["User"] as DA.Users.User;
                    lblFullName.Text =   oUser.FullName + " أهلا ";
                    hdnUserType.Value = oUser.UserType;
                    ShowHideLock(oUser.UserType);

                }
            }
        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable dtUser = DA.Users.Login(txtUserName.Text.Trim(), txtPassword.Text);
            if (dtUser.Rows.Count == 1)
            {
                DA.Users.User oUser = new DA.Users.User();
                oUser.UserID = Convert.ToInt32(dtUser.Rows[0]["UserID"].ToString());
                oUser.UserName = dtUser.Rows[0]["UserName"].ToString();
                oUser.UserEmail = dtUser.Rows[0]["UserEmail"].ToString();
                oUser.UserType = dtUser.Rows[0]["Type"].ToString();
                oUser.FullName = dtUser.Rows[0]["FullName"].ToString();
                Session["User"] = oUser;
                hdnUserType.Value = oUser.UserType;
                ShowHideLock(oUser.UserType);
                lblFullName.Text = oUser.FullName + " أهلا ";
                BtnLogOut.Visible = true;
                lblFullName.Visible = true;
                loginBtn.Visible = false;
                
            }
        }
        public void ShowHideLock(string UserType)
        {
            switch (UserType)
            {
                case "admin":
                    ibooksLocked.Attributes["class"] = ibooksLocked.Attributes["class"].Replace("locked", "").Trim();
                    level1Locked.Attributes["class"] = level1Locked.Attributes["class"].Replace("locked", "").Trim();
                    booksLocked.Attributes["class"] = booksLocked.Attributes["class"].Replace("locked", "").Trim();
                    storiesLocked.Attributes["class"] = storiesLocked.Attributes["class"].Replace("locked", "").Trim();
                    worksheetsLocked.Attributes["class"] = worksheetsLocked.Attributes["class"].Replace("locked", "").Trim();
                    teacherLocked.Attributes["class"] = teacherLocked.Attributes["class"].Replace("locked", "").Trim();
                    ibooksLocked.Attributes["class"] = ibooksLocked.Attributes["class"].Replace("locked", "").Trim();
                    controlPanel.Visible = true;
                    break;
                case "school":
                    ibooksLocked.Attributes["class"] = ibooksLocked.Attributes["class"].Replace("locked", "").Trim();
                    level1Locked.Attributes["class"] = level1Locked.Attributes["class"].Replace("locked", "").Trim();
                    booksLocked.Attributes["class"] = booksLocked.Attributes["class"].Replace("locked", "").Trim();
                    storiesLocked.Attributes["class"] = storiesLocked.Attributes["class"].Replace("locked", "").Trim();
                    worksheetsLocked.Attributes["class"] = worksheetsLocked.Attributes["class"].Replace("locked", "").Trim();
                    teacherLocked.Attributes["class"] = teacherLocked.Attributes["class"].Replace("locked", "").Trim();
                    ibooksLocked.Attributes["class"] = ibooksLocked.Attributes["class"].Replace("locked", "").Trim();
                    controlPanel.Visible = false;
                    break;
                case "teacher":
                    teacherLocked.Attributes["class"] = teacherLocked.Attributes["class"].Replace("locked", "").Trim();
                    controlPanel.Visible = false;
                    break;
                case "student":
                    ibooksLocked.Attributes["class"] = ibooksLocked.Attributes["class"].Replace("locked", "").Trim();
                    level1Locked.Attributes["class"] = level1Locked.Attributes["class"].Replace("locked", "").Trim();
                    booksLocked.Attributes["class"] = booksLocked.Attributes["class"].Replace("locked", "").Trim();
                    storiesLocked.Attributes["class"] = storiesLocked.Attributes["class"].Replace("locked", "").Trim();
                    worksheetsLocked.Attributes["class"] = worksheetsLocked.Attributes["class"].Replace("locked", "").Trim();
                    ibooksLocked.Attributes["class"] = ibooksLocked.Attributes["class"].Replace("locked", "").Trim();
                    controlPanel.Visible = false;
                    break;
            }
        }

        protected void BtnLogOut_Click1(object sender, EventArgs e)
        {
            Session["User"] = null;
            hdnUserType.Value = "";
            BtnLogOut.Visible = false;
            lblFullName.Visible = false;
            loginBtn.Visible = true;
            Response.Redirect("~/ar/Default.aspx");
        }
    }
}