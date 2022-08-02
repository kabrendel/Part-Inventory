namespace C968_Task_1
{
    partial class PartForm
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.partRadioIn = new System.Windows.Forms.RadioButton();
            this.partRadioOut = new System.Windows.Forms.RadioButton();
            this.labelID = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelInventory = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.labelMin = new System.Windows.Forms.Label();
            this.labelMachine = new System.Windows.Forms.Label();
            this.partID = new System.Windows.Forms.TextBox();
            this.partInventory = new System.Windows.Forms.TextBox();
            this.partName = new System.Windows.Forms.TextBox();
            this.partCost = new System.Windows.Forms.TextBox();
            this.partMax = new System.Windows.Forms.TextBox();
            this.partMin = new System.Windows.Forms.TextBox();
            this.partMachine = new System.Windows.Forms.TextBox();
            this.partButtonSave = new System.Windows.Forms.Button();
            this.partButtonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(13, 13);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(48, 13);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Add Part";
            // 
            // partRadioIn
            // 
            this.partRadioIn.AutoSize = true;
            this.partRadioIn.Location = new System.Drawing.Point(86, 12);
            this.partRadioIn.Name = "partRadioIn";
            this.partRadioIn.Size = new System.Drawing.Size(66, 17);
            this.partRadioIn.TabIndex = 1;
            this.partRadioIn.TabStop = true;
            this.partRadioIn.Text = "In-house";
            this.partRadioIn.UseVisualStyleBackColor = true;
            this.partRadioIn.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // partRadioOut
            // 
            this.partRadioOut.AutoSize = true;
            this.partRadioOut.Location = new System.Drawing.Point(177, 13);
            this.partRadioOut.Name = "partRadioOut";
            this.partRadioOut.Size = new System.Drawing.Size(80, 17);
            this.partRadioOut.TabIndex = 2;
            this.partRadioOut.TabStop = true;
            this.partRadioOut.Text = "Outsourced";
            this.partRadioOut.UseVisualStyleBackColor = true;
            this.partRadioOut.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(44, 43);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(18, 13);
            this.labelID.TabIndex = 3;
            this.labelID.Text = "ID";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(44, 75);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Name";
            // 
            // labelInventory
            // 
            this.labelInventory.AutoSize = true;
            this.labelInventory.Location = new System.Drawing.Point(44, 111);
            this.labelInventory.Name = "labelInventory";
            this.labelInventory.Size = new System.Drawing.Size(51, 13);
            this.labelInventory.TabIndex = 5;
            this.labelInventory.Text = "Inventory";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(44, 139);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(57, 13);
            this.labelPrice.TabIndex = 6;
            this.labelPrice.Text = "Price/Cost";
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Location = new System.Drawing.Point(94, 162);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(27, 13);
            this.labelMax.TabIndex = 7;
            this.labelMax.Text = "Max";
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Location = new System.Drawing.Point(193, 162);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(24, 13);
            this.labelMin.TabIndex = 8;
            this.labelMin.Text = "Min";
            // 
            // labelMachine
            // 
            this.labelMachine.AutoSize = true;
            this.labelMachine.Location = new System.Drawing.Point(44, 191);
            this.labelMachine.Name = "labelMachine";
            this.labelMachine.Size = new System.Drawing.Size(62, 13);
            this.labelMachine.TabIndex = 9;
            this.labelMachine.Text = "Machine ID";
            // 
            // partID
            // 
            this.partID.Location = new System.Drawing.Point(127, 43);
            this.partID.Name = "partID";
            this.partID.ReadOnly = true;
            this.partID.Size = new System.Drawing.Size(110, 20);
            this.partID.TabIndex = 10;
            // 
            // partInventory
            // 
            this.partInventory.Location = new System.Drawing.Point(127, 111);
            this.partInventory.Name = "partInventory";
            this.partInventory.Size = new System.Drawing.Size(110, 20);
            this.partInventory.TabIndex = 12;
            this.partInventory.TextChanged += new System.EventHandler(this.TextChange);
            // 
            // partName
            // 
            this.partName.BackColor = System.Drawing.SystemColors.Window;
            this.partName.Location = new System.Drawing.Point(127, 75);
            this.partName.Name = "partName";
            this.partName.Size = new System.Drawing.Size(110, 20);
            this.partName.TabIndex = 11;
            this.partName.TextChanged += new System.EventHandler(this.TextChange);
            // 
            // partCost
            // 
            this.partCost.Location = new System.Drawing.Point(127, 139);
            this.partCost.Name = "partCost";
            this.partCost.Size = new System.Drawing.Size(110, 20);
            this.partCost.TabIndex = 13;
            this.partCost.TextChanged += new System.EventHandler(this.TextChange);
            // 
            // partMax
            // 
            this.partMax.Location = new System.Drawing.Point(127, 165);
            this.partMax.Name = "partMax";
            this.partMax.Size = new System.Drawing.Size(60, 20);
            this.partMax.TabIndex = 14;
            this.partMax.TextChanged += new System.EventHandler(this.TextChange);
            // 
            // partMin
            // 
            this.partMin.Location = new System.Drawing.Point(223, 165);
            this.partMin.Name = "partMin";
            this.partMin.Size = new System.Drawing.Size(60, 20);
            this.partMin.TabIndex = 15;
            this.partMin.TextChanged += new System.EventHandler(this.TextChange);
            // 
            // partMachine
            // 
            this.partMachine.Location = new System.Drawing.Point(127, 191);
            this.partMachine.Name = "partMachine";
            this.partMachine.Size = new System.Drawing.Size(110, 20);
            this.partMachine.TabIndex = 16;
            this.partMachine.TextChanged += new System.EventHandler(this.TextChange);
            // 
            // partButtonSave
            // 
            this.partButtonSave.Location = new System.Drawing.Point(160, 239);
            this.partButtonSave.Name = "partButtonSave";
            this.partButtonSave.Size = new System.Drawing.Size(57, 22);
            this.partButtonSave.TabIndex = 17;
            this.partButtonSave.Text = "Save";
            this.partButtonSave.UseVisualStyleBackColor = true;
            this.partButtonSave.Click += new System.EventHandler(this.ButtonPartSave);
            // 
            // partButtonCancel
            // 
            this.partButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.partButtonCancel.Location = new System.Drawing.Point(226, 239);
            this.partButtonCancel.Name = "partButtonCancel";
            this.partButtonCancel.Size = new System.Drawing.Size(57, 22);
            this.partButtonCancel.TabIndex = 18;
            this.partButtonCancel.Text = "Cancel";
            this.partButtonCancel.UseVisualStyleBackColor = true;
            this.partButtonCancel.Click += new System.EventHandler(this.ButtonPartCancel);
            // 
            // PartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.partButtonCancel;
            this.ClientSize = new System.Drawing.Size(296, 275);
            this.Controls.Add(this.partButtonCancel);
            this.Controls.Add(this.partButtonSave);
            this.Controls.Add(this.partMachine);
            this.Controls.Add(this.partMin);
            this.Controls.Add(this.partMax);
            this.Controls.Add(this.partCost);
            this.Controls.Add(this.partName);
            this.Controls.Add(this.partInventory);
            this.Controls.Add(this.partID);
            this.Controls.Add(this.labelMachine);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelInventory);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.partRadioOut);
            this.Controls.Add(this.partRadioIn);
            this.Controls.Add(this.labelTitle);
            this.MaximumSize = new System.Drawing.Size(312, 314);
            this.MinimumSize = new System.Drawing.Size(312, 314);
            this.Name = "PartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.RadioButton partRadioIn;
        private System.Windows.Forms.RadioButton partRadioOut;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelInventory;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label labelMachine;
        private System.Windows.Forms.TextBox partID;
        private System.Windows.Forms.TextBox partInventory;
        private System.Windows.Forms.TextBox partName;
        private System.Windows.Forms.TextBox partCost;
        private System.Windows.Forms.TextBox partMax;
        private System.Windows.Forms.TextBox partMin;
        private System.Windows.Forms.TextBox partMachine;
        private System.Windows.Forms.Button partButtonSave;
        private System.Windows.Forms.Button partButtonCancel;
    }
}