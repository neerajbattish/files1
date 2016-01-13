using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Text;
using System.Security.Cryptography;


namespace WebApplication1
{
    public partial class uploadbase : System.Web.UI.Page
    {
        cumfun cls = new cumfun();
        String a;
        string Passphrase;
        string filename;
        byte[] Results;
        AESK ak = new AESK();
        string AESKEy;
        int pid;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["sessionuserid"] == null)
            {
                Server.Transfer("~/login/loginpage.aspx");
                Response.Redirect("~/login/loginpage.aspx");
                return;
            }
            if (!Page.IsPostBack)
            {

            }
        }
        public void encryption()
        {
            byte[] file = new byte[FileUpload1.PostedFile.ContentLength];
            FileUpload1.PostedFile.InputStream.Read(file, 0, FileUpload1.PostedFile.ContentLength);
            string fileName = txtfilename.Text;
            byte[] Key = Encoding.UTF8.GetBytes(LTRPRIKEY.Text);
            ASCIIEncoding.ASCII.GetString(Key);
            try
            {
                string outputFile = Path.Combine(Server.MapPath("~/uploadfiles/base"), fileName);

                FileStream fs = new FileStream(outputFile, FileMode.Create);
                RijndaelManaged rmCryp = new RijndaelManaged();
                CryptoStream cs = new CryptoStream(fs, rmCryp.CreateEncryptor(Key, Key), CryptoStreamMode.Write);
                foreach (var data in file)
                {
                    cs.WriteByte((byte)data);
                }
                cs.Close();
                fs.Close();
                insert();


            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "popup",
                   "alert(" + ex + ");", true);
            }
        }



        public void clearall()
        {
            txtcommnt.Text = "";
            txtdiscptn.Text = "";
            txtfilename.Text = "";

        }
        public void insert()
        {
            try
            {
                Label1.Text = "";
                clsjob obj = new clsjob();
                obj.UP_FileName = txtfilename.Text;
                obj.UP_FileTypeId = 0;
                obj.UP_Discription = txtdiscptn.Text;
                obj.UP_Comment = txtcommnt.Text;
                obj.UP_PrivateKey = LTRPRIKEY.Text;
                obj.UP_r_id = Convert.ToInt32(Session["sessionuserid"]);
                obj.baseInsertfile();


            }
            catch
            {
                //Label1.Visible = true;
                //Label1.Text = "Error Please try again.";
                //Label1.ForeColor = System.Drawing.Color.Red;
            }
        }


        public void matadata()
        {
            try
            {

                pid = Convert.ToInt32(cls.RetVal("select Top 1 up_id from uploadfileslist  order by up_id desc"));
                string filename = (Server.MapPath("~/all/base/") + txtfilename.Text);
                string inputString = File.ReadAllText(filename);
                inputString = inputString.ToLower();

                string[] stripChars = { ";", ",", ".", "-", "_", "^", "(", ")", "[", "]","'",
						"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "\n", "\t", "\r" };
                foreach (string character in stripChars)
                {
                    inputString = inputString.Replace(character, "");
                }
                List<string> wordList = inputString.Split(' ').ToList();
                Dictionary<string, int> dictionary = new Dictionary<string, int>();
                foreach (string word in wordList)
                {
                    if (word.Length >= 3)
                    {
                        if (dictionary.ContainsKey(word))
                        {
                            dictionary[word]++;
                        }
                        else
                        {
                            dictionary[word] = 1;
                        }
                    }
                }
                var sortedDict = (from entry in dictionary orderby entry.Value descending select entry).ToDictionary(pair => pair.Key, pair => pair.Value);
                cumfun obj = new cumfun();
                foreach (KeyValuePair<string, int> pair in sortedDict)
                {
                    if (pair.Value <= 2)
                    {
                    }
                    else
                    {
                        obj.UpdateData("insert into matadatabase values('" + pair.Key + "','" + pair.Value + "','" + pid + "')");
                    }
                }
                clearall();
                Label1.Visible = true;
                Label1.Text = "File Uploaded Successfully.";
                Label1.ForeColor = System.Drawing.Color.Green;
            }
            catch
            {
                Label1.Visible = true;
                Label1.Text = "Error Please try again.";
                Label1.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void btnkey_Click(object sender, EventArgs e)
        {
            if (cls.IsExists("select * from uploadfileslist where UP_FileName='" + txtfilename.Text + "' ") == true)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "popup",
                "alert('File Name Already exist. Choose A Different File Name.');", true);
                txtfilename.Text = "";
                return;
            }
            else
            {
                try
                {
                    //string abcc= FileUpload1.PostedFile.FileName.; 
                    filename = txtfilename.Text;
                    FileUpload1.SaveAs(Server.MapPath("~/all/base/") + filename);
                    Passphrase = filename;
                    System.Text.UTF8Encoding UTF8 = new System.Text.UTF8Encoding();
                    MD5CryptoServiceProvider HashProvider = new MD5CryptoServiceProvider();
                    byte[] TAESKey = HashProvider.ComputeHash(UTF8.GetBytes(Passphrase));
                    TripleDESCryptoServiceProvider TAESAlgorithm = new TripleDESCryptoServiceProvider();
                    TAESAlgorithm.Key = TAESKey;
                    TAESAlgorithm.Mode = CipherMode.ECB;
                    TAESAlgorithm.Padding = PaddingMode.PKCS7;
                    byte[] DataToEncrypt = UTF8.GetBytes(filename);
                    try
                    {
                        ICryptoTransform Encryptor = TAESAlgorithm.CreateEncryptor();
                        Results = Encryptor.TransformFinalBlock(DataToEncrypt, 0, DataToEncrypt.Length);
                    }
                    finally
                    {
                        TAESAlgorithm.Clear();
                        HashProvider.Clear();
                        AESKEy = ak.Encrypt("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789");
                        AESKEy = AESKEy.Substring(0, 16);
                        LTRPRIKEY.Text = AESKEy;
                        encryption();
                        matadata();

                    }
                }
                catch (Exception ex)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "popup",
                       "alert('" + ex + "');", true);
                }
            }

        }
    }
}