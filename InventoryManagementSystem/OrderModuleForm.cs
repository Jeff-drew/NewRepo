﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace InventoryManagementSystem
{
    public partial class OrderModuleForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\New User\Documents\DB.mdf"";Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        int qty = 0;
        public OrderModuleForm()
        {
            InitializeComponent();
            LoadCustomer();
            LoadProduct();

        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
            
        }

        public void LoadCustomer()
        {

            int i = 0;
            dgvCustomer.Rows.Clear();
            cm = new SqlCommand("SELECT cid, cname  FROM tbCustomer WHERE CONCAT(cid, cname) LIKE '%"+txtSearchCust.Text+"%'", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvCustomer.Rows.Add(i, dr[0].ToString(), dr[1].ToString());

            }
            dr.Close();
            con.Close();


        }

        public void LoadProduct()
        {

            int i = 0;
            dgvProduct.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tbProduct WHERE CONCAT(pid, pname, pprice, pcategory) LIKE '%" + txtSearchProd.Text + "%'", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvProduct.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());

            }
            dr.Close();
            con.Close();


        }
       


        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCid.Text = dgvCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCName.Text = dgvCustomer.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void txtSearchCust_TextChanged(object sender, EventArgs e)
        {
            LoadCustomer();
        }

        private void txtSearchProd_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPid.Text = dgvProduct.Rows[e.RowIndex].Cells[1].Value.ToString(); 
            txtPName.Text = dgvProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPrice.Text = dgvProduct.Rows[e.RowIndex].Cells[4].Value.ToString();
          //  qty = Convert.ToInt16(dgvProduct.Rows[e.RowIndex].Cells[3].Value.ToString());
        
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            GetQty();
            if (Convert.ToInt16(numericUpDown1.Value)> qty)
            {
                MessageBox.Show("Instock quantity is not enough!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numericUpDown1.Value = numericUpDown1.Value - 1;
                return;
            }
            if (Convert.ToInt16(numericUpDown1.Value) > 0)
            {
                int total = Convert.ToInt16(txtPrice.Text) * Convert.ToInt16(numericUpDown1.Value);
                txtTotal.Text = total.ToString();
            }
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {   if(txtCid.Text == " ")
                {
                    MessageBox.Show("Please select customer!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txtPid.Text == " ")
                {
                    MessageBox.Show("Please select product!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                if (MessageBox.Show("Are you sure you want to add this order?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO tbOrder(odate, pid, cid, qty, price, total)VALUES(@odate, @pid, @cid, @qty, @price, @total)", con);
                    cm.Parameters.AddWithValue("@odate", dOrder.Value);
                    cm.Parameters.AddWithValue("@pid", Convert.ToInt16(txtPid.Text));
                    cm.Parameters.AddWithValue("@cid", Convert.ToInt16(txtCid.Text));
                    cm.Parameters.AddWithValue("@qty", Convert.ToInt16(numericUpDown1.Value));
                    cm.Parameters.AddWithValue("@price", Convert.ToInt16(txtPrice.Text));
                    cm.Parameters.AddWithValue("@total", Convert.ToInt16(txtTotal.Text));
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Order has been added successfully.");
                    Clear();


                    cm = new SqlCommand("UPDATE tbProduct SET  pqty = (pqty-@pqty) WHERE pid LIKE '" + txtPid.Text + "' ", con);            
                    cm.Parameters.AddWithValue("@pqty", Convert.ToInt16(numericUpDown1.Text));                                 
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    Clear();
                    LoadProduct();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Clear()
        {
            txtCid.Clear();
            txtCName.Clear();

            txtPid.Clear();
            txtPName.Clear();

            txtPrice.Clear();
            numericUpDown1.Value = 1;
            txtTotal.Clear(); 
            dOrder.Value = DateTime.Now;


        }

        private void btnC_Click(object sender, EventArgs e)
        {
            Clear();
         
           
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        public void GetQty()
        {
            cm = new SqlCommand("SELECT * FROM tbProduct WHERE pid = '" + txtPid.Text + "'", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                qty = Convert.ToInt32(dr[0].ToString());
            }
            dr.Close();
            con.Close();

        }

        private void btnOrderU_Click(object sender, EventArgs e)
        {

        }
    }
}
