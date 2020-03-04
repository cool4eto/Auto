namespace Auto
{
    partial class carSale
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
            this.components = new System.ComponentModel.Container();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.comboCondition = new System.Windows.Forms.ComboBox();
            this.txtVIN = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtNewPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSale = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.srch = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAddClient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 67;
            this.label7.Text = "Price: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 66;
            this.label6.Text = "Condition: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 65;
            this.label5.Text = "VIN:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 64;
            this.label4.Text = "Color: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 63;
            this.label3.Text = "Model:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 62;
            this.label1.Text = "Make: ";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(105, 213);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(100, 22);
            this.txtPrice.TabIndex = 61;
            // 
            // comboCondition
            // 
            this.comboCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCondition.Enabled = false;
            this.comboCondition.FormattingEnabled = true;
            this.comboCondition.Items.AddRange(new object[] {
            "New",
            "Used"});
            this.comboCondition.Location = new System.Drawing.Point(105, 182);
            this.comboCondition.Name = "comboCondition";
            this.comboCondition.Size = new System.Drawing.Size(188, 24);
            this.comboCondition.TabIndex = 60;
            // 
            // txtVIN
            // 
            this.txtVIN.Location = new System.Drawing.Point(105, 153);
            this.txtVIN.Name = "txtVIN";
            this.txtVIN.ReadOnly = true;
            this.txtVIN.Size = new System.Drawing.Size(100, 22);
            this.txtVIN.TabIndex = 59;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(105, 124);
            this.txtColor.Name = "txtColor";
            this.txtColor.ReadOnly = true;
            this.txtColor.Size = new System.Drawing.Size(100, 22);
            this.txtColor.TabIndex = 58;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(105, 95);
            this.txtModel.Name = "txtModel";
            this.txtModel.ReadOnly = true;
            this.txtModel.Size = new System.Drawing.Size(100, 22);
            this.txtModel.TabIndex = 57;
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(105, 66);
            this.txtMake.Name = "txtMake";
            this.txtMake.ReadOnly = true;
            this.txtMake.Size = new System.Drawing.Size(100, 22);
            this.txtMake.TabIndex = 56;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtNewPrice
            // 
            this.txtNewPrice.Location = new System.Drawing.Point(235, 252);
            this.txtNewPrice.Name = "txtNewPrice";
            this.txtNewPrice.Size = new System.Drawing.Size(100, 22);
            this.txtNewPrice.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(84, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 17);
            this.label2.TabIndex = 70;
            this.label2.Text = "Price after discounts: ";
            // 
            // btnSale
            // 
            this.btnSale.BackColor = System.Drawing.Color.Coral;
            this.btnSale.Enabled = false;
            this.btnSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSale.Location = new System.Drawing.Point(235, 305);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(115, 43);
            this.btnSale.TabIndex = 71;
            this.btnSale.Text = "Sale";
            this.btnSale.UseVisualStyleBackColor = false;
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(341, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(468, 150);
            this.dataGridView1.TabIndex = 75;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // srch
            // 
            this.srch.Location = new System.Drawing.Point(599, 55);
            this.srch.Name = "srch";
            this.srch.Size = new System.Drawing.Size(75, 23);
            this.srch.TabIndex = 74;
            this.srch.Text = "Search";
            this.srch.UseVisualStyleBackColor = true;
            this.srch.Click += new System.EventHandler(this.srch_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(410, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 17);
            this.label8.TabIndex = 73;
            this.label8.Text = "Search: ";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(477, 57);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 22);
            this.txtSearch.TabIndex = 72;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Lime;
            this.label9.Location = new System.Drawing.Point(87, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 29);
            this.label9.TabIndex = 76;
            this.label9.Text = "CAR";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Fuchsia;
            this.label10.Location = new System.Drawing.Point(477, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 32);
            this.label10.TabIndex = 77;
            this.label10.Text = "Client";
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(599, 85);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(95, 23);
            this.btnAddClient.TabIndex = 78;
            this.btnAddClient.Text = "Add Client";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Visible = false;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // carSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 360);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.srch);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSale);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNewPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.comboCondition);
            this.Controls.Add(this.txtVIN);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMake);
            this.Name = "carSale";
            this.Text = "carSale";
            this.Load += new System.EventHandler(this.carSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox comboCondition;
        private System.Windows.Forms.TextBox txtVIN;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtNewPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button srch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAddClient;
    }
}