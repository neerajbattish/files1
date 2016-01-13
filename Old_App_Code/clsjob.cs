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
/// Summary description for clsjob
/// </summary>
public class clsjob
{
    SqlConnection con = new SqlConnection();
    public clsjob()
    {
        con.ConnectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }

    }
    private int _UP_ID;
    public int UP_ID
    {
        get { return _UP_ID; }
        set { _UP_ID = value; }
    }
    private string _UP_FileName;
    public string UP_FileName
    {
        get { return _UP_FileName; }
        set { _UP_FileName = value; }
    }
    private int _UP_FileTypeId;
    public int UP_FileTypeId
    {
        get { return _UP_FileTypeId; }
        set { _UP_FileTypeId = value; }
    }
    private string _UP_Discription;
    public string UP_Discription
    {
        get { return _UP_Discription; }
        set { _UP_Discription = value; }
    }
    private string _UP_Comment;
    public string UP_Comment
    {
        get { return _UP_Comment; }
        set { _UP_Comment = value; }
    }
    private string _UP_PrivateKey;
    public string UP_PrivateKey
    {
        get { return _UP_PrivateKey; }
        set { _UP_PrivateKey = value; }
    }
    private string _UP_AESPrivateKey;
    public string UP_AESPrivateKey
    {
        get { return _UP_AESPrivateKey; }
        set { _UP_AESPrivateKey = value; }
    }
    
    
    private int _UP_r_id;
    public int UP_r_id
    {
        get { return _UP_r_id; }
        set { _UP_r_id = value; }
    }
   

   
    public string baseInsertfile()
    {
        SqlParameter[] param = null;
        try
        {
            param = new SqlParameter[6];
            param[0] = new SqlParameter("@filename", UP_FileName);
            param[1] = new SqlParameter("@filetype", UP_FileTypeId);
            param[2] = new SqlParameter("@discription", UP_Discription);
            param[3] = new SqlParameter("@comment", UP_Comment);
            param[4] = new SqlParameter("@privatekey", UP_PrivateKey);
             param[5] = new SqlParameter("@URID", UP_r_id);
            return Convert.ToString(SqlHelper.ExecuteNonQuery(con, CommandType.StoredProcedure, "fileupload", param));
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

    
    public string advnInsertfile()
    {
        SqlParameter[] param = null;
        try
        {
            param = new SqlParameter[6];
            param[0] = new SqlParameter("@filename", UP_FileName);
            param[1] = new SqlParameter("@filetype", UP_FileTypeId);
            param[2] = new SqlParameter("@discription", UP_Discription);
            param[3] = new SqlParameter("@comment", UP_Comment);
            param[4] = new SqlParameter("@privatekey", UP_PrivateKey);
            param[5] = new SqlParameter("@URID", UP_r_id);
            return Convert.ToString(SqlHelper.ExecuteNonQuery(con, CommandType.StoredProcedure, "advncfileupload", param));
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
