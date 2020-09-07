using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Configuration;
using BookRentalSystem.Windows;

namespace BookRentalSystem.UserControls
{
    public partial class UC_ManageBooks : UserControl
    {
        public UC_ManageBooks()
        {
            InitializeComponent();

            displayData();
        }

        private void btnBookRentalClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UC_ManageBooks_Load(object sender, EventArgs e)
        {

        }

        private void displayData()
        {
            string mainConn = ConfigurationManager.ConnectionStrings["SkyLibraryConn"].ConnectionString;
            SqlConnection sqlConn = new SqlConnection(mainConn);
            string sqlQuery = "select * from [dbo].[Book]";
            
            sqlConn.Open();

            SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConn);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
            sda.Fill(dt);
            dgvManageBookList.DataSource = dt;
            
            sqlConn.Close();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            //string mainConn = ConfigurationManager.ConnectionStrings["SkyLibraryConn"].ConnectionString;
            //SqlConnection sqlConn = new SqlConnection(mainConn);
            //string sqlQuery = "insert into [dbo].[Book] values (@BookId, @AuthorId, @PublisherId, @CategoryId, @Title, @Barcode, @Available)";

            //sqlConn.Open();

            //SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConn);
            //sqlCommand.Parameters.AddWithValue("@BookId", txt1.Text);
            //sqlCommand.ExecuteNonQuery();
            //MessageBox.Show("Saved");
            //displayData();
            //sqlConn.Close();

            Form_AddBook form = new Form_AddBook();
            {
                form.ShowDialog();
            }
        }
    }
}
