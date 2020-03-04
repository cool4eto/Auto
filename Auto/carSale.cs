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
    public partial class carSale : Form
    {
        string connectionString = @"Server=localhost;Database=auto;Uid=root;Pwd=root;";
        int saleID = 0;//ako id=0 to save ako ne update
        int userID = 1;
        int clientID = 1;



        private Car carForSale;
        public carSale()
        {
            InitializeComponent();
        }
        public carSale(Car car1)
        {
            InitializeComponent();
            carForSale = car1;
            txtMake.Text = carForSale.getMake();
            txtModel.Text = carForSale.getModel();
            txtColor.Text = carForSale.getColor();
            txtVIN.Text = carForSale.getVIN();
            comboCondition.SelectedIndex = comboCondition.FindStringExact(carForSale.getCondition());
            txtPrice.Text = carForSale.getPrice();
            GridFill();
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            double newPrice=Convert.ToDouble(txtNewPrice.Text);
            double oldPrice = Convert.ToDouble(txtPrice.Text);
            double maxDiscount = oldPrice / 100 * 20;
            if (oldPrice - newPrice > maxDiscount)
            {
                MessageBox.Show("Discount cannot be more than 20%",
                                 "Price errror",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error 
                                    );
            }
            else
            {
                using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
                {
                    mysqlCon.Open();
                    MySqlCommand mySqlCmd = new MySqlCommand("Sale", mysqlCon);
                    mySqlCmd.CommandType = CommandType.StoredProcedure;
                    mySqlCmd.Parameters.AddWithValue("_userID", Helper.curUser);

                    mySqlCmd.Parameters.AddWithValue("_carID", this.carForSale.getCarID());

                    mySqlCmd.Parameters.AddWithValue("_clientID", dataGridView1.CurrentRow.Cells[0].Value);

                    mySqlCmd.Parameters.AddWithValue("_newPrice", Convert.ToDouble(newPrice));

                    mySqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Submitted Successfully");
                    this.Close();
                    carCRUD carcr1 = new carCRUD();
                    carcr1.Show();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                clientID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                btnSale.Enabled=true;
                
            }
        }
        void GridFill()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("clientViewAll", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtblBook = new DataTable();
                sqlDa.Fill(dtblBook);
                dataGridView1.DataSource = dtblBook;
                dataGridView1.Columns[0].Visible = false;//za da ne se wijda id ot usera
            }
        }

        private void carSale_Load(object sender, EventArgs e)
        {

        }

        private void srch_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("clientSearchByValue", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("_SearchValue", txtSearch.Text);
                DataTable dtblBook = new DataTable();
                sqlDa.Fill(dtblBook);
                dataGridView1.DataSource = dtblBook;
                dataGridView1.Columns[0].Visible = false;
                if(dtblBook.Rows.Count==0)
                {
                    btnAddClient.Visible = true;
                }
            }
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            clientCRUD client = new clientCRUD();
            client.Show();
            btnAddClient.Visible = false;
        }

        
    }
}
