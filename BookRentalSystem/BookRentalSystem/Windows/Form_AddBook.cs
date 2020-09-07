using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Configuration;

namespace BookRentalSystem.Windows
{
    public partial class Form_AddBook : Form
    {
        public Form_AddBook()
        {
            InitializeComponent();
        }

        private void btnAddBookSubmit_Click(object sender, EventArgs e)
        {
            string mainConn = ConfigurationManager.ConnectionStrings["SkyLibraryConn"].ConnectionString;
            SqlConnection sqlConn = new SqlConnection(mainConn);
            string sqlQuery = "insert into [dbo].[Book] values (@BookId, @AuthorId, @PublisherId, @CategoryId, @Title, @Barcode, @Available)";

            sqlConn.Open();

            SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConn);
            sqlCommand.Parameters.AddWithValue("@Title", txtAddTitle.Text);
            sqlCommand.Parameters.AddWithValue("@Author", txtAddAuthorFirstname.Text);
            sqlCommand.Parameters.AddWithValue("@Publisher", txtAddPublisher.Text);
            sqlCommand.Parameters.AddWithValue("@Barcode", txtAddBarcode.Text);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("The book is successfully added.");
            //displayData();
            sqlConn.Close();
        }

    }
}
