using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AWebForm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string name = TextBox1.Text;
        string type = DropDownList1.SelectedValue;
        string filename = FileUpload1.FileName;
        //todo: add to DB

        FileUpload1.SaveAs(Server.MapPath("~/Content/" + filename));
        Feedback.Text = "Submission saved.";
    }
}