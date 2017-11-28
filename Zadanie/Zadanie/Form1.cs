using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Zadanie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Grażyna\Documents\Database1.accdb;
Persist Security Info=False;";
            connection.Open();
            checkConnection.Text = "Connection Succesful";
            connection.Close();
        }


        private void buttonExecute_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Grażyna\Documents\Database1.accdb;
Persist Security Info=False;";
            connection.Open();
            string query = textBoxQuery.Text;
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = query;
            command.ExecuteNonQuery();
            connection.Close();

        }

        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            dataGridViewAcces.DataSource = null;
            dataGridViewAcces.Rows.Clear();
            dataGridViewAcces.Refresh();

            OleDbDataAdapter dAdapter = new OleDbDataAdapter("select * from Dane", @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb;
Persist Security Info=False;");
            OleDbCommandBuilder cBuilder = new OleDbCommandBuilder(dAdapter);

            DataTable dataTable = new DataTable();
            DataSet ds = new DataSet();

            dAdapter.Fill(dataTable);

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataGridViewAcces.Rows.Add(dataTable.Rows[i][0], dataTable.Rows[i][1], dataTable.Rows[i][2]);
            }
        }

        private void buttonRetrieve_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb;
Persist Security Info=False;";
            connection.Open();
            string query = textBoxQuery.Text;

            dataGridViewAcces.DataSource = null;
            dataGridViewAcces.Rows.Clear();
            dataGridViewAcces.Refresh();

            OleDbDataAdapter dAdapter = new OleDbDataAdapter(query, @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb;
Persist Security Info=False;");
            OleDbCommandBuilder cBuilder = new OleDbCommandBuilder(dAdapter);
            DataTable dataTable = new DataTable();
            DataSet ds = new DataSet();

            dAdapter.Fill(dataTable);

            foreach (DataColumn dc in dataTable.Columns)
            {

                dataGridViewAcces.Columns.Add(new DataGridViewTextBoxColumn());

            }

            foreach (DataRow dr in dataTable.Rows)
            {

                dataGridViewAcces.Rows.Add(dr.ItemArray);

            }

            connection.Close();
        }
    }
}
