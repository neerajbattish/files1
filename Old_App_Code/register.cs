using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using Microsoft.ApplicationBlocks.Data;

/// <summary>
/// Summary description for register
/// </summary>
public class register
{
	SqlConnection con = new SqlConnection();
    public register()
    {
        con.ConnectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }

    }
    private string _R_FName;
    public string R_FName
    {
        get { return _R_FName; }
        set { _R_FName = value; }
    }
    private string _R_gender;
    public string R_gender
    {
        get { return _R_gender; }
        set { _R_gender = value; }
    }
    private int _R_GP_ID;
    public int R_GP_ID
    {
        get { return _R_GP_ID; }
        set { _R_GP_ID = value; }
    }
    private string _R_emailid;
    public string R_emailid
    {
        get { return _R_emailid; }
        set { _R_emailid = value; }
    }
    private string _R_logid;
    public string R_logid
    {
        get { return _R_logid; }
        set { _R_logid = value; }
    }
    private string _R_password;
    public string R_password
    {
        get { return _R_password; }
        set { _R_password = value; }
    }
    private string _R_type;
    public string R_type
    {
        get { return  _R_type; }
        set { _R_type = value; }
    }
    public string insertuser()
    {
        SqlParameter[] param = null;
        try
        {
            param = new SqlParameter[4];
            param[0] = new SqlParameter("@username", R_FName );
            //param[1] = new SqlParameter("@gender", R_gender );
            param[1] = new SqlParameter("@emailid", R_emailid );
            param[2] = new SqlParameter("@logid", R_logid );
            param[3] = new SqlParameter("@pass", R_password );
           // param[4] = new SqlParameter("@pass", R_type);

            return Convert.ToString(SqlHelper.ExecuteNonQuery(con, CommandType.StoredProcedure, "Addusers", param));
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            param = null;
        }
    }
}