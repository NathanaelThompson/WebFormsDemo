using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Registration : System.Web.UI.Page
{
    MySql.Data.MySqlClient.MySqlConnection conn;
    MySql.Data.MySqlClient.MySqlCommand cmd;
    string queryStr;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void submitButton_Click(object sender, EventArgs e)
    {
        RegisterUser();
    }
    private void RegisterUser()
    {
        string comma = "','";
        string connString = System.Configuration.ConfigurationManager.ConnectionStrings["webFormConnString"].ToString();
        conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
        conn.Open();
        queryStr = "INSERT INTO webformdemo.userregistration (firstname, middlename, lastname, email, phone, username, password) " +
            "VALUES ('" + fnBox.Text + comma + mnBox.Text + comma + lnBox.Text + comma + emailBox.Text + comma + phoneBox.Text + 
            comma + usernameBox.Text + comma + passwordBox.Text + "')";
        cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, conn);
        cmd.ExecuteReader();
        conn.Close();
    }
}