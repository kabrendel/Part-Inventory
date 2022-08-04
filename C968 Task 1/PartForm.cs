using System;
using System.Drawing;
using System.Windows.Forms;

namespace C968_Task_1
{
    public partial class PartForm : Form
    {
        //  object reference for Form1
        readonly Main main = null;
        //  Constructor
        public PartForm(Main main)
        {
            InitializeComponent();
            this.main = main;
            this.Location = main.Location;
        }
        public void SetAdd(Color color, int index)
        {
            //  Change color of entry fields when using form to "Add" parts.
            partID.Text = index.ToString();
            partName.BackColor = color;
            partInventory.BackColor = color;
            partCost.BackColor = color;
            partMin.BackColor = color;
            partMax.BackColor = color;
            partMachine.BackColor = color;
            partButtonSave.Enabled = false;
        }
        public void SetModify(dynamic temp)
        {
            //  Update textbox text to data from object.
            partID.Text = temp.PartID.ToString();
            partName.Text = temp.Name;
            partInventory.Text = temp.InStock.ToString();
            partCost.Text = temp.Price.ToString();
            partMax.Text = temp.Max.ToString();
            partMin.Text = temp.Min.ToString();
            if (temp.GetType() == typeof(Inhouse))
            {
                partRadioIn.Checked = true;
                partMachine.Text = temp.MachineID.ToString();
            }
            else if (temp.GetType() == typeof(Outsourced))
            {
                partRadioOut.Checked = true;
                partMachine.Text = temp.CompanyName;
            }
            else
            {
                //  Error with object type.
                MessageBox.Show("Potential issue with part.","Part Form");
                partRadioIn.Checked = true;
                partMachine.Text = "";
            }
            labelTitle.Text = "Modify Part";    //  Top left window text label.
            partButtonSave.Enabled = true;
        }
        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton)
            {
                RadioButton radioButton = (RadioButton)sender;
                if (radioButton.Checked)
                {
                    labelMachine.Text = "Machine ID";
                    //  partMachine should be an int.
                    if (int.TryParse(partMachine.Text, out _))
                    {
                        //  text can be converted to a number
                        partMachine.BackColor = Color.White;
                        partButtonSave.Enabled = true;
                    }
                    else
                    {
                        partMachine.BackColor = Color.IndianRed;
                        partButtonSave.Enabled = false;
                    }
                }
            }
        }
        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton)
            {
                RadioButton radioButton = (RadioButton)sender;
                if (radioButton.Checked)
                {
                    labelMachine.Text = "Company ID";
                    //  partMachine should be a string.
                    if (int.TryParse(partMachine.Text, out _))
                    {
                        //  text can be converted to a number
                        partMachine.BackColor = Color.IndianRed;
                        partButtonSave.Enabled = false;
                    }
                    else
                    {
                        if ((partMachine.Text).Length == 0)
                        {
                            partMachine.BackColor = Color.IndianRed;
                        }
                        else
                        {
                            partMachine.BackColor = Color.White;
                            partButtonSave.Enabled = true;
                        }
                    }
                }
            }
        }
        private void ButtonPartSave(object sender, EventArgs e)
        {
            //  Save button clicked.
            //  Do some data validation then pass data out as a part object to save.
            //
            //  check partMachine data to make sure it matches expectations from radio button state.
            //
            if (partRadioIn.Checked)
            {
                if (!int.TryParse(partMachine.Text, out _))
                {
                    //  partMachine does not parse to integer as expected.
                    partButtonSave.Enabled = false;
                    MessageBox.Show("MachineID does not match expected format.", "Part Form");
                    return;
                }
            }
            else if(partRadioOut.Checked)
            {
                if (int.TryParse(partMachine.Text, out _))
                {
                    //  partMachine parses to integer when string expected.
                    partButtonSave.Enabled = false;
                    MessageBox.Show("Company name does not match expected format.", "Part Form");
                    return;
                }    
            }
            //
            //  data check textboxes.
            //
            if (int.TryParse(partName.Text, out _))
            {
                //  Name can be converted to a number.
                partButtonSave.Enabled = false;
                MessageBox.Show("Part name does not match expected format.", "Part Form");
                return;
            }
            else if (!decimal.TryParse(partCost.Text, out _))
            {
                //  Cost does not parse as a decimal.
                partButtonSave.Enabled = false;
                MessageBox.Show("Cost does not match expected format.", "Part Form");
                return;
            }
            else if (!(int.TryParse(partInventory.Text, out _)) || !(int.TryParse(partMax.Text, out _)) || !(int.TryParse(partMin.Text, out _)))
            {
                //  A numeric field does not parse to an int.
                partButtonSave.Enabled = false;
                MessageBox.Show("Inventory out of range.", "Part Form");
                return;
            }
            //
            //  Maximum inventory should be greater than minimum.
            //
            if (int.Parse(partMin.Text) > int.Parse(partMax.Text))
            {

                partMin.BackColor = Color.IndianRed;
                partButtonSave.Enabled = false;
                MessageBox.Show("Minimum quantity should be smaller than Maximum quantity.", "Part Form");
                return;
            }
            //  partInventory should be between partMax and partMin.
            if ((int.Parse(partInventory.Text) < int.Parse(partMin.Text)) || (int.Parse(partInventory.Text) > int.Parse(partMax.Text)))
            {
                partInventory.BackColor = Color.IndianRed;
                partButtonSave.Enabled = false;
                MessageBox.Show("Inventory out of range.", "Part Form");
                return;
            }
            //  Create temporary part object
            if (partRadioIn.Checked)
            {
                Inhouse tempPart = new Inhouse
                {
                    PartID = int.Parse(partID.Text),
                    Name = partName.Text,
                    Price = decimal.Parse(partCost.Text),
                    InStock = int.Parse(partInventory.Text),
                    Min = int.Parse(partMin.Text),
                    Max = int.Parse(partMax.Text),
                    MachineID = int.Parse(partMachine.Text),
                };
                main.SavePart(tempPart);
            }
            else if (partRadioOut.Checked)
            {
                Outsourced tempPart = new Outsourced
                {
                    PartID = int.Parse(partID.Text),
                    Name = partName.Text,
                    Price = decimal.Parse(partCost.Text),
                    InStock = int.Parse(partInventory.Text),
                    Min = int.Parse(partMin.Text),
                    Max = int.Parse(partMax.Text),
                    CompanyName = partMachine.Text
                };
                main.SavePart(tempPart);
            }
            this.Dispose();
            main.UpdatePartView();
        }
        private void ButtonPartCancel(object sender, EventArgs e)
        {
            //  Cancel Button
            this.Dispose();
        }
        private void TextChange(object sender, EventArgs e)
        {
            //  Change background if textbox empty.
            //  Change background if doesn't match expected data type.
            //
            bool save = true;
            if (((TextBox)sender).TextLength == 0)
            {
                //  Textbox length is zero, change BackColor to indicate issue.
                ((TextBox)sender).BackColor = Color.IndianRed;
                save = false;
            }
            else
            {
                //  Textbox length is not zero.
                //  Check data in textbox.
                if (((TextBox)sender).Name == "partName")
                {
                    //  partName should be a string.
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
                else if ((((TextBox)sender).Name == "partInventory") || (((TextBox)sender).Name == "partMax") || (((TextBox)sender).Name == "partMin"))
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
                else if (((TextBox)sender).Name == "partCost")
                {
                    //  partCost expected to be of the decimal data format.
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
                else if (((TextBox)sender).Name == "partMachine")
                {
                    //  partMachine can be valid as an int32 or as a string.
                    //  Dependant on radiobutton partRadioIn, partRadioOut
                    if (partRadioIn.Checked)
                    {
                        //  partMachine should be an int32.
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
                    else if (partRadioOut.Checked)
                    {
                        //  partMachine should be a string.
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
                }
                else
                {
                    //  Kind of a catch all since all TextBox fields should be caught above.
                    ((TextBox)sender).BackColor = Color.White;
                }
            }
            if (save)
            {
                partButtonSave.Enabled = true;
            }
            else
            {
                partButtonSave.Enabled = false;
            }
        }
        //  End of Class.
    }
}