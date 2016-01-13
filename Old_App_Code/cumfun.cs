using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Data.OleDb;
using System.Configuration;
using System.IO;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;


/// <summary>
/// Summary description for cumfun
/// </summary>
public class cumfun
{
    SqlConnection con = new SqlConnection();
    SqlCommand cmd = new SqlCommand();
    SqlDataAdapter da = new SqlDataAdapter();
    SqlDataReader dr;
    DataSet ds = new DataSet();
    DataTable dt = new DataTable();
    DataRow drow;
    public cumfun()
    {
        con.ConnectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }
    }

    public void UpdateData(string str)
    {
        
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = str;
            cmd.ExecuteNonQuery();
            con.Close();
                   
    }


    public string datechange(string Indate)
    {
        string odate = null;
        String[] arr = Indate.Split('/');
        odate = arr[1] + "/" + arr[0] + "/" + arr[2];
        return odate;
    }

    public string getdateServer()
    {
        string functionReturnValue = null;
        try
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader dread1 = default(SqlDataReader);
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand("Select convert(varchar,getdate(),103) as date", con);
            dread1 = cmd.ExecuteReader();
            if (dread1.HasRows)
            {
                if (dread1.Read())
                {
                    functionReturnValue = dread1.GetValue(0).ToString();
                }
            }
            dread1.Close();
            cmd.Dispose();
        }
        catch (Exception ex)
        {
            con.Close();
        }
        return functionReturnValue;
    }

    public SqlDataReader FillDataReader(string str)
    {
        try
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = str;
            cmd.Connection = con;
            dr = cmd.ExecuteReader();
            return dr;
        }
        catch (Exception ex)
        {
            return null;
        }

    }

    public void FillCmb(String str, Object ItemArray, string FirstR, System.Web.UI.WebControls.DropDownList DropDownName)
    {
        try
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            DataTable dt = new DataTable();
            dt.Clear();
            DataRow drow;
            SqlDataAdapter da = new SqlDataAdapter(str, con);
            da.Fill(dt);
            drow = dt.NewRow();
            drow.ItemArray = new object[] { FirstR, 0 };
            dt.Rows.InsertAt(drow, 0);
            DropDownName.DataSource = dt;
            DropDownName.DataValueField = dt.Columns[1].ToString(); 
            DropDownName.DataTextField = dt.Columns[0].ToString();
            DropDownName.DataBind();
            con.Close();
        }
        catch (Exception ex)
        {
            // MessageBox.Show(ex.Message);
        }

    }

    public Boolean IsExists(string str)
    {
        try
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.CommandText = str;
            cmd.Connection = con;
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Close();
                return true;
            }
            else
            {
                dr.Close();
                return false;
            }
        }
        catch (Exception ex)
        {
            // MessageBox.Show(ex.Message);
            return false;
        }
    }
    public DataSet RetDataset(string str)
    {
        try
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            ds.Clear();
            da = new SqlDataAdapter(str, con);
            da.Fill(ds);
            con.Close();
            return ds;
        }
        catch (Exception ex)
        {
            // MessageBox.Show(ex.Message);
            return null;
        }
    }

    public DataTable RetDataTable(string str)
    {
        try
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            ds.Clear();
            da = new SqlDataAdapter(str, con);
            da.Fill(ds);
            con.Close();
            return ds.Tables[0];
        }
        catch (Exception ex)
        {
            // MessageBox.Show(ex.Message);
            return null;
        }
    }

    public string RetVal(string str)
    {
        try
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.CommandText = str;
            cmd.Connection = con;
            string vRetVal;
            vRetVal = Convert.ToString(cmd.ExecuteScalar());
            con.Close();
            return vRetVal;
        }
        catch (Exception ex)
        {
            // MessageBox.Show(ex.Message);
            return null;
        }

    }
}
