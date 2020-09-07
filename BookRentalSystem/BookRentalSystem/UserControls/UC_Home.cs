using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookRentalSystem.UserControls
{
    public partial class UC_Home : UserControl
    {
        public UC_Home()
        {
            InitializeComponent();
            Initialize_dataGridViewHistory();
        }

        private void btnHomeClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Initialize_dataGridViewHistory()
        {
            //Add each columns' header
            dataGridViewHistory.ColumnCount = 7;
            dataGridViewHistory.Columns[0].Name = "Book Title";
            dataGridViewHistory.Columns[1].HeaderText = "Author";
            dataGridViewHistory.Columns[2].HeaderText = "Publisher";
            dataGridViewHistory.Columns[3].HeaderText = "Category";
            dataGridViewHistory.Columns[4].HeaderText = "Barcode";
            dataGridViewHistory.Columns[5].HeaderText = "Rent Date";
            dataGridViewHistory.Columns[6].HeaderText = "Returned";

            /*
            //Add rows
            // Populate the rows.
            string[] row1 = new string[]{"Meatloaf", 
                                            "Main Dish", boringMeatloaf, boringMeatloafRanking};
            string[] row2 = new string[]{"Key Lime Pie", 
                                            "Dessert", "lime juice, evaporated milk", "****"};
            string[] row3 = new string[]{"Orange-Salsa Pork Chops", 
                                            "Main Dish", "pork chops, salsa, orange juice", "****"};
            string[] row4 = new string[]{"Black Bean and Rice Salad", 
                                            "Salad", "black beans, brown rice", "****"};
            string[] row5 = new string[]{"Chocolate Cheesecake", 
                                            "Dessert", "cream cheese", "***"};
            string[] row6 = new string[]{"Black Bean Dip", "Appetizer",
                                            "black beans, sour cream", "***"};

            object[] rows = new object[] { row1, row2, row3, row4, row5, row6 };

            foreach (string[] rowArray in rows)
            {
                dataGridView.Rows.Add(rowArray);
            }
            */

        }
    }
}
