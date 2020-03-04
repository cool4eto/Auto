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
using DGVPrinterHelper;

namespace Auto
{
    public partial class qCarsSoldByDealership : Form
    {
        string connectionString = @"Server=localhost;Database=auto;Uid=root;Pwd=root;";
        public qCarsSoldByDealership()
        {
            InitializeComponent();
            GridFill();
        }

        private void srch_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("qCarsSoldByDealershipSearchByValue", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("_SearchValue", txtSearch.Text);
                DataTable dtblBook = new DataTable();
                sqlDa.Fill(dtblBook);
                dataGridView1.DataSource = dtblBook;
                dtblBook.Columns["price1"].ColumnName = "final Price";
                dtblBook.Columns["name"].ColumnName = "salesman";
                dtblBook.Columns["name1"].ColumnName = "client";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            }
        }
        void GridFill()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("qCarsSoldByDealership", mysqlCon);//tuk shte ni izlizat samo koli koito mojem da prodadem
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("_idDealership", Helper.curDealership);
                DataTable dtblBook = new DataTable();
                sqlDa.Fill(dtblBook);
                dataGridView1.DataSource = dtblBook;
                dtblBook.Columns["price1"].ColumnName = "final Price";
                dtblBook.Columns["name"].ColumnName = "salesman";
                dtblBook.Columns["name1"].ColumnName = "client";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

              
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Cars sold by Dealership";
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Volkswagen Bulgaria";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dataGridView1);
        }
    }
}
