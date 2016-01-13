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
/// Summary description for comncls
/// </summary>
public class comncls
{
	SqlConnection con = new SqlConnection();
    public comncls()
    {
        con.ConnectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }

    }
    private int _ord;
    public int ord
    {
        get { return _ord; }
        set { _ord = value; }
    }
    private int _cunt;
    public int cunt
    {
        get { return _cunt; }
        set { _cunt = value; }
    }
    public DataSet userlists()
    {
        try
        {
            return SqlHelper.ExecuteDataset(con, CommandType.StoredProcedure, "userlist");
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {

        }

    }
    public DataSet resourcepbo()
    {
        try
        {
            return SqlHelper.ExecuteDataset(con, CommandType.StoredProcedure, "resourceslistpbo");
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {

        }

    }
    public DataSet resourceenhancepbo()
    {
        try
        {
            return SqlHelper.ExecuteDataset(con, CommandType.StoredProcedure, "rescenchPBO");
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {

        }

    }
    public DataSet resourceGA()
    {
        try
        {
            return SqlHelper.ExecuteDataset(con, CommandType.StoredProcedure, "resourceGA");
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {

        }

    }
    public DataSet resourceACO()
    {
        try
        {
            return SqlHelper.ExecuteDataset(con, CommandType.StoredProcedure, "rescACO");
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {

        }

    }
    public DataSet resourceadvACO()
    {
        try
        {
            return SqlHelper.ExecuteDataset(con, CommandType.StoredProcedure, "rescavdACO");
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {

        }

    }
    public DataSet GetenergyCom()
    {
        try
        {
            return SqlHelper.ExecuteDataset(con, CommandType.StoredProcedure, "CompenergyUti");
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {

        }

    }
    public DataSet GettimeCom()
    {
        try
        {
            return SqlHelper.ExecuteDataset(con, CommandType.StoredProcedure, "Comptime");
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {

        }

    }
    public DataSet getexedtl1()
    {
        SqlParameter[] param = null;
        try
        {
            param = new SqlParameter[2];
            param[0] = new SqlParameter("@num", cunt);
            param[1] = new SqlParameter("@ord", ord);
            return SqlHelper.ExecuteDataset(con, CommandType.StoredProcedure, "exedtl1", param);
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {

        }

    }
    public DataSet getexedtl2()
    {
        SqlParameter[] param = null;
        try
        {
            param = new SqlParameter[2];
            param[0] = new SqlParameter("@num", cunt);
            param[1] = new SqlParameter("@ord", ord);
            return SqlHelper.ExecuteDataset(con, CommandType.StoredProcedure, "exedtl2", param);
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {

        }

    }
    public DataSet getexedtl3()
    {
        SqlParameter[] param = null;
        try
        {
            param = new SqlParameter[2];
            param[0] = new SqlParameter("@num", cunt);
            param[1] = new SqlParameter("@ord", ord);
            return SqlHelper.ExecuteDataset(con, CommandType.StoredProcedure, "exedtl3", param);
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