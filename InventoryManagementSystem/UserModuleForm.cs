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
using System.Runtime.Remoting.Contexts;

namespace InventoryManagementSystem
{
    public partial class UserModuleForm : System.Windows.Forms.Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\New User\Documents\DB.mdf"";Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand(); 
        public UserModuleForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int i = 0;
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from registration where username='" + txtUserName.Text + "' and password='" + txtPassword.Text + "'   ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());
            if (i == 0)
            {
                MessageBox.Show("this username and password does not exist!");
            }
            else
            {
                this.Hide();
                MDIParent1 mdi = new MDIParent1();
                mdi.Show();
            }

              try
              {
                  if (MessageBox.Show("Are you sure you want to add this user?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.OK)
                  {
                      cm = new SqlCommand("INSERT INTO UserT(unname,fname,pword,number)VALUES(@uname,@fname,@pword,@number)", con);
                      cm.Parameters.AddWithValue("@uname", txtUserName.Text);
                      cm.Parameters.AddWithValue("@fname", txtFullName.Text);
                      cm.Parameters.AddWithValue("@pword", txtPassword.Text);
                      cm.Parameters.AddWithValue("@number", txtPhone.Text);
                      con.Open();
                      cm.ExecuteNonQuery();
                      con.Close();
                      MessageBox.Show("User has been added successfully.");
                      
                      
                  }
              }

              catch (Exception ex)
              {
                  MessageBox.Show(ex.Message);

              }
          }
            

             private void pictureBox1_Clic(object sender, EventArgs e)
              {
                    
              }
              public void Clear()
              {
                  txtU.Clear();
                  txtF.Clear();    
                  txtP.Clear();
                  txtPh.Clear();  
              }

              private void UserModuleForm_Load(object sender, EventArgs e)
              {
                  if (con.State == ConnectionState.Open)
                  {
                      con.Close();
                  }
                  con.Open();
              }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void customerButton2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {   if(txtP.Text != txtCP.Text)
                {
                    MessageBox.Show("Password doesn't match", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("Are you sure you want to add this user?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm= new SqlCommand("INSERT INTO usertable(username,fullname,password,phone)VALUES(@username,@fullname,@password,@phone)", con);
                    cm.Parameters.AddWithValue("@username", txtU.Text);
                    cm.Parameters.AddWithValue("@fullname", txtF.Text);
                    cm.Parameters.AddWithValue("@password", txtP.Text);
                    cm.Parameters.AddWithValue("@phone", txtPh.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("User has been added successfully.");
                    Erase();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UserModuleForm_Load_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clear();
            Erase();
            btnS.Enabled = true;
            btnU.Enabled = false;
        }
        public void Erase()
        {
            txtU.Clear();
            txtF.Clear();
            txtP.Clear();
            txtCP.Clear();  
            txtPh.Clear();
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtP.Text != txtCP.Text)
                {
                    MessageBox.Show("Password doesn't match", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("Are you sure you to update this user?", "Updating Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("UPDATE usertable SET  fullname = @fullname, password = @password, phone = @phone WHERE username LIKE '"+ txtU.Text + "' ", con);
                    cm.Parameters.AddWithValue("@fullname", txtF.Text);
                    cm.Parameters.AddWithValue("@password", txtP.Text);
                    cm.Parameters.AddWithValue("@phone", txtPh.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("User has been updated successfully.");
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    }

