using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Configuration;
using System.IO;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI.WebControls;
using Microsoft.ApplicationBlocks.Data;
/// <summary>
/// Summary description for serch
/// </summary>
public class serch
{
    SqlConnection con = new SqlConnection();
    public serch()
    {
        con.ConnectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }
    }
    private int _ser_UP_ID;
    public int ser_UP_ID
    {
        get { return _ser_UP_ID; }
        set { _ser_UP_ID = value; }
    }
    private int _ser_count;
    public int ser_count
    {
        get { return _ser_count; }
        set { _ser_count = value; }
    }
    private int _counter;
    public int counter
    {
        get { return _counter; }
        set { _counter = value; }
    }
    private string _words;
    public string words
    {
        get { return _words; }
        set { _words = value; }
    }

    public string baseserch()
    {
        SqlParameter[] param = null;
        try
        {
            param = new SqlParameter[3];
            param[0] = new SqlParameter("@serupid", ser_UP_ID);
            param[1] = new SqlParameter("@sercount", ser_count);
            param[2] = new SqlParameter("@counters", counter );
            return Convert.ToString(SqlHelper.ExecuteNonQuery(con, CommandType.StoredProcedure, "serchbase", param));
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


    public DataSet fillserchreslt()
    {
        SqlParameter[] param = null;
        try
        {
            param = new SqlParameter[1];
           
            param[0] = new SqlParameter("@counters", counter);
            return SqlHelper.ExecuteDataset(con, CommandType.StoredProcedure, "serchresults", param);
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

    public DataSet fillist()
    {
        
        try
        {

            return SqlHelper.ExecuteDataset(con, CommandType.StoredProcedure, "filess");
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {

        }

    }

    public DataSet advncemetalist()
    {
        SqlParameter[] param = null;
        try
        {
            param = new SqlParameter[1];
            
            param[0] = new SqlParameter("@id", ser_UP_ID);
            return SqlHelper.ExecuteDataset(con, CommandType.StoredProcedure, "advmetalist", param);
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {

        }

    }


    public DataSet metaserch()
    {
        SqlParameter[] param = null;
        try
        {
            param = new SqlParameter[2];
            param[0] = new SqlParameter("@words", words);
            param[1] = new SqlParameter("@upid", ser_UP_ID);
            return SqlHelper.ExecuteDataset(con, CommandType.StoredProcedure, "metserchbase", param);
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