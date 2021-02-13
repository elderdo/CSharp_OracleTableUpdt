using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IRVT
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["Prime"] != null && Request.QueryString["Prime"] != "")
            {
                SqlDataSource1.SelectCommand += " and prime = '" + Request.QueryString["Prime"] + "' ";
                if (Request.QueryString["ItemId"]  != null && Request.QueryString["ItemId"] != "")
                {
                    SqlDataSource1.SelectCommand += " and ITEM_ID = '" + Request.QueryString["ItemId"] + "'";
                    if (Request.QueryString["VendorCode"] != null && Request.QueryString["VendorCode"] != "")
                    {
                        SqlDataSource1.SelectCommand += " and VENDOR_CODE = '" + Request.QueryString["VendorCode"] + "'";
                    }
                }
            }
            SqlDataSource1.SelectCommand += " order by location";
            StatusLabel.Text = "";
        }

        protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }

        private bool tableCopied = false;
        private System.Data.DataTable originalDataTable;

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
                if (!tableCopied)
                {
                    originalDataTable = ((System.Data.DataRowView)e.Row.DataItem).Row.Table.Copy();
                    ViewState["originalValuesDataTable"] = originalDataTable;
                    tableCopied = true;
                }
        }
        protected void UpdateButton_Click(object sender, EventArgs e)
        {
            originalDataTable = (System.Data.DataTable)ViewState["originalValuesDataTable"];
            int cnt = 0;
            foreach (GridViewRow r in GridView1.Rows)
                if (isRowModified(r)) 
                { 
                    GridView1.UpdateRow(r.RowIndex, false);
                    cnt++;
                }
            // rebind the Grid to repopulate the original values table
            if (cnt > 0)
            {
                StatusLabel.Text = "Update Complete";
            }
            else
            {
                StatusLabel.Text = "";
            }
            tableCopied = false;
            GridView1.DataBind();
        }

        protected bool isRowModified(GridViewRow r)
        {
            string currentPrime;
            string currentItemId;
            string currentVendorCode;

            string currentInduct;

            currentPrime = GridView1.DataKeys[r.RowIndex].Values["PRIME"].ToString();
            currentItemId = GridView1.DataKeys[r.RowIndex].Values["ITEM_ID"].ToString();
            currentVendorCode = GridView1.DataKeys[r.RowIndex].Values["VENDOR_CODE"].ToString();

            currentInduct = ((DropDownList)r.FindControl("DropDownList2")).Text;
            if (originalDataTable.Rows.Count > 0)
            {
                System.Data.DataRow row =
                    originalDataTable.Select(String.Format("PRIME = '{0}' and ITEM_ID = '{1}' and VENDOR_CODE = '{2}'", currentPrime, currentItemId, currentVendorCode))[0];

                if ((!currentInduct.Equals(row["INDUCT"].ToString()))) { return true; }

            }
            return false;
        }
    }
}