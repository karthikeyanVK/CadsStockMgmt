namespace ElectronicShop.PresentationLayer
{
    partial class SalesUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtSalesCode = new System.Windows.Forms.TextBox();
            this.txtSalesQuantity = new System.Windows.Forms.TextBox();
            this.btnSubmitSales = new System.Windows.Forms.Button();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblCus = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtCusName = new System.Windows.Forms.TextBox();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.dgvSale = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.gbSale = new System.Windows.Forms.GroupBox();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.txtWarranty = new System.Windows.Forms.TextBox();
            this.lblWarranty = new System.Windows.Forms.Label();
            this.cboModels = new System.Windows.Forms.ComboBox();
            this.ttView = new System.Windows.Forms.ToolTip(this.components);
            this.ttAdd = new System.Windows.Forms.ToolTip(this.components);
            this.ttBack = new System.Windows.Forms.ToolTip(this.components);
            this.btnReset = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSale)).BeginInit();
            this.gbSale.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 55);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::ElectronicShop.PresentationLayer.Properties.Resources.view;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Location = new System.Drawing.Point(651, 13);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 27);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            this.ttView.SetToolTip(this.pictureBox3, "View");
            this.pictureBox3.Click += new System.EventHandler(this.pictView_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::ElectronicShop.PresentationLayer.Properties.Resources.add1;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(702, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 27);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.ttAdd.SetToolTip(this.pictureBox2, "Add Bill");
            this.pictureBox2.Click += new System.EventHandler(this.pictAdd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ElectronicShop.PresentationLayer.Properties.Resources.back1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(753, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 27);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.ttBack.SetToolTip(this.pictureBox1, "Back");
            this.pictureBox1.Click += new System.EventHandler(this.pictBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reliance Digital";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(22, 211);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(47, 20);
            this.lblCode.TabIndex = 1;
            this.lblCode.Text = "Code";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(22, 260);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(68, 20);
            this.lblQuantity.TabIndex = 3;
            this.lblQuantity.Text = "Quantity";
            // 
            // txtSalesCode
            // 
            this.txtSalesCode.Location = new System.Drawing.Point(180, 211);
            this.txtSalesCode.Name = "txtSalesCode";
            this.txtSalesCode.Size = new System.Drawing.Size(227, 20);
            this.txtSalesCode.TabIndex = 8;
            this.txtSalesCode.TextChanged += new System.EventHandler(this.txtSalesCode_TextChanged);
            // 
            // txtSalesQuantity
            // 
            this.txtSalesQuantity.Location = new System.Drawing.Point(180, 260);
            this.txtSalesQuantity.Name = "txtSalesQuantity";
            this.txtSalesQuantity.Size = new System.Drawing.Size(227, 20);
            this.txtSalesQuantity.TabIndex = 9;
            this.txtSalesQuantity.TextChanged += new System.EventHandler(this.txtSalesQuantity_TextChanged);
            // 
            // btnSubmitSales
            // 
            this.btnSubmitSales.Location = new System.Drawing.Point(209, 395);
            this.btnSubmitSales.Name = "btnSubmitSales";
            this.btnSubmitSales.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitSales.TabIndex = 12;
            this.btnSubmitSales.Text = "Submit";
            this.btnSubmitSales.UseVisualStyleBackColor = true;
            this.btnSubmitSales.Click += new System.EventHandler(this.btnSubmitSales_Click);
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.Location = new System.Drawing.Point(22, 116);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(98, 20);
            this.lblModel.TabIndex = 10;
            this.lblModel.Text = "Model Name";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(22, 310);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 20);
            this.lblPrice.TabIndex = 12;
            this.lblPrice.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(180, 310);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(227, 20);
            this.txtPrice.TabIndex = 10;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // lblCus
            // 
            this.lblCus.AutoSize = true;
            this.lblCus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCus.Location = new System.Drawing.Point(22, 21);
            this.lblCus.Name = "lblCus";
            this.lblCus.Size = new System.Drawing.Size(124, 20);
            this.lblCus.TabIndex = 14;
            this.lblCus.Text = "Customer Name";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(22, 65);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(79, 20);
            this.lblPhone.TabIndex = 15;
            this.lblPhone.Text = "Phone No";
            // 
            // txtCusName
            // 
            this.txtCusName.Location = new System.Drawing.Point(180, 23);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.Size = new System.Drawing.Size(227, 20);
            this.txtCusName.TabIndex = 4;
            this.txtCusName.TextChanged += new System.EventHandler(this.txtCusName_TextChanged);
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(180, 67);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(227, 20);
            this.txtPhoneNo.TabIndex = 5;
            this.txtPhoneNo.TextChanged += new System.EventHandler(this.txtPhoneNo_TextChanged);
            // 
            // dgvSale
            // 
            this.dgvSale.AllowUserToAddRows = false;
            this.dgvSale.AllowUserToDeleteRows = false;
            this.dgvSale.AllowUserToOrderColumns = true;
            this.dgvSale.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSale.Location = new System.Drawing.Point(52, 112);
            this.dgvSale.Name = "dgvSale";
            this.dgvSale.ReadOnly = true;
            this.dgvSale.Size = new System.Drawing.Size(715, 231);
            this.dgvSale.TabIndex = 13;
            this.dgvSale.Visible = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(529, 74);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(138, 20);
            this.txtSearch.TabIndex = 13;
            this.txtSearch.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(692, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(22, 366);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(44, 20);
            this.lblDate.TabIndex = 21;
            this.lblDate.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(180, 365);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(227, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // gbSale
            // 
            this.gbSale.Controls.Add(this.btnReset);
            this.gbSale.Controls.Add(this.lblDisplay);
            this.gbSale.Controls.Add(this.txtWarranty);
            this.gbSale.Controls.Add(this.lblWarranty);
            this.gbSale.Controls.Add(this.cboModels);
            this.gbSale.Controls.Add(this.dateTimePicker1);
            this.gbSale.Controls.Add(this.lblDate);
            this.gbSale.Controls.Add(this.txtPhoneNo);
            this.gbSale.Controls.Add(this.txtCusName);
            this.gbSale.Controls.Add(this.lblPhone);
            this.gbSale.Controls.Add(this.lblCus);
            this.gbSale.Controls.Add(this.txtPrice);
            this.gbSale.Controls.Add(this.lblPrice);
            this.gbSale.Controls.Add(this.lblModel);
            this.gbSale.Controls.Add(this.btnSubmitSales);
            this.gbSale.Controls.Add(this.txtSalesQuantity);
            this.gbSale.Controls.Add(this.txtSalesCode);
            this.gbSale.Controls.Add(this.lblQuantity);
            this.gbSale.Controls.Add(this.lblCode);
            this.gbSale.Location = new System.Drawing.Point(78, 112);
            this.gbSale.Name = "gbSale";
            this.gbSale.Size = new System.Drawing.Size(478, 424);
            this.gbSale.TabIndex = 23;
            this.gbSale.TabStop = false;
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Location = new System.Drawing.Point(413, 265);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(0, 13);
            this.lblDisplay.TabIndex = 24;
            // 
            // txtWarranty
            // 
            this.txtWarranty.Enabled = false;
            this.txtWarranty.Location = new System.Drawing.Point(180, 164);
            this.txtWarranty.Name = "txtWarranty";
            this.txtWarranty.Size = new System.Drawing.Size(227, 20);
            this.txtWarranty.TabIndex = 7;
            // 
            // lblWarranty
            // 
            this.lblWarranty.AutoSize = true;
            this.lblWarranty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarranty.Location = new System.Drawing.Point(23, 164);
            this.lblWarranty.Name = "lblWarranty";
            this.lblWarranty.Size = new System.Drawing.Size(94, 20);
            this.lblWarranty.TabIndex = 22;
            this.lblWarranty.Text = "Warranty(Y)";
            // 
            // cboModels
            // 
            this.cboModels.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboModels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModels.FormattingEnabled = true;
            this.cboModels.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboModels.Location = new System.Drawing.Point(180, 118);
            this.cboModels.Name = "cboModels";
            this.cboModels.Size = new System.Drawing.Size(227, 21);
            this.cboModels.Sorted = true;
            this.cboModels.TabIndex = 6;
            this.cboModels.SelectedIndexChanged += new System.EventHandler(this.cboModels_SelectedIndexChanged);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(310, 395);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 25;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // SalesUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ElectronicShop.PresentationLayer.Properties.Resources.bg_ecommerce;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(802, 557);
            this.Controls.Add(this.gbSale);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvSale);
            this.Controls.Add(this.panel1);
            this.Name = "SalesUI";
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.Sales_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSale)).EndInit();
            this.gbSale.ResumeLayout(false);
            this.gbSale.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtSalesCode;
        private System.Windows.Forms.TextBox txtSalesQuantity;
        private System.Windows.Forms.Button btnSubmitSales;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblCus;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtCusName;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.DataGridView dgvSale;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox gbSale;
        private System.Windows.Forms.ComboBox cboModels;
        private System.Windows.Forms.Label lblWarranty;
        private System.Windows.Forms.TextBox txtWarranty;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ToolTip ttView;
        private System.Windows.Forms.ToolTip ttAdd;
        private System.Windows.Forms.ToolTip ttBack;
        private System.Windows.Forms.Button btnReset;
    }
}