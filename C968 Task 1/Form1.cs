using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace C968_Task_1
{
    public partial class Main : Form
    {
        PartForm addPart;           //  object for Partform from "Add" button.
        PartForm modifyPart;        //  object for Partform from "Modify" button.
        ProductForm addProduct;     //  object for Productform from "Add" button.
        ProductForm modifyProduct;  //  object for Productform from "Modify" button.
        readonly Inventory inventory = new Inventory();              //  Create Inventory object.

        public Main()
        {
            inventory.AllParts = new BindingList<Part>();       //  Instantiate AllParts as a BindingList<Part> through Inventory object.
            inventory.Products = new BindingList<Product>();    //  Instantiate Products as a BindingList<Products> through Inventory object.
            //  Create some objects to represent initial data in Products.
            Product red = new Product
            {
                ProductID = 0,
                Name = "Red Bicycle",
                Price = 11.44m,
                InStock = 15,
                Min = 1,
                Max = 25
            };
            Product yellow = new Product
            {
                ProductID = 1,
                Name = "Yellow Bicycle",
                Price = 9.66m,
                InStock = 19,
                Min = 1,
                Max = 20
            };
            Product blue = new Product
            {
                ProductID = 2,
                Name = "Blue Bicycle",
                Price = 12.77m,
                InStock = 5,
                Min = 1,
                Max = 25
            };
            //  Create some objects to represent initial parts. in AllParts.
            //
            Outsourced wheel = new Outsourced
            {
                PartID = 0,
                Name = "Wheel",
                Price = 12.11m,
                InStock = 15,
                Min = 5,
                Max = 25,
                CompanyName = "Bontrager"
            };
            Inhouse pedal = new Inhouse
            {
                PartID = 1,
                Name = "Pedal",
                Price = 8.22m,
                InStock = 11,
                Min = 5,
                Max = 25,
                MachineID = 110,
            };
            Inhouse chain = new Inhouse
            {
                PartID = 2,
                Name = "Chain",
                Price = 8.33m,
                InStock = 12,
                Min = 5,
                Max = 25,
                MachineID = 563,
            };
            Outsourced seat = new Outsourced
            {
                PartID = 3,
                Name = "Seat",
                Price = 4.55m,
                InStock = 8,
                Min = 2,
                Max = 25,
                CompanyName = "Schwinn"
            };
            //  Add objects to Allparts and Products BindingLists.
            inventory.AddPart(wheel);       //  Add inventory object to AllParts.
            inventory.AddPart(pedal);       //  Add inventory object to AllParts.
            inventory.AddPart(seat);        //  Add inventory object to AllParts.
            inventory.AddPart(chain);       //  Add inventory object to AllParts.
            inventory.AddProduct(red);      //  Add Product object to Products.
            inventory.AddProduct(yellow);   //  Add Product object to Products.
            inventory.AddProduct(blue);     //  Add Product object to Products.
            //
            //  Add initial Associated Parts for our Products.
            red.AssociatedParts = new BindingList<Part>();
            red.AddAssociatedPart(wheel);
            red.AddAssociatedPart(pedal);
            red.AddAssociatedPart(seat);
            red.AddAssociatedPart(chain);
            blue.AssociatedParts = new BindingList<Part>();
            blue.AddAssociatedPart(wheel);
            blue.AddAssociatedPart(seat);
            blue.AddAssociatedPart(chain);
            yellow.AssociatedParts = new BindingList<Part>();
            yellow.AddAssociatedPart(wheel);
            yellow.AddAssociatedPart(pedal);
            yellow.AddAssociatedPart(seat);
            //
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.UpdatePartView();
            this.UpdateProductView();
        }
        private void PartAdd_click(object sender, EventArgs e)
        {
            //  Part Add Button.
            if (addPart == null || addPart.IsDisposed)
            {
                addPart = new PartForm(this);
                addPart.SetAdd(Color.IndianRed,inventory.PartIndex);
                addPart.Show();
            }
            else
            {
                addPart.BringToFront();
            }
        }
        private void PartModify_Click(object sender, EventArgs e)
        {
            //  Part Modify Button.
            if (partView.SelectedIndices.Count <= 0)
            {
                //  Nothing selected in partView, don't open PartForm.
                MessageBox.Show("Must select a part to modify.", "Inventory Management System");
                return;
            }
            //  partView.SelectedIndices[0] is the index of the selection in our listview.
            //  get the text from the first column of our selection which is our partID
            int selected = int.Parse(partView.Items[partView.SelectedIndices[0]].Text);
            if (modifyPart == null || modifyPart.IsDisposed)
            {
                modifyPart = new PartForm(this);
                modifyPart.SetModify(inventory.LookupPart(selected));
                modifyPart.Show();
            }
            else
            {
                modifyPart.BringToFront();
            }
        }
        private void PartDelete_Click(object sender, EventArgs e)
        {
            //  Delete part from partView ListView.
            if (partView.SelectedIndices.Count <= 0)
            {
                //  nothing is selected.
                MessageBox.Show("Must select a part to delete.", "Inventory Management System");
                return;
            }
            else
            {
                //  We shouldn't delete a part if it is associated to a Product.
                bool associated = false;
                int partID = int.Parse(partView.Items[partView.SelectedIndices[0]].Text);
                //  check all associated parts of every product.
                //  Products is a bindinglist of all products which has an AssociatedParts bindinglist of parts.
                foreach (Product product in inventory.Products)
                {
                    foreach (Part part in product.AssociatedParts)
                    {
                        if (part.PartID == partID)
                        {
                            //  Found a matching partID.
                            //  Change bool and jump out of nested loop.
                            associated = true;
                            goto End;
                        }         
                    }
                }
                End:
                if (associated)
                {
                    //  associated == true, can not delete.
                    MessageBox.Show("Unable to delete part while it is associated to a product.", "Inventory Management System");
                    return;
                }
                else
                {
                    //  associated == false, can delete.
                    var confirmDelete = MessageBox.Show("Are you sure you want to delete this part?", "Inventory Management System", MessageBoxButtons.OKCancel);
                    if (confirmDelete == DialogResult.OK)
                    {

                        inventory.DeletePart(inventory.LookupPart(partID));
                        this.UpdatePartView();
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }
        private void ProductAdd_Click(object sender, EventArgs e)
        {
            //  Product Add Button.
            if (addProduct == null || addProduct.IsDisposed)
            {
                addProduct = new ProductForm(this);
                addProduct.SetAdd(Color.IndianRed, inventory.AllParts, inventory.ProductIndex);
                addProduct.Show();
            }
            else
            {
                addProduct.BringToFront();
            }
        }
        private void ProductModify_Click(object sender, EventArgs e)
        {
            //  Product Modify Button.
            if (productView.SelectedIndices.Count <= 0)
            {
                //  Nothing selected in productView, don't open ProductForm.
                MessageBox.Show("Must select a product to modify.", "Inventory Management System");
                return;
            }
            //  productView.SelectedIndices[0] is the index of the selection in our listview.
            //  get the text from the first column of our selection which is our productID
            int selected = int.Parse(productView.Items[productView.SelectedIndices[0]].Text);
            string[] pass = new string[]
            {
                inventory.LookupProduct(selected).ProductID.ToString(),
                inventory.LookupProduct(selected).Name,
                inventory.LookupProduct(selected).InStock.ToString(),
                inventory.LookupProduct(selected).Price.ToString(),
                inventory.LookupProduct(selected).Max.ToString(),
                inventory.LookupProduct(selected).Min.ToString(),
            };
            if (modifyProduct == null || modifyProduct.IsDisposed)
            {
                modifyProduct = new ProductForm(this);
                modifyProduct.SetModify(pass,inventory.AllParts,(inventory.LookupProduct(selected)).AssociatedParts);
                modifyProduct.Show();
            }
            else
            {
                modifyProduct.BringToFront();
            }
        }

        private void MainExit_Click(object sender, EventArgs e)
        {
            //  Exit button.
            this.Dispose();
        }

        public void UpdatePartView()
        {
            ListViewItem item;
            //  clear items.
            partView.Items.Clear();
            //  Iterate through AllParts and populate data in partView.
            for (int i = 0; i < inventory.AllParts.Count; i++)
            {
                item = new ListViewItem((inventory.AllParts[i].PartID).ToString());
                item.SubItems.Add(inventory.AllParts[i].Name);
                item.SubItems.Add((inventory.AllParts[i].InStock).ToString());
                item.SubItems.Add((inventory.AllParts[i].Price).ToString());
                item.SubItems.Add((inventory.AllParts[i].Min).ToString());
                item.SubItems.Add((inventory.AllParts[i].Max).ToString());
                partView.Items.Add(item);
            }
        }
        public void UpdateProductView()
        {
            ListViewItem item;
            //  clear items.
            productView.Items.Clear();
            for (int i = 0; i < inventory.Products.Count; i++)
            {
                item = new ListViewItem((inventory.Products[i].ProductID).ToString());
                item.SubItems.Add(inventory.Products[i].Name);
                item.SubItems.Add((inventory.Products[i].InStock).ToString());
                item.SubItems.Add((inventory.Products[i].Price).ToString());
                item.SubItems.Add((inventory.Products[i].Min).ToString());
                item.SubItems.Add((inventory.Products[i].Max).ToString());
                productView.Items.Add(item);
            }
        }
        public void SavePart(dynamic tempPart)
        {
            //  SavePart called in PartForm to save part.
            if (tempPart.PartID == inventory.PartIndex)
            {
                //  This should be a new item and not an updated to an existing item.
                inventory.AddPart(tempPart);
            }
            else
            {
                //  Update to existing item.
                //  identifier to get index reference of part from AllParts.
                int identifier = 0;
                for (int i = 0; i < inventory.AllParts.Count; i++)
                {
                    if (inventory.AllParts[i].PartID == tempPart.PartID)
                    {
                        identifier = i;
                        break;
                    }
                }
                inventory.UpdatePart(identifier, tempPart);
            }
        }
        public void SaveProduct(string[] temp)
        {
            //  SaveProduct called in ProductForm to save product.
            Product tempProd = new Product
            {
                ProductID = int.Parse(temp[0]),
                Name = temp[1],
                InStock = int.Parse(temp[2]),
                Price = decimal.Parse(temp[3]),
                Max = int.Parse(temp[4]),
                Min = int.Parse(temp[5])
            };
            if (int.Parse(temp[0]) == inventory.ProductIndex)
            {
                //  This should be a new item and not an updated to an existing item.
                inventory.AddProduct(tempProd);
                inventory.LookupProduct(int.Parse(temp[0])).AssociatedParts = new BindingList<Part>();
            }
            else
            {
                //  Update to existing item.
                //  identifier to get index reference of product from Products.
                int identifier = 0;
                for (int i = 0; i < inventory.Products.Count; i++)
                {
                    if (inventory.Products[i].ProductID == int.Parse(temp[0]))
                    {
                        identifier = i;
                        break;
                    }
                }
                inventory.UpdateProduct(identifier, tempProd);
                //  UpdateProduct nulls our Product.AssociatedParts, create new.
                inventory.LookupProduct(int.Parse(temp[0])).AssociatedParts = new BindingList<Part>();
            }
        }
        private void ProductDelete_Click(object sender, EventArgs e)
        {
            //  Delete product selected in productView ListView.
            if (productView.SelectedIndices.Count <= 0)
            {
                //  nothing is selected.
                MessageBox.Show("Must select a product to delete.", "Inventory Management System");
                return;
            }
            else
            {
                int productID = int.Parse(productView.Items[productView.SelectedIndices[0]].Text);
                var confirmDelete = MessageBox.Show("Are you sure you want to delete this product?", "Inventory Management System", MessageBoxButtons.OKCancel);
                if (confirmDelete == DialogResult.OK)
                {

                    inventory.RemoveProduct(productID);
                    this.UpdateProductView();
                }
                else
                {
                    return;
                }
            }
        }
        public bool ProductAddAssociated(int prodID, int partID)
        {
            //  Add partID to ProductID Associated Parts
            //  Fail if already an associated Part.
            for (int i = 0; i < (inventory.LookupProduct(prodID)).AssociatedParts.Count; i++)
            {
                if (inventory.LookupProduct(prodID).AssociatedParts[i].PartID == partID)
                {
                    //  partID already in Product Associated Parts.
                    return false;
                }
            }
            (inventory.LookupProduct(prodID)).AddAssociatedPart(inventory.LookupPart(partID));
            return true;
        }
        public void ProductRemoveAssociated(int prodID)
        {
            //  Remove all Associated Parts for prodID.
            //  Seems faster than iterating and using RemoveAssociatedPart.
            if (inventory.LookupProduct(prodID).AssociatedParts is null)
            {
                //  ProductID passed in has no AssociatedParts
            }
            else
            {
                inventory.LookupProduct(prodID).AssociatedParts.Clear();
            }            
        }
        private void PartSearch_Click(object sender, EventArgs e)
        {
            //  Search partView listview object to match text from search field
            //  partView is our listview
            //  partSearchBox is our textbox
            if (partSearchBox.Text.Length == 0)
            {
                //
                MessageBox.Show("Enter text for search.","Inventory Management System");
                return;
            }
            else
            {
                for (int i = 0; i < partView.Items.Count; i++)
                {
                    if (partView.Items[i].SubItems[1].Text.Contains(partSearchBox.Text))
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
                PartSearch_Click(sender, e);
            }
        }
        private void ProductSearch_Click(object sender, EventArgs e)
        {
            //  Search productView listview object to match text from search field
            //  productView is our listview
            //  productSearchBox is our textbox

            if (productSearchBox.Text.Length == 0)
            {
                //
                MessageBox.Show("Enter text for search.", "Inventory Management System");
                return;
            }
            else
            {
                for (int i = 0; i < productView.Items.Count; i++)
                {
                    if (productView.Items[i].SubItems[1].Text.Contains(productSearchBox.Text))
                    {
                        //  Found search text in part name fields.
                        productView.Items[i].Selected = true;
                        productView.Focus();
                        return;
                    }
                    else
                    {
                        //  No match.                    
                    }
                }
            }
        }
        private void TextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ProductSearch_Click(sender, e);
            }
        }
        private void ProductView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            //  Prevent listview column width changes.
            e.NewWidth = productView.Columns[e.ColumnIndex].Width;
            e.Cancel = true;            
        }
        private void PartView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            //  Prevent listview column width changes.
            e.NewWidth = partView.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }
        //  -----------------------------------------------------
        //  End of Class
        //  -----------------------------------------------------
    }
}