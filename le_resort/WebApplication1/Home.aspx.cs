using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.localhost;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["idn"] = "1";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            /*WebService1 web = new WebService1();
            DataTable dt = web.GetAllClients();
            //DataTable dt = web.();



            foreach (DataRow dr in dt.Rows)
          {
                TextBox1.Text = dr["idClient"].ToString();
          }*/
            
           Response.Redirect("Client.aspx");
            
            


        }

        
    }
}