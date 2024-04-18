using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace userSignUp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-92832BK\SQLEXPRESS;Initial Catalog=registerForm;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[register]
           ([firstname]
           ,[lastname]
           ,[address]
           ,[gender]
           ,[email]
           ,[phone]
           ,[username]
           ,[password])
     VALUES
           ('" + txtFname.Text + "','" + txtLname.Text + "','" + txtAdd.Text + "','" + cmbGender.SelectedItem.ToString() + "','" + txtEmail.Text + "','" + txtPhone.Text + "','" + txtUser.Text + "','" + txtPass.Text + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Sign Up Successfull");
        }
    }
}
