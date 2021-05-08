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
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Session["idn"].ToString();
            WebService1 web = new WebService1();
            int idClient = 0;

            DataTable dtc = web.GetSpecificClients(Int32.Parse(Session["idn"].ToString()));
            foreach (DataRow dr in dtc.Rows)
            {
                 idClient = Int32.Parse(dr["idClient"].ToString());
                Label1.Text = dr["name"].ToString() + dr["lastName"].ToString();
            }

            DataTable dt = web.GetSpecificReserve(idClient);


            foreach (DataRow dr in dt.Rows)
            {
                Label2.Text ="el dia de tu reserva es: " + dr["arrivalDate"].ToString() + "el dia de tu salida es: " + dr["finishDate"].ToString() + ". Tu Habitación es: " + dr["typeRoom"].ToString();  
            }
        }
    }
}