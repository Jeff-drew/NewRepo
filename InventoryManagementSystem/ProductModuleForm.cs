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
    public partial class ProductModuleForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\New User\Documents\DB.mdf"";Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public ProductModuleForm()
        {
            InitializeComponent();
            LoadCategory();
        }

        private void ProductModuleForm_Load(object sender, EventArgs e)
        {

        }

        public void LoadCategory()
        {
            comboCat.Items.Clear();
            cm = new SqlCommand("SELECT catname FROM tbCategory", con);
            con.Open();
            dr = cm.ExecuteReader();

            while (dr.Read())
            {
                comboCat.Items.Add(dr[0].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Are you sure you want to add this Product?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO tbProduct(pname, pqty, pprice, pcategory)VALUES(@pname,@pqty, @pprice, @pcategory )", con);
                    cm.Parameters.AddWithValue("@pname", txtPN.Text);
                    cm.Parameters.AddWithValue("@pqty", Convert.ToInt16(txtQ.Text));
                    cm.Parameters.AddWithValue("@pprice", Convert.ToInt16(txtP.Text));
                    cm.Parameters.AddWithValue("@pcategory", comboCat.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Product has been added successfully.");
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
            txtPN.Clear();
            txtP.Clear();
            txtQ.Clear();
            comboCat.Text = "";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            Clear();
            btnS.Enabled = true;
            btnU.Enabled = false;
        }

        private void lblPid_Click(object sender, EventArgs e)
        {

        }

        private void btnU_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you to update this product?", "Updating Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("UPDATE tbProduct SET  pname = @pname, pqty = @pqty, pprice =@pprice, pcategory =@pcategory WHERE pid LIKE '" + lblPid.Text + "' ", con);
                    cm.Parameters.AddWithValue("@pname", txtP.Text);
                    cm.Parameters.AddWithValue("@pqty", Convert.ToInt16(txtQ.Text));
                    cm.Parameters.AddWithValue("@pprice", Convert.ToInt16(txtPN.Text));
                    cm.Parameters.AddWithValue("@pcategory", comboCat.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Product has been updated successfully.");
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
