using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectronicShop.PresentationLayer
{
    public partial class Menu : Form
    {
        public Menu(string Username)
        {
            InitializeComponent();
            label2.Text = Username;
        }
        private void btnProduct_Click(object sender, EventArgs e)
        {
            ProductUI product = new ProductUI();
            product.ShowDialog();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            SalesUI sales = new SalesUI();
            sales.ShowDialog();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            InventoryUI inv = new InventoryUI();
            inv.ShowDialog();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            AvailabilityCheck ava = new AvailabilityCheck();
            ava.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
