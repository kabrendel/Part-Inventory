using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace C968_Task_1
{
    public partial class ProductForm : Form
    {
        //  object reference for Form1
        readonly Main main = null;
        //  Constructor
        public ProductForm(Main main)
        {
            InitializeComponent();
            this.main = main;
            this.Location = main.Location;
        }
        public void SetAdd(Color color, BindingList<Part> parts, int index)
        {
            //  Change color of entry fields when using form to "Add" parts.
            productID.Text = index.ToString();
            productName.BackColor = color;
            productInventory.BackColor = color;
            productPrice.BackColor = color;
            productMax.BackColor = color;
            productMin.BackColor = color;
            productButtonSave.Enabled = false;
            UpdatePartView(parts);
        }
        public void SetModify(string[] strings, BindingList<Part> parts, BindingList<Part> prods)
        {
            productID.Text = strings[0];
            productName.Text = strings[1];
            productInventory.Text = strings[2];
            productPrice.Text = strings[3];
            productMax.Text = strings[4];
            productMin.Text = strings[5];
            productTitle.Text = "Modify Product";
            productButtonSave.Enabled = true;
            UpdatePartView(parts);
            UpdateAssociatedView(prods);
        }
        private void ProductButtonCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void UpdatePartView(BindingList<Part> temp)
        {
            ListViewItem item;
            //  clear items.
            partView.Items.Clear();
            //  Iterate through BindingList and populate data in partView.            
            for (int i = 0; i < temp.Count; i++)
            {
                item = new ListViewItem((temp[i].PartID).ToString());
                item.SubItems.Add(temp[i].Name);
                item.SubItems.Add((temp[i].InStock).ToString());
                item.SubItems.Add((temp[i].Price).ToString());
                item.SubItems.Add((temp[i].Min).ToString());
                item.SubItems.Add((temp[i].Max).ToString());
                partView.Items.Add(item);
            }
        }
        public void UpdateAssociatedView(BindingList<Part> temp)
        {
            ListViewItem item;
            //  clear items.
            assocParts.Items.Clear();
            //  Iterate through BindingList and populate data in partView.            
            for (int i = 0; i < temp.Count; i++)
            {
                item = new ListViewItem((temp[i].PartID).ToString());
                item.SubItems.Add(temp[i].Name);
                item.SubItems.Add((temp[i].InStock).ToString());
                item.SubItems.Add((temp[i].Price).ToString());
                item.SubItems.Add((temp[i].Min).ToString());
                item.SubItems.Add((temp[i].Max).ToString());
                assocParts.Items.Add(item);
            }
        }
        private void ProductButtonAdd_Click(object sender, EventArgs e)
        {
            if (partView.SelectedIndices.Count <= 0)
            {
                //  Nothing selected in partView, do not add items.
                MessageBox.Show("Must select an item to add.", "Product Form");
                return;
            }
            int index = partView.SelectedIndices[0];
            bool exists = false;
            for (int i = 0; i < assocParts.Items.Count; i++)
            {
                if (int.Parse(assocParts.Items[i].SubItems[0].Text) == int.Parse(partView.Items[index].SubItems[0].Text))
                {
                    exists = true;
                    MessageBox.Show("Part is already associated with this product.", "Product Form");
                    break;
                }
            }
            if (!exists)
            {
                ListViewItem item;
                //  Add selected partView part to assocParts ListView.
                item = new ListViewItem(partView.Items[index].SubItems[0].Text);
                item.SubItems.Add(partView.Items[index].SubItems[1].Text);
                item.SubItems.Add(partView.Items[index].SubItems[2].Text);
                item.SubItems.Add(partView.Items[index].SubItems[3].Text);
                item.SubItems.Add(partView.Items[index].SubItems[4].Text);
                item.SubItems.Add(partView.Items[index].SubItems[5].Text);
                assocParts.Items.Add(item);
            }
        }
        private void ProductButtonDelete_Click(object sender, EventArgs e)
        {
            //  Delete Part from assocPart listview.
            if (assocParts.SelectedIndices.Count <= 0)
            {
                //  Nothing selected in assocParts listview, do not delete any items.
                MessageBox.Show("Must select a part to delete.", "Product Form");
                return;
            }
            var confirmDelete = MessageBox.Show("Are you sure you want to delete this association?", "Product Form", MessageBoxButtons.OKCancel);
            if (confirmDelete == DialogResult.OK)
            {                
                int index = assocParts.SelectedIndices[0];
                assocParts.Items.RemoveAt(index);
            }
            else
            {
                return;
            }
        }
        private void ProductButtonSave_Click(object sender, EventArgs e)
        {
            //  Save needs to save the changes to the product and the associated part list.
            int prodID = int.Parse(productID.Text);

            // data checking data in textbox fields.
            if (int.TryParse(productName.Text, out _))
            {
                //  Text can be converted to a number.
                //  Disable save and return.
                productName.BackColor = Color.IndianRed;
                productButtonSave.Enabled = false;
                MessageBox.Show("Name does not appear to be the correct format.", "Product Form");
                return;
            }
            else if (!(int.TryParse(productInventory.Text, out _)) || !(int.TryParse(productMax.Text, out _)) || !(int.TryParse(productMin.Text, out _)))
            {
                productButtonSave.Enabled = false;
                MessageBox.Show("Inventory does not match range.", "Product Form");
                return;
            }
            else if (!decimal.TryParse(productPrice.Text, out _))
            {
                //  Cost does not parse as a decimal.
                productPrice.BackColor = Color.IndianRed;
                productButtonSave.Enabled = false;
                MessageBox.Show("Price is not the correct format.", "Product Form");
                return;
            }
            //  productMin should be lower than product.Max
            if (int.Parse(productMin.Text) > int.Parse(productMax.Text))
            {

                productMin.BackColor = Color.IndianRed;
                productButtonSave.Enabled = false;
                MessageBox.Show("Minimum quantity must be lower than maximum quantity.", "Product Form");
                return;
            }
            //  productInventory should be between partMax and partMin.
            if ((int.Parse(productInventory.Text) < int.Parse(productMin.Text)) || (int.Parse(productInventory.Text) > int.Parse(productMax.Text)))
            {
                productInventory.BackColor = Color.IndianRed;
                productButtonSave.Enabled = false;
                MessageBox.Show("Inventory out of range.", "Product Form");
                return;
            }
            //  Product should have associated parts:
            if (assocParts.Items.Count == 0)
            {
                MessageBox.Show("Must associate at least one part with the product.", "Product Form");
                return;
            }
            //  string array to pass to Main.SaveProduct(string)
            string[] strings = new string[]
            {
                productID.Text,
                productName.Text,
                productInventory.Text,
                productPrice.Text,
                productMax.Text,
                productMin.Text
            };
            //  Pass string[] to SaveProduct.
            main.SaveProduct(strings);
            //
            //  Clear out existing Associated Parts and then update to match assocProd listview.
            int partID;
            main.ProductRemoveAssociated(prodID);
            for (int i = 0; i < assocParts.Items.Count; i++)
            {
                partID = int.Parse(assocParts.Items[i].SubItems[0].Text);
                main.ProductAddAssociated(prodID, partID);
            }
            //
            //  Close ProductForm and update Form1 ProductView
            this.Dispose();
            main.UpdateProductView();
            //
        }
        private void TextChange(object sender, EventArgs e)
        {
            //  Change background if textbox empty.
            //  Change background if doesn't match expected data type.
            bool save = true;
            if (((TextBox)sender).TextLength == 0)
            {
                //  Textbox length is zero so we color the BackColor IndianRed.
                ((TextBox)sender).BackColor = Color.IndianRed;
                save = false;
            }
            else
            {
                //  Textbox length is not zero.
                //  Check data in textbox.
                if (((TextBox)sender).Name == "productName")
                {
                    //  producttName should be a string.
                    //  If string can be parsed to an int, it's not a string.
                    if (int.TryParse(((TextBox)sender).Text, out _))
                    {
                        //  text can be converted to a number
                        ((TextBox)sender).BackColor = Color.IndianRed;
                        save = false;
                    }
                    else
                    {
                        ((TextBox)sender).BackColor = Color.White;
                    }
                }
                else if ((((TextBox)sender).Name == "productInventory") || (((TextBox)sender).Name == "productMax") || (((TextBox)sender).Name == "productMin"))
                {
                    //  The above fields should be numeric.
                    if (int.TryParse(((TextBox)sender).Text, out _))
                    {
                        //  text can be converted to a number
                        ((TextBox)sender).BackColor = Color.White;
                    }
                    else
                    {
                        ((TextBox)sender).BackColor = Color.IndianRed;
                        save = false;
                    }
                }
                else if (((TextBox)sender).Name == "productPrice")
                {
                    //  productCost expected to be of the decimal data format.
                    if (decimal.TryParse(((TextBox)sender).Text, out _))
                    {
                        //  text can be converted to decimal.
                        ((TextBox)sender).BackColor = Color.White;
                    }
                    else
                    {
                        ((TextBox)sender).BackColor = Color.IndianRed;
                        save = false;
                    }
                }
                else
                {
                    //  Kind of a catch all since all TextBox fields should be caught above.
                    ((TextBox)sender).BackColor = Color.White;
                }
            }
            if (save)
            {
                productButtonSave.Enabled = true;
            }
            else
            {
                productButtonSave.Enabled = false;
            }
        }
        private void ProductButtonSearch_Click(object sender, EventArgs e)
        {
            //  Search partView listview object to match text from search field
            //  partView is our listview
            //  productSearchField is our textbox
            if (productSearchField.Text.Length == 0)
            {
                //
                MessageBox.Show("Enter text for search.", "Product Form");
                return;
            }
            else
            {
                for (int i = 0; i < partView.Items.Count; i++)
                {
                    if (partView.Items[i].SubItems[1].Text.Contains(productSearchField.Text))
                    {
                        //  Found search text in part name fields.
                        partView.Items[i].Selected = true;
                        partView.Focus();
                        return;
                    }
                    else
                    {
                        //  No match.                    
                    }
                }
            }
        }
        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ProductButtonSearch_Click(sender, e);
            }
        }
        private void PartView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            //  Prevent listview column width changes.
            e.NewWidth = partView.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }
        private void AssocParts_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            //  Prevent listview column width changes.
            e.NewWidth = assocParts.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }
        //  End of class
    }
}