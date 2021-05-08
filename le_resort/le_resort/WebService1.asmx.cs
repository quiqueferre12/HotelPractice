using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SQLite;
using System.Security.Cryptography;
using System.Text;

namespace le_resort
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
       
        
        public string DBpath = HttpRuntime.AppDomainAppPath + "database.db";

        
        [WebMethod]
        public DataTable GetAllClients()
        {
            string DBpath = Server.MapPath("database.db");
            DataTable dt = new DataTable();
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + DBpath + ";Version=3;"))
            {
                conn.Open();
                SQLiteCommand comm = new SQLiteCommand("SELECT * FROM clients", conn);
                SQLiteDataReader reader = comm.ExecuteReader();
                dt.Load(reader);
                conn.Close();
            }
            return dt;
        }
        [WebMethod]
        public DataTable GetAllReserve()
        {
            string DBpath = Server.MapPath("database.db");
            DataTable dt = new DataTable();
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + DBpath + ";Version=3;"))
            {
                conn.Open();
                SQLiteCommand comm = new SQLiteCommand("SELECT * FROM reserve", conn);
                SQLiteDataReader reader = comm.ExecuteReader();
                dt.Load(reader);
                conn.Close();
            }
            return dt;
        }

        [WebMethod]
        public DataTable GetSpecificClients(int idn)
        {
            string DBpath = Server.MapPath("database.db");
            DataTable dt = new DataTable();
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + DBpath + ";Version=3;"))
            {
                
                conn.Open();
                SQLiteCommand comm = new SQLiteCommand("SELECT * FROM clients Where idn = " + idn, conn);
                SQLiteDataReader reader = comm.ExecuteReader();
                dt.Load(reader);
                conn.Close();
            }
            return dt;
        }

        [WebMethod]
        public DataTable GetSpecificReserve(int idClient)
        {
            string DBpath = Server.MapPath("database.db");
            DataTable dt = new DataTable();
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + DBpath + ";Version=3;"))
            {
                conn.Open();
                SQLiteCommand comm = new SQLiteCommand("SELECT * FROM reserve Where idClient =' " + idClient + "'", conn);
                SQLiteDataReader reader = comm.ExecuteReader();
                dt.Load(reader);
                conn.Close();
            }
            return dt;
        }

        [WebMethod]
        public DataTable LoginC(int idn)
        {
            DataTable dt = new DataTable();
            string DBpath = Server.MapPath("database.db");
            SQLiteConnection conn = new SQLiteConnection("Data Source=" + DBpath + ";Version=3;");

            conn.Open();
            using (conn)
            {
                SQLiteCommand comm = new SQLiteCommand("SELECT * FROM Clients WHERE idn='" + idn + "'", conn);
                SQLiteDataReader reader = comm.ExecuteReader();
                dt.Load(reader);
                reader.Close();
            }
            return dt;
        }
        [WebMethod]
        public DataTable LoginR(string user)
        {
            DataTable dt = new DataTable();
            string DBpath = Server.MapPath("database.db");
            SQLiteConnection conn = new SQLiteConnection("Data Source=" + DBpath + ";Version=3;");

            conn.Open();
            using (conn)
            {
                SQLiteCommand comm = new SQLiteCommand("SELECT * FROM receptionist WHERE name ='" + user + "'", conn);
                SQLiteDataReader reader = comm.ExecuteReader();
                dt.Load(reader);
                reader.Close();
            }
            return dt;
        }

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

    }
}
