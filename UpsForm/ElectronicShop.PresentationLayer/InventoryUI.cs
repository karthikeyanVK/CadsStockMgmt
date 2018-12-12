using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ElectronicShop.Business.Commands;

namespace ElectronicShop.PresentationLayer
{
    public partial class InventoryUI : Form
    {
        Inventory inventory = new Inventory();
        Deserialization deSerialize = new Deserialization();
        
        public InventoryUI()
        {
            InitializeComponent();
          
        }
        private void Reset()
        {
            cboModel.SelectedIndex = -1;
            txtInventoryCode.Clear();
            txtInventoryQuantity.Clear();
          
        }
        private void InventoryUI_Load(object sender, EventArgs e)
        {
            inventory = deSerialize.ProductDeserialize();
            var modelNames = inventory.GetModel();
            cboModel.Items.AddRange(modelNames);
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
             if (String.IsNullOrEmpty(cboModel.Text))
            {
                MessageBox.Show(Filepath.ModelField);
                cboModel.Focus();
            }
            else if (String.IsNullOrEmpty(txtInventoryCode.Text))
            {
                MessageBox.Show(Filepath.CodeField);
                txtInventoryCode.Focus();
            }
            else if (String.IsNullOrEmpty(txtInventoryQuantity.Text))
            {
                MessageBox.Show(Filepath.QuantityField);
                txtInventoryQuantity.Focus();
            }                 
            else
            {
                ProductUI p1 = new ProductUI();
                string modelNo = cboModel.Text;
                int code = Convert.ToInt32(txtInventoryCode.Text);
                int quantity = Convert.ToInt32(txtInventoryQuantity.Text);
                //var addproduct = inventory.AddExistingProduct(modelNo, code, quantity);
                p1.AddQuantity(modelNo,code, quantity);
                Reset();
            }
           
        }

        private void txtInventoryCode_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtInventoryCode.Text, "[^0-9]"))
            {
                MessageBox.Show(Filepath.OnlyNumbers);
                txtInventoryCode.Text = txtInventoryCode.Text.Remove(txtInventoryCode.Text.Length - 1);
            }
        }      
        private void txtInventoryQuantity_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtInventoryQuantity.Text, "[^0-9]"))
            {
                MessageBox.Show(Filepath.OnlyNumbers);
                txtInventoryQuantity.Text = txtInventoryQuantity.Text.Remove(txtInventoryQuantity.Text.Length - 1);
            }
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currentModelNo = cboModel.Text;
            Product selectedProduct = inventory.GetData(currentModelNo);
            if (selectedProduct != null)
            {
                txtInventoryCode.Text = selectedProduct.Code.ToString();             
            }
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
