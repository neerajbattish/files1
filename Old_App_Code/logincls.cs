using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Microsoft.ApplicationBlocks.Data;
using System.Data;
using System.Data.SqlClient;

using System.Configuration;
/// <summary>
/// Summary description for logincls
/// </summary>
public class logincls
{
    SqlConnection con = new SqlConnection();
    public logincls()
    {
        con.ConnectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }

    }
    public bool loginchk(string u, string p,string t)
    {


        SqlParameter[] param = null;
        SqlDataReader dr = null;
        try
        {
            param = new SqlParameter[3];
            param[0] = new SqlParameter("@user_name", u);
            param[0].Direction = ParameterDirection.Input;
            param[1] = new SqlParameter("@password", p);
            param[1].Direction = ParameterDirection.Input;
            param[2] = new SqlParameter("@grpid", t);
            param[2].Direction = ParameterDirection.Input;
            dr = SqlHelper.ExecuteReader(con, CommandType.StoredProcedure, "LOGINSTATUS", param);
            if (dr.HasRows)
            {
                dr.Read();
                HttpContext.Current.Session["sessionuserid"] = dr["R_id"].ToString();

                return true;
            }
            else
            {
                return false;
            }


        }
        catch (Exception ex)
        {
            throw ex;

        }
        finally
        {
            param = null;
            dr.Dispose();
            dr.Close();
        }

    }

    public bool loginchkstatus(string u, string p,string t)
    {

        SqlDataReader dr = null;
        try
        {
            string query = "LOGINCHK";   //stored procedure Name
            SqlCommand com = new SqlCommand(query, con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@user_name", u);
            com.Parameters.AddWithValue("@password", p);
            com.Parameters.AddWithValue("@grpid", t);
            

            int usercount = (Int32)com.ExecuteScalar();// for taking single value

            if (usercount == 1)  // comparing users from table 
            {
                return true;
            }
            else
            {
                return false;
            }
          
        }
        catch (Exception ex)
        {
            throw ex;

        }
        finally
        {

           
            
        }
    }
}