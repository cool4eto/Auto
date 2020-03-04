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
    public partial class employment : Form
    {
        string connectionString = @"Server=localhost;Database=auto;Uid=root;Pwd=root;";
        int employmentID = 0;//ako id=0 to save ako ne update
        public employment()
        {
            InitializeComponent();
            GridUserFill();
            ComboDealershipFill();
            GridAllFill();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {




                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("userToDealAddOrEdit", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_idUserToDeal", employmentID);
                mySqlCmd.Parameters.AddWithValue("_user", Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                mySqlCmd.Parameters.AddWithValue("_dealership", comboDealership.SelectedIndex+1);
                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Submitted Successfully");
                GridAllFill();
                
            }
        }
        void GridUserFill()
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
        void ComboDealershipFill()//funkciq koqto ni popalva dealershipowete w combo boxa
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("dealershipViewAll", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtblBook = new DataTable();
                sqlDa.Fill(dtblBook);

                comboDealership.DataSource = dtblBook;
                comboDealership.DisplayMember = "name";
            }
        }
        void GridAllFill()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("userToDealViewAll", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtblBook = new DataTable();
                sqlDa.Fill(dtblBook);
                dataGridView2.DataSource = dtblBook;
                dataGridView2.Columns[0].Visible = false;//za da ne se wijda id ot usera
                
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            btnDelete.Enabled = true;
            employmentID = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value.ToString());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("userToDealDeleteByID", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_userID", employmentID);
                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully");
                GridAllFill();
               
            }
        }
        
        

    }
}
