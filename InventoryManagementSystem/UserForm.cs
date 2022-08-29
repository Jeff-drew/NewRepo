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
using System.Data.SqlClient;


namespace InventoryManagementSystem
{
    public partial class UserForm : System.Windows.Forms.Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\New User\Documents\DB.mdf"";Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public UserForm()
        {
            InitializeComponent();
            LoadUser();
            
        }

        public void LoadUser()
        {
            
            int i = 0;
            dgvUser.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM usertable", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvUser.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());

            }
            dr.Close();
            con.Close();
            

        }

        
        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvUser.Columns[e.ColumnIndex].Name;
            if (colName == "Edit") 
            {
                UserModuleForm userModule = new UserModuleForm();
                userModule.txtU.Text = dgvUser.Rows[e.RowIndex].Cells[1].Value.ToString();
                userModule.txtF.Text = dgvUser.Rows[e.RowIndex].Cells[2].Value.ToString();
                userModule.txtP.Text = dgvUser.Rows[e.RowIndex].Cells[3].Value.ToString();
                userModule.txtPh.Text = dgvUser.Rows[e.RowIndex].Cells[4].Value.ToString();

                userModule.btnS.Enabled = false;
                userModule.btnU.Enabled = true;
                userModule.txtU.Enabled = false;
                userModule.ShowDialog();                                                                                    

            }
            else if(colName == "Delete")
            {
                if(MessageBox.Show("Are you sure you want to delete this user?", "Delete record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cm = new SqlCommand("DELETE FROM usertable WHERE phone LIKE '"+dgvUser.Rows[e.RowIndex].Cells[1].Value.ToString()+"'", con);
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Successfully deleted data!");
                }
            }
            LoadUser();

        }

        private void customerButton1_Click(object sender, EventArgs e)
        {
            UserModuleForm userModule = new UserModuleForm();
            userModule.btnS.Enabled = true;
            userModule.btnU.Enabled = false;
            userModule.ShowDialog();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
