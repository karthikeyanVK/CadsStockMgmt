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
    public partial class Report : Form
    {
        //Deserialization deserialization = new Deserialization();
        Shop myShop = new Shop();
        public Report()
        {
            InitializeComponent();
        }
        private void Report_Load(object sender, EventArgs e)
        {
            myShop.SalesDeserialize(ref myShop);
            dataGridView1.DataSource = myShop.SaleList;
        }
        private void Report_Click(object sender, EventArgs e)
        {
            var dateFrom = dateTimePicker1.Value;
            var dateTo = dateTimePicker2.Value;
            //var result = saleslist.slist1.Where(p => p.Date >= dateFrom && p.Date <= dateTo).ToList();
            var result = myShop.AccessReport(dateFrom, dateTo);
            dataGridView1.DataSource = result;
        }
        private void Menu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
