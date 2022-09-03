namespace InventoryManagementSystem
{
    partial class UserModuleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserModuleForm));
            this.label6 = new System.Windows.Forms.Label();
            this.txtU = new System.Windows.Forms.TextBox();
            this.txtF = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPh = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnS = new System.Windows.Forms.Button();
            this.btnU = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "User Name:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtU
            // 
            this.txtU.Location = new System.Drawing.Point(130, 99);
            this.txtU.Name = "txtU";
            this.txtU.Size = new System.Drawing.Size(203, 20);
            this.txtU.TabIndex = 1;
            this.txtU.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtF
            // 
            this.txtF.Location = new System.Drawing.Point(130, 136);
            this.txtF.Name = "txtF";
            this.txtF.Size = new System.Drawing.Size(203, 20);
            this.txtF.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Full Name:";
            // 
            // txtP
            // 
            this.txtP.Location = new System.Drawing.Point(130, 173);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(203, 20);
            this.txtP.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(62, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Password:";
            // 
            // txtPh
            // 
            this.txtPh.Location = new System.Drawing.Point(130, 247);
            this.txtPh.Name = "txtPh";
            this.txtPh.Size = new System.Drawing.Size(203, 20);
            this.txtPh.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(77, 249);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Phone:";
            // 
            // btnS
            // 
            this.btnS.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnS.Location = new System.Drawing.Point(112, 302);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(75, 23);
            this.btnS.TabIndex = 8;
            this.btnS.Text = "Save";
            this.btnS.UseVisualStyleBackColor = false;
            this.btnS.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnU
            // 
            this.btnU.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnU.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnU.Location = new System.Drawing.Point(195, 302);
            this.btnU.Name = "btnU";
            this.btnU.Size = new System.Drawing.Size(75, 23);
            this.btnU.TabIndex = 9;
            this.btnU.Text = "Update";
            this.btnU.UseVisualStyleBackColor = false;
            this.btnU.Click += new System.EventHandler(this.btnU_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnC.Location = new System.Drawing.Point(278, 302);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(75, 23);
            this.btnC.TabIndex = 10;
            this.btnC.Text = "Clear";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.button3_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(12, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 21);
            this.label10.TabIndex = 11;
            this.label10.Text = "User Module";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.pictureBoxClose);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(395, 67);
            this.panel2.TabIndex = 12;
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(130, 210);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(203, 20);
            this.txtCP.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 213);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Confirm Password :";
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(375, 0);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(20, 18);
            this.pictureBoxClose.TabIndex = 12;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // UserModuleForm
            // 
            this.ClientSize = new System.Drawing.Size(395, 337);
            this.Controls.Add(this.txtCP);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnU);
            this.Controls.Add(this.btnS);
            this.Controls.Add(this.txtPh);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtP);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtF);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtU);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserModuleForm";
            this.Load += new System.EventHandler(this.UserModuleForm_Load_1);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        public System.Windows.Forms.Button btnS;
        public System.Windows.Forms.Button btnU;
        public System.Windows.Forms.Button btnC;
        public System.Windows.Forms.TextBox txtU;
        public System.Windows.Forms.TextBox txtF;
        public System.Windows.Forms.TextBox txtP;
        public System.Windows.Forms.TextBox txtPh;
        public System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.Label label11;
    }
}