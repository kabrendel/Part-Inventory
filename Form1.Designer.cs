namespace C968_Task_1
{
    partial class Main
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
            this.productSearchBox = new System.Windows.Forms.TextBox();
            this.mainExit = new System.Windows.Forms.Button();
            this.productSearch = new System.Windows.Forms.Button();
            this.partAdd = new System.Windows.Forms.Button();
            this.partModify = new System.Windows.Forms.Button();
            this.partDelete = new System.Windows.Forms.Button();
            this.partView = new System.Windows.Forms.ListView();
            this.partID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.partName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.partInventory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.partPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.partMin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.partMax = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.partSearchBox = new System.Windows.Forms.TextBox();
            this.mainParts = new System.Windows.Forms.Label();
            this.mainProducts = new System.Windows.Forms.Label();
            this.productView = new System.Windows.Forms.ListView();
            this.productID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.productName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.productInventory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.productPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.productMin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.productMax = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.productDelete = new System.Windows.Forms.Button();
            this.productModify = new System.Windows.Forms.Button();
            this.productAdd = new System.Windows.Forms.Button();
            this.partSearch = new System.Windows.Forms.Button();
            this.mainTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // productSearchBox
            // 
            this.productSearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.productSearchBox.HideSelection = false;
            this.productSearchBox.Location = new System.Drawing.Point(588, 44);
            this.productSearchBox.Name = "productSearchBox";
            this.productSearchBox.Size = new System.Drawing.Size(236, 20);
            this.productSearchBox.TabIndex = 0;
            this.productSearchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox2_KeyDown);
            // 
            // mainExit
            // 
            this.mainExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mainExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.mainExit.Location = new System.Drawing.Point(748, 326);
            this.mainExit.Name = "mainExit";
            this.mainExit.Size = new System.Drawing.Size(75, 23);
            this.mainExit.TabIndex = 1;
            this.mainExit.Text = "Exit";
            this.mainExit.UseVisualStyleBackColor = true;
            this.mainExit.Click += new System.EventHandler(this.MainExit_Click);
            // 
            // productSearch
            // 
            this.productSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.productSearch.Location = new System.Drawing.Point(525, 44);
            this.productSearch.Name = "productSearch";
            this.productSearch.Size = new System.Drawing.Size(57, 22);
            this.productSearch.TabIndex = 2;
            this.productSearch.Text = "Search";
            this.productSearch.UseVisualStyleBackColor = true;
            this.productSearch.Click += new System.EventHandler(this.ProductSearch_Click);
            // 
            // partAdd
            // 
            this.partAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.partAdd.Location = new System.Drawing.Point(148, 285);
            this.partAdd.Name = "partAdd";
            this.partAdd.Size = new System.Drawing.Size(75, 23);
            this.partAdd.TabIndex = 3;
            this.partAdd.Text = "Add";
            this.partAdd.UseVisualStyleBackColor = true;
            this.partAdd.Click += new System.EventHandler(this.PartAdd_click);
            // 
            // partModify
            // 
            this.partModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.partModify.Location = new System.Drawing.Point(234, 285);
            this.partModify.Name = "partModify";
            this.partModify.Size = new System.Drawing.Size(75, 23);
            this.partModify.TabIndex = 4;
            this.partModify.Text = "Modify";
            this.partModify.UseVisualStyleBackColor = true;
            this.partModify.Click += new System.EventHandler(this.PartModify_Click);
            // 
            // partDelete
            // 
            this.partDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.partDelete.Location = new System.Drawing.Point(315, 285);
            this.partDelete.Name = "partDelete";
            this.partDelete.Size = new System.Drawing.Size(75, 23);
            this.partDelete.TabIndex = 5;
            this.partDelete.Text = "Delete";
            this.partDelete.UseVisualStyleBackColor = true;
            this.partDelete.Click += new System.EventHandler(this.PartDelete_Click);
            // 
            // partView
            // 
            this.partView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.partView.BackColor = System.Drawing.SystemColors.Window;
            this.partView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.partID,
            this.partName,
            this.partInventory,
            this.partPrice,
            this.partMin,
            this.partMax});
            this.partView.FullRowSelect = true;
            this.partView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.partView.HideSelection = false;
            this.partView.Location = new System.Drawing.Point(12, 70);
            this.partView.MaximumSize = new System.Drawing.Size(380, 210);
            this.partView.MinimumSize = new System.Drawing.Size(380, 210);
            this.partView.MultiSelect = false;
            this.partView.Name = "partView";
            this.partView.Size = new System.Drawing.Size(380, 210);
            this.partView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.partView.TabIndex = 6;
            this.partView.UseCompatibleStateImageBehavior = false;
            this.partView.View = System.Windows.Forms.View.Details;
            this.partView.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.PartView_ColumnWidthChanging);
            // 
            // partID
            // 
            this.partID.Text = "Part ID";
            // 
            // partName
            // 
            this.partName.Text = "Name";
            this.partName.Width = 80;
            // 
            // partInventory
            // 
            this.partInventory.Text = "Inventory";
            // 
            // partPrice
            // 
            this.partPrice.Text = "Price";
            // 
            // partMin
            // 
            this.partMin.Text = "Min";
            this.partMin.Width = 58;
            // 
            // partMax
            // 
            this.partMax.Text = "Max";
            this.partMax.Width = 58;
            // 
            // partSearchBox
            // 
            this.partSearchBox.HideSelection = false;
            this.partSearchBox.Location = new System.Drawing.Point(154, 44);
            this.partSearchBox.Name = "partSearchBox";
            this.partSearchBox.Size = new System.Drawing.Size(236, 20);
            this.partSearchBox.TabIndex = 7;
            this.partSearchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox1_KeyDown);
            // 
            // mainParts
            // 
            this.mainParts.AutoSize = true;
            this.mainParts.Location = new System.Drawing.Point(12, 41);
            this.mainParts.Name = "mainParts";
            this.mainParts.Size = new System.Drawing.Size(31, 13);
            this.mainParts.TabIndex = 8;
            this.mainParts.Text = "Parts";
            // 
            // mainProducts
            // 
            this.mainProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mainProducts.AutoSize = true;
            this.mainProducts.Location = new System.Drawing.Point(407, 41);
            this.mainProducts.Name = "mainProducts";
            this.mainProducts.Size = new System.Drawing.Size(49, 13);
            this.mainProducts.TabIndex = 9;
            this.mainProducts.Text = "Products";
            // 
            // productView
            // 
            this.productView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.productID,
            this.productName,
            this.productInventory,
            this.productPrice,
            this.productMin,
            this.productMax});
            this.productView.FullRowSelect = true;
            this.productView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.productView.HideSelection = false;
            this.productView.Location = new System.Drawing.Point(410, 70);
            this.productView.MaximumSize = new System.Drawing.Size(415, 210);
            this.productView.MinimumSize = new System.Drawing.Size(415, 210);
            this.productView.MultiSelect = false;
            this.productView.Name = "productView";
            this.productView.Size = new System.Drawing.Size(415, 210);
            this.productView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.productView.TabIndex = 10;
            this.productView.UseCompatibleStateImageBehavior = false;
            this.productView.View = System.Windows.Forms.View.Details;
            this.productView.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.ProductView_ColumnWidthChanging);
            // 
            // productID
            // 
            this.productID.Text = "Product ID";
            this.productID.Width = 70;
            // 
            // productName
            // 
            this.productName.Text = "Name";
            this.productName.Width = 91;
            // 
            // productInventory
            // 
            this.productInventory.Text = "Inventory";
            // 
            // productPrice
            // 
            this.productPrice.Text = "Price";
            this.productPrice.Width = 70;
            // 
            // productMin
            // 
            this.productMin.Text = "Min";
            // 
            // productMax
            // 
            this.productMax.Text = "Max";
            // 
            // productDelete
            // 
            this.productDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.productDelete.Location = new System.Drawing.Point(749, 285);
            this.productDelete.Name = "productDelete";
            this.productDelete.Size = new System.Drawing.Size(75, 23);
            this.productDelete.TabIndex = 13;
            this.productDelete.Text = "Delete";
            this.productDelete.UseVisualStyleBackColor = true;
            this.productDelete.Click += new System.EventHandler(this.ProductDelete_Click);
            // 
            // productModify
            // 
            this.productModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.productModify.Location = new System.Drawing.Point(668, 285);
            this.productModify.Name = "productModify";
            this.productModify.Size = new System.Drawing.Size(75, 23);
            this.productModify.TabIndex = 12;
            this.productModify.Text = "Modify";
            this.productModify.UseVisualStyleBackColor = true;
            this.productModify.Click += new System.EventHandler(this.ProductModify_Click);
            // 
            // productAdd
            // 
            this.productAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.productAdd.Location = new System.Drawing.Point(587, 285);
            this.productAdd.Name = "productAdd";
            this.productAdd.Size = new System.Drawing.Size(75, 23);
            this.productAdd.TabIndex = 11;
            this.productAdd.Text = "Add";
            this.productAdd.UseVisualStyleBackColor = true;
            this.productAdd.Click += new System.EventHandler(this.ProductAdd_Click);
            // 
            // partSearch
            // 
            this.partSearch.Location = new System.Drawing.Point(91, 42);
            this.partSearch.Name = "partSearch";
            this.partSearch.Size = new System.Drawing.Size(57, 22);
            this.partSearch.TabIndex = 14;
            this.partSearch.Text = "Search";
            this.partSearch.UseVisualStyleBackColor = true;
            this.partSearch.Click += new System.EventHandler(this.PartSearch_Click);
            // 
            // mainTitle
            // 
            this.mainTitle.AutoSize = true;
            this.mainTitle.Location = new System.Drawing.Point(12, 9);
            this.mainTitle.Name = "mainTitle";
            this.mainTitle.Size = new System.Drawing.Size(153, 13);
            this.mainTitle.TabIndex = 15;
            this.mainTitle.Text = "Inventory Management System";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 361);
            this.Controls.Add(this.mainTitle);
            this.Controls.Add(this.partSearch);
            this.Controls.Add(this.productDelete);
            this.Controls.Add(this.productModify);
            this.Controls.Add(this.productAdd);
            this.Controls.Add(this.productView);
            this.Controls.Add(this.mainProducts);
            this.Controls.Add(this.mainParts);
            this.Controls.Add(this.partSearchBox);
            this.Controls.Add(this.partView);
            this.Controls.Add(this.partDelete);
            this.Controls.Add(this.partModify);
            this.Controls.Add(this.partAdd);
            this.Controls.Add(this.productSearch);
            this.Controls.Add(this.mainExit);
            this.Controls.Add(this.productSearchBox);
            this.MaximumSize = new System.Drawing.Size(850, 400);
            this.MinimumSize = new System.Drawing.Size(850, 400);
            this.Name = "Main";
            this.Text = "C968 Inventory Screen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox productSearchBox;
        private System.Windows.Forms.Button mainExit;
        private System.Windows.Forms.Button productSearch;
        private System.Windows.Forms.Button partAdd;
        private System.Windows.Forms.Button partModify;
        private System.Windows.Forms.Button partDelete;
        private System.Windows.Forms.ListView partView;
        private System.Windows.Forms.ColumnHeader partID;
        private System.Windows.Forms.ColumnHeader partName;
        private System.Windows.Forms.TextBox partSearchBox;
        private System.Windows.Forms.Label mainParts;
        private System.Windows.Forms.Label mainProducts;
        private System.Windows.Forms.ColumnHeader partInventory;
        private System.Windows.Forms.ColumnHeader partPrice;
        private System.Windows.Forms.ColumnHeader partMin;
        private System.Windows.Forms.ColumnHeader partMax;
        private System.Windows.Forms.ListView productView;
        private System.Windows.Forms.ColumnHeader productID;
        private System.Windows.Forms.ColumnHeader productName;
        private System.Windows.Forms.ColumnHeader productInventory;
        private System.Windows.Forms.ColumnHeader productPrice;
        private System.Windows.Forms.ColumnHeader productMin;
        private System.Windows.Forms.ColumnHeader productMax;
        private System.Windows.Forms.Button productDelete;
        private System.Windows.Forms.Button productModify;
        private System.Windows.Forms.Button productAdd;
        private System.Windows.Forms.Button partSearch;
        private System.Windows.Forms.Label mainTitle;
    }
}

