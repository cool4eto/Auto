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
    public partial class dealershipCRUD : Form
    {
        string connectionString = @"Server=localhost;Database=auto;Uid=root;Pwd=root;";
        int dealershipID = 0;//ako id=0 to save ako ne update
        public dealershipCRUD()
        {
            InitializeComponent();
            GridFill();
        }
        void GridFill()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {

                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("dealershipViewAll", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtblBook = new DataTable();
                sqlDa.Fill(dtblBook);
                dataGridView1.DataSource = dtblBook;
                dataGridView1.Columns[0].Visible = false;//za da ne se wijda id ot usera
                dataGridView1.AutoResizeColumns();//tezi dwa reda sa za da se preorazmerqwat kolonite 
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }
        void Clear()
        {
            txtName.Text = "";
            txtLocation.Text = "";
            dealershipID = 0;
            btnSave.Text = "Save";
            btnDelete.Enabled = false;
            dataGridView1.ClearSelection();
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("dealershipAddOrEdit", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_dealershipID", dealershipID);
                mySqlCmd.Parameters.AddWithValue("_name", txtName.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_location", txtLocation.Text.Trim());
                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Submitted Successfully");
                Clear();
                GridFill();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                
                txtName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtLocation.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                dealershipID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                btnSave.Text = "Update";
                btnDelete.Enabled = Enabled;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("dealershipDeleteByID", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_dealershipID", dealershipID);
                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully");
                Clear();
                GridFill();
            }
        }

        private void srch_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("dealershipSearchByValue", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("_SearchValue", txtSearch.Text);
                DataTable dtblBook = new DataTable();
                sqlDa.Fill(dtblBook);
                dataGridView1.DataSource = dtblBook;
                dataGridView1.Columns[0].Visible = false;
            }
        }


    }
}
