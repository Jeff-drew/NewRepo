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

namespace InventoryManagementSystem
{
    public partial class CustomerModuleForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\New User\Documents\DB.mdf"";Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        public CustomerModuleForm()
        {
            InitializeComponent();
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (MessageBox.Show("Are you sure you want to add this Customer?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO tbCustomer(cname, cphone)VALUES(@cname,@cphone)", con);
                    cm.Parameters.AddWithValue("@cname", txtName.Text);
                    cm.Parameters.AddWithValue("@cphone", txtPhone.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Customer has been added successfully.");
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Clear()
        {
            txtName.Clear();
            txtPhone.Clear();
            btnS.Enabled = true;
            btnU.Enabled = false;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            Clear();
            btnS.Enabled = true;
            btnU.Enabled = false;
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you to update this customer?", "Updating Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                     cm = new SqlCommand("UPDATE tbCustomer SET  cname = @cname, cphone = @cphone WHERE cid LIKE '" + lblCId.Text + "' ", con);
                     cm.Parameters.AddWithValue("@cname", txtName.Text);
                     cm.Parameters.AddWithValue("@cphone", txtPhone.Text);
                     con.Open();
                     cm.ExecuteNonQuery();
                     con.Close();
                     MessageBox.Show("Customer has been updated successfully.");
                     this.Dispose();

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        private void CustomerModuleForm_Load(object sender, EventArgs e)
        {

        }
    }
}
