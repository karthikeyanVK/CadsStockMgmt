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

namespace ElectronicShop.PresentationLayer
{
    public partial class AvailabilityCheck : Form
    {
        Inventory prolist = new Inventory();
        DataTable dt = new DataTable();
        Deserialization deSerialize = new Deserialization();
        public AvailabilityCheck()
        { 
            InitializeComponent();
        }  
        private void btnSearch_Click(object sender, EventArgs e)
        {
            var modelNumber = txtSearch.Text.ToLower();
            var availableProducts = prolist.SearchProduct(modelNumber);
            dgvCheck.DataSource = availableProducts;
        }
        private void AvailabilityCheck_Load(object sender, EventArgs e)
        {
            deSerialize.ProductDeserialize(ref prolist);
            dgvCheck.DataSource = prolist.plist1;
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
