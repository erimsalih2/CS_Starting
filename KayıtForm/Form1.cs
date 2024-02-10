using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLFORM.SQLvariables;
using System.Data.SqlClient;
using KayıtForm;

namespace KayıtForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand loginCmd = new SqlCommand("select * from Sifreleme where UserMail=@pmail and UserPassword=@pPassword",SQLVariables.connect);
            SQLVariables.CheckConnection(SQLVariables.connect);
            string Converted=Sha256Converter.ComputeSha256Hash(TboxPassword.Text);
            loginCmd.Parameters.AddWithValue("@pmail", TboxLogUser.Text);
            loginCmd.Parameters.AddWithValue ("@pPassword", Converted);
            SqlDataAdapter da = new SqlDataAdapter(loginCmd);

            DataTable dt = new DataTable(); 
            da.Fill(dt);


            if(dt.Rows.Count > 1)
            {
                MessageBox.Show("YUHHHHHHHHHHHHHHHHHHHHHH");
            }
            if(dt.Rows.Count > 0)
            {
                MessageBox.Show("Giriş Başarılı");

            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı");
            }
            TboxLogUser.Text = string.Empty;TboxLogpass.Text = string.Empty;
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            SqlCommand commandRegister = new SqlCommand("insert into Sifreleme (UserName,UserSurname,UserMail,UserPassword) values(@pname,@psurname,@pmail,@pPassword)", SQLVariables.connect);
            SQLVariables.CheckConnection(SQLVariables.connect);

            string ConvertedString = Sha256Converter.ComputeSha256Hash(TboxPassword.Text);
            commandRegister.Parameters.AddWithValue("@pname", TboxName.Text);
            commandRegister.Parameters.AddWithValue("@psurname", TboxSurname.Text);
            commandRegister.Parameters.AddWithValue("@pmail", TboxMail.Text);
            commandRegister.Parameters.AddWithValue("@pPassword", ConvertedString);
            commandRegister.ExecuteNonQuery();

            TboxName.Text = string.Empty; TboxSurname.Text = string.Empty;TboxMail.Text = string.Empty;TboxPassword.Text = string.Empty;    
            MessageBox.Show("Başarıyla Kayıt olundu");
        }
    }
}
