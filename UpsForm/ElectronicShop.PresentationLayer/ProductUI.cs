using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using ElectronicShop.Business.Commands;

namespace ElectronicShop.PresentationLayer
{
    public partial class ProductUI : Form
    { 
        List<Product> listemp = new List<Product>();
        Inventory p = new Inventory();
        Deserialization deSerialize = new Deserialization();
        Serialization serialize = new Serialization();
             
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
        private void VisibleFalse()
        {
            gbProduct.Visible = false;
        }
        private void VisibleTrue()
        {
            gbProduct.Visible = true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            dgvData.Visible = false;
            VisibleTrue();
        }
        private void btnView_Click(object sender, EventArgs e)
        {
            dgvData.Visible = true ;
            VisibleFalse();
            deSerialize.ProductDeserialize(ref p);
            dgvData.DataSource = p.plist1;
        }
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cboBrand.Text))
            {
                MessageBox.Show(Filepath.BrandField);
                cboBrand.Focus();
            }
            else if(String.IsNullOrEmpty(txtModel.Text))
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
                    p.plist1.Add(new Product
                    {
                        Brand = cboBrand.Text,
                        Code = Convert.ToInt32(txtCode.Text),
                        ModelNo = txtModel.Text,
                        Price = Convert.ToInt32(txtPrice.Text),
                        Warranty = Convert.ToInt32(txtWarranty.Text),
                        Voltage = cboVoltage.Text,
                        OutputPower = Convert.ToInt64(txtPower.Text),
                        Quantity = Convert.ToInt32(txtQuantity.Text)
                    });
                    serialize.ProductSerialize(ref p);
                }  
                else
                {
                    deSerialize.ProductDeserialize(ref p);
                    p.plist1.Add(new Product
                    {
                        Brand = cboBrand.Text,
                        Code = Convert.ToInt32(txtCode.Text),
                        ModelNo = txtModel.Text,
                        Price = Convert.ToInt32(txtPrice.Text),
                        Warranty = Convert.ToInt32(txtWarranty.Text),
                        Voltage = cboVoltage.Text,
                        OutputPower = Convert.ToInt64(txtPower.Text),
                        Quantity = Convert.ToInt32(txtQuantity.Text)
                    });
                    serialize.ProductSerialize(ref p);

                }
                //serialize.ProductSerialize(ref p);
                MessageBox.Show(Filepath.ProductAdded);
                Reset();
            }                
        }
        public void AddQuantity(string modelno,int code,int quantity)
        {
            deSerialize.ProductDeserialize(ref p);
            dgvData.DataSource = p.plist1;
            bool result = p.AddExistingProduct(modelno,code,quantity);
                if (result)
                {
                    MessageBox.Show(Filepath.QuantityAdded);
                serialize.ProductSerialize(ref p);
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
            deSerialize.ProductDeserialize(ref p);
            dgvData.DataSource = p.plist1;
            bool result1 = p.CheckQuantityAvailability(ModelNumber, code, quantity);
            

            if(result1)
            {
                MessageBox.Show(Filepath.QuantityExceeds);
                txtQuantity.Clear();
                return true;
            }
            else 
            {
                if(p.SaleProduct(ModelNumber, code, quantity))
                {
                    MessageBox.Show(Filepath.ProductSold);
                    serialize.ProductSerialize(ref p);
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
            deSerialize.ProductDeserialize(ref p);
            dgvData.DataSource = p.plist1;
        }
    }
}
