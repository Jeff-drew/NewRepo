using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class Loginform : System.Windows.Forms.Form
    {
        public Loginform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

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
    }
}
