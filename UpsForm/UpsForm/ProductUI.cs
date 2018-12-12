using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using ElectronicShop.Business.Commands;
using ElectronicShop.DataModel;

namespace ElectronicShop.PresentationLayer
{
    public partial class ProductUI : Form
    {
        Shop myShop = new Shop();
        
        public ProductUI()
        {
            InitializeComponent();
        }     

        private void Reset()
        {
            cboBrand.SelectedIndex = -1;
            txtCode.Clear();
            txtModel.Clear();
            txtPower.Clear();
            txtPrice.Clear();
            cboVoltage.SelectedIndex = -1;
            txtWarranty.Clear();
            txtQuantity.Clear();
        }
        public void VisibleFalse()
        {
            gbProduct.Visible = false;
        }
        public void VisibleTrue()
        {
            gbProduct.Visible = true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            dgvData.Visible = false;
            VisibleTrue();
        }
        public void btnView_Click(object sender, EventArgs e)
        {
            dgvData.Visible = true ;
            VisibleFalse();
            myShop.ProductDeserialize(ref myShop);
            dgvData.DataSource = myShop.ProductList;
        }
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cboBrand.Text))
            {
                MessageBox.Show(Filepath.BrandField);
                cboBrand.Focus();
            }
            else if (String.IsNullOrEmpty(txtModel.Text))
            {
                MessageBox.Show(Filepath.ModelField);
                txtModel.Focus();
            }
            else if (String.IsNullOrEmpty(txtCode.Text))
            {
                MessageBox.Show(Filepath.CodeField);
                txtCode.Focus();
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
            else if (String.IsNullOrEmpty(txtPower.Text))
            {
                MessageBox.Show(Filepath.PowerField);
                txtPower.Focus();
            }
            else if (String.IsNullOrEmpty(cboVoltage.Text))
            {
                MessageBox.Show(Filepath.VoltageField);
                cboVoltage.Focus();
            }
            else if (String.IsNullOrEmpty(txtQuantity.Text))
            {
                MessageBox.Show(Filepath.QuantityField);
                txtQuantity.Focus();
            }
            else
            {
                if (!File.Exists(Filepath.productPath))
                {
                    var prod = new Product()
                    {
                        Brand = cboBrand.Text,
                        Code = Convert.ToInt32(txtCode.Text),
                        ModelNo = txtModel.Text,
                        Price = Convert.ToInt32(txtPrice.Text),
                        Warranty = Convert.ToInt32(txtWarranty.Text),
                        Voltage = cboVoltage.Text,
                        OutputPower = Convert.ToInt64(txtPower.Text),
                        Quantity = Convert.ToInt32(txtQuantity.Text)
                    };
                    var result = myShop.AddProduct(prod);
                    if (result == true)
                    {
                        myShop.ProductSerialize(ref myShop);
                        MessageBox.Show(Filepath.ProductAdded);
                        Reset();
                    }
                    else
                    {
                        MessageBox.Show("Modelno already exists");
                        Reset();
                    }
                }
            }
        }
        public void AddQuantity(string modelno,int code,int quantity)
        {
            myShop.ProductDeserialize(ref myShop);
            dgvData.DataSource = myShop.ProductList;
            bool result = myShop.AddExistingProduct(modelno,code,quantity);
                if (result)
                {
                    MessageBox.Show(Filepath.QuantityAdded);
                myShop.ProductSerialize(ref myShop);
                Reset();
                }
                else
                {
                    MessageBox.Show("Enter valid ModelNo and the corresponding code");
                    txtCode.Clear();
                    txtModel.Clear();
                } 
        }
        public bool UpdateQuantity(string ModelNumber, int code, int quantity)
        {
            myShop.ProductDeserialize(ref myShop);
            dgvData.DataSource = myShop.ProductList;
            bool result1 = myShop.CheckQuantityAvailability(ModelNumber, code, quantity);
            

            if(result1)
            {
                MessageBox.Show(Filepath.QuantityExceeds);
                txtQuantity.Clear();
                return true;
            }
            else 
            {
                if(myShop.SaleProduct(ModelNumber, code, quantity))
                {
                    MessageBox.Show(Filepath.ProductSold);
                    myShop.ProductSerialize(ref myShop);
                }
                return false;
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void txtCode_TextChanged_1(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtCode.Text, "[^0-9]"))
            {
                MessageBox.Show(Filepath.OnlyNumbers);
                txtCode.Text = txtCode.Text.Remove(txtCode.Text.Length - 1);
            }
        }
        private void txtPrice_TextChanged_1(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPrice.Text, "[^0-9]"))
            {
                MessageBox.Show(Filepath.OnlyNumbers);
                txtPrice.Text = txtPrice.Text.Remove(txtPrice.Text.Length - 1);
            }
        }
        private void txtWarranty_TextChanged_1(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtWarranty.Text, "[^0-9]"))
            {
                MessageBox.Show(Filepath.OnlyNumbers);
                txtWarranty.Text = txtWarranty.Text.Remove(txtWarranty.Text.Length - 1);
            }
        }
        private void txtPower_TextChanged_1(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPower.Text, "[^0-9]"))
            {
                MessageBox.Show(Filepath.OnlyNumbers);
                txtPower.Text = txtPower.Text.Remove(txtPower.Text.Length - 1);
            }
        }
        private void txtQuantity_TextChanged_1(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtQuantity.Text, "[^0-9]"))
            {
                MessageBox.Show(Filepath.OnlyNumbers);
                txtQuantity.Text = txtQuantity.Text.Remove(txtQuantity.Text.Length - 1);
            }
        }
        private void txtModel_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtModel.Text, "[^A-Za-z0-9]"))
            {
                MessageBox.Show(Filepath.OnlyAlphanumeric);
                txtModel.Text = txtModel.Text.Remove(txtModel.Text.Length - 1);
            }
        } 
        private void picAdd_Click(object sender, EventArgs e)
        {
            dgvData.Visible = false;
            VisibleTrue();
        }
        private void picBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picView_Click(object sender, EventArgs e)
        {
            dgvData.Visible = true;
            VisibleFalse();
            myShop.ProductDeserialize(ref myShop);
            dgvData.DataSource = myShop.ProductList;
        }

        private void ProductUI_Load(object sender, EventArgs e)
        {
            myShop.ProductDeserialize(ref myShop);
        }
    }
}
