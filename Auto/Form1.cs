using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Auto
{
    public partial class Form1 : Form
    {
        string connectionString = @"Server=localhost;Database=auto;Uid=root;Pwd=root;";
        public Form1()
        {
            InitializeComponent();
            changeView(false);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void positionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            positionCRUD pos = new positionCRUD();
            pos.Show();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userCRUD usr = new userCRUD();
            usr.Show();
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clientCRUD client = new clientCRUD();
            client.Show();
        }

        private void dealershipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dealershipCRUD dealership = new dealershipCRUD();
            dealership.Show();
        }

        private void carToolStripMenuItem_Click(object sender, EventArgs e)
        {
            carCRUD car = new carCRUD();
            car.Show();
        }

        private void employmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            employment empl = new employment();
            empl.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ComboDealershipFill();
        }
        void ComboDealershipFill()//funkciq koqto ni popalva dealershipowete w combo boxa
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("Login", mysqlCon);
                /*sqlDa.SelectCommand.Parameters.Add("_username", MySqlDbType.VarChar, 45, "Angel Kirov");
                sqlDa.SelectCommand.Parameters.Add("_password", MySqlDbType.VarChar, 45, "123");*/
                
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("_username", txtUsername.Text);
                sqlDa.SelectCommand.Parameters.AddWithValue("_password", txtPassword.Text);
                DataTable dtblBook = new DataTable();
                
                sqlDa.Fill(dtblBook);
              
                txtTest.Text = Helper.curDealership.ToString();
                comboDealership.DataSource = dtblBook;
                comboDealership.DisplayMember = "name";
                if(comboDealership.Items.Count>0)
                {
                    MessageBox.Show("Login successful",
                                    "OK!",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Information 
                                      );
                    Helper.curUser = dtblBook.Rows[0].Field<int>(1);//tuk zapiswame current user za da znaem s koi rabotim
                    Helper.curDealership = dtblBook.Rows[0].Field<int>(2);
                    changeView(true);
                    if(comboDealership.Items.Count==1)
                    {
                        label3.Visible = false;
                        comboDealership.Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("Login unsuccessful",
                                    "Try again",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Warning
                                      );
                }

            }
        }
        void changeView(bool value)
        {
            if(value==true)
            {
                label3.Visible = true;
                comboDealership.Visible = true;
                toolStripMenuItem1.Visible = true;
                toolStripMenuItem1.Enabled= true;
                queriesToolStripMenuItem.Visible = true;
                label1.Visible = false;
                label2.Visible = false;
                txtUsername.Visible = false;
                txtPassword.Visible = false;
                btnLogin.Visible = false;

            }
            else
            {
                label3.Visible = false;
                comboDealership.Visible = false;
                toolStripMenuItem1.Visible = false;
                queriesToolStripMenuItem.Visible = false;



            }
        }

        private void comboDealership_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("dealershipSearchByValue", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("_SearchValue", comboDealership.Text);
                DataTable dtblBook = new DataTable();
                sqlDa.Fill(dtblBook);
                if (dtblBook.Rows.Count > 0)
                {
                  
                    Helper.curDealership = dtblBook.Rows[0].Field<int>(0);
                    txtTest.Text = Helper.curDealership.ToString();
                }
            }            
        }

        private void carsSoldByDealershipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            qCarsSoldByDealership sold1 = new qCarsSoldByDealership();
            sold1.Show();
        }

        private void carsSoldByUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            qCarsSoldByUser car1 = new qCarsSoldByUser();
            car1.Show();
        }
    }
}
