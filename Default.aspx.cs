using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        CreateTable();
    }

    private void CreateTable()
    {
        DataTable dt = new DataTable();
        dt.Columns.Add("ID");
        dt.Columns.Add("Name");
        dt.Columns.Add("email");

        DataRow dr = dt.NewRow();
        dr[0] ="1"; 
        dr[1] ="Pavan1"; 
        dr[2] ="pavanshevle13@gmail.com";
        dt.Rows.Add(dr);
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
}
