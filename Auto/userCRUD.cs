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
    public partial class userCRUD : Form
    {
        string connectionString = @"Server=localhost;Database=auto;Uid=root;Pwd=root;";
        int userID = 0;//ako id=0 to save ako ne update
        public userCRUD()
        {
            InitializeComponent();
            postionGridFill();
            GridFill();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        void postionGridFill()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("positionViewAll", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtblBook = new DataTable();
                sqlDa.Fill(dtblBook);
                dataGridView2.DataSource = dtblBook;
                dataGridView2.Columns[0].Visible = false;//za da ne se wijda id ot usera
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("userAddOrEdit", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_userID", userID);
                mySqlCmd.Parameters.AddWithValue("_username", txtUsername.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_password", txtPassword.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_name", txtName.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_position", Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value.ToString()));
                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Submitted Successfully");
               Clear();
                GridFill();
            }
        }
        void Clear()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtName.Text = "";
            dataGridView2.Rows[1].Selected = true;
            userID = 0;
            btnSave.Text = "Save";
            btnDelete.Enabled = false;
            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();
        }

      


        void GridFill()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("userViewAll", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtblBook = new DataTable();
                sqlDa.Fill(dtblBook);
                dataGridView1.DataSource = dtblBook;
                dataGridView1.Columns[0].Visible = false;//za da ne se wijda id ot usera
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[6].Visible = false;
            }
        }

      

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dataGridView1_DoubleClick_1(object sender, EventArgs e)
        { 
            if (dataGridView1.CurrentRow.Index != -1)
            {
                dataGridView2.ClearSelection();
                txtUsername.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtName.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtPassword.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                userID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
               int index = Convert.ToInt32(dataGridView1.CurrentRow.Cells[6].Value.ToString())-1; 
                dataGridView2.Rows[index].Selected = true;
                btnSave.Text = "Update";
                btnDelete.Enabled = Enabled;
            }
        }

        private void srch_Click(object sender, EventArgs e)
        {
      
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("userSearchByValue", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("_SearchValue", txtSearch.Text);
                DataTable dtblBook = new DataTable();
                sqlDa.Fill(dtblBook);
                dataGridView1.DataSource = dtblBook;
                dataGridView1.Columns[0].Visible = false;
        }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("userDeleteByID", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_userID", userID);
                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully");
                Clear();
                GridFill();
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            Clear();
        }

        private void userCRUD_Load(object sender, EventArgs e)
        {

        }
    }
}
