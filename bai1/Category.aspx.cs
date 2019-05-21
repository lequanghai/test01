using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Category : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string IDCAT = Request.QueryString["IDCAT"];
            if (IDCAT != null)
            {
                dlCatelogy.DataSource = DataAccess.slectQuery("SELECT * FROM PRODUCT WHERE IDCAT = " + IDCAT);
                dlCatelogy.DataBind();
            }
        }
    }

    protected void dlCatelogy_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}