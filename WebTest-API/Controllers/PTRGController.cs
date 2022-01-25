using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebTest_API.Controllers
{
    public class PTRGController : ApiController
    {
        // GET: api/PTRG
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/PTRG/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/PTRG
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/PTRG/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/PTRG/5
        public void Delete(int id)
        {
        }

        //[Route("api/Log/{lat}/{lon}")]
        [HttpGet]
        //[Route("{http://192.168.1.5:8080/api/table.xml?content=messages&columns=objid,datetime,parent,type,name,status,message&username=prtgadmin&password=prtgadmin}")]
        [Route("{//192.168.1.5:8080/api/table.xml?content=messages&columns=objid,datetime,parent,type,name,status,message&username=prtgadmin&password=prtgadmin}")]
        public string Get(int messages, int messages_listend, int messages_totalcount, string messages_prtg_version, int messages_item, int messages_item_objid, DateTime messages_item_datetime,
            int messages_item_datetime_raw, string messages_item_parent, string messages_item_type, string messages_item_type_raw, string messages_item_name, string messages_item_status, int messages_item_status_raw,
            string messages_item_message, string messages_item_message_raw)
        {
            //Get the SQL Server database connection string from
            //the Web.config file
            ConnectionStringSettings settings;
            settings = System.Configuration.ConfigurationManager.ConnectionStrings["con"];
            string connectionString = settings.ConnectionString;

            //Create a new SQL Server database connection
            SqlConnection conn;
            conn = new SqlConnection(connectionString);
            try
            {
                //Open a connection
                conn.Open();

                //Create a parameterized SQL command to insert
                string query = "insert into PRTG  VALUES( messages int, messages_listend int, messages_totalcount int, messages_prtg_version nvarchar(12) , messages_item int, messages_item_objid int, "
           + " , messages_item_datetime datetime, messages_item_datetime_raw numeric(15, 10), messages_item_parent nvarchar(22), messages_item_type nvarchar(21), messages_item_type_raw nvarchar(12), "
           + " , messages_item_name nvarchar(46), messages_item_status nvarchar(20), messages_item_status_raw int, messages_item_message nvarchar(152), messages_item_message_raw nvarchar(94),)" ;


                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("messages", messages);
                cmd.Parameters.AddWithValue("messages_listend", messages_listend);
                cmd.Parameters.AddWithValue("messages_totalcount", messages_totalcount);
                cmd.Parameters.AddWithValue("messages_prtg_version", messages_prtg_version);
                cmd.Parameters.AddWithValue("messages_item", messages_item);
                cmd.Parameters.AddWithValue("messages_item_objid", messages_item_objid);
                cmd.Parameters.AddWithValue("messages_item_datetime", messages_item_datetime);
                cmd.Parameters.AddWithValue("messages_item_datetime_raw", messages_item_datetime_raw);
                cmd.Parameters.AddWithValue("messages_item_parent", messages_item_parent);
                cmd.Parameters.AddWithValue("messages_item_type", messages_item_type);
                cmd.Parameters.AddWithValue("messages_item_type_raw", messages_item_type_raw);
                cmd.Parameters.AddWithValue("messages_item_name", messages_item_name);
                cmd.Parameters.AddWithValue("messages_item_status", messages_item_status);
                cmd.Parameters.AddWithValue("messages_item_status_raw", messages_item_status_raw);
                cmd.Parameters.AddWithValue("messages_item_message", messages_item_message);
                cmd.Parameters.AddWithValue("messages_item_message_raw", messages_item_message_raw);

                //Run the insert statement
                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:" + ex.Message);
            }
            return "ok";
        }
    }
}
