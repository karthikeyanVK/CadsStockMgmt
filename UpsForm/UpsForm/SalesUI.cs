using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ElectronicShop.Business.Commands;
using ElectronicShop.DataModel;


namespace ElectronicShop.PresentationLayer
{
    public partial class SalesUI : Form
    {
        Shop myShop = new Shop();
        Product product = new Product();
        Sales sale = new Sales();
        public SalesUI()
        {
            InitializeComponent();
        }
        private void Sales_Load(object sender, EventArgs e)
        {
            myShop.SalesDeserialize(ref myShop);
            dgvSale.DataSource = myShop.SaleList;
            myShop = myShop.ProductDeserialize();
            var modelNames = myShop.AccessModel();
            cboModels.Items.AddRange(modelNames);
        }
        public void VisibleTrue()
        {
            gbSale.Visible = true;
        }
        public void VisibleFalse()
        {
            gbSale.Visible = false;
        }
        public void Reset()
        {
            txtCusName.Clear();
            txtPhoneNo.Clear();
            cboModels.SelectedIndex = -1;
            txtWarranty.Clear();
            txtSalesCode.Clear();
            txtSalesQuantity.Clear();
            txtPrice.Clear();
            lblDisplay.Text = "";
        }

        private void btnSubmitSales_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCusName.Text))
            {
                MessageBox.Show(Filepath.CustomerField);
                txtCusName.Focus();
            }
            else if (String.IsNullOrEmpty(txtPhoneNo.Text))
            {
                MessageBox.Show(Filepath.PhoneField);
                txtPhoneNo.Focus();
            }
            else if (String.IsNullOrEmpty(txtSalesCode.Text))
            {
                MessageBox.Show(Filepath.CodeField);
                txtSalesCode.Focus();
            }
            else if (String.IsNullOrEmpty(txtSalesQuantity.Text))
            {
                MessageBox.Show(Filepath.QuantityField);
                txtSalesQuantity.Focus();
            }
            else if (String.IsNullOrEmpty(txtPrice.Text))
            {
                MessageBox.Show(Filepath.PriceField);
                txtPrice.Focus();
            }
            else if (String.IsNullOrEmpty(txtWarranty.Text))
            {
                MessageBox.Show(Filepath.WarrantyField);
                txtWarranty.Focus();
            }
            else
            {
                if (!File.Exists(Filepath.salesPath))
                {
                    var sale = new Sales()
                    {
                        CustomerName = txtCusName.Text,
                        CustomerPhoneNo = Convert.ToInt64(txtPhoneNo.Text),
                        Date = dateTimePicker1.Value,
                        ModelNo = cboModels.Text,
                        Code = Convert.ToInt32(txtSalesCode.Text),
                        Warranty = Convert.ToInt32(txtWarranty.Text),
                        Price = Convert.ToInt32(txtPrice.Text),
                        Quantity = Convert.ToInt32(txtSalesQuantity.Text)                      
                    };
                    myShop.SaleList.Add(sale);
                }
                else
                {
                    myShop.SalesDeserialize(ref myShop);
                    var sale = new Sales()
                    {
                        CustomerName = txtCusName.Text,
                        CustomerPhoneNo = Convert.ToInt64(txtPhoneNo.Text),
                        Date = dateTimePicker1.Value,
                        ModelNo = cboModels.Text,
                        Code = Convert.ToInt32(txtSalesCode.Text),
                        Warranty = Convert.ToInt32(txtWarranty.Text),
                        Price = Convert.ToInt32(txtPrice.Text),
                        Quantity = Convert.ToInt32(txtSalesQuantity.Text),
                    };
                    myShop.SaleList.Add(sale);
                }
                ProductUI p1 = new ProductUI();
                var modelNumber = cboModels.Text;
                int code = Convert.ToInt32(txtSalesCode.Text);
                int quantity = Convert.ToInt32(txtSalesQuantity.Text);
                var result = p1.UpdateQuantity(modelNumber, code, quantity);
                if (result == false)
                myShop.SaleSerialize(ref myShop);
                dgvSale.DataSource = myShop.SaleList;
                Reset();
            }
        }   
        private void btnView_Click(object sender, EventArgs e)
        {
            dgvSale.Visible = true;
            txtSearch.Visible = true;
            button1.Visible = true;

            VisibleFalse();
            myShop.SalesDeserialize(ref myShop);
            dgvSale.DataSource = myShop.SaleList;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            dgvSale.Visible = false;
            txtSearch.Visible = false;
            button1.Visible = false;
            VisibleTrue();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            var model = txtSearch.Text.ToLower();
            var productsSold = myShop.ViewSale(model);
            dgvSale.DataSource = productsSold;
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cboModels_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currentModelNo = cboModels.Text;
            var selectedProduct = myShop.AccessData(currentModelNo);
            if (selectedProduct != null)
            {
                txtSalesCode.Text = selectedProduct.Code.ToString();
                txtPrice.Text = selectedProduct.Price.ToString();
                txtWarranty.Text = selectedProduct.Warranty.ToString();
                var display = selectedProduct.Quantity.ToString();
                lblDisplay.Text = "Available:" + display;
            }
        }
        private void pictView_Click(object sender, EventArgs e)
        {
            dgvSale.Visible = true;
            txtSearch.Visible = true;
            button1.Visible = true;

            VisibleFalse();
            myShop.SalesDeserialize(ref myShop);
            dgvSale.DataSource = myShop.SaleList;
        }
        private void pictAdd_Click(object sender, EventArgs e)
        {
            dgvSale.Visible = false;
            txtSearch.Visible = false;
            button1.Visible = false;
            VisibleTrue();
        }
        private void pictBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtSalesCode_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtSalesCode.Text, "[^0-9]"))
            {
                MessageBox.Show(Filepath.OnlyNumbers);
                txtSalesCode.Text = txtSalesCode.Text.Remove(txtSalesCode.Text.Length - 1);
            }
        }
        private void txtSalesQuantity_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtSalesQuantity.Text, "[^0-9]"))
            {
                MessageBox.Show(Filepath.OnlyNumbers);
                txtSalesQuantity.Text = txtSalesQuantity.Text.Remove(txtSalesQuantity.Text.Length - 1);
            }
        }
        private void txtCusName_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtCusName.Text, "[^A-Za-z]"))
            {
                MessageBox.Show(Filepath.OnlyAlphabets);
                txtCusName.Text = txtCusName.Text.Remove(txtCusName.Text.Length - 1);
            }
        }
        private void txtPhoneNo_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPhoneNo.Text, "[^0-9]"))
            {
                MessageBox.Show(Filepath.OnlyNumbers);
                txtPhoneNo.Text = txtPhoneNo.Text.Remove(txtPhoneNo.Text.Length - 1);
            }
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPrice.Text, "[^0-9]"))
            {
                MessageBox.Show(Filepath.OnlyNumbers);
                txtPrice.Text = txtPrice.Text.Remove(txtPrice.Text.Length - 1);
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
