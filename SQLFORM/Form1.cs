using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SQLFORM.SQLvariables;

namespace SQLFORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("Select * from Ogrenci",SQLVariables.connect);
            SQLVariables.CheckConnection(SQLVariables.connect);
            SqlDataAdapter da =new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            SQLVariables.CheckConnection(SQLVariables.connect);
        }
        public void RefreshPage()
        {
            SqlCommand cmd = new SqlCommand("Select * from Ogrenci", SQLVariables.connect);
            SQLVariables.CheckConnection(SQLVariables.connect);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand commandAdd = new SqlCommand("Insert into Ogrenci (Ad,Soyad,Dogum_yili,Bolum) values (@pname,@plastname,@pbirth,@pmajor)",SQLVariables.connect);
            SQLVariables.CheckConnection (SQLVariables.connect);
            commandAdd.Parameters.AddWithValue("@pname", textBoxAd.Text);
            commandAdd.Parameters.AddWithValue("@plastname", textBoxSoyad.Text);
            commandAdd.Parameters.AddWithValue("@pbirth", textBoxDogum.Text);
            commandAdd.Parameters.AddWithValue("@pmajor", textBoxBolum.Text);

            commandAdd.ExecuteNonQuery();
            RefreshPage();  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RefreshPage();
            
            textBoxAd.Text="";
            textBoxSoyad.Text = "";
            textBoxDogum.Text = "";
            textBoxBolum.Text = "";
        }
        string GGID;
        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            SqlCommand CMDdelete = new SqlCommand("Delete from Ogrenci where OgrenciNo=@pid",SQLVariables.connect);
            SQLVariables.CheckConnection(SQLVariables.connect);
            CMDdelete.Parameters.AddWithValue("@pid",Convert.ToInt32(GGID));

            CMDdelete.ExecuteNonQuery();
            RefreshPage();

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            
                GGID = dataGridView1.CurrentRow.Cells["OgrenciNo"].Value.ToString();
                lblSelected.Text = GGID.ToString();



            TboxUpdateName.Text = dataGridView1.CurrentRow.Cells["Ad"].Value.ToString();
            TboxUpdateLastName.Text = dataGridView1.CurrentRow.Cells["Soyad"].Value.ToString();
            TboxUpdateBirth.Text = dataGridView1.CurrentRow.Cells["Dogum_yili"].Value.ToString();
            TboxUpdateMajor.Text = dataGridView1.CurrentRow.Cells["Bolum"].Value.ToString();


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmdEdit = new SqlCommand("update Ogrenci set Ad=@pname ,Soyad=@plastName ,Dogum_yili=@pbirth ,Bolum=@pmajor where OgrenciNo=@pid",SQLVariables.connect);
            SQLVariables.CheckConnection (SQLVariables.connect);
            cmdEdit.Parameters.AddWithValue("@pname", TboxUpdateName.Text);
            cmdEdit.Parameters.AddWithValue("@plastName", TboxUpdateLastName.Text);
            cmdEdit.Parameters.AddWithValue("@pbirth", TboxUpdateBirth.Text);
            cmdEdit.Parameters.AddWithValue("@pmajor", TboxUpdateMajor.Text);
            cmdEdit.Parameters.AddWithValue("@pid",GGID.ToString());
            cmdEdit.ExecuteNonQuery();
            RefreshPage();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            TboxUpdateName.Text= string.Empty;
            TboxUpdateLastName.Text = string.Empty;
            TboxUpdateBirth.Text = string.Empty;
            TboxUpdateMajor.Text = string.Empty;
        }
    }
}
