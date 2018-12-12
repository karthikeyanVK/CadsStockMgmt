using System;
using System.IO;
using System.Windows.Forms;
using ElectronicShop.Business.Commands;

namespace ElectronicShop.PresentationLayer
{

    public partial class SalesUI : Form
    {
        Inventory p = new Inventory();
        Deserialization deSerialize = new Deserialization();
        Serialization serialize = new Serialization();
        public SalesUI()
        {
            InitializeComponent();
        }
        private void Sales_Load(object sender, EventArgs e)
        {
            deSerialize.SalesDeserialize(ref p);
            dgvSale.DataSource = p.slist1;
            p = deSerialize.ProductDeserialize();
            var modelNames = p.GetModel();
            cboModels.Items.AddRange(modelNames); 
        }

        private void VisibleTrue()
        {
            gbSale.Visible = true;
        }
        private void VisibleFalse()
        {
            gbSale.Visible = false;
        }
        private void Reset()
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
            else if(String.IsNullOrEmpty(txtWarranty.Text))
            {
                MessageBox.Show(Filepath.WarrantyField);
                txtWarranty.Focus();
            }
            else
            {
                if (!File.Exists(Filepath.salesPath))
                {
                    p.slist1.Add(new Sales
                    {
                        CustomerName = txtCusName.Text,
                        CustomerPhoneNo = Convert.ToInt64(txtPhoneNo.Text),
                        ModelName = cboModels.Text,
                        Code = Convert.ToInt32(txtSalesCode.Text),
                        Warranty = Convert.ToInt32(txtWarranty.Text),
                        Price = Convert.ToInt32(txtPrice.Text),
                        Quantity = Convert.ToInt32(txtSalesQuantity.Text),
                        Date = dateTimePicker1.Value
                    });
                }
                else
                {
                    deSerialize.SalesDeserialize(ref p);
                    p.slist1.Add(new Sales
                    {
                        CustomerName = txtCusName.Text,
                        CustomerPhoneNo = Convert.ToInt64(txtPhoneNo.Text),
                        ModelName = cboModels.Text,
                        Code = Convert.ToInt32(txtSalesCode.Text),
                        Warranty = Convert.ToInt32(txtWarranty.Text),
                        Price = Convert.ToInt32(txtPrice.Text),
                        Quantity = Convert.ToInt32(txtSalesQuantity.Text),
                        Date = dateTimePicker1.Value
                    });
                }
                ProductUI p1 = new ProductUI();
                var modelNumber = cboModels.Text;
                int code = Convert.ToInt32(txtSalesCode.Text);      
                int quantity = Convert.ToInt32(txtSalesQuantity.Text);
                var result = p1.UpdateQuantity(modelNumber,code, quantity);

                if(result==false)
                serialize.SaleSerialize(ref p);
                Reset();
            }
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
            if (System.Text.RegularExpressions.Regex.IsMatch(txtSalesQuantity.Text, "[^1-90]"))
            {
                MessageBox.Show(Filepath.OnlyNumbers);
                txtSalesQuantity.Text = txtSalesQuantity.Text.Remove(txtSalesQuantity.Text.Length - 1);
            }
        }
        private void btnView_Click(object sender, EventArgs e)
        {
            dgvSale.Visible = true;
            txtSearch.Visible=true;
            button1.Visible = true;

            VisibleFalse();
            deSerialize.SalesDeserialize(ref p);
            dgvSale.DataSource = p.slist1;
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
            var productsSold = p.SearchBill(model);
            dgvSale.DataSource = productsSold;
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }       
        private void cboModels_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currentModelNo = cboModels.Text;
            Product selectedProduct = p.GetData(currentModelNo);
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
            deSerialize.SalesDeserialize(ref p);
            dgvSale.DataSource = p.slist1;
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
