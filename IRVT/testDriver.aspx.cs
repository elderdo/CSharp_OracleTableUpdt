using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace IRVT
{
    public partial class testDriver : System.Web.UI.Page
    {
        public string genSQLCmd(string InSqlCmd, System.Data.Common.DbParameterCollection p)
        {
            if (p.Count > 0 && InSqlCmd != null)
            {
                foreach (System.Data.Common.DbParameter x in p)
                {
                    if (x != null && x.ParameterName != null)
                        InSqlCmd = InSqlCmd.Replace(":" + x.ParameterName, "'" + (x.Value == null ? "" : x.Value.ToString()) + "'");
                }

            }
            return (InSqlCmd == null ? "" : InSqlCmd);
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Panel10.aspx?Prime=" +
                DropDownList1.Text + "&ItemId=" +
                DropDownList2.Text + "&VendorCode=" +
                DropDownList3.Text);
        }

    
  
        protected void SqlDataSource2_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {
            System.Data.Common.DbCommand command = e.Command;
            SqlDataSourceView dsv = (SqlDataSourceView)sender;
            Label1.Text +=  "<br/>SqlDataSource2: " + genSQLCmd(command.CommandText, command.Parameters);
        }

        protected void SqlDataSource3_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {
            System.Data.Common.DbCommand command = e.Command;
            SqlDataSourceView dsv = (SqlDataSourceView)sender;
            Label1.Text += "<br/>SqlDataSource3: " + genSQLCmd(command.CommandText, command.Parameters);
        }

        protected void DropDownList1_DataBound(object sender, EventArgs e)
        {
            DropDownList1.Items.Insert(0, new ListItem("- Select -", ""));
        }

        protected void DropDownList2_DataBound(object sender, EventArgs e)
        {
            DropDownList2.Items.Insert(0, new ListItem("- Select -", ""));
        }

        protected void DropDownList3_DataBound(object sender, EventArgs e)
        {
            DropDownList3.Items.Insert(0, new ListItem("- Select -", ""));
        }
        

       
    }
}