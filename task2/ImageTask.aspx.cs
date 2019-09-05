using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace task2
{
    public partial class ImageTask : System.Web.UI.Page
    {
        SqlConnection sql = new SqlConnection(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnsave_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(Server.MapPath("Images")))
            {
                Directory.CreateDirectory(Server.MapPath("Images"));
            }
            string imageurl = (Server.MapPath("Images") + "\\" + fileupload.FileName);
            string dppathimg = "~/Images/" + fileupload.FileName;
            fileupload.SaveAs(imageurl);

            SqlCommand cmd = new SqlCommand("insert into ImageUpload (ImageURL, ImageName) values (@ImageURL, @ImageName)", sql);
            cmd.Parameters.AddWithValue("@ImageURL", dppathimg);
            cmd.Parameters.AddWithValue("@ImageName", dppathimg);
            sql.Open();
            cmd.ExecuteNonQuery();
            sql.Close();
        }
    }
}