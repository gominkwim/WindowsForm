using BookRentalSystem.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookRentalSystem
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(c);
        }

        private void panelHome_Click(object sender, EventArgs e)
        {
            UC_Home uch = new UC_Home();
            AddControlsToPanel(uch);
        }

        private void pictureBox_home_Click(object sender, EventArgs e)
        {
            UC_Home uch = new UC_Home();
            AddControlsToPanel(uch);
        }

        private void lblHome_Click(object sender, EventArgs e)
        {
            UC_Home uch = new UC_Home();
            AddControlsToPanel(uch);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelAccount_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_account_Click(object sender, EventArgs e)
        {

        }

        private void lblAccount_Click(object sender, EventArgs e)
        {

        }

        private void panelBookRental_Click(object sender, EventArgs e)
        {
            UC_BookRental ucb = new UC_BookRental();
            AddControlsToPanel(ucb);
        }

        private void pictureBox_bookRental_Click(object sender, EventArgs e)
        {
            UC_BookRental ucb = new UC_BookRental();
            AddControlsToPanel(ucb);
        }

        private void lblBookRental_Click(object sender, EventArgs e)
        {
            UC_BookRental ucb = new UC_BookRental();
            AddControlsToPanel(ucb);
        }

        private void panelManageBooks_Click(object sender, EventArgs e)
        {
            UC_ManageBooks ucmb = new UC_ManageBooks();
            AddControlsToPanel(ucmb);
        }

        private void lblManageBooks_Click(object sender, EventArgs e)
        {
            UC_ManageBooks ucmb = new UC_ManageBooks();
            AddControlsToPanel(ucmb);
        }

        private void pictureBox_manageBooks_Click(object sender, EventArgs e)
        {
            UC_ManageBooks ucmb = new UC_ManageBooks();
            AddControlsToPanel(ucmb);
        }
    }
}
