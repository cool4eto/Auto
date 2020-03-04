namespace Auto
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.positionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dealershipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carsSoldByDealershipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.comboDealership = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTest = new System.Windows.Forms.TextBox();
            this.carsSoldByUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.queriesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(705, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.positionToolStripMenuItem,
            this.userToolStripMenuItem,
            this.clientToolStripMenuItem,
            this.dealershipToolStripMenuItem,
            this.carToolStripMenuItem,
            this.employmentToolStripMenuItem});
            this.toolStripMenuItem1.Enabled = false;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(60, 24);
            this.toolStripMenuItem1.Text = "CRUD";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // positionToolStripMenuItem
            // 
            this.positionToolStripMenuItem.Name = "positionToolStripMenuItem";
            this.positionToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.positionToolStripMenuItem.Text = "Position";
            this.positionToolStripMenuItem.Click += new System.EventHandler(this.positionToolStripMenuItem_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.userToolStripMenuItem.Text = "User";
            this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.clientToolStripMenuItem.Text = "Client";
            this.clientToolStripMenuItem.Click += new System.EventHandler(this.clientToolStripMenuItem_Click);
            // 
            // dealershipToolStripMenuItem
            // 
            this.dealershipToolStripMenuItem.Name = "dealershipToolStripMenuItem";
            this.dealershipToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.dealershipToolStripMenuItem.Text = "Dealership";
            this.dealershipToolStripMenuItem.Click += new System.EventHandler(this.dealershipToolStripMenuItem_Click);
            // 
            // carToolStripMenuItem
            // 
            this.carToolStripMenuItem.Name = "carToolStripMenuItem";
            this.carToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.carToolStripMenuItem.Text = "Car";
            this.carToolStripMenuItem.Click += new System.EventHandler(this.carToolStripMenuItem_Click);
            // 
            // employmentToolStripMenuItem
            // 
            this.employmentToolStripMenuItem.Name = "employmentToolStripMenuItem";
            this.employmentToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.employmentToolStripMenuItem.Text = "Employment";
            this.employmentToolStripMenuItem.Click += new System.EventHandler(this.employmentToolStripMenuItem_Click);
            // 
            // queriesToolStripMenuItem
            // 
            this.queriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carsSoldByDealershipToolStripMenuItem,
            this.carsSoldByUserToolStripMenuItem});
            this.queriesToolStripMenuItem.Name = "queriesToolStripMenuItem";
            this.queriesToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.queriesToolStripMenuItem.Text = "Queries";
            // 
            // carsSoldByDealershipToolStripMenuItem
            // 
            this.carsSoldByDealershipToolStripMenuItem.Name = "carsSoldByDealershipToolStripMenuItem";
            this.carsSoldByDealershipToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.carsSoldByDealershipToolStripMenuItem.Text = "Cars Sold By Dealership";
            this.carsSoldByDealershipToolStripMenuItem.Click += new System.EventHandler(this.carsSoldByDealershipToolStripMenuItem_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(284, 150);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(173, 22);
            this.txtUsername.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password: ";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(284, 185);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(173, 22);
            this.txtPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(343, 232);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 38);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login!";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // comboDealership
            // 
            this.comboDealership.FormattingEnabled = true;
            this.comboDealership.Location = new System.Drawing.Point(125, 63);
            this.comboDealership.Name = "comboDealership";
            this.comboDealership.Size = new System.Drawing.Size(185, 24);
            this.comboDealership.TabIndex = 6;
            this.comboDealership.SelectedIndexChanged += new System.EventHandler(this.comboDealership_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Dealership: ";
            // 
            // txtTest
            // 
            this.txtTest.Location = new System.Drawing.Point(370, 364);
            this.txtTest.Name = "txtTest";
            this.txtTest.Size = new System.Drawing.Size(100, 22);
            this.txtTest.TabIndex = 8;
            this.txtTest.Visible = false;
            // 
            // carsSoldByUserToolStripMenuItem
            // 
            this.carsSoldByUserToolStripMenuItem.Name = "carsSoldByUserToolStripMenuItem";
            this.carsSoldByUserToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.carsSoldByUserToolStripMenuItem.Text = "Cars Sold By User";
            this.carsSoldByUserToolStripMenuItem.Click += new System.EventHandler(this.carsSoldByUserToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 428);
            this.Controls.Add(this.txtTest);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboDealership);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Auto Dealership";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem positionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dealershipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employmentToolStripMenuItem;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.ComboBox comboDealership;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTest;
        private System.Windows.Forms.ToolStripMenuItem queriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carsSoldByDealershipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carsSoldByUserToolStripMenuItem;
    }
}

