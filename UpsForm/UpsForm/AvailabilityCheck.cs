using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using ElectronicShop.Business.Commands;
using ElectronicShop.Common;
namespace ElectronicShop.PresentationLayer
{
    public partial class AvailabilityCheck : Form
    {
        Shop myShop = new Shop();
        
        public AvailabilityCheck()
        { 
            InitializeComponent();
        }  
        private void btnSearch_Click(object sender, EventArgs e)
        {
            var modelNumber = txtSearch.Text.ToLower();
            var availableProducts = myShop.Search(modelNumber);
            dgvCheck.DataSource = availableProducts;
        }
        private void AvailabilityCheck_Load(object sender, EventArgs e)
        {
            myShop.ProductDeserialize(ref myShop);
            dgvCheck.DataSource = myShop.ProductList;
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
