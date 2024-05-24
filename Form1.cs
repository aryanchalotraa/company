using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetEmpList();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        
        SqlConnection con =  new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Test_db;Persist Security Info=True;User ID=sa;Password=12345");
        private object c;

        private void Button1_Click(object sender, EventArgs e)
        {
            int empid = int.Parse(textBox1.Text);
            String empname = textBox2.Text,Position= textBox3.Text;
            int Salary=int.Parse(textBox4.Text);
            con.Open();
            SqlCommand c= new SqlCommand("exec InsertEmp_SP '" + empid + "','" + empname + "','" + Position + "','" + Salary + "'", con);
            c.ExecuteNonQuery();
            MessageBox.Show("Successfully Inserted.");
            GetEmpList();
        }
        void GetEmpList()
        {
            SqlCommand c = new SqlCommand("exec ListEmp_SP", con);
            SqlDataAdapter sd= new SqlDataAdapter(c);
            DataTable dt = new DataTable();
            sd.Fill(dt);    
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int empid = int.Parse(textBox1.Text);
            String empname = textBox2.Text, Position = textBox3.Text;
            int Salary = int.Parse(textBox4.Text);
            con.Open();
            SqlCommand c = new SqlCommand("exec UpdateEmp_SP '" + empid + "','" + empname + "','" + Position + "','" + Salary + "'", con);
            c.ExecuteNonQuery();
            MessageBox.Show("Successfully Updated.");
            GetEmpList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int empid = int.Parse(textBox1.Text);
            
            con.Open();
            SqlCommand c = new SqlCommand("exec DeleteEmp_SP '" + empid + "'", con);
            c.ExecuteNonQuery();
            MessageBox.Show("Successfully Deleted.");
            GetEmpList();
        }
    }
}
