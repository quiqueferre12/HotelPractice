using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.localhost;

namespace WebApplication1
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        public DataTable dt = new DataTable();
        public WebService1 wes;
       

        protected void Page_Load(object sender, EventArgs e)
        {
            wes = new WebService1();
        }


        

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int user = Int32.Parse(txtUser.Text);

                dt = wes.LoginC(user);

                foreach (DataRow dr in dt.Rows)
                {
                    if (txtPassword.Text == dr["pass"].ToString())
                    {
                       Session["idn"] = dr["idn"].ToString();
                        Response.Redirect("Client.aspx");
                    }
                }
            }
            catch (Exception)
            {

            }

            try
            {
                string user = txtUser.Text;

                dt = wes.LoginR(user);

                foreach (DataRow dr in dt.Rows)
                {
                    if (txtPassword.Text == dr["password"].ToString())
                    {
                        Session["idReceptionist"] = dr["idReceptionist"].ToString();
                        Response.Redirect("Receptionist.aspx");
                    }
                }
            }
            catch (Exception)
            {

            }
        }
    }

}
