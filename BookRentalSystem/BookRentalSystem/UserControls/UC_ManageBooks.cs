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
    public partial class UC_ManageBooks : UserControl
    {
        public UC_ManageBooks()
        {
            InitializeComponent();
        }

        private void btnBookRentalClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
