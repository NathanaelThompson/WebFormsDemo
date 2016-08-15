using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    MySql.Data.MySqlClient.MySqlConnection conn;
    MySql.Data.MySqlClient.MySqlCommand cmd;
    MySql.Data.MySqlClient.MySqlDataReader reader;
    string queryStr;
    string name;

    protected void Page_Load(object sender, EventArgs e)
    {
        Utility.CreateAppendLogFile("Loaded default page");
    }
    public string EchoTitle()
    {
        return this.Title;
    }

    protected void titleButton_Click(object sender, EventArgs e)
    {
        Utility.CreateAppendLogFile("Changed title of Default Page");
        this.Title = titleBox.Text;
    }

    protected void defaultCal_SelectionChanged(object sender, EventArgs e)
    {
        selectedDate.Text = defaultCal.SelectedDate.ToString();
    }

    protected void loginButton_Click(object sender, EventArgs e)
    {
        //from web.config
        string connString = System.Configuration.ConfigurationManager.ConnectionStrings["webFormConnString"].ToString();
        conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
        conn.Open(); //must have matching conn.Close()

        //select everything from schema.table where username and password entered equals username and password in database
        queryStr = "SELECT * FROM webformdemo.userregistration WHERE username='" + usernameBox.Text + "' AND password='" + passwordBox.Text + "'";
        cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, conn);
        reader = cmd.ExecuteReader();
        name = "";
        while(reader.HasRows && reader.Read())
        {
            name = reader.GetString(reader.GetOrdinal("firstname")) + " " +
                reader.GetString(reader.GetOrdinal("middlename")) + " " +
                reader.GetString(reader.GetOrdinal("lastname"));

        }
        if(reader.HasRows)
        {
            //use Session to share info across pages
            Session["uname"] = name;
            Response.BufferOutput = true;
            Response.Redirect("LoggedIn.aspx", false);
        }
        else
        {
            passwordBox.Text = "Invalid Username or Password";
        }
        reader.Close();
        conn.Close();

    }
}