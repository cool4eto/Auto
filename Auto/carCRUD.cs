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
    public partial class carCRUD : Form
    {
        string connectionString = @"Server=localhost;Database=auto;Uid=root;Pwd=root;";
        int carID = 0;//ako id=0 to save ako ne update
        public carCRUD()
        {
            
            InitializeComponent();
            Clear();
            GridFill();
            
            ComboDealershipFill();
            comboCondition.SelectedIndex = -1;
            comboDealership.SelectedIndex = Helper.curDealership-1;
            comboDealership.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("carAddOrEdit", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_carID", carID);
                mySqlCmd.Parameters.AddWithValue("_make", txtMake.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_model", txtModel.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_color", txtColor.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_VIN", txtVIN.Text.Trim());
                string condition = this.comboCondition.GetItemText(this.comboCondition.SelectedItem);
                mySqlCmd.Parameters.AddWithValue("_condition", condition);
                string price=txtPrice.Text.Trim();
                mySqlCmd.Parameters.AddWithValue("_price", Convert.ToDouble(price));
                mySqlCmd.Parameters.AddWithValue("_dealership", comboDealership.SelectedIndex+1);
                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Submitted Successfully");
                Clear();
                GridFill();
            }
        }
        void GridFill()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("carViewAllAvailable", mysqlCon);//tuk shte ni izlizat samo koli koito mojem da prodadem
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("_idDealership", Helper.curDealership);
                DataTable dtblBook = new DataTable();
                sqlDa.Fill(dtblBook);
                dataGridView1.DataSource = dtblBook;
                dataGridView1.Columns[0].Visible = false;//za da ne se wijda id ot usera
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[8].Visible = false;
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
        void Clear()
        {
            txtMake.Text = "";
            txtModel.Text = "";
            txtColor.Text = "";
            txtVIN.Text = "";
            txtPrice.Text = "";
            carID = 0;
            btnSave.Text = "Save";
            btnDelete.Enabled = false;
            btnSale.Enabled = false;
            dataGridView1.ClearSelection();
            comboCondition.SelectedIndex = -1;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                
                txtMake.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtModel.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtColor.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtVIN.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                comboCondition.SelectedIndex = comboCondition.FindStringExact(dataGridView1.CurrentRow.Cells[5].Value.ToString());
                txtPrice.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                comboDealership.SelectedIndex = Helper.curDealership-1;
                comboDealership.Enabled = false;
                carID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                btnSave.Text = "Update";
                btnDelete.Enabled = Enabled;
                btnSale.Enabled = Enabled;
            }
        }

        private void srch_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("carSearchByValue", mysqlCon);
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
                MySqlCommand mySqlCmd = new MySqlCommand("carDeleteByID", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_carID", carID);
                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully");
                Clear();
                GridFill();
            }
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            /*string make = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string model = dataGridView1.CurrentRow.Cells[2].Value.ToString();
         string color=dataGridView1.CurrentRow.Cells[3].Value.ToString();
         string VIN = dataGridView1.CurrentRow.Cells[4].Value.ToString();
         string condition = dataGridView1.CurrentRow.Cells[5].Value.ToString();
         string price=dataGridView1.CurrentRow.Cells[6].Value.ToString();
         int dealership = Convert.ToInt32(dataGridView1.CurrentRow.Cells[8].Value.ToString()) - 1;*/
            Car car1 = new Car(carID, dataGridView1.CurrentRow.Cells[1].Value.ToString(), dataGridView1.CurrentRow.Cells[2].Value.ToString(),
                dataGridView1.CurrentRow.Cells[3].Value.ToString(), dataGridView1.CurrentRow.Cells[4].Value.ToString(), dataGridView1.CurrentRow.Cells[5].Value.ToString(),
                dataGridView1.CurrentRow.Cells[6].Value.ToString(), Convert.ToInt32(dataGridView1.CurrentRow.Cells[8].Value.ToString()) - 1);
            carSale cars = new carSale(car1);
            this.Close();
            cars.Show();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboDealership_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
