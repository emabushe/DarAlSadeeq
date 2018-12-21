﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace DarAlSadeeq.ar
{
    public partial class GuidanceList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                int ErshadID = Convert.ToInt32(Request.QueryString.Get("sid"));
                DataTable dt = DA.Content.ListErshad(ErshadID);
                if (dt.Rows.Count > 0)
                {
                    ImgSubject.ImageUrl = dt.Rows[0]["Pic"].ToString();
                    aGuidanceName.InnerText = dt.Rows[0]["Type"].ToString();
                    Repeater1.DataSource = dt;
                    Repeater1.DataBind();
                }
                else
                {
                    lblBody.Visible = true;
                }
            }
        }
        protected void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            HtmlAnchor b = e.Item.FindControl("link1") as HtmlAnchor;
            DataRowView drv = e.Item.DataItem as DataRowView;
            b.HRef = "GuidanceView.aspx?mid="+ drv.Row["ID"].ToString();
        }
    }

}