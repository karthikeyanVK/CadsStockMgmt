using System;
using System.Windows.Forms;
using ElectronicShop.Business.Commands;

namespace ElectronicShop.PresentationLayer
{
    public partial class Report : Form
    {
        Deserialization deserialization = new Deserialization();
        Inventory inventory = new Inventory();
        public Report()
        {
            InitializeComponent();
        }
        private void Report_Load(object sender, EventArgs e)
        {
            deserialization.SalesDeserialize(ref inventory);
            dataGridView1.DataSource = inventory.slist1;
        }
        private void Report_Click(object sender, EventArgs e)
        {
            var dateFrom = dateTimePicker1.Value;
            var dateTo = dateTimePicker2.Value;
            //var result = saleslist.slist1.Where(p => p.Date >= dateFrom && p.Date <= dateTo).ToList();
            var result = inventory.SearchReport(dateFrom, dateTo);
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
