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
using System.Security.Cryptography;

/// <summary>
/// Summary description for AESK
/// </summary>
public class AESK
{
    SqlConnection con = new SqlConnection();
    
	public AESK()
	{
        con.ConnectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }
	}
   public string Encrypt(string clearText)
    {
        string EncryptionKey = clearText;
        byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
        using (Aes encryptor = Aes.Create())
        {
            Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
            encryptor.Key = pdb.GetBytes(32);
            encryptor.IV = pdb.GetBytes(16);
            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(clearBytes, 0, clearBytes.Length);
                    cs.Close();
                }
                clearText = Convert.ToBase64String(ms.ToArray());
            }
        }
        var randoma = new Random();
        var resulta = new string(Enumerable.Repeat(clearText, 16).Select(s => s[randoma.Next(s.Length)]).ToArray());
        return resulta;
    }
}