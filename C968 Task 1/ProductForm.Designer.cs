namespace C968_Task_1
{
    partial class ProductForm
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
            this.productTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.productID = new System.Windows.Forms.TextBox();
            this.productName = new System.Windows.Forms.TextBox();
            this.productInventory = new System.Windows.Forms.TextBox();
            this.productPrice = new System.Windows.Forms.TextBox();
            this.productMax = new System.Windows.Forms.TextBox();
            this.productMin = new System.Windows.Forms.TextBox();
            this.productButtonSearch = new System.Windows.Forms.Button();
            this.productSearchField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.partView = new System.Windows.Forms.ListView();
            this.productpartid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.productPartName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.productPartInventory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.productPartPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.productPartMin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.productPartMax = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.productButtonAdd = new System.Windows.Forms.Button();
            this.assocParts = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.productButtonDelete = new System.Windows.Forms.Button();
            this.productButtonCancel = new System.Windows.Forms.Button();
            this.productButtonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // productTitle
            // 
            this.productTitle.AutoSize = true;
            this.productTitle.Location = new System.Drawing.Point(13, 13);
            this.productTitle.Name = "productTitle";
            this.productTitle.Size = new System.Drawing.Size(66, 13);
            this.productTitle.TabIndex = 0;
            this.productTitle.Text = "Add Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Inventory";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Max";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(140, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Min";
            // 
            // productID
            // 
            this.productID.Location = new System.Drawing.Point(73, 92);
            this.productID.Name = "productID";
            this.productID.ReadOnly = true;
            this.productID.Size = new System.Drawing.Size(100, 20);
            this.productID.TabIndex = 7;
            // 
            // productName
            // 
            this.productName.Location = new System.Drawing.Point(73, 118);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(100, 20);
            this.productName.TabIndex = 8;
            this.productName.TextChanged += new System.EventHandler(this.TextChange);
            // 
            // productInventory
            // 
            this.productInventory.Location = new System.Drawing.Point(73, 144);
            this.productInventory.Name = "productInventory";
            this.productInventory.Size = new System.Drawing.Size(100, 20);
            this.productInventory.TabIndex = 9;
            this.productInventory.TextChanged += new System.EventHandler(this.TextChange);
            // 
            // productPrice
            // 
            this.productPrice.Location = new System.Drawing.Point(73, 170);
            this.productPrice.Name = "productPrice";
            this.productPrice.Size = new System.Drawing.Size(100, 20);
            this.productPrice.TabIndex = 10;
            this.productPrice.TextChanged += new System.EventHandler(this.TextChange);
            // 
            // productMax
            // 
            this.productMax.Location = new System.Drawing.Point(46, 196);
            this.productMax.Name = "productMax";
            this.productMax.Size = new System.Drawing.Size(44, 20);
            this.productMax.TabIndex = 11;
            this.productMax.TextChanged += new System.EventHandler(this.TextChange);
            // 
            // productMin
            // 
            this.productMin.Location = new System.Drawing.Point(170, 196);
            this.productMin.Name = "productMin";
            this.productMin.Size = new System.Drawing.Size(44, 20);
            this.productMin.TabIndex = 12;
            this.productMin.TextChanged += new System.EventHandler(this.TextChange);
            // 
            // productButtonSearch
            // 
            this.productButtonSearch.Location = new System.Drawing.Point(444, 53);
            this.productButtonSearch.Name = "productButtonSearch";
            this.productButtonSearch.Size = new System.Drawing.Size(75, 23);
            this.productButtonSearch.TabIndex = 13;
            this.productButtonSearch.Text = "Search";
            this.productButtonSearch.UseVisualStyleBackColor = true;
            this.productButtonSearch.Click += new System.EventHandler(this.ProductButtonSearch_Click);
            // 
            // productSearchField
            // 
            this.productSearchField.Location = new System.Drawing.Point(525, 53);
            this.productSearchField.Name = "productSearchField";
            this.productSearchField.Size = new System.Drawing.Size(237, 20);
            this.productSearchField.TabIndex = 14;
            this.productSearchField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox1_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "All candidate parts";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(217, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Parts Associated with this Product";
            // 
            // partView
            // 
            this.partView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.productpartid,
            this.productPartName,
            this.productPartInventory,
            this.productPartPrice,
            this.productPartMin,
            this.productPartMax});
            this.partView.FullRowSelect = true;
            this.partView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.partView.HideSelection = false;
            this.partView.Location = new System.Drawing.Point(220, 93);
            this.partView.MaximumSize = new System.Drawing.Size(540, 120);
            this.partView.MinimumSize = new System.Drawing.Size(540, 120);
            this.partView.MultiSelect = false;
            this.partView.Name = "partView";
            this.partView.Size = new System.Drawing.Size(540, 120);
            this.partView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.partView.TabIndex = 17;
            this.partView.UseCompatibleStateImageBehavior = false;
            this.partView.View = System.Windows.Forms.View.Details;
            this.partView.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.PartView_ColumnWidthChanging);
            // 
            // productpartid
            // 
            this.productpartid.Text = "Part ID";
            this.productpartid.Width = 90;
            // 
            // productPartName
            // 
            this.productPartName.Text = "Name";
            this.productPartName.Width = 145;
            // 
            // productPartInventory
            // 
            this.productPartInventory.Text = "Inventory";
            this.productPartInventory.Width = 70;
            // 
            // productPartPrice
            // 
            this.productPartPrice.Text = "Price";
            this.productPartPrice.Width = 90;
            // 
            // productPartMin
            // 
            this.productPartMin.Text = "Min";
            this.productPartMin.Width = 70;
            // 
            // productPartMax
            // 
            this.productPartMax.Text = "Max";
            this.productPartMax.Width = 70;
            // 
            // productButtonAdd
            // 
            this.productButtonAdd.Location = new System.Drawing.Point(687, 222);
            this.productButtonAdd.Name = "productButtonAdd";
            this.productButtonAdd.Size = new System.Drawing.Size(75, 23);
            this.productButtonAdd.TabIndex = 18;
            this.productButtonAdd.Text = "Add";
            this.productButtonAdd.UseVisualStyleBackColor = true;
            this.productButtonAdd.Click += new System.EventHandler(this.ProductButtonAdd_Click);
            // 
            // assocParts
            // 
            this.assocParts.AllowColumnReorder = true;
            this.assocParts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.assocParts.FullRowSelect = true;
            this.assocParts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.assocParts.HideSelection = false;
            this.assocParts.Location = new System.Drawing.Point(220, 258);
            this.assocParts.MaximumSize = new System.Drawing.Size(540, 120);
            this.assocParts.MinimumSize = new System.Drawing.Size(540, 120);
            this.assocParts.MultiSelect = false;
            this.assocParts.Name = "assocParts";
            this.assocParts.Size = new System.Drawing.Size(540, 120);
            this.assocParts.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.assocParts.TabIndex = 19;
            this.assocParts.UseCompatibleStateImageBehavior = false;
            this.assocParts.View = System.Windows.Forms.View.Details;
            this.assocParts.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.AssocParts_ColumnWidthChanging);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Part ID";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 145;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Inventory";
            this.columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Price";
            this.columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Min";
            this.columnHeader5.Width = 70;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Max";
            this.columnHeader6.Width = 70;
            // 
            // productButtonDelete
            // 
            this.productButtonDelete.Location = new System.Drawing.Point(687, 387);
            this.productButtonDelete.Name = "productButtonDelete";
            this.productButtonDelete.Size = new System.Drawing.Size(75, 23);
            this.productButtonDelete.TabIndex = 20;
            this.productButtonDelete.Text = "Delete";
            this.productButtonDelete.UseVisualStyleBackColor = true;
            this.productButtonDelete.Click += new System.EventHandler(this.ProductButtonDelete_Click);
            // 
            // productButtonCancel
            // 
            this.productButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.productButtonCancel.Location = new System.Drawing.Point(687, 416);
            this.productButtonCancel.Name = "productButtonCancel";
            this.productButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.productButtonCancel.TabIndex = 21;
            this.productButtonCancel.Text = "Cancel";
            this.productButtonCancel.UseVisualStyleBackColor = true;
            this.productButtonCancel.Click += new System.EventHandler(this.ProductButtonCancel_Click);
            // 
            // productButtonSave
            // 
            this.productButtonSave.Enabled = false;
            this.productButtonSave.Location = new System.Drawing.Point(606, 416);
            this.productButtonSave.Name = "productButtonSave";
            this.productButtonSave.Size = new System.Drawing.Size(75, 23);
            this.productButtonSave.TabIndex = 22;
            this.productButtonSave.Text = "Save";
            this.productButtonSave.UseVisualStyleBackColor = true;
            this.productButtonSave.Click += new System.EventHandler(this.ProductButtonSave_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.productButtonCancel;
            this.ClientSize = new System.Drawing.Size(784, 451);
            this.Controls.Add(this.productButtonSave);
            this.Controls.Add(this.productButtonCancel);
            this.Controls.Add(this.productButtonDelete);
            this.Controls.Add(this.assocParts);
            this.Controls.Add(this.productButtonAdd);
            this.Controls.Add(this.partView);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productSearchField);
            this.Controls.Add(this.productButtonSearch);
            this.Controls.Add(this.productMin);
            this.Controls.Add(this.productMax);
            this.Controls.Add(this.productPrice);
            this.Controls.Add(this.productInventory);
            this.Controls.Add(this.productName);
            this.Controls.Add(this.productID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productTitle);
            this.MaximumSize = new System.Drawing.Size(800, 490);
            this.MinimumSize = new System.Drawing.Size(800, 490);
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label productTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox productID;
        private System.Windows.Forms.TextBox productName;
        private System.Windows.Forms.TextBox productInventory;
        private System.Windows.Forms.TextBox productPrice;
        private System.Windows.Forms.TextBox productMax;
        private System.Windows.Forms.TextBox productMin;
        private System.Windows.Forms.Button productButtonSearch;
        private System.Windows.Forms.TextBox productSearchField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView partView;
        private System.Windows.Forms.ColumnHeader productpartid;
        private System.Windows.Forms.ColumnHeader productPartName;
        private System.Windows.Forms.ColumnHeader productPartInventory;
        private System.Windows.Forms.ColumnHeader productPartPrice;
        private System.Windows.Forms.ColumnHeader productPartMin;
        private System.Windows.Forms.ColumnHeader productPartMax;
        private System.Windows.Forms.Button productButtonAdd;
        private System.Windows.Forms.ListView assocParts;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button productButtonDelete;
        private System.Windows.Forms.Button productButtonCancel;
        private System.Windows.Forms.Button productButtonSave;
    }
}