namespace ElectronicShop.PresentationLayer
{
    partial class ProductUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblWarranty = new System.Windows.Forms.Label();
            this.lblOutputPower = new System.Windows.Forms.Label();
            this.lblVoltage = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtWarranty = new System.Windows.Forms.TextBox();
            this.txtPower = new System.Windows.Forms.TextBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.cboBrand = new System.Windows.Forms.ComboBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.gbProduct = new System.Windows.Forms.GroupBox();
            this.cboVoltage = new System.Windows.Forms.ComboBox();
            this.ttAdd = new System.Windows.Forms.ToolTip(this.components);
            this.ttBack = new System.Windows.Forms.ToolTip(this.components);
            this.ttView = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.gbProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 55);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::ElectronicShop.PresentationLayer.Properties.Resources.view;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Location = new System.Drawing.Point(620, 14);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 27);
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            this.ttView.SetToolTip(this.pictureBox3, "View");
            this.pictureBox3.Click += new System.EventHandler(this.picView_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::ElectronicShop.PresentationLayer.Properties.Resources.back1;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(726, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 27);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            this.ttBack.SetToolTip(this.pictureBox2, "Back");
            this.pictureBox2.Click += new System.EventHandler(this.picBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::ElectronicShop.PresentationLayer.Properties.Resources.add1;
            this.pictureBox1.Location = new System.Drawing.Point(672, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.ttAdd.SetToolTip(this.pictureBox1, "Add Product");
            this.pictureBox1.Click += new System.EventHandler(this.picAdd_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(20, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(139, 24);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Reliance Digital";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.Location = new System.Drawing.Point(30, 44);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(44, 16);
            this.lblBrand.TabIndex = 1;
            this.lblBrand.Text = "Brand";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(30, 124);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(41, 16);
            this.lblCode.TabIndex = 2;
            this.lblCode.Text = "Code";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(30, 166);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(39, 16);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Price";
            // 
            // lblWarranty
            // 
            this.lblWarranty.AutoSize = true;
            this.lblWarranty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarranty.Location = new System.Drawing.Point(30, 207);
            this.lblWarranty.Name = "lblWarranty";
            this.lblWarranty.Size = new System.Drawing.Size(79, 16);
            this.lblWarranty.TabIndex = 4;
            this.lblWarranty.Text = "Warranty(Y)";
            // 
            // lblOutputPower
            // 
            this.lblOutputPower.AutoSize = true;
            this.lblOutputPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputPower.Location = new System.Drawing.Point(30, 254);
            this.lblOutputPower.Name = "lblOutputPower";
            this.lblOutputPower.Size = new System.Drawing.Size(108, 16);
            this.lblOutputPower.TabIndex = 5;
            this.lblOutputPower.Text = "Output Power(W)";
            // 
            // lblVoltage
            // 
            this.lblVoltage.AutoSize = true;
            this.lblVoltage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoltage.Location = new System.Drawing.Point(30, 299);
            this.lblVoltage.Name = "lblVoltage";
            this.lblVoltage.Size = new System.Drawing.Size(72, 16);
            this.lblVoltage.TabIndex = 6;
            this.lblVoltage.Text = "Voltage(V)";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(149, 121);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(202, 20);
            this.txtCode.TabIndex = 6;
            this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged_1);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(149, 163);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(202, 20);
            this.txtPrice.TabIndex = 7;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged_1);
            // 
            // txtWarranty
            // 
            this.txtWarranty.Location = new System.Drawing.Point(149, 204);
            this.txtWarranty.Name = "txtWarranty";
            this.txtWarranty.Size = new System.Drawing.Size(202, 20);
            this.txtWarranty.TabIndex = 8;
            this.txtWarranty.TextChanged += new System.EventHandler(this.txtWarranty_TextChanged_1);
            // 
            // txtPower
            // 
            this.txtPower.Location = new System.Drawing.Point(148, 251);
            this.txtPower.Name = "txtPower";
            this.txtPower.Size = new System.Drawing.Size(203, 20);
            this.txtPower.TabIndex = 9;
            this.txtPower.TextChanged += new System.EventHandler(this.txtPower_TextChanged_1);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(148, 385);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(75, 23);
            this.btnAddProduct.TabIndex = 12;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(252, 385);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AllowUserToOrderColumns = true;
            this.dgvData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(25, 61);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.Size = new System.Drawing.Size(736, 297);
            this.dgvData.TabIndex = 15;
            this.dgvData.Visible = false;
            // 
            // cboBrand
            // 
            this.cboBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBrand.FormattingEnabled = true;
            this.cboBrand.Items.AddRange(new object[] {
            "Zebronics",
            "hp",
            "Microtek"});
            this.cboBrand.Location = new System.Drawing.Point(149, 39);
            this.cboBrand.Name = "cboBrand";
            this.cboBrand.Size = new System.Drawing.Size(202, 21);
            this.cboBrand.TabIndex = 4;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(30, 345);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(56, 16);
            this.lblQuantity.TabIndex = 17;
            this.lblQuantity.Text = "Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(149, 344);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(202, 20);
            this.txtQuantity.TabIndex = 11;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged_1);
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.Location = new System.Drawing.Point(30, 84);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(83, 16);
            this.lblModel.TabIndex = 19;
            this.lblModel.Text = "ModelName";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(149, 80);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(202, 20);
            this.txtModel.TabIndex = 5;
            this.txtModel.TextChanged += new System.EventHandler(this.txtModel_TextChanged);
            // 
            // gbProduct
            // 
            this.gbProduct.Controls.Add(this.cboVoltage);
            this.gbProduct.Controls.Add(this.txtModel);
            this.gbProduct.Controls.Add(this.lblModel);
            this.gbProduct.Controls.Add(this.txtQuantity);
            this.gbProduct.Controls.Add(this.lblQuantity);
            this.gbProduct.Controls.Add(this.cboBrand);
            this.gbProduct.Controls.Add(this.btnReset);
            this.gbProduct.Controls.Add(this.btnAddProduct);
            this.gbProduct.Controls.Add(this.txtPower);
            this.gbProduct.Controls.Add(this.txtWarranty);
            this.gbProduct.Controls.Add(this.txtPrice);
            this.gbProduct.Controls.Add(this.txtCode);
            this.gbProduct.Controls.Add(this.lblVoltage);
            this.gbProduct.Controls.Add(this.lblOutputPower);
            this.gbProduct.Controls.Add(this.lblWarranty);
            this.gbProduct.Controls.Add(this.lblPrice);
            this.gbProduct.Controls.Add(this.lblCode);
            this.gbProduct.Controls.Add(this.lblBrand);
            this.gbProduct.Location = new System.Drawing.Point(147, 87);
            this.gbProduct.Name = "gbProduct";
            this.gbProduct.Size = new System.Drawing.Size(381, 448);
            this.gbProduct.TabIndex = 20;
            this.gbProduct.TabStop = false;
            // 
            // cboVoltage
            // 
            this.cboVoltage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVoltage.FormattingEnabled = true;
            this.cboVoltage.Items.AddRange(new object[] {
            "10V",
            "20V",
            "30V"});
            this.cboVoltage.Location = new System.Drawing.Point(148, 294);
            this.cboVoltage.Name = "cboVoltage";
            this.cboVoltage.Size = new System.Drawing.Size(203, 21);
            this.cboVoltage.TabIndex = 10;
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ElectronicShop.PresentationLayer.Properties.Resources.bg_ecommerce;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(799, 581);
            this.Controls.Add(this.gbProduct);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.panel1);
            this.Name = "Product";
            this.Text = "Product";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.gbProduct.ResumeLayout(false);
            this.gbProduct.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblWarranty;
        private System.Windows.Forms.Label lblOutputPower;
        private System.Windows.Forms.Label lblVoltage;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtWarranty;
        private System.Windows.Forms.TextBox txtPower;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.ComboBox cboBrand;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.GroupBox gbProduct;
        private System.Windows.Forms.ComboBox cboVoltage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolTip ttAdd;
        private System.Windows.Forms.ToolTip ttBack;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ToolTip ttView;
    }
}