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

namespace InventoryManagementSystem
{
    public partial class Loginform : System.Windows.Forms.Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\New User\Documents\DB.mdf"";Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public Loginform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cm = new SqlCommand("SELECT * FROM usertable WHERE username = @username AND password = @password", con);
                cm.Parameters.AddWithValue("@username", textname.Text);
                cm.Parameters.AddWithValue("@password", textpassword.Text);
                con.Open();
                dr = cm.ExecuteReader();
                dr.Read();

                if (dr.HasRows)
                {
                   MessageBox.Show("Welcome " + dr["fullname"].ToString() + " | " , "ACCESS GRANTED!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   MainForm main =new MainForm();
                   this.Hide();
                   main.ShowDialog();
                  
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password!" , "ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkpassword.Checked == false) 
                textpassword.UseSystemPasswordChar = true;
            else
                textpassword.UseSystemPasswordChar = false;
                
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textname.Clear();
            textpassword.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Exit Application", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Exit Application", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Loginform_Load(object sender, EventArgs e)
        {

        }
    }
}
